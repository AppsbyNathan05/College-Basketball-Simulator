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

            //test.scoreAdjustmentTest();

            //test.orderIndexesTest();

            //test.randomTest();

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

        #region ScoreAdjustmentTestRegion
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
        #endregion

        //---------------------------------------------------------------------
        //GET ORDER INDEXES TEST-----------------------------------------------
        //---------------------------------------------------------------------

        #region OrderIndexesTest
        public void orderIndexesTest()
        {
            double[] arrayDoubleOrderValues = new double[] { 3.0, 10.0, 5.0, 7.0, 1.0 };

            int[] orderArray = new int[arrayDoubleOrderValues.Length];

            getOrderIndexes(arrayDoubleOrderValues, arrayDoubleOrderValues.Length);

            Array.Copy(getOrderIndexes(arrayDoubleOrderValues, arrayDoubleOrderValues.Length),
                orderArray,
                arrayDoubleOrderValues.Length);

            for (int index = 0; index < orderArray.Length; index++)
            {
                Console.WriteLine(index + " " + arrayDoubleOrderValues[orderArray[index]]);
            }//END FOR

        }

        private int[] getOrderIndexes(double[] arrayDoubleOrderValues, int orderLength)
        {
            //ORDER ARRAY
            int[] arrayIntOrder = new int[orderLength];

            //INSERT TEAM INDEX
            int insertTeamArrayIndex = 0;

            //TEMP TEAM INDEX
            int tempTeamIndex = 0;

            //FOR ALL TEAMS
            //SET ORDER
            for (int teamIndex = 0; teamIndex < arrayIntOrder.Length; teamIndex++)
            {
                //SET CURRENT INSERT TEAM
                insertTeamArrayIndex = teamIndex;

                //FOR ALL FILLED ORDER ARRAY
                //FIND PLACEMENT
                for (int orderIndex = 0; orderIndex < teamIndex; orderIndex++)
                {
                    //IF BETTER RANKING
                    //SWITCH
                    if (arrayDoubleOrderValues[insertTeamArrayIndex] >
                        arrayDoubleOrderValues[arrayIntOrder[orderIndex]])
                    {
                        //SET TEMP TEAM INDEX
                        tempTeamIndex = insertTeamArrayIndex;

                        //RESET CURRENT INSERT TEAM
                        insertTeamArrayIndex = arrayIntOrder[orderIndex];

                        //SET NEW ORDER
                        arrayIntOrder[orderIndex] = tempTeamIndex;
                    }//END IF

                }//END FOR

                //ADD TEAM TO ORDER
                arrayIntOrder[teamIndex] = insertTeamArrayIndex;

            }//END FOR

            return arrayIntOrder;

        }// END 
        #endregion

        //---------------------------------------------------------------------
        //GET ORDER INDEXES TEST-----------------------------------------------
        //---------------------------------------------------------------------

        #region RandomTest
        public void randomTest()
        {
            int probability;

            int high = 0;
            int low = 10000;

            for (int index = 0; index < 1000; index++)
            {
                //DISTRIBUTION NUMBER
                probability = getRandom();

                Console.WriteLine(" " + probability);

            }//END FOR

            for (int index = 0; index < 40000; index++)
            {
                //DISTRIBUTION NUMBER
                probability = getRandom();

                if (high < probability)
                {
                    high = probability;
                }//END IF

                if (low > probability)
                {
                    low = probability;
                }//END IF

            }//END FOR

            Console.WriteLine("HIGH " + high);

            Console.WriteLine("LOW " + low);

        } 

        private int getRandom()
        {
            //RANDOM NUMBER GENERATOR
            Random random = new Random();

            int probability = random.Next(5001 + (40 * 4 - 1));

            return probability;
        }
        #endregion

    }
}
