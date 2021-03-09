using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_Basketball_Simulator
{
    class DateScheduleTable : IDisposable
    {
        //STATIC DATA RESOURCES
        private Resources appResources = new Resources();

        //DATE SCHEDULE
        private DataTable dateScheduleTable = new DataTable();

        private bool disposedValue = false; // To detect redundant calls

        //DATE
        private DateTime date = new DateTime();

        public DateScheduleTable()
        {
            //ADD COLUMN HEADINGS
            initializeColumnHeadings();
        } //END

        public DateScheduleTable(DateTime date)
        {
            //SET DATE
            this.date = new DateTime(date.Year, date.Month, date.Day, 0, 0, 0, 0);

            //ADD COLUMN HEADINGS
            initializeColumnHeadings();
        } //END

        //---------------------------------------------------------------------
        //INITIALIZE DATE SCHEDULE DATA TABLE----------------------------------
        //---------------------------------------------------------------------

        private void initializeColumnHeadings()
        {
            //INITIALIZE DATE SCHEDULE DATATABLE COLUMN HEADINGS
            dateScheduleTable.Columns.Add("Conference ", typeof(string));
            dateScheduleTable.Columns.Add("Team ", typeof(string));
            dateScheduleTable.Columns.Add("Points ", typeof(int));
            dateScheduleTable.Columns.Add(" Points", typeof(int));
            dateScheduleTable.Columns.Add(" Team", typeof(string));
            dateScheduleTable.Columns.Add(" Conference", typeof(string));
            dateScheduleTable.PrimaryKey = new DataColumn[] { dateScheduleTable.Columns[1], dateScheduleTable.Columns[4] };
        } //END

        //---------------------------------------------------------------------
        //RESET DATE SCHEDULE--------------------------------------------------
        //---------------------------------------------------------------------

        public void reSetDateSchedule(DateTime date)
        {
            //CLEAR DATA
            dateScheduleTable.Rows.Clear();

            //RESET DATE
            this.date = new DateTime(date.Year, date.Month, date.Day, 0, 0, 0, 0);
        } //END

        //---------------------------------------------------------------------
        //FILL DATE SCHEDULE DATA TABLES---------------------------------------
        //---------------------------------------------------------------------

        public void fillDateSchedDataTable(Team[] teamsArray)
        {
            //ROW VARIABLE
            DataRow row;

            //CLEAR DATA
            dateScheduleTable.Rows.Clear();

            //FOR ALL TEAMS
            for (int teamIndex = 0; teamIndex < appResources.getLengthOfTeamNames(); teamIndex++)
            {
                //IF DOES NOT CONTAIN TEAM
                //CHECK SCHEDULE
                if (!dateScheduleTable.Rows.Contains(appResources.getTeamName(teamIndex)))
                {
                    //FOR ALL TEAMS IN SCHEDULE
                    //CHECK IF SAME DAY
                    for (int rowIndex = 0; rowIndex < teamsArray[teamIndex].getLengthOfSchedule(appResources.getScheduleTypeText(4)); rowIndex++)
                    {
                        //IF SAME DAY
                        //ADD GAME TO DATA TABLE
                        if (DateTime.Compare(teamsArray[teamIndex].getDate(rowIndex, appResources.getScheduleTypeText(4)), date) == 0)
                        {
                            //MAKE ROW
                            row = dateScheduleTable.NewRow();

                            //POPULATE ROWS
                            row[0] = appResources.getTeamsConferenceName(teamIndex);
                            row[1] = appResources.getTeamName(teamIndex);
                            row[2] = teamsArray[teamIndex].getPoints(rowIndex, appResources.getScheduleTypeText(4));
                            row[3] = teamsArray[teamIndex].getOpponentPoints(rowIndex, appResources.getScheduleTypeText(4));
                            row[4] = teamsArray[teamIndex].getOpponentName(rowIndex, appResources.getScheduleTypeText(4));
                            row[5] = appResources.getTeamsConferenceName(teamsArray[teamIndex].getOpponentIndex(rowIndex, appResources.getScheduleTypeText(4)));

                            //ADD ROW TO DATA TABLE
                            dateScheduleTable.Rows.Add(row);
                            
                            //EXIT LOOP
                            break;
                        }//END IF

                    }//END FOR 

                }//END IF

            }//END FOR

        } //END

        //---------------------------------------------------------------------
        //GET DATE SCHEDULE DATA TABLES----------------------------------------
        //---------------------------------------------------------------------

        public DataTable getDateScheduleDataTable()
        {
            return dateScheduleTable;
        } //END

        //---------------------------------------------------------------------
        //GET DATE-------------------------------------------------------------
        //---------------------------------------------------------------------

        public DateTime getDate()
        {
            return date;
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
                    dateScheduleTable.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        ~DateScheduleTable()
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

        public void DisposeDateScheduleTable()
        {
            Dispose();
        }

    } //END
} //END
