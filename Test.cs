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
        //private Director testDirector = new Director();
        private SettingsDirector testSettingsDirector = new SettingsDirector();

        //LIST OF PROBABILITY TO DETERMINE SCORE ADJUSTMENT
        //(determined by the bellcurve array)
        //(random number between is found in list)
        List<int> listProbabilityDistributionRange = new List<int>();

        //LIST OF SCORE ADJUSTMENTS
        //(determined by range of score)
        //(index from the probability list is used to find the score adjustment)
        List<int> listScoringDistributionRange = new List<int>();

        //BELL CURVE DISTRIBUTION SIDE LENGTH
        private int sideLength = 0;

        static void Main(string[] args)
        {
            Test test = new Test();

            //test.test1();

            test.scoreAdjustmentTest();

        }

        //---------------------------------------------------------------------
        //TEST 1---------------------------------------------------------------
        //---------------------------------------------------------------------

        public void test1()
        {
            //testDirector.saveSettings(testSettingsDirector, @"C:\Users\know1\Desktop\NCAA BB Sim\Test Folder 5\");

            //System.Windows.Forms.MessageBox.Show("IMPORT ONLINE DATA");
            //testDirector.importOnlineData();

            //System.Windows.Forms.MessageBox.Show("SAVE SIMULATION");
            //testDirector.saveNewSimulationResultsFile("SaveOne");

            //testDirector.saveNewSimulationResultsFile("SaveTwo");
            //testDirector.deleteSimulationResultsFile("SaveOne");
            //testDirector.saveReplaceSimulation("SaveTwo", "SaveThree");

            //System.Windows.Forms.MessageBox.Show("LOAD SIMULATION");
            //testDirector.loadSimulation("SaveTwo");
            //testDirector.saveNewSimulationResultsFile("SaveFour");
        }

        //---------------------------------------------------------------------
        //SCORE ADJUSTMENT TEST------------------------------------------------
        //---------------------------------------------------------------------

        public void scoreAdjustmentTest()
        {
            int[] scores = new int[41];
            int[] count = new int[41];

            int score = 0;

            for (int index = 0; index < scores.Length; index++)
            {
                scores[index] = -20 + index;
            }//END FOR

            for (int index = 0; index < count.Length; index++)
            {
                count[index] = 0;
            }//END FOR

            initializeScoringDistributionRange(testSettingsDirector);

            for (int index = 0; index < (5001 + (sideLength * 4 - 1)); index++)
            {
                score = getScoreAdjustment(index, 0) + 20;
                count[score] = count[score] + 1;
                score = getScoreAdjustment(index, 1) + 20;
                count[score] = count[score] + 1;
            }//END FOR

            for (int index = 0; index < count.Length; index++)
            {
                Console.WriteLine(scores[index] + ": " + count[index]);
            }//END FOR

            Console.WriteLine();
            Console.WriteLine("Prob Count: " + listProbabilityDistributionRange.Count);
            Console.WriteLine();

            for (int index = 0; index < listProbabilityDistributionRange.Count; index++)
            {
                Console.WriteLine(listScoringDistributionRange[index] + ": " + listProbabilityDistributionRange[index]);
            }//END FOR
        }

        public void initializeScoringDistributionRange(SettingsDirector settingsDirector)
        {
            //INCREMENT
            double increment = 0.0;

            //BELL CURVE LENGTH LENGTH
            int bellCurveLength = appResources.getLengthOfBellCurve();

            //HALF LENGTH
            sideLength = settingsDirector.scoringDistribution;

            //SET HALF LENGTH
            if (sideLength % 2 == 0)
            {
                //ADD 2 FOR ZEROS
                //DIVIDE BY 2
                sideLength = (sideLength + 2) / 2;
            }
            else
            {
                //ADD 3, 2 FOR ZEROS AND 1 TO EVEN EACH SIDE
                //DIVIDE BY 2
                sideLength = (sideLength + 3) / 2;
            }//END IF

            //SET INCREMENT
            increment = (bellCurveLength / 2) / sideLength;

            //CLEAR DATA
            listProbabilityDistributionRange.Clear();

            //FOR HALF THE PROBABILITY DISTRIBUTION
            //FILL PROBABILITY DISTRIBUTION
            for (int index = 0; index < sideLength; index++)
            {
                listProbabilityDistributionRange.Add(appResources.getBellCurveValue(((int)((index + 1) * increment)) - 1) + (index * 4));
            }//END FOR

            //CLEAR DATA
            listScoringDistributionRange.Clear();

            //SET SCORE ADJUSTMENTS
            for (int index = sideLength - 1; index >= 0; index--)
            {
                listScoringDistributionRange.Add(index);
            }//END FOR

        } //END

        //GET POINTS-----------------------------------------------------------

        public int getScoreAdjustment(int probability, int positiveNegative)
        {
            //RANDOM NUMBER GENERATOR
            Random random = new Random();

            //DISTRIBUTION NUMBER
            //int probability = random.Next(5001 + (sideLength * 4 - 1));

            //DISTRIBUTION NUMBER
            //int positiveNegative = random.Next(2);

            //FOR THE PROBABILITY DISTRIBUTION
            //EXIT WHEN SCORE FOUND
            for (int index = 0; index < listProbabilityDistributionRange.Count; index++)
            {
                if (listProbabilityDistributionRange[index] >= probability && positiveNegative == 1)
                {
                    return listScoringDistributionRange[index];
                }
                else if (listProbabilityDistributionRange[index] >= probability && positiveNegative == 0)
                {
                    return listScoringDistributionRange[index] * -1;
                }//END IF

            }//END FOR

            //DISPLAY ERROR MESSAGE
            //System.Windows.Forms.MessageBox.Show("SCORE ADJUSTMENT ERROR");

            //RETURN LAST ADJUSTMENT
            return listScoringDistributionRange[listScoringDistributionRange.Count - 1];

        } //END

    }
}
