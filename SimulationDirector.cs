using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_Basketball_Simulator
{
    class SimulationDirector
    {

        //STATIC DATA RESOURCES
        private Resources appResources = new Resources();

        //SELECTION AND ORDER
        private SelectionAndOrder selectionAndOrder = new SelectionAndOrder();

        //BRACKETS
        private Brackets brackets = new Brackets();

        // DATES
        private DateTime currentSimulationDate = new DateTime(2020, 4, 3, 0, 0, 0, 0);
        private DateTime earliestGameDate = new DateTime(2020, 9, 1, 0, 0, 0, 0);

        //ARRAY OF TEAMS
        private Team[] teamsArray = new Team[353];

        //CONFERENCES
        private Conference[] conferenceArray = new Conference[32];

        //CHAMPIONSHIP TOURNAMENT
        private ChampionshipTournament championshipTournament = new ChampionshipTournament();

        //LIST OF PROBABILITY TO DETERMINE SCORE ADJUSTMENT
        //(determined by the bellcurve array)
        //(random number between is found in list)
        List<int> listProbabilityDistributionRange = new List<int>();

        //LIST OF SCORE ADJUSTMENTS
        //(determined by range of score)
        //(index from the probability list is used to find the score adjustment)
        List<int> listScoringDistributionRange = new List<int>();

        //DIVISION II SCHOOL OFFENSIVE SCORING AVERAGE
        private int divisionIIOffensiveScoringAverage = 0;

        //DIVISION II SCHOOL DEFENSIVE SCORING AVERAGE
        private int divisionIIDefensiveScoringAverage = 0;

        public SimulationDirector()
        {
            //FOR ALL TEAMS
            for (int teamIndex = 0; teamIndex < appResources.getLengthOfTeamNames(); teamIndex++)
            {
                //INITIALIZE TEAMS
                teamsArray[teamIndex] = new Team(
                    appResources.getTeamName(teamIndex), 
                    appResources.getTeamsConferenceName(teamIndex));
            } //END FOR

            //FOR ALL CONFERENCES
            for (int confIndex = 0; confIndex < appResources.getLengthOfConferenceNames(); confIndex++)
            {
                conferenceArray[confIndex] = new Conference(
                    appResources.getSeedStartRound(confIndex),
                    appResources.getSeedStartRow(confIndex),
                    appResources.getConferenceTournamentCode(confIndex));
            }//END FOR

            initializeCurrentSimulationDate(appResources.getProgramInitalStartDate());
        }

        public SimulationDirector(SimulationDirector simulationDirector)
        {
            //FOR ALL TEAMS
            for (int teamIndex = 0; teamIndex < appResources.getLengthOfTeamNames(); teamIndex++)
            {
                //INITIALIZE TEAMS
                teamsArray[teamIndex] = new Team(simulationDirector.getTeam(teamIndex));
            } //END FOR

            //FOR ALL CONFERENCES
            for (int confIndex = 0; confIndex < appResources.getLengthOfConferenceNames(); confIndex++)
            {
                conferenceArray[confIndex] = new Conference(
                                simulationDirector.getTournament(confIndex),
                                appResources.getSeedStartRound(confIndex),
                                appResources.getSeedStartRow(confIndex));
            }//END FOR

            //INITIALIZE CHAMPIONSHIP TOURNAMENT
            championshipTournament = new ChampionshipTournament(simulationDirector.getTournament());

            //ASSOCIATION WILL HAVE SCHEDULES
            //NEEDS INITIALIZED
            initializeAssociation();

            initializeCurrentSimulationDate(simulationDirector.getCurrentSimulationDate());
        }

        //---------------------------------------------------------------------
        //---------------------------------------------------------------------
        //CURRENT SIMULATION DATE----------------------------------------------
        //---------------------------------------------------------------------
        //---------------------------------------------------------------------

        public DateTime getCurrentSimulationDate()
        {
            return currentSimulationDate;
        } //END

        private void initializeCurrentSimulationDate(DateTime currentSimulationDate)
        {
            this.currentSimulationDate = new DateTime(
                                                currentSimulationDate.Year, 
                                                currentSimulationDate.Month, 
                                                currentSimulationDate.Day, 
                                                0, 0, 0, 0);
        } //END

        private void initializeEarliestGameDate(DateTime earliestGameDate)
        {
            this.earliestGameDate = new DateTime(
                                                earliestGameDate.Year,
                                                earliestGameDate.Month,
                                                earliestGameDate.Day,
                                                0, 0, 0, 0);
        } //END

        //---------------------------------------------------------------------
        //---------------------------------------------------------------------
        //NAMES----------------------------------------------------------------
        //---------------------------------------------------------------------
        //---------------------------------------------------------------------

        //TEAM NAME------------------------------------------------------------

        public string getTeamNameDisplay(int teamIndex)
        {
            return teamsArray[teamIndex].teamNameDisplay;
        } //END

        //CONFERENCE NAME------------------------------------------------------

        public string getConferenceNameDisplay(int teamIndex)
        {
            return teamsArray[teamIndex].conferenceNameDisplay;
        } //END

        //---------------------------------------------------------------------
        //---------------------------------------------------------------------
        //RATINGS--------------------------------------------------------------
        //---------------------------------------------------------------------
        //---------------------------------------------------------------------

        //OFFENSIVE RATING-----------------------------------------------------

        public double getOffensiveRating(int teamIndex)
        {
            return teamsArray[teamIndex].ratingOffensive;
        } //END

        public void setOffensiveRating(int teamIndex, double offensiveRating)
        {
            teamsArray[teamIndex].ratingOffensive = offensiveRating;
        } //END

        //DEFENSIVE RATING-----------------------------------------------------

        public double getDefensiveRating(int teamIndex)
        {
            return teamsArray[teamIndex].ratingDefensive;
        } //END

        public void setDefensiveRating(int teamIndex, double defensiveRating)
        {
            teamsArray[teamIndex].ratingDefensive = defensiveRating;
        } //END

        //---------------------------------------------------------------------
        //---------------------------------------------------------------------
        //SCORING AVERAGES-----------------------------------------------------
        //---------------------------------------------------------------------
        //---------------------------------------------------------------------

        //OFFENSIVE SCORING----------------------------------------------------

        public int getOffensivescoring(int teamIndex)
        {
            return teamsArray[teamIndex].offensiveScoringAverage;
        } //END

        public void setOffensivescoring(int teamIndex, int offensivescoring)
        {
            teamsArray[teamIndex].offensiveScoringAverage = offensivescoring;
        } //END

        //DEFENSIVE SCORING----------------------------------------------------

        public int getDefensivescoring(int teamIndex)
        {
            return teamsArray[teamIndex].defensiveScoringAverage;
        } //END

        public void setDefensivescoring(int teamIndex, int defensivescoring)
        {
            teamsArray[teamIndex].defensiveScoringAverage = defensivescoring;
        } //END

        //---------------------------------------------------------------------
        //---------------------------------------------------------------------
        //TEAM TOURNAMENTS-----------------------------------------------------
        //---------------------------------------------------------------------
        //---------------------------------------------------------------------

        //CONFERENCE TOURNAMENT SEED-------------------------------------------

        public int getConfTournSeed(int teamIndex)
        {
            return teamsArray[teamIndex].confTournSeed;
        } //END

        public void setConfTournSeed(int teamIndex, int confTournSeed)
        {
            teamsArray[teamIndex].confTournSeed = confTournSeed;
        } //END

        //CHAMPIONSHIP TOURNAMENT PARTICIPANT----------------------------------

        public Boolean getChampTournParticipant(int teamIndex)
        {
            return teamsArray[teamIndex].champTournParticipant;
        } //END

        public void setChampTournParticipant(int teamIndex, Boolean champTournParticipant)
        {
            teamsArray[teamIndex].champTournParticipant = champTournParticipant;
        } //END

        //CHAMPIONSHIP TOURNAMENT SEED-----------------------------------------

        public int getChampTournSeed(int teamIndex)
        {
            return teamsArray[teamIndex].champTournSeed;
        } //END

        public void setChampTournSeed(int teamIndex, int champTournSeed)
        {
            teamsArray[teamIndex].champTournSeed = champTournSeed;
        } //END

        //CHAMPIONSHIP TOURNAMENT REGION---------------------------------------

        public string getChampTournRegion(int teamIndex)
        {
            return teamsArray[teamIndex].champTournRegion;
        } //END

        public void setChampTournRegion(int teamIndex, string champTournRegion)
        {
            teamsArray[teamIndex].champTournRegion = champTournRegion;
        } //END

        //PLAY IN PARTICIPANT--------------------------------------------------

        public Boolean getPlayInParticipant(int teamIndex)
        {
            return teamsArray[teamIndex].playInParticipant;
        } //END

        public void setPlayInParticipant(int teamIndex, Boolean playInParticipant)
        {
            teamsArray[teamIndex].playInParticipant = playInParticipant;
        } //END

        //---------------------------------------------------------------------
        //---------------------------------------------------------------------
        //WINS AND LOSSES------------------------------------------------------
        //---------------------------------------------------------------------
        //---------------------------------------------------------------------

        //WINS-----------------------------------------------------------------

        public int getWins(int teamIndex)
        {
            return teamsArray[teamIndex].getWins();
        } //END

        //LOSSES---------------------------------------------------------------

        public int getLosses(int teamIndex)
        {
            return teamsArray[teamIndex].getLosses();
        } //END

        //CONFERENCE WINS------------------------------------------------------

        public int getConferenceWins(int teamIndex)
        {
            return teamsArray[teamIndex].getConferenceWins();
        } //END

        //CONFERENCE LOSSES----------------------------------------------------

        public int getConferenceLosses(int teamIndex)
        {
            return teamsArray[teamIndex].getConferenceLosses();
        } //END

        //---------------------------------------------------------------------
        //---------------------------------------------------------------------
        //SCHEDULE-------------------------------------------------------------
        //---------------------------------------------------------------------
        //---------------------------------------------------------------------

        //GET------------------------------------------------------------------

        public Schedule getSchedule(int teamIndex)
        {
            return teamsArray[teamIndex].getSchedule();
        }

        //SET------------------------------------------------------------------
        
        public void setSchedule(int teamIndex, Schedule schedule)
        {
            teamsArray[teamIndex].setSchedule(schedule);
        }

        //---------------------------------------------------------------------
        //---------------------------------------------------------------------
        //TEAMS----------------------------------------------------------------
        //---------------------------------------------------------------------
        //---------------------------------------------------------------------

        //GET------------------------------------------------------------------

        public Team[] getTeams()
        {
            //ARRAY OF TEAMS
            Team[] teamsArray = new Team[353];

            try
            {
                //FOR ALL TEAMS
                for (int teamIndex = 0; teamIndex < appResources.getLengthOfTeamNames(); teamIndex++)
                {
                    //INITIALIZE TEAM
                    teamsArray[teamIndex] = new Team(this.teamsArray[teamIndex]);
                } //END FOR

                return teamsArray;
            }
            finally
            {
                //FOR ALL TEAMS
                for (int teamIndex = 0; teamIndex < appResources.getLengthOfTeamNames(); teamIndex++)
                {
                    //DISPOSE TEAM
                    teamsArray[teamIndex].DisposeTeam();
                } //END FOR
            }//END FINALLY
        } //END

        public Team getTeam(int teamIndex)
        {
            //INITIALIZE TEAM
            Team team = new Team(this.teamsArray[teamIndex]);

            try
            {
                return team;
            }
            finally
            {
                team.DisposeTeam();
            }
        } //END

        //---------------------------------------------------------------------
        //---------------------------------------------------------------------
        //CONFERENCE TOURNAMENT AND CHAMPIONSHIP TOURNAMENT--------------------
        //---------------------------------------------------------------------
        //---------------------------------------------------------------------

        //---------------------------------------------------------------------
        //BRACKETS-------------------------------------------------------------
        //---------------------------------------------------------------------

        //CONFERENCE TOURNAMENT------------------------------------------------

        public string[] getConfTournBracket(int confIndex)
        {
            return brackets.getConferenceBracket(conferenceArray[confIndex].getTournament(), teamsArray, confIndex);
        } //END

        //PROJECTION CHAMPIONSHIP TOURNAMENT-----------------------------------

        public string[] getFullProjectedChampTournBracket()
        {
            updateProjection();

            return brackets.getChampionshipBracket(championshipTournament.getProjectionTournament(), teamsArray);
        } //END

        public string[] getSweet16ProjectedChampTournBracket()
        {
            updateProjection();

            return brackets.getChampionshipBracket(championshipTournament.getSweet16Tournament(), teamsArray);
        } //END

        public string[] getWestProjectedChampTournBracket()
        {
            updateProjection();

            return brackets.getChampionshipBracket(
                championshipTournament.getTournamentRegion(appResources.getChampTounRegionTypeText(0)) , 
                teamsArray, 
                appResources.getChampTounRegionTypeText(0));
        } //END

        public string[] getMidwestProjectedChampTournBracket()
        {
            updateProjection();

            return brackets.getChampionshipBracket(
                championshipTournament.getTournamentRegion(appResources.getChampTounRegionTypeText(1)),
                teamsArray,
                appResources.getChampTounRegionTypeText(1));
        } //END

        public string[] getEastProjectedChampTournBracket()
        {
            updateProjection();

            return brackets.getChampionshipBracket(
                championshipTournament.getTournamentRegion(appResources.getChampTounRegionTypeText(2)),
                teamsArray,
                appResources.getChampTounRegionTypeText(2));
        } //END

        public string[] getSouthProjectedChampTournBracket()
        {
            updateProjection();

            return brackets.getChampionshipBracket(
                championshipTournament.getTournamentRegion(appResources.getChampTounRegionTypeText(3)),
                teamsArray,
                appResources.getChampTounRegionTypeText(3));
        } //END

        private void updateProjection()
        {
            if (!selectionAndOrder.getContainerUpdated(currentSimulationDate))
            {
                selectionAndOrder.setChampTournTeamIndexes(teamsArray, conferenceArray, currentSimulationDate);

                championshipTournament = new ChampionshipTournament(
                    selectionAndOrder.getTournamentContainer().getRanked16ChampTournWestIndexes(),
                    selectionAndOrder.getTournamentContainer().getRanked16ChampTournMidwestIndexes(),
                    selectionAndOrder.getTournamentContainer().getRanked16ChampTournSouthIndexes(),
                    selectionAndOrder.getTournamentContainer().getRanked16ChampTournEastIndexes(),
                    selectionAndOrder.getTournamentContainer().get8PlayInIndexes(),
                    selectionAndOrder.getTournamentContainer().get8PlayInSeeds(),
                    selectionAndOrder.getTournamentContainer().get8PlayInRegions());
            }//END IF
        } //END

        //CHAMPIONSHIP TOURNAMENT----------------------------------------------

        public string[] getFullChampTournBracket()
        {
            return brackets.getChampionshipBracket(championshipTournament.getProjectionTournament(), teamsArray);
        } //END

        public string[] getSweet16ChampTournBracket()
        {
            return brackets.getChampionshipBracket(championshipTournament.getSweet16Tournament(), teamsArray);
        } //END

        public string[] getWestChampTournBracket()
        {
            return brackets.getChampionshipBracket(
                championshipTournament.getTournamentRegion(appResources.getChampTounRegionTypeText(0)),
                teamsArray,
                appResources.getChampTounRegionTypeText(0));
        } //END

        public string[] getMidwestChampTournBracket()
        {
            return brackets.getChampionshipBracket(
                championshipTournament.getTournamentRegion(appResources.getChampTounRegionTypeText(1)),
                teamsArray,
                appResources.getChampTounRegionTypeText(1));
        } //END

        public string[] getEastChampTournBracket()
        {
            return brackets.getChampionshipBracket(
                championshipTournament.getTournamentRegion(appResources.getChampTounRegionTypeText(2)),
                teamsArray,
                appResources.getChampTounRegionTypeText(2));
        } //END

        public string[] getSouthChampTournBracket()
        {
            return brackets.getChampionshipBracket(
                championshipTournament.getTournamentRegion(appResources.getChampTounRegionTypeText(3)),
                teamsArray,
                appResources.getChampTounRegionTypeText(3));
        } //END

        //---------------------------------------------------------------------
        //TOURNAMENT CONTAINER-------------------------------------------------
        //---------------------------------------------------------------------

        public void setTournamentContainer(TournamentContainer tournamentContainer)
        {
            selectionAndOrder = new SelectionAndOrder(tournamentContainer);
        } //END

        public TournamentContainer getTournamentContainer()
        {
            return selectionAndOrder.getTournamentContainer();
        } //END

        //---------------------------------------------------------------------
        //CONFERENCE TOURNAMENT------------------------------------------------
        //---------------------------------------------------------------------

        //GET------------------------------------------------------------------

        public int getNumberOfRounds(int conferenceIndex)
        {
            return conferenceArray[conferenceIndex].getNumberOfRounds();
        } //END

        public int getRoundLength(int conferenceIndex, int round)
        {
            return conferenceArray[conferenceIndex].getRoundLength(round);
        } //END

        public int getTeamIndex(int conferenceIndex, int round, int row)
        {
            return conferenceArray[conferenceIndex].getTeamIndex(round, row);
        } //END

        public int[][] getTournament(int conferenceIndex)
        {
            return conferenceArray[conferenceIndex].getTournament();
        } //END

        //SET------------------------------------------------------------------

        public void initializeTournament(int conferenceIndex, int[] arraysIntTeamIndexes)
        {
            conferenceArray[conferenceIndex].initializeTournament(arraysIntTeamIndexes);
        } //END

        public void initializeTournament(
            int conferenceIndex, 
            int[][] arraysIntTeamIndexes, 
            int[] arraysIntSeedStartRound,
            int[] arraysIntSeedStartRow)
        {
            conferenceArray[conferenceIndex].initializeTournament(
                arraysIntTeamIndexes,
                arraysIntSeedStartRound,
                arraysIntSeedStartRow);
        } //END

        //CONFERENCE CHAMPIONS-------------------------------------------------

        public int getConfTournChampTeamIndex(int conferenceIndex)
        {
            return conferenceArray[conferenceIndex].getConfTournChampTeamIndex();
        } //END

        public Boolean getConfTournChampSet(int conferenceIndex)
        {
            return conferenceArray[conferenceIndex].getConfTournChampSet();
        } //END

        //---------------------------------------------------------------------
        //CHAMPIONSHIP TOURNAMENT----------------------------------------------
        //---------------------------------------------------------------------

        //GET------------------------------------------------------------------

        public int getNumberOfRounds()
        {
            return championshipTournament.getNumberOfRounds();
        } //END

        public int getRoundLength(int round)
        {
            return championshipTournament.getRoundLength(round);
        } //END

        public int getTeamIndex(int round, int row)
        {
            return championshipTournament.getTeamIndex(round, row);
        } //END

        public int[][] getTournament()
        {
            return championshipTournament.getFullTournament();
        } //END

        //SET------------------------------------------------------------------

        public void initializeTournament(int[][] arraysIntTeamIndexes)
        {
            championshipTournament.initializeTournament(arraysIntTeamIndexes);
        } //END

        //---------------------------------------------------------------------
        //---------------------------------------------------------------------
        //SET SCHEDULE INDEXES AND CONFERENCE WINS AND LOSSES------------------
        //---------------------------------------------------------------------
        //---------------------------------------------------------------------

        //INITIALIZE ASSOCIATION-----------------------------------------------

        public void initializeAssociation()
        {
            //System.Windows.Forms.MessageBox.Show("INITIALIZE ASSOCIATION");

            //SET SCHEDULE INDEXES
            setScheduleIndexes();
        } //END

        //SET SCHEDULE INDEXES-------------------------------------------------

        public Boolean setScheduleIndexes()
        {
            //FOR ALL TEAMS
            for (int teamIndex = 0; teamIndex < appResources.getLengthOfTeamNames(); teamIndex++)
            {
                //Console.WriteLine("TEAM INDEX " + teamIndex + " LENGTH " + appResources.getLengthOfTeamNames());
                //FOR ALL ROWS IN REAL SCHEDULE
                for (int scheduleIndex = 0; scheduleIndex < teamsArray[teamIndex].getLengthOfSchedule(appResources.getScheduleTypeText(0)); scheduleIndex++)
                {
                    //Console.WriteLine("   SCHEDULE INDEX " + scheduleIndex + " LENGTH " + teamsArray[teamIndex].getLengthOfSchedule(appResources.getScheduleTypeText(0)));
                    setScheduleIndex(scheduleIndex, teamIndex, appResources.getScheduleTypeText(0));
                } //END FOR ALL SCHEDULE ROWS

                //FOR ALL ROWS IN SIM SCHEDULE
                for (int scheduleIndex = 0; scheduleIndex < teamsArray[teamIndex].getLengthOfSchedule(appResources.getScheduleTypeText(4)); scheduleIndex++)
                {
                    //Console.WriteLine("   SCHEDULE INDEX " + scheduleIndex + " LENGTH " + teamsArray[teamIndex].getLengthOfSchedule(appResources.getScheduleTypeText(4)));
                    setScheduleIndex(scheduleIndex, teamIndex, appResources.getScheduleTypeText(4));
                } //END FOR ALL SCHEDULE ROWS
            } //END FOR ALL TEAMS

            //RETURN SUCCESS
            return true;
        } //END

        private void setScheduleIndex(int scheduleIndex, int teamIndex, string scheduleType)
        {
            //TEAM INDEX 2
            int opponentIndex = -1;
            //ROW INDEX 2
            int oppScheduleIndex = -1;

            //IF TEAM IS DIV II SCHOOL
            //SET INDEX TO NON INDEX (-2)
            //ELSE IF INDEX HASN'T BEEN SET
            //FIND AND SET INDEXES
            if (string.Compare(teamsArray[teamIndex].getOpponentName(scheduleIndex, scheduleType), "DIV II SCHOOL") == 0)
            {
                //SET INDEX
                //Console.WriteLine("      DIV II");
                teamsArray[teamIndex].setOpponentRowIndex(scheduleIndex, scheduleType, -2);
            }
            else if (teamsArray[teamIndex].getOpponentRowIndex(scheduleIndex, scheduleType) == -1)
            {
                //GET OPPONENT INDEX
                opponentIndex = teamsArray[teamIndex].getOpponentIndex(scheduleIndex, scheduleType);
                //Console.WriteLine("      OPPONENT INDEX " + opponentIndex);
                //GET INDEX OF GAME FROM OPPONENT SCHEDULE
                oppScheduleIndex = teamsArray[opponentIndex].findIndexOf(
                    teamsArray[teamIndex].getDate(scheduleIndex, scheduleType),
                    scheduleType,
                    teamsArray[teamIndex].teamNameDisplay);
                //Console.WriteLine("      OPPONENT SCHEDULE INDEX " + oppScheduleIndex);

                //SET CORRESPONDING INDEXES
                //opponent indexes should already be set
                //SET ROW INDEXES
                //Console.WriteLine("         TEAM INDEX " + teamIndex + 
                //    " SCHEDULE INDEX " + scheduleIndex + 
                //    " OPPONENT INDEX " + opponentIndex + 
                //    " OPPONENT SCHEDULE INDEX " + oppScheduleIndex);
                teamsArray[teamIndex].setOpponentRowIndex(scheduleIndex, scheduleType, oppScheduleIndex);
                teamsArray[opponentIndex].setOpponentRowIndex(oppScheduleIndex, scheduleType, scheduleIndex);
            } //END
        } //END

        //---------------------------------------------------------------------
        //---------------------------------------------------------------------
        //SIMULATE-------------------------------------------------------------
        //---------------------------------------------------------------------
        //---------------------------------------------------------------------

        //---------------------------------------------------------------------
        //SIMULATION FUNCTIONS-------------------------------------------------
        //---------------------------------------------------------------------

        //INITIALIZE SIMULATION------------------------------------------------

        public void initializeSimulationProbabilities(SettingsDirector settingsDirector)
        {
            System.Windows.Forms.MessageBox.Show("INITIALIZE PROBABILITIES");

            //INITIALIZE SCORING AVERAGES
            initializeScoringAverages(settingsDirector);

            //INITIALIZE SCORING DISTRIBUTION RANGE
            initializeScoringDistributionRange(settingsDirector);

            //INITIALIZE EARLIEST GAME DATE
            initializeEarliestGameDate(settingsDirector.getEarliestGameDate());

        } //END

        private void initializeScoringAverages(SettingsDirector settingsDirector)
        {

            //AVERAGE OFFENSIVE POINTS MULTIPLIER
            double averageOffensivePointsMultiplier =
                (settingsDirector.maxScoringAverage - settingsDirector.minScoringAverage) /
                (settingsDirector.getHighestOffensiveRating() - settingsDirector.getLowestOffensiveRating());

            //AVERAGE DEFFENSIVE POINTS MULTIPLIER
            double averageDeffensivePointsMultiplier =
                (settingsDirector.maxScoringAverage - settingsDirector.minScoringAverage) /
                (settingsDirector.getHighestDefensiveRating() - settingsDirector.getLowestDefensiveRating());

            //FOR ALL TEAMS
            for (int teamIndex = 0; teamIndex < appResources.getLengthOfTeamNames(); teamIndex++)
            {
                //INITIALIZE OFFENSIVE SCORING AVERAGE
                teamsArray[teamIndex].offensiveScoringAverage = settingsDirector.minScoringAverage +
                    Convert.ToInt32(
                        (teamsArray[teamIndex].ratingOffensive - settingsDirector.getLowestOffensiveRating()) * 
                        averageOffensivePointsMultiplier);

                //INITIALIZE DEFFENSIVE SCORING AVERAGE
                teamsArray[teamIndex].defensiveScoringAverage = settingsDirector.minScoringAverage +
                    Convert.ToInt32(
                        (teamsArray[teamIndex].ratingDefensive - settingsDirector.getLowestDefensiveRating()) *
                        averageDeffensivePointsMultiplier);

            } //END FOR

            divisionIIOffensiveScoringAverage = settingsDirector.minScoringAverage;

            divisionIIDefensiveScoringAverage = settingsDirector.maxScoringAverage;

        } //END

        private void initializeScoringDistributionRange(SettingsDirector settingsDirector)
        {
            //NEGATIVE SIDE
            List<int> negativeSide = new List<int>();

            //POSITIVE SIDE
            List<int> positiveSide = new List<int>();

            //INCREMENT
            double increment = 0.0;

            //BELL CURVE LENGTH LENGTH
            int bellCurveLength = appResources.getLengthOfBellCurve();

            //HALF LENGTH
            int halfLength = settingsDirector.scoringDistribution;

            //SET HALF LENGTH
            if (halfLength % 2 == 0)
            {
                //ADD 2 FOR ZEROS
                //DIVIDE BY 2
                halfLength = (halfLength + 2)/2;
            }
            else
            {
                //ADD 3, 2 FOR ZEROS AND 1 TO EVEN EACH SIDE
                //DIVIDE BY 2
                halfLength = (halfLength + 3)/2;
            }//END IF

            //SET INCREMENT
            increment = bellCurveLength / (halfLength * 2);

            //FOR HALF THE PROBABILITY DISTRIBUTION
            //FILL PROBABILITY DISTRIBUTION
            for (int index = 0; index < halfLength; index++)
            {
                negativeSide.Add(appResources.getBellCurveValue(((int)((index + 1) * increment)) - 1));
                positiveSide.Add(appResources.getBellCurveValue((bellCurveLength - (int)(index * increment)) - 1));
            }//END FOR

            //CLEAR DATA
            listProbabilityDistributionRange.Clear();

            //FOR HALF THE PROBABILITY DISTRIBUTION
            //ADD NEGATIVE SIDE TO DISTRIBUTION
            for (int index = 0; index < halfLength; index++)
            {
                listProbabilityDistributionRange.Add(negativeSide[index]);
            }//END FOR

            //FOR HALF THE PROBABILITY DISTRIBUTION
            //ADD POSITIVE SIDE TO DISTRIBUTION
            for (int index = halfLength - 1; index >= 0; index--)
            {
                listProbabilityDistributionRange.Add(positiveSide[index]);
            }//END FOR

            //CLEAR DATA
            listScoringDistributionRange.Clear();

            //SET SCORE ADJUSTMENTS NEGATIVE SIDE
            for (int index = 0; index < halfLength; index++)
            {
                listScoringDistributionRange.Add((halfLength - 1 - index) * -1);
            }//END FOR

            //SET SCORE ADJUSTMENTS POSITIVE SIDE
            for (int index = 0; index < halfLength; index++)
            {
                listScoringDistributionRange.Add(index);
            }//END FOR

        } //END

        //GET POINTS-----------------------------------------------------------

        private int getScoreAdjustment()
        {
            //RANDOM NUMBER GENERATOR
            Random random = new Random();

            //DISTRIBUTION NUMBER
            int probability = random.Next(10000);

            //FOR THE PROBABILITY DISTRIBUTION
            //EXIT WHEN SCORE FOUND
            for (int index = 0; index < listProbabilityDistributionRange.Count; index++)
            {
                if (listProbabilityDistributionRange[index] >= probability)
                {
                    return listScoringDistributionRange[index];
                }//END IF
                
            }//END FOR

            //DISPLAY ERROR MESSAGE
            System.Windows.Forms.MessageBox.Show("SCORE ADJUSTMENT ERROR");

            //RETURN LAST ADJUSTMENT
            return listScoringDistributionRange[listScoringDistributionRange.Count - 1];

        } //END

        private int getPoints(int offensivePoints, int deffensivePoints)
        {
            //RETURN POINTS SCORED
            return Convert.ToInt32((double)(offensivePoints + getScoreAdjustment() + deffensivePoints + getScoreAdjustment()) / 2.0);
        } //END

        //---------------------------------------------------------------------
        //SIMULATION MENU BUTTONS----------------------------------------------
        //---------------------------------------------------------------------

        //SIM TO---------------------------------------------------------------

        public Boolean simTo(DateTime goToDate)
        {
            if (0 > DateTime.Compare(goToDate, currentSimulationDate))
            {
                resetOneDay();

                currentSimulationDate.AddDays(-1.0);

                while (0 > DateTime.Compare(goToDate, currentSimulationDate))
                {
                    resetOneDay();

                    currentSimulationDate.AddDays(-1.0);
                }//END WHILE
            }
            else if (0 < DateTime.Compare(goToDate, currentSimulationDate))
            {
                advanceSimGamesOneDay();

                currentSimulationDate.AddDays(1.0);

                while (0 < DateTime.Compare(goToDate, currentSimulationDate))
                {
                    advanceSimGamesOneDay();

                    currentSimulationDate.AddDays(1.0);
                }//END WHILE 
            }//END IF

            return true;
        } //END

        //START FROM-----------------------------------------------------------

        public Boolean startFrom(DateTime startFromDate)
        {
            while (0 > DateTime.Compare(earliestGameDate, currentSimulationDate))
            {
                resetOneDay();

                currentSimulationDate.AddDays(-1.0);
            }//END WHILE

            addRealGames(startFromDate);

            while (0 < DateTime.Compare(startFromDate, currentSimulationDate))
            {
                advanceSimGamesOneDay();

                currentSimulationDate.AddDays(1.0);
            }//END WHILE

            return true;
        } //END

        //ADVANCE ONE DAY------------------------------------------------------

        private void advanceSimGamesOneDay()
        {
            brackets.resetProjectionUpdatedStates();

            if (0 > DateTime.Compare(currentSimulationDate, appResources.getConferenceTournamentStartDate()))
            {
                //SEASON
                simulateDay();
            }
            else if (0 <= DateTime.Compare(currentSimulationDate, appResources.getConferenceTournamentStartDate()) &&
                0 > DateTime.Compare(currentSimulationDate, appResources.getChampionshipTournamentStartDate()))
            {
                //CONFERENCE TOURNAMENT
                initializeConferenceTournaments();
                addConfTournGamesToSchedule();
                simulateDay();
                advanceConfTournRound();
            }
            else if (0 <= DateTime.Compare(currentSimulationDate, appResources.getChampionshipTournamentStartDate()))
            {
                //CHAMPIONSHIP TOURNAMENT
                initializeChampionshipTournament();
                addChampTournGamesToSchedule();
                simulateDay();
                advanceChampTournRound();
            }//END IF
        } //END

        private void initializeConferenceTournaments()
        {
            //TEAM INDEXES ARRAY ORDERED BY SEED
            int[] arraySeedTeamIndexes;

            for (int conferenceIndex = 0; conferenceIndex < appResources.getLengthOfConferenceNames(); conferenceIndex++)
            {
                if (0 == DateTime.Compare(currentSimulationDate, appResources.getConferenceTournamentStartDate(conferenceIndex)))
                {
                    int [] arrayConfTeamIndexes = appResources.getConferenceTeamIndexes(conferenceIndex);

                    arraySeedTeamIndexes = new int[arrayConfTeamIndexes.Length];

                    int[] arrayOrder = selectionAndOrder.getOrderIndexes(
                        selectionAndOrder.getConferenceOrderValues(teamsArray, conferenceIndex),
                        arraySeedTeamIndexes.Length);

                    for (int teamIndex = 0; teamIndex < arraySeedTeamIndexes.Length; teamIndex++)
                    {
                        arraySeedTeamIndexes[teamIndex] = arrayConfTeamIndexes[arrayOrder[teamIndex]];

                        teamsArray[arraySeedTeamIndexes[teamIndex]].confTournSeed = teamIndex;
                    }//END FOR

                    conferenceArray[conferenceIndex].initializeTournament(arraySeedTeamIndexes);
                }//END IF
            }//END FOR
        } //END

        private void initializeChampionshipTournament()
        {
            int westIndex = 0;
            int midwestIndex = 0;
            int southIndex = 0;
            int eastIndex = 0;
            int playInIndex = 0;

            if (0 == DateTime.Compare(currentSimulationDate, appResources.getChampionshipTournamentStartDate()))
            {
                if (!selectionAndOrder.getContainerUpdated(currentSimulationDate))
                {
                    selectionAndOrder.setChampTournTeamIndexes(teamsArray, conferenceArray, currentSimulationDate);
                }//END IF

                for (int index = 0; index < 16; index++)
                {
                    westIndex = selectionAndOrder.getTournamentContainer().getRanked16ChampTournWestIndexes()[index];
                    midwestIndex = selectionAndOrder.getTournamentContainer().getRanked16ChampTournMidwestIndexes()[index];
                    southIndex = selectionAndOrder.getTournamentContainer().getRanked16ChampTournSouthIndexes()[index];
                    eastIndex = selectionAndOrder.getTournamentContainer().getRanked16ChampTournEastIndexes()[index];

                    teamsArray[westIndex].champTournParticipant = true;
                    teamsArray[midwestIndex].champTournParticipant = true;
                    teamsArray[southIndex].champTournParticipant = true;
                    teamsArray[eastIndex].champTournParticipant = true;

                    teamsArray[westIndex].champTournSeed = index;
                    teamsArray[midwestIndex].champTournSeed = index;
                    teamsArray[southIndex].champTournSeed = index;
                    teamsArray[eastIndex].champTournSeed = index;

                    teamsArray[westIndex].champTournRegion = appResources.getChampTounRegionTypeText(0);
                    teamsArray[midwestIndex].champTournRegion = appResources.getChampTounRegionTypeText(1);
                    teamsArray[southIndex].champTournRegion = appResources.getChampTounRegionTypeText(2);
                    teamsArray[eastIndex].champTournRegion = appResources.getChampTounRegionTypeText(3);

                    teamsArray[westIndex].playInParticipant = false;
                    teamsArray[midwestIndex].playInParticipant = false;
                    teamsArray[southIndex].playInParticipant = false;
                    teamsArray[eastIndex].playInParticipant = false;
                }//END FOR ALL 16 SEEDS

                for (int index = 0; index < selectionAndOrder.getTournamentContainer().get8PlayInIndexes().Length; index++)
                {
                    playInIndex = selectionAndOrder.getTournamentContainer().get8PlayInIndexes()[index];

                    teamsArray[playInIndex].champTournParticipant = true;
                    teamsArray[playInIndex].champTournSeed = selectionAndOrder.getTournamentContainer().get8PlayInSeeds()[index];
                    teamsArray[playInIndex].champTournRegion = selectionAndOrder.getTournamentContainer().get8PlayInRegions()[index];
                    teamsArray[playInIndex].playInParticipant = true;
                }//END FOR ALL PLAY IN TEAMS

                championshipTournament = new ChampionshipTournament(
                    selectionAndOrder.getTournamentContainer().getRanked16ChampTournWestIndexes(),
                    selectionAndOrder.getTournamentContainer().getRanked16ChampTournMidwestIndexes(),
                    selectionAndOrder.getTournamentContainer().getRanked16ChampTournSouthIndexes(),
                    selectionAndOrder.getTournamentContainer().getRanked16ChampTournEastIndexes(),
                    selectionAndOrder.getTournamentContainer().get8PlayInIndexes(),
                    selectionAndOrder.getTournamentContainer().get8PlayInSeeds(),
                    selectionAndOrder.getTournamentContainer().get8PlayInRegions()); 
            }//END IF
        } //END

        private void addConfTournGamesToSchedule()
        {
            int currentRound = 0;

            string teamName1 = "";
            string teamName2 = "";
            int teamIndex1 = 0;
            int teamIndex2 = 0;
            int teamRowIndex1 = 0;
            int teamRowIndex2 = 0;

            for (int confIndex = 0; confIndex < appResources.getLengthOfConferenceNames(); confIndex++)
            {
                if (conferenceArray[confIndex].getTournFilled() && !conferenceArray[confIndex].getConfTournChampSet())
                {
                    currentRound = conferenceArray[confIndex].getCurrentRound();

                    for (int rowIndex = 0; rowIndex < conferenceArray[confIndex].getCurrentRoundLength(); rowIndex+=2)
                    {
                        teamIndex1 = conferenceArray[confIndex].getTeamIndex(currentRound, rowIndex);
                        teamIndex2 = conferenceArray[confIndex].getTeamIndex(currentRound, rowIndex + 1);
                        teamName1 = teamsArray[teamIndex1].teamNameDisplay;
                        teamName2 = teamsArray[teamIndex2].teamNameDisplay;
                        teamRowIndex1 = teamsArray[teamIndex1].getLengthOfSchedule(appResources.getScheduleTypeText(4));
                        teamRowIndex2 = teamsArray[teamIndex2].getLengthOfSchedule(appResources.getScheduleTypeText(4));

                        teamsArray[teamIndex1].addSimConfTournGame(
                            currentSimulationDate,
                            teamName2,
                            teamIndex2,
                            teamRowIndex2,
                            0,
                            0,
                            currentRound,
                            rowIndex
                            );

                        teamsArray[teamIndex2].addSimConfTournGame(
                            currentSimulationDate,
                            teamName1,
                            teamIndex1,
                            teamRowIndex1,
                            0,
                            0,
                            currentRound,
                            rowIndex
                            );
                    }//END FOR ALL ROWS
                }//END IF
            }//END FOR ALL CONFERENCES
        } //END

        private void addChampTournGamesToSchedule()
        {
            int currentRound = 0;

            string teamName1 = "";
            string teamName2 = "";
            int teamIndex1 = 0;
            int teamIndex2 = 0;
            int teamRowIndex1 = 0;
            int teamRowIndex2 = 0; 
            
            currentRound = championshipTournament.getCurrentRound();

            if (!championshipTournament.getTournChampSet() && 
                0 == DateTime.Compare(currentSimulationDate, appResources.getChampionshipTournamentDates(currentRound)) &&
                championshipTournament.getTournFilled())
            {
                for (int rowIndex = 0; rowIndex < championshipTournament.getCurrentRoundLength(); rowIndex += 2)
                {
                    teamIndex1 = championshipTournament.getTeamIndex(currentRound, rowIndex);
                    teamIndex2 = championshipTournament.getTeamIndex(currentRound, rowIndex + 1);
                    teamName1 = teamsArray[teamIndex1].teamNameDisplay;
                    teamName2 = teamsArray[teamIndex2].teamNameDisplay;
                    teamRowIndex1 = teamsArray[teamIndex1].getLengthOfSchedule(appResources.getScheduleTypeText(4));
                    teamRowIndex2 = teamsArray[teamIndex2].getLengthOfSchedule(appResources.getScheduleTypeText(4));

                    teamsArray[teamIndex1].addSimChampTournGame(
                        currentSimulationDate,
                        teamName2,
                        teamIndex2,
                        teamRowIndex2,
                        0,
                        0,
                        currentRound,
                        rowIndex
                        );

                    teamsArray[teamIndex2].addSimChampTournGame(
                        currentSimulationDate,
                        teamName1,
                        teamIndex1,
                        teamRowIndex1,
                        0,
                        0,
                        currentRound,
                        rowIndex
                        );
                }//END FOR ALL ROWS
            }//END IF
        } //END

        private void simulateDay()
        {
            int teamRowIndex = 0;

            int opponentIndex = 0;
            int opponentRowIndex = 0;

            int currentRound = 0;

            if (0 > DateTime.Compare(currentSimulationDate, appResources.getChampionshipTournamentStartDate()))
            {
                //REGULAR SEASON AND CONFERENCE TOURNAMENTS

                for (int teamIndex = 0; teamIndex < appResources.getLengthOfTeamNames(); teamIndex++)
                {
                    if (!teamsArray[teamIndex].getAllGamesPlayed())
                    {
                        teamRowIndex = teamsArray[teamIndex].getNextGameIndex();

                        if (0 == DateTime.Compare(
                                currentSimulationDate, 
                                teamsArray[teamIndex].getDate(teamRowIndex, appResources.getScheduleTypeText(4))) &&
                            0 == string.Compare(
                                appResources.getGameResultTypeText(0), 
                                teamsArray[teamIndex].getGameResult(teamRowIndex, appResources.getScheduleTypeText(4)))
                            )
                        {
                            //SIMULATE GAME

                            opponentIndex = teamsArray[teamIndex].getOpponentIndex(teamRowIndex, appResources.getScheduleTypeText(4));
                            opponentRowIndex = teamsArray[teamIndex].getOpponentRowIndex(teamRowIndex, appResources.getScheduleTypeText(4));

                            simulateGame(teamIndex, opponentIndex, teamRowIndex, opponentRowIndex);
                        }//END IF

                    }//END IF
                }//END FOR ALL TEAMS
            }
            else
            {
                //CHAMPIONSHIP TOURNAMENT

                currentRound = championshipTournament.getCurrentRound();

                if (!championshipTournament.getTournChampSet() &&
                    0 == DateTime.Compare(currentSimulationDate, appResources.getChampionshipTournamentDates(currentRound)) &&
                    championshipTournament.getTournFilled())
                {
                    int teamIndex = 0;

                    for (int rowIndex = 0; rowIndex < championshipTournament.getCurrentRoundLength(); rowIndex += 2)
                    {
                        teamIndex = championshipTournament.getTeamIndex(currentRound, rowIndex);
                        opponentIndex = championshipTournament.getTeamIndex(currentRound, rowIndex + 1);

                        teamRowIndex = teamsArray[teamIndex].getNextGameIndex();
                        opponentRowIndex = teamsArray[opponentIndex].getNextGameIndex();

                        simulateGame(teamIndex, opponentIndex, teamRowIndex, opponentRowIndex);
                    }//END FOR ALL ROWS
                }//END IF
            }//END IF 
        } //END
        
        private void simulateGame(int teamIndex, int opponentIndex, int teamRowIndex, int opponentRowIndex)
        {
            int teamPoints = 0;
            int opponentPoints = 0;

            int teamOffensiveAverage = teamsArray[teamIndex].offensiveScoringAverage;
            int teamDefensiveAverage = teamsArray[teamIndex].defensiveScoringAverage;

            int opponentOffensiveAverage = 0;
            int opponentDefensiveAverage = 0;

            if (opponentIndex >= 0)
            {
                opponentOffensiveAverage = teamsArray[opponentIndex].offensiveScoringAverage;
                opponentDefensiveAverage = teamsArray[opponentIndex].defensiveScoringAverage; 
            }
            else
            {
                opponentOffensiveAverage = divisionIIOffensiveScoringAverage;
                opponentDefensiveAverage = divisionIIDefensiveScoringAverage;
            }//END IF

            teamPoints = getPoints(
                teamOffensiveAverage,
                opponentDefensiveAverage);

            opponentPoints = getPoints(
                opponentOffensiveAverage,
                teamDefensiveAverage);

            //WHILE SCORE IS TIED
            //ADD OVERTIME POINTS
            while (teamPoints != opponentPoints)
            {
                teamPoints = teamPoints + (getPoints(
                    teamOffensiveAverage,
                    opponentDefensiveAverage)
                        / 8);

                opponentPoints = opponentPoints + (getPoints(
                    opponentOffensiveAverage,
                    teamDefensiveAverage)
                    / 8);
            }//END WHILE TIED

            teamsArray[teamIndex].setSimGameScore(
                teamRowIndex,
                appResources.getScheduleTypeText(4),
                teamPoints,
                opponentPoints);

            if (opponentIndex >= 0)
            {
                teamsArray[opponentIndex].setSimGameScore(
                    opponentRowIndex,
                    appResources.getScheduleTypeText(4),
                    opponentPoints,
                    teamPoints);
            }//END IF

        }//END IF

        private void advanceConfTournRound()
        {
            int currentRound = 0;

            int teamIndex1 = 0;
            int teamIndex2 = 0;

            int teamRowIndex1 = 0;
            int teamRowIndex2 = 0;

            int[] arrayAdvancingTeamIndexes;

            for (int conferenceIndex = 0; conferenceIndex < appResources.getLengthOfConferenceNames(); conferenceIndex++)
            {
                arrayAdvancingTeamIndexes = new int[conferenceArray[conferenceIndex].getCurrentRoundLength() / 2];

                if (conferenceArray[conferenceIndex].getTournFilled() && !conferenceArray[conferenceIndex].getConfTournChampSet())
                {
                    currentRound = conferenceArray[conferenceIndex].getCurrentRound();

                    for (int rowIndex = 0; rowIndex < conferenceArray[conferenceIndex].getCurrentRoundLength(); rowIndex += 2)
                    {
                        teamIndex1 = conferenceArray[conferenceIndex].getTeamIndex(currentRound, rowIndex);
                        teamIndex2 = conferenceArray[conferenceIndex].getTeamIndex(currentRound, rowIndex + 1);
                        teamRowIndex1 = teamsArray[teamIndex1].getLengthOfSchedule(appResources.getScheduleTypeText(6)) - 1;
                        teamRowIndex2 = teamsArray[teamIndex2].getLengthOfSchedule(appResources.getScheduleTypeText(6)) - 1;

                        if (0 == string.Compare(
                                appResources.getGameResultTypeText(1),
                                teamsArray[teamIndex1].getGameResult(teamRowIndex1, appResources.getScheduleTypeText(6))))
                        {
                            arrayAdvancingTeamIndexes[rowIndex / 2] = teamIndex1;
                        }
                        else if (0 == string.Compare(
                                appResources.getGameResultTypeText(1),
                                teamsArray[teamIndex2].getGameResult(teamRowIndex2, appResources.getScheduleTypeText(6))))
                        {
                            arrayAdvancingTeamIndexes[rowIndex / 2] = teamIndex2;
                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("ERROR: CONFERENCE TOURNAMENT GAME WINNER NOT FOUND");
                        }//END IF

                    }//END FOR ALL ROWS 
                }//END IF

                conferenceArray[conferenceIndex].advanceRound(arrayAdvancingTeamIndexes);
            }//END FOR
        } //END

        private void advanceChampTournRound()
        {
            int teamIndex1 = 0;
            int teamIndex2 = 0;

            int teamRowIndex1 = 0;
            int teamRowIndex2 = 0;

            int currentRound = championshipTournament.getCurrentRound();

            int[] arrayAdvancingTeamIndexes = new int[championshipTournament.getCurrentRoundLength() / 2];

            if (!championshipTournament.getTournChampSet() &&
                0 == DateTime.Compare(currentSimulationDate, appResources.getChampionshipTournamentDates(currentRound)) &&
                championshipTournament.getTournFilled())
            {
                for (int rowIndex = 0; rowIndex < championshipTournament.getCurrentRoundLength(); rowIndex += 2)
                {
                    teamIndex1 = championshipTournament.getTeamIndex(currentRound, rowIndex);
                    teamIndex2 = championshipTournament.getTeamIndex(currentRound, rowIndex + 1);
                    teamRowIndex1 = teamsArray[teamIndex1].getLengthOfSchedule(appResources.getScheduleTypeText(7)) - 1;
                    teamRowIndex2 = teamsArray[teamIndex2].getLengthOfSchedule(appResources.getScheduleTypeText(7)) - 1;

                    if (0 == string.Compare(appResources.getGameResultTypeText(1), teamsArray[teamIndex1].getGameResult(teamRowIndex1, appResources.getScheduleTypeText(7))))
                    {
                        arrayAdvancingTeamIndexes[rowIndex / 2] = teamIndex1;
                    }
                    else if (0 == string.Compare(appResources.getGameResultTypeText(1), teamsArray[teamIndex2].getGameResult(teamRowIndex2, appResources.getScheduleTypeText(7))))
                    {
                        arrayAdvancingTeamIndexes[rowIndex / 2] = teamIndex2;
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("ERROR: CONFERENCE TOURNAMENT GAME WINNER NOT FOUND");
                    }//END IF
                }//END FOR ALL ROWS
            }//END IF

            championshipTournament.advanceRound(arrayAdvancingTeamIndexes);

        } //END

        //ADD REAL GAMES-------------------------------------------------------

        private void addRealGames(DateTime startFromDate)
        {
            int rowIndex = 0;
            int scheduleLength = 0;

            for (int teamIndex = 0; teamIndex < appResources.getLengthOfTeamNames(); teamIndex++)
            {
                scheduleLength = teamsArray[teamIndex].getLengthOfSchedule(appResources.getScheduleTypeText(1));

                while (rowIndex < scheduleLength && 
                    0 < DateTime.Compare(startFromDate, teamsArray[teamIndex].getDate(rowIndex, appResources.getScheduleTypeText(1))))
                {
                    teamsArray[teamIndex].setRealGameScore(rowIndex, appResources.getScheduleTypeText(1));

                    rowIndex++;
                }//END WHILE
            }//END FOR ALL TEAMS

        } //END

        //RESET ONE DAY--------------------------------------------------------

        private void resetOneDay()
        {
            brackets.resetProjectionUpdatedStates();

            removeGamesFromSchedule();

            if (0 <= DateTime.Compare(currentSimulationDate, appResources.getConferenceTournamentStartDate()) &&
                0 > DateTime.Compare(currentSimulationDate, appResources.getChampionshipTournamentStartDate()))
            {
                //CONFERENCE TOURNAMENT
                resetConfTournRound();
            }
            else if (0 <= DateTime.Compare(currentSimulationDate, appResources.getChampionshipTournamentStartDate()))
            {
                //CHAMPIONSHIP TOURNAMENT
                resetChampTournRound();
            }//END IF
        } //END

        private void removeGamesFromSchedule()
        {
            int teamRowIndex = 0;

            for (int teamIndex = 0; teamIndex < appResources.getLengthOfTeamNames(); teamIndex++)
            {
                if (!teamsArray[teamIndex].getNoGamesPlayed())
                {
                    teamRowIndex = teamsArray[teamIndex].getNextGameIndex() - 1;

                    if (0 == DateTime.Compare(
                            currentSimulationDate,
                            teamsArray[teamIndex].getDate(teamRowIndex, appResources.getScheduleTypeText(4))))
                    {
                        if (0 == string.Compare(
                            appResources.getGameTypeText(0),
                            teamsArray[teamIndex].getGameType(teamRowIndex, appResources.getScheduleTypeText(4))))
                        {
                            teamsArray[teamIndex].setSimGameScore(teamRowIndex, appResources.getScheduleTypeText(4), 0, 0);
                        }
                        else 
                        {
                            teamsArray[teamIndex].deleteSimTournGame();
                        }//END IF
                    }//END IF
                }//END IF
            }//END FOR ALL TEAMS
        } //END

        private void resetConfTournRound()
        {
            int currentRound = 0;
            DateTime roundDate;

            for (int confIndex = 0; confIndex < appResources.getLengthOfConferenceNames(); confIndex++)
            {
                if (conferenceArray[confIndex].getTournFilled())
                {
                    currentRound = conferenceArray[confIndex].getCurrentRound();

                    roundDate = new DateTime(
                        appResources.getConferenceTournamentStartDate(confIndex).Year,
                        appResources.getConferenceTournamentStartDate(confIndex).Month,
                        appResources.getConferenceTournamentStartDate(confIndex).Day, 
                        0, 0, 0, 0);

                    roundDate.AddDays(currentRound);

                    if (currentRound > 0 &&
                        0 == DateTime.Compare(currentSimulationDate, roundDate))
                    {
                        brackets.resetConfUpdatedStates(confIndex);

                        conferenceArray[confIndex].resetRound(currentRound - 1);
                    }
                    else if (0 == DateTime.Compare(currentSimulationDate, appResources.getConferenceTournamentStartDate(confIndex)))
                    {
                        brackets.resetConfUpdatedStates(confIndex);

                        for (int teamIndex = 0; teamIndex < conferenceArray[confIndex].getTeamIndexes().Length; teamIndex++)
                        {
                            teamsArray[conferenceArray[confIndex].getTeamIndexes()[teamIndex]].confTournSeed = -1;
                        }//END FOR

                        conferenceArray[confIndex] = new Conference(
                            appResources.getSeedStartRound(confIndex),
                            appResources.getSeedStartRow(confIndex),
                            appResources.getConferenceTournamentCode(confIndex));
                    }//END IF 
                }//END IF
            }//END FOR
        } //END

        private void resetChampTournRound()
        {
            int tournIndex = 0;

            int currentRound = championshipTournament.getCurrentRound();

            if (championshipTournament.getTournFilled())
            {
                if (currentRound > 0 && 
                    0 == DateTime.Compare(currentSimulationDate, appResources.getChampionshipTournamentDates(currentRound)))
                {
                    brackets.resetChampUpdatedStates();

                    championshipTournament.resetRound(currentRound - 1);
                }
                else if (0 == DateTime.Compare(currentSimulationDate, appResources.getChampionshipTournamentStartDate()))
                {
                    brackets.resetChampUpdatedStates();

                    for (int teamIndex = 0; teamIndex < championshipTournament.getTeamIndexes().Length; teamIndex++)
                    {
                        tournIndex = championshipTournament.getTeamIndexes()[teamIndex];

                        teamsArray[tournIndex].champTournParticipant = false;
                        teamsArray[tournIndex].champTournSeed = -1;
                        teamsArray[tournIndex].champTournRegion = "";
                        teamsArray[tournIndex].playInParticipant = false;
                    }//END FOR ALL TOURNAMENT TEAMS

                    //INITIALIZE CHAMPIONSHIP TOURNAMENT
                    championshipTournament = new ChampionshipTournament();
                }//END IF 
            }//END IF
        }//END

    } //END IF
} //END IF
