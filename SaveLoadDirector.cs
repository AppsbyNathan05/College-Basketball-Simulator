using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace College_Basketball_Simulator
{
    class SaveLoadDirector
    {
        //STATIC DATA RESOURCES
        private Resources appResources = new Resources();

        //SETTINGS
        private SettingsDirector settingsDirector = new SettingsDirector();

        //NAME OF SAVE (NO NAME IMPLIES SIMULATION HAS NOT BEEN SAVED)
        private string currentSaveDisplayFileName = "";

        //TODAYS DATE
        private DateTime currentDate = DateTime.Now;

        public SaveLoadDirector()
        {

        } //END

        //---------------------------------------------------------------------
        //---------------------------------------------------------------------
        //FILE MANAGEMENT------------------------------------------------------
        //---------------------------------------------------------------------
        //---------------------------------------------------------------------

        //---------------------------------------------------------------------
        //GET FILE PATH ARRAY--------------------------------------------------
        //---------------------------------------------------------------------

        public string[] getFilePathsArray()
        {
            //ARRAY OF ALL FILES IN SAVE FOLDER
            string[] filePathsArray = Directory.GetFiles(getSaveFolder(), "*.txt");

            return filePathsArray;
        } //END

        //---------------------------------------------------------------------
        //GET LINES FROM FILE--------------------------------------------------
        //---------------------------------------------------------------------

        private string[] getLinesFromFile(string filePath)
        {
            //RETURNS TEXT LINES FROM FILE IN A STRING ARRAY
            return System.IO.File.ReadAllLines(filePath);
        } //END

        //---------------------------------------------------------------------
        //CONTAINS FILE--------------------------------------------------------
        //---------------------------------------------------------------------

        public Boolean containsRatingsFile()
        {
            //ARRAY OF ALL FILES IN SAVE FOLDER
            string[] filePathsArray = getFilePathsArray();

            //FOR EACH FILE IN FILE ARRAY
            foreach (string fileNamePath in filePathsArray)
            {
                //IF RATINGS FILE
                if (isARatingsFile(fileNamePath))
                {
                    //FILE FOUND
                    return true;
                } //END IF
            } //END FOR
            //NO FILE FOUND
            return false;
        } //END

        public Boolean containsScheduleFile()
        {
            //ARRAY OF ALL FILES IN SAVE FOLDER
            string[] filePathsArray = getFilePathsArray();

            //FOR EACH FILE IN FILE ARRAY
            foreach (string fileNamePath in filePathsArray)
            {
                //IF SCHEDULE FILE
                if (isAScheduleFile(fileNamePath))
                {
                    //FILE FOUND
                    return true;
                } //END IF
            } //END FOR
            //NO FILE FOUND
            return false;
        } //END

        private Boolean containsSettingsFile()
        {
            //ARRAY OF ALL FILES IN SAVE FOLDER
            string[] filePathsArray = getFilePathsArray();

            //FOR EACH FILE IN FILE ARRAY
            foreach (string fileNamePath in filePathsArray)
            {
                //IF SETTINGS FILE
                if (isASettingsFile(fileNamePath))
                {
                    //FILE FOUND
                    return true;
                } //END IF
            } //END FOR
            //NO FILE FOUND
            return false;
        } //END

        private Boolean containsSaveFile(string displayFileName)
        {
            //ARRAY OF ALL FILES IN SAVE FOLDER
            string[] filePathsArray = getFilePathsArray();

            //FOR EACH FILE IN FILE ARRAY
            foreach (string fileNamePath in filePathsArray)
            {
                //IF SAVE FILE
                if (isASaveFile(fileNamePath) && fileNamePath.Contains(displayFileName))
                {
                    //FILE FOUND
                    return true;
                } //END IF
            } //END FOR
            //NO FILE FOUND
            return false;
        } //END

        //---------------------------------------------------------------------
        //GET FILE NAME PATH---------------------------------------------------
        //---------------------------------------------------------------------

        private string getRatingsFileNamePath()
        {
            //ARRAY OF ALL FILES IN SAVE FOLDER
            string[] filePathsArray = getFilePathsArray();

            //FOR EACH FILE IN FILE ARRAY
            foreach (string fileNamePath in filePathsArray)
            {
                //IF RATINGS FILE
                if (isARatingsFile(fileNamePath))
                {
                    //FILE FOUND
                    return fileNamePath;
                } //END IF
            } //END FOR
            //NO FILE FOUND
            System.Windows.Forms.MessageBox.Show("ERROR: NO RATINGS FILE FOUND");
            return "";
        } //END

        private string getScheduleFileNamePath()
        {
            //ARRAY OF ALL FILES IN SAVE FOLDER
            string[] filePathsArray = getFilePathsArray();

            //FOR EACH FILE IN FILE ARRAY
            foreach (string fileNamePath in filePathsArray)
            {
                //IF SCHEDULE FILE
                if (isAScheduleFile(fileNamePath))
                {
                    //FILE FOUND
                    return fileNamePath;
                } //END IF
            } //END FOR
            //NO FILE FOUND
            System.Windows.Forms.MessageBox.Show("ERROR: NO SCHEDULE FILE FOUND");
            return "";
        } //END

        private string getSettingsFileNamePath()
        {
            //ARRAY OF ALL FILES IN SAVE FOLDER
            string[] filePathsArray = getFilePathsArray();

            //FOR EACH FILE IN FILE ARRAY
            foreach (string fileNamePath in filePathsArray)
            {
                //IF SETTINGS FILE
                if (isASettingsFile(fileNamePath))
                {
                    //FILE FOUND
                    return fileNamePath;
                } //END IF
            } //END FOR
            //NO FILE FOUND
            System.Windows.Forms.MessageBox.Show("ERROR: NO SETTINGS FILE FOUND");
            return "";
        } //END

        private string getSaveFileNamePath(string displayFileName)
        {
            //ARRAY OF ALL FILES IN SAVE FOLDER
            string[] filePathsArray = getFilePathsArray();

            foreach (string fileNamePath in filePathsArray)
            {
                //IF DISPLAY FILE NAME IN FILE PATH
                if (isASaveFile(fileNamePath) && fileNamePath.Contains(displayFileName))
                {
                    //FILE FOUND
                    return fileNamePath;
                } //END IF
            } //END FOR
            //NO FILE FOUND
            System.Windows.Forms.MessageBox.Show("ERROR: NO SAVE FILE FOUND");
            return "";
        } //END

        //---------------------------------------------------------------------
        //VERIFY FILE NAME-----------------------------------------------------
        //---------------------------------------------------------------------

        public Boolean isASaveFile(string fileNamePath)
        {
            //IF SAVE FILE
            return fileNamePath.Contains(")-#_#_#+(=") && fileNamePath.Contains("=)+#_#_#-(");
        } //END

        private Boolean isASettingsFile(string fileNamePath)
        {
            //IF SETTINGS FILE
            return fileNamePath.Contains("SETTINGS)-#!#!#+(=") && fileNamePath.Contains("=)+#!#!#-(");
        } //END

        private Boolean isAScheduleFile(string fileNamePath)
        {
            //IF SCHEDULE FILE
            return fileNamePath.Contains("SCHEDULE)-#$#$#+(=") && fileNamePath.Contains("=)+#$#$#-(");
        } //END

        private Boolean isARatingsFile(string fileNamePath)
        {
            //IF RATINGS FILE
            return fileNamePath.Contains("RATINGS)-#^#^#+(=") && fileNamePath.Contains("=)+#^#^#-(");
        } //END

        //---------------------------------------------------------------------
        //CREATE FILE NAME-----------------------------------------------------
        //---------------------------------------------------------------------

        //CREATE DISPLAY FILE NAME---------------------------------------------

        public string convertToSaveDisplayFileName(string fileName)
        {
            //CUT TO FILE NAME START
            fileName = fileName.Substring(fileName.LastIndexOf(@"\") + 1);

            //TRIM MARKER
            fileName = fileName.Substring(fileName.IndexOf(")-#_#_#+(=") + 10);

            //TRIM MARKER
            fileName = fileName.Substring(0, fileName.IndexOf("=)+#_#_#-(") - 1);

            //RETURN FILE NAME
            return fileName;
        } //END

        //CREATE FILE NAME PATH------------------------------------------------

        private string convertToSaveFileNamePath(string displayFileName)
        {
            //RETURN FILE NAME PATH
            return getSaveFolder() + "\\)-#_#_#+(=" + displayFileName + "=)+#_#_#-(.txt";
        } //END

        private string createScheduleFileNamePath()
        {
            //RETURN FILE NAME PATH
            return getSaveFolder() + "\\SCHEDULE)-#$#$#+(=" + currentDate.Month + currentDate.Day + currentDate.Year + "=)+#$#$#-(.txt";
        } //END

        private string createRatingsFileNamePath()
        {
            //RETURN FILE NAME PATH
            return getSaveFolder() + "\\RATINGS)-#^#^#+(=" + currentDate.Month + currentDate.Day + currentDate.Year + "=)+#^#^#-(.txt";
        } //END

        //---------------------------------------------------------------------
        //---------------------------------------------------------------------
        //GET SAVE AND LOAD FILE NAMES-----------------------------------------
        //---------------------------------------------------------------------
        //---------------------------------------------------------------------

        public string[] getSaveLoadDataTableFileNames()
        {
            //STRING ARRAY VARIABLE
            string[] saveLoadfileNameArray = new string[getFilePathsArray().Length];

            //INDEX
            int index = 0;

            //FOREACH FILE IN SAVE FOLDER
            foreach (string filePath in getFilePathsArray())
            {
                //IF SAVE FILE
                if (isASaveFile(filePath))
                {
                    //ADD TO ARRAY
                    saveLoadfileNameArray[index] = convertToSaveDisplayFileName(filePath);

                    index++;
                } //END IF SAVE FILE
            } //END FOREACH FILE IN SAVE FOLDER

            return saveLoadfileNameArray;
        } //END

        //---------------------------------------------------------------------
        //---------------------------------------------------------------------
        //SIMULATION SAVES-----------------------------------------------------
        //---------------------------------------------------------------------
        //---------------------------------------------------------------------

        //---------------------------------------------------------------------
        //CHECK IF-------------------------------------------------------------
        //---------------------------------------------------------------------

        public Boolean checkIfSimulationSaves()
        {
            //CHECK IF SAVES TO LOAD
            string[] filePathsArray = getFilePathsArray();
            foreach (string fileNamePath in filePathsArray)
            {
                //IF SAVED SIMULATION
                if (isASaveFile(fileNamePath))
                {
                    //SAVED SIMULATION EXISTS
                    return true;
                } //END
            } //END
            //NO SIMULATION EXISTS
            return false;
        } //END

        //---------------------------------------------------------------------
        //SAVE-----------------------------------------------------------------
        //---------------------------------------------------------------------

        public Boolean saveNewSimulation(SimulationDirector simulationDirector, SettingsDirector settingsDirector, string displayFileName)
        {
            //CREATE NEW SIM RESULTS SAVE

            //LINE TO BE WRITTEN
            string displayLine = "";

            //IF SAVE FOLDER
            if (checkForSaveFolder())
            {

                //IF SAVE FILE
                //DELETE SAVE FILE
                if (containsSaveFile(displayFileName))
                {
                    File.Delete(convertToSaveFileNamePath(displayFileName));
                } //END IF SCHEDULE FILE

                //WRITE SCHEDULE TO FILE
                using (StreamWriter writer = File.CreateText(convertToSaveFileNamePath(displayFileName)))
                {
                    //WRITE SETTINGS TO FILE
                    writer.WriteLine(settingsDirector.minScoringAverage);
                    writer.WriteLine(settingsDirector.maxScoringAverage);
                    writer.WriteLine(settingsDirector.scoringDistribution);
                    writer.WriteLine(settingsDirector.simulationType);
                    writer.WriteLine(settingsDirector.getEarliestGameDate());
                    writer.WriteLine(settingsDirector.getHighestOffensiveRating());
                    writer.WriteLine(settingsDirector.getLowestOffensiveRating());
                    writer.WriteLine(settingsDirector.getHighestDefensiveRating());
                    writer.WriteLine(settingsDirector.getLowestDefensiveRating());

                    //SAVE CONFERENCE TOURNAMENTS
                    for (int confIndex = 0; confIndex < appResources.getLengthOfConferenceNames(); confIndex++)
                    {
                        writer.WriteLine(simulationDirector.getNumberOfRounds(confIndex));
                        for (int roundIndex = 0; roundIndex < simulationDirector.getNumberOfRounds(confIndex); roundIndex++)
                        {
                            displayLine = "";
                            writer.WriteLine(simulationDirector.getRoundLength(confIndex, roundIndex));
                            for (int rowIndex = 0; rowIndex < simulationDirector.getRoundLength(confIndex, roundIndex); rowIndex++)
                            {
                                displayLine = displayLine + simulationDirector.getTeamIndex(confIndex, roundIndex, rowIndex) + " # ";
                            }//END FOR
                            writer.WriteLine(displayLine + " ");
                        }//END FOR
                    }//END FOR ALL CONFERENCES

                    //SAVE CHAMPIONSHIP TOURNAMENT
                    writer.WriteLine(simulationDirector.getNumberOfRounds());
                    for (int roundIndex = 0; roundIndex < simulationDirector.getNumberOfRounds(); roundIndex++)
                    {
                        displayLine = "";
                        writer.WriteLine(simulationDirector.getRoundLength(roundIndex));
                        for (int rowIndex = 0; rowIndex < simulationDirector.getRoundLength(roundIndex); rowIndex++)
                        {
                            displayLine = displayLine + simulationDirector.getTeamIndex(roundIndex, rowIndex) + " # ";
                        }//END FOR
                        writer.WriteLine(displayLine + " ");
                    }//END FOR

                    //WRITE BREAK
                    writer.WriteLine(" ###### ");

                    //FOR ALL TEAMS
                    for (int teamIndex = 0; teamIndex < appResources.getLengthOfTeamNames(); teamIndex++)
                    {

                        //WRITE TEAM NAME
                        writer.WriteLine(appResources.getTeamName(teamIndex));

                        //WRITE RATINGS
                        writer.WriteLine(simulationDirector.getOffensiveRating(teamIndex));
                        writer.WriteLine(simulationDirector.getDefensiveRating(teamIndex));

                        //SCORING AVERAGES
                        writer.WriteLine(simulationDirector.getOffensivescoring(teamIndex));
                        writer.WriteLine(simulationDirector.getDefensivescoring(teamIndex));

                        //TOURNAMENTS VARIABLES
                        writer.WriteLine(simulationDirector.getConfTournSeed(teamIndex));
                        writer.WriteLine(simulationDirector.getChampTournParticipant(teamIndex));
                        writer.WriteLine(simulationDirector.getChampTournSeed(teamIndex));
                        writer.WriteLine(simulationDirector.getChampTournRegion(teamIndex));
                        writer.WriteLine(simulationDirector.getPlayInParticipant(teamIndex));

                        //WRITE BREAK
                        writer.WriteLine(" ###### ");

                        //GET SCHEDULE
                        Schedule schedule = new Schedule();

                        schedule.setSchedule(simulationDirector.getSchedule(teamIndex)); 
                            

                        //WRITE TEAM NAME
                        writer.WriteLine(appResources.getTeamName(teamIndex));

                        //FOR ALL ROWS IN SIM REGULAR SEASON SCHEDULE
                        for (int rIndex = 0; rIndex < schedule.getLengthOfSchedule(appResources.getScheduleTypeText(5)); rIndex++)
                        {
                            // 1 Sim RegularSeason

                            //RESET DISPLAY LINE
                            displayLine = "";

                            //APPEND GAME INFO TO LINE

                            // ScheduleType
                            // Date
                            // Opponent
                            // Opponent Index
                            // Opponent Row Index
                            // Real Points
                            // Real Opponent Points
                            // Sim Points
                            // Sim Opponent Points
                            // Conference Game

                            displayLine = displayLine + appResources.getScheduleTypeText(5);
                            displayLine = displayLine + " ### " + schedule.getDate(rIndex, appResources.getScheduleTypeText(5));
                            displayLine = displayLine + " ### " + schedule.getOpponentName(rIndex, appResources.getScheduleTypeText(5));
                            displayLine = displayLine + " ### " + schedule.getOpponentIndex(rIndex, appResources.getScheduleTypeText(5));
                            displayLine = displayLine + " ### " + schedule.getOpponentRowIndex(rIndex, appResources.getScheduleTypeText(5));
                            displayLine = displayLine + " ### " + schedule.getPoints(rIndex, appResources.getScheduleTypeText(5));
                            displayLine = displayLine + " ### " + schedule.getOpponentPoints(rIndex, appResources.getScheduleTypeText(5));
                            displayLine = displayLine + " ### " + schedule.getConferenceGame(rIndex, appResources.getScheduleTypeText(5));
                            displayLine = displayLine + " ### " + schedule.getPoints(rIndex, appResources.getScheduleTypeText(1));
                            displayLine = displayLine + " ### " + schedule.getOpponentPoints(rIndex, appResources.getScheduleTypeText(1));

                            //WRITE TO FILE
                            writer.WriteLine(displayLine);
                        } //END FOR ALL

                        //FOR ALL ROWS IN REAL CONFERECE TOURNAMENT SCHEDULE
                        for (int rIndex = 0; rIndex < schedule.getLengthOfSchedule(appResources.getScheduleTypeText(2)); rIndex++)
                        {
                            // 2 Real ConferenceTournament

                            //RESET DISPLAY LINE
                            displayLine = "";

                            //APPEND GAME INFO TO LINE

                            // ScheduleType
                            // Date
                            // Opponent
                            // Opponent Index
                            // Opponent Row Index
                            // Real Points
                            // Real Opponent Points
                            // Round

                            displayLine = displayLine + appResources.getScheduleTypeText(2);
                            displayLine = displayLine + " ### " + schedule.getDate(rIndex, appResources.getScheduleTypeText(2));
                            displayLine = displayLine + " ### " + schedule.getOpponentName(rIndex, appResources.getScheduleTypeText(2));
                            displayLine = displayLine + " ### " + schedule.getOpponentIndex(rIndex, appResources.getScheduleTypeText(2));
                            displayLine = displayLine + " ### " + schedule.getOpponentRowIndex(rIndex, appResources.getScheduleTypeText(2));
                            displayLine = displayLine + " ### " + schedule.getPoints(rIndex, appResources.getScheduleTypeText(2));
                            displayLine = displayLine + " ### " + schedule.getOpponentPoints(rIndex, appResources.getScheduleTypeText(2));
                            displayLine = displayLine + " ### " + schedule.getConfTournRound(rIndex, appResources.getScheduleTypeText(2));

                            //WRITE TO FILE
                            writer.WriteLine(displayLine);
                        } //END FOR ALL

                        //FOR ALL ROWS IN SIM CONFERECE TOURNAMENT SCHEDULE
                        for (int rIndex = 0; rIndex < schedule.getLengthOfSchedule(appResources.getScheduleTypeText(6)); rIndex++)
                        {
                            // 2 Sim ConferenceTournament

                            //RESET DISPLAY LINE
                            displayLine = "";

                            //APPEND GAME INFO TO LINE

                            // ScheduleType
                            // Date
                            // Opponent
                            // Opponent Index
                            // Opponent Row Index
                            // Sim Points
                            // Sim Opponent Points
                            // Round
                            // Row

                            displayLine = displayLine + appResources.getScheduleTypeText(6);
                            displayLine = displayLine + " ### " + schedule.getDate(rIndex, appResources.getScheduleTypeText(6));
                            displayLine = displayLine + " ### " + schedule.getOpponentName(rIndex, appResources.getScheduleTypeText(6));
                            displayLine = displayLine + " ### " + schedule.getOpponentIndex(rIndex, appResources.getScheduleTypeText(6));
                            displayLine = displayLine + " ### " + schedule.getOpponentRowIndex(rIndex, appResources.getScheduleTypeText(6));
                            displayLine = displayLine + " ### " + schedule.getPoints(rIndex, appResources.getScheduleTypeText(6));
                            displayLine = displayLine + " ### " + schedule.getOpponentPoints(rIndex, appResources.getScheduleTypeText(6));
                            displayLine = displayLine + " ### " + schedule.getConfTournRound(rIndex, appResources.getScheduleTypeText(6));
                            displayLine = displayLine + " ### " + schedule.getConfTournRow(rIndex, appResources.getScheduleTypeText(6));

                            //WRITE TO FILE
                            writer.WriteLine(displayLine);
                        } //END FOR ALL

                        //FOR ALL ROWS IN REAL CHAMPIONSHIP TOURNAMENT SCHEDULE
                        for (int rIndex = 0; rIndex < schedule.getLengthOfSchedule(appResources.getScheduleTypeText(3)); rIndex++)
                        {
                            // 3 Real ChampionshipTournament

                            //RESET DISPLAY LINE
                            displayLine = "";

                            //APPEND GAME INFO TO LINE

                            // ScheduleType
                            // Date
                            // Opponent
                            // Opponent Index
                            // Opponent Row Index
                            // Real Points
                            // Real Opponent Points
                            // Round

                            displayLine = displayLine + appResources.getScheduleTypeText(3);
                            displayLine = displayLine + " ### " + schedule.getDate(rIndex, appResources.getScheduleTypeText(3));
                            displayLine = displayLine + " ### " + schedule.getOpponentName(rIndex, appResources.getScheduleTypeText(3));
                            displayLine = displayLine + " ### " + schedule.getOpponentIndex(rIndex, appResources.getScheduleTypeText(3));
                            displayLine = displayLine + " ### " + schedule.getOpponentRowIndex(rIndex, appResources.getScheduleTypeText(3));
                            displayLine = displayLine + " ### " + schedule.getPoints(rIndex, appResources.getScheduleTypeText(3));
                            displayLine = displayLine + " ### " + schedule.getOpponentPoints(rIndex, appResources.getScheduleTypeText(3));
                            displayLine = displayLine + " ### " + schedule.getChampTournRound(rIndex, appResources.getScheduleTypeText(3));

                            //WRITE TO FILE
                            writer.WriteLine(displayLine);
                        } //END FOR ALL

                        //FOR ALL ROWS IN SIM CHAMPIONSHIP TOURNAMENT SCHEDULE
                        for (int rIndex = 0; rIndex < schedule.getLengthOfSchedule(appResources.getScheduleTypeText(7)); rIndex++)
                        {
                            // 3 Sim ChampionshipTournament

                            //RESET DISPLAY LINE
                            displayLine = "";

                            //APPEND GAME INFO TO LINE

                            // ScheduleType
                            // Date
                            // Opponent
                            // Opponent Index
                            // Opponent Row Index
                            // Sim Points
                            // Sim Opponent Points
                            // Round
                            // Row

                            displayLine = displayLine + appResources.getScheduleTypeText(7);
                            displayLine = displayLine + " ### " + schedule.getDate(rIndex, appResources.getScheduleTypeText(7));
                            displayLine = displayLine + " ### " + schedule.getOpponentName(rIndex, appResources.getScheduleTypeText(7));
                            displayLine = displayLine + " ### " + schedule.getOpponentIndex(rIndex, appResources.getScheduleTypeText(7));
                            displayLine = displayLine + " ### " + schedule.getOpponentRowIndex(rIndex, appResources.getScheduleTypeText(7));
                            displayLine = displayLine + " ### " + schedule.getPoints(rIndex, appResources.getScheduleTypeText(7));
                            displayLine = displayLine + " ### " + schedule.getOpponentPoints(rIndex, appResources.getScheduleTypeText(7));
                            displayLine = displayLine + " ### " + schedule.getChampTournRound(rIndex, appResources.getScheduleTypeText(7));
                            displayLine = displayLine + " ### " + schedule.getChampTournRow(rIndex, appResources.getScheduleTypeText(7));

                            //WRITE TO FILE
                            writer.WriteLine(displayLine);
                        } //END FOR ALL

                        writer.WriteLine(" ###### ");

                        schedule.DisposeSchedule();

                    } //END FOR ALL TEAMS

                } //END USING WRITE SCHEDULE TO FILE

                currentSaveDisplayFileName = displayFileName;
                return true;
            }
            else
            {
                //NO SAVE FOLDER RETURN FAIL
                return false;
            } //END IF SAVE FOLDER

        } //END

        public Boolean saveSimulation(SimulationDirector simulationDirector, SettingsDirector settings)
        {
            //CHANGE SAVE FILE
            return saveNewSimulation(simulationDirector, settings, currentSaveDisplayFileName);
        } //END

        public Boolean saveReplaceSimulation(SimulationDirector simulationDirector, SettingsDirector settings, string originalDisplayFileName, string replaceDisplayFileName)
        {
            //CHANGE NAME OF FILE THEN CHANGE SAVE FILE

            //IF SAVE FOLDER
            if (checkForSaveFolder())
            {

                //IF SAVE FILE
                //DELETE SAVE FILE
                if (containsSaveFile(originalDisplayFileName))
                {
                    File.Delete(convertToSaveFileNamePath(originalDisplayFileName));
                } //END IF SCHEDULE FILE

                return saveNewSimulation(simulationDirector, settings, replaceDisplayFileName);
            }
            else
            {
                //NO SAVE FOLDER RETURN FAIL
                return false;
            } //END IF SAVE FOLDER
        } //END

        //---------------------------------------------------------------------
        //LOAD-----------------------------------------------------------------
        //---------------------------------------------------------------------

        public SimulationDirector loadSimulation(string displayFileName)
        {

            //ASSOCIATION
            SimulationDirector simulationDirector = new SimulationDirector();

            //INDEXES
            int teamIndex = 0;
            int fileIndex = 0;

            //LINE FROM FILE
            string line = "";

            //TOURNAMENT VARIABLES
            int roundLength = 0;
            int rowLength = 0;

            //IF SAVE FOLDER
            if (checkForSaveFolder())
            {
                //IF SAVE FILE
                //LOAD FILE
                if (containsSaveFile(displayFileName))
                {
                    //CONVERT DISPLAY FILE NAME TO FILE PATH NAME
                    //GET RESULTS FROM FILE LOAD SETTINGS RATINGS & SCHEDULE AND RESULTS  
                    string[] lines = getLinesFromFile(getSaveFileNamePath(displayFileName));

                    //RESET IMPORT SETTINGS
                    settingsDirector.resetImportSettings();

                    //SET RATINGS
                    settingsDirector.minScoringAverage = Convert.ToInt32(lines[0]);
                    settingsDirector.maxScoringAverage = Convert.ToInt32(lines[1]);
                    settingsDirector.scoringDistribution = Convert.ToInt32(lines[2]);
                    settingsDirector.simulationType = lines[3];
                    settingsDirector.setEarliestGameDate(Convert.ToDateTime(lines[4]));
                    settingsDirector.setHighestOffensiveRating(Convert.ToDouble(lines[5]));
                    settingsDirector.setLowestOffensiveRating(Convert.ToDouble(lines[6]));
                    settingsDirector.setHighestDefensiveRating(Convert.ToDouble(lines[7]));
                    settingsDirector.setLowestDefensiveRating(Convert.ToDouble(lines[8]));

                    fileIndex = 9;

                    //LOAD CONFERENCE TOURNAMENTS AND CHAMPIONSHIP TOURNAMENT
                    for (int confIndex = 0; confIndex < appResources.getLengthOfConferenceNames() + 1; confIndex++)
                    {
                        int[][] arraysIntRoundsOfTeamIndexes;

                        roundLength = Convert.ToInt32(lines[fileIndex]);

                        fileIndex++;

                        //SET NUMBER OF ROUNDS
                        arraysIntRoundsOfTeamIndexes = new int[roundLength][];

                        for (int roundIndex = 0; roundIndex < roundLength; roundIndex++)
                        {
                            rowLength = Convert.ToInt32(lines[fileIndex]);

                            fileIndex++;

                            //SET LENGTH OF ROUNDS
                            arraysIntRoundsOfTeamIndexes[roundIndex] = new int[rowLength];

                            line = lines[fileIndex];

                            fileIndex++;

                            for (int rowIndex = 0; rowIndex < rowLength; rowIndex++)
                            {
                                arraysIntRoundsOfTeamIndexes[roundIndex][rowIndex] = Convert.ToInt32(line.Substring(0, line.IndexOf(" # ")));

                                line = line.Substring(line.IndexOf(" # ") + 3);
                            }//END FOR
                        }//END FOR

                        if (confIndex >= appResources.getLengthOfConferenceNames())
                        {
                            simulationDirector.initializeTournament(arraysIntRoundsOfTeamIndexes);
                        }
                        else
                        {
                            simulationDirector.initializeTournament(
                                confIndex, 
                                arraysIntRoundsOfTeamIndexes, 
                                appResources.getSeedStartRound(confIndex),
                                appResources.getSeedStartRow(confIndex));
                        }//END IF

                    }//END FOR ALL CONFERENCES

                    //WHILE LINES IN FILE
                    while (fileIndex < lines.Length)
                    {
                        //CREATE SCHEDULE DATA TABLE
                        Schedule schedule = new Schedule();

                        //LINE FROM FILE
                        line = "";

                        //SCHEDULE TYPE VARIABLE
                        string scheduleType = "";

                        //DATE VARIABLES
                        int year = 2019;
                        int month = 1;
                        int day = 1;

                        //OPPONENT NAME VARIABLE
                        string opponentName = "";

                        //OPPONENT INDEX VARIABLE
                        int opponentIndex = 0;
                        int opponentRowIndex = 0;

                        //REAL POINT VARIABLES
                        int opponentPoints = 0;
                        int points = 0;

                        //SIMULATEDPOINT VARIABLES
                        int realOpponentPointsInt = 0;
                        int realPoints = 0;

                        //CONFERENCE GAME VARIABLE
                        Boolean conferenceGame = false;

                        //TOURNAMENT ROUND VARIABLE
                        int champTournRound = 0;
                        int confTournRound = 0;

                        //TOURNAMENT ROW VARIABLE
                        int champTournRow = 0;
                        int confTournRow = 0;

                        //DATE VARIABLE
                        DateTime date;

                        //WHILE NOT BREAK LINE
                        while (fileIndex < lines.Length && string.Compare(lines[fileIndex], " ###### ") == 0)
                        {
                            //INCREMENT FILE INDEX
                            fileIndex++;
                        } //END WHILE LINES IN FILE

                        ////INCREMENT FILE INDEX
                        //fileIndex++;

                        //SET TEAM INDEX
                        teamIndex = appResources.getTeamIndexFromTeamName(lines[fileIndex]);

                        //SET OFFENSIVE AND DEFENSIVE RATINGS
                        simulationDirector.setOffensiveRating(teamIndex, Convert.ToDouble(lines[fileIndex + 1]));
                        simulationDirector.setDefensiveRating(teamIndex, Convert.ToDouble(lines[fileIndex + 2]));

                        //SET HIGH AND LOW RATINGS
                        settingsDirector.setHighLowOffensiveRatings(Convert.ToDouble(lines[fileIndex + 1]));
                        settingsDirector.setHighLowDefensiveRatings(Convert.ToDouble(lines[fileIndex + 2]));

                        //SCORING AVERAGES
                        simulationDirector.setOffensivescoring(teamIndex, Convert.ToInt32(lines[fileIndex + 3]));
                        simulationDirector.setDefensivescoring(teamIndex, Convert.ToInt32(lines[fileIndex + 4]));

                        //TOURNAMENTS VARIABLES
                        simulationDirector.setConfTournSeed(teamIndex, Convert.ToInt32(lines[fileIndex + 5]));
                        simulationDirector.setChampTournParticipant(teamIndex, Convert.ToBoolean(lines[fileIndex + 6]));
                        simulationDirector.setChampTournSeed(teamIndex, Convert.ToInt32(lines[fileIndex + 7]));
                        simulationDirector.setChampTournRegion(teamIndex, lines[fileIndex + 8]);
                        simulationDirector.setPlayInParticipant(teamIndex, Convert.ToBoolean(lines[fileIndex + 9]));

                        //INCREMENT INDEX
                        fileIndex = fileIndex + 12;

                        //WHILE GAMES IN SCHEDULE
                        while (fileIndex < lines.Length && string.Compare(lines[fileIndex], " ###### ") != 0)
                        {
                            //GET LINE FROM FILE
                            line = lines[fileIndex];

                            //SET SCHEDULE TYPE
                            scheduleType = line.Substring(0, line.IndexOf(" ### "));

                            //CUT TO MONTH
                            line = line.Substring(line.IndexOf(" ### ") + 5);

                            //SET MONTH
                            month = Convert.ToInt32(line.Substring(0, line.IndexOf("/")));

                            //CUT TO DAY
                            line = line.Substring(line.IndexOf("/") + 1);

                            //SET DAY
                            day = Convert.ToInt32(line.Substring(0, line.IndexOf("/")));

                            //CUT TO YEAR
                            line = line.Substring(line.IndexOf("/") + 1);

                            //SET YEAR
                            year = Convert.ToInt32(line.Substring(0, line.IndexOf(" ")));

                            //CUT TO OPPONENT NAME
                            line = line.Substring(line.IndexOf(" ### ") + 5);

                            //SET OPPONENT NAME
                            opponentName = line.Substring(0, line.IndexOf(" ### "));

                            //CUT TO OPPONENT INDEX
                            line = line.Substring(line.IndexOf(" ### ") + 5);

                            //SET OPPONENT INDEX
                            opponentIndex = Convert.ToInt32(line.Substring(0, line.IndexOf(" ### ")));

                            //CUT TO OPPONENT ROW INDEX
                            line = line.Substring(line.IndexOf(" ### ") + 5);

                            //SET OPPONENT ROW INDEX
                            opponentRowIndex = Convert.ToInt32(line.Substring(0, line.IndexOf(" ### ")));

                            //CUT TO POINTS
                            line = line.Substring(line.IndexOf(" ### ") + 5);

                            //SET POINTS
                            points = Convert.ToInt32(line.Substring(0, line.IndexOf(" ### ")));

                            //CUT TO OPPONENT POINTS
                            line = line.Substring(line.IndexOf(" ### ") + 5);

                            //SET OPPONENT POINTS
                            opponentPoints = Convert.ToInt32(line.Substring(0, line.IndexOf(" ### ")));

                            //CUT TO SCHEDULE VARIABLES
                            line = line.Substring(line.IndexOf(" ### ") + 5);

                            //SET DATE
                            date = new DateTime(year, month, day, 0, 0, 0, 0);

                            //SET EARLIEST GAME DATE
                            settingsDirector.setEarliestGameDate(date);

                            //IF REGULAR SEASON GAME
                            //ELSE IF REAL CONFERENCE TOURNAMENT GAME
                            //ELSE IF SIM CONFERENCE TOURNAMENT GAME
                            //ELSE IF REAL CHAMPIONSHIP TOURNAMENT GAME
                            //ELSE IF SIM CHAMPIONSHIP TOURNAMENT GAME
                            //ELSE IF ERROR
                            if (string.Compare(appResources.getScheduleTypeText(5), scheduleType) == 0)
                            {
                                //REGULAR SEASON

                                //SET CONFERENCE GAME
                                conferenceGame = Convert.ToBoolean(line.Substring(0, line.IndexOf(" ### ")));

                                //CUT TO REAL POINTS
                                line = line.Substring(line.IndexOf(" ### ") + 5);

                                //SET REAL POINTS
                                realPoints = Convert.ToInt32(line.Substring(0, line.IndexOf(" ### ")));

                                //CUT TO REAL OPPONENT POINTS
                                line = line.Substring(line.IndexOf(" ### ") + 5);

                                //SET REAL OPPONENT POINTS
                                realOpponentPointsInt = Convert.ToInt32(line);

                                // Date
                                // Opponent
                                // Opponent Index
                                // Opponent Row Index
                                // Real Points
                                // Real Opponent Points
                                // Sim Points
                                // Sim Opponent Points
                                // Conference Game
                                schedule.addRegSeasonGame(
                                    date,
                                    opponentName,
                                    opponentIndex,
                                    opponentRowIndex,
                                    points,
                                    opponentPoints,
                                    realPoints,
                                    realOpponentPointsInt,
                                    conferenceGame
                                    );
                            }
                            else if (string.Compare(appResources.getScheduleTypeText(2), scheduleType) == 0)
                            {
                                //CONFERENCE TOURNAMENT

                                //SET CONFERENCE TOURNAMENT ROUND
                                confTournRound = Convert.ToInt32(line);

                                // Date
                                // Opponent
                                // Opponent Index
                                // Opponent Row Index
                                // Real Points
                                // Real Opponent Points
                                // Round
                                schedule.addRealConfTournGame(
                                    date,
                                    opponentName,
                                    opponentIndex,
                                    opponentRowIndex,
                                    points,
                                    opponentPoints,
                                    confTournRound
                                    );
                            }
                            else if (string.Compare(appResources.getScheduleTypeText(6), scheduleType) == 0)
                            {
                                //CONFERENCE TOURNAMENT

                                //SET CONFERENCE TOURNAMENT ROW
                                confTournRound = Convert.ToInt32(line.Substring(0, line.IndexOf(" ### ")));

                                //CUT TO CONFERENCE TOURNAMENT ROUND
                                line = line.Substring(line.IndexOf(" ### ") + 5);

                                //SET CONFERENCE TOURNAMENT ROUND
                                confTournRow = Convert.ToInt32(line);

                                // Date
                                // Opponent
                                // Opponent Index
                                // Opponent Row Index
                                // Sim Points
                                // Sim Opponent Points
                                // Round
                                // Row
                                schedule.addSimConfTournGame(
                                    date,
                                    opponentName,
                                    opponentIndex,
                                    opponentRowIndex,
                                    points,
                                    opponentPoints,
                                    confTournRound,
                                    confTournRow
                                    );
                            }
                            else if (string.Compare(appResources.getScheduleTypeText(3), scheduleType) == 0)
                            {
                                //WILL NEED SOMETHING TO SORT OUT NIT GAMES LATER

                                //CHAMPIONSHIP TOURNAMENT

                                //SET CHAMPIONSHIP TOURNAMENT ROUND
                                champTournRound = Convert.ToInt32(line);

                                // Date
                                // Opponent
                                // Opponent Index
                                // Opponent Row Index
                                // Real Points
                                // Real Opponent Points
                                // Round
                                schedule.addRealChampTournGame(
                                    date,
                                    opponentName,
                                    opponentIndex,
                                    opponentRowIndex,
                                    points,
                                    opponentPoints,
                                    champTournRound
                                    );
                            }
                            else if (string.Compare(appResources.getScheduleTypeText(7), scheduleType) == 0)
                            {
                                //WILL NEED SOMETHING TO SORT OUT NIT GAMES LATER

                                //CHAMPIONSHIP TOURNAMENT

                                //SET CHAMPIONSHIP TOURNAMENT ROW
                                champTournRound = Convert.ToInt32(line.Substring(0, line.IndexOf(" ### ")));

                                //CUT TO CHAMPIONSHIP TOURNAMENT ROUND
                                line = line.Substring(line.IndexOf(" ### ") + 5);

                                //SET CHAMPIONSHIP TOURNAMENT ROUND
                                champTournRow = Convert.ToInt32(line);

                                // Date
                                // Opponent
                                // Opponent Index
                                // Opponent Row Index
                                // Sim Points
                                // Sim Opponent Points
                                // Round
                                // Row
                                schedule.addSimChampTournGame(
                                    date,
                                    opponentName,
                                    opponentIndex,
                                    opponentRowIndex,
                                    points,
                                    opponentPoints,
                                    champTournRound,
                                    champTournRow
                                    );
                            }
                            else 
                            {
                                System.Windows.Forms.MessageBox.Show("ERROR: SAVE LOAD DIRECTOR, LOAD SIMULATION, SCHEDULE TYPE NOT FOUND");
                            }//END

                            //INCREMENT INDEXES
                            fileIndex++;
                        } //END WHILE GAMES IN SCHEDULE

                        //INCREMENT INDEX
                        fileIndex++;

                        //ADD SCHEDULE TO TEAM
                        simulationDirector.setSchedule(teamIndex, schedule);

                        schedule.DisposeSchedule();

                    } //END WHILE LINES IN FILE

                } //END IF SAVE FILE

                //INITIALIZE ASSOCIATION
                simulationDirector.initializeAssociation();

                return simulationDirector;
            }
            else
            {
                //NO SAVE FOLDER
                //DISPLAY ERROR MESSAGE
                System.Windows.Forms.MessageBox.Show("ERROR: SIMULATION FAILED TO LOAD");

                //RETURN DEFAULT ASSOCIATION
                return simulationDirector;
            } //END IF SAVE FOLDER
        } //END

        //---------------------------------------------------------------------
        //DELETE---------------------------------------------------------------
        //---------------------------------------------------------------------

        public Boolean deleteSimulation(string displayFileName)
        {
            //DELETE SIM RESULTS FILE

            //IF SAVE FOLDER
            if (checkForSaveFolder())
            {

                //IF SAVE FILE
                //DELETE SAVE FILE
                if (containsSaveFile(displayFileName))
                {
                    File.Delete(convertToSaveFileNamePath(displayFileName));
                } //END IF SCHEDULE FILE

                return true;
            }
            else
            {
                //NO SAVE FOLDER RETURN FAIL
                return false;
            } //END IF SAVE FOLDER
        } //END

        //---------------------------------------------------------------------
        //---------------------------------------------------------------------
        //SCHEDULE AND RATINGS-------------------------------------------------
        //---------------------------------------------------------------------
        //---------------------------------------------------------------------

        //---------------------------------------------------------------------
        //IMPORT DATA----------------------------------------------------------
        //---------------------------------------------------------------------

        public SimulationDirector importData()
        {
            //ASSOCIATION
            SimulationDirector simulationDirector = new SimulationDirector();

            //RESET IMPORT SETTINGS RATINGS
            settingsDirector.resetImportSettingsRatings();

            //IMPORT DATA FROM WEB TO SET RATINGS AND SCHEDULE
            return importRatingsData(importScheduleData(simulationDirector));
        } //END

        private string getRawData(string url)
        {
            return getRawData(url, 0);
        } //END

        private string getRawData(string url, int errorWaitTime)
        {
            string rawData = "";

            //RANDOM NUMBER GENERATOR
            Random random = new Random();

            //WAIT TIME
            int waitTime = random.Next(9000);

            try
            {
                //PULLS TEXT FROM SENT URL
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                rawData = reader.ReadToEnd();
                reader.Close();
                response.Close();

                System.Threading.Thread.Sleep(1000 + waitTime);
            }
            catch (WebException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message + " ERROR. PRESS OK TO TRY AGAIN. CURRENT WAIT TIME (MIL SEC)" + errorWaitTime);

                waitTime = errorWaitTime + random.Next(5000);

                System.Threading.Thread.Sleep(5000 + waitTime);

                getRawData(url, waitTime);
            }//END TRY CATCH

            //RETURNS HTML TEXT
            return rawData;
        } //END

        private SimulationDirector importRatingsData(SimulationDirector simulationDirector)
        {
            //ONLY MAKE NEW RATINGS FILE IF NOT ON SAME DAY AS PREVIOUS

            //KEN POM URL
            string kenPomURL = "https://kenpom.com/index.php?y=2020";

            //STRING INDEXES
            string teamMark = "\"><a href=\"team";
            string nameMark = "\">";
            string offensiveMark = "divide\">";
            string defensiveMark = "left\">";

            //GET TEXT FROM URL
            string sourceCode = getRawData(kenPomURL);

            //TEAM INDEX
            int teamIndex = 0;

            //WHILE TEAM RATINGS TO PARSE
            while (sourceCode.Contains(teamMark))
            {
                //CUT STRING TO TEAM NAME
                sourceCode = sourceCode.Substring(sourceCode.IndexOf(teamMark) + teamMark.Length);
                sourceCode = sourceCode.Substring(sourceCode.IndexOf(nameMark) + nameMark.Length);

                //GET AND CALCULATE TEAM INDEX
                teamIndex = appResources.getTeamIndexFromTeamName(sourceCode.Substring(0, sourceCode.IndexOf("</")));

                //CUT STRING TO OFFENSIVE RATING
                sourceCode = sourceCode.Substring(sourceCode.IndexOf(offensiveMark) + offensiveMark.Length);

                //GET OFFENSIVE RATING
                simulationDirector.setOffensiveRating(teamIndex, Convert.ToDouble(sourceCode.Substring(0, sourceCode.IndexOf("</"))));

                //SET HIGH AND LOW OFFENSIVE RATINGS
                settingsDirector.setHighLowOffensiveRatings(Convert.ToDouble(sourceCode.Substring(0, sourceCode.IndexOf("</"))));

                //CUT STRING TO DEFENSIVE RATING
                sourceCode = sourceCode.Substring(sourceCode.IndexOf(defensiveMark) + defensiveMark.Length);

                //GET DEFENSIVE RATING
                simulationDirector.setDefensiveRating(teamIndex, Convert.ToDouble(sourceCode.Substring(0, sourceCode.IndexOf("</"))));

                //SET HIGH AND LOW DEFENSIVE RATINGS
                settingsDirector.setHighLowDefensiveRatings(Convert.ToDouble(sourceCode.Substring(0, sourceCode.IndexOf("</"))));
                
            } //END WHILE

            //SAVE RATINGS
            saveRatings(simulationDirector);

            //RETURN ASSOCIATION
            return simulationDirector;

        } //END

        private Schedule getTeamSchedule(string id)
        {
            //SCHEDULE URL
            string url = "https://www.espn.com/mens-college-basketball/team/schedule/_/id/" + id + "/season/2020";
            //CURRENT SEASON
            //string url = "https://www.espn.com/mens-college-basketball/team/schedule/_/id/" + id;

            //GET TEXT FROM URL
            string sourceCode = getRawData(url);

            //TEAM VARIABLES
            int teamIndex = appResources.getTeamIndexFromTeamID(id);
            int conferenceIndex = appResources.getConferenceIndex(teamIndex);

            //TOURNAMENT ROUNDS
            int confTournRound = 0;
            int champTournRound = 0;

            //SCHEDULE VARIABLE
            Schedule schedule = new Schedule();

            //DATE TEMP VALUES
            string dateString = "";
            string monthString = "";

            //DATE VARIABLES
            int year = 2019;
            int month = 1;
            int day = 1;

            //DATE VARIABLE
            DateTime date;

            //OPPONENT VARIABLE
            string opponentName = "";
            int opponentIndex = -1;

            //SCORE TEMP VALUES
            string scoresString = "";
            string winLossString = "";

            //SCORE VARIABLES
            int opponentPoints = 0;
            int points = 0;

            //STRING INDEXES
            string gameMark = "\"><td class=\"Table__TD\"><span>";
            string variableMark = "<td class=\"Table__TD\">";
            string idMark = "team/_/id/";
            string scoreMark = "?gameId=";

            //WHILE GAMES TO PARSE
            while (sourceCode.Contains(gameMark))
            {
                //CUT STRING TO START OF DATE
                sourceCode = sourceCode.Substring(sourceCode.IndexOf(gameMark) + gameMark.Length);
                sourceCode = sourceCode.Substring(sourceCode.IndexOf(", ") + 2);

                //GET DATE FOR LATER
                dateString = sourceCode.Substring(0, sourceCode.IndexOf(variableMark));
                dateString = dateString.Substring(0, dateString.IndexOf("<"));

                //CUT STRING TO ID VARIABLE
                sourceCode = sourceCode.Substring(sourceCode.IndexOf(variableMark) + variableMark.Length);

                //IF ENTRY NEEDED
                if ((sourceCode.IndexOf(variableMark) < sourceCode.IndexOf(gameMark)) ||
                    (sourceCode.Contains(variableMark) && !sourceCode.Contains(gameMark)))
                {
                    //GET MONTH
                    monthString = dateString.Substring(0, dateString.IndexOf(" "));

                    //GET DAY
                    day = Convert.ToInt32(dateString.Substring(dateString.IndexOf(" ") + 1));

                    //IF ID PRESENT
                    //GET ID AND SET OPPONENT NAME
                    //ELSE SET OPPONENT TO DIV II SCHOOL NAME
                    if (sourceCode.IndexOf(idMark) < sourceCode.IndexOf(variableMark) && sourceCode.Contains(idMark))
                    {
                        //GET ID
                        sourceCode = sourceCode.Substring(sourceCode.IndexOf(idMark) + idMark.Length);

                        //SET OPPONENT NAME
                        opponentName = appResources.getTeamName(sourceCode.Substring(0, sourceCode.IndexOf("/")));

                        //SET OPPONENT INDEX
                        opponentIndex = appResources.getTeamIndexFromTeamName(opponentName);
                    }
                    else
                    {
                        //SET OPPONENT TO DIV II SCHOOL NAME
                        opponentName = "DIV II SCHOOL";

                        //SET OPPONENT INDEX
                        opponentIndex = -2;
                    } //END IF ID PRESENT

                    //CUT STRING TO SCORE VARIABLE
                    sourceCode = sourceCode.Substring(sourceCode.IndexOf(variableMark) + variableMark.Length);

                    //IF GAME PRESENT
                    //PARSE SCORE
                    //ELSE SET SCORES TO ZEROS
                    if (sourceCode.IndexOf(scoreMark) < sourceCode.IndexOf(variableMark) && sourceCode.Contains(scoreMark))
                    {
                        //SET WIN LOSS
                        winLossString = sourceCode.Substring(sourceCode.IndexOf("\">") + 2, 1);

                        //CUT STRING TO SCORE VARIABLE
                        sourceCode = sourceCode.Substring(sourceCode.IndexOf(scoreMark) + scoreMark.Length);
                        sourceCode = sourceCode.Substring(sourceCode.IndexOf("\">") + 2);

                        //SET WIN LOSS
                        scoresString = sourceCode.Substring(0, sourceCode.IndexOf("<")).Trim();

                        //IF SCORE PRESENT
                        //PARSE SCORE
                        //ELSE SET SCORES TO ZEROS
                        if (scoresString.Contains("-"))
                        {
                            //SET OPPONENT POINTS
                            opponentPoints = Convert.ToInt32(scoresString.Substring(0, sourceCode.IndexOf("-")));

                            //IF OVERTIME GAME
                            //ELSE IF MULTIPLE OVERTIME GAME
                            //ELSE SET SCORE
                            if (scoresString.Contains(" OT"))
                            {
                                //CUT TO SCORE
                                scoresString = scoresString.Substring(sourceCode.IndexOf("-") + 1);

                                //SET SCORE
                                points = Convert.ToInt32(scoresString.Substring(0, scoresString.IndexOf(" OT")));
                            }
                            else if (scoresString.Contains("OT"))
                            {
                                //CUT TO SCORE
                                scoresString = scoresString.Substring(sourceCode.IndexOf("-") + 1);

                                //SET SCORE
                                points = Convert.ToInt32(scoresString.Substring(0, scoresString.IndexOf("OT") - 2));
                            }
                            else
                            {
                                //SET SCORE
                                points = Convert.ToInt32(scoresString.Substring(sourceCode.IndexOf("-") + 1));
                            } //END

                            //IF WIN
                            if (winLossString.Contains("W"))
                            {
                                // SWITCH SCORES
                                opponentPoints = opponentPoints + points;
                                points = opponentPoints - points;
                                opponentPoints = opponentPoints - points;
                            } //END

                        }
                        else
                        {
                            //GAME NOT PLAYED
                            //SET SCORES TO ZERO
                            opponentPoints = 0;
                            points = 0;
                        } //END
                    }
                    else
                    {
                        //GAME IN PROGRESS
                        //SET SCORES TO ZERO
                        opponentPoints = 0;
                        points = 0;
                    } //END IF SCORE TO PARSE

                    //CONVERT MONTH STRING TO INT
                    month = appResources.getIndexOfMonth(monthString);

                    //IF MONTH IN 2019
                    //ELSE MONTH IN 2020
                    if (month > 6)
                    {
                        //SET YEAR
                        year = 2019;
                    }
                    else
                    {
                        //SET YEAR
                        year = 2020;
                    } //END

                    //SET DATE
                    date = new DateTime(year, month, day, 0, 0, 0, 0);

                    //SET EARLIEST GAME DATE
                    settingsDirector.setEarliestGameDate(date);

                    //IF DATE EARLIER THAN CONFERENCE TOURNAMENT
                    //ELSE IF DATE EARLIER THAN CHAMPIONSHIP TOURNAMENT
                    if (0 < DateTime.Compare(appResources.getConferenceTournamentStartDate(id), date))
                    {
                        //REGULAR SEASON

                        // Date
                        // Opponent
                        // Opponent Index
                        // Opponent Row Index
                        // Real Points
                        // Real Opponent Points
                        // Sim Points
                        // Sim Opponent Points
                        // Conference Game

                        schedule.addRegSeasonGame(
                            date,
                            opponentName,
                            opponentIndex,
                            -1,
                            points,
                            opponentPoints,
                            0,
                            0,
                            appResources.sameConference(teamIndex, opponentIndex, conferenceIndex)
                            );
                    }
                    else if (0 < DateTime.Compare(appResources.getChampionshipTournamentStartDate(), date))
                    {
                        //CONFERENCE TOURNAMENT

                        // Date
                        // Opponent
                        // Opponent Index
                        // Opponent Row Index
                        // Real Points
                        // Real Opponent Points
                        // Round

                        schedule.addRealConfTournGame(
                            date,
                            opponentName,
                            opponentIndex,
                            -1,
                            points,
                            opponentPoints,
                            confTournRound
                            );

                        //INCREMENT TOURNAMENT ROUND
                        confTournRound++;
                    }
                    else
                    {
                        //WILL NEED SOMETHING TO SORT OUT NIT GAMES LATER

                        //CHAMPIONSHIP TOURNAMENT

                        // Date
                        // Opponent
                        // Opponent Index
                        // Opponent Row Index
                        // Real Points
                        // Real Opponent Points
                        // Round

                        schedule.addRealChampTournGame(
                            date,
                            opponentName,
                            opponentIndex,
                            -1,
                            points,
                            opponentPoints,
                            champTournRound
                            );

                        //INCREMENT TOURNAMENT ROUND
                        champTournRound++;
                    } //END

                } //END IF ENTRY NEEDED

            } //END WHILE GAMES TO PARSE

            //RETURN SCHEDULE
            return schedule;

        } //END

        private SimulationDirector importScheduleData(SimulationDirector simulationDirector)
        {
            //ONLY MAKE NEW RATINGS FILE IF NOT ON SAME DAY AS PREVIOUS

            //FOR ALL TEAMS
            for (int teamIndex = 0; teamIndex < appResources.getLengthOfTeamNames(); teamIndex++)
            {
                //GET SCHEDULE
                simulationDirector.setSchedule(teamIndex, getTeamSchedule(appResources.getESPNTeamID(teamIndex)));
            } //END

            //INITIALIZE ASSOCIATION
            simulationDirector.initializeAssociation();

            //SAVE SCHEDULE
            saveSchedule(simulationDirector);

            //RETURN ASSOCIATION
            return simulationDirector; 
        } //END

        //---------------------------------------------------------------------
        //SCHEDULE-------------------------------------------------------------
        //---------------------------------------------------------------------

        //SAVE-----------------------------------------------------------------

        public Boolean saveSchedule(SimulationDirector simulationDirector)
        {
            //CREATE NEW SCHEDULE SAVE

            //LINE TO BE WRITTEN
            string displayLine = "";

            //IF SAVE FOLDER
            if (checkForSaveFolder())
            {
                //IF SCHEDULE FILE
                //DELETE SCHEDULE FILE
                if (containsScheduleFile())
                {
                    File.Delete(getScheduleFileNamePath());
                } //END IF SCHEDULE FILE

                //WRITE SCHEDULE TO FILE
                using (StreamWriter writer = File.CreateText(createScheduleFileNamePath()))
                {
                    //FOR ALL TEAMS
                    for (int teamIndex = 0; teamIndex < appResources.getLengthOfTeamNames(); teamIndex++)
                    {
                        //GET SCHEDULE
                        Schedule schedule = new Schedule();

                        schedule.setSchedule(simulationDirector.getSchedule(teamIndex));

                        //WRITE TEAM NAME
                        writer.WriteLine(appResources.getTeamName(teamIndex));

                        //FOR ALL ROWS IN REAL REGULAR SEASON SCHEDULE
                        for (int rIndex = 0; rIndex < schedule.getLengthOfSchedule(appResources.getScheduleTypeText(1)); rIndex++)
                        {
                            // 1 Real RegularSeason

                            //RESET DISPLAY LINE
                            displayLine = "";

                            //APPEND GAME INFO TO LINE
                            displayLine = displayLine + schedule.getGameType(rIndex, appResources.getScheduleTypeText(1));
                            displayLine = displayLine + " ### " + schedule.getDate(rIndex, appResources.getScheduleTypeText(1));
                            displayLine = displayLine + " ### " + schedule.getOpponentName(rIndex, appResources.getScheduleTypeText(1));
                            displayLine = displayLine + " ### " + schedule.getOpponentIndex(rIndex, appResources.getScheduleTypeText(1));
                            displayLine = displayLine + " ### " + schedule.getOpponentRowIndex(rIndex, appResources.getScheduleTypeText(1));
                            displayLine = displayLine + " ### " + schedule.getPoints(rIndex, appResources.getScheduleTypeText(1));
                            displayLine = displayLine + " ### " + schedule.getOpponentPoints(rIndex, appResources.getScheduleTypeText(1));
                            displayLine = displayLine + " ### " + schedule.getConferenceGame(rIndex, appResources.getScheduleTypeText(1));


                            //WRITE TO FILE
                            writer.WriteLine(displayLine);
                        } //END FOR ALL

                        //FOR ALL ROWS IN REAL CONFERECE TOURNAMENT SCHEDULE
                        for (int rIndex = 0; rIndex < schedule.getLengthOfSchedule(appResources.getScheduleTypeText(2)); rIndex++)
                        {
                            // 2 Real ConferenceTournament

                            //RESET DISPLAY LINE
                            displayLine = "";

                            //APPEND GAME INFO TO LINE
                            displayLine = displayLine + schedule.getGameType(rIndex, appResources.getScheduleTypeText(2));
                            displayLine = displayLine + " ### " + schedule.getDate(rIndex, appResources.getScheduleTypeText(2));
                            displayLine = displayLine + " ### " + schedule.getOpponentName(rIndex, appResources.getScheduleTypeText(2));
                            displayLine = displayLine + " ### " + schedule.getOpponentIndex(rIndex, appResources.getScheduleTypeText(2));
                            displayLine = displayLine + " ### " + schedule.getOpponentRowIndex(rIndex, appResources.getScheduleTypeText(2));
                            displayLine = displayLine + " ### " + schedule.getPoints(rIndex, appResources.getScheduleTypeText(2));
                            displayLine = displayLine + " ### " + schedule.getOpponentPoints(rIndex, appResources.getScheduleTypeText(2));
                            displayLine = displayLine + " ### " + schedule.getConfTournRound(rIndex, appResources.getScheduleTypeText(2));

                            //WRITE TO FILE
                            writer.WriteLine(displayLine);
                        } //END FOR ALL

                        //FOR ALL ROWS IN REAL CHAMPIONSHIP TOURNAMENT SCHEDULE
                        for (int rIndex = 0; rIndex < schedule.getLengthOfSchedule(appResources.getScheduleTypeText(3)); rIndex++)
                        {
                            // 3 Real ChampionshipTournament

                            //RESET DISPLAY LINE
                            displayLine = "";

                            //APPEND GAME INFO TO LINE
                            displayLine = displayLine + schedule.getGameType(rIndex, appResources.getScheduleTypeText(3));
                            displayLine = displayLine + " ### " + schedule.getDate(rIndex, appResources.getScheduleTypeText(3));
                            displayLine = displayLine + " ### " + schedule.getOpponentName(rIndex, appResources.getScheduleTypeText(3));
                            displayLine = displayLine + " ### " + schedule.getOpponentIndex(rIndex, appResources.getScheduleTypeText(3));
                            displayLine = displayLine + " ### " + schedule.getOpponentRowIndex(rIndex, appResources.getScheduleTypeText(3));
                            displayLine = displayLine + " ### " + schedule.getPoints(rIndex, appResources.getScheduleTypeText(3));
                            displayLine = displayLine + " ### " + schedule.getOpponentPoints(rIndex, appResources.getScheduleTypeText(3));
                            displayLine = displayLine + " ### " + schedule.getChampTournRound(rIndex, appResources.getScheduleTypeText(3));

                            //WRITE TO FILE
                            writer.WriteLine(displayLine);
                        } //END FOR ALL

                        writer.WriteLine(" ###### ");

                        schedule.DisposeSchedule();

                    } //END FOR ALL TEAMS

                } //END USING WRITE SCHEDULE TO FILE

                return true;
            }
            else
            {
                //NO SAVE FOLDER RETURN FAIL
                return false;
            } //END IF SAVE FOLDER
        } //END

        //LOAD-----------------------------------------------------------------

        public SimulationDirector loadSchedules(SimulationDirector simulationDirector)
        {
            //GET SCHEDULE FROM FILE LOAD SCHEDULE//ASSOCIATION

            //INDEXES
            int teamIndex = 0;
            int fileIndex = 0;

            //IF SAVE FOLDER
            if (checkForSaveFolder())
            {
                //IF SAVE FILE
                //LOAD SCHEDULE FILE
                if (containsScheduleFile())
                {
                    //RESET IMPORT SETTINGS EARLIEST GAME DATE
                    settingsDirector.resetImportSettingsEarliestDate();

                    //GET LINES FROM FILE
                    string[] lines = getLinesFromFile(getScheduleFileNamePath());

                    //WHILE LINES IN FILE
                    while (fileIndex < lines.Length)
                    {
                        //INITIALIZE INDEXES
                        teamIndex = appResources.getTeamIndexFromTeamName(lines[fileIndex]);
                        fileIndex++;

                        //CREATE SCHEDULE DATA TABLE
                        Schedule schedule = new Schedule();

                        //LINE FROM FILE
                        string line = "";

                        //GAME TYPE VARIABLE
                        string gameType = "";

                        //DATE VARIABLES
                        int year = 2019;
                        int month = 1;
                        int day = 1;

                        //OPPONENT NAME VARIABLE
                        string opponentName = "";

                        //OPPONENT INDEX VARIABLES
                        int opponentIndex = 0;
                        int opponentRowIndex = 0;

                        //POINT VARIABLES
                        int opponentPoints = 0;
                        int points = 0;

                        //CONFERENCE GAME VARIABLE
                        Boolean conferenceGame = false;

                        //TOURNAMENT ROUND VARIABLES
                        int champTournRound = 0;
                        int confTournRound = 0;

                        //DATE VARIABLE
                        DateTime date;

                        //WHILE GAMES IN SCHEDULE
                        while (fileIndex < lines.Length && string.Compare(lines[fileIndex], " ###### ") != 0)
                        {
                            //GET LINE FROM FILE
                            line = lines[fileIndex];

                            //SET GAME TYPE
                            gameType = line.Substring(0, line.IndexOf(" ### "));

                            //CUT TO MONTH
                            line = line.Substring(line.IndexOf(" ### ") + 5);

                            //SET MONTH
                            month = Convert.ToInt32(line.Substring(0, line.IndexOf("/")));

                            //CUT TO DAY
                            line = line.Substring(line.IndexOf("/") + 1);

                            //SET DAY
                            day = Convert.ToInt32(line.Substring(0, line.IndexOf("/")));

                            //CUT TO YEAR
                            line = line.Substring(line.IndexOf("/") + 1);

                            //SET YEAR
                            year = Convert.ToInt32(line.Substring(0, line.IndexOf(" ")));

                            //CUT TO OPPONENT NAME
                            line = line.Substring(line.IndexOf(" ### ") + 5);

                            //SET OPPONENT NAME
                            opponentName = line.Substring(0, line.IndexOf(" ### "));

                            //CUT TO OPPONENT INDEX
                            line = line.Substring(line.IndexOf(" ### ") + 5);

                            //SET OPPONENT INDEX
                            opponentIndex = Convert.ToInt32(line.Substring(0, line.IndexOf(" ### ")));

                            //CUT TO OPPONENT ROW INDEX
                            line = line.Substring(line.IndexOf(" ### ") + 5);

                            //SET OPPONENT ROW INDEX
                            opponentRowIndex = Convert.ToInt32(line.Substring(0, line.IndexOf(" ### ")));

                            //CUT TO POINTS
                            line = line.Substring(line.IndexOf(" ### ") + 5);

                            //SET POINTS
                            points = Convert.ToInt32(line.Substring(0, line.IndexOf(" ### ")));

                            //CUT TO OPPONENT POINTS
                            line = line.Substring(line.IndexOf(" ### ") + 5);

                            //SET OPPONENT POINTS
                            opponentPoints = Convert.ToInt32(line.Substring(0, line.IndexOf(" ### ")));

                            //CUT TO SCHEDULE VARIABLES
                            line = line.Substring(line.IndexOf(" ### ") + 5);

                            //SET DATE
                            date = new DateTime(year, month, day, 0, 0, 0, 0);

                            //SET EARLIEST GAME DATE
                            settingsDirector.setEarliestGameDate(date);

                            //IF REGULAR SEASON GAME
                            //ELSE IF CONFERENCE TOURNAMENT GAME
                            //ELSE IF CHAMPIONSHIP TOURNAMENT GAME
                            //ELSE ERROR
                            if (string.Compare(appResources.getGameTypeText(0), gameType) == 0)
                            {
                                //REGULAR SEASON

                                //SET SCHEDULE TYPE
                                conferenceGame = Convert.ToBoolean(line);

                                // Date
                                // Opponent
                                // Opponent Index
                                // Opponent Row Index
                                // Real Points
                                // Real Opponent Points
                                // Sim Points
                                // Sim Opponent Points
                                // Conference Game
                                schedule.addRegSeasonGame(
                                    date,
                                    opponentName,
                                    opponentIndex,
                                    opponentRowIndex,
                                    points,
                                    opponentPoints,
                                    0,
                                    0,
                                    conferenceGame
                                    );
                            }
                            else if (string.Compare(appResources.getGameTypeText(1), gameType) == 0)
                            {
                                //CONFERENCE TOURNAMENT

                                //SET CONFERENCE TOURNAMENT ROUND
                                confTournRound = Convert.ToInt32(line);

                                // Date
                                // Opponent
                                // Opponent Index
                                // Opponent Row Index
                                // Real Points
                                // Real Opponent Points
                                // Round
                                schedule.addRealConfTournGame(
                                    date,
                                    opponentName,
                                    opponentIndex,
                                    opponentRowIndex,
                                    points,
                                    opponentPoints,
                                    confTournRound
                                    );
                            }
                            else if (string.Compare(appResources.getGameTypeText(1), gameType) == 0)
                            {
                                //WILL NEED SOMETHING TO SORT OUT NIT GAMES LATER

                                //CHAMPIONSHIP TOURNAMENT

                                //SET CHAMPIONSHIP TOURNAMENT ROUND
                                champTournRound = Convert.ToInt32(line);

                                // Date
                                // Opponent
                                // Opponent Index
                                // Opponent Row Index
                                // Real Points
                                // Real Opponent Points
                                // Round
                                schedule.addRealChampTournGame(
                                    date,
                                    opponentName,
                                    opponentIndex,
                                    opponentRowIndex,
                                    points,
                                    opponentPoints,
                                    champTournRound
                                    );
                            }
                            else
                            {
                                System.Windows.Forms.MessageBox.Show("ERROR: SAVE LOAD DIRECTOR, LOAD SCHEDULE, SCHEDULE TYPE NOT FOUND");
                            }//END

                            //INCREMENT INDEXES
                            fileIndex++;
                        } //END WHILE GAMES IN SCHEDULE

                        //INCREMENT INDEX
                        fileIndex++;

                        //ADD SCHEDULE TO TEAM
                        simulationDirector.setSchedule(teamIndex, schedule);

                        schedule.DisposeSchedule();

                    } //END WHILE LINES IN FILE

                    Console.WriteLine(" ");
                    Console.WriteLine("SCHEDULE LOADED");
                    Console.WriteLine(" ");

                } //END IF SCHEDULE FILE
            } //END IF SAVE FOLDER

            //INITIALIZE ASSOCIATION
            simulationDirector.initializeAssociation();

            //RETURN ASSOCIATION
            return simulationDirector;

        } //END

        //---------------------------------------------------------------------
        //RATINGS--------------------------------------------------------------
        //---------------------------------------------------------------------

        //SAVE-----------------------------------------------------------------

        public Boolean saveRatings(SimulationDirector simulationDirector)
        {
            //CREATE NEW RATINGS SAVE

            //IF SAVE FOLDER
            if (checkForSaveFolder())
            {
                //IF SCHEDULE FILE
                //DELETE RATINGS FILE
                if (containsRatingsFile())
                {
                    File.Delete(getRatingsFileNamePath());
                } //END IF

                //WRITE SCHEDULE TO FILE
                using (StreamWriter writer = File.CreateText(createRatingsFileNamePath()))
                {
                    //FOR ALL TEAMS
                    for (int teamIndex = 0; teamIndex < appResources.getLengthOfTeamNames(); teamIndex++)
                    {
                        //WRITE BREAK
                        writer.WriteLine(" ###### ");

                        //WRITE TEAM NAME
                        writer.WriteLine(appResources.getTeamName(teamIndex));

                        //WRITE RATINGS
                        writer.WriteLine(simulationDirector.getOffensiveRating(teamIndex));
                        writer.WriteLine(simulationDirector.getDefensiveRating(teamIndex));

                    } //END FOR ALL TEAMS
                } //END USING WRITE RATINGS TO FILE

                //RETURN SUCCESS
                return true;
            }
            else
            {
                //NO SAVE FOLDER
                //RETURN FAIL
                return false;
            } //END IF SAVE FOLDER
        } //END

        //LOAD-----------------------------------------------------------------

        public SimulationDirector loadRatings(SimulationDirector simulationDirector)
        {
            //GET RATINGS FROM FILE LOAD RATINGS

            //RESET IMPORT SETTINGS RATINGS
            settingsDirector.resetImportSettingsRatings();

            //INDEX VARIABLES
            int teamIndex = 0;
            int fileIndex = 0;

            //IF SAVE FOLDER
            if (checkForSaveFolder())
            {
                //IF SAVE FILE
                //LOAD RATINGS FILE
                if (containsRatingsFile())
                {
                    //GET LINES FROM RATINGS FILE
                    string[] lines = getLinesFromFile(getRatingsFileNamePath());

                    //WHILE LINES IN FILE
                    while (fileIndex < lines.Length)
                    {
                        //IF START OF RATINGS ENTRY
                        //ELSE INCREMENT INDEX
                        if (string.Compare(lines[fileIndex], " ###### ") == 0)
                        {
                            //SET TEAM INDEX
                            teamIndex = appResources.getTeamIndexFromTeamName(lines[fileIndex + 1]);

                            //SET OFFENSIVE AND DEFENSIVE RATINGS
                            simulationDirector.setOffensiveRating(teamIndex, Convert.ToDouble(lines[fileIndex + 2]));
                            simulationDirector.setDefensiveRating(teamIndex, Convert.ToDouble(lines[fileIndex + 3]));

                            //SET HIGH AND LOW RATINGS
                            settingsDirector.setHighLowOffensiveRatings(Convert.ToDouble(lines[fileIndex + 2]));
                            settingsDirector.setHighLowDefensiveRatings(Convert.ToDouble(lines[fileIndex + 3]));

                            //INCREMENT INDEX
                            fileIndex = fileIndex + 4;
                        }
                        else
                        {
                            //INCREMENT INDEX
                            fileIndex++;
                        } //END IF START FO RATINGS ENTRY
                    } //END WHILE LINES IN FILE

                    Console.WriteLine(" ");
                    Console.WriteLine("RATINGS LOADED");
                    Console.WriteLine(" ");

                } //END IF RATINGS FILE

            } //END IF SAVE FOLDER

            //RETURN ASSOCIATION
            return simulationDirector;

        } //END

        //---------------------------------------------------------------------
        //---------------------------------------------------------------------
        //SETTINGS-------------------------------------------------------------
        //---------------------------------------------------------------------
        //---------------------------------------------------------------------

        //---------------------------------------------------------------------
        //GET------------------------------------------------------------------
        //---------------------------------------------------------------------

        public SettingsDirector GetSettings()
        {
            //FOR LOADING SAVED SIMULATIONS (OTHERWISE USE LOAD SETTINGS)
            return settingsDirector;
        }

        //---------------------------------------------------------------------
        //SAVE-----------------------------------------------------------------
        //---------------------------------------------------------------------

        public Boolean saveSettings(SettingsDirector settingsDirector, string saveFolderFilePath)
        {

            //IF SAVE FOLDER SET
            if (setSaveFolder(saveFolderFilePath))
            {
                //IF SAVE SETTINGS FILE
                if (containsSettingsFile())
                {
                    //DELETE SETTINGS FILE
                    File.Delete(getSettingsFileNamePath());
                } //END

                //WRITE SETTINGS TO FILE
                using (StreamWriter writer = File.CreateText(saveFolderFilePath + "\\SETTINGS)-#!#!#+(=" +
                    settingsDirector.minScoringAverage + settingsDirector.maxScoringAverage + settingsDirector.scoringDistribution + settingsDirector.simulationType + "=)+#!#!#-(.txt"))
                {
                    //WRITE SETTINGS TO FILE
                    writer.WriteLine(settingsDirector.minScoringAverage);
                    writer.WriteLine(settingsDirector.maxScoringAverage);
                    writer.WriteLine(settingsDirector.scoringDistribution);
                    writer.WriteLine(settingsDirector.simulationType);
                    writer.WriteLine(settingsDirector.getEarliestGameDate());
                    writer.WriteLine(settingsDirector.getHighestOffensiveRating());
                    writer.WriteLine(settingsDirector.getLowestOffensiveRating());
                    writer.WriteLine(settingsDirector.getHighestDefensiveRating());
                    writer.WriteLine(settingsDirector.getLowestDefensiveRating());
                } //END USING WRITE SETTINGS TO FILE

                Console.WriteLine(" ");
                Console.WriteLine("SETTINGS SAVED");
                Console.WriteLine(" ");

                //RETURN SUCCESS
                return true;
            }
            else
            {
                //SAVE FOLDER NOT SET
                //SHOW ERROR MESSAGE
                System.Windows.Forms.MessageBox.Show("INVALID SAVE FOLDER PATH");

                //RETURN FAIL
                return false;
            } //END IF SAVE FOLDER SET

        } //END

        //---------------------------------------------------------------------
        //LOAD-----------------------------------------------------------------
        //---------------------------------------------------------------------

        public SettingsDirector loadSettings()
        {
            //IF SAVE FOLDER
            if (checkForSaveFolder())
            {
                //IF SETTINGS FILE
                if (containsSettingsFile())
                {
                    //GET LINES FROM SETTINGS FILE
                    string[] lines = getLinesFromFile(getSettingsFileNamePath());

                    //SET RATINGS
                    settingsDirector.minScoringAverage = Convert.ToInt32(lines[0]);
                    settingsDirector.maxScoringAverage = Convert.ToInt32(lines[1]);
                    settingsDirector.scoringDistribution = Convert.ToInt32(lines[2]);
                    settingsDirector.simulationType = lines[3];
                    settingsDirector.setEarliestGameDate(Convert.ToDateTime(lines[4]));
                    settingsDirector.setHighestOffensiveRating(Convert.ToDouble(lines[5]));
                    settingsDirector.setLowestOffensiveRating(Convert.ToDouble(lines[6]));
                    settingsDirector.setHighestDefensiveRating(Convert.ToDouble(lines[7]));
                    settingsDirector.setLowestDefensiveRating(Convert.ToDouble(lines[8]));

                    Console.WriteLine(" ");
                    Console.WriteLine("SETTINGS LOADED");
                    Console.WriteLine(" ");

                } //END IF SETTINGS FILE
            } //END IF SAVE FOLDER 

            return settingsDirector;

        } //END

        //---------------------------------------------------------------------
        //---------------------------------------------------------------------
        //SAVE FOLDER----------------------------------------------------------
        //---------------------------------------------------------------------
        //---------------------------------------------------------------------

        //---------------------------------------------------------------------
        //CHECK FOR------------------------------------------------------------
        //---------------------------------------------------------------------

        public Boolean checkForSaveFolder()
        {
            //RETURN TRUE IF SAVE PATH GOOD
            return getSaveFolder() != "";
        } //END

        //---------------------------------------------------------------------
        //VALIDATE FILE PATH---------------------------------------------------
        //---------------------------------------------------------------------

        private Boolean validateSaveFolderFilePath(string saveFolderFilePath)
        {
            //IF FILE PATH EXISTS
            if (Directory.Exists(saveFolderFilePath))
            {
                //RETURN SUCCESS
                return true;
            }
            else
            {
                //SHOW ERROR MESSAGE
                System.Windows.Forms.MessageBox.Show("ERROR: FILE PATH NOT VALID");
                //RETURN FAIL
                return false;
            } //END IF FILE PATH EXISTS
        } //END

        //---------------------------------------------------------------------
        //SET------------------------------------------------------------------
        //---------------------------------------------------------------------

        public Boolean setSaveFolder(string newSaveFolderFilePath)
        {
            //CURRENT FILE LOCATION
            //C:\Users\know1\Desktop\NCAA BB Sim\Test Folder 5\

            //IF DOES NOT ENDS WITH \
            //APPEND
            if (!newSaveFolderFilePath.EndsWith("\\"))
            {
                newSaveFolderFilePath = newSaveFolderFilePath + "\\";
            } //END IF

            //IF SAVE FOLDER FILE PATH VALID
            if (validateSaveFolderFilePath(newSaveFolderFilePath))
            {
                //SET FILE PATH
                Properties.Settings.Default.appSettingsSaveFolderFilePath = newSaveFolderFilePath;
                Properties.Settings.Default.Save();

                //RETURN SUCCESS
                return true;
            }
            else
            {
                //RETURN FAIL
                return false;
            } //END IF SAVE FOLDER FILE PATH VALID
        } //END

        //---------------------------------------------------------------------
        //GET------------------------------------------------------------------
        //---------------------------------------------------------------------

        public string getSaveFolder()
        {
            //IF SAVE FOLDER FILE PATH VALID
            if (validateSaveFolderFilePath(Properties.Settings.Default.appSettingsSaveFolderFilePath))
            {
                // RETURN FILE PATH
                return Properties.Settings.Default.appSettingsSaveFolderFilePath;
            }
            else
            {
                //RETURN FAIL
                return "";
            } //END IF SAVE FOLDER FILE PATH VALID
        } //END

    }
}
