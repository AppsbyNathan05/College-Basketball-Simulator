using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_Basketball_Simulator
{
    class Test
    {

        private Resources appResources = new Resources();
        private Director testDirector = new Director();
        private SettingsDirector testSettingsDirector = new SettingsDirector();

        static void Main(string[] args)
        {
            Test test = new Test();

            test.test1();

            //test.test2();

            //test.scheduleTest();
        }

        public void test1()
        {
            testDirector.saveSettings(testSettingsDirector, @"C:\Users\know1\Desktop\NCAA BB Sim\Test Folder 5\");

            //System.Windows.Forms.MessageBox.Show("IMPORT ONLINE DATA");
            //testDirector.importOnlineData();

            //System.Windows.Forms.MessageBox.Show("SAVE SIMULATION");
            //testDirector.saveNewSimulationResultsFile("SaveOne");

            //testDirector.saveNewSimulationResultsFile("SaveTwo");
            //testDirector.deleteSimulationResultsFile("SaveOne");
            //testDirector.saveReplaceSimulation("SaveTwo", "SaveThree");

            //System.Windows.Forms.MessageBox.Show("LOAD SIMULATION");
            testDirector.loadSimulation("SaveOne");
            testDirector.saveNewSimulationResultsFile("SaveTwo");
        }

        public void test2()
        {
            testDirector.saveSettings(testSettingsDirector, @"C:\Users\know1\Desktop\NCAA BB Sim\Test Folder 5\");

            System.Windows.Forms.MessageBox.Show("END TEST");
        }

        public void scheduleTest()
        {
            DateTime gameDate = new DateTime(2020, 9, 1, 0, 0, 0, 0);

            Schedule scheduleOne = new Schedule();
            Schedule scheduleTwo = new Schedule();
            Schedule scheduleThree = new Schedule();
            Schedule scheduleFour = new Schedule();

            scheduleOne.addRegSeasonGame(
                gameDate,
                "Two",
                0,
                0,
                5,
                10,
                5,
                10,
                true
                );

            scheduleTwo.addRegSeasonGame(
                gameDate,
                "One",
                1,
                0,
                10,
                5,
                10,
                5,
                true
                );

            //scheduleOne.addRegSeasonGame(
            //    gameDate,
            //    string opponentName,
            //    int opponentIndex,
            //    int opponentRowIndex,
            //    int realPoints,
            //    int realOpponentPoints,
            //    int simPoints,
            //    int simOpponentPoints,
            //    Boolean confGame
            //    );

            gameDate.AddDays(1.0);

            scheduleOne.addRegSeasonGame(
                gameDate,
                "Two",
                0,
                1,
                5,
                11,
                5,
                11,
                true
                );

            scheduleTwo.addRegSeasonGame(
                gameDate,
                "One",
                1,
                1,
                11,
                5,
                11,
                5,
                true
                );

            gameDate.AddDays(1.0);

            scheduleThree.addRegSeasonGame(
                gameDate,
                "Three",
                2,
                0,
                6,
                10,
                6,
                10,
                true
                );

            scheduleFour.addRegSeasonGame(
                gameDate,
                "Four",
                3,
                0,
                10,
                6,
                10,
                6,
                true
                );

            Team teamOne = new Team("One", "A");
            Team teamTwo = new Team("Two", "A");
            Team teamThree = new Team("Three", "B");
            Team teamFour = new Team("Four", "B");



            teamOne.setSchedule(scheduleOne);
            teamTwo.setSchedule(scheduleTwo);
            teamThree.setSchedule(scheduleThree);
            teamFour.setSchedule(scheduleFour);
        }

    }
}
