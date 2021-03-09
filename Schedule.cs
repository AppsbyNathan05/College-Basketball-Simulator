using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_Basketball_Simulator
{
    class Schedule : IDisposable
    {
        //STATIC DATA RESOURCES
        private Resources appResources = new Resources();

        //REAL SCHEDULE DATA TABLE
        private DataTable tableRealSchedule = new DataTable();

        //REAL REGULAR SEASON SCHEDULE DATA TABLE
        private DataTable tableRealRegSeasonSchedule = new DataTable();

        //REAL CONFERENCE TOURNAMENT SCHEDULE DATA TABLE
        private DataTable tableRealConfTournSchedule = new DataTable();

        //REAL CHAMPIONSHIP TOURNAMENT SCHEDULE DATA TABLE
        private DataTable tableRealChampTournSchedule = new DataTable();

        //SIM SCHEDULE DATA TABLE
        private DataTable tableSimSchedule = new DataTable();

        //SIM REGULAR SEASON SCHEDULE DATA TABLE
        private DataTable tableSimRegSeasonSchedule = new DataTable();

        //SIM CONFERENCE TOURNAMENT SCHEDULE DATA TABLE
        private DataTable tableSimConfTournSchedule = new DataTable();

        //SIM CHAMPIONSHIP TOURNAMENT SCHEDULE DATA TABLE
        private DataTable tableSimChampTournSchedule = new DataTable();

        private bool disposedValue = false; // To detect redundant calls

        //SIM SCHEDULE NEXT GAME INDEX
        private int nextGameSimScheduleIndex;

        public Schedule()
        {
            //INITIALIZE TABLE COLUMS
            initializeTableColums();

            //INITIALIZE NEXT GAME INDEX
            nextGameSimScheduleIndex = 0;
        }

        //---------------------------------------------------------------------
        //INITIALIZE SCHEDULE--------------------------------------------------
        //---------------------------------------------------------------------

        private void initializeTableColums()
        {
            // 0 Date
            // 1 Opponent
            // 2 Opponent Index       (team index)
            // 3 Opponent Row Index   (schedule index)
            // 4 Real Points
            // 5 Real Opponent Points
            // 6 Game Type            (arrayStringGameType)
            // 7 Sim Index Row        (index of simulation schedule)
            // 8 Type Row Index       (regseason, conftourn, champtourn index)


            //INITIALIZE REAL SCHEDULE DATA TABLE
            tableRealSchedule.Columns.Add("Date", typeof(DateTime));
            tableRealSchedule.Columns.Add("Opponent Name", typeof(string));
            tableRealSchedule.Columns.Add("Opponent Index", typeof(int));
            tableRealSchedule.Columns.Add("Opponent Row Index", typeof(int));
            tableRealSchedule.Columns.Add("Real Points", typeof(int));
            tableRealSchedule.Columns.Add("Real Opponent Points", typeof(int));
            tableRealSchedule.Columns.Add("Game Result", typeof(string));
            tableRealSchedule.Columns.Add("Game Type", typeof(string));
            tableRealSchedule.Columns.Add("Sim Row Index", typeof(int));
            tableRealSchedule.Columns.Add("Real Schedule Row Index", typeof(int));

            // 0 Real Row Index (index of real schedule)
            // 1 Conference Game

            //INITIALIZE REAL REGULAR SEASON SCHEDULE DATA TABLE
            tableRealRegSeasonSchedule.Columns.Add("Real Row Index", typeof(int));
            tableRealRegSeasonSchedule.Columns.Add("Conference Game", typeof(Boolean));

            // 0 Real Row Index (index of real schedule)
            // 1 Round

            //INITIALIZE REAL CONFERENCE TOURNAMENT SCHEDULE DATA TABLE
            tableRealConfTournSchedule.Columns.Add("Real Row Index", typeof(int));
            tableRealConfTournSchedule.Columns.Add("Round", typeof(int));

            // 0 Real Row Index (index of real schedule)
            // 1 Round 

            //INITIALIZE REAL CHAMPIONSHIP TOURNAMENT SCHEDULE DATA TABLE
            tableRealChampTournSchedule.Columns.Add("Real Row Index", typeof(int));
            tableRealChampTournSchedule.Columns.Add("Round", typeof(int));

            // 0 Date
            // 1 Opponent
            // 2 Opponent Index      (team index)
            // 3 Opponent Row Index  (schedule index)
            // 4 Sim Points
            // 5 Sim Opponent Points
            // 6 Game Type           (arrayStringGameType)
            // 7 Real Index Row      (index of real schedule)
            // 8 Type Row Index      (regseason, conftourn, champtourn index)


            //INITIALIZE SIM SCHEDULE DATA TABLE
            tableSimSchedule.Columns.Add("Date", typeof(DateTime));
            tableSimSchedule.Columns.Add("Opponent Name", typeof(string));
            tableSimSchedule.Columns.Add("Opponent Index", typeof(int));
            tableSimSchedule.Columns.Add("Opponent Row Index", typeof(int));
            tableSimSchedule.Columns.Add("Sim Points", typeof(int));
            tableSimSchedule.Columns.Add("Sim Opponent Points", typeof(int));
            tableSimSchedule.Columns.Add("Game Result", typeof(string));
            tableSimSchedule.Columns.Add("Game Type", typeof(string));
            tableSimSchedule.Columns.Add("Real Row Index", typeof(int));
            tableSimSchedule.Columns.Add("Sim Schedule Row Index", typeof(int));

            // 0 Sim Row Index   (index of simulation schedule)
            // 1 Conference Game

            //INITIALIZE SIM REGULAR SEASON SCHEDULE DATA TABLE
            tableSimRegSeasonSchedule.Columns.Add("Sim Row Index", typeof(int));
            tableSimRegSeasonSchedule.Columns.Add("Conference Game", typeof(Boolean));

            // 0 Sim Row Index (index of simulation schedule)
            // 1 Round
            // 2 Row

            //INITIALIZE SIM CONFERENCE TOURNAMENT SCHEDULE DATA TABLE
            tableSimConfTournSchedule.Columns.Add("Sim Row Index", typeof(int));
            tableSimConfTournSchedule.Columns.Add("Round", typeof(int));
            tableSimConfTournSchedule.Columns.Add("Row", typeof(int));

            // 0 Sim Row Index (index of simulation schedule)
            // 1 Round
            // 2 Row

            //INITIALIZE SIM CHAMPIONSHIP TOURNAMENT SCHEDULE DATA TABLE
            tableSimChampTournSchedule.Columns.Add("Sim Row Index", typeof(int));
            tableSimChampTournSchedule.Columns.Add("Round", typeof(int));
            tableSimChampTournSchedule.Columns.Add("Row", typeof(int));
        }

        //---------------------------------------------------------------------
        //SET SCHEDULE---------------------------------------------------------
        //---------------------------------------------------------------------

        public void setSchedule(Schedule schedule)
        {
            //SCHEDULE TYPES
            string realSeasonType = appResources.getScheduleTypeText(0);
            string simSeasonType = appResources.getScheduleTypeText(4);
            string regularSeasonType = appResources.getScheduleTypeText(5);
            string realConfTournSeasonType = appResources.getScheduleTypeText(2);
            string simConfTournSeasonType = appResources.getScheduleTypeText(6);
            string realChampTournSeasonType = appResources.getScheduleTypeText(3);
            string simChampTournSeasonType = appResources.getScheduleTypeText(7);

            //CLEAR SCHEDULE
            tableRealSchedule.Rows.Clear();
            tableRealRegSeasonSchedule.Rows.Clear();
            tableRealConfTournSchedule.Rows.Clear();
            tableRealChampTournSchedule.Rows.Clear();
            tableSimSchedule.Rows.Clear();
            tableSimRegSeasonSchedule.Rows.Clear();
            tableSimConfTournSchedule.Rows.Clear();
            tableSimChampTournSchedule.Rows.Clear();

            //FOR ALL REGULAR SEASON GAMES IN SCHEDULE
            for (int rIndex = 0; rIndex < schedule.getLengthOfSchedule(regularSeasonType); rIndex++)
            {
                // 5 Sim RegularSeason
                addRegSeasonGame(
                    schedule.getDate(rIndex, regularSeasonType), 
                    schedule.getOpponentName(rIndex, regularSeasonType), 
                    schedule.getOpponentIndex(rIndex, regularSeasonType), 
                    schedule.getOpponentRowIndex(rIndex, regularSeasonType), 
                    schedule.getPoints(rIndex, realSeasonType), 
                    schedule.getOpponentPoints(rIndex, realSeasonType), 
                    schedule.getPoints(rIndex, simSeasonType), 
                    schedule.getOpponentPoints(rIndex, simSeasonType), 
                    schedule.getConferenceGame(rIndex, regularSeasonType)
                    );
            } //END FOR ALL GAMES IN SCHEDULE

            //FOR ALL REAL CONFERENCE TOURNAMENT GAMES IN SCHEDULE
            for (int rIndex = 0; rIndex < schedule.getLengthOfSchedule(realConfTournSeasonType); rIndex++)
            {
                // 2 Real ConferenceTournament
                addRealConfTournGame(
                    schedule.getDate(rIndex, realConfTournSeasonType), 
                    schedule.getOpponentName(rIndex, realConfTournSeasonType),
                    schedule.getOpponentIndex(rIndex, realConfTournSeasonType), 
                    schedule.getOpponentRowIndex(rIndex, realConfTournSeasonType), 
                    schedule.getPoints(rIndex, realSeasonType), 
                    schedule.getOpponentPoints(rIndex, realSeasonType),
                    schedule.getConfTournRound(rIndex, realConfTournSeasonType)
                    );
            } //END FOR ALL GAMES IN SCHEDULE

            //FOR ALL SIM CONFERENCE TOURNAMENT GAMES IN SCHEDULE
            for (int rIndex = 0; rIndex < schedule.getLengthOfSchedule(simConfTournSeasonType); rIndex++)
            {
                // 6 Sim ConferenceTournament
                addSimConfTournGame(
                    schedule.getDate(rIndex, simConfTournSeasonType),
                    schedule.getOpponentName(rIndex, simConfTournSeasonType),
                    schedule.getOpponentIndex(rIndex, simConfTournSeasonType),
                    schedule.getOpponentRowIndex(rIndex, simConfTournSeasonType),
                    schedule.getPoints(rIndex, simSeasonType), 
                    schedule.getOpponentPoints(rIndex, simSeasonType),
                    schedule.getConfTournRound(rIndex, simConfTournSeasonType),
                    schedule.getConfTournRow(rIndex, simConfTournSeasonType)
                    );
            } //END FOR ALL GAMES IN SCHEDULE

            //FOR ALL REAL CHAMPIONSHIP TOURNAMENT GAMES IN SCHEDULE
            for (int rIndex = 0; rIndex < schedule.getLengthOfSchedule(realChampTournSeasonType); rIndex++)
            {
                // 3 Real ChampionshipTournament
                addRealChampTournGame(
                    schedule.getDate(rIndex, realChampTournSeasonType),
                    schedule.getOpponentName(rIndex, realChampTournSeasonType),
                    schedule.getOpponentIndex(rIndex, realChampTournSeasonType),
                    schedule.getOpponentRowIndex(rIndex, realChampTournSeasonType),
                    schedule.getPoints(rIndex, realSeasonType), 
                    schedule.getOpponentPoints(rIndex, realSeasonType),
                    schedule.getChampTournRound(rIndex, realChampTournSeasonType)
                    );
            } //END FOR ALL GAMES IN SCHEDULE

            //FOR ALL SIM CHAMPIONSHIP TOURNAMENT GAMES IN SCHEDULE
            for (int rIndex = 0; rIndex < schedule.getLengthOfSchedule(simChampTournSeasonType); rIndex++)
            {
                // 7 Sim ChampionshipTournament
                addSimChampTournGame(
                    schedule.getDate(rIndex, simChampTournSeasonType),
                    schedule.getOpponentName(rIndex, simChampTournSeasonType),
                    schedule.getOpponentIndex(rIndex, simChampTournSeasonType),
                    schedule.getOpponentRowIndex(rIndex, simChampTournSeasonType),
                    schedule.getPoints(rIndex, simSeasonType), 
                    schedule.getOpponentPoints(rIndex, simSeasonType),
                    schedule.getChampTournRound(rIndex, simChampTournSeasonType),
                    schedule.getChampTournRow(rIndex, simChampTournSeasonType)
                    );
            } //END FOR ALL GAMES IN SCHEDULE

        } //END

        //---------------------------------------------------------------------
        //GET SCHEDULE---------------------------------------------------------
        //---------------------------------------------------------------------

        public Schedule getSchedule()
        {
            //DECLARE SCHEDULE DATA TABLE
            Schedule schedule = new Schedule();

            //SCHEDULE ROW INDEX
            int scheduleRowIndex = 0;

            try
            {
                //FOR ALL REGULAR SEASON GAMES IN SCHEDULE
                for (int rIndex = 0; rIndex < tableSimRegSeasonSchedule.Rows.Count; rIndex++)
                {
                    // 5 Sim RegularSeason
                    scheduleRowIndex = (int)tableSimRegSeasonSchedule.Rows[rIndex]["Sim Row Index"];

                    schedule.addRegSeasonGame(
                        Convert.ToDateTime(tableSimSchedule.Rows[scheduleRowIndex]["Date"].ToString()),
                        (string)tableSimSchedule.Rows[scheduleRowIndex]["Opponent Name"],
                        (int)tableSimSchedule.Rows[scheduleRowIndex]["Opponent Index"],
                        (int)tableSimSchedule.Rows[scheduleRowIndex]["Opponent Row Index"],
                        (int)tableRealSchedule.Rows[scheduleRowIndex]["Real Points"],
                        (int)tableRealSchedule.Rows[scheduleRowIndex]["Real Opponent Points"],
                        (int)tableSimSchedule.Rows[scheduleRowIndex]["Sim Points"],
                        (int)tableSimSchedule.Rows[scheduleRowIndex]["Sim Opponent Points"],
                        (Boolean)tableSimRegSeasonSchedule.Rows[rIndex]["Conference Game"]
                        );
                } //END FOR ALL GAMES IN SCHEDULE

                //FOR ALL REAL CONFERENCE TOURNAMENT GAMES IN SCHEDULE
                for (int rIndex = 0; rIndex < tableRealConfTournSchedule.Rows.Count; rIndex++)
                {
                    // 2 Real ConferenceTournament
                    scheduleRowIndex = (int)tableRealConfTournSchedule.Rows[rIndex]["Real Row Index"];

                    schedule.addRealConfTournGame(
                        Convert.ToDateTime(tableRealSchedule.Rows[scheduleRowIndex]["Date"].ToString()),
                        (string)tableRealSchedule.Rows[scheduleRowIndex]["Opponent Name"],
                        (int)tableRealSchedule.Rows[scheduleRowIndex]["Opponent Index"],
                        (int)tableRealSchedule.Rows[scheduleRowIndex]["Opponent Row Index"],
                        (int)tableRealSchedule.Rows[scheduleRowIndex]["Real Points"],
                        (int)tableRealSchedule.Rows[scheduleRowIndex]["Real Opponent Points"],
                        (int)tableRealConfTournSchedule.Rows[rIndex]["Round"]
                        );
                } //END FOR ALL GAMES IN SCHEDULE

                //FOR ALL SIM CONFERENCE TOURNAMENT GAMES IN SCHEDULE
                for (int rIndex = 0; rIndex < tableSimConfTournSchedule.Rows.Count; rIndex++)
                {
                    // 6 Sim ConferenceTournament
                    scheduleRowIndex = (int)tableSimConfTournSchedule.Rows[rIndex]["Sim Row Index"];

                    schedule.addSimConfTournGame(
                        Convert.ToDateTime(tableSimSchedule.Rows[scheduleRowIndex]["Date"].ToString()),
                        (string)tableSimSchedule.Rows[scheduleRowIndex]["Opponent Name"],
                        (int)tableSimSchedule.Rows[scheduleRowIndex]["Opponent Index"],
                        (int)tableSimSchedule.Rows[scheduleRowIndex]["Opponent Row Index"],
                        (int)tableSimSchedule.Rows[scheduleRowIndex]["Sim Points"],
                        (int)tableSimSchedule.Rows[scheduleRowIndex]["Sim Opponent Points"],
                        (int)tableSimConfTournSchedule.Rows[rIndex]["Round"],
                        (int)tableSimConfTournSchedule.Rows[rIndex]["Row"]
                        );
                } //END FOR ALL GAMES IN SCHEDULE

                //FOR ALL REAL CHAMPIONSHIP TOURNAMENT GAMES IN SCHEDULE
                for (int rIndex = 0; rIndex < tableRealChampTournSchedule.Rows.Count; rIndex++)
                {
                    // 3 Real ChampionshipTournament
                    scheduleRowIndex = (int)tableRealChampTournSchedule.Rows[rIndex]["Real Row Index"];

                    schedule.addRealChampTournGame(
                        Convert.ToDateTime(tableRealSchedule.Rows[scheduleRowIndex]["Date"].ToString()),
                        (string)tableRealSchedule.Rows[scheduleRowIndex]["Opponent Name"],
                        (int)tableRealSchedule.Rows[scheduleRowIndex]["Opponent Index"],
                        (int)tableRealSchedule.Rows[scheduleRowIndex]["Opponent Row Index"],
                        (int)tableRealSchedule.Rows[scheduleRowIndex]["Real Points"],
                        (int)tableRealSchedule.Rows[scheduleRowIndex]["Real Opponent Points"],
                        (int)tableRealChampTournSchedule.Rows[rIndex]["Round"]
                        );
                } //END FOR ALL GAMES IN SCHEDULE

                //FOR ALL SIM CHAMPIONSHIP TOURNAMENT GAMES IN SCHEDULE
                for (int rIndex = 0; rIndex < tableSimChampTournSchedule.Rows.Count; rIndex++)
                {
                    // 7 Sim ChampionshipTournament
                    scheduleRowIndex = (int)tableSimChampTournSchedule.Rows[rIndex]["Sim Row Index"];

                    schedule.addSimChampTournGame(
                        Convert.ToDateTime(tableSimSchedule.Rows[scheduleRowIndex]["Date"].ToString()),
                        (string)tableSimSchedule.Rows[scheduleRowIndex]["Opponent Name"],
                        (int)tableSimSchedule.Rows[scheduleRowIndex]["Opponent Index"],
                        (int)tableSimSchedule.Rows[scheduleRowIndex]["Opponent Row Index"],
                        (int)tableSimSchedule.Rows[scheduleRowIndex]["Sim Points"],
                        (int)tableSimSchedule.Rows[scheduleRowIndex]["Sim Opponent Points"],
                        (int)tableSimChampTournSchedule.Rows[rIndex]["Round"],
                        (int)tableSimChampTournSchedule.Rows[rIndex]["Row"]
                        );
                } //END FOR ALL GAMES IN SCHEDULE

                //RETURN SCHEDULE DATA TABLE
                return schedule;
            }
            finally
            {
                schedule.DisposeSchedule();
            }//END TRY

        } //END

        //---------------------------------------------------------------------
        //GET------------------------------------------------------------------
        //---------------------------------------------------------------------

        //NEXT GAME INDEX------------------------------------------------------

        public int getNextGameIndex()
        {
            //SIM SCHEDULE NEXT GAME INDEX
            return nextGameSimScheduleIndex;
        } //END

        public Boolean getAllGamesPlayed()
        {
            //SIM SCHEDULE NEXT GAME INDEX
            return nextGameSimScheduleIndex >= tableSimSchedule.Rows.Count;
        } //END

        public Boolean getNoGamesPlayed()
        {
            //SIM SCHEDULE NEXT GAME INDEX
            return nextGameSimScheduleIndex <= 0;
        } //END

        //GET DATE-------------------------------------------------------------

        public DateTime getDate(int row, string scheduleType)
        {
            //RETURN DATE
            if (string.Compare(appResources.getScheduleTypeText(0), scheduleType) == 0)
            {
                // 0 Real Schedule
                return Convert.ToDateTime(tableRealSchedule.Rows[row]["Date"].ToString());
            }
            else if (string.Compare(appResources.getScheduleTypeText(1), scheduleType) == 0)
            {
                // 1 Real RegularSeason
                return Convert.ToDateTime(tableRealSchedule.Rows[
                    (int)tableRealRegSeasonSchedule.Rows[row]["Real Row Index"]
                    ]["Date"].ToString());
            }
            else if (string.Compare(appResources.getScheduleTypeText(2), scheduleType) == 0)
            {
                // 2 Real ConferenceTournament
                return Convert.ToDateTime(tableRealSchedule.Rows[
                    (int)tableRealConfTournSchedule.Rows[row]["Real Row Index"]
                    ]["Date"].ToString());
            }
            else if (string.Compare(appResources.getScheduleTypeText(3), scheduleType) == 0)
            {
                // 3 Real ChampionshipTournament
                return Convert.ToDateTime(tableRealSchedule.Rows[
                    (int)tableRealChampTournSchedule.Rows[row]["Real Row Index"]
                    ]["Date"].ToString());
            }
            else if (string.Compare(appResources.getScheduleTypeText(4), scheduleType) == 0)
            {
                // 4 Sim Schedule
                return Convert.ToDateTime(tableSimSchedule.Rows[row]["Date"].ToString());
            }
            else if (string.Compare(appResources.getScheduleTypeText(5), scheduleType) == 0)
            {
                // 5 Sim RegularSeason
                return Convert.ToDateTime(tableSimSchedule.Rows[
                    (int)tableSimRegSeasonSchedule.Rows[row]["Sim Row Index"]
                    ]["Date"].ToString());
            }
            else if (string.Compare(appResources.getScheduleTypeText(6), scheduleType) == 0)
            {
                // 6 Sim ConferenceTournament
                return Convert.ToDateTime(tableSimSchedule.Rows[
                    (int)tableSimConfTournSchedule.Rows[row]["Sim Row Index"]
                    ]["Date"].ToString());
            }
            else if (string.Compare(appResources.getScheduleTypeText(7), scheduleType) == 0)
            {
                // 7 Sim ChampionshipTournament
                return Convert.ToDateTime(tableSimSchedule.Rows[
                    (int)tableSimChampTournSchedule.Rows[row]["Sim Row Index"]
                    ]["Date"].ToString());
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("ERROR: GET SCHEDULE DATE, SCHEDULE TYPE NOT FOUND");
                return Convert.ToDateTime(tableSimSchedule.Rows[row]["Date"].ToString());
            }//END IF
        } //END

        //GET OPPONENT NAME----------------------------------------------------

        public string getOpponentName(int row, string scheduleType)
        {
            //RETURN OPPONENT NAME
            if (string.Compare(appResources.getScheduleTypeText(0), scheduleType) == 0)
            {
                // 0 Real Schedule
                return (string)tableRealSchedule.Rows[row]["Opponent Name"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(1), scheduleType) == 0)
            {
                // 1 Real RegularSeason
                return (string)tableRealSchedule.Rows[
                    (int)tableRealRegSeasonSchedule.Rows[row]["Real Row Index"]
                    ]["Opponent Name"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(2), scheduleType) == 0)
            {
                // 2 Real ConferenceTournament
                return (string)tableRealSchedule.Rows[
                    (int)tableRealConfTournSchedule.Rows[row]["Real Row Index"]
                    ]["Opponent Name"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(3), scheduleType) == 0)
            {
                // 3 Real ChampionshipTournament
                return (string)tableRealSchedule.Rows[
                    (int)tableRealChampTournSchedule.Rows[row]["Real Row Index"]
                    ]["Opponent Name"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(4), scheduleType) == 0)
            {
                // 4 Sim Schedule
                return (string)tableSimSchedule.Rows[row]["Opponent Name"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(5), scheduleType) == 0)
            {
                // 5 Sim RegularSeason
                return (string)tableSimSchedule.Rows[
                    (int)tableSimRegSeasonSchedule.Rows[row]["Sim Row Index"]
                    ]["Opponent Name"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(6), scheduleType) == 0)
            {
                // 6 Sim ConferenceTournament
                return (string)tableSimSchedule.Rows[
                    (int)tableSimConfTournSchedule.Rows[row]["Sim Row Index"]
                    ]["Opponent Name"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(7), scheduleType) == 0)
            {
                // 7 Sim ChampionshipTournament
                return (string)tableSimSchedule.Rows[
                    (int)tableSimChampTournSchedule.Rows[row]["Sim Row Index"]
                    ]["Opponent Name"];
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("ERROR: GET SCHEDULE OPPONENT NAME, SCHEDULE TYPE NOT FOUND");
                return (string)tableSimSchedule.Rows[row]["Opponent Name"];
            }//END IF
        } //END

        //GET OPPONENT INDEX----------------------------------------------------

        public int getOpponentIndex(int row, string scheduleType)
        {
            //RETURN INDEX OF OPPONENTS SCHEDULE
            if (string.Compare(appResources.getScheduleTypeText(0), scheduleType) == 0)
            {
                // 0 Real Schedule
                return (int)tableRealSchedule.Rows[row]["Opponent Index"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(1), scheduleType) == 0)
            {
                // 1 Real RegularSeason
                return (int)tableRealSchedule.Rows[
                    (int)tableRealRegSeasonSchedule.Rows[row]["Real Row Index"]
                    ]["Opponent Index"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(2), scheduleType) == 0)
            {
                // 2 Real ConferenceTournament
                return (int)tableRealSchedule.Rows[
                    (int)tableRealConfTournSchedule.Rows[row]["Real Row Index"]
                    ]["Opponent Index"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(3), scheduleType) == 0)
            {
                // 3 Real ChampionshipTournament
                return (int)tableRealSchedule.Rows[
                    (int)tableRealChampTournSchedule.Rows[row]["Real Row Index"]
                    ]["Opponent Index"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(4), scheduleType) == 0)
            {
                // 4 Sim Schedule
                return (int)tableSimSchedule.Rows[row]["Opponent Index"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(5), scheduleType) == 0)
            {
                // 5 Sim RegularSeason
                return (int)tableSimSchedule.Rows[
                    (int)tableSimRegSeasonSchedule.Rows[row]["Sim Row Index"]
                    ]["Opponent Index"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(6), scheduleType) == 0)
            {
                // 6 Sim ConferenceTournament
                return (int)tableSimSchedule.Rows[
                    (int)tableSimConfTournSchedule.Rows[row]["Sim Row Index"]
                    ]["Opponent Index"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(7), scheduleType) == 0)
            {
                // 7 Sim ChampionshipTournament
                return (int)tableSimSchedule.Rows[
                    (int)tableSimChampTournSchedule.Rows[row]["Sim Row Index"]
                    ]["Opponent Index"];
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("ERROR: GET SCHEDULE OPPONENT INDEX, SCHEDULE TYPE NOT FOUND");
                return (int)tableSimSchedule.Rows[row]["Opponent Index"];
            }//END IF
        } //END

        //GET OPPONENT ROW INDEX------------------------------------------------

        public int getOpponentRowIndex(int row, string scheduleType)
        {
            //RETURN ROW INDEX OF OPPONENTS SCHEDULE
            if (string.Compare(appResources.getScheduleTypeText(0), scheduleType) == 0)
            {
                // 0 Real Schedule
                return (int)tableRealSchedule.Rows[row]["Opponent Row Index"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(1), scheduleType) == 0)
            {
                // 1 Real RegularSeason
                return (int)tableRealSchedule.Rows[
                    (int)tableRealRegSeasonSchedule.Rows[row]["Real Row Index"]
                    ]["Opponent Row Index"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(2), scheduleType) == 0)
            {
                // 2 Real ConferenceTournament
                return (int)tableRealSchedule.Rows[
                    (int)tableRealConfTournSchedule.Rows[row]["Real Row Index"]
                    ]["Opponent Row Index"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(3), scheduleType) == 0)
            {
                // 3 Real ChampionshipTournament
                return (int)tableRealSchedule.Rows[
                    (int)tableRealChampTournSchedule.Rows[row]["Real Row Index"]
                    ]["Opponent Row Index"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(4), scheduleType) == 0)
            {
                // 4 Sim Schedule
                return (int)tableSimSchedule.Rows[row]["Opponent Row Index"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(5), scheduleType) == 0)
            {
                // 5 Sim RegularSeason
                return (int)tableSimSchedule.Rows[
                    (int)tableSimRegSeasonSchedule.Rows[row]["Sim Row Index"]
                    ]["Opponent Row Index"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(6), scheduleType) == 0)
            {
                // 6 Sim ConferenceTournament
                return (int)tableSimSchedule.Rows[
                    (int)tableSimConfTournSchedule.Rows[row]["Sim Row Index"]
                    ]["Opponent Row Index"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(7), scheduleType) == 0)
            {
                // 7 Sim ChampionshipTournament
                return (int)tableSimSchedule.Rows[
                    (int)tableSimChampTournSchedule.Rows[row]["Sim Row Index"]
                    ]["Opponent Row Index"];
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("ERROR: GET SCHEDULE OPPONENT ROW INDEX, SCHEDULE TYPE NOT FOUND");
                return (int)tableSimSchedule.Rows[row]["Opponent Row Index"];
            }//END IF
        } //END

        //GET POINTS-----------------------------------------------------------

        public int getPoints(int row, string scheduleType)
        {
            //RETURN POINTS
            if (string.Compare(appResources.getScheduleTypeText(0), scheduleType) == 0)
            {
                // 0 Real Schedule
                return (int)tableRealSchedule.Rows[row]["Real Points"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(1), scheduleType) == 0)
            {
                // 1 Real RegularSeason
                return (int)tableRealSchedule.Rows[
                    (int)tableRealRegSeasonSchedule.Rows[row]["Real Row Index"]
                    ]["Real Points"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(2), scheduleType) == 0)
            {
                // 2 Real ConferenceTournament
                return (int)tableRealSchedule.Rows[
                    (int)tableRealConfTournSchedule.Rows[row]["Real Row Index"]
                    ]["Real Points"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(3), scheduleType) == 0)
            {
                // 3 Real ChampionshipTournament
                return (int)tableRealSchedule.Rows[
                    (int)tableRealChampTournSchedule.Rows[row]["Real Row Index"]
                    ]["Real Points"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(4), scheduleType) == 0)
            {
                // 4 Sim Schedule
                return (int)tableSimSchedule.Rows[row]["Sim Points"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(5), scheduleType) == 0)
            {
                // 5 Sim RegularSeason
                return (int)tableSimSchedule.Rows[
                    (int)tableSimRegSeasonSchedule.Rows[row]["Sim Row Index"]
                    ]["Sim Points"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(6), scheduleType) == 0)
            {
                // 6 Sim ConferenceTournament
                return (int)tableSimSchedule.Rows[
                    (int)tableSimConfTournSchedule.Rows[row]["Sim Row Index"]
                    ]["Sim Points"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(7), scheduleType) == 0)
            {
                // 7 Sim ChampionshipTournament
                return (int)tableSimSchedule.Rows[
                    (int)tableSimChampTournSchedule.Rows[row]["Sim Row Index"]
                    ]["Sim Points"];
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("ERROR: GET SCHEDULE POINTS, SCHEDULE TYPE NOT FOUND");
                return (int)tableSimSchedule.Rows[row]["Sim Points"];
            }//END IF
        } //END

        //GET OPPONENT POINTS--------------------------------------------------

        public int getOpponentPoints(int row, string scheduleType)
        {
            //RETURN OPPONENT POINTS
            if (string.Compare(appResources.getScheduleTypeText(0), scheduleType) == 0)
            {
                // 0 Real Schedule
                return (int)tableRealSchedule.Rows[row]["Real Opponent Points"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(1), scheduleType) == 0)
            {
                // 1 Real RegularSeason
                return (int)tableRealSchedule.Rows[
                    (int)tableRealRegSeasonSchedule.Rows[row]["Real Row Index"]
                    ]["Real Opponent Points"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(2), scheduleType) == 0)
            {
                // 2 Real ConferenceTournament
                return (int)tableRealSchedule.Rows[
                    (int)tableRealConfTournSchedule.Rows[row]["Real Row Index"]
                    ]["Real Opponent Points"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(3), scheduleType) == 0)
            {
                // 3 Real ChampionshipTournament
                return (int)tableRealSchedule.Rows[
                    (int)tableRealChampTournSchedule.Rows[row]["Real Row Index"]
                    ]["Real Opponent Points"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(4), scheduleType) == 0)
            {
                // 4 Sim Schedule
                return (int)tableSimSchedule.Rows[row]["Sim Opponent Points"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(5), scheduleType) == 0)
            {
                // 5 Sim RegularSeason
                return (int)tableSimSchedule.Rows[
                    (int)tableSimRegSeasonSchedule.Rows[row]["Sim Row Index"]
                    ]["Sim Opponent Points"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(6), scheduleType) == 0)
            {
                // 6 Sim ConferenceTournament
                return (int)tableSimSchedule.Rows[
                    (int)tableSimConfTournSchedule.Rows[row]["Sim Row Index"]
                    ]["Sim Opponent Points"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(7), scheduleType) == 0)
            {
                // 7 Sim ChampionshipTournament
                return (int)tableSimSchedule.Rows[
                    (int)tableSimChampTournSchedule.Rows[row]["Sim Row Index"]
                    ]["Sim Opponent Points"];
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("ERROR: GET SCHEDULE OPPONENT POINTS, SCHEDULE TYPE NOT FOUND");
                return (int)tableSimSchedule.Rows[row]["Sim Opponent Points"];
            }//END IF
        } //END

        //GET WIN LOSE---------------------------------------------------------

        public string getGameResult(int row, string scheduleType)
        {
            //RETURN TRUE IF WIN
            if (string.Compare(appResources.getScheduleTypeText(0), scheduleType) == 0)
            {
                // 0 Real Schedule
                return (string)tableRealSchedule.Rows[row]["Game Result"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(1), scheduleType) == 0)
            {
                // 1 Real RegularSeason
                return (string)tableRealSchedule.Rows[
                    (int)tableRealRegSeasonSchedule.Rows[row]["Real Row Index"]
                    ]["Game Result"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(2), scheduleType) == 0)
            {
                // 2 Real ConferenceTournament
                return (string)tableRealSchedule.Rows[
                    (int)tableRealConfTournSchedule.Rows[row]["Real Row Index"]
                    ]["Game Result"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(3), scheduleType) == 0)
            {
                // 3 Real ChampionshipTournament
                return (string)tableRealSchedule.Rows[
                    (int)tableRealChampTournSchedule.Rows[row]["Real Row Index"]
                    ]["Game Result"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(4), scheduleType) == 0)
            {
                // 4 Sim Schedule
                return (string)tableSimSchedule.Rows[row]["Game Result"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(5), scheduleType) == 0)
            {
                // 5 Sim RegularSeason
                return (string)tableSimSchedule.Rows[
                    (int)tableSimRegSeasonSchedule.Rows[row]["Sim Row Index"]
                    ]["Game Result"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(6), scheduleType) == 0)
            {
                // 6 Sim ConferenceTournament
                return (string)tableSimSchedule.Rows[
                    (int)tableSimConfTournSchedule.Rows[row]["Sim Row Index"]
                    ]["Game Result"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(7), scheduleType) == 0)
            {
                // 7 Sim ChampionshipTournament
                return (string)tableSimSchedule.Rows[
                    (int)tableSimChampTournSchedule.Rows[row]["Sim Row Index"]
                    ]["Game Result"];
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("ERROR: GET SCHEDULE WIN, SCHEDULE TYPE NOT FOUND");
                return (string)tableSimSchedule.Rows[row]["Game Result"];
            }//END IF
        } //END

        //GET GAME TYPE--------------------------------------------------------

        public string getGameType(int row, string scheduleType)
        {
            //RETURN TYPE OF GAME
            if (string.Compare(appResources.getScheduleTypeText(0), scheduleType) == 0)
            {
                // 0 Real Schedule
                return (string)tableRealSchedule.Rows[row]["Game Type"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(1), scheduleType) == 0)
            {
                // 1 Real RegularSeason
                return (string)tableRealSchedule.Rows[
                    (int)tableRealRegSeasonSchedule.Rows[row]["Real Row Index"]
                    ]["Game Type"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(2), scheduleType) == 0)
            {
                // 2 Real ConferenceTournament
                return (string)tableRealSchedule.Rows[
                    (int)tableRealConfTournSchedule.Rows[row]["Real Row Index"]
                    ]["Game Type"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(3), scheduleType) == 0)
            {
                // 3 Real ChampionshipTournament
                return (string)tableRealSchedule.Rows[
                    (int)tableRealChampTournSchedule.Rows[row]["Real Row Index"]
                    ]["Game Type"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(4), scheduleType) == 0)
            {
                // 4 Sim Schedule
                return (string)tableSimSchedule.Rows[row]["Game Type"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(5), scheduleType) == 0)
            {
                // 5 Sim RegularSeason
                return (string)tableSimSchedule.Rows[
                    (int)tableSimRegSeasonSchedule.Rows[row]["Sim Row Index"]
                    ]["Game Type"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(6), scheduleType) == 0)
            {
                // 6 Sim ConferenceTournament
                return (string)tableSimSchedule.Rows[
                    (int)tableSimConfTournSchedule.Rows[row]["Sim Row Index"]
                    ]["Game Type"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(7), scheduleType) == 0)
            {
                // 7 Sim ChampionshipTournament
                return (string)tableSimSchedule.Rows[
                    (int)tableSimChampTournSchedule.Rows[row]["Sim Row Index"]
                    ]["Game Type"];
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("ERROR: GET SCHEDULE GAME TYPE, SCHEDULE TYPE NOT FOUND");
                return (string)tableSimSchedule.Rows[row]["Game Type"];
            }//END IF
        } //END

        //GET REAL/SIM ROW INDEX-----------------------------------------------

        public int getRealSimRowIndex(int row, string scheduleType)
        {
            //RETURN REAL OR SIM INDEX
            if (string.Compare(appResources.getScheduleTypeText(0), scheduleType) == 0)
            {
                // 0 Real Schedule
                return (int)tableRealSchedule.Rows[row]["Sim Row Index"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(4), scheduleType) == 0)
            {
                // 4 Sim Schedule
                return (int)tableSimSchedule.Rows[row]["Real Row Index"];
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("ERROR: GET SCHEDULE REAL SIM INDEX, SCHEDULE TYPE NOT FOUND");
                return (int)tableSimSchedule.Rows[row]["Real Row Index"];
            }//END IF
        } //END

        //GET SCHEDULE ROW INDEX---------------------------------------------------

        public int getScheduleRowIndex(int row, string scheduleType)
        {
            //RETURN SCHEDULE ROW INDEX
            if (string.Compare(appResources.getScheduleTypeText(0), scheduleType) == 0)
            {
                // 0 Real Schedule
                return (int)tableRealSchedule.Rows[row]["Real Schedule Row Index"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(1), scheduleType) == 0)
            {
                // 1 Real RegularSeason
                return (int)tableRealRegSeasonSchedule.Rows[row]["Real Row Index"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(2), scheduleType) == 0)
            {
                // 2 Real ConferenceTournament
                return (int)tableRealConfTournSchedule.Rows[row]["Real Row Index"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(3), scheduleType) == 0)
            {
                // 3 Real ChampionshipTournament
                return (int)tableRealChampTournSchedule.Rows[row]["Real Row Index"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(4), scheduleType) == 0)
            {
                // 4 Sim Schedule
                return (int)tableSimSchedule.Rows[row]["Sim Schedule Row Index"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(5), scheduleType) == 0)
            {
                // 5 Sim RegularSeason
                return (int)tableSimRegSeasonSchedule.Rows[row]["Sim Row Index"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(6), scheduleType) == 0)
            {
                // 6 Sim ConferenceTournament
                return (int)tableSimConfTournSchedule.Rows[row]["Sim Row Index"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(7), scheduleType) == 0)
            {
                // 7 Sim ChampionshipTournament
                return (int)tableSimChampTournSchedule.Rows[row]["Sim Row Index"];
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("ERROR: GET SCHEDULE, SCHEDULE ROW INDEX, SCHEDULE TYPE NOT FOUND");
                return (int)tableSimSchedule.Rows[row]["Sim Schedule Row Index"];
            }//END IF
        } //END

        //GET CONFERENCE GAME--------------------------------------------------

        public Boolean getConferenceGame(int row, string scheduleType)
        {
            //RETURN CONFERENCE GAME
            if (string.Compare(appResources.getScheduleTypeText(0), scheduleType) == 0)
            {
                // 0 Real Schedule

                //IF INDEX WITHIN REGULAR SCHEDULE ARRAY
                //ELSE IF CONFERENCE TOURNAMENT GAME
                //ELSE RETURN FALSE
                if ((int)tableRealSchedule.Rows[row]["Real Schedule Row Index"] < tableRealRegSeasonSchedule.Rows.Count)
                {
                    return (Boolean)tableRealRegSeasonSchedule.Rows[
                                (int)tableRealSchedule.Rows[row]["Real Schedule Row Index"]
                                ]["Conference Game"];
                }
                else if (string.Compare(appResources.getGameTypeText(1), (string)tableRealSchedule.Rows[row]["Game Type"]) == 0)
                {
                    return true;
                }
                else
                {
                    //conference games in championship tournament won't be counted
                    return false;
                }//END IF
            }
            else if (string.Compare(appResources.getScheduleTypeText(1), scheduleType) == 0)
            {
                // 1 Real RegularSeason
                return (Boolean)tableRealRegSeasonSchedule.Rows[row]["Conference Game"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(4), scheduleType) == 0)
            {
                // 4 Sim Schedule

                //IF INDEX WITHIN REGULAR SCHEDULE ARRAY
                //ELSE IF CONFERENCE TOURNAMENT GAME
                //ELSE RETURN FALSE
                if ((int)tableRealSchedule.Rows[row]["Real Schedule Row Index"] < tableSimRegSeasonSchedule.Rows.Count)
                {
                    return (Boolean)tableSimRegSeasonSchedule.Rows[
                    (int)tableSimSchedule.Rows[row]["Sim Schedule Row Index"]
                    ]["Conference Game"];
                }
                else if (string.Compare(appResources.getGameTypeText(1), (string)tableSimSchedule.Rows[row]["Game Type"]) == 0)
                {
                    return true;
                }
                else
                {
                    //conference games in championship tournament won't be counted
                    return false;
                }//END IF  
            }
            else if (string.Compare(appResources.getScheduleTypeText(5), scheduleType) == 0)
            {
                // 5 Sim RegularSeason
                return (Boolean)tableSimRegSeasonSchedule.Rows[row]["Conference Game"];
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("ERROR: GET SCHEDULE CONFERENCE GAME, SCHEDULE TYPE NOT FOUND");
                return (Boolean)tableSimRegSeasonSchedule.Rows[
                    (int)tableSimSchedule.Rows[row]["Sim Schedule Row Index"]
                    ]["Conference Game"];
            }//END IF
        } //END

        //GET CONFERENCE TOURNAMENT ROUND--------------------------------------

        public int getConfTournRound(int row, string scheduleType)
        {
            //RETURN CONFERENCE TOURNAMENT ROUND
            if (string.Compare(appResources.getScheduleTypeText(0), scheduleType) == 0)
            {
                // 0 Real Schedule
                return (int)tableRealConfTournSchedule.Rows[
                    (int)tableRealSchedule.Rows[row]["Real Schedule Row Index"]
                    ]["Round"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(2), scheduleType) == 0)
            {
                // 2 Real ConferenceTournament
                return (int)tableRealConfTournSchedule.Rows[row]["Round"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(4), scheduleType) == 0)
            {
                // 4 Sim Schedule
                return (int)tableSimConfTournSchedule.Rows[
                    (int)tableSimSchedule.Rows[row]["Sim Schedule Row Index"]
                    ]["Round"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(6), scheduleType) == 0)
            {
                // 6 Sim ConferenceTournament
                return (int)tableSimConfTournSchedule.Rows[row]["Round"];
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("ERROR: GET SCHEDULE CONFERENCE TOURNAMENT ROUND, SCHEDULE TYPE NOT FOUND");
                return (int)tableSimConfTournSchedule.Rows[
                    (int)tableSimSchedule.Rows[row]["Sim Schedule Row Index"]
                    ]["Round"];
            }//END IF
        } //END

        //GET CONFERENCE TOURNAMENT ROW----------------------------------------

        public int getConfTournRow(int row, string scheduleType)
        {
            //RETURN CONFERENCE TOURNAMENT ROW
            if (string.Compare(appResources.getScheduleTypeText(0), scheduleType) == 0)
            {
                // 0 Real Schedule
                return (int)tableRealConfTournSchedule.Rows[
                    (int)tableRealSchedule.Rows[row]["Real Schedule Row Index"]
                    ]["Row"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(2), scheduleType) == 0)
            {
                // 2 Real ConferenceTournament
                return (int)tableRealConfTournSchedule.Rows[row]["Row"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(4), scheduleType) == 0)
            {
                // 4 Sim Schedule
                return (int)tableSimConfTournSchedule.Rows[
                    (int)tableSimSchedule.Rows[row]["Sim Schedule Row Index"]
                    ]["Row"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(6), scheduleType) == 0)
            {
                // 6 Sim ConferenceTournament
                return (int)tableSimConfTournSchedule.Rows[row]["Row"];
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("ERROR: GET SCHEDULE CONFERENCE TOURNAMENT ROW, SCHEDULE TYPE NOT FOUND");
                return (int)tableSimConfTournSchedule.Rows[
                    (int)tableSimSchedule.Rows[row]["Sim Schedule Row Index"]
                    ]["Row"];
            }//END IF
        } //END

        //GET CHAMPIONSHIP TOURNAMENT ROUND------------------------------------

        public int getChampTournRound(int row, string scheduleType)
        {
            //RETURN CHAMPIONSHIP TOURNAMENT ROUND
            if (string.Compare(appResources.getScheduleTypeText(0), scheduleType) == 0)
            {
                // 0 Real Schedule
                return (int)tableRealChampTournSchedule.Rows[
                    (int)tableRealSchedule.Rows[row]["Real Schedule Row Index"]
                    ]["Round"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(3), scheduleType) == 0)
            {
                // 3 Real ChampionshipTournament
                return (int)tableRealChampTournSchedule.Rows[row]["Round"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(4), scheduleType) == 0)
            {
                // 4 Sim Schedule
                return (int)tableSimChampTournSchedule.Rows[
                    (int)tableSimSchedule.Rows[row]["Sim Schedule Row Index"]
                    ]["Round"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(7), scheduleType) == 0)
            {
                // 7 Sim ChampionshipTournament
                return (int)tableSimChampTournSchedule.Rows[row]["Round"];
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("ERROR: GET SCHEDULE CHAMPIONSHIP TOURNAMENT ROUND, SCHEDULE TYPE NOT FOUND");
                return (int)tableSimChampTournSchedule.Rows[
                    (int)tableSimSchedule.Rows[row]["Sim Schedule Row Index"]
                    ]["Round"];
            }//END IF
        } //END

        //GET CHAMPIONSHIP TOURNAMENT ROW--------------------------------------

        public int getChampTournRow(int row, string scheduleType)
        {
            //RETURN CHAMPIONSHIP TOURNAMENT ROW
            if (string.Compare(appResources.getScheduleTypeText(0), scheduleType) == 0)
            {
                // 0 Real Schedule
                return (int)tableRealChampTournSchedule.Rows[
                    (int)tableRealSchedule.Rows[row]["Real Schedule Row Index"]
                    ]["Row"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(3), scheduleType) == 0)
            {
                // 3 Real ChampionshipTournament
                return (int)tableRealChampTournSchedule.Rows[row]["Row"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(4), scheduleType) == 0)
            {
                // 4 Sim Schedule
                return (int)tableSimChampTournSchedule.Rows[
                    (int)tableSimSchedule.Rows[row]["Sim Schedule Row Index"]
                    ]["Row"];
            }
            else if (string.Compare(appResources.getScheduleTypeText(7), scheduleType) == 0)
            {
                // 7 Sim ChampionshipTournament
                return (int)tableSimChampTournSchedule.Rows[row]["Row"];
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("ERROR: GET SCHEDULE CHAMPIONSHIP TOURNAMENT ROW, SCHEDULE TYPE NOT FOUND");
                return (int)tableSimChampTournSchedule.Rows[
                    (int)tableSimSchedule.Rows[row]["Sim Schedule Row Index"]
                    ]["Row"];
            }//END IF
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
            //ROW VARIABLES
            DataRow realRow;
            DataRow simRow;

            //INSTANTIATE ROW
            realRow = tableRealRegSeasonSchedule.NewRow();

            realRow["Conference Game"] = confGame;
            realRow["Real Row Index"] = tableRealSchedule.Rows.Count;

            setRealGame(
                date, 
                opponentName, 
                opponentIndex, 
                opponentRowIndex,
                realPoints, 
                realOpponentPoints, 
                appResources.getGameTypeText(0),
                tableSimSchedule.Rows.Count,
                tableRealRegSeasonSchedule.Rows.Count
                );

            //ADD ROW TO SCHEDULE DATA TABLE
            tableRealRegSeasonSchedule.Rows.Add(realRow);

            //INSTANTIATE ROW
            simRow = tableSimRegSeasonSchedule.NewRow();

            simRow["Conference Game"] = confGame;
            simRow["Sim Row Index"] = tableSimSchedule.Rows.Count;

            setSimGame(
                date, 
                opponentName, 
                opponentIndex, 
                opponentRowIndex,
                simPoints, 
                simOpponentPoints,
                appResources.getGameTypeText(0),
                tableRealSchedule.Rows.Count - 1,
                tableSimRegSeasonSchedule.Rows.Count
                );

            //ADD ROW TO SCHEDULE DATA TABLE
            tableSimRegSeasonSchedule.Rows.Add(simRow);

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
            //ROW VARIABLE
            DataRow row;

            //INSTANTIATE ROW
            row = tableRealConfTournSchedule.NewRow();

            row["Round"] = round;
            row["Real Row Index"] = tableRealSchedule.Rows.Count;

            setRealGame(
                date, 
                opponentName, 
                opponentIndex, 
                opponentRowIndex,
                realPoints, 
                realOpponentPoints,
                appResources.getGameTypeText(1), 
                -1, 
                tableRealConfTournSchedule.Rows.Count
                );

            //ADD ROW TO SCHEDULE DATA TABLE
            tableRealConfTournSchedule.Rows.Add(row);
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
            //ROW VARIABLE
            DataRow row;

            //INSTANTIATE ROW
            row = tableRealChampTournSchedule.NewRow();

            row["Round"] = round;
            row["Real Row Index"] = tableRealSchedule.Rows.Count;

            setRealGame(
                date, 
                opponentName, 
                opponentIndex, 
                opponentRowIndex, 
                realPoints, 
                realOpponentPoints,
                appResources.getGameTypeText(2), 
                -1, 
                tableRealChampTournSchedule.Rows.Count
                );

            //ADD ROW TO SCHEDULE DATA TABLE
            tableRealChampTournSchedule.Rows.Add(row);
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
            //ROW VARIABLE
            DataRow dataTableRow;

            //INSTANTIATE ROW
            dataTableRow = tableSimConfTournSchedule.NewRow();

            dataTableRow["Round"] = round;
            dataTableRow["Row"] = row;
            dataTableRow["Sim Row Index"] = tableSimSchedule.Rows.Count;

            setSimGame(
                date, 
                opponentName, 
                opponentIndex, 
                opponentRowIndex,
                simPoints, 
                simOpponentPoints,
                appResources.getGameTypeText(1), 
                -1, 
                tableSimConfTournSchedule.Rows.Count
                );

            //ADD ROW TO SCHEDULE DATA TABLE
            tableSimConfTournSchedule.Rows.Add(dataTableRow);
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
            //ROW VARIABLE
            DataRow dataTableRow;

            //INSTANTIATE ROW
            dataTableRow = tableSimChampTournSchedule.NewRow();

            dataTableRow["Round"] = round;
            dataTableRow["Row"] = row;
            dataTableRow["Sim Row Index"] = tableSimSchedule.Rows.Count;

            setSimGame(
                date, 
                opponentName, 
                opponentIndex, 
                opponentRowIndex, 
                simPoints, 
                simOpponentPoints,
                appResources.getGameTypeText(2), 
                -1, 
                tableSimChampTournSchedule.Rows.Count
                );

            //ADD ROW TO SCHEDULE DATA TABLE
            tableSimChampTournSchedule.Rows.Add(dataTableRow);
        } //END

        private void setRealGame(
            DateTime date, 
            string opponentName, 
            int opponentIndex, 
            int opponentRowIndex, 
            int realPoints, 
            int realOpponentPoints, 
            string gameType, 
            int simRowIndex, 
            int realScheduleRowIndex
            )
        {
            //ROW VARIABLE
            DataRow row;

            //SET DATE TIME
            DateTime gameDate = new DateTime(date.Year, date.Month, date.Day, 0, 0, 0, 0);

            //SET GAME RESULT
            string gameResult = calculateGameResult(realPoints, realOpponentPoints);

            //INSTANTIATE ROW
            row = tableRealSchedule.NewRow();

            row["Date"] = gameDate;
            row["Opponent Name"] = opponentName;
            row["Opponent Index"] = opponentIndex;
            row["Opponent Row Index"] = opponentRowIndex;
            row["Real Points"] = realPoints;
            row["Real Opponent Points"] = realOpponentPoints;
            row["Game Result"] = gameResult;
            row["Game Type"] = gameType;
            row["Sim Row Index"] = simRowIndex;
            row["Real Schedule Row Index"] = realScheduleRowIndex;

            //ADD ROW TO SCHEDULE DATA TABLE
            tableRealSchedule.Rows.Add(row);
        } //END

        private void setSimGame(
            DateTime date,
            string opponentName,
            int opponentIndex,
            int opponentRowIndex,
            int simPoints,
            int simOpponentPoints,
            string gameType,
            int realRowIndex,
            int simScheduleRowIndex
            )
        {
            //ROW VARIABLE
            DataRow row;

            //SET DATE TIME
            DateTime gameDate = new DateTime(date.Year, date.Month, date.Day, 0, 0, 0, 0);

            //SET GAME RESULT
            string gameResult = calculateGameResult(simPoints, simOpponentPoints);

            //INSTANTIATE ROW
            row = tableSimSchedule.NewRow();

            row["Date"] = gameDate;
            row["Opponent Name"] = opponentName;
            row["Opponent Index"] = opponentIndex;
            row["Opponent Row Index"] = opponentRowIndex;
            row["Sim Points"] = simPoints;
            row["Sim Opponent Points"] = simOpponentPoints;
            row["Game Result"] = gameResult;
            row["Game Type"] = gameType;
            row["Real Row Index"] = realRowIndex;
            row["Sim Schedule Row Index"] = simScheduleRowIndex;

            //ADD ROW TO SCHEDULE DATA TABLE
            tableSimSchedule.Rows.Add(row);

            //SET NEXT GAME SIM SCHEDULE INDEX
            nextGameSimScheduleIndex = calculateNextGameIndex(
                simPoints,
                simOpponentPoints,
                tableSimSchedule.Rows.Count - 1);
        } //END

        //---------------------------------------------------------------------
        //DELETE GAME----------------------------------------------------------
        //---------------------------------------------------------------------

        public void deleteSimTournGame()
        {
            //DELETE CONFERENCE TOURNAMENT GAME
            if (tableSimChampTournSchedule.Rows.Count > 0)
            {
                // 4 Sim Schedule
                tableSimSchedule.Rows[
                    (int)tableSimChampTournSchedule.Rows[tableSimChampTournSchedule.Rows.Count - 1]["Sim Row Index"]
                    ].Delete();
                // 7 Sim ChampionshipTournament
                tableSimChampTournSchedule.Rows[tableSimChampTournSchedule.Rows.Count - 1].Delete();

                //SET NEXT GAME SIM SCHEDULE INDEX
                if (nextGameSimScheduleIndex > tableSimSchedule.Rows.Count)
                {
                    //SET TO CURRENT INDEX PLUS ONE
                    nextGameSimScheduleIndex = tableSimSchedule.Rows.Count;
                }//END IF
            }
            else if (tableSimConfTournSchedule.Rows.Count > 0)
            {
                // 4 Sim Schedule
                tableSimSchedule.Rows[
                    (int)tableSimConfTournSchedule.Rows[tableSimConfTournSchedule.Rows.Count - 1]["Sim Row Index"]
                    ].Delete();
                // 6 Sim ConferenceTournament
                tableSimConfTournSchedule.Rows[tableSimConfTournSchedule.Rows.Count - 1].Delete();

                //SET NEXT GAME SIM SCHEDULE INDEX
                if (nextGameSimScheduleIndex > tableSimSchedule.Rows.Count)
                {
                    //SET TO CURRENT INDEX PLUS ONE
                    nextGameSimScheduleIndex = tableSimSchedule.Rows.Count;
                }//END IF
            }//END IF
        } //END

        //---------------------------------------------------------------------
        //SET------------------------------------------------------------------
        //---------------------------------------------------------------------

        public void setRealGameScore(int row, string scheduleType)
        {
            //SCHEDULE ROW INDEX
            int realRowIndex = 0;
            int simRowIndex = 0;

            //DELETE LENGTH
            int deleteLength = 0;

            if (string.Compare(appResources.getScheduleTypeText(0), scheduleType) == 0)
            {
                // 0 Real Schedule
                simRowIndex = (int)tableRealSchedule.Rows[row]["Sim Row Index"];
                
                tableSimSchedule.Rows[simRowIndex]["Sim Points"] = (int)tableRealSchedule.Rows[row]["Real Points"];
                tableSimSchedule.Rows[simRowIndex]["Sim Opponent Points"] = (int)tableRealSchedule.Rows[row]["Real Opponent Points"];
                tableSimSchedule.Rows[simRowIndex]["Game Result"] = (string)tableRealSchedule.Rows[row]["Game Result"];



                //SET NEXT GAME SIM SCHEDULE INDEX
                nextGameSimScheduleIndex = calculateNextGameIndex(
                    (int)tableSimSchedule.Rows[simRowIndex]["Sim Points"],
                    (int)tableSimSchedule.Rows[simRowIndex]["Sim Opponent Points"],
                    simRowIndex);
            }
            else if (string.Compare(appResources.getScheduleTypeText(1), scheduleType) == 0)
            {
                // 1 Real RegularSeason
                realRowIndex = (int)tableRealRegSeasonSchedule.Rows[row]["Real Schedule Row Index"];

                simRowIndex = (int)tableRealSchedule.Rows[realRowIndex]["Sim Row Index"];

                tableSimSchedule.Rows[simRowIndex]["Sim Points"] = (int)tableRealSchedule.Rows[realRowIndex]["Real Points"];
                tableSimSchedule.Rows[simRowIndex]["Sim Opponent Points"] = (int)tableRealSchedule.Rows[realRowIndex]["Real Opponent Points"];
                tableSimSchedule.Rows[simRowIndex]["Game Result"] = (string)tableRealSchedule.Rows[realRowIndex]["Game Result"];

                //SET NEXT GAME SIM SCHEDULE INDEX
                nextGameSimScheduleIndex = calculateNextGameIndex(
                    (int)tableSimSchedule.Rows[simRowIndex]["Sim Points"],
                    (int)tableSimSchedule.Rows[simRowIndex]["Sim Opponent Points"],
                    simRowIndex);
            }
            else if (string.Compare(appResources.getScheduleTypeText(2), scheduleType) == 0)
            {
                // 2 Real ConferenceTournament
                deleteLength = getLengthOfSchedule(appResources.getScheduleTypeText(6)) - (int)tableRealConfTournSchedule.Rows[row]["Round"];

                for (int index = 0; index < deleteLength; index++)
                {
                    deleteSimTournGame();
                }//END FOR

                realRowIndex = (int)tableRealConfTournSchedule.Rows[row]["Real Row Index"];

                addSimConfTournGame(
                    Convert.ToDateTime(tableRealSchedule.Rows[realRowIndex]["Date"].ToString()),
                    (string)tableRealSchedule.Rows[realRowIndex]["Opponent Name"],
                    (int)tableRealSchedule.Rows[realRowIndex]["Opponent Index"],
                    (int)tableRealSchedule.Rows[realRowIndex]["Opponent Row Index"],
                    (int)tableRealSchedule.Rows[realRowIndex]["Real Points"],
                    (int)tableRealSchedule.Rows[realRowIndex]["Real Opponent Points"],
                    (int)tableRealConfTournSchedule.Rows[row]["Round"],
                    (int)tableRealConfTournSchedule.Rows[row]["Row"]
                    );
            }
            else if (string.Compare(appResources.getScheduleTypeText(3), scheduleType) == 0)
            {
                // 3 Real ChampionshipTournament
                deleteLength = getLengthOfSchedule(appResources.getScheduleTypeText(7)) - (int)tableRealChampTournSchedule.Rows[row]["Round"];

                for (int index = 0; index < deleteLength; index++)
                {
                    deleteSimTournGame();
                }//END FOR

                realRowIndex = (int)tableRealChampTournSchedule.Rows[row]["Real Row Index"];

                addSimChampTournGame(
                    Convert.ToDateTime(tableRealSchedule.Rows[realRowIndex]["Date"].ToString()),
                    (string)tableRealSchedule.Rows[realRowIndex]["Opponent Name"],
                    (int)tableRealSchedule.Rows[realRowIndex]["Opponent Index"],
                    (int)tableRealSchedule.Rows[realRowIndex]["Opponent Row Index"],
                    (int)tableRealSchedule.Rows[realRowIndex]["Real Points"],
                    (int)tableRealSchedule.Rows[realRowIndex]["Real Opponent Points"],
                    (int)tableRealChampTournSchedule.Rows[row]["Round"],
                    (int)tableRealChampTournSchedule.Rows[row]["Row"]
                    );
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("ERROR: SET REAL SCHEDULE POINTS, SCHEDULE TYPE NOT FOUND");
            }//END IF
        } //END

        public void setSimGameScore(int row, string scheduleType, int points, int opponentPoints)
        {
            //SCHEDULE ROW INDEX
            int scheduleRowIndex = 0;

            if (string.Compare(appResources.getScheduleTypeText(4), scheduleType) == 0)
            {
                // 4 Sim Schedule
                tableSimSchedule.Rows[row]["Sim Points"] = points;
                tableSimSchedule.Rows[row]["Sim Opponent Points"] = opponentPoints;
                tableSimSchedule.Rows[row]["Game Result"] = calculateGameResult(points, opponentPoints);

                //SET NEXT GAME SIM SCHEDULE INDEX
                nextGameSimScheduleIndex = calculateNextGameIndex(
                    (int)tableSimSchedule.Rows[row]["Sim Points"],
                    (int)tableSimSchedule.Rows[row]["Sim Opponent Points"],
                    row);
            }
            else if (string.Compare(appResources.getScheduleTypeText(5), scheduleType) == 0)
            {
                // 5 Sim RegularSeason
                scheduleRowIndex = (int)tableSimRegSeasonSchedule.Rows[row]["Sim Row Index"];

                tableSimSchedule.Rows[scheduleRowIndex]["Sim Points"] = points;
                tableSimSchedule.Rows[scheduleRowIndex]["Sim Opponent Points"] = opponentPoints;
                tableSimSchedule.Rows[scheduleRowIndex]["Game Result"] = calculateGameResult(points, opponentPoints);

                //SET NEXT GAME SIM SCHEDULE INDEX
                nextGameSimScheduleIndex = calculateNextGameIndex(
                    (int)tableSimSchedule.Rows[scheduleRowIndex]["Sim Points"],
                    (int)tableSimSchedule.Rows[scheduleRowIndex]["Sim Opponent Points"],
                    scheduleRowIndex);
            }
            else if (string.Compare(appResources.getScheduleTypeText(6), scheduleType) == 0)
            {
                // 6 Sim ConferenceTournament
                scheduleRowIndex = (int)tableSimConfTournSchedule.Rows[row]["Sim Row Index"];

                tableSimSchedule.Rows[scheduleRowIndex]["Sim Points"] = points;
                tableSimSchedule.Rows[scheduleRowIndex]["Sim Opponent Points"] = opponentPoints;
                tableSimSchedule.Rows[scheduleRowIndex]["Game Result"] = calculateGameResult(points, opponentPoints);

                //SET NEXT GAME SIM SCHEDULE INDEX
                nextGameSimScheduleIndex = calculateNextGameIndex(
                    (int)tableSimSchedule.Rows[scheduleRowIndex]["Sim Points"],
                    (int)tableSimSchedule.Rows[scheduleRowIndex]["Sim Opponent Points"],
                    scheduleRowIndex);
            }
            else if (string.Compare(appResources.getScheduleTypeText(7), scheduleType) == 0)
            {
                // 7 Sim ChampionshipTournament
                scheduleRowIndex = (int)tableSimChampTournSchedule.Rows[row]["Sim Row Index"];

                tableSimSchedule.Rows[scheduleRowIndex]["Sim Points"] = points;
                tableSimSchedule.Rows[scheduleRowIndex]["Sim Opponent Points"] = opponentPoints;
                tableSimSchedule.Rows[scheduleRowIndex]["Game Result"] = calculateGameResult(points, opponentPoints);

                //SET NEXT GAME SIM SCHEDULE INDEX
                nextGameSimScheduleIndex = calculateNextGameIndex(
                    (int)tableSimSchedule.Rows[scheduleRowIndex]["Sim Points"],
                    (int)tableSimSchedule.Rows[scheduleRowIndex]["Sim Opponent Points"],
                    scheduleRowIndex);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("ERROR: SET SIM SCHEDULE POINTS, SCHEDULE TYPE NOT FOUND");
            }//END IF
        } //END

        public void setOpponentIndex(int row, string scheduleType, int index)
        {
            if (string.Compare(appResources.getScheduleTypeText(0), scheduleType) == 0)
            {
                // 0 Real Schedule
                tableRealSchedule.Rows[row]["Opponent Index"] = index;
            }
            else if (string.Compare(appResources.getScheduleTypeText(4), scheduleType) == 0)
            {
                // 4 Sim Schedule
                tableSimSchedule.Rows[row]["Opponent Index"] = index;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("ERROR: SET OPPONENT INDEX, SCHEDULE TYPE NOT FOUND");
            }//END IF
        } //END

        public void setOpponentRowIndex(int row, string scheduleType, int rowIndex)
        {
            if (string.Compare(appResources.getScheduleTypeText(0), scheduleType) == 0)
            {
                // 0 Real Schedule
                tableRealSchedule.Rows[row]["Opponent Row Index"] = rowIndex;
            }
            else if (string.Compare(appResources.getScheduleTypeText(4), scheduleType) == 0)
            {
                // 4 Sim Schedule
                tableSimSchedule.Rows[row]["Opponent Row Index"] = rowIndex;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("ERROR: SET OPPONENT INDEX, SCHEDULE TYPE NOT FOUND");
            }//END IF
        } //END

        //---------------------------------------------------------------------
        //CALCULATE------------------------------------------------------------
        //---------------------------------------------------------------------

        public string calculateGameResult(int points, int opponentPoints)
        {
            //CALCULATE GAME RESULT
            if (points > opponentPoints)
            {
                // 1 Win
                return appResources.getGameResultTypeText(1);
            }
            else if (points < opponentPoints)
            {
                // 2 Loss
                return appResources.getGameResultTypeText(2);
            }
            else if (points == 0 && opponentPoints == 0)
            {
                // 0 NotPlayed
                return appResources.getGameResultTypeText(0);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("ERROR: SCHEDULE CALCULATE GAME RESULT, SCHEDULE RESULT NOT FOUND");
                // 0 NotPlayed
                return appResources.getGameResultTypeText(0);
            }//END IF
        } //END

        private int calculateNextGameIndex(int points, int opponentPoints, int index)
        {
            //SET NEXT GAME SIM SCHEDULE INDEX
            if (points > 0 || opponentPoints > 0)
            {
                //SET TO CURRENT INDEX PLUS ONE
                return index + 1;
            }
            else if (nextGameSimScheduleIndex > index)
            {
                //SET TO CURRENT INDEX
                 return index;
            }
            else
            {
                //RETURN ORIGIONAL INDEX
                return nextGameSimScheduleIndex;
            }//END IF
        }//END

        //---------------------------------------------------------------------
        //FIND INDEX OF--------------------------------------------------------
        //---------------------------------------------------------------------

        public int findIndexOf(DateTime date, string scheduleType, string opponentName)
        {
            //IF OPPONENT IS DIV II SCHOOL
            //RETURN NON INDEX
            //ELSE FIND INDEX
            if (string.Compare("DIV II SCHOOL", opponentName) == 0)
            {
                //RETURN NON INDEX
                return -2;
            }
            else
            {
                if (string.Compare(appResources.getScheduleTypeText(0), scheduleType) == 0)
                {
                    // 0 Real Schedule

                    //FOR ALL GAMES IN SCHEDULE
                    for (int index = 0; index < tableRealSchedule.Rows.Count; index++)
                    {
                        //IF DATES AND TEAM NAMES MATCH
                        //RETURN INDEX
                        if (DateTime.Compare(Convert.ToDateTime(tableRealSchedule.Rows[index]["Date"].ToString()), date) == 0 &&
                            string.Compare((string)tableRealSchedule.Rows[index]["Opponent Name"], opponentName) == 0)
                        {
                            //RETURN INDEX
                            return index;
                        } //END
                    } //END FOR ALL GAMES IN SCHEDULE
                }
                else if (string.Compare(appResources.getScheduleTypeText(4), scheduleType) == 0)
                {
                    // 4 Sim Schedule

                    //FOR ALL GAMES IN SCHEDULE
                    for (int index = 0; index < tableSimSchedule.Rows.Count; index++)
                    {
                        //IF DATES AND TEAM NAMES MATCH
                        //RETURN INDEX
                        if (DateTime.Compare(Convert.ToDateTime(tableSimSchedule.Rows[index]["Date"].ToString()), date) == 0 &&
                            string.Compare((string)tableSimSchedule.Rows[index]["Opponent Name"], opponentName) == 0)
                        {
                            //RETURN INDEX
                            return index;
                        } //END
                    } //END FOR ALL GAMES IN SCHEDULE
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("ERROR: FIND INDEX OF, SCHEDULE TYPE NOT FOUND");
                }//END IF
            } //END IF OPPONENT IS DIV II SCHOOL

            //PRINT ERROR MESSAGES
            System.Windows.Forms.MessageBox.Show("SCHEDULE DATE " + date + " OPPONENT " + opponentName);
            System.Windows.Forms.MessageBox.Show("ERROR: TEAM CLASS NO INDEX VALUE FOUND");

            //RETURN NON INDEX
            return -3;

        } //END

        //---------------------------------------------------------------------
        //GET LENGTH OF SCHEDULE-----------------------------------------------
        //---------------------------------------------------------------------

        public int getLengthOfSchedule(string scheduleType)
        {
            //RETURN NUMBER OF GAMES IN SCHEDULE
            if (string.Compare(appResources.getScheduleTypeText(0), scheduleType) == 0)
            {
                // 0 Real Schedule
                return tableRealSchedule.Rows.Count; 
            }
            else if (string.Compare(appResources.getScheduleTypeText(1), scheduleType) == 0)
            {
                // 1 Real RegularSeason
                return tableRealRegSeasonSchedule.Rows.Count;
            }
            else if (string.Compare(appResources.getScheduleTypeText(2), scheduleType) == 0)
            {
                // 2 Real ConferenceTournament
                return tableRealConfTournSchedule.Rows.Count;
            }
            else if (string.Compare(appResources.getScheduleTypeText(3), scheduleType) == 0)
            {
                // 3 Real ChampionshipTournament
                return tableRealChampTournSchedule.Rows.Count;
            }
            else if (string.Compare(appResources.getScheduleTypeText(4), scheduleType) == 0)
            {
                // 4 Sim Schedule
                return tableSimSchedule.Rows.Count;
            }
            else if (string.Compare(appResources.getScheduleTypeText(5), scheduleType) == 0)
            {
                // 5 Sim RegularSeason
                return tableSimRegSeasonSchedule.Rows.Count;
            }
            else if (string.Compare(appResources.getScheduleTypeText(6), scheduleType) == 0)
            {
                // 6 Sim ConferenceTournament
                return tableSimConfTournSchedule.Rows.Count;
            }
            else if (string.Compare(appResources.getScheduleTypeText(7), scheduleType) == 0)
            {
                // 7 Sim ChampionshipTournament
                return tableSimChampTournSchedule.Rows.Count;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("ERROR: GET SCHEDULE LENGTH, SCHEDULE TYPE NOT FOUND");
                return 0;
            }//END IF
        } //END

        

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    tableRealSchedule.Dispose();
                    tableRealRegSeasonSchedule.Dispose();
                    tableRealConfTournSchedule.Dispose();
                    tableRealChampTournSchedule.Dispose();
                    tableSimSchedule.Dispose();
                    tableSimRegSeasonSchedule.Dispose();
                    tableSimConfTournSchedule.Dispose();
                    tableSimChampTournSchedule.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        ~Schedule()
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

        public void DisposeSchedule()
        {
            Dispose();
        }

    }
}
