using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_Basketball_Simulator
{
    class SelectionAndOrder
    {

        //STATIC DATA RESOURCES
        private Resources appResources = new Resources();

        //TOURNAMENT CONTAINER
        private TournamentContainer tournamentContainer = new TournamentContainer();

        public SelectionAndOrder()
        {

        }

        public SelectionAndOrder(TournamentContainer tournamentContainer)
        {
            this.tournamentContainer = new TournamentContainer(tournamentContainer);
        }

        //---------------------------------------------------------------------
        //---------------------------------------------------------------------
        //TOURNAMENT CONTAINER-------------------------------------------------
        //---------------------------------------------------------------------
        //---------------------------------------------------------------------

        public TournamentContainer getTournamentContainer()
        {
            return tournamentContainer;
        } //END

        public Boolean getContainerUpdated(DateTime currentDate)
        {
            return 0 == DateTime.Compare(tournamentContainer.getLastUpdatedDate(), currentDate);
        } //END

        //---------------------------------------------------------------------
        //---------------------------------------------------------------------
        //TOURNAMENT SELECTION-------------------------------------------------
        //---------------------------------------------------------------------
        //---------------------------------------------------------------------

        public void setOverallChampRankingsTeamIndexes(SimulationDirector simulationDirector)
        {
            tournamentContainer.setLastUpdatedDate(simulationDirector.getCurrentSimulationDate());

            setConferenceChampIndexes(simulationDirector);

            setChampTournRankingsTeamIndexes(simulationDirector.getTeams());
        } //END

        public void setChampTournTeamIndexes(Team[] teamsArray, Conference[] conferenceArray, DateTime currentSimulationDate)
        {
            tournamentContainer.setLastUpdatedDate(currentSimulationDate);

            setConferenceChampIndexes(teamsArray, conferenceArray);

            setChampTournRankingsTeamIndexes(teamsArray);
        } //END

        private void setChampTournRankingsTeamIndexes(Team[] teamsArray)
        {
            //TEMP TOURNAMENT ARRAYS
            //ORDER - CONFERENCE INDEX
            int[] arrayIntRanked32IndexesForConfChampsIndexes = new int[appResources.getLengthOfConferenceNames()];
            //CONFERENCE INDEX - RATING
            double[] arrayDouble32ConfChampRatings = new double[appResources.getLengthOfConferenceNames()];

            //INDEX - TEAM INDEX
            int[] arrayInt64ChampTournIndexes = new int[64];
            //INDEX - RATING
            double[] arrayDouble64ChampTournRatings = new double[64];
            //RANK - TEAM INDEX
            int[] arrayIntRanked64IndexesForChampTournIndexes = new int[64];

            //INDEX - TEAM INDEX
            int[] arrayInt68ChampTournIndexes = new int[68];
            //INDEX - RATING
            double[] arrayDouble68ChampTournRatings = new double[68];
            //RANK TEAM INDEX
            int[] arrayIntRanked68IndexesForChampTournIndexes = new int[68];

            //CHAMPIONSHIP TOURNAMENT
            //RANK - TEAM INDEX
            int[] arrayIntRanked64ChampTournIndexes = new int[64];
            //RANK - SEED
            int[] arrayIntRanked64ChampTournSeeds = new int[64];
            //RANK - REGION
            string[] arrayStringRanked64ChampTournRegions = new string[64];

            //TEAM RANKS INDEXES
            //TEAM INDEX - RANK
            int[] arrayInt353TeamIndexes = new int[appResources.getLengthOfTeamNames()];
            //RANK - TEAM INDEX
            int[] arrayIntRanked353TeamIndexes = new int[appResources.getLengthOfTeamNames()];

            //SEEDED PLAY IN TEAMS
            int[] arrayIntSeededPlayInIndexes = new int[] { 0, 1, 4, 5 };

            //FOUND INDEX VARIABLE
            int foundIndex = 0;

            //TEAM INDEX VARIABLE
            int rankIndex = 0;
            
            //IF RANKINGS NOT UPDATED
            //UPDATE RANKINGS
            if (tournamentContainer.getRankingsUpdated() == false)
            {
                updateRankings(teamsArray);
            } //END IF

            //RANK TEAMS

            //TEAM RANKS INDEXES
            Array.Copy(getOrderIndexes(tournamentContainer.get353Rankings(), appResources.getLengthOfTeamNames()),
                arrayInt353TeamIndexes,
                appResources.getLengthOfTeamNames());

            //ORDER TEAM INDEXES
            for (int index = 0; index < arrayInt353TeamIndexes.Length; index++)
            {
                //RANK - TEAM INDEX 
                arrayIntRanked353TeamIndexes[arrayInt353TeamIndexes[index]] = index;
            }//END FOR

            //INITIALIZE VALUES
            //(so indexOf doesn't find garbage)
            for (int index = 0; index < arrayInt68ChampTournIndexes.Length; index++)
            {
                //INDEX - TEAM INDEX
                arrayInt68ChampTournIndexes[index] = -1;
            }//END FOR

            //SELECT CHAMPIONSHIP TOURNAMENT PARTICIPANTS--------------------------

            //GET CONFERENCE RATINGS

            //FOR ALL CONFERENCES
            for (int conferenceIndex = 0; conferenceIndex < appResources.getLengthOfConferenceNames(); conferenceIndex++)
            {
                //CONFERENCE INDEX - RATING
                arrayDouble32ConfChampRatings[conferenceIndex] =
                    tournamentContainer.get353Rankings()[tournamentContainer.get32ConfChampsIndexes()[conferenceIndex]];
            } //END FOR

            //CALCULATE ORDER

            //ORDER CONFERENCE CHAMPIONS
            Array.Copy(getOrderIndexes(arrayDouble32ConfChampRatings, arrayDouble32ConfChampRatings.Length),
                arrayIntRanked32IndexesForConfChampsIndexes,
                arrayIntRanked32IndexesForConfChampsIndexes.Length);

            //ADD CONFERENCE CHAMPIONS

            //FOR ALL CONFERENCES
            for (int conferenceIndex = 0; conferenceIndex < appResources.getLengthOfConferenceNames(); conferenceIndex++)
            {
                //INDEX - TEAM INDEX
                arrayInt68ChampTournIndexes[
                    arrayIntRanked32IndexesForConfChampsIndexes[conferenceIndex]
                    ] = tournamentContainer.get32ConfChampsIndexes()[conferenceIndex];
            } //END FOR

            //SET PLAY IN CONFERENCE TOURNAMENT CHAMPIONS

            //ADD 4 WORST CONFERECE CHAMPS TO PLAY IN ARRAY
            //(from best to worse)
            tournamentContainer.set8PlayInIndexes(0, arrayInt68ChampTournIndexes[appResources.getLengthOfConferenceNames() - 4]);
            tournamentContainer.set8PlayInIndexes(1, arrayInt68ChampTournIndexes[appResources.getLengthOfConferenceNames() - 3]);
            tournamentContainer.set8PlayInIndexes(2, arrayInt68ChampTournIndexes[appResources.getLengthOfConferenceNames() - 2]);
            tournamentContainer.set8PlayInIndexes(3, arrayInt68ChampTournIndexes[appResources.getLengthOfConferenceNames() - 1]);

            //ADD AT LARGE TEAMS

            //FOR ALL REMAINING TEAMS
            for (int teamIndex = appResources.getLengthOfConferenceNames(); teamIndex < 68; teamIndex++)
            {
                //FIND TEAM TO ADD TO TOURNAMENT
                do
                {
                    //IF NOT IN ARRAY
                    if (Array.IndexOf(arrayInt68ChampTournIndexes, arrayIntRanked353TeamIndexes[rankIndex]) < 0)
                    {
                        //INDEX - TEAM INDEX
                        arrayInt68ChampTournIndexes[teamIndex] = arrayIntRanked353TeamIndexes[rankIndex];
                        rankIndex++;
                        break;
                    }//END IF 
                    rankIndex++;
                } while (rankIndex < arrayIntRanked353TeamIndexes.Length); //END DO WHILE

            } //END FOR

            //SET PLAY IN AT LARGE TEAMS

            //ADD 4 WORST CONFERECE CHAMPS TO PLAY IN ARRAY
            //(from best to worse)
            tournamentContainer.set8PlayInIndexes(4, arrayInt68ChampTournIndexes[64]);
            tournamentContainer.set8PlayInIndexes(5, arrayInt68ChampTournIndexes[65]);
            tournamentContainer.set8PlayInIndexes(6, arrayInt68ChampTournIndexes[66]);
            tournamentContainer.set8PlayInIndexes(7, arrayInt68ChampTournIndexes[67]);

            //ORDER 68 TOURNAMENT TEAMS--------------------------------------------

            //GET RATINGS

            //FOR ALL TOURNAMENT TEAMS
            for (int index = 0; index < arrayDouble68ChampTournRatings.Length; index++)
            {
                //INDEX - RATING
                arrayDouble68ChampTournRatings[index] = tournamentContainer.get353Rankings()[arrayInt68ChampTournIndexes[index]];
            } //END FOR

            //CALCULATE ORDER

            //ORDER TOURNAMENT TEAMS
            Array.Copy(getOrderIndexes(arrayDouble68ChampTournRatings, arrayIntRanked68IndexesForChampTournIndexes.Length),
                arrayIntRanked68IndexesForChampTournIndexes,
                arrayIntRanked68IndexesForChampTournIndexes.Length);

            //ORDER 64 TOURNAMENT TEAMS--------------------------------------------

            //GET INDEXES FOR SEEDING

            //GET CONFERENCE TOURNAMENT CHAMPIONS INDEXES
            //(minus 2 worst play in conference champions)

            //FOR ALL SEEDED CONFERENCE CHAMP TEAMS
            for (int index = 0; index < appResources.getLengthOfConferenceNames() - 2; index++)
            {
                //INDEX - TEAM INDEX
                arrayInt64ChampTournIndexes[index] = arrayInt68ChampTournIndexes[index];
            } //END FOR

            //GET AT LARGE INDEXES
            //(minus 2 worst play in at large teams)

            //FOR ALL AT LARGE SEEDED TEAMS
            for (int index = appResources.getLengthOfConferenceNames(); index < arrayInt64ChampTournIndexes.Length + 2; index++)
            {
                //INDEX - TEAM INDEX
                arrayInt64ChampTournIndexes[index - 2] = arrayInt68ChampTournIndexes[index];
            } //END FOR

            //GET RATINGS

            //FOR ALL SEEDED TEAMS
            for (int index = 0; index < arrayDouble64ChampTournRatings.Length; index++)
            {
                //INDEX - RATING
                arrayDouble64ChampTournRatings[index] = tournamentContainer.get353Rankings()[arrayInt64ChampTournIndexes[index]];
            } //END FOR

            //CALCULATE ORDER

            //ORDER TOURNAMENT TEAMS
            Array.Copy(getOrderIndexes(arrayDouble64ChampTournRatings, arrayIntRanked64IndexesForChampTournIndexes.Length),
                arrayIntRanked64IndexesForChampTournIndexes,
                arrayIntRanked64IndexesForChampTournIndexes.Length);

            //SET TOURNAMENT SEEDS-------------------------------------------------

            //SET SEEDS
            for (int seedIndex = 0; seedIndex < 16; seedIndex += 4)
            {
                //SET INDEXES IN RANKINGS
                //RANK - TEAM INDEX
                arrayIntRanked64ChampTournIndexes[seedIndex * 4] = arrayInt64ChampTournIndexes[arrayIntRanked64IndexesForChampTournIndexes[seedIndex * 4]];
                arrayIntRanked64ChampTournIndexes[seedIndex * 4 + 1] = arrayInt64ChampTournIndexes[arrayIntRanked64IndexesForChampTournIndexes[seedIndex * 4 + 1]];
                arrayIntRanked64ChampTournIndexes[seedIndex * 4 + 2] = arrayInt64ChampTournIndexes[arrayIntRanked64IndexesForChampTournIndexes[seedIndex * 4 + 2]];
                arrayIntRanked64ChampTournIndexes[seedIndex * 4 + 3] = arrayInt64ChampTournIndexes[arrayIntRanked64IndexesForChampTournIndexes[seedIndex * 4 + 3]];
                
                //ZIG ZAG THROUGH SEEDS
                if (seedIndex % 2 == 0)
                {
                    //SET INDEXES IN REGIONS
                    tournamentContainer.setRanked16ChampTournWestIndexes(seedIndex, arrayInt64ChampTournIndexes[arrayIntRanked64IndexesForChampTournIndexes[seedIndex * 4]]);
                    tournamentContainer.setRanked16ChampTournMidwestIndexes(seedIndex, arrayInt64ChampTournIndexes[arrayIntRanked64IndexesForChampTournIndexes[seedIndex * 4 + 1]]);
                    tournamentContainer.setRanked16ChampTournSouthIndexes(seedIndex, arrayInt64ChampTournIndexes[arrayIntRanked64IndexesForChampTournIndexes[seedIndex * 4 + 2]]);
                    tournamentContainer.setRanked16ChampTournEastIndexes(seedIndex, arrayInt64ChampTournIndexes[arrayIntRanked64IndexesForChampTournIndexes[seedIndex * 4 + 3]]);

                    //SET SEEDS IN 
                    //RANK - SEED
                    arrayIntRanked64ChampTournSeeds[seedIndex * 4] = seedIndex;
                    arrayIntRanked64ChampTournSeeds[seedIndex * 4 + 1] = seedIndex;
                    arrayIntRanked64ChampTournSeeds[seedIndex * 4 + 2] = seedIndex;
                    arrayIntRanked64ChampTournSeeds[seedIndex * 4 + 3] = seedIndex;

                    //SET REGIONS IN RANKINGS
                    //RANK - REGION
                    arrayStringRanked64ChampTournRegions[seedIndex * 4] = appResources.getChampTounRegionTypeText(0);
                    arrayStringRanked64ChampTournRegions[seedIndex * 4 + 1] = appResources.getChampTounRegionTypeText(1);
                    arrayStringRanked64ChampTournRegions[seedIndex * 4 + 2] = appResources.getChampTounRegionTypeText(2);
                    arrayStringRanked64ChampTournRegions[seedIndex * 4 + 3] = appResources.getChampTounRegionTypeText(3);
                }
                else
                {
                    //SET INDEXES IN REGIONS
                    tournamentContainer.setRanked16ChampTournWestIndexes(seedIndex, arrayInt64ChampTournIndexes[arrayIntRanked64IndexesForChampTournIndexes[seedIndex * 4 + 3]]);
                    tournamentContainer.setRanked16ChampTournMidwestIndexes(seedIndex, arrayInt64ChampTournIndexes[arrayIntRanked64IndexesForChampTournIndexes[seedIndex * 4 + 2]]);
                    tournamentContainer.setRanked16ChampTournSouthIndexes(seedIndex, arrayInt64ChampTournIndexes[arrayIntRanked64IndexesForChampTournIndexes[seedIndex * 4 + 1]]);
                    tournamentContainer.setRanked16ChampTournEastIndexes(seedIndex, arrayInt64ChampTournIndexes[arrayIntRanked64IndexesForChampTournIndexes[seedIndex * 4]]);

                    //SET SEEDS IN RANKINGS
                    //RANK - SEED
                    arrayIntRanked64ChampTournSeeds[seedIndex * 4 + 3] = seedIndex;
                    arrayIntRanked64ChampTournSeeds[seedIndex * 4 + 2] = seedIndex;
                    arrayIntRanked64ChampTournSeeds[seedIndex * 4 + 1] = seedIndex;
                    arrayIntRanked64ChampTournSeeds[seedIndex * 4] = seedIndex;

                    //SET REGIONS IN RANKINGS
                    //RANK - REGION
                    arrayStringRanked64ChampTournRegions[seedIndex * 4 + 3] = appResources.getChampTounRegionTypeText(0);
                    arrayStringRanked64ChampTournRegions[seedIndex * 4 + 2] = appResources.getChampTounRegionTypeText(1);
                    arrayStringRanked64ChampTournRegions[seedIndex * 4 + 1] = appResources.getChampTounRegionTypeText(2);
                    arrayStringRanked64ChampTournRegions[seedIndex * 4] = appResources.getChampTounRegionTypeText(3);
                }//END IF
            }//END FOR

            //FILL TOP 68 OVERALL RANKINGS-----------------------------------------

            //FILL TOP 68 TOURNAMENT TEAMS

            //FOR ALL SEEDED TEAMS
            //ADD INDEX REGION AND SEED
            //ADD RANKING INDEXES TO RANKING ARRAY
            for (int index = 0; index < arrayInt68ChampTournIndexes.Length; index++)
            {
                tournamentContainer.setRanked68ChampTournIndexes(
                    index, 
                    arrayInt68ChampTournIndexes[arrayIntRanked68IndexesForChampTournIndexes[index]]);

                foundIndex = Array.IndexOf(arrayIntRanked64ChampTournIndexes, tournamentContainer.getRanked68ChampTournIndexes()[index]);

                if (foundIndex != -1)
                {
                    tournamentContainer.setRanked68ChampTournSeeds(index, arrayIntRanked64ChampTournSeeds[foundIndex]);

                    tournamentContainer.setRanked68ChampTournRegions(index, arrayStringRanked64ChampTournRegions[foundIndex]);
                }//END IF

                tournamentContainer.setRanked353ChampTournReturnIndexes(index, arrayInt68ChampTournIndexes[arrayIntRanked68IndexesForChampTournIndexes[index]]);
            } //END FOR

            //SET PLAY IN TEAM SEEDS AND REGIONS-----------------------------------

            //FOR ALL REMAINING TEAMS
            for (int index = 0; index < arrayIntSeededPlayInIndexes.Length; index++)
            {
                //FIND RANKINGS INDEX
                foundIndex = Array.IndexOf(tournamentContainer.getRanked68ChampTournIndexes(), tournamentContainer.get8PlayInIndexes()[arrayIntSeededPlayInIndexes[index]]);

                //COPY SEED AND REGION TO PLAY IN ARRAYS
                tournamentContainer.set8PlayInSeeds(arrayIntSeededPlayInIndexes[index], tournamentContainer.getRanked68ChampTournSeeds()[foundIndex]);

                tournamentContainer.set8PlayInRegions(arrayIntSeededPlayInIndexes[index], tournamentContainer.getRanked68ChampTournRegions()[foundIndex]);
            } //END FOR

            //FILL NON SEEDED PLAY IN TEAMS
            tournamentContainer.set8PlayInSeeds(2, tournamentContainer.get8PlayInSeeds()[1]);
            tournamentContainer.set8PlayInRegions(2, tournamentContainer.get8PlayInRegions()[1]);
            tournamentContainer.set8PlayInSeeds(3, tournamentContainer.get8PlayInSeeds()[0]);
            tournamentContainer.set8PlayInRegions(3, tournamentContainer.get8PlayInRegions()[0]);
            tournamentContainer.set8PlayInSeeds(6, tournamentContainer.get8PlayInSeeds()[5]);
            tournamentContainer.set8PlayInRegions(6, tournamentContainer.get8PlayInRegions()[5]);
            tournamentContainer.set8PlayInSeeds(7, tournamentContainer.get8PlayInSeeds()[4]);
            tournamentContainer.set8PlayInRegions(7, tournamentContainer.get8PlayInRegions()[4]);

            //FILL CHAMPIONSHIP TOURNAMENT ARRAY WITH NON SEEDED PLAY IN TEAMS
            //FIND RANKINGS INDEX
            foundIndex = Array.IndexOf(tournamentContainer.getRanked68ChampTournIndexes(), tournamentContainer.get8PlayInIndexes()[2]);

            tournamentContainer.setRanked68ChampTournIndexes(foundIndex, tournamentContainer.get8PlayInIndexes()[2]);
            tournamentContainer.setRanked68ChampTournSeeds(foundIndex, tournamentContainer.get8PlayInSeeds()[2]);
            tournamentContainer.setRanked68ChampTournRegions(foundIndex, tournamentContainer.get8PlayInRegions()[2]);

            foundIndex = Array.IndexOf(tournamentContainer.getRanked68ChampTournIndexes(), tournamentContainer.get8PlayInIndexes()[3]);

            tournamentContainer.setRanked68ChampTournIndexes(foundIndex, tournamentContainer.get8PlayInIndexes()[3]);
            tournamentContainer.setRanked68ChampTournSeeds(foundIndex, tournamentContainer.get8PlayInSeeds()[3]);
            tournamentContainer.setRanked68ChampTournRegions(foundIndex, tournamentContainer.get8PlayInRegions()[3]);

            foundIndex = Array.IndexOf(tournamentContainer.getRanked68ChampTournIndexes(), tournamentContainer.get8PlayInIndexes()[6]);

            tournamentContainer.setRanked68ChampTournIndexes(foundIndex, tournamentContainer.get8PlayInIndexes()[6]);
            tournamentContainer.setRanked68ChampTournSeeds(foundIndex, tournamentContainer.get8PlayInSeeds()[6]);
            tournamentContainer.setRanked68ChampTournRegions(foundIndex, tournamentContainer.get8PlayInRegions()[6]);

            foundIndex = Array.IndexOf(tournamentContainer.getRanked68ChampTournIndexes(), tournamentContainer.get8PlayInIndexes()[7]);

            tournamentContainer.setRanked68ChampTournIndexes(foundIndex, tournamentContainer.get8PlayInIndexes()[7]);
            tournamentContainer.setRanked68ChampTournSeeds(foundIndex, tournamentContainer.get8PlayInSeeds()[7]);
            tournamentContainer.setRanked68ChampTournRegions(foundIndex, tournamentContainer.get8PlayInRegions()[7]);

            //FILL REMAINING OVERALL RANKINGS--------------------------------------

            //ADD REMAINING TEAMS FROM RANKINGS

            //FOR ALL REMAINING TEAMS
            for (int teamIndex = 68; teamIndex < tournamentContainer.getRanked353ChampTournReturnIndexes().Length; teamIndex++)
            {
                //FIND TEAM TO ADD TO TOURNAMENT
                do
                {
                    //IF NOT IN ARRAY
                    if (Array.IndexOf(arrayInt68ChampTournIndexes, arrayIntRanked353TeamIndexes[rankIndex]) < 0)
                    {
                        tournamentContainer.setRanked353ChampTournReturnIndexes(teamIndex, arrayIntRanked353TeamIndexes[rankIndex]);
                        rankIndex++;
                        break;
                    }//END IF 
                    rankIndex++;
                } while (rankIndex < tournamentContainer.getRanked353ChampTournReturnIndexes().Length); //END DO WHILE
            } //END FOR 

        } //END

        //---------------------------------------------------------------------

        public void setConferenceChampIndexes(SimulationDirector simulationDirector)
        {
            //FOR ALL CONFERENCES
            for (int conferenceIndex = 0; conferenceIndex < appResources.getLengthOfConferenceNames(); conferenceIndex++)
            {
                //CHECK IF CONFERENCE TOURNAMENT CHAMPION
                //ADD CHAMPION TO TOURNAMENT
                //ELSE ADD CONFERENCE LEADER
                if (simulationDirector.getConfTournChampSet(conferenceIndex))
                {
                    tournamentContainer.set32ConfChampsIndexes(conferenceIndex, simulationDirector.getConfTournChampTeamIndex(conferenceIndex));
                }
                else
                {
                    setConferenceChampIndex(simulationDirector.getTeams(), conferenceIndex);
                }//END IF
            } //END FOR
        } //END

        public void setConferenceChampIndexes(Team[] teamsArray, Conference[] conferenceArray)
        {
            //FOR ALL CONFERENCES
            for (int conferenceIndex = 0; conferenceIndex < appResources.getLengthOfConferenceNames(); conferenceIndex++)
            {
                //CHECK IF CONFERENCE TOURNAMENT CHAMPION
                //ADD CHAMPION TO TOURNAMENT
                //ELSE ADD CONFERENCE LEADER
                if (conferenceArray[conferenceIndex].getConfTournChampSet())
                {
                    tournamentContainer.set32ConfChampsIndexes(conferenceIndex, conferenceArray[conferenceIndex].getConfTournChampTeamIndex());
                }
                else
                {
                    setConferenceChampIndex(teamsArray, conferenceIndex);
                }//END IF
            } //END FOR
        } //END

        private void setConferenceChampIndex(Team[] teamsArray, int conferenceIndex)
        {
            double highestValue = 0.0;
            int index = 0;

            double[] arrayDoubleOrderValues = getConferenceOrderValues(teamsArray, conferenceIndex);

            for (int teamIndex = 0; teamIndex < arrayDoubleOrderValues.Length; teamIndex++)
            {
                if (arrayDoubleOrderValues[teamIndex] > highestValue)
                {
                    highestValue = arrayDoubleOrderValues[teamIndex];
                    index = teamIndex;
                }
            }//END FOR TEAMS

            tournamentContainer.set32ConfChampsIndexes(conferenceIndex, appResources.getConferenceTeamIndexes(conferenceIndex)[index]);
        } //END

        //---------------------------------------------------------------------
        //---------------------------------------------------------------------
        //ORDER----------------------------------------------------------------
        //---------------------------------------------------------------------
        //---------------------------------------------------------------------

        public int[] getOrderIndexes(double[] arrayDoubleOrderValues, int orderLength)
        {
            //ORDER ARRAY
            int[] arrayIntOrder = new int[orderLength];

            //INSERT TEAM INDEX
            int insertTeamArrayIndex = 0;

            //TEMP TEAM INDEX
            int tempTeamIndex = 0;

            //FOR ALL TEAMS
            //SET ORDER
            for (int teamIndex = 0; teamIndex < arrayIntOrder.Length; teamIndex++)
            {
                //SET CURRENT INSERT TEAM
                insertTeamArrayIndex = teamIndex;

                //FOR ALL FILLED ORDER ARRAY
                //FIND PLACEMENT
                for (int orderIndex = 0; orderIndex < teamIndex; orderIndex++)
                {
                    //IF BETTER RANKING
                    //SWITCH
                    if (arrayDoubleOrderValues[insertTeamArrayIndex] >
                        arrayDoubleOrderValues[arrayIntOrder[orderIndex]])
                    {
                        //SET TEMP TEAM INDEX
                        tempTeamIndex = insertTeamArrayIndex;

                        //RESET CURRENT INSERT TEAM
                        insertTeamArrayIndex = arrayIntOrder[orderIndex];

                        //SET NEW ORDER
                        arrayIntOrder[orderIndex] = tempTeamIndex;
                    }//END IF

                }//END FOR

                //ADD TEAM TO ORDER
                arrayIntOrder[teamIndex] = insertTeamArrayIndex;

            }//END FOR

            return arrayIntOrder;

        }// END

        //---------------------------------------------------------------------

            //CHANGE NAME TO CONFERENCE ORDER VALUES
        public double[] getConferenceOrderValues(Team[] teamsArray, int confIndex)
        {
            //GET CONFERENCE TEAM INDEXES
            int[] arrayIntConferenceTeamIndexes = new int[appResources.getConferenceTeamIndexes(confIndex).Length];

            Array.Copy(appResources.getConferenceTeamIndexes(confIndex),
                arrayIntConferenceTeamIndexes,
                appResources.getConferenceTeamIndexes(confIndex).Length);

            //ARRAY OF CONFERENCE WIN PERCENTAGES
            double[] arrayDoubleOrderValues = new double[arrayIntConferenceTeamIndexes.Length];

            //FOR ALL TEAMS IN CONFERENCE
            //ADD CONFERENCE WIN PERCENTAGE TO ARRAY
            for (int index = 0; index < arrayIntConferenceTeamIndexes.Length; index++)
            {
                if (teamsArray[arrayIntConferenceTeamIndexes[index]].getConferenceWins() > 0)
                {
                    arrayDoubleOrderValues[index] = (double)teamsArray[arrayIntConferenceTeamIndexes[index]].getConferenceWins() /
                            (double)(teamsArray[arrayIntConferenceTeamIndexes[index]].getConferenceLosses() +
                            teamsArray[arrayIntConferenceTeamIndexes[index]].getConferenceWins()); 
                }
                else 
                {
                    arrayDoubleOrderValues[index] = 0.0;
                }//END IF
            }//END FOR

            return arrayDoubleOrderValues;

        } //END

        //---------------------------------------------------------------------
        //---------------------------------------------------------------------
        //RANKINGS-------------------------------------------------------------
        //---------------------------------------------------------------------
        //---------------------------------------------------------------------

        public double[] getRankings()
        {
            return tournamentContainer.get353Rankings();
        } //END

        public Boolean getRankingsUpdated()
        {
            return tournamentContainer.getRankingsUpdated();
        } //END

        public void setRankingsUpdated(Boolean updated)
        {
            tournamentContainer.setRankingsUpdated(updated);
        } //END

        //---------------------------------------------------------------------

        public void updateRankings(Team[] teamsArray)
        {
            //STRENGTH OF SCHEDULE RANKINGS ARRAY
            double[] arrayDoubleSOSRankings = new double[353];

            //STRENGTH OF SCHEDULE RANKINGS ARRAY
            double[] arrayDoubleWinPercentRankings = new double[353];

            //FOR ALL TEAMS
            //CALCULATE FIRST RATING
            //WIN PERCENTAGE
            for (int teamIndex = 0; teamIndex < appResources.getLengthOfTeamNames(); teamIndex++)
            {
                if (teamsArray[teamIndex].getWins() > 0)
                {
                    arrayDoubleWinPercentRankings[teamIndex] = (double)teamsArray[teamIndex].getWins() /
                                (double)(teamsArray[teamIndex].getLosses() +
                                teamsArray[teamIndex].getWins());
                }
                else 
                {
                    arrayDoubleWinPercentRankings[teamIndex] = 0.0;
                }//END IF
            }//END FOR

            //CALCULATE SECOND RATING
            //STRENGTH OF SCHEDULE 1.0
            Array.Copy(getStrengthOfScheduleArray(teamsArray, arrayDoubleWinPercentRankings),
                arrayDoubleSOSRankings,
                353);

            //CALCULATE THIRD RATING
            //STRENGTH OF SCHEDULE 1.1
            Array.Copy(getStrengthOfScheduleArray(teamsArray, arrayDoubleSOSRankings),
                arrayDoubleSOSRankings,
                353);

            //CALCULATE FOURTH RATING
            //STRENGTH OF SCHEDULE 1.2
            Array.Copy(getStrengthOfScheduleArray(teamsArray, arrayDoubleSOSRankings),
                arrayDoubleSOSRankings,
                353);

            //FOR ALL TEAMS
            //CALCULATE FIFTH RATING
            //AVERAGE WIN PERCENT AND STRENGTH OF SCHEDULE
            for (int teamIndex = 0; teamIndex < appResources.getLengthOfTeamNames(); teamIndex++)
            {
                if ((arrayDoubleWinPercentRankings[teamIndex] + arrayDoubleSOSRankings[teamIndex]) > 0.0)
                {
                    arrayDoubleSOSRankings[teamIndex] = (arrayDoubleWinPercentRankings[teamIndex] + arrayDoubleSOSRankings[teamIndex]) / 2.0;
                }
                else
                {
                    arrayDoubleSOSRankings[teamIndex] = 0.0;
                }//END IF
            }//END FOR

            //CALCULATE SIXTH RATING
            //STRENGTH OF SCHEDULE 2.0
            tournamentContainer.set353Rankings(getStrengthOfScheduleArray(teamsArray, arrayDoubleSOSRankings));

            //RANKINGS
            //SET UPDATED TO TRUE
            tournamentContainer.setRankingsUpdated(true);

        } //END

        //---------------------------------------------------------------------

        private double[] getStrengthOfScheduleArray(Team[] teamsArray, double[] arrayDoubleWinPercentRankings)
        {
            //STRENGTH OF SCHEDULE RANKINGS ARRAY
            double[] arrayDoubleSOSRankings = new double[353];

            //WINS VALUE
            double winsValue = 0.0;

            //LOSSES VALUE
            double lossesValue = 0.0;

            //EXIT LOOP
            Boolean endLoop = false;

            //FOR ALL TEAMS
            //CALCULATE SECOND RATING
            for (int teamIndex = 0; teamIndex < appResources.getLengthOfTeamNames(); teamIndex++)
            {
                //RESET VALUES
                winsValue = 0.0;
                lossesValue = 0.0;

                //FOR ALL GAMES IN SCHEDULE
                //CALCULATE NEXT RATING
                for (int scheduleIndex = 0; scheduleIndex < teamsArray[teamIndex].getLengthOfSchedule(appResources.getScheduleTypeText(4)); scheduleIndex++)
                {
                    //IF GAME WAS PLAYED (or because an opponent could score zero)
                    //PROCESS GAME
                    //ELSE EXIT LOOP
                    if (teamsArray[teamIndex].getPoints(scheduleIndex, appResources.getScheduleTypeText(4)) > 0 || teamsArray[teamIndex].getOpponentPoints(scheduleIndex, appResources.getScheduleTypeText(4)) > 0)
                    {
                        //IF WIN
                        //ELSE IF LOSS
                        if (teamsArray[teamIndex].getPoints(scheduleIndex, appResources.getScheduleTypeText(4)) > teamsArray[teamIndex].getOpponentPoints(scheduleIndex, appResources.getScheduleTypeText(4)))
                        {
                            //IF DIV II SCHOOL WIN
                            if (teamsArray[teamIndex].getOpponentRowIndex(scheduleIndex, appResources.getScheduleTypeText(4)) == -2)
                            {
                                winsValue = winsValue + 0.01;
                            }
                            else
                            {
                                //IF WIN
                                winsValue = winsValue + arrayDoubleWinPercentRankings[teamsArray[teamIndex].getOpponentIndex(scheduleIndex, appResources.getScheduleTypeText(4))];
                            }//END IF
                        }
                        else if (teamsArray[teamIndex].getPoints(scheduleIndex, appResources.getScheduleTypeText(4)) < teamsArray[teamIndex].getOpponentPoints(scheduleIndex, appResources.getScheduleTypeText(4)))
                        {
                            //IF DIV II SCHOOL LOSS
                            if (teamsArray[teamIndex].getOpponentRowIndex(scheduleIndex, appResources.getScheduleTypeText(4)) == -2)
                            {
                                lossesValue = lossesValue + 0.99;
                            }
                            else
                            {
                                //IF LOSS
                                lossesValue = lossesValue + (1.0 - arrayDoubleWinPercentRankings[teamsArray[teamIndex].getOpponentIndex(scheduleIndex, appResources.getScheduleTypeText(4))]);
                            }//END IF
                        }//END IF
                    }
                    else
                    {
                        endLoop = true;
                        break;
                    }//END IF
                }//END FOR

                if (winsValue > 0.0)
                {
                    arrayDoubleSOSRankings[teamIndex] = winsValue / (winsValue + lossesValue); 
                }
                else
                {
                    arrayDoubleSOSRankings[teamIndex] = 0.0;
                }//END IF

                if (endLoop)
                {
                    break;
                }//END IF

            }//END FOR

            return arrayDoubleSOSRankings;
        }//END

    }
}
