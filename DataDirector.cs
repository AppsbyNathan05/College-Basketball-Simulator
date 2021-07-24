using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_Basketball_Simulator
{
    class DataDirector : IDisposable
    {
        //STATIC DATA RESOURCES
        private Resources appResources = new Resources();

        //SELECTION AND ORDER
        private SelectionAndOrder selectionAndOrder = new SelectionAndOrder();

        //DATA TABLES----------------------------------------------------------

        //DISPLAY TABLES
        private DataTable schedSlectConferencesDataTable = new DataTable();
        private DataTable schedSlectTeamsDataTable = new DataTable();
        private DataTable schedSlectDatesDataTable = new DataTable();

        //SAVE AND LOAD TABLES
        private DataTable saveAsDataTable = new DataTable();
        private DataTable loadDataTable = new DataTable();

        //SCHEDULE DATA TABLES
        private TeamScheduleTable[] teamScheduleArray = new TeamScheduleTable[353];
        private DateScheduleTable[] dateScheduleArray = new DateScheduleTable[366]; //WAS 210

        //CONFERENCE STANDINGS TABLES
        private ConferenceStandingsTable[] conferenceStandingsArray = new ConferenceStandingsTable[32];

        //TOP 25 TABLE
        private DataTable top25DataTable = new DataTable();

        //TOURNAMENT TABLE
        private DataTable champTournListDataTable = new DataTable();

        private bool disposedValue = false; // To detect redundant calls

        //UPDATED--------------------------------------------------------------

        //SCHEDULE DATA UPDATED
        private Boolean[] arrayBoolTeamScheduleUpdated = new Boolean[353];
        private Boolean[] arrayBoolDateScheduleUpdated = new Boolean[366];

        //CONFERENCE STANDINGS UPDATED
        private Boolean boolConferenceStandingsUpdated = false;

        //TOP 25 UPDATED
        private Boolean boolTop25Updated = false;

        //TOURNAMENT UPDATED
        private Boolean boolchampTournListUpdated = false;

        //FILLED---------------------------------------------------------------

        private Boolean boolschedSlectDatesLoaded = false;

        //ORDER----------------------------------------------------------------

        //SCHEDULE DATA ORDER
        private int indexTeamSchedule = 0;
        private int indexDateSchedule = 0;
        
        //CONFERENCE STANDINGS ORDER
        private int[] arrayIntIndexConferenceStandings = new int[32];

        //START DATE-----------------------------------------------------------

        DateTime startDate = new DateTime(2020, 9, 1, 0, 0, 0, 0);

        //---------------------------------------------------------------------

        public DataDirector()
        {
            //INITIALIZE DISPLAY DATA TABLES

            //INITIALIZE CONFERENCE DISPLAY DATATABLES COLUMN HEADINGS
            schedSlectConferencesDataTable.Columns.Add("Conference", typeof(string));

            //INITIALIZE TEAM DISPLAY DATATABLES COLUMN HEADINGS
            schedSlectTeamsDataTable.Columns.Add("Team", typeof(string));
            schedSlectTeamsDataTable.Columns.Add("Conference", typeof(string));

            //INITIALIZE DATE DISPLAY DATATABLES COLUMN HEADINGS
            schedSlectDatesDataTable.Columns.Add("Date", typeof(DateTime));

            //INITIALIZE SAVE AND LOAD DATA TABLES

            //INITIALIZE SAVE DATATABLES COLUMN HEADINGS
            saveAsDataTable.Columns.Add("Overwrite?", typeof(string));
            saveAsDataTable.Columns.Add("File Name", typeof(string));
            saveAsDataTable.Columns.Add("Delete?", typeof(string));

            //INITIALIZE LOAD DATATABLES COLUMN HEADINGS
            loadDataTable.Columns.Add("Load?", typeof(string));
            loadDataTable.Columns.Add("File Name", typeof(string));
            loadDataTable.Columns.Add("Delete?", typeof(string));

            //INITIALIZE SCHEDULE DATA TABLES

            //FOR EVERY TEAM
            for (int teamIndex = 0; teamIndex < teamScheduleArray.Length; teamIndex++)
            {
                //INITIALIZE TEAM SCHEDULE DATA TABLE
                teamScheduleArray[teamIndex] = new TeamScheduleTable();
            } //END FOR

            //INITIAL DATE FOR LOOP
            DateTime date = new DateTime(startDate.Year, startDate.Month, startDate.Day, 0, 0, 0, 0);

            //FOR EVERY DAY IN THE ARRAY
            for (int dateIndex = 0; dateIndex < dateScheduleArray.Length; dateIndex++)
            {
                //INITIALIZE DATE SCHEDULE DATA TABLE
                dateScheduleArray[dateIndex] = new DateScheduleTable(date);

                //INCREMENT DATE
                date = date.AddDays(1.0);
            } //END FOR


            //INITIALIZE CONFERENCE STANDINGS DATA TABLES

            for (int conferenceIndex = 0; conferenceIndex < conferenceStandingsArray.Length; conferenceIndex++)
            {
                //INITIALIZE STANDINGS
                conferenceStandingsArray[conferenceIndex] = new ConferenceStandingsTable(conferenceIndex);

                //INITIALIZE INDEXES
                arrayIntIndexConferenceStandings[conferenceIndex] = conferenceIndex;
            } //END FOR

            //INITIALIZE TOP 25 DATA TABLE
            top25DataTable.Columns.Add("Rank", typeof(int));
            top25DataTable.Columns.Add("Team", typeof(string));
            top25DataTable.Columns.Add("Conference", typeof(string));
            top25DataTable.Columns.Add("Weighted %", typeof(double));
            top25DataTable.Columns.Add("Wins", typeof(int));
            top25DataTable.Columns.Add("Losses", typeof(int));
            top25DataTable.Columns.Add("Win %", typeof(double));

            //INITIALIZE TOURNAMENT DATA TABLE
            champTournListDataTable.Columns.Add("Seed", typeof(int));
            champTournListDataTable.Columns.Add("Region", typeof(string));
            champTournListDataTable.Columns.Add("Bid", typeof(string));
            champTournListDataTable.Columns.Add("Team", typeof(string));
            champTournListDataTable.Columns.Add("Conference", typeof(string));
            champTournListDataTable.Columns.Add("Wins", typeof(int));
            champTournListDataTable.Columns.Add("Losses", typeof(int));
            champTournListDataTable.Columns.Add("Weighted %", typeof(double));

            //SET ALL UPDATED TO FALSE
            updateDataDirector();

        } //END

        //---------------------------------------------------------------------
        //---------------------------------------------------------------------
        //UPDATE DATA DIRECTOR-------------------------------------------------
        //---------------------------------------------------------------------
        //---------------------------------------------------------------------

        public void updateDataDirector(SettingsDirector settings)
        {
            //RESET UPDATE STATUS
            updateDataDirector();

            //IF START DATE INCORRECT
            //RESET DATE SCHEDULE ARRAY
            if (0 != DateTime.Compare(startDate, settings.getEarliestGameDate()))
            {
                //UPDATE START DATE
                startDate = new DateTime(
                settings.getEarliestGameDate().Year,
                settings.getEarliestGameDate().Month,
                settings.getEarliestGameDate().Day,
                0, 0, 0, 0);

                //INITIAL DATE FOR LOOP
                DateTime date = new DateTime(startDate.Year, startDate.Month, startDate.Day, 0, 0, 0, 0);

                //FOR EVERY DAY IN THE ARRAY
                for (int dateIndex = 0; dateIndex < dateScheduleArray.Length; dateIndex++)
                {
                    //RESET DATE SCHEDULE DATA TABLE
                    dateScheduleArray[dateIndex].reSetDateSchedule(date);

                    //INCREMENT DATE
                    date = date.AddDays(1.0);
                } //END FOR 
            }// END IF

        } //END

        //RESET UPDATE STATUS--------------------------------------------------

        public void updateDataDirector()
        {
            //SET ALL UPDATED TO FALSE

            //TEAM SCHEDULE DATA TABLES
            for (int index = 0; index < arrayBoolTeamScheduleUpdated.Length; index++)
            {
                //SET UPDATED TO FALSE
                arrayBoolTeamScheduleUpdated[index] = false;
            } //END FOR

            //DATE SCHEDULE DATA TABLES
            for (int index = 0; index < arrayBoolDateScheduleUpdated.Length; index++)
            {
                //SET UPDATED TO FALSE
                arrayBoolDateScheduleUpdated[index] = false;
            } //END FOR

            //CONFERENCE STANDINGS TABLES
            //SET UPDATED TO FALSE
            boolConferenceStandingsUpdated = false;

            //TOP 25 TABLE
            //SET UPDATED TO FALSE
            boolTop25Updated = false;

            //TOURNAMENT TABLE
            //SET UPDATED TO FALSE
            boolchampTournListUpdated = false;

            //RANKINGS
            //SET UPDATED TO FALSE
            selectionAndOrder.setRankingsUpdated(false);
        } //END

        //---------------------------------------------------------------------
        //---------------------------------------------------------------------
        //TOURNAMENT CONTAINER-------------------------------------------------
        //---------------------------------------------------------------------
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
        //---------------------------------------------------------------------
        //GET DATA TABLES------------------------------------------------------
        //---------------------------------------------------------------------
        //---------------------------------------------------------------------

        //---------------------------------------------------------------------
        //GET DISPLAY DATA TABLES----------------------------------------------
        //---------------------------------------------------------------------

        //CONFERENCE-----------------------------------------------------------

        public DataTable getSelectConferencesDataTable()
        {
            //RETURN SELECT CONFERENCE TOURNAMENT DATA TABLE 
            return schedSlectConferencesDataTable;
        } //END

        //TEAM-----------------------------------------------------------------

        public DataTable getSelectTeamsDataTable()
        {
            //RETURN SCHEDULE SELECT TEAMS DATA TABLE
            return schedSlectTeamsDataTable;
        } //END

        //DATE-----------------------------------------------------------------

        public DataTable getSelectDatesDataTable()
        {
            //RETURN SCHEDULE SELECT DATES DATA TABLE
            return schedSlectDatesDataTable;
        } //END

        //---------------------------------------------------------------------
        //GET SAVE AND LOAD DATA TABLES----------------------------------------
        //---------------------------------------------------------------------

        //SAVE-----------------------------------------------------------------

        public DataTable getSaveAsDataTable()
        {
            //RETURN SAVE AS DATA TABLE
            return saveAsDataTable;
        } //END

        //LOAD----------------------------------------------------------------

        public DataTable getLoadDataTable()
        {
            //RETURN LOAD DATA TABLE
            return loadDataTable;
        } //END

        //---------------------------------------------------------------------
        //GET SCHEDULE DATA TABLES---------------------------------------------
        //---------------------------------------------------------------------

        //TEAM SCHEDULE DATA TABLE---------------------------------------------

        public DataTable getTeamSchedDataTable()
        {
        
            //FIND INDEX OF TEAM NAME
            //RETURN TEAM SCHEDULE DATA TABLE
            return teamScheduleArray[indexTeamSchedule].getTeamScheduleDataTable();
        } //END

        //DATE SCHEDULE DATA TABLE---------------------------------------------

        public DataTable getDateSchedDataTable()
        {
            //RETURN DATE SCHEDULE DATA TABLE
            return dateScheduleArray[indexDateSchedule].getDateScheduleDataTable();
        } //END

        //---------------------------------------------------------------------
        //GET CONFERENCE STANDINGS DATA TABLES---------------------------------
        //---------------------------------------------------------------------

        public DataTable getConferenceStandingsDataTable(int conferenceIndex)
        {
            //RETURN CONFERENCE STANDINGS DATA TABLE
            return conferenceStandingsArray[getConferenceOrderIndex(conferenceIndex)].getConferenceStandingsDataTable();
        } //END

        //---------------------------------------------------------------------
        //GET TOP 25 DATA TABLE------------------------------------------------
        //---------------------------------------------------------------------

        public DataTable getTop25DataTable()
        {
            //RETURN TOP 25 DATA TABLE
            return top25DataTable;
        } //END

        //---------------------------------------------------------------------
        //GET TOURNAMENT DATA TABLES-------------------------------------------
        //---------------------------------------------------------------------

        //CHAMPIONSHIP TOURNAMENT PROJECTION LIST DATA TABLE-------------------

        public DataTable getChampTournProListDataTable()
        {
            //RETURN CHAMPIONSHIP TOURNAMENT PROJECTION LIST DATA TABLE
            return champTournListDataTable;
        } //END

        //CHAMPIONSHIP TOURNAMENT LIST SAVE DATA TABLE-------------------------

        public DataTable getChampTournListDataTable()
        {
            //RETURN CHAMPIONSHIP TOURNAMENT LIST DATA TABLE
            return champTournListDataTable;
        } //END

        //---------------------------------------------------------------------
        //---------------------------------------------------------------------
        //FILL DATA TABLES-----------------------------------------------------
        //---------------------------------------------------------------------
        //---------------------------------------------------------------------

        //---------------------------------------------------------------------
        //FILL DISPLAY DATA TABLES---------------------------------------------
        //---------------------------------------------------------------------

        //CONFERENCE-----------------------------------------------------------

        public void fillSelectConferencesDataTable()
        {
            //ROW VARIABLE
            DataRow row;

            //CLEAR DATA TABLE
            schedSlectConferencesDataTable.Rows.Clear();

            for (int conferenceIndex = 0; conferenceIndex < appResources.getLengthOfConferenceNames(); conferenceIndex++)
            {
                //MAKE ROW
                row = schedSlectConferencesDataTable.NewRow();

                //POPULATE ROW
                row[0] = appResources.getConferenceName(conferenceIndex);

                //ADD ROW TO DATA TABLE
                schedSlectConferencesDataTable.Rows.Add(row);
            } //END FOR
        } //END

        //TEAM-----------------------------------------------------------------

        public void fillSelectTeamsDataTable(int conferenceIndex)
        {
            //ROW VARIABLE
            DataRow row;

            //CLEAR DATA TABLE
            schedSlectTeamsDataTable.Rows.Clear();

            //IF ALL TEAMS ARE SELECTED (== 0)
            //ELSE IF A CONFERENCE IS SELECTED (> 0)
            if (conferenceIndex == 0)
            {

                //FOR ALL TEAMS IN THE COLLEGE BASKETBALL
                //POPULATE DATA TABLE
                for (int teamIndex = 0; teamIndex < appResources.getLengthOfTeamNames(); teamIndex++)
                {
                    //MAKE ROW
                    row = schedSlectTeamsDataTable.NewRow();

                    //POPULATE ROW
                    row[0] = appResources.getTeamName(teamIndex);
                    row[1] = appResources.getTeamsConferenceName(teamIndex);

                    //ADD ROW TO DATA TABLE
                    schedSlectTeamsDataTable.Rows.Add(row);
                }//END FOR

            }
            else if (conferenceIndex > 0)
            {
                //GET CONFERENCE ARRAY OF TEAM INDEXES
                int[] arrayIntTeamIndexes = appResources.getConferenceTeamIndexes(conferenceIndex - 1);

                //FOR ALL TEAMS IN THE CONFERENCE
                //POPULATE DATA TABLE
                for (int index = 0; index < arrayIntTeamIndexes.Length; index++)
                {
                    //MAKE ROW
                    row = schedSlectTeamsDataTable.NewRow();

                    //POPULATE ROW
                    row[0] = appResources.getTeamName(arrayIntTeamIndexes[index]);
                    row[1] = appResources.getConferenceName(conferenceIndex - 1);

                    //ADD ROW TO DATA TABLE
                    schedSlectTeamsDataTable.Rows.Add(row);
                }//END FOR

            } //END IF

        } //END

        //DATE-----------------------------------------------------------------

        public void fillSelectDatesDataTable()
        {
            //IF DATA TABLE HASN'T BEEN FILLED
            //FILL DATES DATA TABLE
            if (!boolschedSlectDatesLoaded)
            {
                //INITIAL DATE FOR LOOP
                DateTime date = new DateTime(startDate.Year, startDate.Month, startDate.Day, 0, 0, 0, 0);

                //ROW VARIABLE
                DataRow row;

                //CLEAR DATA TABLE
                schedSlectDatesDataTable.Rows.Clear();

                //FOR ALL DATES
                //POPULATE DATA TABLE
                for (int dayIndex = 0; dayIndex < dateScheduleArray.Length; dayIndex++)
                {
                    //MAKE ROW
                    row = schedSlectDatesDataTable.NewRow();

                    //POPULATE ROW
                    row[0] = date;

                    //ADD ROW TO DATA TABLE
                    schedSlectDatesDataTable.Rows.Add(row);
                    
                    date = date.AddDays(1.0);
                }//END FOR 
            }//END IF

            boolschedSlectDatesLoaded = true;

        } //END

        //---------------------------------------------------------------------
        //FILL SAVE AND LOAD DATA TABLES---------------------------------------
        //---------------------------------------------------------------------

        //SAVE-----------------------------------------------------------------

        public void fillSaveAsDataTable(string[] fileNameArray)
        {
            //ROW VARIABLE
            DataRow row;

            //CLEAR DATA TABLE
            saveAsDataTable.Rows.Clear();

            //FOREACH FILE IN SAVE FOLDER
            foreach (string fileName in fileNameArray)
            {
                //MAKE ROW
                row = saveAsDataTable.NewRow();

                //POPULATE ROW
                row[0] = "Overwrite";
                row[1] = fileName;
                row[2] = "Delete";

                //ADD ROW TO DATA TABLE
                saveAsDataTable.Rows.Add(row);
            } //END FOREACH FILE IN SAVE FOLDER
        } //END

        //LOAD-----------------------------------------------------------------

        public void fillLoadDataTable(string[] fileNameArray)
        {
            //ROW VARIABLE
            DataRow row;

            //CLEAR DATA TABLE
            loadDataTable.Rows.Clear();

            //FOREACH FILE IN SAVE FOLDER
            foreach (string fileName in fileNameArray)
            {
                //MAKE ROW
                row = loadDataTable.NewRow();

                //POPULATE ROW
                row[0] = "Load";
                row[1] = fileName;
                row[2] = "Delete";

                //ADD ROW TO DATA TABLE
                loadDataTable.Rows.Add(row);
            } //END FOREACH FILE IN SAVE FOLDER
        } //END

        //---------------------------------------------------------------------
        //FILL SCHEDULE DATA TABLES--------------------------------------------
        //---------------------------------------------------------------------

        //TEAM SCHEDULE DATA TABLE---------------------------------------------

        public void fillTeamSchedDataTable(Schedule schedule, int teamIndex)
        {
            //SET SCHEDULE INDEX
            indexTeamSchedule = teamIndex;

            //IF SCHEDULE NOT UPDATED
            //FILL SCHEDULE
            if (arrayBoolTeamScheduleUpdated[teamIndex] == false)
            {
                //FILL SCHEDULE
                teamScheduleArray[teamIndex].fillTeamSchedDataTable(schedule);

            } //END IF

            //SET UPDATED TO TRUE
            arrayBoolTeamScheduleUpdated[teamIndex] = true;

            //DELETE----------------------------------------------------------------------------------
            Console.WriteLine(" ");

        } //END

        //DATE SCHEDULE DATA TABLE---------------------------------------------

        public void fillDateSchedDataTable(int dateIndex, Team[] teamsArray)
        {
            //SET SCHEDULE INDEX
            indexDateSchedule = dateIndex;

            //IF SCHEDULE NOT UPDATED
            //FILL SCHEDULE
            if (arrayBoolDateScheduleUpdated[dateIndex] == false)
            {
                //FILL SCHEDULE
                dateScheduleArray[dateIndex].fillDateSchedDataTable(teamsArray);

            } //END IF

            //SET UPDATED TO TRUE
            arrayBoolDateScheduleUpdated[dateIndex] = true;
        } //END

        //---------------------------------------------------------------------
        //FILL CONFERENCE STANDINGS DATA TABLES--------------------------------
        //---------------------------------------------------------------------

        public void fillConferenceStandingsDataTables(int firstConferenceIndex, Team[] teamsArray)
        {
            //SET CONFERENCE ORDER
            setConferenceOrderIndexes(firstConferenceIndex);

            //IF RANKINGS NOT UPDATED
            //UPDATE RANKINGS
            if (!selectionAndOrder.getRankingsUpdated())
            {
                selectionAndOrder.updateRankings(teamsArray);
            } //END IF

            //IF STANDINGS NOT UPDATED
            //FILL STANDINGS
            if (boolConferenceStandingsUpdated == false)
            {
                //FOR ALL CONFERENCES
                //FILL CONFERECE STANDINGS DATA TABLE
                for (int conferenceIndex = 0; conferenceIndex < conferenceStandingsArray.Length; conferenceIndex++)
                {
                    //GET CONFERENCE TEAMS CONFERENCE WIN PERCENTAGES
                    double[] arrayDoubleOrderValues = selectionAndOrder.getConferenceOrderValues(teamsArray, conferenceIndex);

                    //GET ORDER FOR CONFERENCE STANDINGS
                    int[] arrayIntOrder = selectionAndOrder.getOrderIndexes(arrayDoubleOrderValues, arrayDoubleOrderValues.Length);

                    //FILL CONFERECE STANDINGS DATA TABLE
                    conferenceStandingsArray[conferenceIndex].fillConferenceStandingsDataTable(
                        teamsArray, 
                        selectionAndOrder.getRankings(), 
                        arrayIntOrder);
                } //END FOR
            } //END IF

            //SET UPDATED TO TRUE
            boolConferenceStandingsUpdated = true;

        } //END

        //---------------------------------------------------------------------
        //FILL TOP 25 DATA TABLE-----------------------------------------------
        //---------------------------------------------------------------------

        public void fillTop25DataTable(Team[] teamsArray)
        {
            //IF RANKINGS NOT UPDATED
            //UPDATE RANKINGS
            if (selectionAndOrder.getRankingsUpdated() == false)
            {
                selectionAndOrder.updateRankings(teamsArray);
            } //END IF

            //IF TOP 25 NOT UPDATED
            //FILL TOP 25
            if (boolTop25Updated == false)
            {
                //ROW VARIABLE
                DataRow row;

                int[] arrayIntOrder = selectionAndOrder.getOrderIndexes(selectionAndOrder.getRankings(), appResources.getLengthOfTeamNames());

                //CLEAR DATA TABLE
                top25DataTable.Rows.Clear();

                //FOR ALL TEAMS
                //FILL TOP 25 DATATABLE
                for (int rankIndex = 0; rankIndex < arrayIntOrder.Length; rankIndex++)
                {
                    //top25DataTable 
                    //arrayIntOrder

                    //MAKE ROW
                    row = top25DataTable .NewRow();

                    //POPULATE ROWS
                    row[0] = rankIndex + 1;
                    row[1] = teamsArray[arrayIntOrder[rankIndex]].teamNameDisplay;
                    row[2] = teamsArray[arrayIntOrder[rankIndex]].conferenceNameDisplay;
                    row[3] = selectionAndOrder.getRankings()[arrayIntOrder[rankIndex]];
                    row[4] = teamsArray[arrayIntOrder[rankIndex]].getWins();
                    row[5] = teamsArray[arrayIntOrder[rankIndex]].getLosses();
                    row[6] = (double)teamsArray[arrayIntOrder[rankIndex]].getWins() /
                        (double)(teamsArray[arrayIntOrder[rankIndex]].getLosses() +
                        teamsArray[arrayIntOrder[rankIndex]].getWins());

                    //ADD ROW TO DATA TABLE
                    top25DataTable .Rows.Add(row);
                }//END FOR

            } //END IF

            //SET UPDATED TO TRUE
            boolTop25Updated = true;

        } //END

        //---------------------------------------------------------------------
        //FILL TOURNAMENT DATA TABLES------------------------------------------
        //---------------------------------------------------------------------

        //CHAMPIONSHIP TOURNAMENT PROJECTION LIST DATA TABLE-------------------

        public void fillChampTournProListDataTable(SimulationDirector simulationDirector)
        {
            getChampTournListDataTable(simulationDirector, true);
        } //END

        //CHAMPIONSHIP TOURNAMENT LIST SAVE DATA TABLE-------------------------

        public void fillChampTournListDataTable(SimulationDirector simulationDirector)
        {
            getChampTournListDataTable(simulationDirector, false);
        } //END

        private void getChampTournListDataTable(SimulationDirector simulationDirector, Boolean projected)
        {
            int[] arrayIntRankingsOrderTeamIndexes = new int[appResources.getLengthOfTeamNames()];

            //IF RANKINGS NOT UPDATED
            //UPDATE RANKINGS
            if (selectionAndOrder.getRankingsUpdated() == false)
            {
                selectionAndOrder.updateRankings(simulationDirector.getTeams());
            } //END IF

            //IF TOURNAMENT LIST NOT UPDATED
            //FILL TOURNAMENT LIST 
            if (boolchampTournListUpdated == false)
            {
                //ROW VARIABLE
                DataRow row;

                //TEAM INDEXES IN ORDER OF RANK
                if (!selectionAndOrder.getContainerUpdated(simulationDirector.getCurrentSimulationDate()))
                {
                    selectionAndOrder.setOverallChampRankingsTeamIndexes(simulationDirector); 
                }//END IF

                Array.Copy(
                    selectionAndOrder.getTournamentContainer().getRanked353ChampTournReturnIndexes(),
                    arrayIntRankingsOrderTeamIndexes,
                    arrayIntRankingsOrderTeamIndexes.Length);

                //CLEAR DATA TABLE
                champTournListDataTable.Rows.Clear();

                //ADD TOURNAMENT TEAMS FROM GLOBALS

                for (int tournIndex = 0; tournIndex < selectionAndOrder.getTournamentContainer().getRanked68ChampTournIndexes().Length; tournIndex++)
                {
                    //MAKE ROW
                    row = champTournListDataTable.NewRow();

                    //POPULATE ROWS
                    row[0] = selectionAndOrder.getTournamentContainer().getRanked68ChampTournSeeds()[tournIndex];
                    row[1] = selectionAndOrder.getTournamentContainer().getRanked68ChampTournRegions()[tournIndex];

                    //ASSIGN BID TYPE
                    //IF CONFERENCE CHAMPION
                    //ELSE IF PLAY IN
                    //ELSE AT LARGE
                    if (Array.IndexOf(
                        selectionAndOrder.getTournamentContainer().get32ConfChampsIndexes(), 
                        selectionAndOrder.getTournamentContainer().getRanked68ChampTournIndexes()[tournIndex])
                        > -1)
                    {
                        //IF PLAY IN
                        //ELSE CONFERENCE CHAMP
                        if (Array.IndexOf(
                            selectionAndOrder.getTournamentContainer().get8PlayInIndexes(), 
                            selectionAndOrder.getTournamentContainer().getRanked68ChampTournIndexes()[tournIndex])
                            > -1)
                        {
                            row[2] = "Play In CC";
                        }
                        else
                        {
                            row[2] = "Conf Champ";
                        }//END IF
                    }
                    else if (Array.IndexOf(
                        selectionAndOrder.getTournamentContainer().get8PlayInIndexes(), 
                        selectionAndOrder.getTournamentContainer().getRanked68ChampTournIndexes()[tournIndex])
                        > -1)
                    {
                        row[2] = "Play In AL";
                    }
                    else
                    {
                        row[2] = "At Large";
                    }//END IF

                    row[3] = simulationDirector.getTeamNameDisplay(selectionAndOrder.getTournamentContainer().getRanked68ChampTournIndexes()[tournIndex]);
                    row[4] = simulationDirector.getConferenceNameDisplay(selectionAndOrder.getTournamentContainer().getRanked68ChampTournIndexes()[tournIndex]);
                    row[5] = simulationDirector.getWins(selectionAndOrder.getTournamentContainer().getRanked68ChampTournIndexes()[tournIndex]);
                    row[6] = simulationDirector.getLosses(selectionAndOrder.getTournamentContainer().getRanked68ChampTournIndexes()[tournIndex]);
                    row[7] = selectionAndOrder.getRankings()[selectionAndOrder.getTournamentContainer().getRanked68ChampTournIndexes()[tournIndex]];

                    //ADD ROW TO DATA TABLE
                    champTournListDataTable.Rows.Add(row);
                }//END FOR

                //IF PROJECTED ADD REST FROM RETURNED ARRAY

                if (projected)
                {
                    for (int teamIndex = selectionAndOrder.getTournamentContainer().getRanked68ChampTournIndexes().Length; teamIndex < arrayIntRankingsOrderTeamIndexes.Length; teamIndex++)
                    {
                        //MAKE ROW
                        row = champTournListDataTable.NewRow();
                        
                        //POPULATE ROWS
                        row[3] = simulationDirector.getTeamNameDisplay(arrayIntRankingsOrderTeamIndexes[teamIndex]);
                        row[4] = simulationDirector.getConferenceNameDisplay(arrayIntRankingsOrderTeamIndexes[teamIndex]);
                        row[5] = simulationDirector.getWins(arrayIntRankingsOrderTeamIndexes[teamIndex]);
                        row[6] = simulationDirector.getLosses(arrayIntRankingsOrderTeamIndexes[teamIndex]);
                        row[7] = selectionAndOrder.getRankings()[arrayIntRankingsOrderTeamIndexes[teamIndex]];

                        //ADD ROW TO DATA TABLE
                        champTournListDataTable.Rows.Add(row); 
                    }//END FOR
                }//END IF

            } //END IF

            //SET UPDATED TO TRUE
            boolchampTournListUpdated = true;
        } //END

        //---------------------------------------------------------------------
        //---------------------------------------------------------------------
        //SCHEDULE DATA TABLES-------------------------------------------------
        //---------------------------------------------------------------------
        //---------------------------------------------------------------------

        //TEAM SCHEDULE DATA TABLE---------------------------------------------


        //DATE SCHEDULE DATA TABLE---------------------------------------------

        private int getDateScheduleIndex(DateTime date)
        {
            //FIND WHICH DATE DATA TABLE SCHEDULE TO RETURN
            for (int dateIndex = 0; dateIndex < dateScheduleArray.Length; dateIndex++)
            {
                //IF DATE MATCHES
                if (DateTime.Compare(dateScheduleArray[dateIndex].getDate(), date) == 0)
                {
                    //RETURN DATE SCHEDULE DATA TABLE
                    return dateIndex;
                } //END IF
            } //END FOR

            //SHOW ERROR MESSAGE
            System.Windows.Forms.MessageBox.Show("ERROR: NO DATE MATCHED");
            //RETURN DEFAULT VALUE
            return 0;

        } //END

        //---------------------------------------------------------------------
        //---------------------------------------------------------------------
        //CONFERENCE STANDINGS DATA TABLES-------------------------------------
        //---------------------------------------------------------------------
        //---------------------------------------------------------------------

        public void setConferenceOrderIndexes(int firstConferenceIndex)
        {
            //SET FIRST INDEX
            arrayIntIndexConferenceStandings[0] = firstConferenceIndex;

            //SET INDEXES BEFORE FIRST
            for (int conferenceIndex = 0; conferenceIndex < firstConferenceIndex; conferenceIndex++)
            {
                //SET INDEXES
                arrayIntIndexConferenceStandings[conferenceIndex + 1] = conferenceIndex;
            } //END FOR

            //SET INDEXES AFTER FIRST
            for (int conferenceIndex = firstConferenceIndex + 1; conferenceIndex < arrayIntIndexConferenceStandings.Length; conferenceIndex++)
            {
                //SET INDEXES
                arrayIntIndexConferenceStandings[conferenceIndex] = conferenceIndex;
            } //END FOR
        } //END

        private int getConferenceOrderIndex(int conferenceIndex)
        {
            //RETURNS INDEX OF CORRECT STANDINGS
            return arrayIntIndexConferenceStandings[conferenceIndex];
        } //END

        public string getConferenceStandingDisplayName(int conferenceIndex)
        {
            //RETURNS CONFERENCE NAME FOR CORRESPONDING STANDINGS
            return appResources.getConferenceName(getConferenceOrderIndex(conferenceIndex));
        } //END

        //---------------------------------------------------------------------
        //---------------------------------------------------------------------
        //DISPOSE DATA DIRECTOR------------------------------------------------
        //---------------------------------------------------------------------
        //---------------------------------------------------------------------

        public void DisposeDataDirector()
        {
            //TEAM SCHEDULE DATA TABLES
            for (int index = 0; index < arrayBoolTeamScheduleUpdated.Length; index++)
            {
                //DISPOSE
                teamScheduleArray[index].DisposeTeamScheduleTable();
            } //END FOR

            //DATE SCHEDULE DATA TABLES
            for (int index = 0; index < arrayBoolDateScheduleUpdated.Length; index++)
            {
                //DISPOSE
                dateScheduleArray[index].DisposeDateScheduleTable();
            } //END FOR

            //CONFERENCE STANDINGS DATA TABLES
            for (int index = 0; index < conferenceStandingsArray.Length; index++)
            {
                //DISPOSE
                conferenceStandingsArray[index].DisposeConferenceStandingsTable();
            } //END FOR

            Dispose();
        } //END

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    schedSlectConferencesDataTable.Dispose();
                    schedSlectTeamsDataTable.Dispose();
                    schedSlectDatesDataTable.Dispose();
                    saveAsDataTable.Dispose();
                    loadDataTable.Dispose();
                    top25DataTable.Dispose();
                    champTournListDataTable.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        ~DataDirector()
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

    }
}
