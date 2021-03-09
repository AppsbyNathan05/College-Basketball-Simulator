using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_Basketball_Simulator
{
    class ChampionshipTournament
    {
        //STATIC DATA RESOURCES
        private Resources appResources = new Resources();

        //TOURNAMENT ROUNDS
        private int[][] arraysIntRoundsOfTeamIndexes = new int[][]
        {
            new int[8],
            new int[64],
            new int[32],
            new int[16],
            new int[8],
            new int[4],
            new int[2],
            new int[1]
        };

        //CURRENT ROUND
        private int currentRound = 0;

        //SEED START LOCATIONS
        private int[] arraysIntSeedStartRound = new int[68];
        private int[] arraysIntSeedStartRow = new int[68];

        //TEAM INDEXES BY SEED
        private int[] arraysIntTeamIndexes = new int[68];

        //TOURNAMENT INITIALIZED
        private Boolean tournamentFilled = false;

        //INDEXS FOR MOVING REGION TEAM INDEXES TO BRACKET
        private int[] regionBracketIndexes = new int[] 
        {0, 8, 12, 4, 6, 14, 10, 2, 3, 11, 15, 7, 5, 13, 9, 1};

        private int[] regionSeedSearchForIndexes = new int[]
        {0, 15, 7, 8, 3, 12, 4, 11, 1, 14, 6, 9, 2, 13, 5, 10};

        public ChampionshipTournament()
        {
            tournamentFilled = false;

            initializeTournament();
        }

        public ChampionshipTournament(
            int[] arrayIntRanked16ChampTournWestIndexes,
            int[] arrayIntRanked16ChampTournMidwestIndexes,
            int[] arrayIntRanked16ChampTournSouthIndexes,
            int[] arrayIntRanked16ChampTournEastIndexes,
            int[] arrayInt8PlayInIndexes,
            int[] arrayInt8PlayInSeeds,
            string[] arrayString8PlayInRegions)
        {
            initializeTournament(
                arrayIntRanked16ChampTournWestIndexes,
                arrayIntRanked16ChampTournMidwestIndexes,
                arrayIntRanked16ChampTournSouthIndexes,
                arrayIntRanked16ChampTournEastIndexes,
                arrayInt8PlayInIndexes,
                arrayInt8PlayInSeeds,
                arrayString8PlayInRegions);
        }

        public ChampionshipTournament(int[][] arraysIntRoundsOfTeamIndexes)
        {
            initializeTournament(arraysIntRoundsOfTeamIndexes);
        }

        //INITIALIZE TOURNAMENT

        private void initializeTournament()
        {
            //INITIALIZE 

            //FOR ALL ROUNDS
            for (int roundIndex = 0; roundIndex < arraysIntRoundsOfTeamIndexes.Length; roundIndex++)
            {
                //FOR ALL ROUND LENGTHS
                for (int rowIndex = 0; rowIndex < arraysIntRoundsOfTeamIndexes[roundIndex].Length; rowIndex++)
                {
                    arraysIntRoundsOfTeamIndexes[roundIndex][rowIndex] = -1;
                } //END FOR
            } //END FOR

            currentRound = 0;

        }//END

        public void initializeTournament(
            int[] arrayIntRanked16ChampTournWestIndexes,
            int[] arrayIntRanked16ChampTournMidwestIndexes,
            int[] arrayIntRanked16ChampTournSouthIndexes,
            int[] arrayIntRanked16ChampTournEastIndexes,
            int[] arrayInt8PlayInIndexes,
            int[] arrayInt8PlayInSeeds,
            string[] arrayString8PlayInRegions)
        {

            int[] arrayInt8PlayInIndexesSorted = new int[] 
                {-1, -1, -1, -1, -1, -1, -1, -1};
            int[] arrayInt8PlayInSeedsSorted = new int[]
                {-1, -1, -1, -1, -1, -1, -1, -1};
            string[] arrayString8PlayInRegionsSorted = new string[8];

            int sortedValues = 0;
            int lookForIndex = 0;
            int searchIndex;

            int foundIndex;
            int roundRow = 0;

            tournamentFilled = true;

            initializeTournament();

            for (int index = 0; index < regionBracketIndexes.Length; index++)
            {
                arraysIntSeedStartRound[regionBracketIndexes[index]] = 1;
                arraysIntSeedStartRow[regionBracketIndexes[index]] = regionBracketIndexes[index];
                arraysIntTeamIndexes[regionBracketIndexes[index]] = arrayIntRanked16ChampTournWestIndexes[index];

                arraysIntSeedStartRound[regionBracketIndexes[index] + 16] = 1;
                arraysIntSeedStartRow[regionBracketIndexes[index] + 16] = regionBracketIndexes[index] + 16;
                arraysIntTeamIndexes[regionBracketIndexes[index] + 16] = arrayIntRanked16ChampTournMidwestIndexes[index];

                arraysIntSeedStartRound[regionBracketIndexes[index] + 32] = 1;
                arraysIntSeedStartRow[regionBracketIndexes[index] + 32] = regionBracketIndexes[index] + 32;
                arraysIntTeamIndexes[regionBracketIndexes[index] + 32] = arrayIntRanked16ChampTournSouthIndexes[index];

                arraysIntSeedStartRound[regionBracketIndexes[index] + 48] = 1;
                arraysIntSeedStartRow[regionBracketIndexes[index] + 48] = regionBracketIndexes[index] + 48;
                arraysIntTeamIndexes[regionBracketIndexes[index] + 48] = arrayIntRanked16ChampTournEastIndexes[index];

            }//END FOR

            while (lookForIndex < regionSeedSearchForIndexes.Length && sortedValues < arrayInt8PlayInIndexes.Length)
            {
                searchIndex = 0;
                while (searchIndex < arrayInt8PlayInIndexes.Length && sortedValues < arrayInt8PlayInIndexes.Length)
                {
                    if (regionSeedSearchForIndexes[lookForIndex] == arrayInt8PlayInSeeds[searchIndex])
                    {
                        arrayInt8PlayInIndexesSorted[sortedValues] = arrayInt8PlayInIndexes[searchIndex];
                        arrayInt8PlayInSeedsSorted[sortedValues] = arrayInt8PlayInSeeds[searchIndex];
                        arrayString8PlayInRegionsSorted[sortedValues] = arrayString8PlayInRegions[searchIndex];
                        sortedValues++;
                    }//END IF

                    searchIndex++;
                }//END WHILE
                lookForIndex++;
            }//END WHILE

            lookForIndex = 0;
            sortedValues = 64;

            while (lookForIndex < 4 && roundRow < arrayInt8PlayInIndexesSorted.Length)
            {
                searchIndex = 0;
                while (searchIndex < arrayInt8PlayInIndexes.Length && roundRow < arrayInt8PlayInIndexesSorted.Length)
                {
                    if (string.Compare(appResources.getChampTounRegionTypeText(lookForIndex), arrayString8PlayInRegionsSorted[sortedValues]) == 0)
                    {
                        foundIndex = Array.IndexOf(arraysIntTeamIndexes, arrayInt8PlayInIndexesSorted[searchIndex]);

                        if (foundIndex > -1)
                        {
                            arraysIntSeedStartRound[foundIndex] = 0;
                            arraysIntSeedStartRow[foundIndex] = roundRow;
                        }
                        else
                        {
                            arraysIntSeedStartRound[sortedValues] = 0;
                            arraysIntSeedStartRow[sortedValues] = roundRow;
                            arraysIntTeamIndexes[sortedValues] = arrayInt8PlayInIndexesSorted[searchIndex];
                        }//END IF

                        roundRow++;
                        sortedValues++;
                    }//END IF
                    searchIndex++;
                }//END WHILE
                lookForIndex++;
            }//END WHILE

            //FOR ALL ROUNDS
            for (int index = 0; index < arraysIntTeamIndexes.Length; index++)
            {
                arraysIntRoundsOfTeamIndexes[arraysIntSeedStartRound[index]][arraysIntSeedStartRow[index]] = arraysIntTeamIndexes[index];
            } //END FOR

            currentRound = 0;

        }//END

        public void initializeTournament(int[][] arraysIntRoundsOfTeamIndexes)
        {
            //FOR WHEN LOADING A SIMULATION

            //CHANGE CURRENT ROUND
            Boolean changeRound = true;

            tournamentFilled = true;

            //INDEX ADDITION
            int indexAddition = 0;

            //FOR ALL TOURNAMENT TEAMS
            //SET TEAM INDEXES
            for (int round = 0; round < arraysIntRoundsOfTeamIndexes.Length; round++)
            {
                changeRound = true;

                for (int row = 0; row < arraysIntRoundsOfTeamIndexes[round].Length; row++)
                {
                    this.arraysIntRoundsOfTeamIndexes[round][row] = arraysIntRoundsOfTeamIndexes[round][row];

                    if (this.arraysIntRoundsOfTeamIndexes[round][row] < 0)
                    {
                        changeRound = false;

                        if (round == 0)
                        {
                            tournamentFilled = false; 
                        }//END IF
                    }//END IF
                }//END FOR COLUMNS

                //SET ROUND
                if (changeRound)
                {
                    currentRound = round;
                }//END IF

            }//END FOR ROWS

            //FOR ALL TEAM INDEXES
            //RESET INDEX TO -1
            for (int index = 0; index < arraysIntTeamIndexes.Length; index++)
            {
                arraysIntTeamIndexes[index] = -1;
            } //END FOR

            //FOR ALL PLAY IN TEAMS
            for (int rowIndex = 0; rowIndex < this.arraysIntRoundsOfTeamIndexes[0].Length; rowIndex++)
            {
                arraysIntTeamIndexes[rowIndex] = this.arraysIntRoundsOfTeamIndexes[0][rowIndex];
                arraysIntSeedStartRound[rowIndex] = 0;
                arraysIntSeedStartRow[rowIndex] = rowIndex;
            } //END FOR

            indexAddition = this.arraysIntRoundsOfTeamIndexes[0].Length;

            //FOR ALL REMAINING 60 TEAMS
            for (int rowIndex = 0; rowIndex < this.arraysIntRoundsOfTeamIndexes[1].Length; rowIndex++)
            {
                //IF ONE OF THE PLAY INS
                //DON'T ADD, ADJUST INDEX ADDITION
                //ADD
                if (this.arraysIntRoundsOfTeamIndexes[1][rowIndex] == -1 ||
                    Array.IndexOf(arraysIntTeamIndexes, this.arraysIntRoundsOfTeamIndexes[1][rowIndex]) > -1)
                {
                    indexAddition--;
                }
                else
                {
                    arraysIntTeamIndexes[rowIndex + indexAddition] = this.arraysIntRoundsOfTeamIndexes[1][rowIndex];
                    arraysIntSeedStartRound[rowIndex + indexAddition] = 1;
                    arraysIntSeedStartRow[rowIndex + indexAddition] = rowIndex;
                }//END IF
            } //END FOR

        }//END

        //---------------------------------------------------------------------
        //RESET TOURNAMENT TEAMS-----------------------------------------------
        //---------------------------------------------------------------------

        public void resetTournament(
            int[] arraysIntTeamIndexes, 
            int[] arraysIntSeedStartRound, 
            int[] arraysIntSeedStartRow)
        {
            //SET INDEXES
            Array.Copy(
                arraysIntTeamIndexes,
                this.arraysIntTeamIndexes,
                arraysIntTeamIndexes.Length);

            //SET ROUNDS
            Array.Copy(
                arraysIntSeedStartRound,
                this.arraysIntSeedStartRound,
                arraysIntSeedStartRound.Length);

            //SET ROWS
            Array.Copy(
                arraysIntSeedStartRow,
                this.arraysIntSeedStartRow,
                arraysIntSeedStartRow.Length);

            //RESET TOURNAMENT
            resetRound(0);
        } //END

        //---------------------------------------------------------------------
        //ADVANCE OR RESET ROUND-----------------------------------------------
        //---------------------------------------------------------------------

        public void advanceRound(int[] advancingTeamIndexes)
        {
            int currentIndex = 0;
            int nextIndex = 0;
            int count = 0;

            //WHILE TEAMS TO ADVANCE
            while (currentIndex < arraysIntRoundsOfTeamIndexes[currentRound].Length && advancingTeamIndexes.Length > count)
            {
                //IF TEAM IN ADVANCING TEAM INDEXES
                //ADVANCE TO NEXT ROUND
                if (Array.IndexOf(advancingTeamIndexes, arraysIntRoundsOfTeamIndexes[currentRound][currentIndex]) > -1)
                {
                    //DO WHILE TEAM HASN'T BEEN INSERTED
                    do
                    {
                        //IF SPACE OPEN
                        //INSERT TEAM
                        if (arraysIntRoundsOfTeamIndexes[currentRound + 1][nextIndex] == -1)
                        {
                            arraysIntRoundsOfTeamIndexes[currentRound + 1][nextIndex] =
                                arraysIntRoundsOfTeamIndexes[currentRound][currentIndex];
                            count++;
                        }//END IF

                        //INCREMENT INDEX
                        nextIndex++;
                    } while (arraysIntRoundsOfTeamIndexes[currentRound + 1][nextIndex - 1] !=
                        arraysIntRoundsOfTeamIndexes[currentRound][currentIndex]); //END DO WHILE
                }//END IF

                //INCREMENT INDEX
                currentIndex++;
            }//END WHILE

            //ADVANCE TO NEXT ROUND
            currentRound++;
        } //END

        public void resetRound(int round)
        {
            //FOR ALL RESET ROUNDS
            for (int roundIndex = currentRound; roundIndex > round; roundIndex--)
            {
                //FOR ALL ROWS
                //ERASE ALL RESUTLS
                for (int rowIndex = 0; rowIndex < arraysIntRoundsOfTeamIndexes[roundIndex].Length; rowIndex++)
                {
                    arraysIntRoundsOfTeamIndexes[roundIndex][rowIndex] = -1;
                }//END FOR ROWS

                //UPDATE CURRENT ROUND
                currentRound--;
            }//END FOR ROUNDS

            //FOR ALL TOURNAMENT TEAMS
            //SET TEAM INDEXES
            for (int index = 0; index < arraysIntTeamIndexes.Length; index++)
            {
                arraysIntRoundsOfTeamIndexes[arraysIntSeedStartRound[index]]
                    [arraysIntSeedStartRow[index]] = arraysIntTeamIndexes[index];
            }//END FOR
        } //END

        //---------------------------------------------------------------------
        //GET------------------------------------------------------------------
        //---------------------------------------------------------------------

        public int getCurrentRound()
        {
            return currentRound;
        } //END

        public int getNumberOfRounds()
        {
            return arraysIntRoundsOfTeamIndexes.Length;
        } //END

        public int getRoundLength(int round)
        {
            return arraysIntRoundsOfTeamIndexes[round].Length;
        } //END

        public int getCurrentRoundLength()
        {
            return arraysIntRoundsOfTeamIndexes[currentRound].Length;
        } //END

        public int getTeamIndex(int round, int row)
        {
            return arraysIntRoundsOfTeamIndexes[round][row];
        } //END

        public int[] getTeamIndexes()
        {
            return arraysIntTeamIndexes;
        } //END

        public int[][] getFullTournament()
        {
            return getTournament(0, this.arraysIntRoundsOfTeamIndexes.Length, this.arraysIntRoundsOfTeamIndexes.Length);
        } //END

        public int[][] getSweet16Tournament()
        {
            return getTournament(3, this.arraysIntRoundsOfTeamIndexes.Length, 5);
        } //END

        public int[][] getProjectionTournament()
        {
            return getTournament(0, 2, 2);
        } //END

        private int[][] getTournament(int startRound, int stopRound, int numberOfRounds)
        {
            int[][] arraysIntRoundsOfTeamIndexes;

            //SET NUMBER OF ROUNDS
            arraysIntRoundsOfTeamIndexes = new int[numberOfRounds][];

            for (int roundIndex = startRound; roundIndex < stopRound; roundIndex++)
            {
                //SET LENGTH OF ROUNDS
                arraysIntRoundsOfTeamIndexes[roundIndex] = new int[this.arraysIntRoundsOfTeamIndexes[roundIndex].Length];

                for (int rowIndex = 0; rowIndex < this.arraysIntRoundsOfTeamIndexes[roundIndex].Length; rowIndex++)
                {
                    arraysIntRoundsOfTeamIndexes[roundIndex][rowIndex] = this.arraysIntRoundsOfTeamIndexes[roundIndex][rowIndex];
                }//END FOR
            }//END FOR

            return arraysIntRoundsOfTeamIndexes;
        } //END

        public int[][] getTournamentRegion(string region)
        {
            int regionMultiplier = 0;
            int rowOffset = 0;

            int[][] arraysIntRoundsOfTeamIndexes;

            //SET NUMBER OF ROUNDS
            arraysIntRoundsOfTeamIndexes = new int[this.arraysIntRoundsOfTeamIndexes.Length - 2][];

            if (0 == string.Compare(appResources.getChampTounRegionTypeText(0), region))
            {
                regionMultiplier = 0;
            }
            else if (0 == string.Compare(appResources.getChampTounRegionTypeText(1), region))
            {
                regionMultiplier = 1;
            }
            else if (0 == string.Compare(appResources.getChampTounRegionTypeText(2), region))
            {
                regionMultiplier = 2;
            }
            else if (0 == string.Compare(appResources.getChampTounRegionTypeText(3), region))
            {
                regionMultiplier = 3;
            }//END IF

            arraysIntRoundsOfTeamIndexes[0] = new int[this.arraysIntRoundsOfTeamIndexes[0].Length];

            for (int index = 0; index < arraysIntRoundsOfTeamIndexes[0].Length; index++)
            {
                arraysIntRoundsOfTeamIndexes[0][index] = this.arraysIntRoundsOfTeamIndexes[0][index];
            }//END FOR ALL PLAY IN TEAMS

            for (int roundIndex = 1; roundIndex < arraysIntRoundsOfTeamIndexes.Length; roundIndex++)
            {
                //SET LENGTH OF ROUNDS
                arraysIntRoundsOfTeamIndexes[roundIndex] = new int[this.arraysIntRoundsOfTeamIndexes[roundIndex].Length / 4];

                rowOffset = arraysIntRoundsOfTeamIndexes[roundIndex].Length * regionMultiplier;

                for (int rowIndex = rowOffset; rowIndex < arraysIntRoundsOfTeamIndexes[roundIndex].Length + rowOffset; rowIndex++)
                {
                    arraysIntRoundsOfTeamIndexes[roundIndex][rowIndex - rowOffset] = this.arraysIntRoundsOfTeamIndexes[roundIndex][rowIndex];
                }//END FOR
            }//END FOR

            return arraysIntRoundsOfTeamIndexes;
        } //END

        public int getTournChampTeamIndex()
        {
            return arraysIntRoundsOfTeamIndexes[arraysIntRoundsOfTeamIndexes.Length - 1][0];
        } //END

        public Boolean getTournChampSet()
        {
            return arraysIntRoundsOfTeamIndexes[arraysIntRoundsOfTeamIndexes.Length - 1][0] > -1;
        } //END

        public Boolean getTournFilled()
        {
            return tournamentFilled;
        } //END

    }
}
