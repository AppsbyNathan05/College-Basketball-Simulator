using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_Basketball_Simulator
{
    class TeamScheduleTable : IDisposable
    {
        //STATIC DATA RESOURCES
        private Resources appResources = new Resources();

        //TEAM SCHEDULE
        private DataTable teamScheduleTable = new DataTable();

        private bool disposedValue = false; // To detect redundant calls

        public TeamScheduleTable()
        {
            //ADD COLUMN HEADINGS
            teamScheduleTable.Columns.Add("Opponent", typeof(string));
            teamScheduleTable.Columns.Add("Conference", typeof(string));
            teamScheduleTable.Columns.Add("Date", typeof(DateTime));
            teamScheduleTable.Columns.Add("Result", typeof(string));
            teamScheduleTable.Columns.Add("Points", typeof(int));
            teamScheduleTable.Columns.Add("Opponent Points", typeof(int));

        } //END

        //---------------------------------------------------------------------
        //FILL TEAM SCHEDULE DATA TABLES---------------------------------------
        //---------------------------------------------------------------------

        public void fillTeamSchedDataTable(Schedule schedule)
        {
            //ROW VARIABLE
            DataRow row;

            //CLEAR DATA TABLE
            teamScheduleTable.Rows.Clear();

            //FOR ALL TEAMS IN SCHEDULE
            //ADD GAME TO DATA TABLE
            for (int rowIndex = 0; rowIndex < schedule.getLengthOfSchedule(appResources.getScheduleTypeText(4)) ; rowIndex++)
            {
                //MAKE ROW
                row = teamScheduleTable.NewRow();

                //POPULATE ROWS
                row[0] = schedule.getOpponentName(rowIndex, appResources.getScheduleTypeText(4));
                row[1] = appResources.getTeamsConferenceName(schedule.getOpponentIndex(rowIndex, appResources.getScheduleTypeText(4)));
                row[2] = schedule.getDate(rowIndex, appResources.getScheduleTypeText(4));

                //IF GAME WIN
                //ELSE IF GAME LOSS
                //ELSE NO GAME PLAYED
                if (string.Compare(schedule.getGameResult(rowIndex, appResources.getScheduleTypeText(4)), appResources.getGameResultTypeText(1)) == 0)
                {
                    row[3] = "W";
                }
                else if (string.Compare(schedule.getGameResult(rowIndex, appResources.getScheduleTypeText(4)), appResources.getGameResultTypeText(2)) == 0)
                {
                    row[3] = "L";
                }
                else
                {
                    row[3] = " ";
                }//END IF
                row[4] = schedule.getPoints(rowIndex, appResources.getScheduleTypeText(4));
                row[5] = schedule.getOpponentPoints(rowIndex, appResources.getScheduleTypeText(4));

                //ADD ROW TO DATA TABLE
                teamScheduleTable.Rows.Add(row);
            }//END FOR

        } //END

        //---------------------------------------------------------------------
        //GET TEAM SCHEDULE DATA TABLES----------------------------------------
        //---------------------------------------------------------------------

        public DataTable getTeamScheduleDataTable()
        {
            return teamScheduleTable;
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
                    teamScheduleTable.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        ~TeamScheduleTable()
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

        public void DisposeTeamScheduleTable()
        {
            Dispose();
        }

    } //END
} //END
