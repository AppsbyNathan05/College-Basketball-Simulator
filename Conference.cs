using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_Basketball_Simulator
{
    class Conference
    {
        //TOURNAMENT ROUNDS
        private int[][] arraysIntRoundsOfTeamIndexes;

        //CURRENT ROUND
        private int currentRound = 0;

        //SEED START LOCATIONS
        private int[] arraysIntSeedStartRound;
        private int[] arraysIntSeedStartRow;

        //TEAM INDEXES BY SEED
        private int[] arraysIntTeamIndexes;

        //TOURNAMENT INITIALIZED
        private Boolean tournamentFilled = false;

        public Conference(
            int[] arraysIntSeedStartRound, 
            int[] arraysIntSeedStartRow, 
            int[] arrayTournamentCode)
        {
            tournamentFilled = false;

            initializeTournament(
                arraysIntSeedStartRound,
                arraysIntSeedStartRow,
                arrayTournamentCode);
        }

        public Conference(
            int[] arraysIntSeedStartRound, 
            int[] arraysIntSeedStartRow, 
            int[] arrayTournamentCode,
            int[] arraysIntTeamIndexes)
        {
            initializeTournament(
                arraysIntSeedStartRound,
                arraysIntSeedStartRow,
                arrayTournamentCode);

            initializeTournament(arraysIntTeamIndexes);
        }

        public Conference(
            int[][] arraysIntRoundsOfTeamIndexes,
            int[] arraysIntSeedStartRound,
            int[] arraysIntSeedStartRow)
        {
            initializeTournament(
                arraysIntRoundsOfTeamIndexes,
                arraysIntSeedStartRound,
                arraysIntSeedStartRow);
        }

        //INITIALIZE TOURNAMENT

        private void initializeTournament(
            int[] arraysIntSeedStartRound,
            int[] arraysIntSeedStartRow,
            int[] arrayTournamentCode)
        {
            //INITIALIZE 

            //SET NUMBER OF ROUNDS
            arraysIntRoundsOfTeamIndexes = new int[arrayTournamentCode.Length + 1][];

            for (int index = 0; index < arrayTournamentCode.Length; index++)
            {
                //SET LENGTH OF ROUNDS
                arraysIntRoundsOfTeamIndexes[index] = new int[arrayTournamentCode[index] * 2];
            }//END FOR

            //SET LENGTH OF ROUNDS
            arraysIntRoundsOfTeamIndexes[arrayTournamentCode.Length] = new int[1];

            //FOR ALL ROUNDS
            for (int roundIndex = 0; roundIndex < arraysIntRoundsOfTeamIndexes.Length; roundIndex++)
            {
                //FOR ALL ROUND LENGTHS
                for (int rowIndex = 0; rowIndex < arraysIntRoundsOfTeamIndexes[roundIndex].Length; rowIndex++)
                {
                    arraysIntRoundsOfTeamIndexes[roundIndex][rowIndex] = -1;
                } //END FOR
            } //END FOR

            //INITIALIZE LOCATIONS
            this.arraysIntSeedStartRound = new int[arraysIntSeedStartRound.Length];
            this.arraysIntSeedStartRow = new int[arraysIntSeedStartRow.Length];
            this.arraysIntTeamIndexes = new int[arraysIntSeedStartRow.Length];

            //SET ROUND LOCATION
            Array.Copy(
                arraysIntSeedStartRound,
                this.arraysIntSeedStartRound,
                arraysIntSeedStartRound.Length);

            //SET ROW LOCATION
            Array.Copy(
                arraysIntSeedStartRow,
                this.arraysIntSeedStartRow,
                arraysIntSeedStartRow.Length);

            currentRound = 0;

        }//END

        public void initializeTournament(int[] arraysIntTeamIndexes)
        {
            tournamentFilled = true;

            //SET INDEXES
            Array.Copy(
                arraysIntTeamIndexes,
                this.arraysIntTeamIndexes,
                arraysIntTeamIndexes.Length);

            //FOR ALL TOURNAMENT TEAMS
            //SET TEAM INDEXES
            for (int index = 0; index < this.arraysIntTeamIndexes.Length; index++)
            {
                arraysIntRoundsOfTeamIndexes[arraysIntSeedStartRound[index]]
                    [arraysIntSeedStartRow[index]] = this.arraysIntTeamIndexes[index];
            }//END FOR

        }//END

        public void initializeTournament(
            int[][] arraysIntRoundsOfTeamIndexes,
            int[] arraysIntSeedStartRound,
            int[] arraysIntSeedStartRow)
        {
            //FOR WHEN LOADING A SIMULATION

            //CURRENT ROUND
            Boolean changeRound = true;

            tournamentFilled = true;

            //SET NUMBER OF ROUNDS
            this.arraysIntRoundsOfTeamIndexes = new int[arraysIntRoundsOfTeamIndexes.Length][];

            //FOR ALL TOURNAMENT TEAMS
            //SET TEAM INDEXES
            for (int round = 0; round < arraysIntRoundsOfTeamIndexes.Length; round++)
            {
                changeRound = true;

                //SET LENGTH OF ROUNDS
                this.arraysIntRoundsOfTeamIndexes[round] = new int[arraysIntRoundsOfTeamIndexes[round].Length];

                for (int row = 0; row < arraysIntRoundsOfTeamIndexes[round].Length; row++)
                {
                    this.arraysIntRoundsOfTeamIndexes[round][row] = arraysIntRoundsOfTeamIndexes[round][row];

                    if (this.arraysIntRoundsOfTeamIndexes[round][0] < 0)
                    {
                        changeRound = false;

                        if (round == 0)
                        {
                            tournamentFilled = false;
                        }//END IF
                    }//END IF

                }//END FOR COLUMNS

                //SET ROUND
                if(changeRound)
                {
                    currentRound = round;
                }//END IF

            }//END FOR ROWS

            //INITIALIZE LOCATIONS
            this.arraysIntSeedStartRound = new int[arraysIntSeedStartRound.Length];
            this.arraysIntSeedStartRow = new int[arraysIntSeedStartRow.Length];
            this.arraysIntTeamIndexes = new int[arraysIntSeedStartRow.Length];

            //SET ROUND LOCATION
            Array.Copy(
                arraysIntSeedStartRound,
                this.arraysIntSeedStartRound,
                arraysIntSeedStartRound.Length);

            //SET ROW LOCATION
            Array.Copy(
                arraysIntSeedStartRow,
                this.arraysIntSeedStartRow,
                arraysIntSeedStartRow.Length);

            //FOR ALL TOURNAMENT TEAMS
            //SET TEAM INDEXES
            for (int index = 0; index < this.arraysIntTeamIndexes.Length; index++)
            {
                this.arraysIntTeamIndexes[index] = 
                    arraysIntRoundsOfTeamIndexes[this.arraysIntSeedStartRound[index]]
                    [this.arraysIntSeedStartRow[index]];
            }//END FOR
        }//END

        //---------------------------------------------------------------------
        //RESET TOURNAMENT TEAMS-----------------------------------------------
        //---------------------------------------------------------------------

        public void resetTournament(int[] arraysIntTeamIndexes)
        {
            //SET INDEXES
            Array.Copy(
                arraysIntTeamIndexes,
                this.arraysIntTeamIndexes,
                arraysIntTeamIndexes.Length);

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
                        if(arraysIntRoundsOfTeamIndexes[currentRound + 1][nextIndex] == -1)
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

        public int[][] getTournament()
        {
            int[][] arraysIntRoundsOfTeamIndexes;

            //SET NUMBER OF ROUNDS
            arraysIntRoundsOfTeamIndexes = new int[this.arraysIntRoundsOfTeamIndexes.Length][];

            for (int roundIndex = 0; roundIndex < this.arraysIntRoundsOfTeamIndexes.Length; roundIndex++)
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

        public int getConfTournChampTeamIndex()
        {
            return arraysIntRoundsOfTeamIndexes[arraysIntRoundsOfTeamIndexes.Length - 1][0];
        } //END

        public Boolean getConfTournChampSet()
        {
            return arraysIntRoundsOfTeamIndexes[arraysIntRoundsOfTeamIndexes.Length - 1][0] > -1;
        } //END

        public Boolean getTournFilled()
        {
            return tournamentFilled;
        } //END
    }
}
