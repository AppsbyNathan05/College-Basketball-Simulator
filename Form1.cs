using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace College_Basketball_Simulator
{
    public partial class Form1 : Form
    {
        //DIRECTS INFORMATION
        private Director appDirector = new Director();

        //STACK OF PREVIOUS MENUS
        private Stack<string> stackBack = new Stack<string>();
        private Stack<int> stackBackIndex = new Stack<int>();

        //RESOURCES
        private static Resources appResources = new Resources();

        public Form1()
        {
            //INITIALIZE COMPONENT (DON'T DELETE)
            InitializeComponent();

            //INTIALIZE DROP DOWNS-------------------------------------------------

            comboBoxConfSchedFind.Items.Add("ALL TEAMS");

            for (int conferenceIndex = 0; conferenceIndex < appResources.getLengthOfConferenceNames(); conferenceIndex++)
            {
                //GET CONFERENCE NAME
                string conferenceDisplayName = appResources.getConferenceName(conferenceIndex);

                //ADD CONFERENCE TO DROP DOWN
                comboBoxConferencesStand.Items.Add(conferenceDisplayName);
                comboBoxConfSchedFind.Items.Add(conferenceDisplayName);
                comboBoxConferencesConfTournBrac.Items.Add(conferenceDisplayName);
                
            } //END FOR

            for (int monthIndex = 0; monthIndex < 12; monthIndex++)
            {
                //ADD MONTH TO DROP DOWN
                comboBoxMonthSimTo.Items.Add(appResources.getMonth(monthIndex));
                comboBoxMonthStartFrom.Items.Add(appResources.getMonth(monthIndex));
            } //END FOR

            //DISPLAY--------------------------------------------------------------

            dataGridViewConferencesConfTournFind.DataSource = appDirector.getSelectConferencesDataTable();
            dataGridViewTeamsSchedFind.DataSource = appDirector.getSelectTeamsDataTable();
            dataGridViewDatesSchedFind.DataSource = appDirector.getSelectDatesDataTable();

            //SAVE AND LOAD--------------------------------------------------------

            dataGridViewSavesSaveAs.DataSource = appDirector.getSaveAsDataTable();
            dataGridViewLoadsLoad.DataSource = appDirector.getLoadDataTable();

            //SCHEDULES------------------------------------------------------------

            dataGridViewTeamSchedTeamSched.DataSource = appDirector.getTeamSchedDataTable();
            dataGridViewDateSchedDateSched.DataSource = appDirector.getDateSchedDataTable();

            //STANDINGS------------------------------------------------------------

            upDateConferenceStandingsTables();

            //TOP 25---------------------------------------------------------------

            dataGridViewTop25Top25.DataSource = appDirector.getTop25DataTable();

            //TOURNAMENTS----------------------------------------------------------

            dataGridViewChampTournProListTournProList.DataSource = appDirector.getChampTournProListDataTable();
            dataGridViewChampTournListTournList.DataSource = appDirector.getChampTournListDataTable();

            //SETTINGS-------------------------------------------------------------

            comboBoxSimTypeSet.Items.Add(appResources.getSimulationTypeText());

            //---------------------------------------------------------------------

            // 0 MainMenuIntro 
            // 1 MainMenu 
            // 3 SaveFold 

            //IF NO SAVE FOLDER
            //LOAD SAVE FOLDER MENU
            //ELSE IF NO DATA
            //LOAD INTRO MAIN MENU
            //ELSE
            //LOAD MAIN MENU
            if (appDirector.getMenuAvailability(appResources.getMenuText(3)))
            {
                loadMenus(appResources.getMenuText(3));
            }
            else if (appDirector.getMenuAvailability(appResources.getMenuText(0)))
            {
                loadMenus(appResources.getMenuText(0));
            }
            else
            {
                loadMenus(appResources.getMenuText(1));
            } //END IF

        } //END

        private void Form1_Load(object sender, EventArgs e)
        {
            
        } //END

        //---------------------------------------------------------------------
        //---------------------------------------------------------------------
        //LOCAL FUNCTIONS------------------------------------------------------
        //---------------------------------------------------------------------
        //---------------------------------------------------------------------

        //---------------------------------------------------------------------
        //UPDATE TABLES--------------------------------------------------------
        //---------------------------------------------------------------------

        //STANDINGS------------------------------------------------------------

        private void upDateConferenceStandingsTables()
        {
            dataGridViewConference1Stand.DataSource = appDirector.getConferenceStandingsDataTable(0);
            dataGridViewConference2Stand.DataSource = appDirector.getConferenceStandingsDataTable(1);
            dataGridViewConference3Stand.DataSource = appDirector.getConferenceStandingsDataTable(2);
            dataGridViewConference4Stand.DataSource = appDirector.getConferenceStandingsDataTable(3);
            dataGridViewConference5Stand.DataSource = appDirector.getConferenceStandingsDataTable(4);
            dataGridViewConference6Stand.DataSource = appDirector.getConferenceStandingsDataTable(5);
            dataGridViewConference7Stand.DataSource = appDirector.getConferenceStandingsDataTable(6);
            dataGridViewConference8Stand.DataSource = appDirector.getConferenceStandingsDataTable(7);
            dataGridViewConference9Stand.DataSource = appDirector.getConferenceStandingsDataTable(8);
            dataGridViewConference10Stand.DataSource = appDirector.getConferenceStandingsDataTable(9);
            dataGridViewConference11Stand.DataSource = appDirector.getConferenceStandingsDataTable(10);
            dataGridViewConference12Stand.DataSource = appDirector.getConferenceStandingsDataTable(11);
            dataGridViewConference13Stand.DataSource = appDirector.getConferenceStandingsDataTable(12);
            dataGridViewConference14Stand.DataSource = appDirector.getConferenceStandingsDataTable(13);
            dataGridViewConference15Stand.DataSource = appDirector.getConferenceStandingsDataTable(14);
            dataGridViewConference16Stand.DataSource = appDirector.getConferenceStandingsDataTable(15);
            dataGridViewConference17Stand.DataSource = appDirector.getConferenceStandingsDataTable(16);
            dataGridViewConference18Stand.DataSource = appDirector.getConferenceStandingsDataTable(17);
            dataGridViewConference19Stand.DataSource = appDirector.getConferenceStandingsDataTable(18);
            dataGridViewConference20Stand.DataSource = appDirector.getConferenceStandingsDataTable(19);
            dataGridViewConference21Stand.DataSource = appDirector.getConferenceStandingsDataTable(20);
            dataGridViewConference22Stand.DataSource = appDirector.getConferenceStandingsDataTable(21);
            dataGridViewConference23Stand.DataSource = appDirector.getConferenceStandingsDataTable(22);
            dataGridViewConference24Stand.DataSource = appDirector.getConferenceStandingsDataTable(23);
            dataGridViewConference25Stand.DataSource = appDirector.getConferenceStandingsDataTable(24);
            dataGridViewConference26Stand.DataSource = appDirector.getConferenceStandingsDataTable(25);
            dataGridViewConference27Stand.DataSource = appDirector.getConferenceStandingsDataTable(26);
            dataGridViewConference28Stand.DataSource = appDirector.getConferenceStandingsDataTable(27);
            dataGridViewConference29Stand.DataSource = appDirector.getConferenceStandingsDataTable(28);
            dataGridViewConference30Stand.DataSource = appDirector.getConferenceStandingsDataTable(29);
            dataGridViewConference31Stand.DataSource = appDirector.getConferenceStandingsDataTable(30);
            dataGridViewConference32Stand.DataSource = appDirector.getConferenceStandingsDataTable(31);
        } //END

        //---------------------------------------------------------------------
        //NAVIGATION-----------------------------------------------------------
        //---------------------------------------------------------------------

        private void goTo(string destinationMenu)
        {
            //FILL IN INDEXES
            //CALL GO TO
            goTo(destinationMenu, -1);
        } //END

        private void goTo(string destinationMenu, int destinationMenuIndex)
        {
            //PUSH MENU ON BACK STACK
            stackBack.Push(appDirector.getCurrentMenuOpenString());

            //PUSH MENU INDEX ON STACK
            stackBackIndex.Push(appDirector.getCurrentMenuIndexInt());

            //LOAD DESTINATION MENU
            loadMenus(destinationMenu, destinationMenuIndex);
        } //END

        private void loadMenus(string destinationMenu)
        {
            //FILL INDEX
            //CALL LOAD MENUS
            loadMenus(destinationMenu, -1);
        } //END

        private void loadMenus(string destinationMenu, int destinationMenuIndex)
        {
            //INTIALIZE ALL PANELS TO NOT BE VISIBLE
            panelMainMenuIntro.Visible = false;
            panelMainMenu.Visible = false;
            panelSettings.Visible = false;
            panelSaveFold.Visible = false;
            panelSaveAs.Visible = false;
            panelLoad.Visible = false;
            panelSimTo.Visible = false;
            panelStartFrom.Visible = false;
            panelSchedFind.Visible = false;
            panelTeamSched.Visible = false;
            panelDateSched.Visible = false;
            panelStand.Visible = false;
            panelTop25.Visible = false;
            panelTournProList.Visible = false;
            panelTournProBrac.Visible = false;
            panelConfTournBrac.Visible = false;
            panelConfTournFind.Visible = false;
            panelTournList.Visible = false;
            panelTournBrac.Visible = false;

            //STORE CURRENT MENU OPEN
            appDirector.setCurrentMenuOpenString(destinationMenu);

            //STORE CURRENT MENU INDEX
            appDirector.setCurrentMenuIndexInt(destinationMenuIndex);

            //SET MENU STRIP VISIBILITY--------------------------------------------

            // 5 Load 
            if (appDirector.getMenuAvailability(appResources.getMenuText(5)) && 
                string.Compare(destinationMenu, appResources.getMenuText(5)) != 0)
            {
                //SHOW LOAD DROP DOWN
                loadToolStripMenuItem.Visible = true;
            }
            else
            {
                //HIDE LOAD DROP DOWN
                loadToolStripMenuItem.Visible = false;
            } //END IF

            // 4 SaveAs (SAVE)
            if (appDirector.getMenuAvailability(appResources.getMenuText(4)) && 
                string.Compare(destinationMenu, appResources.getMenuText(4)) != 0 && 
                appDirector.checkIfCurrentSimulationSaved())
            {
                //SHOW SAVE DROP DOWN
                saveToolStripMenuItem.Visible = true;
            }
            else
            {
                //HIDE SAVE DROP DOWN
                saveToolStripMenuItem.Visible = false;
            } //END IF

            // 4 SaveAs (SAVE AS)
            if (appDirector.getMenuAvailability(appResources.getMenuText(4)) && 
                string.Compare(destinationMenu, appResources.getMenuText(4)) != 0)
            {
                //SHOW SAVE AS DROP DOWN
                saveAsToolStripMenuItem.Visible = true;
            }
            else
            {
                //HIDE SAVE AS DROP DOWN
                saveAsToolStripMenuItem.Visible = false;
            } //END IF

            // 2 Settings
            if (appDirector.getMenuAvailability(appResources.getMenuText(2)) && 
                string.Compare(destinationMenu, appResources.getMenuText(2)) != 0)
            {
                //SHOW SETTINGS DROP DOWN
                settingsToolStripMenuItem.Visible = true;
            }
            else
            {
                //HIDE SETTINGS DROP DOWN
                settingsToolStripMenuItem.Visible = false;
            } //END IF

            // 6 SimTo 
            if (appDirector.getMenuAvailability(appResources.getMenuText(6)) && 
                string.Compare(destinationMenu, appResources.getMenuText(6)) != 0)
            {
                //SHOW SIM TO DROP DOWN
                simToToolStripMenuItem.Visible = true;
            }
            else
            {
                //HIDE SIM TO DROP DOWN
                simToToolStripMenuItem.Visible = false;
            } //END IF

            // 7 StartFrom
            if (appDirector.getMenuAvailability(appResources.getMenuText(7)) && 
                string.Compare(destinationMenu, appResources.getMenuText(7)) != 0)
            {
                //SHOW START FROM DROP DOWN
                startFromPreviousDateToolStripMenuItem.Visible = true;
            }
            else
            {
                //HIDE START FROM DROP DOWN
                startFromPreviousDateToolStripMenuItem.Visible = false;
            } //END IF

            // 8 SchedFind 
            if (appDirector.getMenuAvailability(appResources.getMenuText(8)) && 
                string.Compare(destinationMenu, appResources.getMenuText(8)) != 0)
            {
                //SHOW SCHEDULE DROP DOWN
                scheduleToolStripMenuItem.Visible = true;
            }
            else
            {
                //HIDE SCHEDULE DROP DONW
                scheduleToolStripMenuItem.Visible = false;
            } //END IF

            // 11 Stand
            if (appDirector.getMenuAvailability(appResources.getMenuText(11)) && 
                string.Compare(destinationMenu, appResources.getMenuText(11)) != 0)
            {
                //SHOW STANDINGS DROP DOWN
                standingsToolStripMenuItem.Visible = true;
            }
            else
            {
                //HIDE STANDINGS DROP DOWN
                standingsToolStripMenuItem.Visible = false;
            } //END IF

            // 12 Top25 
            if (appDirector.getMenuAvailability(appResources.getMenuText(12)) && 
                string.Compare(destinationMenu, appResources.getMenuText(12)) != 0)
            {
                //SHOW TOP 25 DROP DOWN
                top25ToolStripMenuItem.Visible = true;
            }
            else
            {
                //HIDE TOP 25 DROP DOWN
                top25ToolStripMenuItem.Visible = false;
            } //END IF

            // 13 TournProList 
            // 14 TournProBrac 
            if (appDirector.getMenuAvailability(appResources.getMenuText(13)) && 
                string.Compare(destinationMenu, appResources.getMenuText(13)) != 0 && 
                string.Compare(destinationMenu, appResources.getMenuText(14)) != 0)
            {
                //SHOW TOURNAMENT PROJECTION DROP DOWN
                tournamentProjectionToolStripMenuItem.Visible = true;
            }
            else
            {
                //HIDE TOURNAMENT PROJECTION DROP DOWN
                tournamentProjectionToolStripMenuItem.Visible = false;
            } //END IF
 
            // 15 ConTournBrac
            // 16 ConTournFind 
            if (appDirector.getMenuAvailability(appResources.getMenuText(15)) && 
                string.Compare(destinationMenu, appResources.getMenuText(15)) != 0 && 
                string.Compare(destinationMenu, appResources.getMenuText(16)) != 0)
            {
                //SHOW CONFERENCE TOURNAMENT DROP DOWN
                conferenceTournamentToolStripMenuItem.Visible = true;
            }
            else
            {
                //HIDE CONFERENCE TOURNAMENT DROP DOWN
                conferenceTournamentToolStripMenuItem.Visible = false;
            } //END IF
 
            // 17 TournList 
            // 18 TournBrac
            if (appDirector.getMenuAvailability(appResources.getMenuText(17)) &&
                string.Compare(destinationMenu, appResources.getMenuText(17)) != 0 &&
                string.Compare(destinationMenu, appResources.getMenuText(18)) != 0)
            {
                //SHOW CHAMPIONSHIP TOURNAMENT DROP DOWN
                championshipTournamentToolStripMenuItem.Visible = true;
            }
            else
            {
                //HIDE CHAMPIONSHIP TOURNAMENT DROP DOWN
                championshipTournamentToolStripMenuItem.Visible = false;
            } //END IF

            // 0 MainMenuIntro 
            // 1 MainMenu 
            if (appDirector.getMenuAvailability(appResources.getMenuText(1)) &&
                string.Compare(destinationMenu, appResources.getMenuText(0)) != 0 &&
                string.Compare(destinationMenu, appResources.getMenuText(1)) != 0)
            {
                //SHOW MAIN MENU DROP DOWN
                mainMenuToolStripMenuItem.Visible = true;
            }
            else
            {
                //HIDE MAIN MENU DROP DOWN
                mainMenuToolStripMenuItem.Visible = false;
            } //END IF

            //LOAD NEXT MENU-------------------------------------------------------

            if (string.Compare(destinationMenu, appResources.getMenuText(0)) == 0)
            {
                // 0 MainMenuIntro 
                loadMainMenuIntro();
            }
            else if (string.Compare(destinationMenu, appResources.getMenuText(1)) == 0)
            {
                // 1 MainMenu 
                loadMainMenu();
            }
            else if (string.Compare(destinationMenu, appResources.getMenuText(2)) == 0)
            {
                // 2 Settings
                loadSettings();
            }
            else if (string.Compare(destinationMenu, appResources.getMenuText(3)) == 0)
            {
                // 3 SaveFold 
                loadSaveFold();
            }
            else if (string.Compare(destinationMenu, appResources.getMenuText(4)) == 0)
            {
                // 4 SaveAs 
                loadSaveAs();
            }
            else if (string.Compare(destinationMenu, appResources.getMenuText(5)) == 0)
            {
                // 5 Load 
                loadLoad();
            }
            else if (string.Compare(destinationMenu, appResources.getMenuText(6)) == 0)
            {
                // 6 SimTo
                loadSimTo();
            }
            else if (string.Compare(destinationMenu, appResources.getMenuText(7)) == 0)
            { 
                // 7 StartFrom
                loadStartFrom();
            }
            else if (string.Compare(destinationMenu, appResources.getMenuText(8)) == 0)
            {
                // 8 SchedFind
                loadSchedFind(destinationMenuIndex);
            }
            else if (string.Compare(destinationMenu, appResources.getMenuText(9)) == 0)
            { 
                // 9 TeamSched
                loadTeamSched(destinationMenuIndex);
            }
            else if (string.Compare(destinationMenu, appResources.getMenuText(10)) == 0)
            { 
                // 10 DateSched 
                loadDateSched(destinationMenuIndex);
            }
            else if (string.Compare(destinationMenu, appResources.getMenuText(11)) == 0)
            {
                // 11 Stand
                loadStand(destinationMenuIndex);
            }
            else if (string.Compare(destinationMenu, appResources.getMenuText(12)) == 0)
            {
                // 12 Top25 
                loadTop25();
            }
            else if (string.Compare(destinationMenu, appResources.getMenuText(13)) == 0)
            {
                // 13 TournProList 
                loadTournProList();
            }
            else if (string.Compare(destinationMenu, appResources.getMenuText(14)) == 0)
            {
                // 14 TournProBrac
                loadTournProBrac(destinationMenuIndex);
            }
            else if (string.Compare(destinationMenu, appResources.getMenuText(15)) == 0)
            { 
                // 15 ConTournBrac
                loadConfTournBrac(destinationMenuIndex);
            }
            else if (string.Compare(destinationMenu, appResources.getMenuText(16)) == 0)
            {
                // 16 ConTournFind
                loadConfTournFind();
            }
            else if (string.Compare(destinationMenu, appResources.getMenuText(17)) == 0)
            { 
                // 17 TournList 
                loadTournList();
            }
            else if (string.Compare(destinationMenu, appResources.getMenuText(18)) == 0)
            {
                // 18 TournBrac
                loadTournBrac(destinationMenuIndex);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("ERROR: LOAD MENUS FUNCTION DIDN'T FIND MENU TO LOAD");
            } //END

        } //END

        //---------------------------------------------------------------------
        //LOAD PANEL-----------------------------------------------------------
        //---------------------------------------------------------------------

        private void loadMainMenuIntro()
        {
            //SHOW MENU PANEL
            panelMainMenuIntro.Visible = true;
            buttonBackMainIntro.Visible = showBackButton();
        } //END

        private void loadMainMenu()
        {
            //SHOW MENU PANEL
            panelMainMenu.Visible = true;

            //SHOW SIM TO BUTTON
            buttonSimulateMain.Visible = appDirector.getSimToAvailability();

            //SHOW START FROM BUTTON
            buttonRestartDateMain.Visible = true;

            //SHOW IMPORT DATA BUTTON
            buttonImportDataMain.Visible = appDirector.getImportDataAvailability();

            //SHOW BACK BUTTON
            buttonBackMain.Visible = showBackButton();

            //SET CURRENT DAY LABEL
            labelCurrentDayMain.Text = "Current Simulation Date " + appDirector.getCurrentSimulationDate().ToString("d");
        } //END

        private void loadSettings()
        {
            //SHOW MENU PANEL
            panelSettings.Visible = true;

            //SHOW BACK BUTTON
            buttonBackSet.Visible = showBackButton();
        } //END

        private void loadSaveFold()
        {
            //SHOW MENU PANEL
            panelSaveFold.Visible = true;
        } //END

        private void loadSaveAs()
        {
            //SHOW MENU PANEL
            panelSaveAs.Visible = true;

            //SHOW BACK BUTTON
            buttonBackSaveAs.Visible = showBackButton();

            //FILL SAVE AS DATA TABLE
            appDirector.fillSaveAsDataTable();
        } //END

        private void loadLoad()
        {
            //SHOW MENU PANEL
            panelLoad.Visible = true;

            //SHOW BACK BUTTON
            buttonBackLoad.Visible = showBackButton();

            //FILL LOAD DATA TABLE
            appDirector.fillLoadDataTable();
        } //END

        private void loadSimTo()
        {
            //SHOW MENU PANEL
            panelSimTo.Visible = true;

            //SHOW BACK BUTTON
            buttonBackSimTo.Visible = showBackButton();

            //SET YEAR LABEL
            labelYear20SimTo.Text = "20XX";

            //CLEAR DROP DOWN
            comboBoxDaySimTo.Items.Clear();

            //SET CURRENT DAY LABEL
            labelCurrentDaySimTo.Text = "Current Simulation Date " + appDirector.getCurrentSimulationDate().ToString("d");
        } //END

        private void loadStartFrom()
        {
            //SHOW MENU PANEL
            panelStartFrom.Visible = true;

            //SHOW BACK BUTTON
            buttonBackStartFrom.Visible = showBackButton();

            //SET YEAR LABEL
            labelYear20StartFrom.Text = "20XX";

            //CLEAR DROP DOWN
            comboBoxDayStartFrom.Items.Clear();

            //SET CURRENT DAY LABEL
            labelCurrentDayStartFrom.Text = "Current Simulation Date " + appDirector.getCurrentSimulationDate().ToString("d");
        } //END

        private void loadSchedFind(int conferenceIndex)
        {
            //SHOW MENU PANEL
            panelSchedFind.Visible = true;

            //SHOW BACK BUTTON
            buttonBackSchedFind.Visible = showBackButton();

            //SET CURRENT DAY LABEL
            labelCurrentDaySchedFind.Text = "Current Simulation Date " + appDirector.getCurrentSimulationDate().ToString("d");

            //FILL TEAMS DATA TABLE
            //(CONFERENCE INDEX == 0 IS ALL CONFERENCES)
            appDirector.fillSelectTeamsDataTable(conferenceIndex);

            //FILL DATES DATA TABLE
            appDirector.fillSelectDatesDataTable();

        } //END

        private void loadTeamSched(int teamIndex)
        {
            //SHOW MENU PANEL
            panelTeamSched.Visible = true;

            //SHOW BACK BUTTON
            buttonBackTeamSched.Visible = showBackButton();

            //FILL TEAM SCHEDULE TABLE
            appDirector.fillTeamSchedDataTable(teamIndex);

            //SET TEAM NAME LABEL
            labelTeamSchedTeamSched.Text = appResources.getTeamName(teamIndex);

            //SET CURRENT DAY LABEL
            labelCurrentDayTeamSched.Text = "Current Simulation Date " + appDirector.getCurrentSimulationDate().ToString("d");

            //SET WINS AND LOSSES LABELS
            labelRecWinsTeamSched.Text = appDirector.getWins(teamIndex).ToString();
            labelRecLossesTeamSched.Text = appDirector.getLosses(teamIndex).ToString();
            labelConfRecWinsTeamSched.Text = appDirector.getConferenceWins(teamIndex).ToString();
            labelConfRecLossesTeamSched.Text = appDirector.getConferenceLosses(teamIndex).ToString();
        } //END

        private void loadDateSched(int dateIndex)
        {
            //SHOW MENU PANEL
            panelDateSched.Visible = true;

            //SHOW BACK BUTTON
            buttonBackDateSched.Visible = showBackButton();

            //FILL DATE SCHEDULE TABLE
            appDirector.fillDateSchedDataTable(dateIndex);

            //GET DATE TEXT
            string dateText = dataGridViewDatesSchedFind.Rows[dateIndex].Cells[0].Value.ToString();

            //CONVERT TO DATETIME THEN CONVERT TO STRING TO FORMAT DATE
            //SET DATE LABEL
            labelDateSchedDateSched.Text = Convert.ToDateTime(dateText).ToString("d");

            //SET CURRENT DAY LABEL
            labelCurrentDayDateSched.Text = "Current Simulation Date " + appDirector.getCurrentSimulationDate().ToString("d");
        } //END

        private void loadStand(int conferenceIndex)
        {
            //SHOW MENU PANEL
            panelStand.Visible = true;

            //SHOW BACK BUTTON
            buttonBackStand.Visible = showBackButton();

            //FILL CONFERENCE STANDINGS TABLES
            appDirector.fillConferenceStandingsDataTables(conferenceIndex);

            //SET CONFERENCE LABELS
            labelConference1Stand.Text = appDirector.getConferenceStandingDisplayName(0);
            labelConference2Stand.Text = appDirector.getConferenceStandingDisplayName(1);
            labelConference3Stand.Text = appDirector.getConferenceStandingDisplayName(2);
            labelConference4Stand.Text = appDirector.getConferenceStandingDisplayName(3);
            labelConference5Stand.Text = appDirector.getConferenceStandingDisplayName(4);
            labelConference6Stand.Text = appDirector.getConferenceStandingDisplayName(5);
            labelConference7Stand.Text = appDirector.getConferenceStandingDisplayName(6);
            labelConference8Stand.Text = appDirector.getConferenceStandingDisplayName(7);
            labelConference9Stand.Text = appDirector.getConferenceStandingDisplayName(8);
            labelConference10Stand.Text = appDirector.getConferenceStandingDisplayName(9);
            labelConference11Stand.Text = appDirector.getConferenceStandingDisplayName(10);
            labelConference12Stand.Text = appDirector.getConferenceStandingDisplayName(11);
            labelConference13Stand.Text = appDirector.getConferenceStandingDisplayName(12);
            labelConference14Stand.Text = appDirector.getConferenceStandingDisplayName(13);
            labelConference15Stand.Text = appDirector.getConferenceStandingDisplayName(14);
            labelConference16Stand.Text = appDirector.getConferenceStandingDisplayName(15);
            labelConference17Stand.Text = appDirector.getConferenceStandingDisplayName(16);
            labelConference18Stand.Text = appDirector.getConferenceStandingDisplayName(17);
            labelConference19Stand.Text = appDirector.getConferenceStandingDisplayName(18);
            labelConference20Stand.Text = appDirector.getConferenceStandingDisplayName(19);
            labelConference21Stand.Text = appDirector.getConferenceStandingDisplayName(20);
            labelConference22Stand.Text = appDirector.getConferenceStandingDisplayName(21);
            labelConference23Stand.Text = appDirector.getConferenceStandingDisplayName(22);
            labelConference24Stand.Text = appDirector.getConferenceStandingDisplayName(23);
            labelConference25Stand.Text = appDirector.getConferenceStandingDisplayName(24);
            labelConference26Stand.Text = appDirector.getConferenceStandingDisplayName(25);
            labelConference27Stand.Text = appDirector.getConferenceStandingDisplayName(26);
            labelConference28Stand.Text = appDirector.getConferenceStandingDisplayName(27);
            labelConference29Stand.Text = appDirector.getConferenceStandingDisplayName(28);
            labelConference30Stand.Text = appDirector.getConferenceStandingDisplayName(29);
            labelConference31Stand.Text = appDirector.getConferenceStandingDisplayName(30);
            labelConference32Stand.Text = appDirector.getConferenceStandingDisplayName(31);

            //UPDATE CONFERENCE STANDINGS
            upDateConferenceStandingsTables();

            //SET CURRENT DAY LABEL
            labelCurrentDayStand.Text = "Current Simulation Date " + appDirector.getCurrentSimulationDate().ToString("d");
        } //END

        private void loadTop25()
        {
            //SHOW MENU PANEL
            panelTop25.Visible = true;

            //SHOW BACK BUTTON
            buttonBackTop25.Visible = showBackButton();

            //FILL TOP 25 TABLE
            appDirector.fillTop25DataTable();

            //SET CURRENT DAY LABEL
            labelCurrentDayTop25.Text = "Current Simulation Date " + appDirector.getCurrentSimulationDate().ToString("d");
        } //END

        private void loadTournProList()
        {
            //SHOW MENU PANEL
            panelTournProList.Visible = true;

            //SHOW BACK BUTTON
            buttonBackTournProList.Visible = showBackButton();

            //FILL TOURNAMENT PROJECTIONS LIST
            appDirector.fillChampTournProListDataTable();

            //SET CURRENT DAY LABEL
            labelCurrentDayTournProList.Text = "Current Simulation Date " + appDirector.getCurrentSimulationDate().ToString("d");
        } //END

        private void loadTournProBrac(int viewIndex)
        {
            //0 FULL BRACKET
            //1 SWEET 16
            //2 WEST
            //3 MIDWEST
            //4 EAST
            //5 SOUTH
            string[] tournamentBracket = appDirector.getProjectedTournamentBracket(viewIndex);

            //SHOW MENU PANEL
            panelTournProBrac.Visible = true;

            //SHOW BACK BUTTON
            buttonBackTournProBrac.Visible = showBackButton();

            //SET CURRENT DAY LABEL
            labelCurrentDayTournProBrac.Text = "Current Simulation Date " + appDirector.getCurrentSimulationDate().ToString("d");

            textBoxChampTournProBracTournProBrac.Clear();

            for (int index = 0; index < tournamentBracket.Length; index++)
            {
                textBoxChampTournProBracTournProBrac.AppendText(tournamentBracket[index] + "\r\n");
            }//END FOR
        } //END

        private void loadConfTournBrac(int conferenceIndex)
        {
            string[] tournamentBracket = appDirector.getConferenceTournamentBracket(conferenceIndex);

            //SHOW MENU PANEL
            panelConfTournBrac.Visible = true;

            //SHOW BACK BUTTON
            buttonBackConfTournBrac.Visible = showBackButton();

            //SET CONFERENCE NAME
            labelConfTournConfTournBrac.Text = appResources.getConferenceName(conferenceIndex);

            //SET CURRENT DAY LABEL
            labelCurrentDayTournBrac.Text = "Current Simulation Date " + appDirector.getCurrentSimulationDate().ToString("d");

            textBoxConfTournBracConfTournBrac.Clear();

            for (int index = 0; index < tournamentBracket.Length; index++)
            {
                textBoxConfTournBracConfTournBrac.AppendText(tournamentBracket[index] + "\r\n");
            }//END FOR
        } //END

        private void loadConfTournFind()
        {
            //SHOW MENU PANEL
            panelConfTournFind.Visible = true;

            //SHOW BACK BUTTON
            buttonBackConfTournFind.Visible = showBackButton();

            //SET CURRENT DAY LABEL
            labelCurrentDayConfTournFind.Text = "Current Simulation Date " + appDirector.getCurrentSimulationDate().ToString("d");
        } //END

        private void loadTournList()
        {
            //SHOW MENU PANEL
            panelTournList.Visible = true;

            //SHOW BACK BUTTON
            buttonBackTournList.Visible = showBackButton();

            //FILL TOURNAMENT LIST 
            appDirector.fillChampTournListDataTable();

            //SET CURRENT DAY LABEL
            labelCurrentDayTournList.Text = "Current Simulation Date " + appDirector.getCurrentSimulationDate().ToString("d");
        } //END

        private void loadTournBrac(int viewIndex)
        {
            //0 FULL BRACKET
            //1 SWEET 16
            //2 WEST
            //3 MIDWEST
            //4 EAST
            //5 SOUTH
            string[] tournamentBracket = appDirector.getTournamentBracket(viewIndex);

            //SHOW MENU PANEL
            panelTournBrac.Visible = true;

            //SHOW BACK BUTTON
            buttonBackTournBrac.Visible = showBackButton();

            //SET CURRENT DAY LABEL
            labelCurrentDayTournBrac.Text = "Current Simulation Date " + appDirector.getCurrentSimulationDate().ToString("d");

            textBoxChampTournBracTournBrac.Clear();

            for (int index = 0; index < tournamentBracket.Length; index++)
            {
                textBoxChampTournBracTournBrac.AppendText(tournamentBracket[index] + "\r\n");
            }//END FOR
        } //END

        //---------------------------------------------------------------------
        //SHOW BACK BUTTON?----------------------------------------------------
        //---------------------------------------------------------------------

        private Boolean showBackButton()
        {
            //IF MENUS TO GO BACK TO
            //SHOW BACK BUTTON
            //ELSE
            //DON'T SHOW BACK BUTTON
            if (stackBack.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            } //END IF

        } //END

        //---------------------------------------------------------------------
        //BACK GO TO-----------------------------------------------------------
        //---------------------------------------------------------------------

        private void backGoTo()
        {
            //IF MENUS TO GO BACK TO
            //GO BACK TO MENU
            //ELSE IF NO MENU TO GO BACK TO
            //RETURN TO CURRENT MENU
            //ELSE
            //ERROR
            if (stackBack.Count > 0)
            {
                //POP MENU OFF STACK
                string menuName = stackBack.Pop();

                //POP MENU INDEX OFF STACK
                int menuIndex = stackBackIndex.Pop();

                //IF MENU AVAILABLE
                //GOTO MENU
                //ELSE
                //GO BACK TO NEXT MENU
                if (appDirector.getMenuAvailability(menuName))
                {
                    loadMenus(menuName, menuIndex);
                }
                else
                {
                    backGoTo();
                } //END IF

            }
            else if (stackBack.Count == 0)
            {
                loadMenus(appDirector.getCurrentMenuOpenString());
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("ERROR: BACKGOTO FUNCTION FAIL");
            } //END IF

        } //END

        //---------------------------------------------------------------------
        //---------------------------------------------------------------------
        //NAVIGATION BUTTONS---------------------------------------------------
        //---------------------------------------------------------------------
        //---------------------------------------------------------------------

        //---------------------------------------------------------------------
        //MENU STRIP BUTTONS---------------------------------------------------
        //---------------------------------------------------------------------

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 5 Load 
            goTo(appResources.getMenuText(5));
        } //END

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //   Save

            //IF FILE SAVED
            //DISPLAY SUCCESS MESSAGE
            //ELSE
            //DISPLAY FAIL MESSAGE
            if (appDirector.saveSimulation())
            {
                System.Windows.Forms.MessageBox.Show("File Saved");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("ERROR: FAILED TO SAVE FILE");
            } //END IF
        } //END

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 4 SaveAs 
            goTo(appResources.getMenuText(4));
        } //END

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 2 Settings
            goTo(appResources.getMenuText(2));
        } //END

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //EXIT APP
            Application.Exit();
        } //END

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 1 MainMenu 
            goTo(appResources.getMenuText(1));
        } //END

        private void scheduleToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            // 9 (8) TeamSched (TEAM SCHEDULE FIND)
            goTo(appResources.getMenuText(8));
        } //END

        private void standingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 11 Stand
            goTo(appResources.getMenuText(11));
        } //END

        private void top25ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 12 Top25 
            goTo(appResources.getMenuText(12));
        } //END

        private void tournamentProjectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 13 TournProList
            goTo(appResources.getMenuText(13));
        } //END

        private void conferenceTournamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 16 ConTournFind 
            goTo(appResources.getMenuText(16));
        } //END

        private void championshipTournamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 18 TournBrac
            goTo(appResources.getMenuText(18));
        } //END

        private void simToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 6 SimTo 
            goTo(appResources.getMenuText(6));
        } //END

        private void startFromPreviousDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 7 StartFrom
            goTo(appResources.getMenuText(7));
        } //END

        //---------------------------------------------------------------------
        //BACK BUTTONS---------------------------------------------------------
        //---------------------------------------------------------------------

        private void buttonBackMainIntro_Click(object sender, EventArgs e)
        {
            //BACK TO PREVIOUS MENU
            backGoTo();
        } //END

        private void buttonBackMain_Click(object sender, EventArgs e)
        {
            //BACK TO PREVIOUS MENU
            backGoTo();
        } //END

        private void buttonBackSet_Click(object sender, EventArgs e)
        {
            //BACK TO PREVIOUS MENU
            backGoTo();
        } //END

        private void buttonBackSaveAs_Click(object sender, EventArgs e)
        {
            //BACK TO PREVIOUS MENU
            backGoTo();
        } //END

        private void buttonBackLoad_Click(object sender, EventArgs e)
        {
            //BACK TO PREVIOUS MENU
            backGoTo();
        } //END

        private void buttonBackSimTo_Click(object sender, EventArgs e)
        {
            //BACK TO PREVIOUS MENU
            backGoTo();
        } //END

        private void buttonBackStartFrom_Click(object sender, EventArgs e)
        {
            //BACK TO PREVIOUS MENU
            backGoTo();
        } //END

        private void buttonBackSchedFind_Click(object sender, EventArgs e)
        {
            //BACK TO PREVIOUS MENU
            backGoTo();
        } //END

        private void buttonBackTeamSched_Click(object sender, EventArgs e)
        {
            //BACK TO PREVIOUS MENU
            backGoTo();
        } //END

        private void buttonBackDateSched_Click(object sender, EventArgs e)
        {
            //BACK TO PREVIOUS MENU
            backGoTo();
        } //END

        private void buttonBackStand_Click(object sender, EventArgs e)
        {
            //BACK TO PREVIOUS MENU
            backGoTo();
        } //END

        private void buttonBackTop25_Click(object sender, EventArgs e)
        {
            //BACK TO PREVIOUS MENU
            backGoTo();
        } //END

        private void buttonBackTournProList_Click(object sender, EventArgs e)
        {
            //BACK TO PREVIOUS MENU
            backGoTo();
        } //END

        private void buttonBackTournProBrac_Click(object sender, EventArgs e)
        {
            //BACK TO PREVIOUS MENU
            backGoTo();
        } //END

        private void buttonBackConfTournBrac_Click(object sender, EventArgs e)
        {
            //BACK TO PREVIOUS MENU
            backGoTo();
        } //END

        private void buttonBackConfTournFind_Click(object sender, EventArgs e)
        {
            //BACK TO PREVIOUS MENU
            backGoTo();
        } //END

        private void buttonBackTournList_Click(object sender, EventArgs e)
        {
            //BACK TO PREVIOUS MENU
            backGoTo();
        } //END

        private void buttonBackTournBrac_Click(object sender, EventArgs e)
        {
            //BACK TO PREVIOUS MENU
            backGoTo();
        } //END

        //---------------------------------------------------------------------
        //---------------------------------------------------------------------
        //PANEL BUTTONS AND TABLES---------------------------------------------
        //---------------------------------------------------------------------
        //---------------------------------------------------------------------

        //---------------------------------------------------------------------
        //MAIN MENU INTRO BUTTONS----------------------------------------------
        //---------------------------------------------------------------------

        private void buttonImportDataMainInt_Click(object sender, EventArgs e)
        {
            //IMPORT DATA
            appDirector.importOnlineData();

            //SHOW CONFIRMATION MESSAGE
            System.Windows.Forms.MessageBox.Show("Successfully pulled data from web (hopefully)");

            // 1 MainMenu 
            goTo(appResources.getMenuText(1));
        } //END

        private void buttonSettingsMainInt_Click(object sender, EventArgs e)
        { 
            // 2 Settings
            goTo(appResources.getMenuText(2));
        } //END

        //---------------------------------------------------------------------
        //MAIN MENU BUTTONS----------------------------------------------------
        //---------------------------------------------------------------------

        private void buttonImportDataMain_Click(object sender, EventArgs e)
        {
            //IMPORT DATA
            appDirector.importOnlineData();
        } //END

        private void buttonSettingsMain_Click(object sender, EventArgs e)
        {
            // 2 Settings
            goTo(appResources.getMenuText(2));
        } //END

        private void buttonSimulateMain_Click(object sender, EventArgs e)
        {
            // 6 SimTo 
            goTo(appResources.getMenuText(6));
        } //END

        private void buttonRestartDateMain_Click(object sender, EventArgs e)
        {
            // 7 StartFrom
            goTo(appResources.getMenuText(7));
        } //END

        //---------------------------------------------------------------------
        //SETTINGS BUTTONS-----------------------------------------------------
        //---------------------------------------------------------------------

        private void buttonCancelSet_Click(object sender, EventArgs e)
        {
            //COULD IMPLEMENT A PREVIOUS SETTINGS RESET
            //BACK TO PREVIOUS MENU
            backGoTo();
        } //END

        private void buttonSaveSettingsSet_Click(object sender, EventArgs e)
        {
            //SETTINGS
            SettingsDirector settings = new SettingsDirector();

            //GET SETTINGS INPUTS
            settings.minScoringAverage = Convert.ToInt32(textBoxMinScoreRangeSet.Text);
            settings.maxScoringAverage = Convert.ToInt32(textBoxMaxScoreRangeSet.Text);
            settings.scoringDistribution = Convert.ToInt32(textBoxScoreDistRangeSet.Text);
            settings.simulationType = comboBoxSimTypeSet.SelectedItem.ToString();
            string saveFolderFilePath = textBoxSaveFoldLocationSet.Text;

            //IF SIMULATION TYPE NULL
            //SET DEFAULT VALUE
            if (settings.simulationType == null)
            {
                settings.simulationType = appResources.getSimulationTypeText();
            } //END IF

            //CHANGE SETTINGS
            //IF FAILED TO CHANGE SETTINGS
            //DISPLAY ERROR MESSAGE
            if (!appDirector.saveSettings(settings, saveFolderFilePath))
            {
                System.Windows.Forms.MessageBox.Show("Failed to change settings");
            }
        } //END

        //---------------------------------------------------------------------
        //SAVE FOLDER SETTINGS BUTTONS-----------------------------------------
        //---------------------------------------------------------------------

        private void buttonSaveSettingsSaveFold_Click(object sender, EventArgs e)
        {
            //IF SAVE FOLDER SET
            //DISPLAY SUCCESS MESSAGE
            //ELSE
            //DISPLAY FAIL MESSAGE
            if (appDirector.setSaveFolder(textBoxSaveFoldLocationSaveFold.Text))
            {
                System.Windows.Forms.MessageBox.Show("Successfully changed save file location");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("ERROR: FAILED TO CHANGE SAVE FILE LOCATION");
            } //END IF
        } //END

        //---------------------------------------------------------------------
        //SAVE AS TABLE--------------------------------------------------------
        //---------------------------------------------------------------------

        private void dataGridViewSavesSaveAs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //IF OVERWRITE
            //OVERWRITE SAVE
            //ELSE IF DELETE
            //DELETE SAVE
            if (e.ColumnIndex == 0)
            {
                //IF SAVE SUCCESS
                //DISPLAY SUCCESS MESSAGE
                //ELSE
                //DISPLAY FAIL MESSAGE
                if (appDirector.saveReplaceSimulation(
                    dataGridViewSavesSaveAs.Rows[e.RowIndex].Cells[1].Value.ToString(), 
                    textBoxSaveNameSaveAs.Text))
                {
                    System.Windows.Forms.MessageBox.Show("Successfully overwrote file");
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("ERROR: FAILED TO OVERWRITE FILE");
                } //END IF
            }
            else if (e.ColumnIndex == 2)
            {
                //IF DELETE SUCCESS
                //DISPLAY SUCCESS MESSAGE
                //ELSE
                //DISPLAY FAIL MESSAGE
                if (appDirector.deleteSimulationResultsFile(dataGridViewSavesSaveAs.Rows[e.RowIndex].Cells[1].Value.ToString()))
                {
                    System.Windows.Forms.MessageBox.Show("Successfully deleted file");
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("ERROR: FAILED TO DELETE FILE");
                } //END IF
            } //END IF
        } //END

        //---------------------------------------------------------------------
        //SAVE AS BUTTONS------------------------------------------------------
        //---------------------------------------------------------------------

        private void buttonSaveSaveAs_Click(object sender, EventArgs e)
        {
            //IF SIMULATION SAVED
            //DISPLAY SUCCESS MESSAGE
            //ELSE
            //DISPLAY FAIL MESSAGE
            if (appDirector.saveNewSimulationResultsFile(textBoxSaveNameSaveAs.Text))
            {
                System.Windows.Forms.MessageBox.Show("Successfully saved file");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("ERROR: FAILED TO SAVE FILE");
            } //END IF
        } //END

        //---------------------------------------------------------------------
        //LOAD TABLE-----------------------------------------------------------
        //---------------------------------------------------------------------

        private void dataGridViewLoadsLoad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //IF LOAD
            //LOAD SIMULATION
            //ELSE IF DELETE
            //DELETE SAVE
            if (e.ColumnIndex == 0)
            {
                //OVERWRITE SIMULATION
                appDirector.loadSimulation(dataGridViewLoadsLoad.Rows[e.RowIndex].Cells[1].Value.ToString());

                System.Windows.Forms.MessageBox.Show("Successfully overwrote file");
            }
            else if (e.ColumnIndex == 2)
            {
                //IF DELETE SUCCESS
                //DISPLAY SUCCESS MESSAGE
                //ELSE
                //DISPLAY FAIL MESSAGE
                if (appDirector.deleteSimulationResultsFile(dataGridViewLoadsLoad.Rows[e.RowIndex].Cells[1].Value.ToString()))
                {
                    System.Windows.Forms.MessageBox.Show("Successfully deleted file");
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("ERROR: FAILED TO DELETE FILE");
                } //END IF
            } //END IF
        } //END

        //---------------------------------------------------------------------
        //SIM TO BUTTONS-------------------------------------------------------
        //---------------------------------------------------------------------

        private void buttonSimToEndSimTo_Click(object sender, EventArgs e)
        {
            //IF SIMULATION SUCCESSFUL
            //DISPLAY SUCCESS MESSAGE
            //ELSE
            //DISPLAY FAIL MESSAGE
            if (appDirector.goSimTo(appResources.getPostSeasonStartDate()))
            {
                System.Windows.Forms.MessageBox.Show("Successfully simulated to end");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("ERROR: FAILED TO SIMULATE TO END");
            } //END IF
        } //END

        private void buttonGoSimTo_Click(object sender, EventArgs e)
        {
            //GET DAY MONTH YEAR
            int day = comboBoxDaySimTo.SelectedIndex;
            int month = comboBoxMonthSimTo.SelectedIndex;
            int year = calculateYear(month);

            //SET DATE
            DateTime goToDate = new DateTime(year, month, day, 0, 0, 0, 0);

            //IF SIMULATION SUCCESSFUL
            //DISPLAY SUCCESS MESSAGE
            //ELSE
            //DISPLAY FAIL MESSAGE
            if (appDirector.goSimTo(goToDate))
            {
                System.Windows.Forms.MessageBox.Show("Successfully simulated to " + goToDate.ToString("d"));
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("ERROR: FAILED TO SIMULATE TO " + goToDate.ToString("d"));
            } //END IF
        } //END

        //---------------------------------------------------------------------
        //SIM TO DROP DOWN-----------------------------------------------------
        //---------------------------------------------------------------------

        private void comboBoxMonthSimTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //FILL CORRECT NUMBER OF DAYS IN DROP DOWN
            setSimToAndStartFromDisplayDates(comboBoxMonthSimTo.SelectedIndex);
        } //END

        //---------------------------------------------------------------------
        //START FROM BUTTONS---------------------------------------------------
        //---------------------------------------------------------------------

        private void buttonStartFromBegStartFrom_Click(object sender, EventArgs e)
        {
            //IF SIMULATION SUCCESSFUL
            //DISPLAY SUCCESS MESSAGE
            //ELSE
            //DISPLAY FAIL MESSAGE
            if (appDirector.goStartFrom(appResources.getSeasonStartDate()))
            {
                System.Windows.Forms.MessageBox.Show("Successfully simulated to beginning");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("ERROR: FAILED TO SIMULATE TO BEGINNING");
            } //END IF
        } //END

        private void buttonGoStartFrom_Click(object sender, EventArgs e)
        {
            //GET DAY MONTH YEAR
            int day = comboBoxDayStartFrom.SelectedIndex;
            int month = comboBoxMonthStartFrom.SelectedIndex;
            int year = calculateYear(month);

            //SET DATE
            DateTime startFromDate = new DateTime(year, month, day, 0, 0, 0, 0);

            //IF SIMULATION SUCCESSFUL
            //DISPLAY SUCCESS MESSAGE
            //ELSE
            //DISPLAY FAIL MESSAGE
            if (appDirector.goStartFrom(startFromDate))
            {
                System.Windows.Forms.MessageBox.Show("Successfully simulated to " + startFromDate.ToString("d"));
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("ERROR: FAILED TO SIMULATE TO " + startFromDate.ToString("d"));
            } //END IF
        } //END

        //---------------------------------------------------------------------
        //START FROM DROP DOWN-------------------------------------------------
        //---------------------------------------------------------------------

        private void comboBoxMonthStartFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            //FILL CORRECT NUMBER OF DAYS IN DROP DOWN
            setSimToAndStartFromDisplayDates(comboBoxMonthStartFrom.SelectedIndex);
        } //END

        //---------------------------------------------------------------------
        //SCHEDULE FINDER BUTTON-----------------------------------------------
        //---------------------------------------------------------------------

        private void buttonFilterSchedFind_Click(object sender, EventArgs e)
        {
            //IF USER SELECTED A CONFERENCE OR ALL TEAMS
            //ELSE USER HAS NOT MADE A SELECTION
            if (comboBoxConfSchedFind.SelectedIndex > 0)
            {
                //LOAD SCHEDULE FIND
                goTo(appResources.getMenuText(8), comboBoxConfSchedFind.SelectedIndex);
            } //END IF

        } //END

        //---------------------------------------------------------------------
        //SCHEDULE FINDER TABLES-----------------------------------------------
        //---------------------------------------------------------------------

        private void dataGridViewTeamsSchedFind_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //GET TEAM NAME
            string teamName = dataGridViewTeamsSchedFind.Rows[e.RowIndex].Cells[0].Value.ToString();

            //GET TEAM INDEX
            int teamIndex = appResources.getTeamIndexFromTeamName(teamName);

            //LOAD TEAM SCHEDULE
            goTo(appResources.getMenuText(9), teamIndex);
        } //END

        private void dataGridViewDatesSchedFind_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //LOAD DATE SCHEDULE
            goTo(appResources.getMenuText(10), e.RowIndex);
        } //END

        //---------------------------------------------------------------------
        //TEAM SCHEDULE TABLE--------------------------------------------------
        //---------------------------------------------------------------------

        private void dataGridViewTeamSchedTeamSched_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //IF TEAM 
            //GO TO TEAM SCHEDULE
            //ELSE IF CONFERENCE
            //GOTO CONFERENCE
            if (e.ColumnIndex == 0)
            {
                string teamName = dataGridViewTeamSchedTeamSched.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                int teamIndex = appResources.getTeamIndexFromTeamName(teamName);

                if (teamIndex >= 0)
                {
                    goTo(appResources.getMenuText(9), teamIndex); 
                }//END IF
            }
            else if (e.ColumnIndex == 1)
            {
                string conferenceName = dataGridViewTeamSchedTeamSched.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                int confIndex = appResources.getConferenceIndex(conferenceName);

                if (confIndex >= 0)
                {
                    goTo(appResources.getMenuText(11), confIndex); 
                }//END IF
            } //END IF
        } //END

        //---------------------------------------------------------------------
        //DATE SCHEDULE TABLE--------------------------------------------------
        //---------------------------------------------------------------------

        private void dataGridViewDateSchedDateSched_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //IF TEAM 
            //GO TO TEAM SCHEDULE
            //ELSE IF CONFERENCE
            //GOTO CONFERENCE
            if (e.ColumnIndex == 1 || e.ColumnIndex == 4)
            {
                string teamName = dataGridViewDateSchedDateSched.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                int teamIndex = appResources.getTeamIndexFromTeamName(teamName);

                if (teamIndex >= 0)
                {
                    goTo(appResources.getMenuText(9), teamIndex);
                }//END IF
            }
            else if (e.ColumnIndex == 0 || e.ColumnIndex == 5)
            {
                string conferenceName = dataGridViewDateSchedDateSched.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                int confIndex = appResources.getConferenceIndex(conferenceName);

                if (confIndex >= 0)
                {
                    goTo(appResources.getMenuText(11), confIndex);
                }//END IF
            } //END IF
        } //END

        //---------------------------------------------------------------------
        //STANDINGS TABLES-----------------------------------------------------
        //---------------------------------------------------------------------

        private void dataGridViewConference1Stand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //GO TO TEAM
            
            //IF TEAM SELECTED
            //GO TO TEAM SCHEDULE
            if (e.ColumnIndex == 0)
            {
                string teamName = dataGridViewConference1Stand.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                goTo(appResources.getMenuText(9), appResources.getTeamIndexFromTeamName(teamName));
            } //END IF
        } //END

        private void dataGridViewConference2Stand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //GO TO TEAM

            //IF TEAM SELECTED
            //GO TO TEAM SCHEDULE
            if (e.ColumnIndex == 0)
            {
                string teamName = dataGridViewConference2Stand.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                goTo(appResources.getMenuText(9), appResources.getTeamIndexFromTeamName(teamName));
            } //END IF
        } //END

        private void dataGridViewConference3Stand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //GO TO TEAM

            //IF TEAM SELECTED
            //GO TO TEAM SCHEDULE
            if (e.ColumnIndex == 0)
            {
                string teamName = dataGridViewConference3Stand.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                goTo(appResources.getMenuText(9), appResources.getTeamIndexFromTeamName(teamName));
            } //END IF
        } //END

        private void dataGridViewConference4Stand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //GO TO TEAM

            //IF TEAM SELECTED
            //GO TO TEAM SCHEDULE
            if (e.ColumnIndex == 0)
            {
                string teamName = dataGridViewConference4Stand.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                goTo(appResources.getMenuText(9), appResources.getTeamIndexFromTeamName(teamName));
            } //END IF
        } //END

        private void dataGridViewConference5Stand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //GO TO TEAM

            //IF TEAM SELECTED
            //GO TO TEAM SCHEDULE
            if (e.ColumnIndex == 0)
            {
                string teamName = dataGridViewConference5Stand.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                goTo(appResources.getMenuText(9), appResources.getTeamIndexFromTeamName(teamName));
            } //END IF
        } //END

        private void dataGridViewConference6Stand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //GO TO TEAM

            //IF TEAM SELECTED
            //GO TO TEAM SCHEDULE
            if (e.ColumnIndex == 0)
            {
                string teamName = dataGridViewConference6Stand.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                goTo(appResources.getMenuText(9), appResources.getTeamIndexFromTeamName(teamName));
            } //END IF
        } //END

        private void dataGridViewConference7Stand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //GO TO TEAM

            //IF TEAM SELECTED
            //GO TO TEAM SCHEDULE
            if (e.ColumnIndex == 0)
            {
                string teamName = dataGridViewConference7Stand.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                goTo(appResources.getMenuText(9), appResources.getTeamIndexFromTeamName(teamName));
            } //END IF
        } //END

        private void dataGridViewConference8Stand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //GO TO TEAM

            //IF TEAM SELECTED
            //GO TO TEAM SCHEDULE
            if (e.ColumnIndex == 0)
            {
                string teamName = dataGridViewConference8Stand.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                goTo(appResources.getMenuText(9), appResources.getTeamIndexFromTeamName(teamName));
            } //END IF
        } //END

        private void dataGridViewConference9Stand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //GO TO TEAM

            //IF TEAM SELECTED
            //GO TO TEAM SCHEDULE
            if (e.ColumnIndex == 0)
            {
                string teamName = dataGridViewConference9Stand.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                goTo(appResources.getMenuText(9), appResources.getTeamIndexFromTeamName(teamName));
            } //END IF
        } //END

        private void dataGridViewConference10Stand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //GO TO TEAM

            //IF TEAM SELECTED
            //GO TO TEAM SCHEDULE
            if (e.ColumnIndex == 0)
            {
                string teamName = dataGridViewConference10Stand.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                goTo(appResources.getMenuText(9), appResources.getTeamIndexFromTeamName(teamName));
            } //END IF
        } //END

        private void dataGridViewConference11Stand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //GO TO TEAM

            //IF TEAM SELECTED
            //GO TO TEAM SCHEDULE
            if (e.ColumnIndex == 0)
            {
                string teamName = dataGridViewConference11Stand.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                goTo(appResources.getMenuText(9), appResources.getTeamIndexFromTeamName(teamName));
            } //END IF
        } //END

        private void dataGridViewConference12Stand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //GO TO TEAM

            //IF TEAM SELECTED
            //GO TO TEAM SCHEDULE
            if (e.ColumnIndex == 0)
            {
                string teamName = dataGridViewConference12Stand.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                goTo(appResources.getMenuText(9), appResources.getTeamIndexFromTeamName(teamName));
            } //END IF
        } //END

        private void dataGridViewConference13Stand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //GO TO TEAM

            //IF TEAM SELECTED
            //GO TO TEAM SCHEDULE
            if (e.ColumnIndex == 0)
            {
                string teamName = dataGridViewConference13Stand.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                goTo(appResources.getMenuText(9), appResources.getTeamIndexFromTeamName(teamName));
            } //END IF
        } //END

        private void dataGridViewConference14Stand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //GO TO TEAM

            //IF TEAM SELECTED
            //GO TO TEAM SCHEDULE
            if (e.ColumnIndex == 0)
            {
                string teamName = dataGridViewConference14Stand.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                goTo(appResources.getMenuText(9), appResources.getTeamIndexFromTeamName(teamName));
            } //END IF
        } //END

        private void dataGridViewConference15Stand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //GO TO TEAM

            //IF TEAM SELECTED
            //GO TO TEAM SCHEDULE
            if (e.ColumnIndex == 0)
            {
                string teamName = dataGridViewConference15Stand.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                goTo(appResources.getMenuText(9), appResources.getTeamIndexFromTeamName(teamName));
            } //END IF
        } //END

        private void dataGridViewConference16Stand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //GO TO TEAM

            //IF TEAM SELECTED
            //GO TO TEAM SCHEDULE
            if (e.ColumnIndex == 0)
            {
                string teamName = dataGridViewConference16Stand.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                goTo(appResources.getMenuText(9), appResources.getTeamIndexFromTeamName(teamName));
            } //END IF
        } //END

        private void dataGridViewConference17Stand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //GO TO TEAM

            //IF TEAM SELECTED
            //GO TO TEAM SCHEDULE
            if (e.ColumnIndex == 0)
            {
                string teamName = dataGridViewConference17Stand.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                goTo(appResources.getMenuText(9), appResources.getTeamIndexFromTeamName(teamName));
            } //END IF
        } //END

        private void dataGridViewConference18Stand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //GO TO TEAM

            //IF TEAM SELECTED
            //GO TO TEAM SCHEDULE
            if (e.ColumnIndex == 0)
            {
                string teamName = dataGridViewConference18Stand.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                goTo(appResources.getMenuText(9), appResources.getTeamIndexFromTeamName(teamName));
            } //END IF
        } //END

        private void dataGridViewConference19Stand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //GO TO TEAM

            //IF TEAM SELECTED
            //GO TO TEAM SCHEDULE
            if (e.ColumnIndex == 0)
            {
                string teamName = dataGridViewConference19Stand.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                goTo(appResources.getMenuText(9), appResources.getTeamIndexFromTeamName(teamName));
            } //END IF
        } //END

        private void dataGridViewConference20Stand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //GO TO TEAM

            //IF TEAM SELECTED
            //GO TO TEAM SCHEDULE
            if (e.ColumnIndex == 0)
            {
                string teamName = dataGridViewConference20Stand.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                goTo(appResources.getMenuText(9), appResources.getTeamIndexFromTeamName(teamName));
            } //END IF
        } //END

        private void dataGridViewConference21Stand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //GO TO TEAM

            //IF TEAM SELECTED
            //GO TO TEAM SCHEDULE
            if (e.ColumnIndex == 0)
            {
                string teamName = dataGridViewConference21Stand.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                goTo(appResources.getMenuText(9), appResources.getTeamIndexFromTeamName(teamName));
            } //END IF
        } //END

        private void dataGridViewConference22Stand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //GO TO TEAM

            //IF TEAM SELECTED
            //GO TO TEAM SCHEDULE
            if (e.ColumnIndex == 0)
            {
                string teamName = dataGridViewConference22Stand.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                goTo(appResources.getMenuText(9), appResources.getTeamIndexFromTeamName(teamName));
            } //END IF
        } //END

        private void dataGridViewConference23Stand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //GO TO TEAM

            //IF TEAM SELECTED
            //GO TO TEAM SCHEDULE
            if (e.ColumnIndex == 0)
            {
                string teamName = dataGridViewConference23Stand.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                goTo(appResources.getMenuText(9), appResources.getTeamIndexFromTeamName(teamName));
            } //END IF
        } //END

        private void dataGridViewConference24Stand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //GO TO TEAM

            //IF TEAM SELECTED
            //GO TO TEAM SCHEDULE
            if (e.ColumnIndex == 0)
            {
                string teamName = dataGridViewConference24Stand.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                goTo(appResources.getMenuText(9), appResources.getTeamIndexFromTeamName(teamName));
            } //END IF
        } //END

        private void dataGridViewConference25Stand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //GO TO TEAM

            //IF TEAM SELECTED
            //GO TO TEAM SCHEDULE
            if (e.ColumnIndex == 0)
            {
                string teamName = dataGridViewConference25Stand.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                goTo(appResources.getMenuText(9), appResources.getTeamIndexFromTeamName(teamName));
            } //END IF
        } //END

        private void dataGridViewConference26Stand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //GO TO TEAM

            //IF TEAM SELECTED
            //GO TO TEAM SCHEDULE
            if (e.ColumnIndex == 0)
            {
                string teamName = dataGridViewConference26Stand.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                goTo(appResources.getMenuText(9), appResources.getTeamIndexFromTeamName(teamName));
            } //END IF
        } //END

        private void dataGridViewConference27Stand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //GO TO TEAM

            //IF TEAM SELECTED
            //GO TO TEAM SCHEDULE
            if (e.ColumnIndex == 0)
            {
                string teamName = dataGridViewConference27Stand.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                goTo(appResources.getMenuText(9), appResources.getTeamIndexFromTeamName(teamName));
            } //END IF
        } //END

        private void dataGridViewConference28Stand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //GO TO TEAM

            //IF TEAM SELECTED
            //GO TO TEAM SCHEDULE
            if (e.ColumnIndex == 0)
            {
                string teamName = dataGridViewConference28Stand.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                goTo(appResources.getMenuText(9), appResources.getTeamIndexFromTeamName(teamName));
            } //END IF
        } //END

        private void dataGridViewConference29Stand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //GO TO TEAM

            //IF TEAM SELECTED
            //GO TO TEAM SCHEDULE
            if (e.ColumnIndex == 0)
            {
                string teamName = dataGridViewConference29Stand.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                goTo(appResources.getMenuText(9), appResources.getTeamIndexFromTeamName(teamName));
            } //END IF
        } //END

        private void dataGridViewConference30Stand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //GO TO TEAM

            //IF TEAM SELECTED
            //GO TO TEAM SCHEDULE
            if (e.ColumnIndex == 0)
            {
                string teamName = dataGridViewConference30Stand.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                goTo(appResources.getMenuText(9), appResources.getTeamIndexFromTeamName(teamName));
            } //END IF
        } //END

        private void dataGridViewConference31Stand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //GO TO TEAM

            //IF TEAM SELECTED
            //GO TO TEAM SCHEDULE
            if (e.ColumnIndex == 0)
            {
                string teamName = dataGridViewConference31Stand.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                goTo(appResources.getMenuText(9), appResources.getTeamIndexFromTeamName(teamName));
            } //END IF
        } //END

        private void dataGridViewConference32Stand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //GO TO TEAM

            //IF TEAM SELECTED
            //GO TO TEAM SCHEDULE
            if (e.ColumnIndex == 0)
            {
                string teamName = dataGridViewConference32Stand.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                goTo(appResources.getMenuText(9), appResources.getTeamIndexFromTeamName(teamName));
            } //END IF
        } //END

        //---------------------------------------------------------------------
        //STANDINGS BUTTONS----------------------------------------------------
        //---------------------------------------------------------------------
        
        private void buttonGoStand_Click(object sender, EventArgs e)
        {
            //IF USER SELECTED ITEM IN DROP DOWN
            if (comboBoxConferencesStand.SelectedIndex > -1)
            {
                //LOAD NEW STANDINGS
                goTo(appResources.getMenuText(11), comboBoxConferencesStand.SelectedIndex);
            } //END IF
        } //END

        //---------------------------------------------------------------------
        //TOP 25 TABLE---------------------------------------------------------
        //---------------------------------------------------------------------

        private void dataGridViewTop25Top25_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //IF TEAM 
            //GO TO TEAM SCHEDULE
            //ELSE IF CONFERENCE
            //GOTO CONFERENCE
            if (e.ColumnIndex == 1)
            {
                string teamName = dataGridViewTop25Top25.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                goTo(appResources.getMenuText(9), appResources.getTeamIndexFromTeamName(teamName));
            }
            else if (e.ColumnIndex == 2)
            {
                string conferenceName = dataGridViewTop25Top25.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                goTo(appResources.getMenuText(11), appResources.getConferenceIndex(conferenceName));
            } //END IF
        } //END

        //---------------------------------------------------------------------
        //CHAMPIONSHIP TOURNAMENT PROJECTION LIST TABLE------------------------
        //---------------------------------------------------------------------

        private void dataGridViewChampTournProListTournProList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //IF TEAM 
            //GO TO TEAM SCHEDULE
            //ELSE IF CONFERENCE
            //GOTO CONFERENCE
            if (e.ColumnIndex == 2)
            {
                string teamName = dataGridViewChampTournProListTournProList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                goTo(appResources.getMenuText(9), appResources.getTeamIndexFromTeamName(teamName));
            }
            else if (e.ColumnIndex == 3)
            {
                string conferenceName = dataGridViewChampTournProListTournProList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                goTo(appResources.getMenuText(11), appResources.getConferenceIndex(conferenceName));
            } //END IF
        } //END

        //---------------------------------------------------------------------
        //CHAMPIONSHIP TOURNAMENT PROJECTION LIST BUTTON-----------------------
        //---------------------------------------------------------------------

        private void buttonBracketTournProList_Click(object sender, EventArgs e)
        {
            // 14 TournProBrac 
            goTo(appResources.getMenuText(14));
        } //END

        //---------------------------------------------------------------------
        //CHAMPIONSHIP TOURNAMENT PROJECTION BRACKET BUTTONS-------------------
        //---------------------------------------------------------------------

        private void buttonListViewTournProBrac_Click(object sender, EventArgs e)
        {
            goTo(appResources.getMenuText(13));
        } //END

        private void buttonWestTournProBrac_Click(object sender, EventArgs e)
        {
            goTo(appResources.getMenuText(14), 2);
        } //END

        private void buttonMidwestTournProBrac_Click(object sender, EventArgs e)
        {
            goTo(appResources.getMenuText(14), 3);
        } //END

        private void buttonEastTournProBrac_Click(object sender, EventArgs e)
        {
            goTo(appResources.getMenuText(14), 4);
        } //END

        private void buttonSouthTournProBrac_Click(object sender, EventArgs e)
        {
            goTo(appResources.getMenuText(14), 5);
        } //END

        private void buttonSweet16TournProBrac_Click(object sender, EventArgs e)
        {
            goTo(appResources.getMenuText(14), 1);
        } //END

        private void buttonFullBracketTournProBrac_Click(object sender, EventArgs e)
        {
            goTo(appResources.getMenuText(14), 0);
        } //END

        //---------------------------------------------------------------------
        //CONFERENCE TOURNAMENT BRACKET BUTTON---------------------------------
        //---------------------------------------------------------------------

        private void buttonGoConfTournBrac_Click(object sender, EventArgs e)
        {
            // 15 ConTournBrac
            //(in selected index zero is not whole simulationDirector)
            goTo(appResources.getMenuText(15), comboBoxConferencesConfTournBrac.SelectedIndex);
        } //END

        //---------------------------------------------------------------------
        //CONFERENCE TOURNAMENT FINDER TABLE-----------------------------------
        //---------------------------------------------------------------------

        private void dataGridViewConferencesConfTournFind_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 15 ConTournBrac
            //(in selected index zero is not whole simulationDirector)
            goTo(appResources.getMenuText(15), e.RowIndex);
        } //END

        //---------------------------------------------------------------------
        //CHAMPIONSHIP TOURNAMENT LIST TABLE-----------------------------------
        //---------------------------------------------------------------------

        private void dataGridViewChampTournListTournList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //IF TEAM 
            //GO TO TEAM SCHEDULE
            //ELSE IF CONFERENCE
            //GOTO CONFERENCE
            if (e.ColumnIndex == 2)
            {
                string teamName = dataGridViewChampTournListTournList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                goTo(appResources.getMenuText(9), appResources.getTeamIndexFromTeamName(teamName));
            }
            else if (e.ColumnIndex == 3)
            {
                string conferenceName = dataGridViewChampTournListTournList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                goTo(appResources.getMenuText(11), appResources.getConferenceIndex(conferenceName));
            } //END IF
        } //END

        //---------------------------------------------------------------------
        //CHAMPIONSHIP TOURNAMENT LIST BUTTON----------------------------------
        //---------------------------------------------------------------------

        private void buttonBracketTournList_Click(object sender, EventArgs e)
        {
            // 18 TournBrac
            goTo(appResources.getMenuText(18));
        } //END

        //---------------------------------------------------------------------
        //CHAMPIONSHIP TOURNAMENT BRACKET BUTTONS------------------------------
        //---------------------------------------------------------------------

        private void buttonListViewTournBrac_Click(object sender, EventArgs e)
        {
            goTo(appResources.getMenuText(17));
        } //END

        private void buttonWestTournBrac_Click(object sender, EventArgs e)
        {
            goTo(appResources.getMenuText(18), 2);
        } //END

        private void buttonMidwestTournBrac_Click(object sender, EventArgs e)
        {
            goTo(appResources.getMenuText(18), 3);
        } //END

        private void buttonEastTournBrac_Click(object sender, EventArgs e)
        {
            goTo(appResources.getMenuText(18), 4);
        } //END

        private void buttonSouthTournBrac_Click(object sender, EventArgs e)
        {
            goTo(appResources.getMenuText(18), 5);
        } //END

        private void buttonSweet16TournBrac_Click(object sender, EventArgs e)
        {
            goTo(appResources.getMenuText(18), 1);
        } //END

        private void buttonFullBracketTournBrac_Click(object sender, EventArgs e)
        {
            goTo(appResources.getMenuText(18), 0);
        } //END

        //---------------------------------------------------------------------
        //---------------------------------------------------------------------
        //DROP DOWNS-----------------------------------------------------------
        //---------------------------------------------------------------------
        //---------------------------------------------------------------------

        private void setSimToAndStartFromDisplayDates(int month)
        {
            //LOCAL DATE VARIABLES
            int daysInMonth = 31;
            int year = calculateYear(month);

            //SET YEAR LABELS
            labelYear20SimTo.Text = year.ToString();
            labelYear20StartFrom.Text = year.ToString();

            //FIND DAYS IN MONTH
            daysInMonth = DateTime.DaysInMonth(year, month);

            //CLEAR DROP DOWNS
            comboBoxDaySimTo.Items.Clear();
            comboBoxDayStartFrom.Items.Clear();

            //FOR ALL THE DAYS IN THE MONTH
            //ADD DAYS TO DROP DOWN
            for (int daysIndex = 0; daysIndex < daysInMonth; daysIndex++)
            {
                comboBoxDaySimTo.Items.Add(daysIndex + 1);
                comboBoxDayStartFrom.Items.Add(daysIndex + 1);
            }// END FOR

        } //END

        private int calculateYear(int month)
        {
            //IF MONTH AT BEGINING OF SEASON
            //SET YEAR TO 2019
            //ELSE SET YEAR TO 2020
            if (month > 5)
            {
                return 2019;
            }
            else
            {
                return 2020;
            }//END IF
        } //END

        //---------------------------------------------------------------------
        //---------------------------------------------------------------------
        //ON CLOSE-------------------------------------------------------------
        //---------------------------------------------------------------------
        //---------------------------------------------------------------------

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //EXIT APP
            Application.Exit();
        } //END

    } //END
} //END
