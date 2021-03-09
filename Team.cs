using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_Basketball_Simulator
{
    class Team : IDisposable
    {
        //STATIC DATA RESOURCES
        private Resources appResources = new Resources();

        //SCHEDULE
        private Schedule schedule = new Schedule();

        private bool disposedValue = false; // To detect redundant calls

        //DISPLAY NAMES
        public string teamNameDisplay { get; set; }
        public string conferenceNameDisplay { get; set; }

        //RATINGS
        public double ratingOffensive { get; set; }
        public double ratingDefensive { get; set; }

        //SCORING AVERAGES
        public int offensiveScoringAverage { get; set; }
        public int defensiveScoringAverage { get; set; }

        //CONFERENCE TOURNAMENT SEED
        public int confTournSeed { get; set; }

        //CHAMPIONSHIP TOURNAMENT PARTICIPANT
        public Boolean champTournParticipant { get; set; }

        //CHAMPIONSHIP TOURNAMENT SEED
        public int champTournSeed { get; set; }

        //CHAMPIONSHIP TOURNAMENT REGION
        public string champTournRegion { get; set; }

        //PLAY IN PARTICIPANT
        public Boolean playInParticipant { get; set; }

        //WINS AND LOSSES
        private int wins;
        private int losses;

        //CONFERENCE WINS AND LOSSES
        private int conferenceWins;
        private int conferenceLosses;

        //---------------------------------------------------------------------

        public Team(Team team)
        {
            //SET DISPLAYS AND INITIALIZE SCHEDULE DATA TABLE
            setProperties(
                team.teamNameDisplay,
                team.conferenceNameDisplay,
                team.ratingOffensive,
                team.ratingDefensive,
                team.offensiveScoringAverage,
                team.defensiveScoringAverage,
                team.getWins(),
                team.getLosses(),
                team.getConferenceWins(),
                team.getConferenceLosses(),
                team.confTournSeed,
                team.champTournParticipant,
                team.champTournSeed,
                team.champTournRegion,
                team.playInParticipant
                );

            //SET SCHEDULE DATA TABLE VALUES
            setSchedule(team.getSchedule());
        } //END

        public Team(string teamDisplay, string conferenceDisplay)
        {
            //SET DISPLAYS AND INITIALIZE SCHEDULE DATA TABLE
            setProperties(
                teamDisplay,
                conferenceDisplay,
                0.0,
                0.0,
                0,
                0,
                0,
                0,
                0,
                0,
                -1,
                false,
                -1,
                "",
                false
                );
        } //END

        //---------------------------------------------------------------------
        //CONSTRUCTOR SET VARIABLES--------------------------------------------
        //---------------------------------------------------------------------

        private void setProperties(
            string teamNameDisplay, 
            string conferenceNameDisplay,
            double ratingOffensive, 
            double ratingDefensive, 
            int offensiveScoringAverage, 
            int defensiveScoringAverage,
            int wins,
            int losses,
            int conferenceWins,
            int conferenceLosses,
            int confTournSeed,
            Boolean champTournParticipant,
            int champTournSeed,
            string champTournRegion,
            Boolean playInParticipant
            )
        {
            //SET DISPLAY NAMES
            this.teamNameDisplay = teamNameDisplay;
            this.conferenceNameDisplay = conferenceNameDisplay;

            //SET RATINGS
            this.ratingOffensive = ratingOffensive;
            this.ratingDefensive = ratingDefensive;

            //SCORING AVERAGES
            this.offensiveScoringAverage = offensiveScoringAverage;
            this.defensiveScoringAverage = defensiveScoringAverage;

            //WINS AND LOSSES
            this.wins = wins;
            this.losses = losses;

            //CONFERENCE WINS AND LOSSES
            this.conferenceWins = conferenceWins;
            this.conferenceLosses = conferenceLosses;

            //CONFERENCE TOURNAMENT
            this.confTournSeed = confTournSeed;

            //CHAMPIONSHIP TOURNAMENT
            this.champTournParticipant = champTournParticipant;
            this.champTournSeed = champTournSeed;
            this.champTournRegion = champTournRegion;
            this.playInParticipant = playInParticipant;
        } //END

        //---------------------------------------------------------------------
        //---------------------------------------------------------------------
        //SCHEDULE-------------------------------------------------------------
        //---------------------------------------------------------------------
        //---------------------------------------------------------------------

        //---------------------------------------------------------------------
        //SET SCHEDULE---------------------------------------------------------
        //---------------------------------------------------------------------

        public void setSchedule(Schedule schedule)
        {
            //RESET WINS AND LOSSES
            wins = 0;
            losses = 0;
            conferenceWins = 0;
            conferenceLosses = 0;

            //FOR ALL GAMES IN SCHEDULE
            //SET WINS AND LOSSES
            for (int index = 0; index < schedule.getLengthOfSchedule(appResources.getScheduleTypeText(4)); index++)
            {
                addWinsAndLosses(
                    schedule.getGameResult(index, appResources.getScheduleTypeText(4)), 
                    schedule.getConferenceGame(index, appResources.getScheduleTypeText(4))
                    );
            }//END FOR

            this.schedule.setSchedule(schedule);
        } //END

        //---------------------------------------------------------------------
        //GET SCHEDULE---------------------------------------------------------
        //---------------------------------------------------------------------

        public Schedule getSchedule()
        {
                return schedule.getSchedule();
        } //END

        //---------------------------------------------------------------------
        //GET------------------------------------------------------------------
        //---------------------------------------------------------------------

        //NEXT GAME INDEX------------------------------------------------------

        public int getNextGameIndex()
        {
            //SIM SCHEDULE NEXT GAME INDEX
            return schedule.getNextGameIndex();
        } //END

        public Boolean getAllGamesPlayed()
        {
            return schedule.getAllGamesPlayed();
        } //END

        public Boolean getNoGamesPlayed()
        {
            return schedule.getNoGamesPlayed();
        } //END

        //GET DATE-------------------------------------------------------------

        public DateTime getDate(int row, string scheduleType)
        {
            return schedule.getDate(row, scheduleType);
        } //END

        //GET OPPONENT NAME----------------------------------------------------

        public string getOpponentName(int row, string scheduleType)
        {
            return schedule.getOpponentName(row, scheduleType);
        } //END

        //GET OPPONENT INDEX----------------------------------------------------

        public int getOpponentIndex(int row, string scheduleType)
        {
            return schedule.getOpponentIndex(row, scheduleType);
        } //END

        //GET OPPONENT ROW INDEX------------------------------------------------

        public int getOpponentRowIndex(int row, string scheduleType)
        {
            return schedule.getOpponentRowIndex(row, scheduleType);
        } //END

        //GET POINTS-----------------------------------------------------------

        public int getPoints(int row, string scheduleType)
        {
            return schedule.getPoints(row, scheduleType);
        } //END

        //GET OPPONENT POINTS--------------------------------------------------

        public int getOpponentPoints(int row, string scheduleType)
        {
            return schedule.getOpponentPoints(row, scheduleType);
        } //END

        //GET WIN LOSE---------------------------------------------------------

        public string getGameResult(int row, string scheduleType)
        {
            // 0 NotPlayed
            // 1 Win
            // 2 Loss
            return schedule.getGameResult(row, scheduleType);
        } //END

        //GET GAME TYPE--------------------------------------------------------

        public string getGameType(int row, string scheduleType)
        {
            // 0 RegularSeason
            // 1 ConferenceTournament
            // 2 ChampionshipTournament
            // 3 SecondaryTournament
            return schedule.getGameType(row, scheduleType);
        } //END

        //GET REAL/SIM ROW INDEX-----------------------------------------------

        public int getRealSimRowIndex(int row, string scheduleType)
        {
            return schedule.getRealSimRowIndex(row, scheduleType);
        } //END

        //GET SCHEDULE ROW INDEX---------------------------------------------------

        public int getScheduleRowIndex(int row, string scheduleType)
        {
            return schedule.getScheduleRowIndex(row, scheduleType);
        } //END

        //GET CONFERENCE GAME--------------------------------------------------

        public Boolean getConferenceGame(int row, string scheduleType)
        {
            return schedule.getConferenceGame(row, scheduleType);
        } //END

        //GET CONFERENCE TOURNAMENT ROUND--------------------------------------

        public int getConfTournRound(int row, string scheduleType)
        {
            return schedule.getConfTournRound(row, scheduleType);
        } //END

        //GET CHAMPIONSHIP TOURNAMENT ROUND------------------------------------

        public int getChampTournRound(int row, string scheduleType)
        {
            return schedule.getChampTournRound(row, scheduleType);
        } //END

        //---------------------------------------------------------------------
        //ADD GAME-------------------------------------------------------------
        //---------------------------------------------------------------------

        public void addRegSeasonGame(
            DateTime date,
            string opponentName,
            int opponentIndex,
            int opponentRowIndex,
            int realPoints,
            int realOpponentPoints,
            int simPoints,
            int simOpponentPoints,
            Boolean confGame
            )
        {
            //SET WINS AND LOSSES
            addWinsAndLosses(schedule.calculateGameResult(simPoints, simOpponentPoints), confGame);

            schedule.addRegSeasonGame(
            date,
            opponentName,
            opponentIndex,
            opponentRowIndex,
            realPoints,
            realOpponentPoints,
            simPoints,
            simOpponentPoints,
            confGame
            );
        } //END

        public void addRealConfTournGame(
            DateTime date,
            string opponentName,
            int opponentIndex,
            int opponentRowIndex,
            int realPoints,
            int realOpponentPoints,
            int round
            )
        {
            schedule.addRealConfTournGame(
            date,
            opponentName,
            opponentIndex,
            opponentRowIndex,
            realPoints,
            realOpponentPoints,
            round
            );
        } //END

        public void addRealChampTournGame(
            DateTime date,
            string opponentName,
            int opponentIndex,
            int opponentRowIndex,
            int realPoints,
            int realOpponentPoints,
            int round
            )
        {
            schedule.addRealChampTournGame(
            date,
            opponentName,
            opponentIndex,
            opponentRowIndex,
            realPoints,
            realOpponentPoints,
            round
            );
        } //END

        public void addSimConfTournGame(
            DateTime date,
            string opponentName,
            int opponentIndex,
            int opponentRowIndex,
            int simPoints,
            int simOpponentPoints,
            int round,
            int row
            )
        {
            //SET WINS AND LOSSES
            addWinsAndLosses(schedule.calculateGameResult(simPoints, simOpponentPoints), true);

            schedule.addSimConfTournGame(
            date,
            opponentName,
            opponentIndex,
            opponentRowIndex,
            simPoints,
            simOpponentPoints,
            round,
            row
            );
        } //END

        public void addSimChampTournGame(
            DateTime date,
            string opponentName,
            int opponentIndex,
            int opponentRowIndex,
            int simPoints,
            int simOpponentPoints,
            int round,
            int row
            )
        {
            //SET WINS AND LOSSES
            addWinsAndLosses(schedule.calculateGameResult(simPoints, simOpponentPoints), false);

            schedule.addSimChampTournGame(
            date,
            opponentName,
            opponentIndex,
            opponentRowIndex,
            simPoints,
            simOpponentPoints,
            round,
            row
            );
        } //END

        //---------------------------------------------------------------------
        //DELETE GAME----------------------------------------------------------
        //---------------------------------------------------------------------

        public void deleteSimTournGame()
        {
            int gameIndex = schedule.getLengthOfSchedule(appResources.getScheduleTypeText(4)) - 1;

            removeWinsAndLosses(
                    schedule.getGameResult(gameIndex, appResources.getScheduleTypeText(4)),
                    schedule.getConferenceGame(gameIndex, appResources.getScheduleTypeText(4))
                    );

            schedule.deleteSimTournGame();
        } //END

        //---------------------------------------------------------------------
        //SET------------------------------------------------------------------
        //---------------------------------------------------------------------

        public void setRealGameScore(int row, string scheduleType)
        {
            //IF REGULAR SEASON GAME
            if (string.Compare(scheduleType, appResources.getScheduleTypeText(0)) == 0)
            {
                //REMOVE CURRENT WIN OR LOSS
                removeWinsAndLosses(
                            schedule.getGameResult(row, appResources.getScheduleTypeText(4)),
                            schedule.getConferenceGame(row, scheduleType)
                            ); 
            }
            else if (string.Compare(scheduleType, appResources.getScheduleTypeText(1)) == 0)
            {
                //REMOVE CURRENT WIN OR LOSS
                removeWinsAndLosses(
                            schedule.getGameResult(row, appResources.getScheduleTypeText(5)),
                            schedule.getConferenceGame(row, scheduleType)
                            );
            }//END IF

            schedule.setRealGameScore(row, scheduleType);

            //ADD NEW WIN OR LOSS
            addWinsAndLosses(
                        schedule.getGameResult(row, scheduleType),
                        schedule.getConferenceGame(row, scheduleType)
                        );
        } //END

        public void setSimGameScore(int row, string scheduleType, int points, int opponentPoints)
        {
            //REMOVE CURRENT WIN OR LOSS
            removeWinsAndLosses(
                        schedule.getGameResult(row, scheduleType),
                        schedule.getConferenceGame(row, scheduleType)
                        );

            //ADD NEW WIN OR LOSS
            addWinsAndLosses(
                        schedule.calculateGameResult(points, opponentPoints),
                        schedule.getConferenceGame(row, scheduleType)
                        );

            schedule.setSimGameScore(row, scheduleType, points, opponentPoints);
        } //END

        public void setOpponentIndex(int row, string scheduleType, int index)
        {
            schedule.setOpponentIndex(row, scheduleType, index);
        } //END

        public void setOpponentRowIndex(int row, string scheduleType, int rowIndex)
        {
            schedule.setOpponentRowIndex(row, scheduleType, rowIndex);
        } //END

        //---------------------------------------------------------------------
        //FIND INDEX OF--------------------------------------------------------
        //---------------------------------------------------------------------

        public int findIndexOf(DateTime date, string scheduleType, string opponentName)
        {
            return schedule.findIndexOf(date, scheduleType, opponentName);
        } //END

        //---------------------------------------------------------------------
        //GET LENGTH OF SCHEDULE-----------------------------------------------
        //---------------------------------------------------------------------

        public int getLengthOfSchedule(string scheduleType)
        {
            return schedule.getLengthOfSchedule(scheduleType);
        } //END

        //---------------------------------------------------------------------
        //GET SET WINS AND LOSSES----------------------------------------------
        //---------------------------------------------------------------------

        //SET WINS AND LOSSES--------------------------------------------------

        private void addWinsAndLosses(string gameResult, Boolean conferenceGame)
        {
            //IF GAME IS A WIN
            //ELSE IF GAME IS A LOSS
            if (string.Compare(gameResult, appResources.getGameResultTypeText(1)) == 0)
            {
                //IF CONFERENCE GAME
                if (conferenceGame)
                {
                    conferenceWins++;
                }//END IF
                wins++;
            }
            else if (string.Compare(gameResult, appResources.getGameResultTypeText(2)) == 0)
            {
                //IF CONFERENCE GAME
                if (conferenceGame)
                {
                    conferenceLosses++;
                }//END IF
                losses++;
            }//END IF
        } //END

        private void removeWinsAndLosses(string gameResult, Boolean conferenceGame)
        {
            //IF GAME IS A WIN
            //ELSE IF GAME IS A LOSS
            if (string.Compare(gameResult, appResources.getGameResultTypeText(1)) == 0)
            {
                //IF CONFERENCE GAME
                if (conferenceGame)
                {
                    conferenceWins--;
                }//END IF
                wins--;
            }
            else if (string.Compare(gameResult, appResources.getGameResultTypeText(2)) == 0)
            {
                //IF CONFERENCE GAME
                if (conferenceGame)
                {
                    conferenceLosses--;
                }//END IF
                losses--;
            }//END IF
        } //END

        //GET WINS AND LOSSES--------------------------------------------------

        public int getWins()
        {
            return wins;
        } //END

        public int getLosses()
        {
            return losses;
        } //END

        public int getConferenceWins()
        {
            return conferenceWins;
        } //END

        public int getConferenceLosses()
        {
            return conferenceLosses;
        } //END

        //---------------------------------------------------------------------
        //---------------------------------------------------------------------
        //DISPOSE TEAM---------------------------------------------------------
        //---------------------------------------------------------------------
        //---------------------------------------------------------------------

        public void DisposeTeam()
        {
            Dispose();
        } //END

        //DisposeSchedule() CALLS Dispose()
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2213:DisposableFieldsShouldBeDisposed", MessageId = "schedule")]
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    schedule.DisposeSchedule();
                    //schedule.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        ~Team()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(false);
        }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            GC.SuppressFinalize(this);
        }

    } //END
} //END
