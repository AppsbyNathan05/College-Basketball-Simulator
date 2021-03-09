using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_Basketball_Simulator
{
    class ConferenceStandingsTable : IDisposable
    {
        //STATIC DATA RESOURCES
        private Resources appResources = new Resources();

        //CONFERENCE STANDINGS
        private DataTable conferenceStandingsTable = new DataTable();

        private bool disposedValue = false; // To detect redundant calls

        //CONFERENCE DISPLAY NAME
        public string conferenceDisplayName { get; set; }
        
        //CONFERENCE CHAMPION INDEX
        public int conferenceChampionIndex { get; set; }

        public ConferenceStandingsTable()
        {
            //ADD COLUMN HEADINGS
            initializeColumnHeadings();
        } //END

        public ConferenceStandingsTable(string conferenceDisplayName)
        {
            //SET CONFERENCE DISPLAY NAME
            this.conferenceDisplayName = conferenceDisplayName;

            //INITIALIZE CONFERENCE CHAMPION INDEX
            conferenceChampionIndex = appResources.getConferenceTeamIndexes(conferenceDisplayName)[0];

            //ADD COLUMN HEADINGS
            initializeColumnHeadings();
        } //END

        //---------------------------------------------------------------------
        //INITIALIZE CONFERENCE STANDINGS DATA TABLE---------------------------
        //---------------------------------------------------------------------

        private void initializeColumnHeadings()
        {
            //INITIALIZE CONFERENCE DATATABLE COLUMN HEADINGS
            conferenceStandingsTable.Columns.Add("Team", typeof(string));
            conferenceStandingsTable.Columns.Add("Wins", typeof(int));
            conferenceStandingsTable.Columns.Add("Losses", typeof(int));
            conferenceStandingsTable.Columns.Add("Win %", typeof(double));
            conferenceStandingsTable.Columns.Add("Conf W", typeof(int));
            conferenceStandingsTable.Columns.Add("Conf L", typeof(int));
            conferenceStandingsTable.Columns.Add("Conf %", typeof(double));
            conferenceStandingsTable.Columns.Add("Weighted %", typeof(double));
        } //END

        //---------------------------------------------------------------------
        //FILL CONFERENCE STANDINGS DATA TABLE---------------------------------
        //---------------------------------------------------------------------

        public void fillConferenceStandingsDataTable(Team[] teamsArray, double[] arrayDoubleRankings, int[] arrayIntOrder)
        {
            //GET CONFERENCE TEAM INDEXES
            int[] arrayIntConferenceTeamIndexes = appResources.getConferenceTeamIndexes(conferenceDisplayName);

            //ROW VARIABLE
            DataRow row;

            //SET CONFERENCE CHAMPION INDEX
            conferenceChampionIndex = arrayIntConferenceTeamIndexes[arrayIntOrder[0]];

            //CLEAR DATA TABLE
            conferenceStandingsTable.Rows.Clear();

            //FOR ALL TEAMS IN CONFERENCE
            //ADD TEAM TO DATA TABLE
            for (int index = 0; index < arrayIntConferenceTeamIndexes.Length; index++)
            {
                //MAKE ROW
                row = conferenceStandingsTable.NewRow();

                //POPULATE ROWS
                row[0] = teamsArray[arrayIntConferenceTeamIndexes[arrayIntOrder[index]]].teamNameDisplay;
                row[1] = teamsArray[arrayIntConferenceTeamIndexes[arrayIntOrder[index]]].getWins();
                row[2] = teamsArray[arrayIntConferenceTeamIndexes[arrayIntOrder[index]]].getLosses();
                row[3] = (double)teamsArray[arrayIntConferenceTeamIndexes[arrayIntOrder[index]]].getWins() / 
                    (double)(teamsArray[arrayIntConferenceTeamIndexes[arrayIntOrder[index]]].getLosses() + 
                    teamsArray[arrayIntConferenceTeamIndexes[arrayIntOrder[index]]].getWins());
                row[4] = teamsArray[arrayIntConferenceTeamIndexes[arrayIntOrder[index]]].getConferenceWins();
                row[5] = teamsArray[arrayIntConferenceTeamIndexes[arrayIntOrder[index]]].getConferenceLosses();
                row[6] = (double)teamsArray[arrayIntConferenceTeamIndexes[arrayIntOrder[index]]].getConferenceWins() /
                    (double)(teamsArray[arrayIntConferenceTeamIndexes[arrayIntOrder[index]]].getConferenceLosses() +
                    teamsArray[arrayIntConferenceTeamIndexes[arrayIntOrder[index]]].getConferenceWins());
                row[7] = arrayDoubleRankings[arrayIntConferenceTeamIndexes[arrayIntOrder[index]]];

                //ADD ROW TO DATA TABLE
                conferenceStandingsTable.Rows.Add(row);
            }//END FOR

        } //END

        //---------------------------------------------------------------------
        //GET CONFERENCE STANDINGS DATA TABLE----------------------------------
        //---------------------------------------------------------------------

        public DataTable getConferenceStandingsDataTable()
        {
            return conferenceStandingsTable;
        } //END

        //---------------------------------------------------------------------
        //IDISPOSABLE----------------------------------------------------------
        //---------------------------------------------------------------------

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    conferenceStandingsTable.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        ~ConferenceStandingsTable()
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

        public void DisposeConferenceStandingsTable()
        {
            Dispose();
        }

    } //END
} //END
