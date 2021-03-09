namespace College_Basketball_Simulator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2213:DisposableFieldsShouldBeDisposed", MessageId = "appDirector")]
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                //DisposeDirector() CALLS Dispose()
                appDirector.DisposeDirector();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMainMenuIntro = new System.Windows.Forms.Panel();
            this.tableLayoutPanelAMainInt = new System.Windows.Forms.TableLayoutPanel();
            this.buttonImportDataMainInt = new System.Windows.Forms.Button();
            this.buttonSettingsMainInt = new System.Windows.Forms.Button();
            this.tableLayoutPanelHeaderMainInt = new System.Windows.Forms.TableLayoutPanel();
            this.labelMainMenuMainInt = new System.Windows.Forms.Label();
            this.buttonBackMainIntro = new System.Windows.Forms.Button();
            this.panelMainMenu = new System.Windows.Forms.Panel();
            this.tableLayoutPanelAMain = new System.Windows.Forms.TableLayoutPanel();
            this.buttonImportDataMain = new System.Windows.Forms.Button();
            this.buttonSettingsMain = new System.Windows.Forms.Button();
            this.buttonSimulateMain = new System.Windows.Forms.Button();
            this.buttonRestartDateMain = new System.Windows.Forms.Button();
            this.tableLayoutPanelHeaderMain = new System.Windows.Forms.TableLayoutPanel();
            this.buttonBackMain = new System.Windows.Forms.Button();
            this.labelMainMenuMain = new System.Windows.Forms.Label();
            this.labelCurrentDayMain = new System.Windows.Forms.Label();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.tableLayoutPanelBSet = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxSaveFoldLocationSet = new System.Windows.Forms.TextBox();
            this.labelSimTypeSet = new System.Windows.Forms.Label();
            this.labelSaveLocationSet = new System.Windows.Forms.Label();
            this.comboBoxSimTypeSet = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanelASet = new System.Windows.Forms.TableLayoutPanel();
            this.labelDistributionRangeSet = new System.Windows.Forms.Label();
            this.labelToSet = new System.Windows.Forms.Label();
            this.textBoxMinScoreRangeSet = new System.Windows.Forms.TextBox();
            this.labelMinAndMaxSet = new System.Windows.Forms.Label();
            this.textBoxMaxScoreRangeSet = new System.Windows.Forms.TextBox();
            this.textBoxScoreDistRangeSet = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelCSet = new System.Windows.Forms.TableLayoutPanel();
            this.buttonCancelSet = new System.Windows.Forms.Button();
            this.buttonSaveSettingsSet = new System.Windows.Forms.Button();
            this.tableLayoutPanelHeaderSet = new System.Windows.Forms.TableLayoutPanel();
            this.labelSettingsSet = new System.Windows.Forms.Label();
            this.buttonBackSet = new System.Windows.Forms.Button();
            this.panelSaveFold = new System.Windows.Forms.Panel();
            this.tableLayoutPanelASaveFold = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxSaveFoldLocationSaveFold = new System.Windows.Forms.TextBox();
            this.labelSaveLocationSaveFold = new System.Windows.Forms.Label();
            this.tableLayoutPanelBSaveFold = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSaveSettingsSaveFold = new System.Windows.Forms.Button();
            this.tableLayoutPanelHeaderSaveFold = new System.Windows.Forms.TableLayoutPanel();
            this.labelSaveFolderSettingsSaveFold = new System.Windows.Forms.Label();
            this.panelSaveAs = new System.Windows.Forms.Panel();
            this.tableLayoutPanelASaveAs = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSaveSaveAs = new System.Windows.Forms.Button();
            this.textBoxSaveNameSaveAs = new System.Windows.Forms.TextBox();
            this.labelSaveNameSaveAs = new System.Windows.Forms.Label();
            this.tableLayoutPanelBSaveAs = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewSavesSaveAs = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanelHeaderSaveAs = new System.Windows.Forms.TableLayoutPanel();
            this.labelSaveAsSaveAs = new System.Windows.Forms.Label();
            this.buttonBackSaveAs = new System.Windows.Forms.Button();
            this.panelLoad = new System.Windows.Forms.Panel();
            this.tableLayoutPanelALoad = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewLoadsLoad = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanelHeaderLoad = new System.Windows.Forms.TableLayoutPanel();
            this.labelLoadLoad = new System.Windows.Forms.Label();
            this.buttonBackLoad = new System.Windows.Forms.Button();
            this.panelSimTo = new System.Windows.Forms.Panel();
            this.tableLayoutPanelBSimTo = new System.Windows.Forms.TableLayoutPanel();
            this.labelDaySimTo = new System.Windows.Forms.Label();
            this.labelMonthSimTo = new System.Windows.Forms.Label();
            this.comboBoxMonthSimTo = new System.Windows.Forms.ComboBox();
            this.labelYearSimTo = new System.Windows.Forms.Label();
            this.labelYear20SimTo = new System.Windows.Forms.Label();
            this.buttonGoSimTo = new System.Windows.Forms.Button();
            this.comboBoxDaySimTo = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanelASimTo = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSimToEndSimTo = new System.Windows.Forms.Button();
            this.tableLayoutPanelHeaderSimTo = new System.Windows.Forms.TableLayoutPanel();
            this.labelSimToSimTo = new System.Windows.Forms.Label();
            this.buttonBackSimTo = new System.Windows.Forms.Button();
            this.labelCurrentDaySimTo = new System.Windows.Forms.Label();
            this.panelStartFrom = new System.Windows.Forms.Panel();
            this.tableLayoutPanelBStartFrom = new System.Windows.Forms.TableLayoutPanel();
            this.labelDayStartFrom = new System.Windows.Forms.Label();
            this.labelMonthStartFrom = new System.Windows.Forms.Label();
            this.comboBoxMonthStartFrom = new System.Windows.Forms.ComboBox();
            this.labelYearStartFrom = new System.Windows.Forms.Label();
            this.labelYear20StartFrom = new System.Windows.Forms.Label();
            this.buttonGoStartFrom = new System.Windows.Forms.Button();
            this.comboBoxDayStartFrom = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanelAStartFrom = new System.Windows.Forms.TableLayoutPanel();
            this.buttonStartFromBegStartFrom = new System.Windows.Forms.Button();
            this.tableLayoutPanelHeaderStartFrom = new System.Windows.Forms.TableLayoutPanel();
            this.labelStartFromPrevStartFrom = new System.Windows.Forms.Label();
            this.buttonBackStartFrom = new System.Windows.Forms.Button();
            this.labelCurrentDayStartFrom = new System.Windows.Forms.Label();
            this.panelSchedFind = new System.Windows.Forms.Panel();
            this.tableLayoutPanelASchedFind = new System.Windows.Forms.TableLayoutPanel();
            this.buttonFilterSchedFind = new System.Windows.Forms.Button();
            this.labelFilterConfSchedFind = new System.Windows.Forms.Label();
            this.comboBoxConfSchedFind = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanelBSchedFind = new System.Windows.Forms.TableLayoutPanel();
            this.labelSelectTeamSchedFind = new System.Windows.Forms.Label();
            this.labelSelectDateSchedFind = new System.Windows.Forms.Label();
            this.dataGridViewTeamsSchedFind = new System.Windows.Forms.DataGridView();
            this.dataGridViewDatesSchedFind = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanelHeaderSchedFind = new System.Windows.Forms.TableLayoutPanel();
            this.labelScheduleSchedFind = new System.Windows.Forms.Label();
            this.buttonBackSchedFind = new System.Windows.Forms.Button();
            this.labelCurrentDaySchedFind = new System.Windows.Forms.Label();
            this.panelTeamSched = new System.Windows.Forms.Panel();
            this.tableLayoutPanelATeamSched = new System.Windows.Forms.TableLayoutPanel();
            this.labelRecordTeamSched = new System.Windows.Forms.Label();
            this.labelConfRecordTeamSched = new System.Windows.Forms.Label();
            this.labelRecWinsTeamSched = new System.Windows.Forms.Label();
            this.labelRecLossesTeamSched = new System.Windows.Forms.Label();
            this.labelConfRecWinsTeamSched = new System.Windows.Forms.Label();
            this.labelConfRecLossesTeamSched = new System.Windows.Forms.Label();
            this.labelRecDashTeamSched = new System.Windows.Forms.Label();
            this.labelConfRecDashTeamSched = new System.Windows.Forms.Label();
            this.tableLayoutPanelBTeamSched = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewTeamSchedTeamSched = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanelHeaderTeamSched = new System.Windows.Forms.TableLayoutPanel();
            this.labelTeamSchedTeamSched = new System.Windows.Forms.Label();
            this.buttonBackTeamSched = new System.Windows.Forms.Button();
            this.labelCurrentDayTeamSched = new System.Windows.Forms.Label();
            this.panelDateSched = new System.Windows.Forms.Panel();
            this.tableLayoutPanelADateSched = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewDateSchedDateSched = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanelHeaderDateSched = new System.Windows.Forms.TableLayoutPanel();
            this.labelDateSchedDateSched = new System.Windows.Forms.Label();
            this.buttonBackDateSched = new System.Windows.Forms.Button();
            this.labelCurrentDayDateSched = new System.Windows.Forms.Label();
            this.panelStand = new System.Windows.Forms.Panel();
            this.tableLayoutPanelAStand = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxConferencesStand = new System.Windows.Forms.ComboBox();
            this.labelGoToConferenceStand = new System.Windows.Forms.Label();
            this.buttonGoStand = new System.Windows.Forms.Button();
            this.tableLayoutPanelBStand = new System.Windows.Forms.TableLayoutPanel();
            this.labelConference1Stand = new System.Windows.Forms.Label();
            this.dataGridViewConference1Stand = new System.Windows.Forms.DataGridView();
            this.labelConference2Stand = new System.Windows.Forms.Label();
            this.dataGridViewConference2Stand = new System.Windows.Forms.DataGridView();
            this.labelConference3Stand = new System.Windows.Forms.Label();
            this.dataGridViewConference3Stand = new System.Windows.Forms.DataGridView();
            this.labelConference4Stand = new System.Windows.Forms.Label();
            this.dataGridViewConference4Stand = new System.Windows.Forms.DataGridView();
            this.labelConference5Stand = new System.Windows.Forms.Label();
            this.dataGridViewConference5Stand = new System.Windows.Forms.DataGridView();
            this.labelConference6Stand = new System.Windows.Forms.Label();
            this.dataGridViewConference6Stand = new System.Windows.Forms.DataGridView();
            this.labelConference7Stand = new System.Windows.Forms.Label();
            this.dataGridViewConference7Stand = new System.Windows.Forms.DataGridView();
            this.labelConference8Stand = new System.Windows.Forms.Label();
            this.dataGridViewConference8Stand = new System.Windows.Forms.DataGridView();
            this.labelConference9Stand = new System.Windows.Forms.Label();
            this.dataGridViewConference9Stand = new System.Windows.Forms.DataGridView();
            this.labelConference10Stand = new System.Windows.Forms.Label();
            this.dataGridViewConference10Stand = new System.Windows.Forms.DataGridView();
            this.labelConference11Stand = new System.Windows.Forms.Label();
            this.dataGridViewConference11Stand = new System.Windows.Forms.DataGridView();
            this.labelConference12Stand = new System.Windows.Forms.Label();
            this.dataGridViewConference12Stand = new System.Windows.Forms.DataGridView();
            this.labelConference13Stand = new System.Windows.Forms.Label();
            this.dataGridViewConference13Stand = new System.Windows.Forms.DataGridView();
            this.labelConference14Stand = new System.Windows.Forms.Label();
            this.dataGridViewConference14Stand = new System.Windows.Forms.DataGridView();
            this.labelConference15Stand = new System.Windows.Forms.Label();
            this.dataGridViewConference15Stand = new System.Windows.Forms.DataGridView();
            this.labelConference16Stand = new System.Windows.Forms.Label();
            this.dataGridViewConference16Stand = new System.Windows.Forms.DataGridView();
            this.labelConference17Stand = new System.Windows.Forms.Label();
            this.dataGridViewConference17Stand = new System.Windows.Forms.DataGridView();
            this.labelConference18Stand = new System.Windows.Forms.Label();
            this.dataGridViewConference18Stand = new System.Windows.Forms.DataGridView();
            this.labelConference19Stand = new System.Windows.Forms.Label();
            this.dataGridViewConference19Stand = new System.Windows.Forms.DataGridView();
            this.labelConference20Stand = new System.Windows.Forms.Label();
            this.dataGridViewConference20Stand = new System.Windows.Forms.DataGridView();
            this.labelConference21Stand = new System.Windows.Forms.Label();
            this.dataGridViewConference21Stand = new System.Windows.Forms.DataGridView();
            this.labelConference22Stand = new System.Windows.Forms.Label();
            this.dataGridViewConference22Stand = new System.Windows.Forms.DataGridView();
            this.labelConference23Stand = new System.Windows.Forms.Label();
            this.dataGridViewConference23Stand = new System.Windows.Forms.DataGridView();
            this.labelConference24Stand = new System.Windows.Forms.Label();
            this.dataGridViewConference24Stand = new System.Windows.Forms.DataGridView();
            this.labelConference25Stand = new System.Windows.Forms.Label();
            this.dataGridViewConference25Stand = new System.Windows.Forms.DataGridView();
            this.labelConference26Stand = new System.Windows.Forms.Label();
            this.dataGridViewConference26Stand = new System.Windows.Forms.DataGridView();
            this.labelConference27Stand = new System.Windows.Forms.Label();
            this.dataGridViewConference27Stand = new System.Windows.Forms.DataGridView();
            this.labelConference28Stand = new System.Windows.Forms.Label();
            this.dataGridViewConference28Stand = new System.Windows.Forms.DataGridView();
            this.labelConference29Stand = new System.Windows.Forms.Label();
            this.dataGridViewConference29Stand = new System.Windows.Forms.DataGridView();
            this.labelConference30Stand = new System.Windows.Forms.Label();
            this.dataGridViewConference30Stand = new System.Windows.Forms.DataGridView();
            this.labelConference31Stand = new System.Windows.Forms.Label();
            this.dataGridViewConference31Stand = new System.Windows.Forms.DataGridView();
            this.labelConference32Stand = new System.Windows.Forms.Label();
            this.dataGridViewConference32Stand = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanelHeaderStand = new System.Windows.Forms.TableLayoutPanel();
            this.labelStandingsStand = new System.Windows.Forms.Label();
            this.buttonBackStand = new System.Windows.Forms.Button();
            this.labelCurrentDayStand = new System.Windows.Forms.Label();
            this.panelTop25 = new System.Windows.Forms.Panel();
            this.tableLayoutPanelATop25 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewTop25Top25 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanelHeaderTop25 = new System.Windows.Forms.TableLayoutPanel();
            this.labelTop25Top25 = new System.Windows.Forms.Label();
            this.buttonBackTop25 = new System.Windows.Forms.Button();
            this.labelCurrentDayTop25 = new System.Windows.Forms.Label();
            this.panelTournProList = new System.Windows.Forms.Panel();
            this.tableLayoutPanelATournProList = new System.Windows.Forms.TableLayoutPanel();
            this.buttonBracketTournProList = new System.Windows.Forms.Button();
            this.tableLayoutPanelBTournProList = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewChampTournProListTournProList = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanelHeaderTournProList = new System.Windows.Forms.TableLayoutPanel();
            this.labelChampTournProjTournProList = new System.Windows.Forms.Label();
            this.buttonBackTournProList = new System.Windows.Forms.Button();
            this.labelCurrentDayTournProList = new System.Windows.Forms.Label();
            this.panelTournList = new System.Windows.Forms.Panel();
            this.tableLayoutPanelATournList = new System.Windows.Forms.TableLayoutPanel();
            this.buttonBracketTournList = new System.Windows.Forms.Button();
            this.tableLayoutPanelBTournList = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewChampTournListTournList = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanelHeaderTournList = new System.Windows.Forms.TableLayoutPanel();
            this.labelChampTournTournList = new System.Windows.Forms.Label();
            this.buttonBackTournList = new System.Windows.Forms.Button();
            this.labelCurrentDayTournList = new System.Windows.Forms.Label();
            this.panelTournProBrac = new System.Windows.Forms.Panel();
            this.tableLayoutPanelATournProBrac = new System.Windows.Forms.TableLayoutPanel();
            this.buttonWestTournProBrac = new System.Windows.Forms.Button();
            this.buttonMidwestTournProBrac = new System.Windows.Forms.Button();
            this.buttonEastTournProBrac = new System.Windows.Forms.Button();
            this.buttonSouthTournProBrac = new System.Windows.Forms.Button();
            this.buttonFullBracketTournProBrac = new System.Windows.Forms.Button();
            this.buttonListViewTournProBrac = new System.Windows.Forms.Button();
            this.buttonSweet16TournProBrac = new System.Windows.Forms.Button();
            this.tableLayoutPanelBTournProBrac = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxChampTournProBracTournProBrac = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelHeaderTournProBrac = new System.Windows.Forms.TableLayoutPanel();
            this.labelChampTournProTournProBrac = new System.Windows.Forms.Label();
            this.buttonBackTournProBrac = new System.Windows.Forms.Button();
            this.labelCurrentDayTournProBrac = new System.Windows.Forms.Label();
            this.panelTournBrac = new System.Windows.Forms.Panel();
            this.tableLayoutPanelATournBrac = new System.Windows.Forms.TableLayoutPanel();
            this.buttonWestTournBrac = new System.Windows.Forms.Button();
            this.buttonMidwestTournBrac = new System.Windows.Forms.Button();
            this.buttonEastTournBrac = new System.Windows.Forms.Button();
            this.buttonSouthTournBrac = new System.Windows.Forms.Button();
            this.buttonFullBracketTournBrac = new System.Windows.Forms.Button();
            this.buttonListViewTournBrac = new System.Windows.Forms.Button();
            this.buttonSweet16TournBrac = new System.Windows.Forms.Button();
            this.tableLayoutPanelBTournBrac = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxChampTournBracTournBrac = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelHeaderTournBrac = new System.Windows.Forms.TableLayoutPanel();
            this.labelChampTournTournBrac = new System.Windows.Forms.Label();
            this.buttonBackTournBrac = new System.Windows.Forms.Button();
            this.labelCurrentDayTournBrac = new System.Windows.Forms.Label();
            this.panelConfTournFind = new System.Windows.Forms.Panel();
            this.tableLayoutPanelAConfTournFind = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewConferencesConfTournFind = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanelHeaderConfTournFind = new System.Windows.Forms.TableLayoutPanel();
            this.labelConfTournConfTournFind = new System.Windows.Forms.Label();
            this.buttonBackConfTournFind = new System.Windows.Forms.Button();
            this.labelCurrentDayConfTournFind = new System.Windows.Forms.Label();
            this.panelConfTournBrac = new System.Windows.Forms.Panel();
            this.tableLayoutPanelAConfTournBrac = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxConferencesConfTournBrac = new System.Windows.Forms.ComboBox();
            this.labelGoToConfConfTournBrac = new System.Windows.Forms.Label();
            this.buttonGoConfTournBrac = new System.Windows.Forms.Button();
            this.tableLayoutPanelBConfTournBrac = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxConfTournBracConfTournBrac = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelHeaderConfTournBrac = new System.Windows.Forms.TableLayoutPanel();
            this.labelConfTournConfTournBrac = new System.Windows.Forms.Label();
            this.buttonBackConfTournBrac = new System.Windows.Forms.Button();
            this.labelCurrentDayConfTournBrac = new System.Windows.Forms.Label();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.top25ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tournamentProjectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conferenceTournamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.championshipTournamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simulateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startFromPreviousDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panelMainMenuIntro.SuspendLayout();
            this.tableLayoutPanelAMainInt.SuspendLayout();
            this.tableLayoutPanelHeaderMainInt.SuspendLayout();
            this.panelMainMenu.SuspendLayout();
            this.tableLayoutPanelAMain.SuspendLayout();
            this.tableLayoutPanelHeaderMain.SuspendLayout();
            this.panelSettings.SuspendLayout();
            this.tableLayoutPanelBSet.SuspendLayout();
            this.tableLayoutPanelASet.SuspendLayout();
            this.tableLayoutPanelCSet.SuspendLayout();
            this.tableLayoutPanelHeaderSet.SuspendLayout();
            this.panelSaveFold.SuspendLayout();
            this.tableLayoutPanelASaveFold.SuspendLayout();
            this.tableLayoutPanelBSaveFold.SuspendLayout();
            this.tableLayoutPanelHeaderSaveFold.SuspendLayout();
            this.panelSaveAs.SuspendLayout();
            this.tableLayoutPanelASaveAs.SuspendLayout();
            this.tableLayoutPanelBSaveAs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSavesSaveAs)).BeginInit();
            this.tableLayoutPanelHeaderSaveAs.SuspendLayout();
            this.panelLoad.SuspendLayout();
            this.tableLayoutPanelALoad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoadsLoad)).BeginInit();
            this.tableLayoutPanelHeaderLoad.SuspendLayout();
            this.panelSimTo.SuspendLayout();
            this.tableLayoutPanelBSimTo.SuspendLayout();
            this.tableLayoutPanelASimTo.SuspendLayout();
            this.tableLayoutPanelHeaderSimTo.SuspendLayout();
            this.panelStartFrom.SuspendLayout();
            this.tableLayoutPanelBStartFrom.SuspendLayout();
            this.tableLayoutPanelAStartFrom.SuspendLayout();
            this.tableLayoutPanelHeaderStartFrom.SuspendLayout();
            this.panelSchedFind.SuspendLayout();
            this.tableLayoutPanelASchedFind.SuspendLayout();
            this.tableLayoutPanelBSchedFind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeamsSchedFind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatesSchedFind)).BeginInit();
            this.tableLayoutPanelHeaderSchedFind.SuspendLayout();
            this.panelTeamSched.SuspendLayout();
            this.tableLayoutPanelATeamSched.SuspendLayout();
            this.tableLayoutPanelBTeamSched.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeamSchedTeamSched)).BeginInit();
            this.tableLayoutPanelHeaderTeamSched.SuspendLayout();
            this.panelDateSched.SuspendLayout();
            this.tableLayoutPanelADateSched.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDateSchedDateSched)).BeginInit();
            this.tableLayoutPanelHeaderDateSched.SuspendLayout();
            this.panelStand.SuspendLayout();
            this.tableLayoutPanelAStand.SuspendLayout();
            this.tableLayoutPanelBStand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference1Stand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference2Stand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference3Stand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference4Stand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference5Stand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference6Stand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference7Stand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference8Stand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference9Stand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference10Stand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference11Stand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference12Stand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference13Stand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference14Stand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference15Stand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference16Stand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference17Stand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference18Stand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference19Stand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference20Stand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference21Stand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference22Stand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference23Stand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference24Stand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference25Stand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference26Stand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference27Stand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference28Stand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference29Stand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference30Stand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference31Stand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference32Stand)).BeginInit();
            this.tableLayoutPanelHeaderStand.SuspendLayout();
            this.panelTop25.SuspendLayout();
            this.tableLayoutPanelATop25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTop25Top25)).BeginInit();
            this.tableLayoutPanelHeaderTop25.SuspendLayout();
            this.panelTournProList.SuspendLayout();
            this.tableLayoutPanelATournProList.SuspendLayout();
            this.tableLayoutPanelBTournProList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChampTournProListTournProList)).BeginInit();
            this.tableLayoutPanelHeaderTournProList.SuspendLayout();
            this.panelTournList.SuspendLayout();
            this.tableLayoutPanelATournList.SuspendLayout();
            this.tableLayoutPanelBTournList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChampTournListTournList)).BeginInit();
            this.tableLayoutPanelHeaderTournList.SuspendLayout();
            this.panelTournProBrac.SuspendLayout();
            this.tableLayoutPanelATournProBrac.SuspendLayout();
            this.tableLayoutPanelBTournProBrac.SuspendLayout();
            this.tableLayoutPanelHeaderTournProBrac.SuspendLayout();
            this.panelTournBrac.SuspendLayout();
            this.tableLayoutPanelATournBrac.SuspendLayout();
            this.tableLayoutPanelBTournBrac.SuspendLayout();
            this.tableLayoutPanelHeaderTournBrac.SuspendLayout();
            this.panelConfTournFind.SuspendLayout();
            this.tableLayoutPanelAConfTournFind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConferencesConfTournFind)).BeginInit();
            this.tableLayoutPanelHeaderConfTournFind.SuspendLayout();
            this.panelConfTournBrac.SuspendLayout();
            this.tableLayoutPanelAConfTournBrac.SuspendLayout();
            this.tableLayoutPanelBConfTournBrac.SuspendLayout();
            this.tableLayoutPanelHeaderConfTournBrac.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMainMenuIntro
            // 
            this.panelMainMenuIntro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMainMenuIntro.AutoScroll = true;
            this.panelMainMenuIntro.AutoSize = true;
            this.panelMainMenuIntro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelMainMenuIntro.Controls.Add(this.tableLayoutPanelAMainInt);
            this.panelMainMenuIntro.Controls.Add(this.tableLayoutPanelHeaderMainInt);
            this.panelMainMenuIntro.Location = new System.Drawing.Point(0, 3);
            this.panelMainMenuIntro.Margin = new System.Windows.Forms.Padding(0);
            this.panelMainMenuIntro.Name = "panelMainMenuIntro";
            this.panelMainMenuIntro.Size = new System.Drawing.Size(1309, 343);
            this.panelMainMenuIntro.TabIndex = 1;
            // 
            // tableLayoutPanelAMainInt
            // 
            this.tableLayoutPanelAMainInt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelAMainInt.ColumnCount = 5;
            this.tableLayoutPanelAMainInt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAMainInt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanelAMainInt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelAMainInt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanelAMainInt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAMainInt.Controls.Add(this.buttonImportDataMainInt, 1, 0);
            this.tableLayoutPanelAMainInt.Controls.Add(this.buttonSettingsMainInt, 3, 0);
            this.tableLayoutPanelAMainInt.Location = new System.Drawing.Point(3, 240);
            this.tableLayoutPanelAMainInt.Name = "tableLayoutPanelAMainInt";
            this.tableLayoutPanelAMainInt.RowCount = 1;
            this.tableLayoutPanelAMainInt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelAMainInt.Size = new System.Drawing.Size(1303, 100);
            this.tableLayoutPanelAMainInt.TabIndex = 1;
            // 
            // buttonImportDataMainInt
            // 
            this.buttonImportDataMainInt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonImportDataMainInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.buttonImportDataMainInt.Location = new System.Drawing.Point(341, 0);
            this.buttonImportDataMainInt.Margin = new System.Windows.Forms.Padding(0);
            this.buttonImportDataMainInt.Name = "buttonImportDataMainInt";
            this.buttonImportDataMainInt.Size = new System.Drawing.Size(300, 100);
            this.buttonImportDataMainInt.TabIndex = 0;
            this.buttonImportDataMainInt.Text = "Import Data";
            this.buttonImportDataMainInt.UseVisualStyleBackColor = true;
            this.buttonImportDataMainInt.Click += new System.EventHandler(this.buttonImportDataMainInt_Click);
            // 
            // buttonSettingsMainInt
            // 
            this.buttonSettingsMainInt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSettingsMainInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.buttonSettingsMainInt.Location = new System.Drawing.Point(661, 0);
            this.buttonSettingsMainInt.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSettingsMainInt.Name = "buttonSettingsMainInt";
            this.buttonSettingsMainInt.Size = new System.Drawing.Size(300, 100);
            this.buttonSettingsMainInt.TabIndex = 1;
            this.buttonSettingsMainInt.Text = "Settings";
            this.buttonSettingsMainInt.UseVisualStyleBackColor = true;
            this.buttonSettingsMainInt.Click += new System.EventHandler(this.buttonSettingsMainInt_Click);
            // 
            // tableLayoutPanelHeaderMainInt
            // 
            this.tableLayoutPanelHeaderMainInt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelHeaderMainInt.ColumnCount = 5;
            this.tableLayoutPanelHeaderMainInt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelHeaderMainInt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelHeaderMainInt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelHeaderMainInt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelHeaderMainInt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelHeaderMainInt.Controls.Add(this.labelMainMenuMainInt, 1, 0);
            this.tableLayoutPanelHeaderMainInt.Controls.Add(this.buttonBackMainIntro, 3, 0);
            this.tableLayoutPanelHeaderMainInt.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelHeaderMainInt.Name = "tableLayoutPanelHeaderMainInt";
            this.tableLayoutPanelHeaderMainInt.RowCount = 2;
            this.tableLayoutPanelHeaderMainInt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanelHeaderMainInt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanelHeaderMainInt.Size = new System.Drawing.Size(1303, 184);
            this.tableLayoutPanelHeaderMainInt.TabIndex = 0;
            // 
            // labelMainMenuMainInt
            // 
            this.labelMainMenuMainInt.AutoSize = true;
            this.labelMainMenuMainInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.labelMainMenuMainInt.Location = new System.Drawing.Point(23, 0);
            this.labelMainMenuMainInt.Name = "labelMainMenuMainInt";
            this.labelMainMenuMainInt.Size = new System.Drawing.Size(294, 63);
            this.labelMainMenuMainInt.TabIndex = 0;
            this.labelMainMenuMainInt.Text = "Main Menu";
            // 
            // buttonBackMainIntro
            // 
            this.buttonBackMainIntro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBackMainIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.buttonBackMainIntro.Location = new System.Drawing.Point(1083, 20);
            this.buttonBackMainIntro.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBackMainIntro.Name = "buttonBackMainIntro";
            this.buttonBackMainIntro.Size = new System.Drawing.Size(200, 100);
            this.buttonBackMainIntro.TabIndex = 5;
            this.buttonBackMainIntro.Text = "Back";
            this.buttonBackMainIntro.UseVisualStyleBackColor = true;
            this.buttonBackMainIntro.Click += new System.EventHandler(this.buttonBackMainIntro_Click);
            // 
            // panelMainMenu
            // 
            this.panelMainMenu.AutoScroll = true;
            this.panelMainMenu.AutoSize = true;
            this.panelMainMenu.Controls.Add(this.tableLayoutPanelAMain);
            this.panelMainMenu.Controls.Add(this.panelMainMenuIntro);
            this.panelMainMenu.Controls.Add(this.tableLayoutPanelHeaderMain);
            this.panelMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainMenu.Location = new System.Drawing.Point(0, 24);
            this.panelMainMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panelMainMenu.Name = "panelMainMenu";
            this.panelMainMenu.Size = new System.Drawing.Size(1286, 554);
            this.panelMainMenu.TabIndex = 2;
            // 
            // tableLayoutPanelAMain
            // 
            this.tableLayoutPanelAMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelAMain.ColumnCount = 5;
            this.tableLayoutPanelAMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanelAMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelAMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanelAMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAMain.Controls.Add(this.buttonImportDataMain, 1, 0);
            this.tableLayoutPanelAMain.Controls.Add(this.buttonSettingsMain, 3, 0);
            this.tableLayoutPanelAMain.Controls.Add(this.buttonSimulateMain, 1, 2);
            this.tableLayoutPanelAMain.Controls.Add(this.buttonRestartDateMain, 3, 2);
            this.tableLayoutPanelAMain.Location = new System.Drawing.Point(3, 240);
            this.tableLayoutPanelAMain.Name = "tableLayoutPanelAMain";
            this.tableLayoutPanelAMain.RowCount = 3;
            this.tableLayoutPanelAMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelAMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelAMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelAMain.Size = new System.Drawing.Size(1280, 220);
            this.tableLayoutPanelAMain.TabIndex = 1;
            // 
            // buttonImportDataMain
            // 
            this.buttonImportDataMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonImportDataMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.buttonImportDataMain.Location = new System.Drawing.Point(330, 0);
            this.buttonImportDataMain.Margin = new System.Windows.Forms.Padding(0);
            this.buttonImportDataMain.Name = "buttonImportDataMain";
            this.buttonImportDataMain.Size = new System.Drawing.Size(300, 100);
            this.buttonImportDataMain.TabIndex = 0;
            this.buttonImportDataMain.Text = "Import Data";
            this.buttonImportDataMain.UseVisualStyleBackColor = true;
            this.buttonImportDataMain.Click += new System.EventHandler(this.buttonImportDataMain_Click);
            // 
            // buttonSettingsMain
            // 
            this.buttonSettingsMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSettingsMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.buttonSettingsMain.Location = new System.Drawing.Point(650, 0);
            this.buttonSettingsMain.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSettingsMain.Name = "buttonSettingsMain";
            this.buttonSettingsMain.Size = new System.Drawing.Size(300, 100);
            this.buttonSettingsMain.TabIndex = 1;
            this.buttonSettingsMain.Text = "Settings";
            this.buttonSettingsMain.UseVisualStyleBackColor = true;
            this.buttonSettingsMain.Click += new System.EventHandler(this.buttonSettingsMain_Click);
            // 
            // buttonSimulateMain
            // 
            this.buttonSimulateMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSimulateMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.buttonSimulateMain.Location = new System.Drawing.Point(330, 120);
            this.buttonSimulateMain.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSimulateMain.Name = "buttonSimulateMain";
            this.buttonSimulateMain.Size = new System.Drawing.Size(300, 100);
            this.buttonSimulateMain.TabIndex = 2;
            this.buttonSimulateMain.Text = "Simulate";
            this.buttonSimulateMain.UseVisualStyleBackColor = true;
            this.buttonSimulateMain.Click += new System.EventHandler(this.buttonSimulateMain_Click);
            // 
            // buttonRestartDateMain
            // 
            this.buttonRestartDateMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRestartDateMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.buttonRestartDateMain.Location = new System.Drawing.Point(650, 120);
            this.buttonRestartDateMain.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRestartDateMain.Name = "buttonRestartDateMain";
            this.buttonRestartDateMain.Size = new System.Drawing.Size(300, 100);
            this.buttonRestartDateMain.TabIndex = 3;
            this.buttonRestartDateMain.Text = "Restart";
            this.buttonRestartDateMain.UseVisualStyleBackColor = true;
            this.buttonRestartDateMain.Click += new System.EventHandler(this.buttonRestartDateMain_Click);
            // 
            // tableLayoutPanelHeaderMain
            // 
            this.tableLayoutPanelHeaderMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelHeaderMain.ColumnCount = 5;
            this.tableLayoutPanelHeaderMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelHeaderMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelHeaderMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelHeaderMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelHeaderMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelHeaderMain.Controls.Add(this.buttonBackMain, 3, 0);
            this.tableLayoutPanelHeaderMain.Controls.Add(this.labelMainMenuMain, 1, 0);
            this.tableLayoutPanelHeaderMain.Controls.Add(this.labelCurrentDayMain, 1, 1);
            this.tableLayoutPanelHeaderMain.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelHeaderMain.Name = "tableLayoutPanelHeaderMain";
            this.tableLayoutPanelHeaderMain.RowCount = 2;
            this.tableLayoutPanelHeaderMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanelHeaderMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanelHeaderMain.Size = new System.Drawing.Size(1280, 184);
            this.tableLayoutPanelHeaderMain.TabIndex = 0;
            // 
            // buttonBackMain
            // 
            this.buttonBackMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBackMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.buttonBackMain.Location = new System.Drawing.Point(1060, 20);
            this.buttonBackMain.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBackMain.Name = "buttonBackMain";
            this.buttonBackMain.Size = new System.Drawing.Size(200, 100);
            this.buttonBackMain.TabIndex = 4;
            this.buttonBackMain.Text = "Back";
            this.buttonBackMain.UseVisualStyleBackColor = true;
            this.buttonBackMain.Click += new System.EventHandler(this.buttonBackMain_Click);
            // 
            // labelMainMenuMain
            // 
            this.labelMainMenuMain.AutoSize = true;
            this.labelMainMenuMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.labelMainMenuMain.Location = new System.Drawing.Point(23, 0);
            this.labelMainMenuMain.Name = "labelMainMenuMain";
            this.labelMainMenuMain.Size = new System.Drawing.Size(294, 63);
            this.labelMainMenuMain.TabIndex = 0;
            this.labelMainMenuMain.Text = "Main Menu";
            // 
            // labelCurrentDayMain
            // 
            this.labelCurrentDayMain.AutoSize = true;
            this.labelCurrentDayMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelCurrentDayMain.Location = new System.Drawing.Point(23, 120);
            this.labelCurrentDayMain.Name = "labelCurrentDayMain";
            this.labelCurrentDayMain.Size = new System.Drawing.Size(235, 44);
            this.labelCurrentDayMain.TabIndex = 1;
            this.labelCurrentDayMain.Text = "Current Day:";
            // 
            // panelSettings
            // 
            this.panelSettings.AutoScroll = true;
            this.panelSettings.AutoSize = true;
            this.panelSettings.Controls.Add(this.tableLayoutPanelBSet);
            this.panelSettings.Controls.Add(this.tableLayoutPanelASet);
            this.panelSettings.Controls.Add(this.tableLayoutPanelCSet);
            this.panelSettings.Controls.Add(this.tableLayoutPanelHeaderSet);
            this.panelSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSettings.Location = new System.Drawing.Point(0, 24);
            this.panelSettings.Margin = new System.Windows.Forms.Padding(0);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(1286, 554);
            this.panelSettings.TabIndex = 3;
            // 
            // tableLayoutPanelBSet
            // 
            this.tableLayoutPanelBSet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelBSet.ColumnCount = 6;
            this.tableLayoutPanelBSet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBSet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 612F));
            this.tableLayoutPanelBSet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelBSet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tableLayoutPanelBSet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanelBSet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBSet.Controls.Add(this.textBoxSaveFoldLocationSet, 3, 1);
            this.tableLayoutPanelBSet.Controls.Add(this.labelSimTypeSet, 1, 0);
            this.tableLayoutPanelBSet.Controls.Add(this.labelSaveLocationSet, 1, 1);
            this.tableLayoutPanelBSet.Controls.Add(this.comboBoxSimTypeSet, 3, 0);
            this.tableLayoutPanelBSet.Location = new System.Drawing.Point(3, 335);
            this.tableLayoutPanelBSet.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.tableLayoutPanelBSet.Name = "tableLayoutPanelBSet";
            this.tableLayoutPanelBSet.RowCount = 2;
            this.tableLayoutPanelBSet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanelBSet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanelBSet.Size = new System.Drawing.Size(1263, 128);
            this.tableLayoutPanelBSet.TabIndex = 3;
            // 
            // textBoxSaveFoldLocationSet
            // 
            this.textBoxSaveFoldLocationSet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSaveFoldLocationSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.textBoxSaveFoldLocationSet.Location = new System.Drawing.Point(694, 67);
            this.textBoxSaveFoldLocationSet.Name = "textBoxSaveFoldLocationSet";
            this.textBoxSaveFoldLocationSet.Size = new System.Drawing.Size(444, 44);
            this.textBoxSaveFoldLocationSet.TabIndex = 13;
            // 
            // labelSimTypeSet
            // 
            this.labelSimTypeSet.AutoSize = true;
            this.labelSimTypeSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelSimTypeSet.Location = new System.Drawing.Point(62, 0);
            this.labelSimTypeSet.Name = "labelSimTypeSet";
            this.labelSimTypeSet.Size = new System.Drawing.Size(294, 44);
            this.labelSimTypeSet.TabIndex = 9;
            this.labelSimTypeSet.Text = "Simulation Type";
            // 
            // labelSaveLocationSet
            // 
            this.labelSaveLocationSet.AutoSize = true;
            this.labelSaveLocationSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelSaveLocationSet.Location = new System.Drawing.Point(62, 64);
            this.labelSaveLocationSet.Name = "labelSaveLocationSet";
            this.labelSaveLocationSet.Size = new System.Drawing.Size(378, 44);
            this.labelSaveLocationSet.TabIndex = 10;
            this.labelSaveLocationSet.Text = "Save Folder Location";
            // 
            // comboBoxSimTypeSet
            // 
            this.comboBoxSimTypeSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.comboBoxSimTypeSet.FormattingEnabled = true;
            this.comboBoxSimTypeSet.Location = new System.Drawing.Point(694, 3);
            this.comboBoxSimTypeSet.Name = "comboBoxSimTypeSet";
            this.comboBoxSimTypeSet.Size = new System.Drawing.Size(300, 45);
            this.comboBoxSimTypeSet.TabIndex = 14;
            // 
            // tableLayoutPanelASet
            // 
            this.tableLayoutPanelASet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelASet.ColumnCount = 8;
            this.tableLayoutPanelASet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelASet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 612F));
            this.tableLayoutPanelASet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelASet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanelASet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanelASet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanelASet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanelASet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelASet.Controls.Add(this.labelDistributionRangeSet, 1, 1);
            this.tableLayoutPanelASet.Controls.Add(this.labelToSet, 4, 0);
            this.tableLayoutPanelASet.Controls.Add(this.textBoxMinScoreRangeSet, 3, 0);
            this.tableLayoutPanelASet.Controls.Add(this.labelMinAndMaxSet, 1, 0);
            this.tableLayoutPanelASet.Controls.Add(this.textBoxMaxScoreRangeSet, 5, 0);
            this.tableLayoutPanelASet.Controls.Add(this.textBoxScoreDistRangeSet, 3, 1);
            this.tableLayoutPanelASet.Location = new System.Drawing.Point(3, 207);
            this.tableLayoutPanelASet.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.tableLayoutPanelASet.Name = "tableLayoutPanelASet";
            this.tableLayoutPanelASet.RowCount = 2;
            this.tableLayoutPanelASet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanelASet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanelASet.Size = new System.Drawing.Size(1263, 128);
            this.tableLayoutPanelASet.TabIndex = 2;
            // 
            // labelDistributionRangeSet
            // 
            this.labelDistributionRangeSet.AutoSize = true;
            this.labelDistributionRangeSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelDistributionRangeSet.Location = new System.Drawing.Point(62, 64);
            this.labelDistributionRangeSet.Name = "labelDistributionRangeSet";
            this.labelDistributionRangeSet.Size = new System.Drawing.Size(606, 44);
            this.labelDistributionRangeSet.TabIndex = 8;
            this.labelDistributionRangeSet.Text = "Normal Scoring Distribution Range";
            // 
            // labelToSet
            // 
            this.labelToSet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelToSet.AutoSize = true;
            this.labelToSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelToSet.Location = new System.Drawing.Point(844, 0);
            this.labelToSet.Name = "labelToSet";
            this.labelToSet.Size = new System.Drawing.Size(144, 44);
            this.labelToSet.TabIndex = 9;
            this.labelToSet.Text = "To";
            this.labelToSet.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxMinScoreRangeSet
            // 
            this.textBoxMinScoreRangeSet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMinScoreRangeSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.textBoxMinScoreRangeSet.Location = new System.Drawing.Point(694, 3);
            this.textBoxMinScoreRangeSet.Name = "textBoxMinScoreRangeSet";
            this.textBoxMinScoreRangeSet.Size = new System.Drawing.Size(144, 44);
            this.textBoxMinScoreRangeSet.TabIndex = 10;
            // 
            // labelMinAndMaxSet
            // 
            this.labelMinAndMaxSet.AutoSize = true;
            this.labelMinAndMaxSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelMinAndMaxSet.Location = new System.Drawing.Point(62, 0);
            this.labelMinAndMaxSet.Name = "labelMinAndMaxSet";
            this.labelMinAndMaxSet.Size = new System.Drawing.Size(527, 44);
            this.labelMinAndMaxSet.TabIndex = 7;
            this.labelMinAndMaxSet.Text = "Min and Max Scoring Average";
            // 
            // textBoxMaxScoreRangeSet
            // 
            this.textBoxMaxScoreRangeSet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMaxScoreRangeSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.textBoxMaxScoreRangeSet.Location = new System.Drawing.Point(994, 3);
            this.textBoxMaxScoreRangeSet.Name = "textBoxMaxScoreRangeSet";
            this.textBoxMaxScoreRangeSet.Size = new System.Drawing.Size(144, 44);
            this.textBoxMaxScoreRangeSet.TabIndex = 11;
            // 
            // textBoxScoreDistRangeSet
            // 
            this.textBoxScoreDistRangeSet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxScoreDistRangeSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.textBoxScoreDistRangeSet.Location = new System.Drawing.Point(694, 67);
            this.textBoxScoreDistRangeSet.Name = "textBoxScoreDistRangeSet";
            this.textBoxScoreDistRangeSet.Size = new System.Drawing.Size(144, 44);
            this.textBoxScoreDistRangeSet.TabIndex = 12;
            // 
            // tableLayoutPanelCSet
            // 
            this.tableLayoutPanelCSet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelCSet.ColumnCount = 5;
            this.tableLayoutPanelCSet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCSet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanelCSet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelCSet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanelCSet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCSet.Controls.Add(this.buttonCancelSet, 1, 0);
            this.tableLayoutPanelCSet.Controls.Add(this.buttonSaveSettingsSet, 3, 0);
            this.tableLayoutPanelCSet.Location = new System.Drawing.Point(3, 463);
            this.tableLayoutPanelCSet.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tableLayoutPanelCSet.Name = "tableLayoutPanelCSet";
            this.tableLayoutPanelCSet.RowCount = 1;
            this.tableLayoutPanelCSet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelCSet.Size = new System.Drawing.Size(1263, 100);
            this.tableLayoutPanelCSet.TabIndex = 1;
            // 
            // buttonCancelSet
            // 
            this.buttonCancelSet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.buttonCancelSet.Location = new System.Drawing.Point(321, 0);
            this.buttonCancelSet.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCancelSet.Name = "buttonCancelSet";
            this.buttonCancelSet.Size = new System.Drawing.Size(300, 100);
            this.buttonCancelSet.TabIndex = 0;
            this.buttonCancelSet.Text = "Cancel";
            this.buttonCancelSet.UseVisualStyleBackColor = true;
            this.buttonCancelSet.Click += new System.EventHandler(this.buttonCancelSet_Click);
            // 
            // buttonSaveSettingsSet
            // 
            this.buttonSaveSettingsSet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveSettingsSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.buttonSaveSettingsSet.Location = new System.Drawing.Point(641, 0);
            this.buttonSaveSettingsSet.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSaveSettingsSet.Name = "buttonSaveSettingsSet";
            this.buttonSaveSettingsSet.Size = new System.Drawing.Size(300, 100);
            this.buttonSaveSettingsSet.TabIndex = 1;
            this.buttonSaveSettingsSet.Text = "Save Settings";
            this.buttonSaveSettingsSet.UseVisualStyleBackColor = true;
            this.buttonSaveSettingsSet.Click += new System.EventHandler(this.buttonSaveSettingsSet_Click);
            // 
            // tableLayoutPanelHeaderSet
            // 
            this.tableLayoutPanelHeaderSet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelHeaderSet.ColumnCount = 5;
            this.tableLayoutPanelHeaderSet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelHeaderSet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelHeaderSet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelHeaderSet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelHeaderSet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelHeaderSet.Controls.Add(this.labelSettingsSet, 1, 0);
            this.tableLayoutPanelHeaderSet.Controls.Add(this.buttonBackSet, 3, 0);
            this.tableLayoutPanelHeaderSet.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelHeaderSet.Name = "tableLayoutPanelHeaderSet";
            this.tableLayoutPanelHeaderSet.RowCount = 2;
            this.tableLayoutPanelHeaderSet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanelHeaderSet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanelHeaderSet.Size = new System.Drawing.Size(1263, 184);
            this.tableLayoutPanelHeaderSet.TabIndex = 0;
            // 
            // labelSettingsSet
            // 
            this.labelSettingsSet.AutoSize = true;
            this.labelSettingsSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.labelSettingsSet.Location = new System.Drawing.Point(23, 0);
            this.labelSettingsSet.Name = "labelSettingsSet";
            this.labelSettingsSet.Size = new System.Drawing.Size(223, 63);
            this.labelSettingsSet.TabIndex = 0;
            this.labelSettingsSet.Text = "Settings";
            // 
            // buttonBackSet
            // 
            this.buttonBackSet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBackSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.buttonBackSet.Location = new System.Drawing.Point(1043, 20);
            this.buttonBackSet.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBackSet.Name = "buttonBackSet";
            this.buttonBackSet.Size = new System.Drawing.Size(200, 100);
            this.buttonBackSet.TabIndex = 5;
            this.buttonBackSet.Text = "Back";
            this.buttonBackSet.UseVisualStyleBackColor = true;
            this.buttonBackSet.Click += new System.EventHandler(this.buttonBackSet_Click);
            // 
            // panelSaveFold
            // 
            this.panelSaveFold.AutoScroll = true;
            this.panelSaveFold.AutoSize = true;
            this.panelSaveFold.Controls.Add(this.tableLayoutPanelASaveFold);
            this.panelSaveFold.Controls.Add(this.tableLayoutPanelBSaveFold);
            this.panelSaveFold.Controls.Add(this.tableLayoutPanelHeaderSaveFold);
            this.panelSaveFold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSaveFold.Location = new System.Drawing.Point(0, 24);
            this.panelSaveFold.Margin = new System.Windows.Forms.Padding(0);
            this.panelSaveFold.Name = "panelSaveFold";
            this.panelSaveFold.Size = new System.Drawing.Size(1286, 554);
            this.panelSaveFold.TabIndex = 4;
            // 
            // tableLayoutPanelASaveFold
            // 
            this.tableLayoutPanelASaveFold.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelASaveFold.ColumnCount = 5;
            this.tableLayoutPanelASaveFold.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelASaveFold.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 612F));
            this.tableLayoutPanelASaveFold.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tableLayoutPanelASaveFold.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanelASaveFold.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelASaveFold.Controls.Add(this.textBoxSaveFoldLocationSaveFold, 2, 0);
            this.tableLayoutPanelASaveFold.Controls.Add(this.labelSaveLocationSaveFold, 1, 0);
            this.tableLayoutPanelASaveFold.Location = new System.Drawing.Point(3, 207);
            this.tableLayoutPanelASaveFold.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.tableLayoutPanelASaveFold.Name = "tableLayoutPanelASaveFold";
            this.tableLayoutPanelASaveFold.RowCount = 1;
            this.tableLayoutPanelASaveFold.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanelASaveFold.Size = new System.Drawing.Size(1280, 64);
            this.tableLayoutPanelASaveFold.TabIndex = 3;
            // 
            // textBoxSaveFoldLocationSaveFold
            // 
            this.textBoxSaveFoldLocationSaveFold.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSaveFoldLocationSaveFold.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.textBoxSaveFoldLocationSaveFold.Location = new System.Drawing.Point(683, 3);
            this.textBoxSaveFoldLocationSaveFold.Name = "textBoxSaveFoldLocationSaveFold";
            this.textBoxSaveFoldLocationSaveFold.Size = new System.Drawing.Size(444, 44);
            this.textBoxSaveFoldLocationSaveFold.TabIndex = 13;
            // 
            // labelSaveLocationSaveFold
            // 
            this.labelSaveLocationSaveFold.AutoSize = true;
            this.labelSaveLocationSaveFold.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelSaveLocationSaveFold.Location = new System.Drawing.Point(71, 0);
            this.labelSaveLocationSaveFold.Name = "labelSaveLocationSaveFold";
            this.labelSaveLocationSaveFold.Size = new System.Drawing.Size(378, 44);
            this.labelSaveLocationSaveFold.TabIndex = 10;
            this.labelSaveLocationSaveFold.Text = "Save Folder Location";
            // 
            // tableLayoutPanelBSaveFold
            // 
            this.tableLayoutPanelBSaveFold.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelBSaveFold.ColumnCount = 3;
            this.tableLayoutPanelBSaveFold.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBSaveFold.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanelBSaveFold.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBSaveFold.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelBSaveFold.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelBSaveFold.Controls.Add(this.buttonSaveSettingsSaveFold, 1, 0);
            this.tableLayoutPanelBSaveFold.Location = new System.Drawing.Point(3, 271);
            this.tableLayoutPanelBSaveFold.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tableLayoutPanelBSaveFold.Name = "tableLayoutPanelBSaveFold";
            this.tableLayoutPanelBSaveFold.RowCount = 1;
            this.tableLayoutPanelBSaveFold.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelBSaveFold.Size = new System.Drawing.Size(1280, 100);
            this.tableLayoutPanelBSaveFold.TabIndex = 1;
            // 
            // buttonSaveSettingsSaveFold
            // 
            this.buttonSaveSettingsSaveFold.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveSettingsSaveFold.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.buttonSaveSettingsSaveFold.Location = new System.Drawing.Point(490, 0);
            this.buttonSaveSettingsSaveFold.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSaveSettingsSaveFold.Name = "buttonSaveSettingsSaveFold";
            this.buttonSaveSettingsSaveFold.Size = new System.Drawing.Size(300, 100);
            this.buttonSaveSettingsSaveFold.TabIndex = 1;
            this.buttonSaveSettingsSaveFold.Text = "Save Settings";
            this.buttonSaveSettingsSaveFold.UseVisualStyleBackColor = true;
            this.buttonSaveSettingsSaveFold.Click += new System.EventHandler(this.buttonSaveSettingsSaveFold_Click);
            // 
            // tableLayoutPanelHeaderSaveFold
            // 
            this.tableLayoutPanelHeaderSaveFold.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelHeaderSaveFold.ColumnCount = 5;
            this.tableLayoutPanelHeaderSaveFold.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelHeaderSaveFold.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelHeaderSaveFold.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelHeaderSaveFold.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelHeaderSaveFold.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelHeaderSaveFold.Controls.Add(this.labelSaveFolderSettingsSaveFold, 1, 0);
            this.tableLayoutPanelHeaderSaveFold.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelHeaderSaveFold.Name = "tableLayoutPanelHeaderSaveFold";
            this.tableLayoutPanelHeaderSaveFold.RowCount = 2;
            this.tableLayoutPanelHeaderSaveFold.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanelHeaderSaveFold.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanelHeaderSaveFold.Size = new System.Drawing.Size(1280, 184);
            this.tableLayoutPanelHeaderSaveFold.TabIndex = 0;
            // 
            // labelSaveFolderSettingsSaveFold
            // 
            this.labelSaveFolderSettingsSaveFold.AutoSize = true;
            this.labelSaveFolderSettingsSaveFold.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.labelSaveFolderSettingsSaveFold.Location = new System.Drawing.Point(23, 0);
            this.labelSaveFolderSettingsSaveFold.Name = "labelSaveFolderSettingsSaveFold";
            this.labelSaveFolderSettingsSaveFold.Size = new System.Drawing.Size(528, 63);
            this.labelSaveFolderSettingsSaveFold.TabIndex = 0;
            this.labelSaveFolderSettingsSaveFold.Text = "Save Folder Settings";
            // 
            // panelSaveAs
            // 
            this.panelSaveAs.AutoScroll = true;
            this.panelSaveAs.AutoSize = true;
            this.panelSaveAs.Controls.Add(this.tableLayoutPanelASaveAs);
            this.panelSaveAs.Controls.Add(this.tableLayoutPanelBSaveAs);
            this.panelSaveAs.Controls.Add(this.tableLayoutPanelHeaderSaveAs);
            this.panelSaveAs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSaveAs.Location = new System.Drawing.Point(0, 24);
            this.panelSaveAs.Margin = new System.Windows.Forms.Padding(0);
            this.panelSaveAs.Name = "panelSaveAs";
            this.panelSaveAs.Size = new System.Drawing.Size(1286, 554);
            this.panelSaveAs.TabIndex = 5;
            // 
            // tableLayoutPanelASaveAs
            // 
            this.tableLayoutPanelASaveAs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelASaveAs.ColumnCount = 8;
            this.tableLayoutPanelASaveAs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelASaveAs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 403F));
            this.tableLayoutPanelASaveAs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelASaveAs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tableLayoutPanelASaveAs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelASaveAs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelASaveAs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanelASaveAs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelASaveAs.Controls.Add(this.buttonSaveSaveAs, 5, 0);
            this.tableLayoutPanelASaveAs.Controls.Add(this.textBoxSaveNameSaveAs, 3, 0);
            this.tableLayoutPanelASaveAs.Controls.Add(this.labelSaveNameSaveAs, 1, 0);
            this.tableLayoutPanelASaveAs.Location = new System.Drawing.Point(3, 207);
            this.tableLayoutPanelASaveAs.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.tableLayoutPanelASaveAs.Name = "tableLayoutPanelASaveAs";
            this.tableLayoutPanelASaveAs.RowCount = 1;
            this.tableLayoutPanelASaveAs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanelASaveAs.Size = new System.Drawing.Size(1263, 64);
            this.tableLayoutPanelASaveAs.TabIndex = 3;
            // 
            // buttonSaveSaveAs
            // 
            this.buttonSaveSaveAs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveSaveAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.buttonSaveSaveAs.Location = new System.Drawing.Point(952, 0);
            this.buttonSaveSaveAs.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSaveSaveAs.Name = "buttonSaveSaveAs";
            this.buttonSaveSaveAs.Size = new System.Drawing.Size(200, 64);
            this.buttonSaveSaveAs.TabIndex = 0;
            this.buttonSaveSaveAs.Text = "Save";
            this.buttonSaveSaveAs.UseVisualStyleBackColor = true;
            this.buttonSaveSaveAs.Click += new System.EventHandler(this.buttonSaveSaveAs_Click);
            // 
            // textBoxSaveNameSaveAs
            // 
            this.textBoxSaveNameSaveAs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSaveNameSaveAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.textBoxSaveNameSaveAs.Location = new System.Drawing.Point(485, 3);
            this.textBoxSaveNameSaveAs.Name = "textBoxSaveNameSaveAs";
            this.textBoxSaveNameSaveAs.Size = new System.Drawing.Size(444, 44);
            this.textBoxSaveNameSaveAs.TabIndex = 13;
            // 
            // labelSaveNameSaveAs
            // 
            this.labelSaveNameSaveAs.AutoSize = true;
            this.labelSaveNameSaveAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelSaveNameSaveAs.Location = new System.Drawing.Point(62, 0);
            this.labelSaveNameSaveAs.Name = "labelSaveNameSaveAs";
            this.labelSaveNameSaveAs.Size = new System.Drawing.Size(397, 44);
            this.labelSaveNameSaveAs.TabIndex = 10;
            this.labelSaveNameSaveAs.Text = "Save Name (Optional)";
            // 
            // tableLayoutPanelBSaveAs
            // 
            this.tableLayoutPanelBSaveAs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelBSaveAs.ColumnCount = 3;
            this.tableLayoutPanelBSaveAs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBSaveAs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1144F));
            this.tableLayoutPanelBSaveAs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBSaveAs.Controls.Add(this.dataGridViewSavesSaveAs, 1, 0);
            this.tableLayoutPanelBSaveAs.Location = new System.Drawing.Point(3, 291);
            this.tableLayoutPanelBSaveAs.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tableLayoutPanelBSaveAs.Name = "tableLayoutPanelBSaveAs";
            this.tableLayoutPanelBSaveAs.RowCount = 1;
            this.tableLayoutPanelBSaveAs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanelBSaveAs.Size = new System.Drawing.Size(1263, 300);
            this.tableLayoutPanelBSaveAs.TabIndex = 1;
            // 
            // dataGridViewSavesSaveAs
            // 
            this.dataGridViewSavesSaveAs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSavesSaveAs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSavesSaveAs.Location = new System.Drawing.Point(62, 3);
            this.dataGridViewSavesSaveAs.Name = "dataGridViewSavesSaveAs";
            this.dataGridViewSavesSaveAs.Size = new System.Drawing.Size(1138, 150);
            this.dataGridViewSavesSaveAs.TabIndex = 0;
            this.dataGridViewSavesSaveAs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSavesSaveAs_CellContentClick);
            // 
            // tableLayoutPanelHeaderSaveAs
            // 
            this.tableLayoutPanelHeaderSaveAs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelHeaderSaveAs.ColumnCount = 5;
            this.tableLayoutPanelHeaderSaveAs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelHeaderSaveAs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelHeaderSaveAs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelHeaderSaveAs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelHeaderSaveAs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelHeaderSaveAs.Controls.Add(this.labelSaveAsSaveAs, 1, 0);
            this.tableLayoutPanelHeaderSaveAs.Controls.Add(this.buttonBackSaveAs, 3, 0);
            this.tableLayoutPanelHeaderSaveAs.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelHeaderSaveAs.Name = "tableLayoutPanelHeaderSaveAs";
            this.tableLayoutPanelHeaderSaveAs.RowCount = 2;
            this.tableLayoutPanelHeaderSaveAs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanelHeaderSaveAs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanelHeaderSaveAs.Size = new System.Drawing.Size(1263, 184);
            this.tableLayoutPanelHeaderSaveAs.TabIndex = 0;
            // 
            // labelSaveAsSaveAs
            // 
            this.labelSaveAsSaveAs.AutoSize = true;
            this.labelSaveAsSaveAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.labelSaveAsSaveAs.Location = new System.Drawing.Point(23, 0);
            this.labelSaveAsSaveAs.Name = "labelSaveAsSaveAs";
            this.labelSaveAsSaveAs.Size = new System.Drawing.Size(227, 63);
            this.labelSaveAsSaveAs.TabIndex = 0;
            this.labelSaveAsSaveAs.Text = "Save As";
            // 
            // buttonBackSaveAs
            // 
            this.buttonBackSaveAs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBackSaveAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.buttonBackSaveAs.Location = new System.Drawing.Point(1043, 20);
            this.buttonBackSaveAs.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBackSaveAs.Name = "buttonBackSaveAs";
            this.buttonBackSaveAs.Size = new System.Drawing.Size(200, 100);
            this.buttonBackSaveAs.TabIndex = 5;
            this.buttonBackSaveAs.Text = "Back";
            this.buttonBackSaveAs.UseVisualStyleBackColor = true;
            this.buttonBackSaveAs.Click += new System.EventHandler(this.buttonBackSaveAs_Click);
            // 
            // panelLoad
            // 
            this.panelLoad.AutoScroll = true;
            this.panelLoad.AutoSize = true;
            this.panelLoad.Controls.Add(this.tableLayoutPanelALoad);
            this.panelLoad.Controls.Add(this.tableLayoutPanelHeaderLoad);
            this.panelLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLoad.Location = new System.Drawing.Point(0, 24);
            this.panelLoad.Margin = new System.Windows.Forms.Padding(0);
            this.panelLoad.Name = "panelLoad";
            this.panelLoad.Size = new System.Drawing.Size(1286, 554);
            this.panelLoad.TabIndex = 6;
            // 
            // tableLayoutPanelALoad
            // 
            this.tableLayoutPanelALoad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelALoad.ColumnCount = 3;
            this.tableLayoutPanelALoad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelALoad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1144F));
            this.tableLayoutPanelALoad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelALoad.Controls.Add(this.dataGridViewLoadsLoad, 1, 0);
            this.tableLayoutPanelALoad.Location = new System.Drawing.Point(3, 291);
            this.tableLayoutPanelALoad.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tableLayoutPanelALoad.Name = "tableLayoutPanelALoad";
            this.tableLayoutPanelALoad.RowCount = 1;
            this.tableLayoutPanelALoad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanelALoad.Size = new System.Drawing.Size(1263, 300);
            this.tableLayoutPanelALoad.TabIndex = 1;
            // 
            // dataGridViewLoadsLoad
            // 
            this.dataGridViewLoadsLoad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewLoadsLoad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLoadsLoad.Location = new System.Drawing.Point(62, 3);
            this.dataGridViewLoadsLoad.Name = "dataGridViewLoadsLoad";
            this.dataGridViewLoadsLoad.Size = new System.Drawing.Size(1138, 150);
            this.dataGridViewLoadsLoad.TabIndex = 0;
            this.dataGridViewLoadsLoad.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLoadsLoad_CellContentClick);
            // 
            // tableLayoutPanelHeaderLoad
            // 
            this.tableLayoutPanelHeaderLoad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelHeaderLoad.ColumnCount = 5;
            this.tableLayoutPanelHeaderLoad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelHeaderLoad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelHeaderLoad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelHeaderLoad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelHeaderLoad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelHeaderLoad.Controls.Add(this.labelLoadLoad, 1, 0);
            this.tableLayoutPanelHeaderLoad.Controls.Add(this.buttonBackLoad, 3, 0);
            this.tableLayoutPanelHeaderLoad.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelHeaderLoad.Name = "tableLayoutPanelHeaderLoad";
            this.tableLayoutPanelHeaderLoad.RowCount = 2;
            this.tableLayoutPanelHeaderLoad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanelHeaderLoad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanelHeaderLoad.Size = new System.Drawing.Size(1263, 184);
            this.tableLayoutPanelHeaderLoad.TabIndex = 0;
            // 
            // labelLoadLoad
            // 
            this.labelLoadLoad.AutoSize = true;
            this.labelLoadLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.labelLoadLoad.Location = new System.Drawing.Point(23, 0);
            this.labelLoadLoad.Name = "labelLoadLoad";
            this.labelLoadLoad.Size = new System.Drawing.Size(147, 63);
            this.labelLoadLoad.TabIndex = 0;
            this.labelLoadLoad.Text = "Load";
            // 
            // buttonBackLoad
            // 
            this.buttonBackLoad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBackLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.buttonBackLoad.Location = new System.Drawing.Point(1043, 20);
            this.buttonBackLoad.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBackLoad.Name = "buttonBackLoad";
            this.buttonBackLoad.Size = new System.Drawing.Size(200, 100);
            this.buttonBackLoad.TabIndex = 5;
            this.buttonBackLoad.Text = "Back";
            this.buttonBackLoad.UseVisualStyleBackColor = true;
            this.buttonBackLoad.Click += new System.EventHandler(this.buttonBackLoad_Click);
            // 
            // panelSimTo
            // 
            this.panelSimTo.AutoScroll = true;
            this.panelSimTo.AutoSize = true;
            this.panelSimTo.Controls.Add(this.tableLayoutPanelBSimTo);
            this.panelSimTo.Controls.Add(this.tableLayoutPanelASimTo);
            this.panelSimTo.Controls.Add(this.tableLayoutPanelHeaderSimTo);
            this.panelSimTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSimTo.Location = new System.Drawing.Point(0, 24);
            this.panelSimTo.Margin = new System.Windows.Forms.Padding(0);
            this.panelSimTo.Name = "panelSimTo";
            this.panelSimTo.Size = new System.Drawing.Size(1286, 554);
            this.panelSimTo.TabIndex = 7;
            // 
            // tableLayoutPanelBSimTo
            // 
            this.tableLayoutPanelBSimTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelBSimTo.ColumnCount = 9;
            this.tableLayoutPanelBSimTo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBSimTo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 271F));
            this.tableLayoutPanelBSimTo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelBSimTo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 271F));
            this.tableLayoutPanelBSimTo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelBSimTo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 271F));
            this.tableLayoutPanelBSimTo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelBSimTo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 271F));
            this.tableLayoutPanelBSimTo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBSimTo.Controls.Add(this.labelDaySimTo, 3, 0);
            this.tableLayoutPanelBSimTo.Controls.Add(this.labelMonthSimTo, 1, 0);
            this.tableLayoutPanelBSimTo.Controls.Add(this.comboBoxMonthSimTo, 1, 1);
            this.tableLayoutPanelBSimTo.Controls.Add(this.labelYearSimTo, 5, 0);
            this.tableLayoutPanelBSimTo.Controls.Add(this.labelYear20SimTo, 5, 1);
            this.tableLayoutPanelBSimTo.Controls.Add(this.buttonGoSimTo, 7, 1);
            this.tableLayoutPanelBSimTo.Controls.Add(this.comboBoxDaySimTo, 3, 1);
            this.tableLayoutPanelBSimTo.Location = new System.Drawing.Point(3, 327);
            this.tableLayoutPanelBSimTo.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.tableLayoutPanelBSimTo.Name = "tableLayoutPanelBSimTo";
            this.tableLayoutPanelBSimTo.RowCount = 2;
            this.tableLayoutPanelBSimTo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanelBSimTo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanelBSimTo.Size = new System.Drawing.Size(1280, 128);
            this.tableLayoutPanelBSimTo.TabIndex = 3;
            // 
            // labelDaySimTo
            // 
            this.labelDaySimTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDaySimTo.AutoSize = true;
            this.labelDaySimTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelDaySimTo.Location = new System.Drawing.Point(362, 0);
            this.labelDaySimTo.Name = "labelDaySimTo";
            this.labelDaySimTo.Size = new System.Drawing.Size(265, 44);
            this.labelDaySimTo.TabIndex = 8;
            this.labelDaySimTo.Text = "Day";
            this.labelDaySimTo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelMonthSimTo
            // 
            this.labelMonthSimTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMonthSimTo.AutoSize = true;
            this.labelMonthSimTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelMonthSimTo.Location = new System.Drawing.Point(71, 0);
            this.labelMonthSimTo.Name = "labelMonthSimTo";
            this.labelMonthSimTo.Size = new System.Drawing.Size(265, 44);
            this.labelMonthSimTo.TabIndex = 7;
            this.labelMonthSimTo.Text = "Month";
            this.labelMonthSimTo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBoxMonthSimTo
            // 
            this.comboBoxMonthSimTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.comboBoxMonthSimTo.FormattingEnabled = true;
            this.comboBoxMonthSimTo.Location = new System.Drawing.Point(71, 67);
            this.comboBoxMonthSimTo.Name = "comboBoxMonthSimTo";
            this.comboBoxMonthSimTo.Size = new System.Drawing.Size(265, 45);
            this.comboBoxMonthSimTo.TabIndex = 14;
            this.comboBoxMonthSimTo.SelectedIndexChanged += new System.EventHandler(this.comboBoxMonthSimTo_SelectedIndexChanged);
            // 
            // labelYearSimTo
            // 
            this.labelYearSimTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelYearSimTo.AutoSize = true;
            this.labelYearSimTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelYearSimTo.Location = new System.Drawing.Point(653, 0);
            this.labelYearSimTo.Name = "labelYearSimTo";
            this.labelYearSimTo.Size = new System.Drawing.Size(265, 44);
            this.labelYearSimTo.TabIndex = 9;
            this.labelYearSimTo.Text = "Year";
            this.labelYearSimTo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelYear20SimTo
            // 
            this.labelYear20SimTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelYear20SimTo.AutoSize = true;
            this.labelYear20SimTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelYear20SimTo.Location = new System.Drawing.Point(653, 64);
            this.labelYear20SimTo.Name = "labelYear20SimTo";
            this.labelYear20SimTo.Size = new System.Drawing.Size(265, 44);
            this.labelYear20SimTo.TabIndex = 10;
            this.labelYear20SimTo.Text = "20XX";
            this.labelYear20SimTo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonGoSimTo
            // 
            this.buttonGoSimTo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGoSimTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.buttonGoSimTo.Location = new System.Drawing.Point(941, 64);
            this.buttonGoSimTo.Margin = new System.Windows.Forms.Padding(0);
            this.buttonGoSimTo.Name = "buttonGoSimTo";
            this.buttonGoSimTo.Size = new System.Drawing.Size(271, 64);
            this.buttonGoSimTo.TabIndex = 15;
            this.buttonGoSimTo.Text = "Go";
            this.buttonGoSimTo.UseVisualStyleBackColor = true;
            this.buttonGoSimTo.Click += new System.EventHandler(this.buttonGoSimTo_Click);
            // 
            // comboBoxDaySimTo
            // 
            this.comboBoxDaySimTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.comboBoxDaySimTo.FormattingEnabled = true;
            this.comboBoxDaySimTo.Location = new System.Drawing.Point(362, 67);
            this.comboBoxDaySimTo.Name = "comboBoxDaySimTo";
            this.comboBoxDaySimTo.Size = new System.Drawing.Size(265, 45);
            this.comboBoxDaySimTo.TabIndex = 16;
            // 
            // tableLayoutPanelASimTo
            // 
            this.tableLayoutPanelASimTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelASimTo.ColumnCount = 3;
            this.tableLayoutPanelASimTo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelASimTo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanelASimTo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelASimTo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelASimTo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelASimTo.Controls.Add(this.buttonSimToEndSimTo, 1, 0);
            this.tableLayoutPanelASimTo.Location = new System.Drawing.Point(3, 207);
            this.tableLayoutPanelASimTo.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tableLayoutPanelASimTo.Name = "tableLayoutPanelASimTo";
            this.tableLayoutPanelASimTo.RowCount = 1;
            this.tableLayoutPanelASimTo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelASimTo.Size = new System.Drawing.Size(1280, 100);
            this.tableLayoutPanelASimTo.TabIndex = 1;
            // 
            // buttonSimToEndSimTo
            // 
            this.buttonSimToEndSimTo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSimToEndSimTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.buttonSimToEndSimTo.Location = new System.Drawing.Point(490, 0);
            this.buttonSimToEndSimTo.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSimToEndSimTo.Name = "buttonSimToEndSimTo";
            this.buttonSimToEndSimTo.Size = new System.Drawing.Size(300, 100);
            this.buttonSimToEndSimTo.TabIndex = 0;
            this.buttonSimToEndSimTo.Text = "Sim To End";
            this.buttonSimToEndSimTo.UseVisualStyleBackColor = true;
            this.buttonSimToEndSimTo.Click += new System.EventHandler(this.buttonSimToEndSimTo_Click);
            // 
            // tableLayoutPanelHeaderSimTo
            // 
            this.tableLayoutPanelHeaderSimTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelHeaderSimTo.ColumnCount = 5;
            this.tableLayoutPanelHeaderSimTo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelHeaderSimTo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelHeaderSimTo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelHeaderSimTo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelHeaderSimTo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelHeaderSimTo.Controls.Add(this.labelSimToSimTo, 1, 0);
            this.tableLayoutPanelHeaderSimTo.Controls.Add(this.buttonBackSimTo, 3, 0);
            this.tableLayoutPanelHeaderSimTo.Controls.Add(this.labelCurrentDaySimTo, 1, 1);
            this.tableLayoutPanelHeaderSimTo.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelHeaderSimTo.Name = "tableLayoutPanelHeaderSimTo";
            this.tableLayoutPanelHeaderSimTo.RowCount = 2;
            this.tableLayoutPanelHeaderSimTo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanelHeaderSimTo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanelHeaderSimTo.Size = new System.Drawing.Size(1280, 184);
            this.tableLayoutPanelHeaderSimTo.TabIndex = 0;
            // 
            // labelSimToSimTo
            // 
            this.labelSimToSimTo.AutoSize = true;
            this.labelSimToSimTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.labelSimToSimTo.Location = new System.Drawing.Point(23, 0);
            this.labelSimToSimTo.Name = "labelSimToSimTo";
            this.labelSimToSimTo.Size = new System.Drawing.Size(198, 63);
            this.labelSimToSimTo.TabIndex = 0;
            this.labelSimToSimTo.Text = "Sim To";
            // 
            // buttonBackSimTo
            // 
            this.buttonBackSimTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBackSimTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.buttonBackSimTo.Location = new System.Drawing.Point(1060, 20);
            this.buttonBackSimTo.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBackSimTo.Name = "buttonBackSimTo";
            this.buttonBackSimTo.Size = new System.Drawing.Size(200, 100);
            this.buttonBackSimTo.TabIndex = 5;
            this.buttonBackSimTo.Text = "Back";
            this.buttonBackSimTo.UseVisualStyleBackColor = true;
            this.buttonBackSimTo.Click += new System.EventHandler(this.buttonBackSimTo_Click);
            // 
            // labelCurrentDaySimTo
            // 
            this.labelCurrentDaySimTo.AutoSize = true;
            this.labelCurrentDaySimTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelCurrentDaySimTo.Location = new System.Drawing.Point(23, 120);
            this.labelCurrentDaySimTo.Name = "labelCurrentDaySimTo";
            this.labelCurrentDaySimTo.Size = new System.Drawing.Size(235, 44);
            this.labelCurrentDaySimTo.TabIndex = 6;
            this.labelCurrentDaySimTo.Text = "Current Day:";
            // 
            // panelStartFrom
            // 
            this.panelStartFrom.AutoScroll = true;
            this.panelStartFrom.AutoSize = true;
            this.panelStartFrom.Controls.Add(this.tableLayoutPanelBStartFrom);
            this.panelStartFrom.Controls.Add(this.tableLayoutPanelAStartFrom);
            this.panelStartFrom.Controls.Add(this.tableLayoutPanelHeaderStartFrom);
            this.panelStartFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStartFrom.Location = new System.Drawing.Point(0, 24);
            this.panelStartFrom.Margin = new System.Windows.Forms.Padding(0);
            this.panelStartFrom.Name = "panelStartFrom";
            this.panelStartFrom.Size = new System.Drawing.Size(1286, 554);
            this.panelStartFrom.TabIndex = 8;
            // 
            // tableLayoutPanelBStartFrom
            // 
            this.tableLayoutPanelBStartFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelBStartFrom.ColumnCount = 9;
            this.tableLayoutPanelBStartFrom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBStartFrom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 271F));
            this.tableLayoutPanelBStartFrom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelBStartFrom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 271F));
            this.tableLayoutPanelBStartFrom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelBStartFrom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 271F));
            this.tableLayoutPanelBStartFrom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelBStartFrom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 271F));
            this.tableLayoutPanelBStartFrom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBStartFrom.Controls.Add(this.labelDayStartFrom, 3, 0);
            this.tableLayoutPanelBStartFrom.Controls.Add(this.labelMonthStartFrom, 1, 0);
            this.tableLayoutPanelBStartFrom.Controls.Add(this.comboBoxMonthStartFrom, 1, 1);
            this.tableLayoutPanelBStartFrom.Controls.Add(this.labelYearStartFrom, 5, 0);
            this.tableLayoutPanelBStartFrom.Controls.Add(this.labelYear20StartFrom, 5, 1);
            this.tableLayoutPanelBStartFrom.Controls.Add(this.buttonGoStartFrom, 7, 1);
            this.tableLayoutPanelBStartFrom.Controls.Add(this.comboBoxDayStartFrom, 3, 1);
            this.tableLayoutPanelBStartFrom.Location = new System.Drawing.Point(3, 327);
            this.tableLayoutPanelBStartFrom.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.tableLayoutPanelBStartFrom.Name = "tableLayoutPanelBStartFrom";
            this.tableLayoutPanelBStartFrom.RowCount = 2;
            this.tableLayoutPanelBStartFrom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanelBStartFrom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanelBStartFrom.Size = new System.Drawing.Size(1280, 128);
            this.tableLayoutPanelBStartFrom.TabIndex = 3;
            // 
            // labelDayStartFrom
            // 
            this.labelDayStartFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDayStartFrom.AutoSize = true;
            this.labelDayStartFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelDayStartFrom.Location = new System.Drawing.Point(362, 0);
            this.labelDayStartFrom.Name = "labelDayStartFrom";
            this.labelDayStartFrom.Size = new System.Drawing.Size(265, 44);
            this.labelDayStartFrom.TabIndex = 8;
            this.labelDayStartFrom.Text = "Day";
            this.labelDayStartFrom.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelMonthStartFrom
            // 
            this.labelMonthStartFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMonthStartFrom.AutoSize = true;
            this.labelMonthStartFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelMonthStartFrom.Location = new System.Drawing.Point(71, 0);
            this.labelMonthStartFrom.Name = "labelMonthStartFrom";
            this.labelMonthStartFrom.Size = new System.Drawing.Size(265, 44);
            this.labelMonthStartFrom.TabIndex = 7;
            this.labelMonthStartFrom.Text = "Month";
            this.labelMonthStartFrom.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBoxMonthStartFrom
            // 
            this.comboBoxMonthStartFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.comboBoxMonthStartFrom.FormattingEnabled = true;
            this.comboBoxMonthStartFrom.Location = new System.Drawing.Point(71, 67);
            this.comboBoxMonthStartFrom.Name = "comboBoxMonthStartFrom";
            this.comboBoxMonthStartFrom.Size = new System.Drawing.Size(265, 45);
            this.comboBoxMonthStartFrom.TabIndex = 14;
            this.comboBoxMonthStartFrom.SelectedIndexChanged += new System.EventHandler(this.comboBoxMonthStartFrom_SelectedIndexChanged);
            // 
            // labelYearStartFrom
            // 
            this.labelYearStartFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelYearStartFrom.AutoSize = true;
            this.labelYearStartFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelYearStartFrom.Location = new System.Drawing.Point(653, 0);
            this.labelYearStartFrom.Name = "labelYearStartFrom";
            this.labelYearStartFrom.Size = new System.Drawing.Size(265, 44);
            this.labelYearStartFrom.TabIndex = 9;
            this.labelYearStartFrom.Text = "Year";
            this.labelYearStartFrom.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelYear20StartFrom
            // 
            this.labelYear20StartFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelYear20StartFrom.AutoSize = true;
            this.labelYear20StartFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelYear20StartFrom.Location = new System.Drawing.Point(653, 64);
            this.labelYear20StartFrom.Name = "labelYear20StartFrom";
            this.labelYear20StartFrom.Size = new System.Drawing.Size(265, 44);
            this.labelYear20StartFrom.TabIndex = 10;
            this.labelYear20StartFrom.Text = "20XX";
            this.labelYear20StartFrom.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonGoStartFrom
            // 
            this.buttonGoStartFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGoStartFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.buttonGoStartFrom.Location = new System.Drawing.Point(941, 64);
            this.buttonGoStartFrom.Margin = new System.Windows.Forms.Padding(0);
            this.buttonGoStartFrom.Name = "buttonGoStartFrom";
            this.buttonGoStartFrom.Size = new System.Drawing.Size(271, 64);
            this.buttonGoStartFrom.TabIndex = 15;
            this.buttonGoStartFrom.Text = "Go";
            this.buttonGoStartFrom.UseVisualStyleBackColor = true;
            this.buttonGoStartFrom.Click += new System.EventHandler(this.buttonGoStartFrom_Click);
            // 
            // comboBoxDayStartFrom
            // 
            this.comboBoxDayStartFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.comboBoxDayStartFrom.FormattingEnabled = true;
            this.comboBoxDayStartFrom.Location = new System.Drawing.Point(362, 67);
            this.comboBoxDayStartFrom.Name = "comboBoxDayStartFrom";
            this.comboBoxDayStartFrom.Size = new System.Drawing.Size(265, 45);
            this.comboBoxDayStartFrom.TabIndex = 16;
            // 
            // tableLayoutPanelAStartFrom
            // 
            this.tableLayoutPanelAStartFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelAStartFrom.ColumnCount = 3;
            this.tableLayoutPanelAStartFrom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAStartFrom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanelAStartFrom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAStartFrom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelAStartFrom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelAStartFrom.Controls.Add(this.buttonStartFromBegStartFrom, 1, 0);
            this.tableLayoutPanelAStartFrom.Location = new System.Drawing.Point(3, 207);
            this.tableLayoutPanelAStartFrom.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tableLayoutPanelAStartFrom.Name = "tableLayoutPanelAStartFrom";
            this.tableLayoutPanelAStartFrom.RowCount = 1;
            this.tableLayoutPanelAStartFrom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelAStartFrom.Size = new System.Drawing.Size(1280, 100);
            this.tableLayoutPanelAStartFrom.TabIndex = 1;
            // 
            // buttonStartFromBegStartFrom
            // 
            this.buttonStartFromBegStartFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStartFromBegStartFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.buttonStartFromBegStartFrom.Location = new System.Drawing.Point(490, 0);
            this.buttonStartFromBegStartFrom.Margin = new System.Windows.Forms.Padding(0);
            this.buttonStartFromBegStartFrom.Name = "buttonStartFromBegStartFrom";
            this.buttonStartFromBegStartFrom.Size = new System.Drawing.Size(300, 100);
            this.buttonStartFromBegStartFrom.TabIndex = 0;
            this.buttonStartFromBegStartFrom.Text = "Start From Beginning";
            this.buttonStartFromBegStartFrom.UseVisualStyleBackColor = true;
            this.buttonStartFromBegStartFrom.Click += new System.EventHandler(this.buttonStartFromBegStartFrom_Click);
            // 
            // tableLayoutPanelHeaderStartFrom
            // 
            this.tableLayoutPanelHeaderStartFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelHeaderStartFrom.ColumnCount = 5;
            this.tableLayoutPanelHeaderStartFrom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelHeaderStartFrom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelHeaderStartFrom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelHeaderStartFrom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelHeaderStartFrom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelHeaderStartFrom.Controls.Add(this.labelStartFromPrevStartFrom, 1, 0);
            this.tableLayoutPanelHeaderStartFrom.Controls.Add(this.buttonBackStartFrom, 3, 0);
            this.tableLayoutPanelHeaderStartFrom.Controls.Add(this.labelCurrentDayStartFrom, 1, 1);
            this.tableLayoutPanelHeaderStartFrom.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelHeaderStartFrom.Name = "tableLayoutPanelHeaderStartFrom";
            this.tableLayoutPanelHeaderStartFrom.RowCount = 2;
            this.tableLayoutPanelHeaderStartFrom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanelHeaderStartFrom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanelHeaderStartFrom.Size = new System.Drawing.Size(1280, 184);
            this.tableLayoutPanelHeaderStartFrom.TabIndex = 0;
            // 
            // labelStartFromPrevStartFrom
            // 
            this.labelStartFromPrevStartFrom.AutoSize = true;
            this.labelStartFromPrevStartFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.labelStartFromPrevStartFrom.Location = new System.Drawing.Point(23, 0);
            this.labelStartFromPrevStartFrom.Name = "labelStartFromPrevStartFrom";
            this.labelStartFromPrevStartFrom.Size = new System.Drawing.Size(634, 63);
            this.labelStartFromPrevStartFrom.TabIndex = 0;
            this.labelStartFromPrevStartFrom.Text = "Start From Previous Date";
            // 
            // buttonBackStartFrom
            // 
            this.buttonBackStartFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBackStartFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.buttonBackStartFrom.Location = new System.Drawing.Point(1060, 20);
            this.buttonBackStartFrom.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBackStartFrom.Name = "buttonBackStartFrom";
            this.buttonBackStartFrom.Size = new System.Drawing.Size(200, 100);
            this.buttonBackStartFrom.TabIndex = 5;
            this.buttonBackStartFrom.Text = "Back";
            this.buttonBackStartFrom.UseVisualStyleBackColor = true;
            this.buttonBackStartFrom.Click += new System.EventHandler(this.buttonBackStartFrom_Click);
            // 
            // labelCurrentDayStartFrom
            // 
            this.labelCurrentDayStartFrom.AutoSize = true;
            this.labelCurrentDayStartFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelCurrentDayStartFrom.Location = new System.Drawing.Point(23, 120);
            this.labelCurrentDayStartFrom.Name = "labelCurrentDayStartFrom";
            this.labelCurrentDayStartFrom.Size = new System.Drawing.Size(235, 44);
            this.labelCurrentDayStartFrom.TabIndex = 6;
            this.labelCurrentDayStartFrom.Text = "Current Day:";
            // 
            // panelSchedFind
            // 
            this.panelSchedFind.AutoScroll = true;
            this.panelSchedFind.AutoSize = true;
            this.panelSchedFind.Controls.Add(this.tableLayoutPanelASchedFind);
            this.panelSchedFind.Controls.Add(this.tableLayoutPanelBSchedFind);
            this.panelSchedFind.Controls.Add(this.tableLayoutPanelHeaderSchedFind);
            this.panelSchedFind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSchedFind.Location = new System.Drawing.Point(0, 24);
            this.panelSchedFind.Margin = new System.Windows.Forms.Padding(0);
            this.panelSchedFind.Name = "panelSchedFind";
            this.panelSchedFind.Size = new System.Drawing.Size(1286, 554);
            this.panelSchedFind.TabIndex = 9;
            // 
            // tableLayoutPanelASchedFind
            // 
            this.tableLayoutPanelASchedFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelASchedFind.ColumnCount = 8;
            this.tableLayoutPanelASchedFind.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelASchedFind.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 368F));
            this.tableLayoutPanelASchedFind.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelASchedFind.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 266F));
            this.tableLayoutPanelASchedFind.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelASchedFind.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 206F));
            this.tableLayoutPanelASchedFind.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 162F));
            this.tableLayoutPanelASchedFind.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelASchedFind.Controls.Add(this.buttonFilterSchedFind, 5, 0);
            this.tableLayoutPanelASchedFind.Controls.Add(this.labelFilterConfSchedFind, 1, 0);
            this.tableLayoutPanelASchedFind.Controls.Add(this.comboBoxConfSchedFind, 3, 0);
            this.tableLayoutPanelASchedFind.Location = new System.Drawing.Point(3, 207);
            this.tableLayoutPanelASchedFind.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.tableLayoutPanelASchedFind.Name = "tableLayoutPanelASchedFind";
            this.tableLayoutPanelASchedFind.RowCount = 1;
            this.tableLayoutPanelASchedFind.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanelASchedFind.Size = new System.Drawing.Size(1263, 64);
            this.tableLayoutPanelASchedFind.TabIndex = 4;
            // 
            // buttonFilterSchedFind
            // 
            this.buttonFilterSchedFind.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFilterSchedFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.buttonFilterSchedFind.Location = new System.Drawing.Point(784, 0);
            this.buttonFilterSchedFind.Margin = new System.Windows.Forms.Padding(0);
            this.buttonFilterSchedFind.Name = "buttonFilterSchedFind";
            this.buttonFilterSchedFind.Size = new System.Drawing.Size(206, 64);
            this.buttonFilterSchedFind.TabIndex = 0;
            this.buttonFilterSchedFind.Text = "Filter";
            this.buttonFilterSchedFind.UseVisualStyleBackColor = true;
            this.buttonFilterSchedFind.Click += new System.EventHandler(this.buttonFilterSchedFind_Click);
            // 
            // labelFilterConfSchedFind
            // 
            this.labelFilterConfSchedFind.AutoSize = true;
            this.labelFilterConfSchedFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelFilterConfSchedFind.Location = new System.Drawing.Point(113, 0);
            this.labelFilterConfSchedFind.Name = "labelFilterConfSchedFind";
            this.labelFilterConfSchedFind.Size = new System.Drawing.Size(362, 44);
            this.labelFilterConfSchedFind.TabIndex = 10;
            this.labelFilterConfSchedFind.Text = "Filter by Conference";
            // 
            // comboBoxConfSchedFind
            // 
            this.comboBoxConfSchedFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.comboBoxConfSchedFind.FormattingEnabled = true;
            this.comboBoxConfSchedFind.Location = new System.Drawing.Point(501, 3);
            this.comboBoxConfSchedFind.Name = "comboBoxConfSchedFind";
            this.comboBoxConfSchedFind.Size = new System.Drawing.Size(254, 45);
            this.comboBoxConfSchedFind.TabIndex = 15;
            // 
            // tableLayoutPanelBSchedFind
            // 
            this.tableLayoutPanelBSchedFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelBSchedFind.ColumnCount = 5;
            this.tableLayoutPanelBSchedFind.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBSchedFind.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 458F));
            this.tableLayoutPanelBSchedFind.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanelBSchedFind.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.tableLayoutPanelBSchedFind.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBSchedFind.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelBSchedFind.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelBSchedFind.Controls.Add(this.labelSelectTeamSchedFind, 1, 0);
            this.tableLayoutPanelBSchedFind.Controls.Add(this.labelSelectDateSchedFind, 3, 0);
            this.tableLayoutPanelBSchedFind.Controls.Add(this.dataGridViewTeamsSchedFind, 1, 1);
            this.tableLayoutPanelBSchedFind.Controls.Add(this.dataGridViewDatesSchedFind, 3, 1);
            this.tableLayoutPanelBSchedFind.Location = new System.Drawing.Point(3, 291);
            this.tableLayoutPanelBSchedFind.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.tableLayoutPanelBSchedFind.Name = "tableLayoutPanelBSchedFind";
            this.tableLayoutPanelBSchedFind.RowCount = 2;
            this.tableLayoutPanelBSchedFind.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanelBSchedFind.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanelBSchedFind.Size = new System.Drawing.Size(1263, 400);
            this.tableLayoutPanelBSchedFind.TabIndex = 3;
            // 
            // labelSelectTeamSchedFind
            // 
            this.labelSelectTeamSchedFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSelectTeamSchedFind.AutoSize = true;
            this.labelSelectTeamSchedFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelSelectTeamSchedFind.Location = new System.Drawing.Point(234, 0);
            this.labelSelectTeamSchedFind.Name = "labelSelectTeamSchedFind";
            this.labelSelectTeamSchedFind.Size = new System.Drawing.Size(452, 44);
            this.labelSelectTeamSchedFind.TabIndex = 8;
            this.labelSelectTeamSchedFind.Text = "Select Team";
            this.labelSelectTeamSchedFind.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelSelectDateSchedFind
            // 
            this.labelSelectDateSchedFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSelectDateSchedFind.AutoSize = true;
            this.labelSelectDateSchedFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelSelectDateSchedFind.Location = new System.Drawing.Point(775, 0);
            this.labelSelectDateSchedFind.Name = "labelSelectDateSchedFind";
            this.labelSelectDateSchedFind.Size = new System.Drawing.Size(254, 44);
            this.labelSelectDateSchedFind.TabIndex = 9;
            this.labelSelectDateSchedFind.Text = "Select Date";
            this.labelSelectDateSchedFind.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridViewTeamsSchedFind
            // 
            this.dataGridViewTeamsSchedFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTeamsSchedFind.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeamsSchedFind.Location = new System.Drawing.Point(234, 111);
            this.dataGridViewTeamsSchedFind.Name = "dataGridViewTeamsSchedFind";
            this.dataGridViewTeamsSchedFind.Size = new System.Drawing.Size(452, 150);
            this.dataGridViewTeamsSchedFind.TabIndex = 12;
            this.dataGridViewTeamsSchedFind.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTeamsSchedFind_CellContentClick);
            // 
            // dataGridViewDatesSchedFind
            // 
            this.dataGridViewDatesSchedFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDatesSchedFind.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDatesSchedFind.Location = new System.Drawing.Point(775, 111);
            this.dataGridViewDatesSchedFind.Name = "dataGridViewDatesSchedFind";
            this.dataGridViewDatesSchedFind.Size = new System.Drawing.Size(254, 150);
            this.dataGridViewDatesSchedFind.TabIndex = 13;
            this.dataGridViewDatesSchedFind.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDatesSchedFind_CellContentClick);
            // 
            // tableLayoutPanelHeaderSchedFind
            // 
            this.tableLayoutPanelHeaderSchedFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelHeaderSchedFind.ColumnCount = 5;
            this.tableLayoutPanelHeaderSchedFind.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelHeaderSchedFind.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelHeaderSchedFind.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelHeaderSchedFind.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelHeaderSchedFind.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelHeaderSchedFind.Controls.Add(this.labelScheduleSchedFind, 1, 0);
            this.tableLayoutPanelHeaderSchedFind.Controls.Add(this.buttonBackSchedFind, 3, 0);
            this.tableLayoutPanelHeaderSchedFind.Controls.Add(this.labelCurrentDaySchedFind, 1, 1);
            this.tableLayoutPanelHeaderSchedFind.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelHeaderSchedFind.Name = "tableLayoutPanelHeaderSchedFind";
            this.tableLayoutPanelHeaderSchedFind.RowCount = 2;
            this.tableLayoutPanelHeaderSchedFind.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanelHeaderSchedFind.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanelHeaderSchedFind.Size = new System.Drawing.Size(1263, 184);
            this.tableLayoutPanelHeaderSchedFind.TabIndex = 0;
            // 
            // labelScheduleSchedFind
            // 
            this.labelScheduleSchedFind.AutoSize = true;
            this.labelScheduleSchedFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.labelScheduleSchedFind.Location = new System.Drawing.Point(23, 0);
            this.labelScheduleSchedFind.Name = "labelScheduleSchedFind";
            this.labelScheduleSchedFind.Size = new System.Drawing.Size(253, 63);
            this.labelScheduleSchedFind.TabIndex = 0;
            this.labelScheduleSchedFind.Text = "Schedule";
            // 
            // buttonBackSchedFind
            // 
            this.buttonBackSchedFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBackSchedFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.buttonBackSchedFind.Location = new System.Drawing.Point(1043, 20);
            this.buttonBackSchedFind.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBackSchedFind.Name = "buttonBackSchedFind";
            this.buttonBackSchedFind.Size = new System.Drawing.Size(200, 100);
            this.buttonBackSchedFind.TabIndex = 5;
            this.buttonBackSchedFind.Text = "Back";
            this.buttonBackSchedFind.UseVisualStyleBackColor = true;
            this.buttonBackSchedFind.Click += new System.EventHandler(this.buttonBackSchedFind_Click);
            // 
            // labelCurrentDaySchedFind
            // 
            this.labelCurrentDaySchedFind.AutoSize = true;
            this.labelCurrentDaySchedFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelCurrentDaySchedFind.Location = new System.Drawing.Point(23, 120);
            this.labelCurrentDaySchedFind.Name = "labelCurrentDaySchedFind";
            this.labelCurrentDaySchedFind.Size = new System.Drawing.Size(235, 44);
            this.labelCurrentDaySchedFind.TabIndex = 6;
            this.labelCurrentDaySchedFind.Text = "Current Day:";
            // 
            // panelTeamSched
            // 
            this.panelTeamSched.AutoScroll = true;
            this.panelTeamSched.AutoSize = true;
            this.panelTeamSched.Controls.Add(this.tableLayoutPanelATeamSched);
            this.panelTeamSched.Controls.Add(this.tableLayoutPanelBTeamSched);
            this.panelTeamSched.Controls.Add(this.tableLayoutPanelHeaderTeamSched);
            this.panelTeamSched.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTeamSched.Location = new System.Drawing.Point(0, 24);
            this.panelTeamSched.Margin = new System.Windows.Forms.Padding(0);
            this.panelTeamSched.Name = "panelTeamSched";
            this.panelTeamSched.Size = new System.Drawing.Size(1286, 554);
            this.panelTeamSched.TabIndex = 10;
            // 
            // tableLayoutPanelATeamSched
            // 
            this.tableLayoutPanelATeamSched.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelATeamSched.ColumnCount = 13;
            this.tableLayoutPanelATeamSched.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelATeamSched.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.tableLayoutPanelATeamSched.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelATeamSched.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanelATeamSched.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanelATeamSched.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanelATeamSched.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelATeamSched.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 354F));
            this.tableLayoutPanelATeamSched.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelATeamSched.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanelATeamSched.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanelATeamSched.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanelATeamSched.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelATeamSched.Controls.Add(this.labelRecordTeamSched, 1, 0);
            this.tableLayoutPanelATeamSched.Controls.Add(this.labelConfRecordTeamSched, 7, 0);
            this.tableLayoutPanelATeamSched.Controls.Add(this.labelRecWinsTeamSched, 3, 0);
            this.tableLayoutPanelATeamSched.Controls.Add(this.labelRecLossesTeamSched, 5, 0);
            this.tableLayoutPanelATeamSched.Controls.Add(this.labelConfRecWinsTeamSched, 9, 0);
            this.tableLayoutPanelATeamSched.Controls.Add(this.labelConfRecLossesTeamSched, 11, 0);
            this.tableLayoutPanelATeamSched.Controls.Add(this.labelRecDashTeamSched, 4, 0);
            this.tableLayoutPanelATeamSched.Controls.Add(this.labelConfRecDashTeamSched, 10, 0);
            this.tableLayoutPanelATeamSched.Location = new System.Drawing.Point(3, 207);
            this.tableLayoutPanelATeamSched.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.tableLayoutPanelATeamSched.Name = "tableLayoutPanelATeamSched";
            this.tableLayoutPanelATeamSched.RowCount = 1;
            this.tableLayoutPanelATeamSched.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanelATeamSched.Size = new System.Drawing.Size(1263, 64);
            this.tableLayoutPanelATeamSched.TabIndex = 3;
            // 
            // labelRecordTeamSched
            // 
            this.labelRecordTeamSched.AutoSize = true;
            this.labelRecordTeamSched.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelRecordTeamSched.Location = new System.Drawing.Point(196, 0);
            this.labelRecordTeamSched.Name = "labelRecordTeamSched";
            this.labelRecordTeamSched.Size = new System.Drawing.Size(142, 44);
            this.labelRecordTeamSched.TabIndex = 10;
            this.labelRecordTeamSched.Text = "Record";
            // 
            // labelConfRecordTeamSched
            // 
            this.labelConfRecordTeamSched.AutoSize = true;
            this.labelConfRecordTeamSched.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelConfRecordTeamSched.Location = new System.Drawing.Point(541, 0);
            this.labelConfRecordTeamSched.Name = "labelConfRecordTeamSched";
            this.labelConfRecordTeamSched.Size = new System.Drawing.Size(348, 44);
            this.labelConfRecordTeamSched.TabIndex = 11;
            this.labelConfRecordTeamSched.Text = "Conference Record";
            // 
            // labelRecWinsTeamSched
            // 
            this.labelRecWinsTeamSched.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRecWinsTeamSched.AutoSize = true;
            this.labelRecWinsTeamSched.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelRecWinsTeamSched.Location = new System.Drawing.Point(361, 0);
            this.labelRecWinsTeamSched.Margin = new System.Windows.Forms.Padding(0);
            this.labelRecWinsTeamSched.Name = "labelRecWinsTeamSched";
            this.labelRecWinsTeamSched.Size = new System.Drawing.Size(62, 44);
            this.labelRecWinsTeamSched.TabIndex = 12;
            this.labelRecWinsTeamSched.Text = "00";
            this.labelRecWinsTeamSched.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelRecLossesTeamSched
            // 
            this.labelRecLossesTeamSched.AutoSize = true;
            this.labelRecLossesTeamSched.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelRecLossesTeamSched.Location = new System.Drawing.Point(456, 0);
            this.labelRecLossesTeamSched.Margin = new System.Windows.Forms.Padding(0);
            this.labelRecLossesTeamSched.Name = "labelRecLossesTeamSched";
            this.labelRecLossesTeamSched.Size = new System.Drawing.Size(62, 44);
            this.labelRecLossesTeamSched.TabIndex = 13;
            this.labelRecLossesTeamSched.Text = "00";
            // 
            // labelConfRecWinsTeamSched
            // 
            this.labelConfRecWinsTeamSched.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConfRecWinsTeamSched.AutoSize = true;
            this.labelConfRecWinsTeamSched.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelConfRecWinsTeamSched.Location = new System.Drawing.Point(912, 0);
            this.labelConfRecWinsTeamSched.Margin = new System.Windows.Forms.Padding(0);
            this.labelConfRecWinsTeamSched.Name = "labelConfRecWinsTeamSched";
            this.labelConfRecWinsTeamSched.Size = new System.Drawing.Size(62, 44);
            this.labelConfRecWinsTeamSched.TabIndex = 14;
            this.labelConfRecWinsTeamSched.Text = "00";
            this.labelConfRecWinsTeamSched.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelConfRecLossesTeamSched
            // 
            this.labelConfRecLossesTeamSched.AutoSize = true;
            this.labelConfRecLossesTeamSched.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelConfRecLossesTeamSched.Location = new System.Drawing.Point(1007, 0);
            this.labelConfRecLossesTeamSched.Margin = new System.Windows.Forms.Padding(0);
            this.labelConfRecLossesTeamSched.Name = "labelConfRecLossesTeamSched";
            this.labelConfRecLossesTeamSched.Size = new System.Drawing.Size(62, 44);
            this.labelConfRecLossesTeamSched.TabIndex = 15;
            this.labelConfRecLossesTeamSched.Text = "00";
            // 
            // labelRecDashTeamSched
            // 
            this.labelRecDashTeamSched.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRecDashTeamSched.AutoSize = true;
            this.labelRecDashTeamSched.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelRecDashTeamSched.Location = new System.Drawing.Point(423, 0);
            this.labelRecDashTeamSched.Margin = new System.Windows.Forms.Padding(0);
            this.labelRecDashTeamSched.Name = "labelRecDashTeamSched";
            this.labelRecDashTeamSched.Size = new System.Drawing.Size(33, 44);
            this.labelRecDashTeamSched.TabIndex = 16;
            this.labelRecDashTeamSched.Text = "-";
            this.labelRecDashTeamSched.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelConfRecDashTeamSched
            // 
            this.labelConfRecDashTeamSched.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConfRecDashTeamSched.AutoSize = true;
            this.labelConfRecDashTeamSched.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelConfRecDashTeamSched.Location = new System.Drawing.Point(974, 0);
            this.labelConfRecDashTeamSched.Margin = new System.Windows.Forms.Padding(0);
            this.labelConfRecDashTeamSched.Name = "labelConfRecDashTeamSched";
            this.labelConfRecDashTeamSched.Size = new System.Drawing.Size(33, 44);
            this.labelConfRecDashTeamSched.TabIndex = 17;
            this.labelConfRecDashTeamSched.Text = "-";
            this.labelConfRecDashTeamSched.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanelBTeamSched
            // 
            this.tableLayoutPanelBTeamSched.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelBTeamSched.ColumnCount = 3;
            this.tableLayoutPanelBTeamSched.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBTeamSched.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1144F));
            this.tableLayoutPanelBTeamSched.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBTeamSched.Controls.Add(this.dataGridViewTeamSchedTeamSched, 1, 0);
            this.tableLayoutPanelBTeamSched.Location = new System.Drawing.Point(3, 291);
            this.tableLayoutPanelBTeamSched.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tableLayoutPanelBTeamSched.Name = "tableLayoutPanelBTeamSched";
            this.tableLayoutPanelBTeamSched.RowCount = 1;
            this.tableLayoutPanelBTeamSched.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanelBTeamSched.Size = new System.Drawing.Size(1263, 300);
            this.tableLayoutPanelBTeamSched.TabIndex = 1;
            // 
            // dataGridViewTeamSchedTeamSched
            // 
            this.dataGridViewTeamSchedTeamSched.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTeamSchedTeamSched.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeamSchedTeamSched.Location = new System.Drawing.Point(62, 3);
            this.dataGridViewTeamSchedTeamSched.Name = "dataGridViewTeamSchedTeamSched";
            this.dataGridViewTeamSchedTeamSched.Size = new System.Drawing.Size(1138, 150);
            this.dataGridViewTeamSchedTeamSched.TabIndex = 0;
            this.dataGridViewTeamSchedTeamSched.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTeamSchedTeamSched_CellContentClick);
            // 
            // tableLayoutPanelHeaderTeamSched
            // 
            this.tableLayoutPanelHeaderTeamSched.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelHeaderTeamSched.ColumnCount = 5;
            this.tableLayoutPanelHeaderTeamSched.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelHeaderTeamSched.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelHeaderTeamSched.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelHeaderTeamSched.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelHeaderTeamSched.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelHeaderTeamSched.Controls.Add(this.labelTeamSchedTeamSched, 1, 0);
            this.tableLayoutPanelHeaderTeamSched.Controls.Add(this.buttonBackTeamSched, 3, 0);
            this.tableLayoutPanelHeaderTeamSched.Controls.Add(this.labelCurrentDayTeamSched, 1, 1);
            this.tableLayoutPanelHeaderTeamSched.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelHeaderTeamSched.Name = "tableLayoutPanelHeaderTeamSched";
            this.tableLayoutPanelHeaderTeamSched.RowCount = 2;
            this.tableLayoutPanelHeaderTeamSched.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanelHeaderTeamSched.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanelHeaderTeamSched.Size = new System.Drawing.Size(1263, 184);
            this.tableLayoutPanelHeaderTeamSched.TabIndex = 0;
            // 
            // labelTeamSchedTeamSched
            // 
            this.labelTeamSchedTeamSched.AutoSize = true;
            this.labelTeamSchedTeamSched.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.labelTeamSchedTeamSched.Location = new System.Drawing.Point(23, 0);
            this.labelTeamSchedTeamSched.Name = "labelTeamSchedTeamSched";
            this.labelTeamSchedTeamSched.Size = new System.Drawing.Size(253, 63);
            this.labelTeamSchedTeamSched.TabIndex = 0;
            this.labelTeamSchedTeamSched.Text = "Schedule";
            // 
            // buttonBackTeamSched
            // 
            this.buttonBackTeamSched.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBackTeamSched.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.buttonBackTeamSched.Location = new System.Drawing.Point(1043, 20);
            this.buttonBackTeamSched.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBackTeamSched.Name = "buttonBackTeamSched";
            this.buttonBackTeamSched.Size = new System.Drawing.Size(200, 100);
            this.buttonBackTeamSched.TabIndex = 5;
            this.buttonBackTeamSched.Text = "Back";
            this.buttonBackTeamSched.UseVisualStyleBackColor = true;
            this.buttonBackTeamSched.Click += new System.EventHandler(this.buttonBackTeamSched_Click);
            // 
            // labelCurrentDayTeamSched
            // 
            this.labelCurrentDayTeamSched.AutoSize = true;
            this.labelCurrentDayTeamSched.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelCurrentDayTeamSched.Location = new System.Drawing.Point(23, 120);
            this.labelCurrentDayTeamSched.Name = "labelCurrentDayTeamSched";
            this.labelCurrentDayTeamSched.Size = new System.Drawing.Size(235, 44);
            this.labelCurrentDayTeamSched.TabIndex = 7;
            this.labelCurrentDayTeamSched.Text = "Current Day:";
            // 
            // panelDateSched
            // 
            this.panelDateSched.AutoScroll = true;
            this.panelDateSched.AutoSize = true;
            this.panelDateSched.Controls.Add(this.tableLayoutPanelADateSched);
            this.panelDateSched.Controls.Add(this.tableLayoutPanelHeaderDateSched);
            this.panelDateSched.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDateSched.Location = new System.Drawing.Point(0, 24);
            this.panelDateSched.Margin = new System.Windows.Forms.Padding(0);
            this.panelDateSched.Name = "panelDateSched";
            this.panelDateSched.Size = new System.Drawing.Size(1286, 554);
            this.panelDateSched.TabIndex = 11;
            // 
            // tableLayoutPanelADateSched
            // 
            this.tableLayoutPanelADateSched.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelADateSched.ColumnCount = 3;
            this.tableLayoutPanelADateSched.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelADateSched.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1144F));
            this.tableLayoutPanelADateSched.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelADateSched.Controls.Add(this.dataGridViewDateSchedDateSched, 1, 0);
            this.tableLayoutPanelADateSched.Location = new System.Drawing.Point(3, 207);
            this.tableLayoutPanelADateSched.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tableLayoutPanelADateSched.Name = "tableLayoutPanelADateSched";
            this.tableLayoutPanelADateSched.RowCount = 1;
            this.tableLayoutPanelADateSched.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanelADateSched.Size = new System.Drawing.Size(1280, 300);
            this.tableLayoutPanelADateSched.TabIndex = 1;
            // 
            // dataGridViewDateSchedDateSched
            // 
            this.dataGridViewDateSchedDateSched.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDateSchedDateSched.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDateSchedDateSched.Location = new System.Drawing.Point(71, 3);
            this.dataGridViewDateSchedDateSched.Name = "dataGridViewDateSchedDateSched";
            this.dataGridViewDateSchedDateSched.Size = new System.Drawing.Size(1138, 150);
            this.dataGridViewDateSchedDateSched.TabIndex = 0;
            this.dataGridViewDateSchedDateSched.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDateSchedDateSched_CellContentClick);
            // 
            // tableLayoutPanelHeaderDateSched
            // 
            this.tableLayoutPanelHeaderDateSched.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelHeaderDateSched.ColumnCount = 5;
            this.tableLayoutPanelHeaderDateSched.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelHeaderDateSched.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelHeaderDateSched.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelHeaderDateSched.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelHeaderDateSched.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelHeaderDateSched.Controls.Add(this.labelDateSchedDateSched, 1, 0);
            this.tableLayoutPanelHeaderDateSched.Controls.Add(this.buttonBackDateSched, 3, 0);
            this.tableLayoutPanelHeaderDateSched.Controls.Add(this.labelCurrentDayDateSched, 1, 1);
            this.tableLayoutPanelHeaderDateSched.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelHeaderDateSched.Name = "tableLayoutPanelHeaderDateSched";
            this.tableLayoutPanelHeaderDateSched.RowCount = 2;
            this.tableLayoutPanelHeaderDateSched.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanelHeaderDateSched.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanelHeaderDateSched.Size = new System.Drawing.Size(1280, 184);
            this.tableLayoutPanelHeaderDateSched.TabIndex = 0;
            // 
            // labelDateSchedDateSched
            // 
            this.labelDateSchedDateSched.AutoSize = true;
            this.labelDateSchedDateSched.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.labelDateSchedDateSched.Location = new System.Drawing.Point(23, 0);
            this.labelDateSchedDateSched.Name = "labelDateSchedDateSched";
            this.labelDateSchedDateSched.Size = new System.Drawing.Size(253, 63);
            this.labelDateSchedDateSched.TabIndex = 0;
            this.labelDateSchedDateSched.Text = "Schedule";
            // 
            // buttonBackDateSched
            // 
            this.buttonBackDateSched.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBackDateSched.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.buttonBackDateSched.Location = new System.Drawing.Point(1060, 20);
            this.buttonBackDateSched.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBackDateSched.Name = "buttonBackDateSched";
            this.buttonBackDateSched.Size = new System.Drawing.Size(200, 100);
            this.buttonBackDateSched.TabIndex = 5;
            this.buttonBackDateSched.Text = "Back";
            this.buttonBackDateSched.UseVisualStyleBackColor = true;
            this.buttonBackDateSched.Click += new System.EventHandler(this.buttonBackDateSched_Click);
            // 
            // labelCurrentDayDateSched
            // 
            this.labelCurrentDayDateSched.AutoSize = true;
            this.labelCurrentDayDateSched.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelCurrentDayDateSched.Location = new System.Drawing.Point(23, 120);
            this.labelCurrentDayDateSched.Name = "labelCurrentDayDateSched";
            this.labelCurrentDayDateSched.Size = new System.Drawing.Size(235, 44);
            this.labelCurrentDayDateSched.TabIndex = 7;
            this.labelCurrentDayDateSched.Text = "Current Day:";
            // 
            // panelStand
            // 
            this.panelStand.AutoScroll = true;
            this.panelStand.AutoSize = true;
            this.panelStand.Controls.Add(this.tableLayoutPanelAStand);
            this.panelStand.Controls.Add(this.tableLayoutPanelBStand);
            this.panelStand.Controls.Add(this.tableLayoutPanelHeaderStand);
            this.panelStand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStand.Location = new System.Drawing.Point(0, 24);
            this.panelStand.Margin = new System.Windows.Forms.Padding(0);
            this.panelStand.Name = "panelStand";
            this.panelStand.Size = new System.Drawing.Size(1286, 554);
            this.panelStand.TabIndex = 12;
            // 
            // tableLayoutPanelAStand
            // 
            this.tableLayoutPanelAStand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelAStand.ColumnCount = 7;
            this.tableLayoutPanelAStand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAStand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelAStand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelAStand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelAStand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelAStand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelAStand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAStand.Controls.Add(this.comboBoxConferencesStand, 3, 0);
            this.tableLayoutPanelAStand.Controls.Add(this.labelGoToConferenceStand, 1, 0);
            this.tableLayoutPanelAStand.Controls.Add(this.buttonGoStand, 5, 0);
            this.tableLayoutPanelAStand.Location = new System.Drawing.Point(3, 207);
            this.tableLayoutPanelAStand.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.tableLayoutPanelAStand.Name = "tableLayoutPanelAStand";
            this.tableLayoutPanelAStand.RowCount = 1;
            this.tableLayoutPanelAStand.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanelAStand.Size = new System.Drawing.Size(1263, 64);
            this.tableLayoutPanelAStand.TabIndex = 3;
            // 
            // comboBoxConferencesStand
            // 
            this.comboBoxConferencesStand.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.comboBoxConferencesStand.FormattingEnabled = true;
            this.comboBoxConferencesStand.Location = new System.Drawing.Point(514, 3);
            this.comboBoxConferencesStand.Name = "comboBoxConferencesStand";
            this.comboBoxConferencesStand.Size = new System.Drawing.Size(300, 45);
            this.comboBoxConferencesStand.TabIndex = 15;
            // 
            // labelGoToConferenceStand
            // 
            this.labelGoToConferenceStand.AutoSize = true;
            this.labelGoToConferenceStand.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelGoToConferenceStand.Location = new System.Drawing.Point(157, 0);
            this.labelGoToConferenceStand.Name = "labelGoToConferenceStand";
            this.labelGoToConferenceStand.Size = new System.Drawing.Size(331, 44);
            this.labelGoToConferenceStand.TabIndex = 10;
            this.labelGoToConferenceStand.Text = "Go To Conference";
            // 
            // buttonGoStand
            // 
            this.buttonGoStand.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGoStand.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.buttonGoStand.Location = new System.Drawing.Point(837, 0);
            this.buttonGoStand.Margin = new System.Windows.Forms.Padding(0);
            this.buttonGoStand.Name = "buttonGoStand";
            this.buttonGoStand.Size = new System.Drawing.Size(271, 64);
            this.buttonGoStand.TabIndex = 16;
            this.buttonGoStand.Text = "Go";
            this.buttonGoStand.UseVisualStyleBackColor = true;
            this.buttonGoStand.Click += new System.EventHandler(this.buttonGoStand_Click);
            // 
            // tableLayoutPanelBStand
            // 
            this.tableLayoutPanelBStand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelBStand.AutoSize = true;
            this.tableLayoutPanelBStand.ColumnCount = 3;
            this.tableLayoutPanelBStand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBStand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1144F));
            this.tableLayoutPanelBStand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBStand.Controls.Add(this.labelConference1Stand, 1, 0);
            this.tableLayoutPanelBStand.Controls.Add(this.dataGridViewConference1Stand, 1, 1);
            this.tableLayoutPanelBStand.Controls.Add(this.labelConference2Stand, 1, 2);
            this.tableLayoutPanelBStand.Controls.Add(this.dataGridViewConference2Stand, 1, 3);
            this.tableLayoutPanelBStand.Controls.Add(this.labelConference3Stand, 1, 4);
            this.tableLayoutPanelBStand.Controls.Add(this.dataGridViewConference3Stand, 1, 5);
            this.tableLayoutPanelBStand.Controls.Add(this.labelConference4Stand, 1, 6);
            this.tableLayoutPanelBStand.Controls.Add(this.dataGridViewConference4Stand, 1, 7);
            this.tableLayoutPanelBStand.Controls.Add(this.labelConference5Stand, 1, 8);
            this.tableLayoutPanelBStand.Controls.Add(this.dataGridViewConference5Stand, 1, 9);
            this.tableLayoutPanelBStand.Controls.Add(this.labelConference6Stand, 1, 10);
            this.tableLayoutPanelBStand.Controls.Add(this.dataGridViewConference6Stand, 1, 11);
            this.tableLayoutPanelBStand.Controls.Add(this.labelConference7Stand, 1, 12);
            this.tableLayoutPanelBStand.Controls.Add(this.dataGridViewConference7Stand, 1, 13);
            this.tableLayoutPanelBStand.Controls.Add(this.labelConference8Stand, 1, 14);
            this.tableLayoutPanelBStand.Controls.Add(this.dataGridViewConference8Stand, 1, 15);
            this.tableLayoutPanelBStand.Controls.Add(this.labelConference9Stand, 1, 16);
            this.tableLayoutPanelBStand.Controls.Add(this.dataGridViewConference9Stand, 1, 17);
            this.tableLayoutPanelBStand.Controls.Add(this.labelConference10Stand, 1, 18);
            this.tableLayoutPanelBStand.Controls.Add(this.dataGridViewConference10Stand, 1, 19);
            this.tableLayoutPanelBStand.Controls.Add(this.labelConference11Stand, 1, 20);
            this.tableLayoutPanelBStand.Controls.Add(this.dataGridViewConference11Stand, 1, 21);
            this.tableLayoutPanelBStand.Controls.Add(this.labelConference12Stand, 1, 22);
            this.tableLayoutPanelBStand.Controls.Add(this.dataGridViewConference12Stand, 1, 23);
            this.tableLayoutPanelBStand.Controls.Add(this.labelConference13Stand, 1, 24);
            this.tableLayoutPanelBStand.Controls.Add(this.dataGridViewConference13Stand, 1, 25);
            this.tableLayoutPanelBStand.Controls.Add(this.labelConference14Stand, 1, 26);
            this.tableLayoutPanelBStand.Controls.Add(this.dataGridViewConference14Stand, 1, 27);
            this.tableLayoutPanelBStand.Controls.Add(this.labelConference15Stand, 1, 28);
            this.tableLayoutPanelBStand.Controls.Add(this.dataGridViewConference15Stand, 1, 29);
            this.tableLayoutPanelBStand.Controls.Add(this.labelConference16Stand, 1, 30);
            this.tableLayoutPanelBStand.Controls.Add(this.dataGridViewConference16Stand, 1, 31);
            this.tableLayoutPanelBStand.Controls.Add(this.labelConference17Stand, 1, 32);
            this.tableLayoutPanelBStand.Controls.Add(this.dataGridViewConference17Stand, 1, 33);
            this.tableLayoutPanelBStand.Controls.Add(this.labelConference18Stand, 1, 34);
            this.tableLayoutPanelBStand.Controls.Add(this.dataGridViewConference18Stand, 1, 35);
            this.tableLayoutPanelBStand.Controls.Add(this.labelConference19Stand, 1, 36);
            this.tableLayoutPanelBStand.Controls.Add(this.dataGridViewConference19Stand, 1, 37);
            this.tableLayoutPanelBStand.Controls.Add(this.labelConference20Stand, 1, 38);
            this.tableLayoutPanelBStand.Controls.Add(this.dataGridViewConference20Stand, 1, 39);
            this.tableLayoutPanelBStand.Controls.Add(this.labelConference21Stand, 1, 40);
            this.tableLayoutPanelBStand.Controls.Add(this.dataGridViewConference21Stand, 1, 41);
            this.tableLayoutPanelBStand.Controls.Add(this.labelConference22Stand, 1, 42);
            this.tableLayoutPanelBStand.Controls.Add(this.dataGridViewConference22Stand, 1, 43);
            this.tableLayoutPanelBStand.Controls.Add(this.labelConference23Stand, 1, 44);
            this.tableLayoutPanelBStand.Controls.Add(this.dataGridViewConference23Stand, 1, 45);
            this.tableLayoutPanelBStand.Controls.Add(this.labelConference24Stand, 1, 46);
            this.tableLayoutPanelBStand.Controls.Add(this.dataGridViewConference24Stand, 1, 47);
            this.tableLayoutPanelBStand.Controls.Add(this.labelConference25Stand, 1, 48);
            this.tableLayoutPanelBStand.Controls.Add(this.dataGridViewConference25Stand, 1, 49);
            this.tableLayoutPanelBStand.Controls.Add(this.labelConference26Stand, 1, 50);
            this.tableLayoutPanelBStand.Controls.Add(this.dataGridViewConference26Stand, 1, 51);
            this.tableLayoutPanelBStand.Controls.Add(this.labelConference27Stand, 1, 52);
            this.tableLayoutPanelBStand.Controls.Add(this.dataGridViewConference27Stand, 1, 53);
            this.tableLayoutPanelBStand.Controls.Add(this.labelConference28Stand, 1, 54);
            this.tableLayoutPanelBStand.Controls.Add(this.dataGridViewConference28Stand, 1, 55);
            this.tableLayoutPanelBStand.Controls.Add(this.labelConference29Stand, 1, 56);
            this.tableLayoutPanelBStand.Controls.Add(this.dataGridViewConference29Stand, 1, 57);
            this.tableLayoutPanelBStand.Controls.Add(this.labelConference30Stand, 1, 58);
            this.tableLayoutPanelBStand.Controls.Add(this.dataGridViewConference30Stand, 1, 59);
            this.tableLayoutPanelBStand.Controls.Add(this.labelConference31Stand, 1, 60);
            this.tableLayoutPanelBStand.Controls.Add(this.dataGridViewConference31Stand, 1, 61);
            this.tableLayoutPanelBStand.Controls.Add(this.labelConference32Stand, 1, 62);
            this.tableLayoutPanelBStand.Controls.Add(this.dataGridViewConference32Stand, 1, 63);
            this.tableLayoutPanelBStand.Location = new System.Drawing.Point(3, 291);
            this.tableLayoutPanelBStand.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tableLayoutPanelBStand.Name = "tableLayoutPanelBStand";
            this.tableLayoutPanelBStand.RowCount = 65;
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBStand.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelBStand.Size = new System.Drawing.Size(1263, 21908);
            this.tableLayoutPanelBStand.TabIndex = 1;
            // 
            // labelConference1Stand
            // 
            this.labelConference1Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConference1Stand.AutoSize = true;
            this.labelConference1Stand.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelConference1Stand.Location = new System.Drawing.Point(62, 10);
            this.labelConference1Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.labelConference1Stand.Name = "labelConference1Stand";
            this.labelConference1Stand.Size = new System.Drawing.Size(1138, 44);
            this.labelConference1Stand.TabIndex = 11;
            this.labelConference1Stand.Text = "America East Conference";
            this.labelConference1Stand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewConference1Stand
            // 
            this.dataGridViewConference1Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewConference1Stand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConference1Stand.Location = new System.Drawing.Point(62, 74);
            this.dataGridViewConference1Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.dataGridViewConference1Stand.Name = "dataGridViewConference1Stand";
            this.dataGridViewConference1Stand.Size = new System.Drawing.Size(1138, 600);
            this.dataGridViewConference1Stand.TabIndex = 0;
            this.dataGridViewConference1Stand.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConference1Stand_CellContentClick);
            // 
            // labelConference2Stand
            // 
            this.labelConference2Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConference2Stand.AutoSize = true;
            this.labelConference2Stand.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelConference2Stand.Location = new System.Drawing.Point(62, 694);
            this.labelConference2Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.labelConference2Stand.Name = "labelConference2Stand";
            this.labelConference2Stand.Size = new System.Drawing.Size(1138, 44);
            this.labelConference2Stand.TabIndex = 12;
            this.labelConference2Stand.Text = "American Athletic Conference";
            this.labelConference2Stand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewConference2Stand
            // 
            this.dataGridViewConference2Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewConference2Stand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConference2Stand.Location = new System.Drawing.Point(62, 758);
            this.dataGridViewConference2Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.dataGridViewConference2Stand.Name = "dataGridViewConference2Stand";
            this.dataGridViewConference2Stand.Size = new System.Drawing.Size(1138, 600);
            this.dataGridViewConference2Stand.TabIndex = 16;
            this.dataGridViewConference2Stand.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConference2Stand_CellContentClick);
            // 
            // labelConference3Stand
            // 
            this.labelConference3Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConference3Stand.AutoSize = true;
            this.labelConference3Stand.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelConference3Stand.Location = new System.Drawing.Point(62, 1378);
            this.labelConference3Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.labelConference3Stand.Name = "labelConference3Stand";
            this.labelConference3Stand.Size = new System.Drawing.Size(1138, 44);
            this.labelConference3Stand.TabIndex = 17;
            this.labelConference3Stand.Text = "Atlantic 10 Conference";
            this.labelConference3Stand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewConference3Stand
            // 
            this.dataGridViewConference3Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewConference3Stand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConference3Stand.Location = new System.Drawing.Point(62, 1442);
            this.dataGridViewConference3Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.dataGridViewConference3Stand.Name = "dataGridViewConference3Stand";
            this.dataGridViewConference3Stand.Size = new System.Drawing.Size(1138, 600);
            this.dataGridViewConference3Stand.TabIndex = 18;
            this.dataGridViewConference3Stand.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConference3Stand_CellContentClick);
            // 
            // labelConference4Stand
            // 
            this.labelConference4Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConference4Stand.AutoSize = true;
            this.labelConference4Stand.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelConference4Stand.Location = new System.Drawing.Point(62, 2062);
            this.labelConference4Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.labelConference4Stand.Name = "labelConference4Stand";
            this.labelConference4Stand.Size = new System.Drawing.Size(1138, 44);
            this.labelConference4Stand.TabIndex = 18;
            this.labelConference4Stand.Text = "Atlantic Coast Conference";
            this.labelConference4Stand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewConference4Stand
            // 
            this.dataGridViewConference4Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewConference4Stand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConference4Stand.Location = new System.Drawing.Point(62, 2126);
            this.dataGridViewConference4Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.dataGridViewConference4Stand.Name = "dataGridViewConference4Stand";
            this.dataGridViewConference4Stand.Size = new System.Drawing.Size(1138, 600);
            this.dataGridViewConference4Stand.TabIndex = 19;
            this.dataGridViewConference4Stand.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConference4Stand_CellContentClick);
            // 
            // labelConference5Stand
            // 
            this.labelConference5Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConference5Stand.AutoSize = true;
            this.labelConference5Stand.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelConference5Stand.Location = new System.Drawing.Point(62, 2746);
            this.labelConference5Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.labelConference5Stand.Name = "labelConference5Stand";
            this.labelConference5Stand.Size = new System.Drawing.Size(1138, 44);
            this.labelConference5Stand.TabIndex = 19;
            this.labelConference5Stand.Text = "Atlantic Sun Conference";
            this.labelConference5Stand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewConference5Stand
            // 
            this.dataGridViewConference5Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewConference5Stand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConference5Stand.Location = new System.Drawing.Point(62, 2810);
            this.dataGridViewConference5Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.dataGridViewConference5Stand.Name = "dataGridViewConference5Stand";
            this.dataGridViewConference5Stand.Size = new System.Drawing.Size(1138, 600);
            this.dataGridViewConference5Stand.TabIndex = 22;
            this.dataGridViewConference5Stand.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConference5Stand_CellContentClick);
            // 
            // labelConference6Stand
            // 
            this.labelConference6Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConference6Stand.AutoSize = true;
            this.labelConference6Stand.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelConference6Stand.Location = new System.Drawing.Point(62, 3430);
            this.labelConference6Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.labelConference6Stand.Name = "labelConference6Stand";
            this.labelConference6Stand.Size = new System.Drawing.Size(1138, 44);
            this.labelConference6Stand.TabIndex = 20;
            this.labelConference6Stand.Text = "Big 12 Conference";
            this.labelConference6Stand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewConference6Stand
            // 
            this.dataGridViewConference6Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewConference6Stand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConference6Stand.Location = new System.Drawing.Point(62, 3494);
            this.dataGridViewConference6Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.dataGridViewConference6Stand.Name = "dataGridViewConference6Stand";
            this.dataGridViewConference6Stand.Size = new System.Drawing.Size(1138, 600);
            this.dataGridViewConference6Stand.TabIndex = 23;
            this.dataGridViewConference6Stand.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConference6Stand_CellContentClick);
            // 
            // labelConference7Stand
            // 
            this.labelConference7Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConference7Stand.AutoSize = true;
            this.labelConference7Stand.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelConference7Stand.Location = new System.Drawing.Point(62, 4114);
            this.labelConference7Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.labelConference7Stand.Name = "labelConference7Stand";
            this.labelConference7Stand.Size = new System.Drawing.Size(1138, 44);
            this.labelConference7Stand.TabIndex = 21;
            this.labelConference7Stand.Text = "Big East Conference";
            this.labelConference7Stand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewConference7Stand
            // 
            this.dataGridViewConference7Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewConference7Stand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConference7Stand.Location = new System.Drawing.Point(62, 4178);
            this.dataGridViewConference7Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.dataGridViewConference7Stand.Name = "dataGridViewConference7Stand";
            this.dataGridViewConference7Stand.Size = new System.Drawing.Size(1138, 600);
            this.dataGridViewConference7Stand.TabIndex = 24;
            this.dataGridViewConference7Stand.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConference7Stand_CellContentClick);
            // 
            // labelConference8Stand
            // 
            this.labelConference8Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConference8Stand.AutoSize = true;
            this.labelConference8Stand.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelConference8Stand.Location = new System.Drawing.Point(62, 4798);
            this.labelConference8Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.labelConference8Stand.Name = "labelConference8Stand";
            this.labelConference8Stand.Size = new System.Drawing.Size(1138, 44);
            this.labelConference8Stand.TabIndex = 22;
            this.labelConference8Stand.Text = "Big Sky Conference";
            this.labelConference8Stand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewConference8Stand
            // 
            this.dataGridViewConference8Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewConference8Stand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConference8Stand.Location = new System.Drawing.Point(62, 4862);
            this.dataGridViewConference8Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.dataGridViewConference8Stand.Name = "dataGridViewConference8Stand";
            this.dataGridViewConference8Stand.Size = new System.Drawing.Size(1138, 600);
            this.dataGridViewConference8Stand.TabIndex = 25;
            this.dataGridViewConference8Stand.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConference8Stand_CellContentClick);
            // 
            // labelConference9Stand
            // 
            this.labelConference9Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConference9Stand.AutoSize = true;
            this.labelConference9Stand.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelConference9Stand.Location = new System.Drawing.Point(62, 5482);
            this.labelConference9Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.labelConference9Stand.Name = "labelConference9Stand";
            this.labelConference9Stand.Size = new System.Drawing.Size(1138, 44);
            this.labelConference9Stand.TabIndex = 23;
            this.labelConference9Stand.Text = "Big South Conference";
            this.labelConference9Stand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewConference9Stand
            // 
            this.dataGridViewConference9Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewConference9Stand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConference9Stand.Location = new System.Drawing.Point(62, 5546);
            this.dataGridViewConference9Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.dataGridViewConference9Stand.Name = "dataGridViewConference9Stand";
            this.dataGridViewConference9Stand.Size = new System.Drawing.Size(1138, 600);
            this.dataGridViewConference9Stand.TabIndex = 26;
            this.dataGridViewConference9Stand.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConference9Stand_CellContentClick);
            // 
            // labelConference10Stand
            // 
            this.labelConference10Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConference10Stand.AutoSize = true;
            this.labelConference10Stand.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelConference10Stand.Location = new System.Drawing.Point(62, 6166);
            this.labelConference10Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.labelConference10Stand.Name = "labelConference10Stand";
            this.labelConference10Stand.Size = new System.Drawing.Size(1138, 44);
            this.labelConference10Stand.TabIndex = 24;
            this.labelConference10Stand.Text = "Big Ten Conference";
            this.labelConference10Stand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewConference10Stand
            // 
            this.dataGridViewConference10Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewConference10Stand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConference10Stand.Location = new System.Drawing.Point(62, 6230);
            this.dataGridViewConference10Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.dataGridViewConference10Stand.Name = "dataGridViewConference10Stand";
            this.dataGridViewConference10Stand.Size = new System.Drawing.Size(1138, 600);
            this.dataGridViewConference10Stand.TabIndex = 27;
            this.dataGridViewConference10Stand.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConference10Stand_CellContentClick);
            // 
            // labelConference11Stand
            // 
            this.labelConference11Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConference11Stand.AutoSize = true;
            this.labelConference11Stand.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelConference11Stand.Location = new System.Drawing.Point(62, 6850);
            this.labelConference11Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.labelConference11Stand.Name = "labelConference11Stand";
            this.labelConference11Stand.Size = new System.Drawing.Size(1138, 44);
            this.labelConference11Stand.TabIndex = 25;
            this.labelConference11Stand.Text = "Big West Conference";
            this.labelConference11Stand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewConference11Stand
            // 
            this.dataGridViewConference11Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewConference11Stand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConference11Stand.Location = new System.Drawing.Point(62, 6914);
            this.dataGridViewConference11Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.dataGridViewConference11Stand.Name = "dataGridViewConference11Stand";
            this.dataGridViewConference11Stand.Size = new System.Drawing.Size(1138, 600);
            this.dataGridViewConference11Stand.TabIndex = 28;
            this.dataGridViewConference11Stand.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConference11Stand_CellContentClick);
            // 
            // labelConference12Stand
            // 
            this.labelConference12Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConference12Stand.AutoSize = true;
            this.labelConference12Stand.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelConference12Stand.Location = new System.Drawing.Point(62, 7534);
            this.labelConference12Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.labelConference12Stand.Name = "labelConference12Stand";
            this.labelConference12Stand.Size = new System.Drawing.Size(1138, 44);
            this.labelConference12Stand.TabIndex = 26;
            this.labelConference12Stand.Text = "Colonial Athletic Association";
            this.labelConference12Stand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewConference12Stand
            // 
            this.dataGridViewConference12Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewConference12Stand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConference12Stand.Location = new System.Drawing.Point(62, 7598);
            this.dataGridViewConference12Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.dataGridViewConference12Stand.Name = "dataGridViewConference12Stand";
            this.dataGridViewConference12Stand.Size = new System.Drawing.Size(1138, 600);
            this.dataGridViewConference12Stand.TabIndex = 29;
            this.dataGridViewConference12Stand.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConference12Stand_CellContentClick);
            // 
            // labelConference13Stand
            // 
            this.labelConference13Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConference13Stand.AutoSize = true;
            this.labelConference13Stand.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelConference13Stand.Location = new System.Drawing.Point(62, 8218);
            this.labelConference13Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.labelConference13Stand.Name = "labelConference13Stand";
            this.labelConference13Stand.Size = new System.Drawing.Size(1138, 44);
            this.labelConference13Stand.TabIndex = 27;
            this.labelConference13Stand.Text = "Conference USA";
            this.labelConference13Stand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewConference13Stand
            // 
            this.dataGridViewConference13Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewConference13Stand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConference13Stand.Location = new System.Drawing.Point(62, 8282);
            this.dataGridViewConference13Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.dataGridViewConference13Stand.Name = "dataGridViewConference13Stand";
            this.dataGridViewConference13Stand.Size = new System.Drawing.Size(1138, 600);
            this.dataGridViewConference13Stand.TabIndex = 30;
            this.dataGridViewConference13Stand.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConference13Stand_CellContentClick);
            // 
            // labelConference14Stand
            // 
            this.labelConference14Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConference14Stand.AutoSize = true;
            this.labelConference14Stand.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelConference14Stand.Location = new System.Drawing.Point(62, 8902);
            this.labelConference14Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.labelConference14Stand.Name = "labelConference14Stand";
            this.labelConference14Stand.Size = new System.Drawing.Size(1138, 44);
            this.labelConference14Stand.TabIndex = 28;
            this.labelConference14Stand.Text = "Horizon League";
            this.labelConference14Stand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewConference14Stand
            // 
            this.dataGridViewConference14Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewConference14Stand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConference14Stand.Location = new System.Drawing.Point(62, 8966);
            this.dataGridViewConference14Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.dataGridViewConference14Stand.Name = "dataGridViewConference14Stand";
            this.dataGridViewConference14Stand.Size = new System.Drawing.Size(1138, 600);
            this.dataGridViewConference14Stand.TabIndex = 33;
            this.dataGridViewConference14Stand.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConference14Stand_CellContentClick);
            // 
            // labelConference15Stand
            // 
            this.labelConference15Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConference15Stand.AutoSize = true;
            this.labelConference15Stand.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelConference15Stand.Location = new System.Drawing.Point(62, 9586);
            this.labelConference15Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.labelConference15Stand.Name = "labelConference15Stand";
            this.labelConference15Stand.Size = new System.Drawing.Size(1138, 44);
            this.labelConference15Stand.TabIndex = 29;
            this.labelConference15Stand.Text = "Ivy League";
            this.labelConference15Stand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewConference15Stand
            // 
            this.dataGridViewConference15Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewConference15Stand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConference15Stand.Location = new System.Drawing.Point(62, 9650);
            this.dataGridViewConference15Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.dataGridViewConference15Stand.Name = "dataGridViewConference15Stand";
            this.dataGridViewConference15Stand.Size = new System.Drawing.Size(1138, 600);
            this.dataGridViewConference15Stand.TabIndex = 34;
            this.dataGridViewConference15Stand.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConference15Stand_CellContentClick);
            // 
            // labelConference16Stand
            // 
            this.labelConference16Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConference16Stand.AutoSize = true;
            this.labelConference16Stand.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelConference16Stand.Location = new System.Drawing.Point(62, 10270);
            this.labelConference16Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.labelConference16Stand.Name = "labelConference16Stand";
            this.labelConference16Stand.Size = new System.Drawing.Size(1138, 44);
            this.labelConference16Stand.TabIndex = 30;
            this.labelConference16Stand.Text = "Metro Atlantic Athletic Conference";
            this.labelConference16Stand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewConference16Stand
            // 
            this.dataGridViewConference16Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewConference16Stand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConference16Stand.Location = new System.Drawing.Point(62, 10334);
            this.dataGridViewConference16Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.dataGridViewConference16Stand.Name = "dataGridViewConference16Stand";
            this.dataGridViewConference16Stand.Size = new System.Drawing.Size(1138, 600);
            this.dataGridViewConference16Stand.TabIndex = 35;
            this.dataGridViewConference16Stand.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConference16Stand_CellContentClick);
            // 
            // labelConference17Stand
            // 
            this.labelConference17Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConference17Stand.AutoSize = true;
            this.labelConference17Stand.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelConference17Stand.Location = new System.Drawing.Point(62, 10954);
            this.labelConference17Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.labelConference17Stand.Name = "labelConference17Stand";
            this.labelConference17Stand.Size = new System.Drawing.Size(1138, 44);
            this.labelConference17Stand.TabIndex = 31;
            this.labelConference17Stand.Text = "Mid-American Conference";
            this.labelConference17Stand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewConference17Stand
            // 
            this.dataGridViewConference17Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewConference17Stand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConference17Stand.Location = new System.Drawing.Point(62, 11018);
            this.dataGridViewConference17Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.dataGridViewConference17Stand.Name = "dataGridViewConference17Stand";
            this.dataGridViewConference17Stand.Size = new System.Drawing.Size(1138, 600);
            this.dataGridViewConference17Stand.TabIndex = 36;
            this.dataGridViewConference17Stand.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConference17Stand_CellContentClick);
            // 
            // labelConference18Stand
            // 
            this.labelConference18Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConference18Stand.AutoSize = true;
            this.labelConference18Stand.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelConference18Stand.Location = new System.Drawing.Point(62, 11638);
            this.labelConference18Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.labelConference18Stand.Name = "labelConference18Stand";
            this.labelConference18Stand.Size = new System.Drawing.Size(1138, 44);
            this.labelConference18Stand.TabIndex = 32;
            this.labelConference18Stand.Text = "Mid-Eastern Athletic Conference";
            this.labelConference18Stand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewConference18Stand
            // 
            this.dataGridViewConference18Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewConference18Stand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConference18Stand.Location = new System.Drawing.Point(62, 11702);
            this.dataGridViewConference18Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.dataGridViewConference18Stand.Name = "dataGridViewConference18Stand";
            this.dataGridViewConference18Stand.Size = new System.Drawing.Size(1138, 600);
            this.dataGridViewConference18Stand.TabIndex = 37;
            this.dataGridViewConference18Stand.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConference18Stand_CellContentClick);
            // 
            // labelConference19Stand
            // 
            this.labelConference19Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConference19Stand.AutoSize = true;
            this.labelConference19Stand.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelConference19Stand.Location = new System.Drawing.Point(62, 12322);
            this.labelConference19Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.labelConference19Stand.Name = "labelConference19Stand";
            this.labelConference19Stand.Size = new System.Drawing.Size(1138, 44);
            this.labelConference19Stand.TabIndex = 33;
            this.labelConference19Stand.Text = "Missouri Valley Conference";
            this.labelConference19Stand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewConference19Stand
            // 
            this.dataGridViewConference19Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewConference19Stand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConference19Stand.Location = new System.Drawing.Point(62, 12386);
            this.dataGridViewConference19Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.dataGridViewConference19Stand.Name = "dataGridViewConference19Stand";
            this.dataGridViewConference19Stand.Size = new System.Drawing.Size(1138, 600);
            this.dataGridViewConference19Stand.TabIndex = 38;
            this.dataGridViewConference19Stand.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConference19Stand_CellContentClick);
            // 
            // labelConference20Stand
            // 
            this.labelConference20Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConference20Stand.AutoSize = true;
            this.labelConference20Stand.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelConference20Stand.Location = new System.Drawing.Point(62, 13006);
            this.labelConference20Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.labelConference20Stand.Name = "labelConference20Stand";
            this.labelConference20Stand.Size = new System.Drawing.Size(1138, 44);
            this.labelConference20Stand.TabIndex = 34;
            this.labelConference20Stand.Text = "Mountain West Conference";
            this.labelConference20Stand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewConference20Stand
            // 
            this.dataGridViewConference20Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewConference20Stand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConference20Stand.Location = new System.Drawing.Point(62, 13070);
            this.dataGridViewConference20Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.dataGridViewConference20Stand.Name = "dataGridViewConference20Stand";
            this.dataGridViewConference20Stand.Size = new System.Drawing.Size(1138, 600);
            this.dataGridViewConference20Stand.TabIndex = 39;
            this.dataGridViewConference20Stand.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConference20Stand_CellContentClick);
            // 
            // labelConference21Stand
            // 
            this.labelConference21Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConference21Stand.AutoSize = true;
            this.labelConference21Stand.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelConference21Stand.Location = new System.Drawing.Point(62, 13690);
            this.labelConference21Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.labelConference21Stand.Name = "labelConference21Stand";
            this.labelConference21Stand.Size = new System.Drawing.Size(1138, 44);
            this.labelConference21Stand.TabIndex = 35;
            this.labelConference21Stand.Text = "Northeast Conference";
            this.labelConference21Stand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewConference21Stand
            // 
            this.dataGridViewConference21Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewConference21Stand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConference21Stand.Location = new System.Drawing.Point(62, 13754);
            this.dataGridViewConference21Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.dataGridViewConference21Stand.Name = "dataGridViewConference21Stand";
            this.dataGridViewConference21Stand.Size = new System.Drawing.Size(1138, 600);
            this.dataGridViewConference21Stand.TabIndex = 40;
            this.dataGridViewConference21Stand.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConference21Stand_CellContentClick);
            // 
            // labelConference22Stand
            // 
            this.labelConference22Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConference22Stand.AutoSize = true;
            this.labelConference22Stand.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelConference22Stand.Location = new System.Drawing.Point(62, 14374);
            this.labelConference22Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.labelConference22Stand.Name = "labelConference22Stand";
            this.labelConference22Stand.Size = new System.Drawing.Size(1138, 44);
            this.labelConference22Stand.TabIndex = 36;
            this.labelConference22Stand.Text = "Ohio Valley Conference";
            this.labelConference22Stand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewConference22Stand
            // 
            this.dataGridViewConference22Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewConference22Stand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConference22Stand.Location = new System.Drawing.Point(62, 14438);
            this.dataGridViewConference22Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.dataGridViewConference22Stand.Name = "dataGridViewConference22Stand";
            this.dataGridViewConference22Stand.Size = new System.Drawing.Size(1138, 600);
            this.dataGridViewConference22Stand.TabIndex = 41;
            this.dataGridViewConference22Stand.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConference22Stand_CellContentClick);
            // 
            // labelConference23Stand
            // 
            this.labelConference23Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConference23Stand.AutoSize = true;
            this.labelConference23Stand.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelConference23Stand.Location = new System.Drawing.Point(62, 15058);
            this.labelConference23Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.labelConference23Stand.Name = "labelConference23Stand";
            this.labelConference23Stand.Size = new System.Drawing.Size(1138, 44);
            this.labelConference23Stand.TabIndex = 37;
            this.labelConference23Stand.Text = "Pac-12 Conference";
            this.labelConference23Stand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewConference23Stand
            // 
            this.dataGridViewConference23Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewConference23Stand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConference23Stand.Location = new System.Drawing.Point(62, 15122);
            this.dataGridViewConference23Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.dataGridViewConference23Stand.Name = "dataGridViewConference23Stand";
            this.dataGridViewConference23Stand.Size = new System.Drawing.Size(1138, 600);
            this.dataGridViewConference23Stand.TabIndex = 42;
            this.dataGridViewConference23Stand.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConference23Stand_CellContentClick);
            // 
            // labelConference24Stand
            // 
            this.labelConference24Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConference24Stand.AutoSize = true;
            this.labelConference24Stand.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelConference24Stand.Location = new System.Drawing.Point(62, 15742);
            this.labelConference24Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.labelConference24Stand.Name = "labelConference24Stand";
            this.labelConference24Stand.Size = new System.Drawing.Size(1138, 44);
            this.labelConference24Stand.TabIndex = 12;
            this.labelConference24Stand.Text = "Patriot League";
            this.labelConference24Stand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewConference24Stand
            // 
            this.dataGridViewConference24Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewConference24Stand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConference24Stand.Location = new System.Drawing.Point(62, 15806);
            this.dataGridViewConference24Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.dataGridViewConference24Stand.Name = "dataGridViewConference24Stand";
            this.dataGridViewConference24Stand.Size = new System.Drawing.Size(1138, 600);
            this.dataGridViewConference24Stand.TabIndex = 17;
            this.dataGridViewConference24Stand.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConference24Stand_CellContentClick);
            // 
            // labelConference25Stand
            // 
            this.labelConference25Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConference25Stand.AutoSize = true;
            this.labelConference25Stand.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelConference25Stand.Location = new System.Drawing.Point(62, 16426);
            this.labelConference25Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.labelConference25Stand.Name = "labelConference25Stand";
            this.labelConference25Stand.Size = new System.Drawing.Size(1138, 44);
            this.labelConference25Stand.TabIndex = 13;
            this.labelConference25Stand.Text = "Southeastern Conference";
            this.labelConference25Stand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewConference25Stand
            // 
            this.dataGridViewConference25Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewConference25Stand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConference25Stand.Location = new System.Drawing.Point(62, 16490);
            this.dataGridViewConference25Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.dataGridViewConference25Stand.Name = "dataGridViewConference25Stand";
            this.dataGridViewConference25Stand.Size = new System.Drawing.Size(1138, 600);
            this.dataGridViewConference25Stand.TabIndex = 18;
            this.dataGridViewConference25Stand.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConference25Stand_CellContentClick);
            // 
            // labelConference26Stand
            // 
            this.labelConference26Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConference26Stand.AutoSize = true;
            this.labelConference26Stand.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelConference26Stand.Location = new System.Drawing.Point(62, 17110);
            this.labelConference26Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.labelConference26Stand.Name = "labelConference26Stand";
            this.labelConference26Stand.Size = new System.Drawing.Size(1138, 44);
            this.labelConference26Stand.TabIndex = 14;
            this.labelConference26Stand.Text = "Southern Conference";
            this.labelConference26Stand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewConference26Stand
            // 
            this.dataGridViewConference26Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewConference26Stand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConference26Stand.Location = new System.Drawing.Point(62, 17174);
            this.dataGridViewConference26Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.dataGridViewConference26Stand.Name = "dataGridViewConference26Stand";
            this.dataGridViewConference26Stand.Size = new System.Drawing.Size(1138, 600);
            this.dataGridViewConference26Stand.TabIndex = 19;
            this.dataGridViewConference26Stand.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConference26Stand_CellContentClick);
            // 
            // labelConference27Stand
            // 
            this.labelConference27Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConference27Stand.AutoSize = true;
            this.labelConference27Stand.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelConference27Stand.Location = new System.Drawing.Point(62, 17794);
            this.labelConference27Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.labelConference27Stand.Name = "labelConference27Stand";
            this.labelConference27Stand.Size = new System.Drawing.Size(1138, 44);
            this.labelConference27Stand.TabIndex = 15;
            this.labelConference27Stand.Text = "Southland Conference";
            this.labelConference27Stand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewConference27Stand
            // 
            this.dataGridViewConference27Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewConference27Stand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConference27Stand.Location = new System.Drawing.Point(62, 17858);
            this.dataGridViewConference27Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.dataGridViewConference27Stand.Name = "dataGridViewConference27Stand";
            this.dataGridViewConference27Stand.Size = new System.Drawing.Size(1138, 600);
            this.dataGridViewConference27Stand.TabIndex = 20;
            this.dataGridViewConference27Stand.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConference27Stand_CellContentClick);
            // 
            // labelConference28Stand
            // 
            this.labelConference28Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConference28Stand.AutoSize = true;
            this.labelConference28Stand.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelConference28Stand.Location = new System.Drawing.Point(62, 18478);
            this.labelConference28Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.labelConference28Stand.Name = "labelConference28Stand";
            this.labelConference28Stand.Size = new System.Drawing.Size(1138, 44);
            this.labelConference28Stand.TabIndex = 16;
            this.labelConference28Stand.Text = "Southwestern Athletic Conference";
            this.labelConference28Stand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewConference28Stand
            // 
            this.dataGridViewConference28Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewConference28Stand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConference28Stand.Location = new System.Drawing.Point(62, 18542);
            this.dataGridViewConference28Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.dataGridViewConference28Stand.Name = "dataGridViewConference28Stand";
            this.dataGridViewConference28Stand.Size = new System.Drawing.Size(1138, 600);
            this.dataGridViewConference28Stand.TabIndex = 21;
            this.dataGridViewConference28Stand.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConference28Stand_CellContentClick);
            // 
            // labelConference29Stand
            // 
            this.labelConference29Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConference29Stand.AutoSize = true;
            this.labelConference29Stand.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelConference29Stand.Location = new System.Drawing.Point(62, 19162);
            this.labelConference29Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.labelConference29Stand.Name = "labelConference29Stand";
            this.labelConference29Stand.Size = new System.Drawing.Size(1138, 44);
            this.labelConference29Stand.TabIndex = 12;
            this.labelConference29Stand.Text = "Summit League";
            this.labelConference29Stand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewConference29Stand
            // 
            this.dataGridViewConference29Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewConference29Stand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConference29Stand.Location = new System.Drawing.Point(62, 19226);
            this.dataGridViewConference29Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.dataGridViewConference29Stand.Name = "dataGridViewConference29Stand";
            this.dataGridViewConference29Stand.Size = new System.Drawing.Size(1138, 600);
            this.dataGridViewConference29Stand.TabIndex = 16;
            this.dataGridViewConference29Stand.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConference29Stand_CellContentClick);
            // 
            // labelConference30Stand
            // 
            this.labelConference30Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConference30Stand.AutoSize = true;
            this.labelConference30Stand.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelConference30Stand.Location = new System.Drawing.Point(62, 19846);
            this.labelConference30Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.labelConference30Stand.Name = "labelConference30Stand";
            this.labelConference30Stand.Size = new System.Drawing.Size(1138, 44);
            this.labelConference30Stand.TabIndex = 13;
            this.labelConference30Stand.Text = "Sun Belt Conference";
            this.labelConference30Stand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewConference30Stand
            // 
            this.dataGridViewConference30Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewConference30Stand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConference30Stand.Location = new System.Drawing.Point(62, 19910);
            this.dataGridViewConference30Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.dataGridViewConference30Stand.Name = "dataGridViewConference30Stand";
            this.dataGridViewConference30Stand.Size = new System.Drawing.Size(1138, 600);
            this.dataGridViewConference30Stand.TabIndex = 17;
            this.dataGridViewConference30Stand.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConference30Stand_CellContentClick);
            // 
            // labelConference31Stand
            // 
            this.labelConference31Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConference31Stand.AutoSize = true;
            this.labelConference31Stand.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelConference31Stand.Location = new System.Drawing.Point(62, 20530);
            this.labelConference31Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.labelConference31Stand.Name = "labelConference31Stand";
            this.labelConference31Stand.Size = new System.Drawing.Size(1138, 44);
            this.labelConference31Stand.TabIndex = 14;
            this.labelConference31Stand.Text = "West Coast Conference";
            this.labelConference31Stand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewConference31Stand
            // 
            this.dataGridViewConference31Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewConference31Stand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConference31Stand.Location = new System.Drawing.Point(62, 20594);
            this.dataGridViewConference31Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.dataGridViewConference31Stand.Name = "dataGridViewConference31Stand";
            this.dataGridViewConference31Stand.Size = new System.Drawing.Size(1138, 600);
            this.dataGridViewConference31Stand.TabIndex = 18;
            this.dataGridViewConference31Stand.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConference31Stand_CellContentClick);
            // 
            // labelConference32Stand
            // 
            this.labelConference32Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConference32Stand.AutoSize = true;
            this.labelConference32Stand.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelConference32Stand.Location = new System.Drawing.Point(62, 21214);
            this.labelConference32Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.labelConference32Stand.Name = "labelConference32Stand";
            this.labelConference32Stand.Size = new System.Drawing.Size(1138, 44);
            this.labelConference32Stand.TabIndex = 15;
            this.labelConference32Stand.Text = "Western Athletic Conference";
            this.labelConference32Stand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewConference32Stand
            // 
            this.dataGridViewConference32Stand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewConference32Stand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConference32Stand.Location = new System.Drawing.Point(62, 21278);
            this.dataGridViewConference32Stand.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.dataGridViewConference32Stand.Name = "dataGridViewConference32Stand";
            this.dataGridViewConference32Stand.Size = new System.Drawing.Size(1138, 600);
            this.dataGridViewConference32Stand.TabIndex = 1;
            this.dataGridViewConference32Stand.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConference32Stand_CellContentClick);
            // 
            // tableLayoutPanelHeaderStand
            // 
            this.tableLayoutPanelHeaderStand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelHeaderStand.ColumnCount = 5;
            this.tableLayoutPanelHeaderStand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelHeaderStand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelHeaderStand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelHeaderStand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelHeaderStand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelHeaderStand.Controls.Add(this.labelStandingsStand, 1, 0);
            this.tableLayoutPanelHeaderStand.Controls.Add(this.buttonBackStand, 3, 0);
            this.tableLayoutPanelHeaderStand.Controls.Add(this.labelCurrentDayStand, 1, 1);
            this.tableLayoutPanelHeaderStand.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelHeaderStand.Name = "tableLayoutPanelHeaderStand";
            this.tableLayoutPanelHeaderStand.RowCount = 2;
            this.tableLayoutPanelHeaderStand.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanelHeaderStand.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanelHeaderStand.Size = new System.Drawing.Size(1263, 184);
            this.tableLayoutPanelHeaderStand.TabIndex = 0;
            // 
            // labelStandingsStand
            // 
            this.labelStandingsStand.AutoSize = true;
            this.labelStandingsStand.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.labelStandingsStand.Location = new System.Drawing.Point(23, 0);
            this.labelStandingsStand.Name = "labelStandingsStand";
            this.labelStandingsStand.Size = new System.Drawing.Size(268, 63);
            this.labelStandingsStand.TabIndex = 0;
            this.labelStandingsStand.Text = "Standings";
            // 
            // buttonBackStand
            // 
            this.buttonBackStand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBackStand.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.buttonBackStand.Location = new System.Drawing.Point(1043, 20);
            this.buttonBackStand.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBackStand.Name = "buttonBackStand";
            this.buttonBackStand.Size = new System.Drawing.Size(200, 100);
            this.buttonBackStand.TabIndex = 5;
            this.buttonBackStand.Text = "Back";
            this.buttonBackStand.UseVisualStyleBackColor = true;
            this.buttonBackStand.Click += new System.EventHandler(this.buttonBackStand_Click);
            // 
            // labelCurrentDayStand
            // 
            this.labelCurrentDayStand.AutoSize = true;
            this.labelCurrentDayStand.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelCurrentDayStand.Location = new System.Drawing.Point(23, 120);
            this.labelCurrentDayStand.Name = "labelCurrentDayStand";
            this.labelCurrentDayStand.Size = new System.Drawing.Size(235, 44);
            this.labelCurrentDayStand.TabIndex = 7;
            this.labelCurrentDayStand.Text = "Current Day:";
            // 
            // panelTop25
            // 
            this.panelTop25.AutoScroll = true;
            this.panelTop25.AutoSize = true;
            this.panelTop25.Controls.Add(this.tableLayoutPanelATop25);
            this.panelTop25.Controls.Add(this.tableLayoutPanelHeaderTop25);
            this.panelTop25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTop25.Location = new System.Drawing.Point(0, 24);
            this.panelTop25.Margin = new System.Windows.Forms.Padding(0);
            this.panelTop25.Name = "panelTop25";
            this.panelTop25.Size = new System.Drawing.Size(1286, 554);
            this.panelTop25.TabIndex = 13;
            // 
            // tableLayoutPanelATop25
            // 
            this.tableLayoutPanelATop25.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelATop25.ColumnCount = 3;
            this.tableLayoutPanelATop25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelATop25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1144F));
            this.tableLayoutPanelATop25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelATop25.Controls.Add(this.dataGridViewTop25Top25, 1, 0);
            this.tableLayoutPanelATop25.Location = new System.Drawing.Point(3, 207);
            this.tableLayoutPanelATop25.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tableLayoutPanelATop25.Name = "tableLayoutPanelATop25";
            this.tableLayoutPanelATop25.RowCount = 1;
            this.tableLayoutPanelATop25.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanelATop25.Size = new System.Drawing.Size(1280, 300);
            this.tableLayoutPanelATop25.TabIndex = 1;
            // 
            // dataGridViewTop25Top25
            // 
            this.dataGridViewTop25Top25.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTop25Top25.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTop25Top25.Location = new System.Drawing.Point(71, 3);
            this.dataGridViewTop25Top25.Name = "dataGridViewTop25Top25";
            this.dataGridViewTop25Top25.Size = new System.Drawing.Size(1138, 150);
            this.dataGridViewTop25Top25.TabIndex = 0;
            this.dataGridViewTop25Top25.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTop25Top25_CellContentClick);
            // 
            // tableLayoutPanelHeaderTop25
            // 
            this.tableLayoutPanelHeaderTop25.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelHeaderTop25.ColumnCount = 5;
            this.tableLayoutPanelHeaderTop25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelHeaderTop25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelHeaderTop25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelHeaderTop25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelHeaderTop25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelHeaderTop25.Controls.Add(this.labelTop25Top25, 1, 0);
            this.tableLayoutPanelHeaderTop25.Controls.Add(this.buttonBackTop25, 3, 0);
            this.tableLayoutPanelHeaderTop25.Controls.Add(this.labelCurrentDayTop25, 1, 1);
            this.tableLayoutPanelHeaderTop25.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelHeaderTop25.Name = "tableLayoutPanelHeaderTop25";
            this.tableLayoutPanelHeaderTop25.RowCount = 2;
            this.tableLayoutPanelHeaderTop25.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanelHeaderTop25.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanelHeaderTop25.Size = new System.Drawing.Size(1280, 184);
            this.tableLayoutPanelHeaderTop25.TabIndex = 0;
            // 
            // labelTop25Top25
            // 
            this.labelTop25Top25.AutoSize = true;
            this.labelTop25Top25.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.labelTop25Top25.Location = new System.Drawing.Point(23, 0);
            this.labelTop25Top25.Name = "labelTop25Top25";
            this.labelTop25Top25.Size = new System.Drawing.Size(194, 63);
            this.labelTop25Top25.TabIndex = 0;
            this.labelTop25Top25.Text = "Top 25";
            // 
            // buttonBackTop25
            // 
            this.buttonBackTop25.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBackTop25.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.buttonBackTop25.Location = new System.Drawing.Point(1060, 20);
            this.buttonBackTop25.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBackTop25.Name = "buttonBackTop25";
            this.buttonBackTop25.Size = new System.Drawing.Size(200, 100);
            this.buttonBackTop25.TabIndex = 5;
            this.buttonBackTop25.Text = "Back";
            this.buttonBackTop25.UseVisualStyleBackColor = true;
            this.buttonBackTop25.Click += new System.EventHandler(this.buttonBackTop25_Click);
            // 
            // labelCurrentDayTop25
            // 
            this.labelCurrentDayTop25.AutoSize = true;
            this.labelCurrentDayTop25.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelCurrentDayTop25.Location = new System.Drawing.Point(23, 120);
            this.labelCurrentDayTop25.Name = "labelCurrentDayTop25";
            this.labelCurrentDayTop25.Size = new System.Drawing.Size(235, 44);
            this.labelCurrentDayTop25.TabIndex = 7;
            this.labelCurrentDayTop25.Text = "Current Day:";
            // 
            // panelTournProList
            // 
            this.panelTournProList.AutoScroll = true;
            this.panelTournProList.AutoSize = true;
            this.panelTournProList.Controls.Add(this.tableLayoutPanelATournProList);
            this.panelTournProList.Controls.Add(this.tableLayoutPanelBTournProList);
            this.panelTournProList.Controls.Add(this.tableLayoutPanelHeaderTournProList);
            this.panelTournProList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTournProList.Location = new System.Drawing.Point(0, 24);
            this.panelTournProList.Margin = new System.Windows.Forms.Padding(0);
            this.panelTournProList.Name = "panelTournProList";
            this.panelTournProList.Size = new System.Drawing.Size(1286, 554);
            this.panelTournProList.TabIndex = 14;
            // 
            // tableLayoutPanelATournProList
            // 
            this.tableLayoutPanelATournProList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelATournProList.ColumnCount = 3;
            this.tableLayoutPanelATournProList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelATournProList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanelATournProList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelATournProList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelATournProList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelATournProList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelATournProList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelATournProList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelATournProList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelATournProList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelATournProList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelATournProList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelATournProList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelATournProList.Controls.Add(this.buttonBracketTournProList, 1, 0);
            this.tableLayoutPanelATournProList.Location = new System.Drawing.Point(3, 207);
            this.tableLayoutPanelATournProList.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.tableLayoutPanelATournProList.Name = "tableLayoutPanelATournProList";
            this.tableLayoutPanelATournProList.RowCount = 1;
            this.tableLayoutPanelATournProList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanelATournProList.Size = new System.Drawing.Size(1263, 64);
            this.tableLayoutPanelATournProList.TabIndex = 3;
            // 
            // buttonBracketTournProList
            // 
            this.buttonBracketTournProList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBracketTournProList.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.buttonBracketTournProList.Location = new System.Drawing.Point(481, 0);
            this.buttonBracketTournProList.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBracketTournProList.Name = "buttonBracketTournProList";
            this.buttonBracketTournProList.Size = new System.Drawing.Size(300, 64);
            this.buttonBracketTournProList.TabIndex = 8;
            this.buttonBracketTournProList.Text = "Bracket";
            this.buttonBracketTournProList.UseVisualStyleBackColor = true;
            this.buttonBracketTournProList.Click += new System.EventHandler(this.buttonBracketTournProList_Click);
            // 
            // tableLayoutPanelBTournProList
            // 
            this.tableLayoutPanelBTournProList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelBTournProList.ColumnCount = 3;
            this.tableLayoutPanelBTournProList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBTournProList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1144F));
            this.tableLayoutPanelBTournProList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBTournProList.Controls.Add(this.dataGridViewChampTournProListTournProList, 1, 0);
            this.tableLayoutPanelBTournProList.Location = new System.Drawing.Point(3, 291);
            this.tableLayoutPanelBTournProList.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tableLayoutPanelBTournProList.Name = "tableLayoutPanelBTournProList";
            this.tableLayoutPanelBTournProList.RowCount = 1;
            this.tableLayoutPanelBTournProList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanelBTournProList.Size = new System.Drawing.Size(1263, 300);
            this.tableLayoutPanelBTournProList.TabIndex = 1;
            // 
            // dataGridViewChampTournProListTournProList
            // 
            this.dataGridViewChampTournProListTournProList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewChampTournProListTournProList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChampTournProListTournProList.Location = new System.Drawing.Point(62, 3);
            this.dataGridViewChampTournProListTournProList.Name = "dataGridViewChampTournProListTournProList";
            this.dataGridViewChampTournProListTournProList.Size = new System.Drawing.Size(1138, 150);
            this.dataGridViewChampTournProListTournProList.TabIndex = 0;
            this.dataGridViewChampTournProListTournProList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewChampTournProListTournProList_CellContentClick);
            // 
            // tableLayoutPanelHeaderTournProList
            // 
            this.tableLayoutPanelHeaderTournProList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelHeaderTournProList.ColumnCount = 5;
            this.tableLayoutPanelHeaderTournProList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelHeaderTournProList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelHeaderTournProList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelHeaderTournProList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelHeaderTournProList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelHeaderTournProList.Controls.Add(this.labelChampTournProjTournProList, 1, 0);
            this.tableLayoutPanelHeaderTournProList.Controls.Add(this.buttonBackTournProList, 3, 0);
            this.tableLayoutPanelHeaderTournProList.Controls.Add(this.labelCurrentDayTournProList, 1, 1);
            this.tableLayoutPanelHeaderTournProList.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelHeaderTournProList.Name = "tableLayoutPanelHeaderTournProList";
            this.tableLayoutPanelHeaderTournProList.RowCount = 2;
            this.tableLayoutPanelHeaderTournProList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanelHeaderTournProList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanelHeaderTournProList.Size = new System.Drawing.Size(1263, 184);
            this.tableLayoutPanelHeaderTournProList.TabIndex = 0;
            // 
            // labelChampTournProjTournProList
            // 
            this.labelChampTournProjTournProList.AutoSize = true;
            this.labelChampTournProjTournProList.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.labelChampTournProjTournProList.Location = new System.Drawing.Point(23, 0);
            this.labelChampTournProjTournProList.Name = "labelChampTournProjTournProList";
            this.labelChampTournProjTournProList.Size = new System.Drawing.Size(935, 63);
            this.labelChampTournProjTournProList.TabIndex = 0;
            this.labelChampTournProjTournProList.Text = "Championship Tournament Projection";
            // 
            // buttonBackTournProList
            // 
            this.buttonBackTournProList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBackTournProList.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.buttonBackTournProList.Location = new System.Drawing.Point(1043, 20);
            this.buttonBackTournProList.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBackTournProList.Name = "buttonBackTournProList";
            this.buttonBackTournProList.Size = new System.Drawing.Size(200, 100);
            this.buttonBackTournProList.TabIndex = 5;
            this.buttonBackTournProList.Text = "Back";
            this.buttonBackTournProList.UseVisualStyleBackColor = true;
            this.buttonBackTournProList.Click += new System.EventHandler(this.buttonBackTournProList_Click);
            // 
            // labelCurrentDayTournProList
            // 
            this.labelCurrentDayTournProList.AutoSize = true;
            this.labelCurrentDayTournProList.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelCurrentDayTournProList.Location = new System.Drawing.Point(23, 120);
            this.labelCurrentDayTournProList.Name = "labelCurrentDayTournProList";
            this.labelCurrentDayTournProList.Size = new System.Drawing.Size(235, 44);
            this.labelCurrentDayTournProList.TabIndex = 7;
            this.labelCurrentDayTournProList.Text = "Current Day:";
            // 
            // panelTournList
            // 
            this.panelTournList.AutoScroll = true;
            this.panelTournList.AutoSize = true;
            this.panelTournList.Controls.Add(this.tableLayoutPanelATournList);
            this.panelTournList.Controls.Add(this.tableLayoutPanelBTournList);
            this.panelTournList.Controls.Add(this.tableLayoutPanelHeaderTournList);
            this.panelTournList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTournList.Location = new System.Drawing.Point(0, 24);
            this.panelTournList.Margin = new System.Windows.Forms.Padding(0);
            this.panelTournList.Name = "panelTournList";
            this.panelTournList.Size = new System.Drawing.Size(1286, 554);
            this.panelTournList.TabIndex = 15;
            // 
            // tableLayoutPanelATournList
            // 
            this.tableLayoutPanelATournList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelATournList.ColumnCount = 3;
            this.tableLayoutPanelATournList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelATournList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanelATournList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelATournList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelATournList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelATournList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelATournList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelATournList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelATournList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelATournList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelATournList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelATournList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelATournList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelATournList.Controls.Add(this.buttonBracketTournList, 1, 0);
            this.tableLayoutPanelATournList.Location = new System.Drawing.Point(3, 207);
            this.tableLayoutPanelATournList.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.tableLayoutPanelATournList.Name = "tableLayoutPanelATournList";
            this.tableLayoutPanelATournList.RowCount = 1;
            this.tableLayoutPanelATournList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanelATournList.Size = new System.Drawing.Size(1263, 64);
            this.tableLayoutPanelATournList.TabIndex = 3;
            // 
            // buttonBracketTournList
            // 
            this.buttonBracketTournList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBracketTournList.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.buttonBracketTournList.Location = new System.Drawing.Point(481, 0);
            this.buttonBracketTournList.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBracketTournList.Name = "buttonBracketTournList";
            this.buttonBracketTournList.Size = new System.Drawing.Size(300, 64);
            this.buttonBracketTournList.TabIndex = 8;
            this.buttonBracketTournList.Text = "Bracket";
            this.buttonBracketTournList.UseVisualStyleBackColor = true;
            this.buttonBracketTournList.Click += new System.EventHandler(this.buttonBracketTournList_Click);
            // 
            // tableLayoutPanelBTournList
            // 
            this.tableLayoutPanelBTournList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelBTournList.ColumnCount = 3;
            this.tableLayoutPanelBTournList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBTournList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1144F));
            this.tableLayoutPanelBTournList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBTournList.Controls.Add(this.dataGridViewChampTournListTournList, 1, 0);
            this.tableLayoutPanelBTournList.Location = new System.Drawing.Point(3, 291);
            this.tableLayoutPanelBTournList.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tableLayoutPanelBTournList.Name = "tableLayoutPanelBTournList";
            this.tableLayoutPanelBTournList.RowCount = 1;
            this.tableLayoutPanelBTournList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanelBTournList.Size = new System.Drawing.Size(1263, 300);
            this.tableLayoutPanelBTournList.TabIndex = 1;
            // 
            // dataGridViewChampTournListTournList
            // 
            this.dataGridViewChampTournListTournList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewChampTournListTournList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChampTournListTournList.Location = new System.Drawing.Point(62, 3);
            this.dataGridViewChampTournListTournList.Name = "dataGridViewChampTournListTournList";
            this.dataGridViewChampTournListTournList.Size = new System.Drawing.Size(1138, 150);
            this.dataGridViewChampTournListTournList.TabIndex = 0;
            this.dataGridViewChampTournListTournList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewChampTournListTournList_CellContentClick);
            // 
            // tableLayoutPanelHeaderTournList
            // 
            this.tableLayoutPanelHeaderTournList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelHeaderTournList.ColumnCount = 5;
            this.tableLayoutPanelHeaderTournList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelHeaderTournList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelHeaderTournList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelHeaderTournList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelHeaderTournList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelHeaderTournList.Controls.Add(this.labelChampTournTournList, 1, 0);
            this.tableLayoutPanelHeaderTournList.Controls.Add(this.buttonBackTournList, 3, 0);
            this.tableLayoutPanelHeaderTournList.Controls.Add(this.labelCurrentDayTournList, 1, 1);
            this.tableLayoutPanelHeaderTournList.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelHeaderTournList.Name = "tableLayoutPanelHeaderTournList";
            this.tableLayoutPanelHeaderTournList.RowCount = 2;
            this.tableLayoutPanelHeaderTournList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanelHeaderTournList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanelHeaderTournList.Size = new System.Drawing.Size(1263, 184);
            this.tableLayoutPanelHeaderTournList.TabIndex = 0;
            // 
            // labelChampTournTournList
            // 
            this.labelChampTournTournList.AutoSize = true;
            this.labelChampTournTournList.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.labelChampTournTournList.Location = new System.Drawing.Point(23, 0);
            this.labelChampTournTournList.Name = "labelChampTournTournList";
            this.labelChampTournTournList.Size = new System.Drawing.Size(679, 63);
            this.labelChampTournTournList.TabIndex = 0;
            this.labelChampTournTournList.Text = "Championship Tournament";
            // 
            // buttonBackTournList
            // 
            this.buttonBackTournList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBackTournList.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.buttonBackTournList.Location = new System.Drawing.Point(1043, 20);
            this.buttonBackTournList.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBackTournList.Name = "buttonBackTournList";
            this.buttonBackTournList.Size = new System.Drawing.Size(200, 100);
            this.buttonBackTournList.TabIndex = 5;
            this.buttonBackTournList.Text = "Back";
            this.buttonBackTournList.UseVisualStyleBackColor = true;
            this.buttonBackTournList.Click += new System.EventHandler(this.buttonBackTournList_Click);
            // 
            // labelCurrentDayTournList
            // 
            this.labelCurrentDayTournList.AutoSize = true;
            this.labelCurrentDayTournList.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelCurrentDayTournList.Location = new System.Drawing.Point(23, 120);
            this.labelCurrentDayTournList.Name = "labelCurrentDayTournList";
            this.labelCurrentDayTournList.Size = new System.Drawing.Size(235, 44);
            this.labelCurrentDayTournList.TabIndex = 7;
            this.labelCurrentDayTournList.Text = "Current Day:";
            // 
            // panelTournProBrac
            // 
            this.panelTournProBrac.AutoScroll = true;
            this.panelTournProBrac.AutoSize = true;
            this.panelTournProBrac.Controls.Add(this.tableLayoutPanelATournProBrac);
            this.panelTournProBrac.Controls.Add(this.tableLayoutPanelBTournProBrac);
            this.panelTournProBrac.Controls.Add(this.tableLayoutPanelHeaderTournProBrac);
            this.panelTournProBrac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTournProBrac.Location = new System.Drawing.Point(0, 24);
            this.panelTournProBrac.Margin = new System.Windows.Forms.Padding(0);
            this.panelTournProBrac.Name = "panelTournProBrac";
            this.panelTournProBrac.Size = new System.Drawing.Size(1286, 554);
            this.panelTournProBrac.TabIndex = 16;
            // 
            // tableLayoutPanelATournProBrac
            // 
            this.tableLayoutPanelATournProBrac.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelATournProBrac.ColumnCount = 7;
            this.tableLayoutPanelATournProBrac.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelATournProBrac.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanelATournProBrac.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelATournProBrac.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanelATournProBrac.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelATournProBrac.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanelATournProBrac.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelATournProBrac.Controls.Add(this.buttonWestTournProBrac, 1, 2);
            this.tableLayoutPanelATournProBrac.Controls.Add(this.buttonMidwestTournProBrac, 1, 4);
            this.tableLayoutPanelATournProBrac.Controls.Add(this.buttonEastTournProBrac, 3, 2);
            this.tableLayoutPanelATournProBrac.Controls.Add(this.buttonSouthTournProBrac, 3, 4);
            this.tableLayoutPanelATournProBrac.Controls.Add(this.buttonFullBracketTournProBrac, 5, 2);
            this.tableLayoutPanelATournProBrac.Controls.Add(this.buttonListViewTournProBrac, 5, 0);
            this.tableLayoutPanelATournProBrac.Controls.Add(this.buttonSweet16TournProBrac, 5, 4);
            this.tableLayoutPanelATournProBrac.Location = new System.Drawing.Point(3, 207);
            this.tableLayoutPanelATournProBrac.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.tableLayoutPanelATournProBrac.Name = "tableLayoutPanelATournProBrac";
            this.tableLayoutPanelATournProBrac.RowCount = 5;
            this.tableLayoutPanelATournProBrac.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanelATournProBrac.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelATournProBrac.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanelATournProBrac.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelATournProBrac.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanelATournProBrac.Size = new System.Drawing.Size(1263, 232);
            this.tableLayoutPanelATournProBrac.TabIndex = 3;
            // 
            // buttonWestTournProBrac
            // 
            this.buttonWestTournProBrac.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonWestTournProBrac.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.buttonWestTournProBrac.Location = new System.Drawing.Point(101, 84);
            this.buttonWestTournProBrac.Margin = new System.Windows.Forms.Padding(0);
            this.buttonWestTournProBrac.Name = "buttonWestTournProBrac";
            this.buttonWestTournProBrac.Size = new System.Drawing.Size(250, 64);
            this.buttonWestTournProBrac.TabIndex = 8;
            this.buttonWestTournProBrac.Text = "West";
            this.buttonWestTournProBrac.UseVisualStyleBackColor = true;
            this.buttonWestTournProBrac.Click += new System.EventHandler(this.buttonWestTournProBrac_Click);
            // 
            // buttonMidwestTournProBrac
            // 
            this.buttonMidwestTournProBrac.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMidwestTournProBrac.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.buttonMidwestTournProBrac.Location = new System.Drawing.Point(101, 168);
            this.buttonMidwestTournProBrac.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMidwestTournProBrac.Name = "buttonMidwestTournProBrac";
            this.buttonMidwestTournProBrac.Size = new System.Drawing.Size(250, 64);
            this.buttonMidwestTournProBrac.TabIndex = 9;
            this.buttonMidwestTournProBrac.Text = "Midwest";
            this.buttonMidwestTournProBrac.UseVisualStyleBackColor = true;
            this.buttonMidwestTournProBrac.Click += new System.EventHandler(this.buttonMidwestTournProBrac_Click);
            // 
            // buttonEastTournProBrac
            // 
            this.buttonEastTournProBrac.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEastTournProBrac.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.buttonEastTournProBrac.Location = new System.Drawing.Point(371, 84);
            this.buttonEastTournProBrac.Margin = new System.Windows.Forms.Padding(0);
            this.buttonEastTournProBrac.Name = "buttonEastTournProBrac";
            this.buttonEastTournProBrac.Size = new System.Drawing.Size(250, 64);
            this.buttonEastTournProBrac.TabIndex = 10;
            this.buttonEastTournProBrac.Text = "East";
            this.buttonEastTournProBrac.UseVisualStyleBackColor = true;
            this.buttonEastTournProBrac.Click += new System.EventHandler(this.buttonEastTournProBrac_Click);
            // 
            // buttonSouthTournProBrac
            // 
            this.buttonSouthTournProBrac.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSouthTournProBrac.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.buttonSouthTournProBrac.Location = new System.Drawing.Point(371, 168);
            this.buttonSouthTournProBrac.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSouthTournProBrac.Name = "buttonSouthTournProBrac";
            this.buttonSouthTournProBrac.Size = new System.Drawing.Size(250, 64);
            this.buttonSouthTournProBrac.TabIndex = 11;
            this.buttonSouthTournProBrac.Text = "South";
            this.buttonSouthTournProBrac.UseVisualStyleBackColor = true;
            this.buttonSouthTournProBrac.Click += new System.EventHandler(this.buttonSouthTournProBrac_Click);
            // 
            // buttonFullBracketTournProBrac
            // 
            this.buttonFullBracketTournProBrac.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFullBracketTournProBrac.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.buttonFullBracketTournProBrac.Location = new System.Drawing.Point(641, 84);
            this.buttonFullBracketTournProBrac.Margin = new System.Windows.Forms.Padding(0);
            this.buttonFullBracketTournProBrac.Name = "buttonFullBracketTournProBrac";
            this.buttonFullBracketTournProBrac.Size = new System.Drawing.Size(250, 64);
            this.buttonFullBracketTournProBrac.TabIndex = 12;
            this.buttonFullBracketTournProBrac.Text = "Full Bracket";
            this.buttonFullBracketTournProBrac.UseVisualStyleBackColor = true;
            this.buttonFullBracketTournProBrac.Click += new System.EventHandler(this.buttonFullBracketTournProBrac_Click);
            // 
            // buttonListViewTournProBrac
            // 
            this.buttonListViewTournProBrac.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonListViewTournProBrac.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.buttonListViewTournProBrac.Location = new System.Drawing.Point(641, 0);
            this.buttonListViewTournProBrac.Margin = new System.Windows.Forms.Padding(0);
            this.buttonListViewTournProBrac.Name = "buttonListViewTournProBrac";
            this.buttonListViewTournProBrac.Size = new System.Drawing.Size(250, 64);
            this.buttonListViewTournProBrac.TabIndex = 13;
            this.buttonListViewTournProBrac.Text = "List View";
            this.buttonListViewTournProBrac.UseVisualStyleBackColor = true;
            this.buttonListViewTournProBrac.Click += new System.EventHandler(this.buttonListViewTournProBrac_Click);
            // 
            // buttonSweet16TournProBrac
            // 
            this.buttonSweet16TournProBrac.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSweet16TournProBrac.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.buttonSweet16TournProBrac.Location = new System.Drawing.Point(641, 168);
            this.buttonSweet16TournProBrac.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSweet16TournProBrac.Name = "buttonSweet16TournProBrac";
            this.buttonSweet16TournProBrac.Size = new System.Drawing.Size(250, 64);
            this.buttonSweet16TournProBrac.TabIndex = 14;
            this.buttonSweet16TournProBrac.Text = "Sweet 16";
            this.buttonSweet16TournProBrac.UseVisualStyleBackColor = true;
            this.buttonSweet16TournProBrac.Click += new System.EventHandler(this.buttonSweet16TournProBrac_Click);
            // 
            // tableLayoutPanelBTournProBrac
            // 
            this.tableLayoutPanelBTournProBrac.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelBTournProBrac.ColumnCount = 3;
            this.tableLayoutPanelBTournProBrac.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBTournProBrac.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1144F));
            this.tableLayoutPanelBTournProBrac.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBTournProBrac.Controls.Add(this.textBoxChampTournProBracTournProBrac, 1, 0);
            this.tableLayoutPanelBTournProBrac.Location = new System.Drawing.Point(3, 479);
            this.tableLayoutPanelBTournProBrac.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tableLayoutPanelBTournProBrac.Name = "tableLayoutPanelBTournProBrac";
            this.tableLayoutPanelBTournProBrac.RowCount = 1;
            this.tableLayoutPanelBTournProBrac.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanelBTournProBrac.Size = new System.Drawing.Size(1263, 300);
            this.tableLayoutPanelBTournProBrac.TabIndex = 1;
            // 
            // textBoxChampTournProBracTournProBrac
            // 
            this.textBoxChampTournProBracTournProBrac.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxChampTournProBracTournProBrac.Location = new System.Drawing.Point(62, 3);
            this.textBoxChampTournProBracTournProBrac.Multiline = true;
            this.textBoxChampTournProBracTournProBrac.Name = "textBoxChampTournProBracTournProBrac";
            this.textBoxChampTournProBracTournProBrac.Size = new System.Drawing.Size(1138, 294);
            this.textBoxChampTournProBracTournProBrac.TabIndex = 0;
            // 
            // tableLayoutPanelHeaderTournProBrac
            // 
            this.tableLayoutPanelHeaderTournProBrac.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelHeaderTournProBrac.ColumnCount = 5;
            this.tableLayoutPanelHeaderTournProBrac.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelHeaderTournProBrac.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelHeaderTournProBrac.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelHeaderTournProBrac.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelHeaderTournProBrac.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelHeaderTournProBrac.Controls.Add(this.labelChampTournProTournProBrac, 1, 0);
            this.tableLayoutPanelHeaderTournProBrac.Controls.Add(this.buttonBackTournProBrac, 3, 0);
            this.tableLayoutPanelHeaderTournProBrac.Controls.Add(this.labelCurrentDayTournProBrac, 1, 1);
            this.tableLayoutPanelHeaderTournProBrac.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelHeaderTournProBrac.Name = "tableLayoutPanelHeaderTournProBrac";
            this.tableLayoutPanelHeaderTournProBrac.RowCount = 2;
            this.tableLayoutPanelHeaderTournProBrac.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanelHeaderTournProBrac.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanelHeaderTournProBrac.Size = new System.Drawing.Size(1263, 184);
            this.tableLayoutPanelHeaderTournProBrac.TabIndex = 0;
            // 
            // labelChampTournProTournProBrac
            // 
            this.labelChampTournProTournProBrac.AutoSize = true;
            this.labelChampTournProTournProBrac.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.labelChampTournProTournProBrac.Location = new System.Drawing.Point(23, 0);
            this.labelChampTournProTournProBrac.Name = "labelChampTournProTournProBrac";
            this.labelChampTournProTournProBrac.Size = new System.Drawing.Size(935, 63);
            this.labelChampTournProTournProBrac.TabIndex = 0;
            this.labelChampTournProTournProBrac.Text = "Championship Tournament Projection";
            // 
            // buttonBackTournProBrac
            // 
            this.buttonBackTournProBrac.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBackTournProBrac.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.buttonBackTournProBrac.Location = new System.Drawing.Point(1043, 20);
            this.buttonBackTournProBrac.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBackTournProBrac.Name = "buttonBackTournProBrac";
            this.buttonBackTournProBrac.Size = new System.Drawing.Size(200, 100);
            this.buttonBackTournProBrac.TabIndex = 5;
            this.buttonBackTournProBrac.Text = "Back";
            this.buttonBackTournProBrac.UseVisualStyleBackColor = true;
            this.buttonBackTournProBrac.Click += new System.EventHandler(this.buttonBackTournProBrac_Click);
            // 
            // labelCurrentDayTournProBrac
            // 
            this.labelCurrentDayTournProBrac.AutoSize = true;
            this.labelCurrentDayTournProBrac.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelCurrentDayTournProBrac.Location = new System.Drawing.Point(23, 120);
            this.labelCurrentDayTournProBrac.Name = "labelCurrentDayTournProBrac";
            this.labelCurrentDayTournProBrac.Size = new System.Drawing.Size(235, 44);
            this.labelCurrentDayTournProBrac.TabIndex = 7;
            this.labelCurrentDayTournProBrac.Text = "Current Day:";
            // 
            // panelTournBrac
            // 
            this.panelTournBrac.AutoScroll = true;
            this.panelTournBrac.AutoSize = true;
            this.panelTournBrac.Controls.Add(this.tableLayoutPanelATournBrac);
            this.panelTournBrac.Controls.Add(this.tableLayoutPanelBTournBrac);
            this.panelTournBrac.Controls.Add(this.tableLayoutPanelHeaderTournBrac);
            this.panelTournBrac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTournBrac.Location = new System.Drawing.Point(0, 24);
            this.panelTournBrac.Margin = new System.Windows.Forms.Padding(0);
            this.panelTournBrac.Name = "panelTournBrac";
            this.panelTournBrac.Size = new System.Drawing.Size(1286, 554);
            this.panelTournBrac.TabIndex = 17;
            // 
            // tableLayoutPanelATournBrac
            // 
            this.tableLayoutPanelATournBrac.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelATournBrac.ColumnCount = 7;
            this.tableLayoutPanelATournBrac.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelATournBrac.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanelATournBrac.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelATournBrac.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanelATournBrac.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelATournBrac.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanelATournBrac.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelATournBrac.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelATournBrac.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelATournBrac.Controls.Add(this.buttonWestTournBrac, 1, 2);
            this.tableLayoutPanelATournBrac.Controls.Add(this.buttonMidwestTournBrac, 1, 4);
            this.tableLayoutPanelATournBrac.Controls.Add(this.buttonEastTournBrac, 3, 2);
            this.tableLayoutPanelATournBrac.Controls.Add(this.buttonSouthTournBrac, 3, 4);
            this.tableLayoutPanelATournBrac.Controls.Add(this.buttonFullBracketTournBrac, 5, 2);
            this.tableLayoutPanelATournBrac.Controls.Add(this.buttonListViewTournBrac, 5, 0);
            this.tableLayoutPanelATournBrac.Controls.Add(this.buttonSweet16TournBrac, 5, 4);
            this.tableLayoutPanelATournBrac.Location = new System.Drawing.Point(3, 207);
            this.tableLayoutPanelATournBrac.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.tableLayoutPanelATournBrac.Name = "tableLayoutPanelATournBrac";
            this.tableLayoutPanelATournBrac.RowCount = 5;
            this.tableLayoutPanelATournBrac.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanelATournBrac.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelATournBrac.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanelATournBrac.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelATournBrac.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanelATournBrac.Size = new System.Drawing.Size(1263, 232);
            this.tableLayoutPanelATournBrac.TabIndex = 3;
            // 
            // buttonWestTournBrac
            // 
            this.buttonWestTournBrac.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonWestTournBrac.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.buttonWestTournBrac.Location = new System.Drawing.Point(236, 84);
            this.buttonWestTournBrac.Margin = new System.Windows.Forms.Padding(0);
            this.buttonWestTournBrac.Name = "buttonWestTournBrac";
            this.buttonWestTournBrac.Size = new System.Drawing.Size(250, 64);
            this.buttonWestTournBrac.TabIndex = 8;
            this.buttonWestTournBrac.Text = "West";
            this.buttonWestTournBrac.UseVisualStyleBackColor = true;
            this.buttonWestTournBrac.Click += new System.EventHandler(this.buttonWestTournBrac_Click);
            // 
            // buttonMidwestTournBrac
            // 
            this.buttonMidwestTournBrac.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMidwestTournBrac.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.buttonMidwestTournBrac.Location = new System.Drawing.Point(236, 168);
            this.buttonMidwestTournBrac.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMidwestTournBrac.Name = "buttonMidwestTournBrac";
            this.buttonMidwestTournBrac.Size = new System.Drawing.Size(250, 64);
            this.buttonMidwestTournBrac.TabIndex = 9;
            this.buttonMidwestTournBrac.Text = "Midwest";
            this.buttonMidwestTournBrac.UseVisualStyleBackColor = true;
            this.buttonMidwestTournBrac.Click += new System.EventHandler(this.buttonMidwestTournBrac_Click);
            // 
            // buttonEastTournBrac
            // 
            this.buttonEastTournBrac.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEastTournBrac.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.buttonEastTournBrac.Location = new System.Drawing.Point(506, 84);
            this.buttonEastTournBrac.Margin = new System.Windows.Forms.Padding(0);
            this.buttonEastTournBrac.Name = "buttonEastTournBrac";
            this.buttonEastTournBrac.Size = new System.Drawing.Size(250, 64);
            this.buttonEastTournBrac.TabIndex = 10;
            this.buttonEastTournBrac.Text = "East";
            this.buttonEastTournBrac.UseVisualStyleBackColor = true;
            this.buttonEastTournBrac.Click += new System.EventHandler(this.buttonEastTournBrac_Click);
            // 
            // buttonSouthTournBrac
            // 
            this.buttonSouthTournBrac.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSouthTournBrac.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.buttonSouthTournBrac.Location = new System.Drawing.Point(506, 168);
            this.buttonSouthTournBrac.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSouthTournBrac.Name = "buttonSouthTournBrac";
            this.buttonSouthTournBrac.Size = new System.Drawing.Size(250, 64);
            this.buttonSouthTournBrac.TabIndex = 11;
            this.buttonSouthTournBrac.Text = "South";
            this.buttonSouthTournBrac.UseVisualStyleBackColor = true;
            this.buttonSouthTournBrac.Click += new System.EventHandler(this.buttonSouthTournBrac_Click);
            // 
            // buttonFullBracketTournBrac
            // 
            this.buttonFullBracketTournBrac.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFullBracketTournBrac.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.buttonFullBracketTournBrac.Location = new System.Drawing.Point(776, 84);
            this.buttonFullBracketTournBrac.Margin = new System.Windows.Forms.Padding(0);
            this.buttonFullBracketTournBrac.Name = "buttonFullBracketTournBrac";
            this.buttonFullBracketTournBrac.Size = new System.Drawing.Size(250, 64);
            this.buttonFullBracketTournBrac.TabIndex = 12;
            this.buttonFullBracketTournBrac.Text = "Full Bracket";
            this.buttonFullBracketTournBrac.UseVisualStyleBackColor = true;
            this.buttonFullBracketTournBrac.Click += new System.EventHandler(this.buttonFullBracketTournBrac_Click);
            // 
            // buttonListViewTournBrac
            // 
            this.buttonListViewTournBrac.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonListViewTournBrac.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.buttonListViewTournBrac.Location = new System.Drawing.Point(776, 0);
            this.buttonListViewTournBrac.Margin = new System.Windows.Forms.Padding(0);
            this.buttonListViewTournBrac.Name = "buttonListViewTournBrac";
            this.buttonListViewTournBrac.Size = new System.Drawing.Size(250, 64);
            this.buttonListViewTournBrac.TabIndex = 13;
            this.buttonListViewTournBrac.Text = "List View";
            this.buttonListViewTournBrac.UseVisualStyleBackColor = true;
            this.buttonListViewTournBrac.Click += new System.EventHandler(this.buttonListViewTournBrac_Click);
            // 
            // buttonSweet16TournBrac
            // 
            this.buttonSweet16TournBrac.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSweet16TournBrac.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.buttonSweet16TournBrac.Location = new System.Drawing.Point(776, 168);
            this.buttonSweet16TournBrac.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSweet16TournBrac.Name = "buttonSweet16TournBrac";
            this.buttonSweet16TournBrac.Size = new System.Drawing.Size(250, 64);
            this.buttonSweet16TournBrac.TabIndex = 14;
            this.buttonSweet16TournBrac.Text = "Sweet 16";
            this.buttonSweet16TournBrac.UseVisualStyleBackColor = true;
            this.buttonSweet16TournBrac.Click += new System.EventHandler(this.buttonSweet16TournBrac_Click);
            // 
            // tableLayoutPanelBTournBrac
            // 
            this.tableLayoutPanelBTournBrac.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelBTournBrac.ColumnCount = 3;
            this.tableLayoutPanelBTournBrac.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBTournBrac.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1144F));
            this.tableLayoutPanelBTournBrac.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBTournBrac.Controls.Add(this.textBoxChampTournBracTournBrac, 1, 0);
            this.tableLayoutPanelBTournBrac.Location = new System.Drawing.Point(3, 479);
            this.tableLayoutPanelBTournBrac.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tableLayoutPanelBTournBrac.Name = "tableLayoutPanelBTournBrac";
            this.tableLayoutPanelBTournBrac.RowCount = 1;
            this.tableLayoutPanelBTournBrac.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanelBTournBrac.Size = new System.Drawing.Size(1263, 300);
            this.tableLayoutPanelBTournBrac.TabIndex = 1;
            // 
            // textBoxChampTournBracTournBrac
            // 
            this.textBoxChampTournBracTournBrac.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxChampTournBracTournBrac.Location = new System.Drawing.Point(62, 3);
            this.textBoxChampTournBracTournBrac.Multiline = true;
            this.textBoxChampTournBracTournBrac.Name = "textBoxChampTournBracTournBrac";
            this.textBoxChampTournBracTournBrac.Size = new System.Drawing.Size(1138, 294);
            this.textBoxChampTournBracTournBrac.TabIndex = 0;
            // 
            // tableLayoutPanelHeaderTournBrac
            // 
            this.tableLayoutPanelHeaderTournBrac.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelHeaderTournBrac.ColumnCount = 5;
            this.tableLayoutPanelHeaderTournBrac.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelHeaderTournBrac.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelHeaderTournBrac.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelHeaderTournBrac.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelHeaderTournBrac.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelHeaderTournBrac.Controls.Add(this.labelChampTournTournBrac, 1, 0);
            this.tableLayoutPanelHeaderTournBrac.Controls.Add(this.buttonBackTournBrac, 3, 0);
            this.tableLayoutPanelHeaderTournBrac.Controls.Add(this.labelCurrentDayTournBrac, 1, 1);
            this.tableLayoutPanelHeaderTournBrac.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelHeaderTournBrac.Name = "tableLayoutPanelHeaderTournBrac";
            this.tableLayoutPanelHeaderTournBrac.RowCount = 2;
            this.tableLayoutPanelHeaderTournBrac.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanelHeaderTournBrac.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanelHeaderTournBrac.Size = new System.Drawing.Size(1263, 184);
            this.tableLayoutPanelHeaderTournBrac.TabIndex = 0;
            // 
            // labelChampTournTournBrac
            // 
            this.labelChampTournTournBrac.AutoSize = true;
            this.labelChampTournTournBrac.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.labelChampTournTournBrac.Location = new System.Drawing.Point(23, 0);
            this.labelChampTournTournBrac.Name = "labelChampTournTournBrac";
            this.labelChampTournTournBrac.Size = new System.Drawing.Size(679, 63);
            this.labelChampTournTournBrac.TabIndex = 0;
            this.labelChampTournTournBrac.Text = "Championship Tournament";
            // 
            // buttonBackTournBrac
            // 
            this.buttonBackTournBrac.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBackTournBrac.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.buttonBackTournBrac.Location = new System.Drawing.Point(1043, 20);
            this.buttonBackTournBrac.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBackTournBrac.Name = "buttonBackTournBrac";
            this.buttonBackTournBrac.Size = new System.Drawing.Size(200, 100);
            this.buttonBackTournBrac.TabIndex = 5;
            this.buttonBackTournBrac.Text = "Back";
            this.buttonBackTournBrac.UseVisualStyleBackColor = true;
            this.buttonBackTournBrac.Click += new System.EventHandler(this.buttonBackTournBrac_Click);
            // 
            // labelCurrentDayTournBrac
            // 
            this.labelCurrentDayTournBrac.AutoSize = true;
            this.labelCurrentDayTournBrac.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelCurrentDayTournBrac.Location = new System.Drawing.Point(23, 120);
            this.labelCurrentDayTournBrac.Name = "labelCurrentDayTournBrac";
            this.labelCurrentDayTournBrac.Size = new System.Drawing.Size(235, 44);
            this.labelCurrentDayTournBrac.TabIndex = 7;
            this.labelCurrentDayTournBrac.Text = "Current Day:";
            // 
            // panelConfTournFind
            // 
            this.panelConfTournFind.AutoScroll = true;
            this.panelConfTournFind.AutoSize = true;
            this.panelConfTournFind.Controls.Add(this.tableLayoutPanelAConfTournFind);
            this.panelConfTournFind.Controls.Add(this.tableLayoutPanelHeaderConfTournFind);
            this.panelConfTournFind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConfTournFind.Location = new System.Drawing.Point(0, 24);
            this.panelConfTournFind.Margin = new System.Windows.Forms.Padding(0);
            this.panelConfTournFind.Name = "panelConfTournFind";
            this.panelConfTournFind.Size = new System.Drawing.Size(1286, 554);
            this.panelConfTournFind.TabIndex = 18;
            // 
            // tableLayoutPanelAConfTournFind
            // 
            this.tableLayoutPanelAConfTournFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelAConfTournFind.ColumnCount = 3;
            this.tableLayoutPanelAConfTournFind.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAConfTournFind.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 600F));
            this.tableLayoutPanelAConfTournFind.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAConfTournFind.Controls.Add(this.dataGridViewConferencesConfTournFind, 1, 0);
            this.tableLayoutPanelAConfTournFind.Location = new System.Drawing.Point(3, 207);
            this.tableLayoutPanelAConfTournFind.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tableLayoutPanelAConfTournFind.Name = "tableLayoutPanelAConfTournFind";
            this.tableLayoutPanelAConfTournFind.RowCount = 1;
            this.tableLayoutPanelAConfTournFind.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanelAConfTournFind.Size = new System.Drawing.Size(1280, 300);
            this.tableLayoutPanelAConfTournFind.TabIndex = 1;
            // 
            // dataGridViewConferencesConfTournFind
            // 
            this.dataGridViewConferencesConfTournFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewConferencesConfTournFind.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConferencesConfTournFind.Location = new System.Drawing.Point(343, 3);
            this.dataGridViewConferencesConfTournFind.Name = "dataGridViewConferencesConfTournFind";
            this.dataGridViewConferencesConfTournFind.Size = new System.Drawing.Size(594, 150);
            this.dataGridViewConferencesConfTournFind.TabIndex = 0;
            this.dataGridViewConferencesConfTournFind.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConferencesConfTournFind_CellContentClick);
            // 
            // tableLayoutPanelHeaderConfTournFind
            // 
            this.tableLayoutPanelHeaderConfTournFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelHeaderConfTournFind.ColumnCount = 5;
            this.tableLayoutPanelHeaderConfTournFind.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelHeaderConfTournFind.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelHeaderConfTournFind.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelHeaderConfTournFind.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelHeaderConfTournFind.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelHeaderConfTournFind.Controls.Add(this.labelConfTournConfTournFind, 1, 0);
            this.tableLayoutPanelHeaderConfTournFind.Controls.Add(this.buttonBackConfTournFind, 3, 0);
            this.tableLayoutPanelHeaderConfTournFind.Controls.Add(this.labelCurrentDayConfTournFind, 1, 1);
            this.tableLayoutPanelHeaderConfTournFind.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelHeaderConfTournFind.Name = "tableLayoutPanelHeaderConfTournFind";
            this.tableLayoutPanelHeaderConfTournFind.RowCount = 2;
            this.tableLayoutPanelHeaderConfTournFind.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanelHeaderConfTournFind.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanelHeaderConfTournFind.Size = new System.Drawing.Size(1280, 184);
            this.tableLayoutPanelHeaderConfTournFind.TabIndex = 0;
            // 
            // labelConfTournConfTournFind
            // 
            this.labelConfTournConfTournFind.AutoSize = true;
            this.labelConfTournConfTournFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.labelConfTournConfTournFind.Location = new System.Drawing.Point(23, 0);
            this.labelConfTournConfTournFind.Name = "labelConfTournConfTournFind";
            this.labelConfTournConfTournFind.Size = new System.Drawing.Size(611, 63);
            this.labelConfTournConfTournFind.TabIndex = 0;
            this.labelConfTournConfTournFind.Text = "Conference Tournament";
            // 
            // buttonBackConfTournFind
            // 
            this.buttonBackConfTournFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBackConfTournFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.buttonBackConfTournFind.Location = new System.Drawing.Point(1060, 20);
            this.buttonBackConfTournFind.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBackConfTournFind.Name = "buttonBackConfTournFind";
            this.buttonBackConfTournFind.Size = new System.Drawing.Size(200, 100);
            this.buttonBackConfTournFind.TabIndex = 5;
            this.buttonBackConfTournFind.Text = "Back";
            this.buttonBackConfTournFind.UseVisualStyleBackColor = true;
            this.buttonBackConfTournFind.Click += new System.EventHandler(this.buttonBackConfTournFind_Click);
            // 
            // labelCurrentDayConfTournFind
            // 
            this.labelCurrentDayConfTournFind.AutoSize = true;
            this.labelCurrentDayConfTournFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelCurrentDayConfTournFind.Location = new System.Drawing.Point(23, 120);
            this.labelCurrentDayConfTournFind.Name = "labelCurrentDayConfTournFind";
            this.labelCurrentDayConfTournFind.Size = new System.Drawing.Size(235, 44);
            this.labelCurrentDayConfTournFind.TabIndex = 7;
            this.labelCurrentDayConfTournFind.Text = "Current Day:";
            // 
            // panelConfTournBrac
            // 
            this.panelConfTournBrac.AutoScroll = true;
            this.panelConfTournBrac.AutoSize = true;
            this.panelConfTournBrac.Controls.Add(this.tableLayoutPanelAConfTournBrac);
            this.panelConfTournBrac.Controls.Add(this.tableLayoutPanelBConfTournBrac);
            this.panelConfTournBrac.Controls.Add(this.tableLayoutPanelHeaderConfTournBrac);
            this.panelConfTournBrac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConfTournBrac.Location = new System.Drawing.Point(0, 24);
            this.panelConfTournBrac.Margin = new System.Windows.Forms.Padding(0);
            this.panelConfTournBrac.Name = "panelConfTournBrac";
            this.panelConfTournBrac.Size = new System.Drawing.Size(1286, 554);
            this.panelConfTournBrac.TabIndex = 19;
            // 
            // tableLayoutPanelAConfTournBrac
            // 
            this.tableLayoutPanelAConfTournBrac.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelAConfTournBrac.ColumnCount = 7;
            this.tableLayoutPanelAConfTournBrac.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAConfTournBrac.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelAConfTournBrac.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelAConfTournBrac.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelAConfTournBrac.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelAConfTournBrac.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelAConfTournBrac.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAConfTournBrac.Controls.Add(this.comboBoxConferencesConfTournBrac, 3, 0);
            this.tableLayoutPanelAConfTournBrac.Controls.Add(this.labelGoToConfConfTournBrac, 1, 0);
            this.tableLayoutPanelAConfTournBrac.Controls.Add(this.buttonGoConfTournBrac, 5, 0);
            this.tableLayoutPanelAConfTournBrac.Location = new System.Drawing.Point(3, 207);
            this.tableLayoutPanelAConfTournBrac.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.tableLayoutPanelAConfTournBrac.Name = "tableLayoutPanelAConfTournBrac";
            this.tableLayoutPanelAConfTournBrac.RowCount = 1;
            this.tableLayoutPanelAConfTournBrac.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanelAConfTournBrac.Size = new System.Drawing.Size(1263, 64);
            this.tableLayoutPanelAConfTournBrac.TabIndex = 3;
            // 
            // comboBoxConferencesConfTournBrac
            // 
            this.comboBoxConferencesConfTournBrac.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.comboBoxConferencesConfTournBrac.FormattingEnabled = true;
            this.comboBoxConferencesConfTournBrac.Location = new System.Drawing.Point(514, 3);
            this.comboBoxConferencesConfTournBrac.Name = "comboBoxConferencesConfTournBrac";
            this.comboBoxConferencesConfTournBrac.Size = new System.Drawing.Size(300, 45);
            this.comboBoxConferencesConfTournBrac.TabIndex = 16;
            // 
            // labelGoToConfConfTournBrac
            // 
            this.labelGoToConfConfTournBrac.AutoSize = true;
            this.labelGoToConfConfTournBrac.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelGoToConfConfTournBrac.Location = new System.Drawing.Point(157, 0);
            this.labelGoToConfConfTournBrac.Name = "labelGoToConfConfTournBrac";
            this.labelGoToConfConfTournBrac.Size = new System.Drawing.Size(331, 44);
            this.labelGoToConfConfTournBrac.TabIndex = 17;
            this.labelGoToConfConfTournBrac.Text = "Go To Conference";
            // 
            // buttonGoConfTournBrac
            // 
            this.buttonGoConfTournBrac.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGoConfTournBrac.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.buttonGoConfTournBrac.Location = new System.Drawing.Point(837, 0);
            this.buttonGoConfTournBrac.Margin = new System.Windows.Forms.Padding(0);
            this.buttonGoConfTournBrac.Name = "buttonGoConfTournBrac";
            this.buttonGoConfTournBrac.Size = new System.Drawing.Size(271, 64);
            this.buttonGoConfTournBrac.TabIndex = 18;
            this.buttonGoConfTournBrac.Text = "Go";
            this.buttonGoConfTournBrac.UseVisualStyleBackColor = true;
            this.buttonGoConfTournBrac.Click += new System.EventHandler(this.buttonGoConfTournBrac_Click);
            // 
            // tableLayoutPanelBConfTournBrac
            // 
            this.tableLayoutPanelBConfTournBrac.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelBConfTournBrac.ColumnCount = 3;
            this.tableLayoutPanelBConfTournBrac.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBConfTournBrac.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1144F));
            this.tableLayoutPanelBConfTournBrac.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBConfTournBrac.Controls.Add(this.textBoxConfTournBracConfTournBrac, 1, 0);
            this.tableLayoutPanelBConfTournBrac.Location = new System.Drawing.Point(3, 291);
            this.tableLayoutPanelBConfTournBrac.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tableLayoutPanelBConfTournBrac.Name = "tableLayoutPanelBConfTournBrac";
            this.tableLayoutPanelBConfTournBrac.RowCount = 1;
            this.tableLayoutPanelBConfTournBrac.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanelBConfTournBrac.Size = new System.Drawing.Size(1263, 300);
            this.tableLayoutPanelBConfTournBrac.TabIndex = 1;
            // 
            // textBoxConfTournBracConfTournBrac
            // 
            this.textBoxConfTournBracConfTournBrac.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxConfTournBracConfTournBrac.Location = new System.Drawing.Point(62, 3);
            this.textBoxConfTournBracConfTournBrac.Multiline = true;
            this.textBoxConfTournBracConfTournBrac.Name = "textBoxConfTournBracConfTournBrac";
            this.textBoxConfTournBracConfTournBrac.Size = new System.Drawing.Size(1138, 294);
            this.textBoxConfTournBracConfTournBrac.TabIndex = 1;
            // 
            // tableLayoutPanelHeaderConfTournBrac
            // 
            this.tableLayoutPanelHeaderConfTournBrac.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelHeaderConfTournBrac.ColumnCount = 5;
            this.tableLayoutPanelHeaderConfTournBrac.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelHeaderConfTournBrac.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelHeaderConfTournBrac.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelHeaderConfTournBrac.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelHeaderConfTournBrac.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelHeaderConfTournBrac.Controls.Add(this.labelConfTournConfTournBrac, 1, 0);
            this.tableLayoutPanelHeaderConfTournBrac.Controls.Add(this.buttonBackConfTournBrac, 3, 0);
            this.tableLayoutPanelHeaderConfTournBrac.Controls.Add(this.labelCurrentDayConfTournBrac, 1, 1);
            this.tableLayoutPanelHeaderConfTournBrac.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelHeaderConfTournBrac.Name = "tableLayoutPanelHeaderConfTournBrac";
            this.tableLayoutPanelHeaderConfTournBrac.RowCount = 2;
            this.tableLayoutPanelHeaderConfTournBrac.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanelHeaderConfTournBrac.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanelHeaderConfTournBrac.Size = new System.Drawing.Size(1263, 184);
            this.tableLayoutPanelHeaderConfTournBrac.TabIndex = 0;
            // 
            // labelConfTournConfTournBrac
            // 
            this.labelConfTournConfTournBrac.AutoSize = true;
            this.labelConfTournConfTournBrac.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.labelConfTournConfTournBrac.Location = new System.Drawing.Point(23, 0);
            this.labelConfTournConfTournBrac.Name = "labelConfTournConfTournBrac";
            this.labelConfTournConfTournBrac.Size = new System.Drawing.Size(318, 63);
            this.labelConfTournConfTournBrac.TabIndex = 0;
            this.labelConfTournConfTournBrac.Text = "Tournament";
            // 
            // buttonBackConfTournBrac
            // 
            this.buttonBackConfTournBrac.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBackConfTournBrac.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.buttonBackConfTournBrac.Location = new System.Drawing.Point(1043, 20);
            this.buttonBackConfTournBrac.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBackConfTournBrac.Name = "buttonBackConfTournBrac";
            this.buttonBackConfTournBrac.Size = new System.Drawing.Size(200, 100);
            this.buttonBackConfTournBrac.TabIndex = 5;
            this.buttonBackConfTournBrac.Text = "Back";
            this.buttonBackConfTournBrac.UseVisualStyleBackColor = true;
            this.buttonBackConfTournBrac.Click += new System.EventHandler(this.buttonBackConfTournBrac_Click);
            // 
            // labelCurrentDayConfTournBrac
            // 
            this.labelCurrentDayConfTournBrac.AutoSize = true;
            this.labelCurrentDayConfTournBrac.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelCurrentDayConfTournBrac.Location = new System.Drawing.Point(23, 120);
            this.labelCurrentDayConfTournBrac.Name = "labelCurrentDayConfTournBrac";
            this.labelCurrentDayConfTournBrac.Size = new System.Drawing.Size(235, 44);
            this.labelCurrentDayConfTournBrac.TabIndex = 7;
            this.labelCurrentDayConfTournBrac.Text = "Current Day:";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // goToToolStripMenuItem
            // 
            this.goToToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.scheduleToolStripMenuItem,
            this.standingsToolStripMenuItem,
            this.top25ToolStripMenuItem,
            this.tournamentProjectionToolStripMenuItem,
            this.conferenceTournamentToolStripMenuItem,
            this.championshipTournamentToolStripMenuItem});
            this.goToToolStripMenuItem.Name = "goToToolStripMenuItem";
            this.goToToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.goToToolStripMenuItem.Text = "Go To";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // scheduleToolStripMenuItem
            // 
            this.scheduleToolStripMenuItem.Name = "scheduleToolStripMenuItem";
            this.scheduleToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.scheduleToolStripMenuItem.Text = "Schedule";
            this.scheduleToolStripMenuItem.Click += new System.EventHandler(this.scheduleToolStripMenuItem_Click);
            // 
            // standingsToolStripMenuItem
            // 
            this.standingsToolStripMenuItem.Name = "standingsToolStripMenuItem";
            this.standingsToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.standingsToolStripMenuItem.Text = "Standings";
            this.standingsToolStripMenuItem.Click += new System.EventHandler(this.standingsToolStripMenuItem_Click);
            // 
            // top25ToolStripMenuItem
            // 
            this.top25ToolStripMenuItem.Name = "top25ToolStripMenuItem";
            this.top25ToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.top25ToolStripMenuItem.Text = "Top 25";
            this.top25ToolStripMenuItem.Click += new System.EventHandler(this.top25ToolStripMenuItem_Click);
            // 
            // tournamentProjectionToolStripMenuItem
            // 
            this.tournamentProjectionToolStripMenuItem.Name = "tournamentProjectionToolStripMenuItem";
            this.tournamentProjectionToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.tournamentProjectionToolStripMenuItem.Text = "Tournament Projection";
            this.tournamentProjectionToolStripMenuItem.Click += new System.EventHandler(this.tournamentProjectionToolStripMenuItem_Click);
            // 
            // conferenceTournamentToolStripMenuItem
            // 
            this.conferenceTournamentToolStripMenuItem.Name = "conferenceTournamentToolStripMenuItem";
            this.conferenceTournamentToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.conferenceTournamentToolStripMenuItem.Text = "Conference Tournament";
            this.conferenceTournamentToolStripMenuItem.Click += new System.EventHandler(this.conferenceTournamentToolStripMenuItem_Click);
            // 
            // championshipTournamentToolStripMenuItem
            // 
            this.championshipTournamentToolStripMenuItem.Name = "championshipTournamentToolStripMenuItem";
            this.championshipTournamentToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.championshipTournamentToolStripMenuItem.Text = "Championship Tournament";
            this.championshipTournamentToolStripMenuItem.Click += new System.EventHandler(this.championshipTournamentToolStripMenuItem_Click);
            // 
            // simulateToolStripMenuItem
            // 
            this.simulateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simToToolStripMenuItem,
            this.startFromPreviousDateToolStripMenuItem});
            this.simulateToolStripMenuItem.Name = "simulateToolStripMenuItem";
            this.simulateToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.simulateToolStripMenuItem.Text = "Simulate";
            // 
            // simToToolStripMenuItem
            // 
            this.simToToolStripMenuItem.Name = "simToToolStripMenuItem";
            this.simToToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.simToToolStripMenuItem.Text = "Sim To";
            this.simToToolStripMenuItem.Click += new System.EventHandler(this.simToToolStripMenuItem_Click);
            // 
            // startFromPreviousDateToolStripMenuItem
            // 
            this.startFromPreviousDateToolStripMenuItem.Name = "startFromPreviousDateToolStripMenuItem";
            this.startFromPreviousDateToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.startFromPreviousDateToolStripMenuItem.Text = "Start From Previous Date";
            this.startFromPreviousDateToolStripMenuItem.Click += new System.EventHandler(this.startFromPreviousDateToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.goToToolStripMenuItem,
            this.simulateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1286, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(1184, 0);
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1286, 578);
            this.Controls.Add(this.panelMainMenu);
            this.Controls.Add(this.panelSettings);
            this.Controls.Add(this.panelSaveFold);
            this.Controls.Add(this.panelSaveAs);
            this.Controls.Add(this.panelLoad);
            this.Controls.Add(this.panelStartFrom);
            this.Controls.Add(this.panelSimTo);
            this.Controls.Add(this.panelSchedFind);
            this.Controls.Add(this.panelTeamSched);
            this.Controls.Add(this.panelDateSched);
            this.Controls.Add(this.panelStand);
            this.Controls.Add(this.panelTop25);
            this.Controls.Add(this.panelTournProList);
            this.Controls.Add(this.panelTournProBrac);
            this.Controls.Add(this.panelConfTournBrac);
            this.Controls.Add(this.panelConfTournFind);
            this.Controls.Add(this.panelTournList);
            this.Controls.Add(this.panelTournBrac);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "College Basketball Simulator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMainMenuIntro.ResumeLayout(false);
            this.tableLayoutPanelAMainInt.ResumeLayout(false);
            this.tableLayoutPanelHeaderMainInt.ResumeLayout(false);
            this.tableLayoutPanelHeaderMainInt.PerformLayout();
            this.panelMainMenu.ResumeLayout(false);
            this.panelMainMenu.PerformLayout();
            this.tableLayoutPanelAMain.ResumeLayout(false);
            this.tableLayoutPanelHeaderMain.ResumeLayout(false);
            this.tableLayoutPanelHeaderMain.PerformLayout();
            this.panelSettings.ResumeLayout(false);
            this.tableLayoutPanelBSet.ResumeLayout(false);
            this.tableLayoutPanelBSet.PerformLayout();
            this.tableLayoutPanelASet.ResumeLayout(false);
            this.tableLayoutPanelASet.PerformLayout();
            this.tableLayoutPanelCSet.ResumeLayout(false);
            this.tableLayoutPanelHeaderSet.ResumeLayout(false);
            this.tableLayoutPanelHeaderSet.PerformLayout();
            this.panelSaveFold.ResumeLayout(false);
            this.tableLayoutPanelASaveFold.ResumeLayout(false);
            this.tableLayoutPanelASaveFold.PerformLayout();
            this.tableLayoutPanelBSaveFold.ResumeLayout(false);
            this.tableLayoutPanelHeaderSaveFold.ResumeLayout(false);
            this.tableLayoutPanelHeaderSaveFold.PerformLayout();
            this.panelSaveAs.ResumeLayout(false);
            this.tableLayoutPanelASaveAs.ResumeLayout(false);
            this.tableLayoutPanelASaveAs.PerformLayout();
            this.tableLayoutPanelBSaveAs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSavesSaveAs)).EndInit();
            this.tableLayoutPanelHeaderSaveAs.ResumeLayout(false);
            this.tableLayoutPanelHeaderSaveAs.PerformLayout();
            this.panelLoad.ResumeLayout(false);
            this.tableLayoutPanelALoad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoadsLoad)).EndInit();
            this.tableLayoutPanelHeaderLoad.ResumeLayout(false);
            this.tableLayoutPanelHeaderLoad.PerformLayout();
            this.panelSimTo.ResumeLayout(false);
            this.tableLayoutPanelBSimTo.ResumeLayout(false);
            this.tableLayoutPanelBSimTo.PerformLayout();
            this.tableLayoutPanelASimTo.ResumeLayout(false);
            this.tableLayoutPanelHeaderSimTo.ResumeLayout(false);
            this.tableLayoutPanelHeaderSimTo.PerformLayout();
            this.panelStartFrom.ResumeLayout(false);
            this.tableLayoutPanelBStartFrom.ResumeLayout(false);
            this.tableLayoutPanelBStartFrom.PerformLayout();
            this.tableLayoutPanelAStartFrom.ResumeLayout(false);
            this.tableLayoutPanelHeaderStartFrom.ResumeLayout(false);
            this.tableLayoutPanelHeaderStartFrom.PerformLayout();
            this.panelSchedFind.ResumeLayout(false);
            this.tableLayoutPanelASchedFind.ResumeLayout(false);
            this.tableLayoutPanelASchedFind.PerformLayout();
            this.tableLayoutPanelBSchedFind.ResumeLayout(false);
            this.tableLayoutPanelBSchedFind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeamsSchedFind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatesSchedFind)).EndInit();
            this.tableLayoutPanelHeaderSchedFind.ResumeLayout(false);
            this.tableLayoutPanelHeaderSchedFind.PerformLayout();
            this.panelTeamSched.ResumeLayout(false);
            this.tableLayoutPanelATeamSched.ResumeLayout(false);
            this.tableLayoutPanelATeamSched.PerformLayout();
            this.tableLayoutPanelBTeamSched.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeamSchedTeamSched)).EndInit();
            this.tableLayoutPanelHeaderTeamSched.ResumeLayout(false);
            this.tableLayoutPanelHeaderTeamSched.PerformLayout();
            this.panelDateSched.ResumeLayout(false);
            this.tableLayoutPanelADateSched.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDateSchedDateSched)).EndInit();
            this.tableLayoutPanelHeaderDateSched.ResumeLayout(false);
            this.tableLayoutPanelHeaderDateSched.PerformLayout();
            this.panelStand.ResumeLayout(false);
            this.panelStand.PerformLayout();
            this.tableLayoutPanelAStand.ResumeLayout(false);
            this.tableLayoutPanelAStand.PerformLayout();
            this.tableLayoutPanelBStand.ResumeLayout(false);
            this.tableLayoutPanelBStand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference1Stand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference2Stand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference3Stand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference4Stand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference5Stand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference6Stand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference7Stand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference8Stand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference9Stand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference10Stand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference11Stand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference12Stand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference13Stand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference14Stand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference15Stand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference16Stand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference17Stand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference18Stand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference19Stand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference20Stand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference21Stand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference22Stand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference23Stand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference24Stand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference25Stand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference26Stand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference27Stand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference28Stand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference29Stand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference30Stand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference31Stand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConference32Stand)).EndInit();
            this.tableLayoutPanelHeaderStand.ResumeLayout(false);
            this.tableLayoutPanelHeaderStand.PerformLayout();
            this.panelTop25.ResumeLayout(false);
            this.tableLayoutPanelATop25.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTop25Top25)).EndInit();
            this.tableLayoutPanelHeaderTop25.ResumeLayout(false);
            this.tableLayoutPanelHeaderTop25.PerformLayout();
            this.panelTournProList.ResumeLayout(false);
            this.tableLayoutPanelATournProList.ResumeLayout(false);
            this.tableLayoutPanelBTournProList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChampTournProListTournProList)).EndInit();
            this.tableLayoutPanelHeaderTournProList.ResumeLayout(false);
            this.tableLayoutPanelHeaderTournProList.PerformLayout();
            this.panelTournList.ResumeLayout(false);
            this.tableLayoutPanelATournList.ResumeLayout(false);
            this.tableLayoutPanelBTournList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChampTournListTournList)).EndInit();
            this.tableLayoutPanelHeaderTournList.ResumeLayout(false);
            this.tableLayoutPanelHeaderTournList.PerformLayout();
            this.panelTournProBrac.ResumeLayout(false);
            this.tableLayoutPanelATournProBrac.ResumeLayout(false);
            this.tableLayoutPanelBTournProBrac.ResumeLayout(false);
            this.tableLayoutPanelBTournProBrac.PerformLayout();
            this.tableLayoutPanelHeaderTournProBrac.ResumeLayout(false);
            this.tableLayoutPanelHeaderTournProBrac.PerformLayout();
            this.panelTournBrac.ResumeLayout(false);
            this.tableLayoutPanelATournBrac.ResumeLayout(false);
            this.tableLayoutPanelBTournBrac.ResumeLayout(false);
            this.tableLayoutPanelBTournBrac.PerformLayout();
            this.tableLayoutPanelHeaderTournBrac.ResumeLayout(false);
            this.tableLayoutPanelHeaderTournBrac.PerformLayout();
            this.panelConfTournFind.ResumeLayout(false);
            this.tableLayoutPanelAConfTournFind.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConferencesConfTournFind)).EndInit();
            this.tableLayoutPanelHeaderConfTournFind.ResumeLayout(false);
            this.tableLayoutPanelHeaderConfTournFind.PerformLayout();
            this.panelConfTournBrac.ResumeLayout(false);
            this.tableLayoutPanelAConfTournBrac.ResumeLayout(false);
            this.tableLayoutPanelAConfTournBrac.PerformLayout();
            this.tableLayoutPanelBConfTournBrac.ResumeLayout(false);
            this.tableLayoutPanelBConfTournBrac.PerformLayout();
            this.tableLayoutPanelHeaderConfTournBrac.ResumeLayout(false);
            this.tableLayoutPanelHeaderConfTournBrac.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelMainMenuIntro;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAMainInt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelHeaderMainInt;
        private System.Windows.Forms.Button buttonImportDataMainInt;
        private System.Windows.Forms.Button buttonSettingsMainInt;
        private System.Windows.Forms.Label labelMainMenuMainInt;
        private System.Windows.Forms.Panel panelMainMenu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAMain;
        private System.Windows.Forms.Button buttonImportDataMain;
        private System.Windows.Forms.Button buttonSettingsMain;
        private System.Windows.Forms.Button buttonSimulateMain;
        private System.Windows.Forms.Button buttonRestartDateMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelHeaderMain;
        private System.Windows.Forms.Label labelMainMenuMain;
        private System.Windows.Forms.Button buttonBackMain;
        private System.Windows.Forms.Label labelCurrentDayMain;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCSet;
        private System.Windows.Forms.Button buttonCancelSet;
        private System.Windows.Forms.Button buttonSaveSettingsSet;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelHeaderSet;
        private System.Windows.Forms.Label labelSettingsSet;
        private System.Windows.Forms.Button buttonBackSet;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBSet;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelASet;
        private System.Windows.Forms.TextBox textBoxSaveFoldLocationSet;
        private System.Windows.Forms.Label labelSimTypeSet;
        private System.Windows.Forms.Label labelSaveLocationSet;
        private System.Windows.Forms.ComboBox comboBoxSimTypeSet;
        private System.Windows.Forms.Label labelDistributionRangeSet;
        private System.Windows.Forms.Label labelToSet;
        private System.Windows.Forms.TextBox textBoxMinScoreRangeSet;
        private System.Windows.Forms.Label labelMinAndMaxSet;
        private System.Windows.Forms.TextBox textBoxMaxScoreRangeSet;
        private System.Windows.Forms.TextBox textBoxScoreDistRangeSet;
        private System.Windows.Forms.Panel panelSaveFold;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelASaveFold;
        private System.Windows.Forms.TextBox textBoxSaveFoldLocationSaveFold;
        private System.Windows.Forms.Label labelSaveLocationSaveFold;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBSaveFold;
        private System.Windows.Forms.Button buttonSaveSettingsSaveFold;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelHeaderSaveFold;
        private System.Windows.Forms.Label labelSaveFolderSettingsSaveFold;
        private System.Windows.Forms.Panel panelSaveAs;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelASaveAs;
        private System.Windows.Forms.Button buttonSaveSaveAs;
        private System.Windows.Forms.TextBox textBoxSaveNameSaveAs;
        private System.Windows.Forms.Label labelSaveNameSaveAs;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBSaveAs;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelHeaderSaveAs;
        private System.Windows.Forms.Label labelSaveAsSaveAs;
        private System.Windows.Forms.Button buttonBackSaveAs;
        private System.Windows.Forms.DataGridView dataGridViewSavesSaveAs;
        private System.Windows.Forms.Panel panelLoad;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelALoad;
        private System.Windows.Forms.DataGridView dataGridViewLoadsLoad;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelHeaderLoad;
        private System.Windows.Forms.Label labelLoadLoad;
        private System.Windows.Forms.Button buttonBackLoad;
        private System.Windows.Forms.Panel panelSimTo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBSimTo;
        private System.Windows.Forms.Label labelYearSimTo;
        private System.Windows.Forms.Label labelYear20SimTo;
        private System.Windows.Forms.ComboBox comboBoxMonthSimTo;
        private System.Windows.Forms.Label labelDaySimTo;
        private System.Windows.Forms.Label labelMonthSimTo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelASimTo;
        private System.Windows.Forms.Button buttonSimToEndSimTo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelHeaderSimTo;
        private System.Windows.Forms.Label labelSimToSimTo;
        private System.Windows.Forms.Button buttonBackSimTo;
        private System.Windows.Forms.Label labelCurrentDaySimTo;
        private System.Windows.Forms.Button buttonGoSimTo;
        private System.Windows.Forms.ComboBox comboBoxDaySimTo;
        private System.Windows.Forms.Panel panelStartFrom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBStartFrom;
        private System.Windows.Forms.Label labelDayStartFrom;
        private System.Windows.Forms.Label labelMonthStartFrom;
        private System.Windows.Forms.ComboBox comboBoxMonthStartFrom;
        private System.Windows.Forms.Label labelYearStartFrom;
        private System.Windows.Forms.Label labelYear20StartFrom;
        private System.Windows.Forms.Button buttonGoStartFrom;
        private System.Windows.Forms.ComboBox comboBoxDayStartFrom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAStartFrom;
        private System.Windows.Forms.Button buttonStartFromBegStartFrom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelHeaderStartFrom;
        private System.Windows.Forms.Label labelStartFromPrevStartFrom;
        private System.Windows.Forms.Button buttonBackStartFrom;
        private System.Windows.Forms.Label labelCurrentDayStartFrom;
        private System.Windows.Forms.Panel panelSchedFind;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBSchedFind;
        private System.Windows.Forms.Label labelSelectTeamSchedFind;
        private System.Windows.Forms.Label labelSelectDateSchedFind;
        private System.Windows.Forms.DataGridView dataGridViewTeamsSchedFind;
        private System.Windows.Forms.DataGridView dataGridViewDatesSchedFind;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelHeaderSchedFind;
        private System.Windows.Forms.Label labelScheduleSchedFind;
        private System.Windows.Forms.Button buttonBackSchedFind;
        private System.Windows.Forms.Label labelCurrentDaySchedFind;
        private System.Windows.Forms.Panel panelTeamSched;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelATeamSched;
        private System.Windows.Forms.Label labelRecordTeamSched;
        private System.Windows.Forms.Label labelConfRecordTeamSched;
        private System.Windows.Forms.Label labelRecWinsTeamSched;
        private System.Windows.Forms.Label labelRecLossesTeamSched;
        private System.Windows.Forms.Label labelConfRecWinsTeamSched;
        private System.Windows.Forms.Label labelConfRecLossesTeamSched;
        private System.Windows.Forms.Label labelRecDashTeamSched;
        private System.Windows.Forms.Label labelConfRecDashTeamSched;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBTeamSched;
        private System.Windows.Forms.DataGridView dataGridViewTeamSchedTeamSched;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelHeaderTeamSched;
        private System.Windows.Forms.Label labelTeamSchedTeamSched;
        private System.Windows.Forms.Button buttonBackTeamSched;
        private System.Windows.Forms.Label labelCurrentDayTeamSched;
        private System.Windows.Forms.Panel panelDateSched;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelADateSched;
        private System.Windows.Forms.DataGridView dataGridViewDateSchedDateSched;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelHeaderDateSched;
        private System.Windows.Forms.Label labelDateSchedDateSched;
        private System.Windows.Forms.Button buttonBackDateSched;
        private System.Windows.Forms.Label labelCurrentDayDateSched;
        private System.Windows.Forms.Panel panelStand;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAStand;
        private System.Windows.Forms.Label labelGoToConferenceStand;
        private System.Windows.Forms.ComboBox comboBoxConferencesStand;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBStand;
        private System.Windows.Forms.DataGridView dataGridViewConference1Stand;
        private System.Windows.Forms.Label labelConference1Stand;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelHeaderStand;
        private System.Windows.Forms.Label labelStandingsStand;
        private System.Windows.Forms.Button buttonBackStand;
        private System.Windows.Forms.Label labelCurrentDayStand;
        private System.Windows.Forms.Label labelConference8Stand;
        private System.Windows.Forms.Label labelConference9Stand;
        private System.Windows.Forms.Label labelConference10Stand;
        private System.Windows.Forms.DataGridView dataGridViewConference7Stand;
        private System.Windows.Forms.DataGridView dataGridViewConference4Stand;
        private System.Windows.Forms.Label labelConference7Stand;
        private System.Windows.Forms.Label labelConference6Stand;
        private System.Windows.Forms.DataGridView dataGridViewConference6Stand;
        private System.Windows.Forms.Label labelConference4Stand;
        private System.Windows.Forms.Label labelConference2Stand;
        private System.Windows.Forms.DataGridView dataGridViewConference2Stand;
        private System.Windows.Forms.Label labelConference3Stand;
        private System.Windows.Forms.DataGridView dataGridViewConference3Stand;
        private System.Windows.Forms.Label labelConference5Stand;
        private System.Windows.Forms.DataGridView dataGridViewConference5Stand;
        private System.Windows.Forms.DataGridView dataGridViewConference13Stand;
        private System.Windows.Forms.DataGridView dataGridViewConference10Stand;
        private System.Windows.Forms.DataGridView dataGridViewConference8Stand;
        private System.Windows.Forms.DataGridView dataGridViewConference9Stand;
        private System.Windows.Forms.Label labelConference11Stand;
        private System.Windows.Forms.DataGridView dataGridViewConference11Stand;
        private System.Windows.Forms.Label labelConference12Stand;
        private System.Windows.Forms.DataGridView dataGridViewConference12Stand;
        private System.Windows.Forms.Label labelConference13Stand;
        private System.Windows.Forms.Label labelConference18Stand;
        private System.Windows.Forms.DataGridView dataGridViewConference18Stand;
        private System.Windows.Forms.DataGridView dataGridViewConference17Stand;
        private System.Windows.Forms.Label labelConference14Stand;
        private System.Windows.Forms.DataGridView dataGridViewConference14Stand;
        private System.Windows.Forms.Label labelConference15Stand;
        private System.Windows.Forms.DataGridView dataGridViewConference15Stand;
        private System.Windows.Forms.Label labelConference16Stand;
        private System.Windows.Forms.DataGridView dataGridViewConference16Stand;
        private System.Windows.Forms.Label labelConference17Stand;
        private System.Windows.Forms.DataGridView dataGridViewConference32Stand;
        private System.Windows.Forms.Label labelConference32Stand;
        private System.Windows.Forms.DataGridView dataGridViewConference31Stand;
        private System.Windows.Forms.Label labelConference31Stand;
        private System.Windows.Forms.DataGridView dataGridViewConference30Stand;
        private System.Windows.Forms.Label labelConference30Stand;
        private System.Windows.Forms.DataGridView dataGridViewConference28Stand;
        private System.Windows.Forms.Label labelConference28Stand;
        private System.Windows.Forms.DataGridView dataGridViewConference27Stand;
        private System.Windows.Forms.Label labelConference27Stand;
        private System.Windows.Forms.DataGridView dataGridViewConference26Stand;
        private System.Windows.Forms.Label labelConference26Stand;
        private System.Windows.Forms.DataGridView dataGridViewConference23Stand;
        private System.Windows.Forms.Label labelConference23Stand;
        private System.Windows.Forms.DataGridView dataGridViewConference22Stand;
        private System.Windows.Forms.Label labelConference22Stand;
        private System.Windows.Forms.DataGridView dataGridViewConference21Stand;
        private System.Windows.Forms.Label labelConference21Stand;
        private System.Windows.Forms.Label labelConference19Stand;
        private System.Windows.Forms.DataGridView dataGridViewConference19Stand;
        private System.Windows.Forms.Label labelConference20Stand;
        private System.Windows.Forms.DataGridView dataGridViewConference20Stand;
        private System.Windows.Forms.Label labelConference24Stand;
        private System.Windows.Forms.DataGridView dataGridViewConference24Stand;
        private System.Windows.Forms.Label labelConference25Stand;
        private System.Windows.Forms.DataGridView dataGridViewConference25Stand;
        private System.Windows.Forms.Label labelConference29Stand;
        private System.Windows.Forms.DataGridView dataGridViewConference29Stand;
        private System.Windows.Forms.Panel panelTop25;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelATop25;
        private System.Windows.Forms.DataGridView dataGridViewTop25Top25;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelHeaderTop25;
        private System.Windows.Forms.Label labelTop25Top25;
        private System.Windows.Forms.Button buttonBackTop25;
        private System.Windows.Forms.Label labelCurrentDayTop25;
        private System.Windows.Forms.Panel panelTournProList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelATournProList;
        private System.Windows.Forms.Button buttonBracketTournProList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBTournProList;
        private System.Windows.Forms.DataGridView dataGridViewChampTournProListTournProList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelHeaderTournProList;
        private System.Windows.Forms.Label labelChampTournProjTournProList;
        private System.Windows.Forms.Button buttonBackTournProList;
        private System.Windows.Forms.Label labelCurrentDayTournProList;
        private System.Windows.Forms.Panel panelTournList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelATournList;
        private System.Windows.Forms.Button buttonBracketTournList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBTournList;
        private System.Windows.Forms.DataGridView dataGridViewChampTournListTournList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelHeaderTournList;
        private System.Windows.Forms.Label labelChampTournTournList;
        private System.Windows.Forms.Button buttonBackTournList;
        private System.Windows.Forms.Label labelCurrentDayTournList;
        private System.Windows.Forms.Panel panelTournProBrac;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelATournProBrac;
        private System.Windows.Forms.Button buttonWestTournProBrac;
        private System.Windows.Forms.Button buttonMidwestTournProBrac;
        private System.Windows.Forms.Button buttonEastTournProBrac;
        private System.Windows.Forms.Button buttonSouthTournProBrac;
        private System.Windows.Forms.Button buttonFullBracketTournProBrac;
        private System.Windows.Forms.Button buttonListViewTournProBrac;
        private System.Windows.Forms.Button buttonSweet16TournProBrac;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBTournProBrac;
        private System.Windows.Forms.TextBox textBoxChampTournProBracTournProBrac;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelHeaderTournProBrac;
        private System.Windows.Forms.Label labelChampTournProTournProBrac;
        private System.Windows.Forms.Button buttonBackTournProBrac;
        private System.Windows.Forms.Label labelCurrentDayTournProBrac;
        private System.Windows.Forms.Panel panelTournBrac;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelATournBrac;
        private System.Windows.Forms.Button buttonWestTournBrac;
        private System.Windows.Forms.Button buttonMidwestTournBrac;
        private System.Windows.Forms.Button buttonEastTournBrac;
        private System.Windows.Forms.Button buttonSouthTournBrac;
        private System.Windows.Forms.Button buttonFullBracketTournBrac;
        private System.Windows.Forms.Button buttonListViewTournBrac;
        private System.Windows.Forms.Button buttonSweet16TournBrac;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBTournBrac;
        private System.Windows.Forms.TextBox textBoxChampTournBracTournBrac;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelHeaderTournBrac;
        private System.Windows.Forms.Label labelChampTournTournBrac;
        private System.Windows.Forms.Button buttonBackTournBrac;
        private System.Windows.Forms.Label labelCurrentDayTournBrac;
        private System.Windows.Forms.Panel panelConfTournFind;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAConfTournFind;
        private System.Windows.Forms.DataGridView dataGridViewConferencesConfTournFind;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelHeaderConfTournFind;
        private System.Windows.Forms.Label labelConfTournConfTournFind;
        private System.Windows.Forms.Button buttonBackConfTournFind;
        private System.Windows.Forms.Label labelCurrentDayConfTournFind;
        private System.Windows.Forms.Panel panelConfTournBrac;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAConfTournBrac;
        private System.Windows.Forms.ComboBox comboBoxConferencesConfTournBrac;
        private System.Windows.Forms.Label labelGoToConfConfTournBrac;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBConfTournBrac;
        private System.Windows.Forms.TextBox textBoxConfTournBracConfTournBrac;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelHeaderConfTournBrac;
        private System.Windows.Forms.Label labelConfTournConfTournBrac;
        private System.Windows.Forms.Button buttonBackConfTournBrac;
        private System.Windows.Forms.Label labelCurrentDayConfTournBrac;
        private System.Windows.Forms.Button buttonGoStand;
        private System.Windows.Forms.Button buttonGoConfTournBrac;
        private System.Windows.Forms.Button buttonBackMainIntro;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelASchedFind;
        private System.Windows.Forms.Button buttonFilterSchedFind;
        private System.Windows.Forms.Label labelFilterConfSchedFind;
        private System.Windows.Forms.ComboBox comboBoxConfSchedFind;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem top25ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tournamentProjectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conferenceTournamentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem championshipTournamentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simulateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startFromPreviousDateToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

