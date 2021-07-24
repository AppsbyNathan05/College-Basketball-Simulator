using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_Basketball_Simulator
{
    class StateDirector
    {
        //STATIC DATA RESOURCES
        private static Resources appResources = new Resources();

        //CURRENT MENU
        private string currentMenuOpen = appResources.getMenuText(0);
        private int currentMenuIndex = -1;

        //SAVE STATES
        private Boolean boolCurrentSimulationSaved = false;
        private Boolean boolHasSaves = false;
        private Boolean boolHasSaveFolder = false;

        //DATA STATE
        private Boolean boolScheduleAndRatingsLoaded = false;
        
        //INITIAL STATE
        private Boolean boolNoDataState = false;

        //SEASON STATE
        private Boolean boolPreseasonState = false;
        private Boolean boolSeasonState = false;
        private Boolean boolConferenceTournamentState = false;
        private Boolean boolChampionshipTournamentState = false;
        private Boolean boolPostSeasonState = false;

        //private States currentState = new States();

        public StateDirector()
        {
            //INITIALIZE STATES
            setStates(appResources.getProgramInitalStartDate(), false, false);
        } //END

        //---------------------------------------------------------------------
        //---------------------------------------------------------------------
        //STATES---------------------------------------------------------------
        //---------------------------------------------------------------------
        //---------------------------------------------------------------------

        //---------------------------------------------------------------------
        //UPDATE STATES--------------------------------------------------------
        //---------------------------------------------------------------------

        public void setStates(DateTime currentSimulationDate, Boolean saveFolder, Boolean simulationSaves)
        {
            //IF NO SCHEDULE AND RATINGS
            //SET NO DATA STATE
            if (boolScheduleAndRatingsLoaded)
            {
                //SET SEASON STATE
                if (0 > DateTime.Compare(currentSimulationDate, appResources.getSeasonStartDate()))
                {
                    //SET PRESEASON STATE
                    setStateOfSeason(appResources.getStateText(1));
                }
                else if (0 <= DateTime.Compare(currentSimulationDate, appResources.getSeasonStartDate()) &&
                    0 > DateTime.Compare(currentSimulationDate, appResources.getConferenceTournamentStartDate()))
                {
                    //SET SEASON STATE
                    setStateOfSeason(appResources.getStateText(2));
                }
                else if (0 <= DateTime.Compare(currentSimulationDate, appResources.getConferenceTournamentStartDate()) &&
                    0 > DateTime.Compare(currentSimulationDate, appResources.getChampionshipTournamentStartDate()))
                {
                    //SET CONFERENCE TOURNAMENT STATE
                    setStateOfSeason(appResources.getStateText(3));
                }
                else if (0 <= DateTime.Compare(currentSimulationDate, appResources.getChampionshipTournamentStartDate()) &&
                    0 > DateTime.Compare(currentSimulationDate, appResources.getPostSeasonStartDate()))
                {
                    //SET CHAMPIONSHIP TOURNAMENT STATE
                    setStateOfSeason(appResources.getStateText(4));
                }
                else if (0 <= DateTime.Compare(currentSimulationDate, appResources.getPostSeasonStartDate()))
                {
                    //SET POSTSEASON STATE
                    setStateOfSeason(appResources.getStateText(5));
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("ERROR: NO SEASON STATE SET");
                } //END IF

            }
            else
            {
                //SET NO DATA STATE
                setStateOfSeason(appResources.getStateText(0));
            } //END IF

            //SET SAVE STATES
            boolHasSaveFolder = saveFolder;
            boolHasSaves = simulationSaves;

        } //END

        //---------------------------------------------------------------------
        //SEASON STATE---------------------------------------------------------
        //---------------------------------------------------------------------

        private void setStateOfSeason(string state)
        {
            //RESET ALL SEASON STATES
            boolNoDataState = false;
            boolPreseasonState = false;
            boolSeasonState = false;
            boolConferenceTournamentState = false;
            boolChampionshipTournamentState = false;
            boolPostSeasonState = false;

            //SET SEASON STATE
            if (string.Compare(state, appResources.getStateText(0)) == 0)
            {
                // 0 NoDataState 
                boolNoDataState = true;
                Console.WriteLine(" ");
                Console.WriteLine("NO DATA STATE SET");
                Console.WriteLine(" ");
            }
            else if (string.Compare(state, appResources.getStateText(1)) == 0)
            {
                // 1 PreseasonState
                boolPreseasonState = true;
                Console.WriteLine(" ");
                Console.WriteLine("PRESEASON STATE SET");
                Console.WriteLine(" ");
            }
            else if (string.Compare(state, appResources.getStateText(2)) == 0)
            {
                // 2 SeasonState 
                boolSeasonState = true;
                Console.WriteLine(" ");
                Console.WriteLine("SEASON STATE SET");
                Console.WriteLine(" ");
            }
            else if (string.Compare(state, appResources.getStateText(3)) == 0)
            {
                // 3 ConferenceTournamentState 
                boolConferenceTournamentState = true;
                Console.WriteLine(" ");
                Console.WriteLine("CONFERENCE TOURNAMENT STATE SET");
                Console.WriteLine(" ");
            }
            else if (string.Compare(state, appResources.getStateText(4)) == 0)
            {
                // 4 ChampionshipTournamentState 
                boolChampionshipTournamentState = true;
                Console.WriteLine(" ");
                Console.WriteLine("CHAMPIONSHIP TOURNAMENT STATE SET");
                Console.WriteLine(" ");
            }
            else if (string.Compare(state, appResources.getStateText(5)) == 0)
            {
                // 5 PostSeasonState
                boolPostSeasonState = true;
                Console.WriteLine(" ");
                Console.WriteLine("POSTSEASON STATE SET");
                Console.WriteLine(" ");
            }
            else
            {
                //ERROR NO STATE SET
                System.Windows.Forms.MessageBox.Show("ERROR: NO STATE SET");
            } //END IF

        } //END

        //---------------------------------------------------------------------
        //DATA STATE-----------------------------------------------------------
        //---------------------------------------------------------------------

        public void setScheduleAndRatingsLoadedState(Boolean boolScheduleAndRatingsLoaded)
        {
            //SCHEDULE AND RATINGS LOADED
            this.boolScheduleAndRatingsLoaded = boolScheduleAndRatingsLoaded;
        } //END

        public Boolean getScheduleAndRatingsLoadedState()
        {
            //SCHEDULE AND RATINGS LOADED
            return boolScheduleAndRatingsLoaded;
        } //END

        //---------------------------------------------------------------------
        //SAVE STATES----------------------------------------------------------
        //---------------------------------------------------------------------

        //SIMULATION SAVED STATE-----------------------------------------------

        public void setCurrentSimulationSavedState(Boolean boolCurrentSimulationSaved)
        {
            //CAN CALL SAVE DROP DOWN
            this.boolCurrentSimulationSaved = boolCurrentSimulationSaved;
        }

        public Boolean getCurrentSimulationSavedState()
        {
            //CAN CALL SAVE DROP DOWN
            return boolCurrentSimulationSaved;
        }

        //HAS SAVES AND SAVE FOLDER STATES-------------------------------------

        public Boolean getHasSavesState()
        {
            //IF THERE ARE SAVES
            return boolHasSaves;
        } //END

        public void setHasSaveFolderState(Boolean boolHasSaveFolder)
        {
            //IF THERE IS A SAVE FOLDER
            this.boolHasSaveFolder = boolHasSaveFolder;
        } //END

        public Boolean getHasSaveFolderState()
        {
            //IF THERE IS A SAVE FOLDER
            return boolHasSaveFolder;
        } //END

        //---------------------------------------------------------------------
        //---------------------------------------------------------------------
        //BUTTON AVAILABILITY--------------------------------------------------
        //---------------------------------------------------------------------
        //---------------------------------------------------------------------

        public Boolean getImportDataAvailability()
        {
            //IF SEASON HASN'T STARTED
            return !boolSeasonState && !boolConferenceTournamentState &&
                !boolChampionshipTournamentState && !boolPostSeasonState;
        } //END

        public Boolean getSimToAvailability(DateTime currentSimulationDate)
        {
            //IF DAYS TO BE SIMULATED
            if (0 > DateTime.Compare(currentSimulationDate, appResources.getPostSeasonStartDate()))
            {
                return true;
            }
            else
            {
                return false;
            } //END IF
        } //END

        //---------------------------------------------------------------------
        //---------------------------------------------------------------------
        //GET MENU AVAILABILITY------------------------------------------------
        //---------------------------------------------------------------------
        //---------------------------------------------------------------------

        public Boolean getMenuAvailability(string menu)
        {
            if (string.Compare(appResources.getMenuText(0), menu) == 0)
            {
                // 0 MainMenuIntro 
                return boolNoDataState;
            }
            else if (string.Compare(appResources.getMenuText(1), menu) == 0)
            {
                // 1 MainMenu 
                return boolPreseasonState || boolSeasonState || boolConferenceTournamentState ||
                boolChampionshipTournamentState || boolPostSeasonState;
            }
            else if (string.Compare(appResources.getMenuText(2), menu) == 0)
            {
                // 2 Settings
                return boolNoDataState || boolPreseasonState || boolSeasonState || boolConferenceTournamentState ||
                boolChampionshipTournamentState || boolPostSeasonState;
            }
            else if (string.Compare(appResources.getMenuText(3), menu) == 0)
            {
                //ONLY RETURN YES IF NEEDED ON START UP
                // 3 SaveFold 
                return !boolHasSaveFolder;
            }
            else if (string.Compare(appResources.getMenuText(4), menu) == 0)
            {
                // 4 SaveAs
                return boolPreseasonState || boolSeasonState || boolConferenceTournamentState ||
                boolChampionshipTournamentState || boolPostSeasonState;
            }
            else if (string.Compare(appResources.getMenuText(5), menu) == 0)
            {
                // 5 Load 
                return boolHasSaves && boolPreseasonState || boolSeasonState || boolConferenceTournamentState ||
                boolChampionshipTournamentState || boolPostSeasonState;
            }
            else if (string.Compare(appResources.getMenuText(6), menu) == 0)
            {
                // 6 SimTo 
                return boolPreseasonState || boolSeasonState || boolConferenceTournamentState ||
                boolChampionshipTournamentState;
            }
            else if (string.Compare(appResources.getMenuText(7), menu) == 0)
            {
                // 7 StartFrom
                return boolSeasonState || boolConferenceTournamentState ||
                boolChampionshipTournamentState || boolPostSeasonState;
            }
            else if (string.Compare(appResources.getMenuText(8), menu) == 0 ||
                string.Compare(appResources.getMenuText(9), menu) == 0 ||
                string.Compare(appResources.getMenuText(10), menu) == 0)
            {
                // 8 SchedFind 
                // 9 TeamSched 
                // 10 DateSched 
                return boolPreseasonState || boolSeasonState || boolConferenceTournamentState ||
                boolChampionshipTournamentState || boolPostSeasonState;
            }
            else if (string.Compare(appResources.getMenuText(11), menu) == 0)
            {
                // 11 Stand
                return boolPreseasonState || boolSeasonState || boolConferenceTournamentState ||
                boolChampionshipTournamentState || boolPostSeasonState;
            }
            else if (string.Compare(appResources.getMenuText(12), menu) == 0)
            {
                // 12 Top25 
                return boolSeasonState || boolConferenceTournamentState ||
                boolChampionshipTournamentState || boolPostSeasonState;
            }
            else if (string.Compare(appResources.getMenuText(13), menu) == 0 ||
                string.Compare(appResources.getMenuText(14), menu) == 0)
            {
                // 13 TournProList 
                // 14 TournProBrac 
                return boolPreseasonState || boolSeasonState || boolConferenceTournamentState;
            }
            else if (string.Compare(appResources.getMenuText(15), menu) == 0 ||
                string.Compare(appResources.getMenuText(16), menu) == 0)
            {
                // 15 ConTournBrac
                // 16 ConTournFind 
                return boolConferenceTournamentState || boolChampionshipTournamentState || boolPostSeasonState;
            }
            else if (string.Compare(appResources.getMenuText(17), menu) == 0 ||
                string.Compare(appResources.getMenuText(18), menu) == 0)
            {
                // 17 TournList 
                // 18 TournBrac
                return boolChampionshipTournamentState || boolPostSeasonState;
            }
            else
            {
                //ERROR NO VALID MENU
                System.Windows.Forms.MessageBox.Show("ERROR: DIRECTOR CLASS NO VALID MENU NAME PASSED TO GET MENU AVAILABILITY");
                return false;
            } //END IF

        } //END

        //---------------------------------------------------------------------
        //---------------------------------------------------------------------
        //CURRENT MENU---------------------------------------------------------
        //---------------------------------------------------------------------
        //---------------------------------------------------------------------

        //GET MENU-------------------------------------------------------------
        
        public string getCurrentMenuOpenString()
        {
            //GET CURRENT OPEN MENU
            return currentMenuOpen;
        } //END

        //SET MENU-------------------------------------------------------------

        public void setCurrentMenuOpenString(string menuOpen)
        {
            //SET CURRENT OPEN MENU
            currentMenuOpen = menuOpen;
        } //END

        //GET INDEX------------------------------------------------------------

        public int getCurrentMenuIndexInt()
        {
            //GET MENU INDEX
            return currentMenuIndex;
        } //END

        //SET INDEX------------------------------------------------------------

        public void setCurrentMenuIndexInt(int menuIndex)
        {
            //SET MENU INDEX
            currentMenuIndex = menuIndex;
        } //END

    } //END
} //END
