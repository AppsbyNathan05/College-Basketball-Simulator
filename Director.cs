using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_Basketball_Simulator
{
    class Director : IDisposable
    {
        //STATIC DATA RESOURCES
        private Resources appResources = new Resources();

        //DIRECTOR OF SAVES AND LOADS
        private SaveLoadDirector saveLoadDirector = new SaveLoadDirector();

        //DIRECTOR OF STATES
        private StateDirector stateDirector = new StateDirector();

        //DIRECTOR OF DATA
        private DataDirector dataDirector = new DataDirector();

        //ASSOCIATION
        private SimulationDirector simulationDirector = new SimulationDirector();

        //SETTINGS
        private SettingsDirector settingsDirector = new SettingsDirector();

        private bool disposedValue = false; // To detect redundant calls

        public Director()
        {
            //IF SAVE FOLDER
            //CHECK FOR SCHEDULE AND RATINGS
            //ELSE SET STATES
            if (saveLoadDirector.checkForSaveFolder())
            {
                //IF SCHEDULE AND RATINGS
                //LOAD SCHEDULE AND RATINGS
                //ELSE SET STATES
                if (saveLoadDirector.containsScheduleFile() && saveLoadDirector.containsRatingsFile())
                {
                    //INITIALIZE ASSOCIATION 
                    this.simulationDirector = new SimulationDirector(
                        saveLoadDirector.loadRatings(
                            saveLoadDirector.loadSchedules(simulationDirector)));

                    //UPDATE STATE
                    stateDirector.setScheduleAndRatingsLoadedState(true);

                    //INITIALIZE SETTINGS 
                    //(must import data before loading settings)
                    this.settingsDirector = new SettingsDirector(saveLoadDirector.GetSettings());

                    //INITIALIZE SIMULATION PROBABILITIES 
                    //(must load settings before initializing simulation probabilities)
                    simulationDirector.initializeSimulationProbabilities(settingsDirector);

                    //SET STATES
                    stateDirector.setStates(simulationDirector.getCurrentSimulationDate(),
                        saveLoadDirector.checkForSaveFolder(), saveLoadDirector.checkIfSimulationSaves());

                    //UPDATE ASSOCIATION DATA
                    dataDirector.updateDataDirector(settingsDirector);
                }
                else
                {
                    //INITIALIZE STATES
                    stateDirector.setStates(simulationDirector.getCurrentSimulationDate(),
                        saveLoadDirector.checkForSaveFolder(), saveLoadDirector.checkIfSimulationSaves());
                }//END IF 
            }
            else
            {
                //INITIALIZE STATES
                stateDirector.setStates(simulationDirector.getCurrentSimulationDate(),
                    saveLoadDirector.checkForSaveFolder(), saveLoadDirector.checkIfSimulationSaves());
            }//END IF 

        } //END

        //---------------------------------------------------------------------
        //---------------------------------------------------------------------
        //STATE DIRECTOR-------------------------------------------------------
        //---------------------------------------------------------------------
        //---------------------------------------------------------------------

        //---------------------------------------------------------------------
        //GET MENU STATES------------------------------------------------------
        //---------------------------------------------------------------------

        public Boolean getMenuAvailability(string menu)
        {
            //IF MENU IS AVAILABLE
            return stateDirector.getMenuAvailability(menu);
        }

        //---------------------------------------------------------------------
        //GET STATES-----------------------------------------------------------
        //---------------------------------------------------------------------

        //BUTTON AVAILABILITY--------------------------------------------------

        public Boolean getImportDataAvailability()
        {
            //IF SEASON HASN'T STARTED
            return stateDirector.getImportDataAvailability();
        } //END

        public Boolean getSimToAvailability()
        {
            //IF DAYS TO BE SIMULATED
            return stateDirector.getSimToAvailability(simulationDirector.getCurrentSimulationDate());
        } //END

        //---------------------------------------------------------------------
        //CURRENT MENU---------------------------------------------------------
        //---------------------------------------------------------------------

        //GET MENU-------------------------------------------------------------

        public string getCurrentMenuOpenString()
        {
            //GET CURRENT MENU OPEN
            return stateDirector.getCurrentMenuOpenString();
        } //END

        //SET MENU-------------------------------------------------------------

        public void setCurrentMenuOpenString(string menuOpen)
        {
            //SET CURRENT MENU OPEN
            stateDirector.setCurrentMenuOpenString(menuOpen);
        } //END

        //GET INDEX------------------------------------------------------------

        public int getCurrentMenuIndexInt()
        {
            //GET MENU INDEX
            return stateDirector.getCurrentMenuIndexInt();
        } //END

        //SET INDEX------------------------------------------------------------

        public void setCurrentMenuIndexInt(int menuIndex)
        {
            //SET MENU INDEX
            stateDirector.setCurrentMenuIndexInt(menuIndex);
        } //END

        //---------------------------------------------------------------------
        //---------------------------------------------------------------------
        //DATA TABLES----------------------------------------------------------
        //---------------------------------------------------------------------
        //---------------------------------------------------------------------

        //---------------------------------------------------------------------
        //DISPLAY DATA TABLES--------------------------------------------------
        //---------------------------------------------------------------------

        //CONFERENCE SELECTOR--------------------------------------------------

        public DataTable getSelectConferencesDataTable()
        {
            //RETURN SELECT CONFERENCE TOURNAMENT DATA TABLE 
            return dataDirector.getSelectConferencesDataTable();
        } //END

        public void fillSelectConferencesDataTable()
        {
            dataDirector.fillSelectConferencesDataTable();
        } //END

        //TEAM SELECTOR--------------------------------------------------------

        public DataTable getSelectTeamsDataTable()
        {
            //RETURN SCHEDULE SELECT TEAMS DATA TABLE
            return dataDirector.getSelectTeamsDataTable();
        } //END

        public void fillSelectTeamsDataTable(int conferenceIndex)
        {
            dataDirector.fillSelectTeamsDataTable(conferenceIndex);
        } //END

        //DAY SELECTOR---------------------------------------------------------

        public DataTable getSelectDatesDataTable()
        {
            //RETURN SCHEDULE SELECT DATES DATA TABLE
            return dataDirector.getSelectDatesDataTable();
        } //END

        public void fillSelectDatesDataTable()
        {
            dataDirector.fillSelectDatesDataTable();
        } //END

        //---------------------------------------------------------------------
        //SAVE AND LOAD DATA TABLES--------------------------------------------
        //---------------------------------------------------------------------

        //SAVE-----------------------------------------------------------------

        public DataTable getSaveAsDataTable()
        {
            //GET SAVE AS DATA TABLE
            return dataDirector.getSaveAsDataTable();
        } //END

        public void fillSaveAsDataTable()
        {
            //FILL SAVE AS DATA TABLE
            dataDirector.fillSaveAsDataTable(saveLoadDirector.getSaveLoadDataTableFileNames());
        } //END

        //LOAD-----------------------------------------------------------------

        public DataTable getLoadDataTable()
        {
            //GET LOAD DATA TABLE
            return dataDirector.getLoadDataTable();
        } //END

        public void fillLoadDataTable()
        {
            //FILL LOAD DATA TABLE
            dataDirector.fillLoadDataTable(saveLoadDirector.getSaveLoadDataTableFileNames());
        } //END

        //---------------------------------------------------------------------
        //SCHEDULE DATA TABLES-------------------------------------------------
        //---------------------------------------------------------------------

        //TEAM SCHEDULE DATA TABLE---------------------------------------------

        public DataTable getTeamSchedDataTable()
        {
            //RETURN TEAM SCHEDULE DATA TABLE
            return dataDirector.getTeamSchedDataTable();
        } //END

        public void fillTeamSchedDataTable(int teamIndex)
        {
            //FILL SCHEDULE
            dataDirector.fillTeamSchedDataTable(simulationDirector.getSchedule(teamIndex), teamIndex);
        } //END

        //DATE SCHEDULE DATA TABLE---------------------------------------------

        public DataTable getDateSchedDataTable()
        {
            //RETURN DATE SCHEDULE DATA TABLE
            return dataDirector.getDateSchedDataTable();
        } //END

        public void fillDateSchedDataTable(int dateIndex)
        {
            //FILL SCHEDULE
            dataDirector.fillDateSchedDataTable(dateIndex, simulationDirector.getTeams());
        } //END

        //---------------------------------------------------------------------
        //SANDINGS DATA TABLES-------------------------------------------------
        //---------------------------------------------------------------------

        public DataTable getConferenceStandingsDataTable(int index)
        {
            return dataDirector.getConferenceStandingsDataTable(index);
        } //END

        public void fillConferenceStandingsDataTables(int firstConferenceIndex) 
        {
            dataDirector.fillConferenceStandingsDataTables(firstConferenceIndex, simulationDirector.getTeams());
        } //END

        //STANDINGS DISPLAY NAMES----------------------------------------------

        public string getConferenceStandingDisplayName(int conferenceIndex)
        {
            //RETURNS CONFERENCE NAME FOR CORRESPONDING STANDINGS
            return dataDirector.getConferenceStandingDisplayName(conferenceIndex);
        } //END

        //---------------------------------------------------------------------
        //TOP 25 DATA TABLE----------------------------------------------------
        //---------------------------------------------------------------------

        public DataTable getTop25DataTable()
        {
            //GET TOP 25 DATATABLE
            return dataDirector.getTop25DataTable();
        } //END

        public void fillTop25DataTable()
        {
            //FILL TOP 25 DATATABLE
            dataDirector.fillTop25DataTable(simulationDirector.getTeams());

            //UPDATE TOURNAMENT CONTAINERS
            simulationDirector.setTournamentContainer(dataDirector.getTournamentContainer());
        } //END

        //---------------------------------------------------------------------
        //TOURNAMENT DATA TABLES-----------------------------------------------
        //---------------------------------------------------------------------

        //CHAMPIONSHIP TOURNAMENT PROJECTION LIST DATA TABLE-------------------

        public DataTable getChampTournProListDataTable()
        {
            //RETURN CHAMPIONSHIP TOURNAMENT PROJECTION LIST DATA TABLE
            return dataDirector.getChampTournProListDataTable();
        } //END

        public void fillChampTournProListDataTable()
        {
            //FILL TOURNAMENT PROJECTIONS LIST
            dataDirector.fillChampTournProListDataTable(simulationDirector);

            //UPDATE TOURNAMENT CONTAINERS
            simulationDirector.setTournamentContainer(dataDirector.getTournamentContainer());
        } //END

        //CHAMPIONSHIP TOURNAMENT LIST SAVE DATA TABLE-------------------------

        public DataTable getChampTournListDataTable()
        {
            //RETURN CHAMPIONSHIP TOURNAMENT LIST DATA TABLE
            return dataDirector.getChampTournListDataTable();
        } //END

        public void fillChampTournListDataTable()
        {
            //FILL TOURNAMENT LIST 
            dataDirector.fillChampTournListDataTable(simulationDirector);

            //UPDATE TOURNAMENT CONTAINERS
            simulationDirector.setTournamentContainer(dataDirector.getTournamentContainer());
        } //END

        //---------------------------------------------------------------------
        //---------------------------------------------------------------------
        //BRACKETS-------------------------------------------------------------
        //---------------------------------------------------------------------
        //---------------------------------------------------------------------

        //---------------------------------------------------------------------
        //PROJECTED CHAMPIONSHIP TOURNAMENT------------------------------------
        //---------------------------------------------------------------------

        public string[] getProjectedTournamentBracket(int bracketType)
        {
            string[] bracketString;

            if (bracketType == 0)
            {
                bracketString = simulationDirector.getFullProjectedChampTournBracket();

                //UPDATE TOURNAMENT CONTAINERS
                dataDirector.setTournamentContainer(simulationDirector.getTournamentContainer());

                return bracketString;
            }
            else if (bracketType == 1)
            {
                bracketString = simulationDirector.getSweet16ProjectedChampTournBracket();

                //UPDATE TOURNAMENT CONTAINERS
                dataDirector.setTournamentContainer(simulationDirector.getTournamentContainer());

                return simulationDirector.getSweet16ProjectedChampTournBracket();
            }
            else if (bracketType == 2)
            {
                bracketString = simulationDirector.getWestProjectedChampTournBracket();

                //UPDATE TOURNAMENT CONTAINERS
                dataDirector.setTournamentContainer(simulationDirector.getTournamentContainer());

                return bracketString;
            }
            else if (bracketType == 3)
            {
                bracketString = simulationDirector.getMidwestProjectedChampTournBracket();

                //UPDATE TOURNAMENT CONTAINERS
                dataDirector.setTournamentContainer(simulationDirector.getTournamentContainer());

                return bracketString;
            }
            else if (bracketType == 4)
            {
                bracketString = simulationDirector.getSouthProjectedChampTournBracket();

                //UPDATE TOURNAMENT CONTAINERS
                dataDirector.setTournamentContainer(simulationDirector.getTournamentContainer());

                return bracketString;
            }
            else if (bracketType == 5)
            {
                bracketString = simulationDirector.getEastProjectedChampTournBracket();

                //UPDATE TOURNAMENT CONTAINERS
                dataDirector.setTournamentContainer(simulationDirector.getTournamentContainer());

                return bracketString;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("ERROR: INVALID BRACKET TYPE");
                return simulationDirector.getFullProjectedChampTournBracket();
            }//END IF
        } //END

        //---------------------------------------------------------------------
        //CONFERENCE TOURNAMENT------------------------------------------------
        //---------------------------------------------------------------------

        public string[] getConferenceTournamentBracket(int confIndex)
        {
            return simulationDirector.getConfTournBracket(confIndex);
        } //END

        //---------------------------------------------------------------------
        //CHAMPIONSHIP TOURNAMENT----------------------------------------------
        //---------------------------------------------------------------------

        public string[] getTournamentBracket(int bracketType)
        {
            string[] bracketString;

            if (bracketType == 0)
            {
                bracketString = simulationDirector.getFullChampTournBracket();

                //UPDATE TOURNAMENT CONTAINERS
                dataDirector.setTournamentContainer(simulationDirector.getTournamentContainer());

                return bracketString;
            }
            else if (bracketType == 1)
            {
                bracketString = simulationDirector.getSweet16ChampTournBracket();

                //UPDATE TOURNAMENT CONTAINERS
                dataDirector.setTournamentContainer(simulationDirector.getTournamentContainer());

                return bracketString;
            }
            else if (bracketType == 2)
            {
                bracketString = simulationDirector.getWestChampTournBracket();

                //UPDATE TOURNAMENT CONTAINERS
                dataDirector.setTournamentContainer(simulationDirector.getTournamentContainer());

                return bracketString;
            }
            else if (bracketType == 3)
            {
                bracketString = simulationDirector.getMidwestChampTournBracket();

                //UPDATE TOURNAMENT CONTAINERS
                dataDirector.setTournamentContainer(simulationDirector.getTournamentContainer());

                return bracketString;
            }
            else if (bracketType == 4)
            {
                bracketString = simulationDirector.getSouthChampTournBracket();

                //UPDATE TOURNAMENT CONTAINERS
                dataDirector.setTournamentContainer(simulationDirector.getTournamentContainer());

                return bracketString;
            }
            else if (bracketType == 5)
            {
                bracketString = simulationDirector.getEastChampTournBracket();

                //UPDATE TOURNAMENT CONTAINERS
                dataDirector.setTournamentContainer(simulationDirector.getTournamentContainer());

                return bracketString;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("ERROR: INVALID BRACKET TYPE");
                return simulationDirector.getFullChampTournBracket();
            }//END IF
        } //END

        //---------------------------------------------------------------------
        //---------------------------------------------------------------------
        //SIMULATION DIRECTOR--------------------------------------------------
        //---------------------------------------------------------------------
        //---------------------------------------------------------------------

        //---------------------------------------------------------------------
        //CURRENT SIMULATION DATE----------------------------------------------
        //---------------------------------------------------------------------

        public DateTime getCurrentSimulationDate()
        {
            return simulationDirector.getCurrentSimulationDate();
        } //END

        //---------------------------------------------------------------------
        //WINS AND LOSSES------------------------------------------------------
        //---------------------------------------------------------------------

        //WINS-----------------------------------------------------------------

        public int getWins(int teamIndex)
        {
            return simulationDirector.getWins(teamIndex);
        } //END

        //LOSSES---------------------------------------------------------------

        public int getLosses(int teamIndex)
        {
            return simulationDirector.getLosses(teamIndex);
        } //END

        //CONFERENCE WINS------------------------------------------------------

        public int getConferenceWins(int teamIndex)
        {
            return simulationDirector.getConferenceWins(teamIndex);
        } //END

        //CONFERENCE LOSSES----------------------------------------------------

        public int getConferenceLosses(int teamIndex)
        {
            return simulationDirector.getConferenceLosses(teamIndex);
        } //END

        //---------------------------------------------------------------------
        //SIM TO---------------------------------------------------------------
        //---------------------------------------------------------------------

        public Boolean goSimTo(DateTime goToDate)
        {
            //SIMULATE TO
            Boolean result = simulationDirector.simTo(goToDate);

            //SET STATES
            stateDirector.setStates(simulationDirector.getCurrentSimulationDate(),
                saveLoadDirector.checkForSaveFolder(), saveLoadDirector.checkIfSimulationSaves());

            //UPDATE ASSOCIATION DATA
            dataDirector.updateDataDirector();

            return result;
        } //END

        //---------------------------------------------------------------------
        //START FROM-----------------------------------------------------------
        //---------------------------------------------------------------------

        public Boolean goStartFrom(DateTime startFromDate)
        {
            //START FROM EARLIER DATE
            Boolean result = simulationDirector.startFrom(startFromDate);

            //SET STATES
            stateDirector.setStates(simulationDirector.getCurrentSimulationDate(),
                saveLoadDirector.checkForSaveFolder(), saveLoadDirector.checkIfSimulationSaves());

            //UPDATE ASSOCIATION DATA
            dataDirector.updateDataDirector();

            return result;
        } //END

        //---------------------------------------------------------------------
        //---------------------------------------------------------------------
        //SAVE AND LOAD DIRECTOR-----------------------------------------------
        //---------------------------------------------------------------------
        //---------------------------------------------------------------------

        //---------------------------------------------------------------------
        //IMPORT SCHEDULE AND RATINGS------------------------------------------
        //---------------------------------------------------------------------

        public void importOnlineData()
        {
            //DELETE!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            Console.WriteLine("IMPORT ONLINE DATA");
            //DELETE!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

            //INITIALIZE ASSOCIATION 
            this.simulationDirector = new SimulationDirector(saveLoadDirector.importData());

            //UPDATE STATE
            stateDirector.setScheduleAndRatingsLoadedState(true);

            //INITIALIZE SETTINGS 
            //(must import data before loading settings)
            this.settingsDirector = new SettingsDirector(saveLoadDirector.GetSettings());

            //INITIALIZE SIMULATION PROBABILITIES 
            //(must load settings before initializing simulation probabilities)
            simulationDirector.initializeSimulationProbabilities(settingsDirector);

            //SET STATES
            stateDirector.setStates(simulationDirector.getCurrentSimulationDate(),
                saveLoadDirector.checkForSaveFolder(), saveLoadDirector.checkIfSimulationSaves());

            //UPDATE ASSOCIATION DATA
            dataDirector.updateDataDirector(settingsDirector);

            //DELETE!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            Console.WriteLine("END IMPORT ONLINE DATA");
            //DELETE!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        } //END

        //---------------------------------------------------------------------
        //SIMULATION SAVES-----------------------------------------------------
        //---------------------------------------------------------------------

        //CHECK IF-------------------------------------------------------------

        public Boolean checkIfCurrentSimulationSaved()
        {
            //IF OPEN SIMULATION
            return stateDirector.getCurrentSimulationSavedState();
        }

        //SAVE-----------------------------------------------------------------

        public Boolean saveNewSimulationResultsFile(string fileName)
        {
            //SAVE SIMULATION
            Boolean result = saveLoadDirector.saveNewSimulation(simulationDirector, settingsDirector, fileName);

            //SET STATES
            stateDirector.setStates(simulationDirector.getCurrentSimulationDate(),
                saveLoadDirector.checkForSaveFolder(), saveLoadDirector.checkIfSimulationSaves());

            return result;
        } //END

        public Boolean saveSimulation()
        {
            //SAVE SIMULATION
            Boolean result = saveLoadDirector.saveSimulation(simulationDirector, settingsDirector);

            //SET STATES
            stateDirector.setStates(simulationDirector.getCurrentSimulationDate(),
                saveLoadDirector.checkForSaveFolder(), saveLoadDirector.checkIfSimulationSaves());

            return result;  
        }

        public Boolean saveReplaceSimulation(string originalDisplayFileName, string replaceDisplayFileName)
        {
            //REPLACE SIMULATION
            Boolean result = saveLoadDirector.saveReplaceSimulation(simulationDirector, settingsDirector,
                originalDisplayFileName, replaceDisplayFileName);

            //SET STATES
            stateDirector.setStates(simulationDirector.getCurrentSimulationDate(),
                saveLoadDirector.checkForSaveFolder(), saveLoadDirector.checkIfSimulationSaves());

            return result;  
        }

        //LOAD-----------------------------------------------------------------

        public void loadSimulation(string displayFileName)
        {
            //DELETE!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            Console.WriteLine("LOAD SIMULATION");
            //DELETE!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

            //INITIALIZE ASSOCIATION 
            this.simulationDirector = new SimulationDirector(saveLoadDirector.loadSimulation(displayFileName));

            //UPDATE STATE
            stateDirector.setScheduleAndRatingsLoadedState(true);

            //INITIALIZE SETTINGS 
            //(must import data before loading settings)
            this.settingsDirector = new SettingsDirector(saveLoadDirector.GetSettings());

            //INITIALIZE SIMULATION PROBABILITIES 
            //(must load settings before initializing simulation probabilities)
            simulationDirector.initializeSimulationProbabilities(settingsDirector);

            //SET STATES
            stateDirector.setStates(simulationDirector.getCurrentSimulationDate(),
                saveLoadDirector.checkForSaveFolder(), saveLoadDirector.checkIfSimulationSaves());

            //UPDATE ASSOCIATION DATA
            dataDirector.updateDataDirector(settingsDirector);

            //DELETE!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            Console.WriteLine("END LOAD SIMULATION");
            //DELETE!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        }

        //DELETE---------------------------------------------------------------

        public Boolean deleteSimulationResultsFile(string fileName)
        {
            //DELETE SIMULATION
            Boolean result = saveLoadDirector.deleteSimulation(fileName);

            //SET STATES
            stateDirector.setStates(simulationDirector.getCurrentSimulationDate(),
                saveLoadDirector.checkForSaveFolder(), saveLoadDirector.checkIfSimulationSaves());

            return result;
        } //END

        //---------------------------------------------------------------------
        //SETTINGS-------------------------------------------------------------
        //---------------------------------------------------------------------

        //SAVE-----------------------------------------------------------------

        public Boolean saveSettings(SettingsDirector settingsDirector, string saveFolderFilePath)
        {
            //DELETE!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            Console.WriteLine("SAVE SETTINGS");
            //DELETE!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

            //TRANSFER NON USER ENTERED RATINGS OVER
            settingsDirector.setEarliestGameDate(this.settingsDirector.getEarliestGameDate());
            settingsDirector.setHighLowOffensiveRatings(this.settingsDirector.getHighestOffensiveRating());
            settingsDirector.setHighLowOffensiveRatings(this.settingsDirector.getLowestOffensiveRating());
            settingsDirector.setHighLowDefensiveRatings(this.settingsDirector.getHighestDefensiveRating());
            settingsDirector.setHighLowDefensiveRatings(this.settingsDirector.getLowestDefensiveRating());

            //IF SETTINGS SAVED
            //LOAD SETTINGS
            if (saveLoadDirector.saveSettings(settingsDirector, saveFolderFilePath))
            {
                //INITIALIZE SETTINGS 
                this.settingsDirector = new SettingsDirector(saveLoadDirector.GetSettings());

                //IF SIMULATION LOADED
                //INITIALIZE SIMULATION PROBABILITIES
                if (stateDirector.getScheduleAndRatingsLoadedState())
                {
                    //INITIALIZE SIMULATION PROBABILITIES 
                    simulationDirector.initializeSimulationProbabilities(this.settingsDirector); 
                }//END IF

                return true;
            }
            else
            {
                //ERROR MESSAGE HANDLED AT FORM LEVEL
                return false;
            }//END IF

            //DELETE!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            Console.WriteLine("END SAVE SETTINGS");
            //DELETE!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

        } //END

        //---------------------------------------------------------------------
        //SAVE FOLDER----------------------------------------------------------
        //---------------------------------------------------------------------

        //SET------------------------------------------------------------------

        public Boolean setSaveFolder(string newSaveFolderFilePath)
        {
            //DELETE SIMULATION
            Boolean result = saveLoadDirector.setSaveFolder(newSaveFolderFilePath);

            //SET STATES
            stateDirector.setStates(simulationDirector.getCurrentSimulationDate(),
                saveLoadDirector.checkForSaveFolder(), saveLoadDirector.checkIfSimulationSaves());

            return result;
        } //END

        //---------------------------------------------------------------------
        //---------------------------------------------------------------------
        //DISPOSE DIRECTOR-----------------------------------------------------
        //---------------------------------------------------------------------
        //---------------------------------------------------------------------

        public void DisposeDirector()
        {
            Dispose();
        }

        //DisposeDataDirector() CALLS Dispose()
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2213:DisposableFieldsShouldBeDisposed", MessageId = "dataDirector")]
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    dataDirector.DisposeDataDirector();
                    //dataDirector.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        ~Director()
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
