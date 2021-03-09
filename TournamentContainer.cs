using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_Basketball_Simulator
{
    class TournamentContainer
    {
        //RANKINGS
        private double[] arrayDoubleRankings = new double[353];

        //RANKINGS UPDATED
        private Boolean boolRankingsUpdated = false;

        //TOURNAMENT CONTAINER UPDATED DATE
        private DateTime lastUpdatedDate = new DateTime(2019, 8, 1, 0, 0, 0, 0);

        //CHAMPIONSHIP TOURNAMENT REGIONS
        private int[] arrayIntRanked16ChampTournWestIndexes = new int[16];
        private int[] arrayIntRanked16ChampTournMidwestIndexes = new int[16];
        private int[] arrayIntRanked16ChampTournSouthIndexes = new int[16];
        private int[] arrayIntRanked16ChampTournEastIndexes = new int[16];

        //CHAMPIONSHIP TOURNAMENT
        private int[] arrayIntRanked68ChampTournIndexes = new int[68];
        private int[] arrayIntRanked68ChampTournSeeds = new int[68];
        private string[] arrayStringRanked68ChampTournRegions = new string[68];

        //PLAY IN TEAMS
        private int[] arrayInt8PlayInIndexes = new int[8];
        private int[] arrayInt8PlayInSeeds = new int[8];
        private string[] arrayString8PlayInRegions = new string[8];

        //CONFERENCE CHAMPIONS
        private int[] arrayInt32ConfChampsIndexes = new int[32];

        //OVERALL CHAMPIONSHIP TOURNAMENT RANKINGS
        int[] arrayIntRanked353ChampTournReturnIndexes = new int[353];

        public TournamentContainer()
        {
            
        }

        public TournamentContainer(TournamentContainer tournamentContainer)
        {
            set353Rankings(tournamentContainer.get353Rankings());
            setRankingsUpdated(tournamentContainer.getRankingsUpdated());

            setLastUpdatedDate(tournamentContainer.getLastUpdatedDate());

            setRanked16ChampTournWestIndexes(tournamentContainer.getRanked16ChampTournWestIndexes());
            setRanked16ChampTournMidwestIndexes(tournamentContainer.getRanked16ChampTournMidwestIndexes());
            setRanked16ChampTournSouthIndexes(tournamentContainer.getRanked16ChampTournSouthIndexes());
            setRanked16ChampTournEastIndexes(tournamentContainer.getRanked16ChampTournEastIndexes());
            setRanked68ChampTournIndexes(tournamentContainer.getRanked68ChampTournIndexes());
            setRanked68ChampTournSeeds(tournamentContainer.getRanked68ChampTournSeeds());
            setRanked68ChampTournRegions(tournamentContainer.getRanked68ChampTournRegions());
            set8PlayInIndexes(tournamentContainer.get8PlayInIndexes());
            set8PlayInSeeds(tournamentContainer.get8PlayInSeeds());
            set8PlayInRegions(tournamentContainer.get8PlayInRegions());
            set32ConfChampsIndexes(tournamentContainer.get32ConfChampsIndexes());
            setRanked353ChampTournReturnIndexes(tournamentContainer.getRanked353ChampTournReturnIndexes());
        }

        //---------------------------------------------------------------------
        //CONTAINER UPDATED----------------------------------------------------
        //---------------------------------------------------------------------

        public void setLastUpdatedDate(DateTime lastUpdatedDate)
        {
            this.lastUpdatedDate = new DateTime(
                                                lastUpdatedDate.Year,
                                                lastUpdatedDate.Month,
                                                lastUpdatedDate.Day,
                                                0, 0, 0, 0);
        } //END

        public DateTime getLastUpdatedDate()
        {
            return lastUpdatedDate;
        } //END

        public void setRankingsUpdated(Boolean rankingsUpdated)
        {
            boolRankingsUpdated = rankingsUpdated;
        } //END

        public Boolean getRankingsUpdated()
        {
            return boolRankingsUpdated;
        } //END

        //---------------------------------------------------------------------
        //RANKINGS-------------------------------------------------------------
        //---------------------------------------------------------------------

        public void set353Rankings(double[] arrayDoubleRankings)
        {
            Array.Copy(
                arrayDoubleRankings,
                this.arrayDoubleRankings,
                arrayDoubleRankings.Length);
        } //END

        public void set353Rankings(int index, int indexValue)
        {
            arrayDoubleRankings[index] = indexValue;
        } //END

        public double[] get353Rankings()
        {
            return arrayDoubleRankings;
        } //END

        //---------------------------------------------------------------------
        //CHAMPIONSHIP TOURNAMENT REGIONS--------------------------------------
        //---------------------------------------------------------------------

        public void setRanked16ChampTournWestIndexes(int[] arrayIntRanked16ChampTournWestIndexes)
        {
            Array.Copy(
                arrayIntRanked16ChampTournWestIndexes,
                this.arrayIntRanked16ChampTournWestIndexes,
                arrayIntRanked16ChampTournWestIndexes.Length);
        } //END

        public void setRanked16ChampTournWestIndexes(int index, int indexValue)
        {
            arrayIntRanked16ChampTournWestIndexes[index] = indexValue;
        } //END

        public int[] getRanked16ChampTournWestIndexes()
        {
            return arrayIntRanked16ChampTournWestIndexes;
        } //END

        //---------------------------------------------------------------------

        public void setRanked16ChampTournMidwestIndexes(int[] arrayIntRanked16ChampTournMidwestIndexes)
        {
            Array.Copy(
                arrayIntRanked16ChampTournMidwestIndexes,
                this.arrayIntRanked16ChampTournMidwestIndexes,
                arrayIntRanked16ChampTournMidwestIndexes.Length);
        } //END

        public void setRanked16ChampTournMidwestIndexes(int index, int indexValue)
        {
                arrayIntRanked16ChampTournMidwestIndexes[index] = indexValue;
        } //END

        public int[] getRanked16ChampTournMidwestIndexes()
        {
            return arrayIntRanked16ChampTournMidwestIndexes;
        } //END

        //---------------------------------------------------------------------

        public void setRanked16ChampTournSouthIndexes(int[] arrayIntRanked16ChampTournSouthIndexes)
        {
            Array.Copy(
                arrayIntRanked16ChampTournSouthIndexes,
                this.arrayIntRanked16ChampTournSouthIndexes,
                arrayIntRanked16ChampTournSouthIndexes.Length);
        } //END

        public void setRanked16ChampTournSouthIndexes(int index, int indexValue)
        {
                arrayIntRanked16ChampTournSouthIndexes[index] = indexValue;
        } //END

        public int[] getRanked16ChampTournSouthIndexes()
        {
            return arrayIntRanked16ChampTournSouthIndexes;
        } //END

        //---------------------------------------------------------------------

        public void setRanked16ChampTournEastIndexes(int[] arrayIntRanked16ChampTournEastIndexes)
        {
            Array.Copy(
                arrayIntRanked16ChampTournEastIndexes,
                this.arrayIntRanked16ChampTournEastIndexes,
                arrayIntRanked16ChampTournEastIndexes.Length);
        } //END

        public void setRanked16ChampTournEastIndexes(int index, int indexValue)
        {
                arrayIntRanked16ChampTournEastIndexes[index] = indexValue;
        } //END

        public int[] getRanked16ChampTournEastIndexes()
        {
            return arrayIntRanked16ChampTournEastIndexes;
        } //END

        //---------------------------------------------------------------------
        //CHAMPIONSHIP TOURNAMENT----------------------------------------------
        //---------------------------------------------------------------------

        public void setRanked68ChampTournIndexes(int[] arrayIntRanked68ChampTournIndexes)
        {
            Array.Copy(
                arrayIntRanked68ChampTournIndexes,
                this.arrayIntRanked68ChampTournIndexes,
                arrayIntRanked68ChampTournIndexes.Length);
        } //END

        public void setRanked68ChampTournIndexes(int index, int indexValue)
        {
                arrayIntRanked68ChampTournIndexes[index] = indexValue;
        } //END

        public int[] getRanked68ChampTournIndexes()
        {
            return arrayIntRanked68ChampTournIndexes;
        } //END

        //---------------------------------------------------------------------

        public void setRanked68ChampTournSeeds(int[] arrayIntRanked68ChampTournSeeds)
        {
            Array.Copy(
                arrayIntRanked68ChampTournSeeds,
                this.arrayIntRanked68ChampTournSeeds,
                arrayIntRanked68ChampTournSeeds.Length);
        } //END

        public void setRanked68ChampTournSeeds(int index, int indexValue)
        {
                arrayIntRanked68ChampTournSeeds[index] = indexValue;
        } //END

        public int[] getRanked68ChampTournSeeds()
        {
            return arrayIntRanked68ChampTournSeeds;
        } //END

        //---------------------------------------------------------------------

        public void setRanked68ChampTournRegions(string[] arrayStringRanked68ChampTournRegions)
        {
            Array.Copy(
                arrayStringRanked68ChampTournRegions,
                this.arrayStringRanked68ChampTournRegions,
                arrayStringRanked68ChampTournRegions.Length);
        } //END

        public void setRanked68ChampTournRegions(int index, string region)
        {
                arrayStringRanked68ChampTournRegions[index] = region;
        } //END

        public string[] getRanked68ChampTournRegions()
        {
            return arrayStringRanked68ChampTournRegions;
        } //END

        //---------------------------------------------------------------------
        //PLAY IN TEAMS--------------------------------------------------------
        //---------------------------------------------------------------------

        public void set8PlayInIndexes(int[] arrayInt8PlayInIndexes)
        {
            Array.Copy(
                arrayInt8PlayInIndexes,
                this.arrayInt8PlayInIndexes,
                arrayInt8PlayInIndexes.Length);
        } //END

        public void set8PlayInIndexes(int index, int indexValue)
        {
                arrayInt8PlayInIndexes[index] = indexValue;
        } //END

        public int[] get8PlayInIndexes()
        {
            return arrayInt8PlayInIndexes;
        } //END

        //---------------------------------------------------------------------

        public void set8PlayInSeeds(int[] arrayInt8PlayInSeeds)
        {
            Array.Copy(
                arrayInt8PlayInSeeds,
                this.arrayInt8PlayInSeeds,
                arrayInt8PlayInSeeds.Length);
        } //END

        public void set8PlayInSeeds(int index, int indexValue)
        {
                arrayInt8PlayInSeeds[index] = indexValue;
        } //END

        public int[] get8PlayInSeeds()
        {
            return arrayInt8PlayInSeeds;
        } //END

        //---------------------------------------------------------------------

        public void set8PlayInRegions(string[] arrayString8PlayInRegions)
        {
            Array.Copy(
                arrayString8PlayInRegions,
                this.arrayString8PlayInRegions,
                arrayString8PlayInRegions.Length);
        } //END

        public void set8PlayInRegions(int index, string region)
        {
                arrayString8PlayInRegions[index] = region;
        } //END

        public string[] get8PlayInRegions()
        {
            return arrayString8PlayInRegions;
        } //END

        //---------------------------------------------------------------------
        //CONFERENCE CHAMPIONS-------------------------------------------------
        //---------------------------------------------------------------------

        public void set32ConfChampsIndexes(int[] arrayInt32ConfChampsIndexes)
        {
            Array.Copy(
                arrayInt32ConfChampsIndexes,
                this.arrayInt32ConfChampsIndexes,
                arrayInt32ConfChampsIndexes.Length);
        } //END

        public void set32ConfChampsIndexes(int confIndex, int teamIndex)
        {
                arrayInt32ConfChampsIndexes[confIndex] = teamIndex;
        } //END

        public int[] get32ConfChampsIndexes()
        {
            return arrayInt32ConfChampsIndexes;
        } //END

        //---------------------------------------------------------------------
        //OVERALL CHAMPIONSHIP TOURNAMENT RANKINGS-----------------------------
        //---------------------------------------------------------------------

        public void setRanked353ChampTournReturnIndexes(int[] arrayIntRanked353ChampTournReturnIndexes)
        {
            Array.Copy(
                arrayIntRanked353ChampTournReturnIndexes,
                this.arrayIntRanked353ChampTournReturnIndexes,
                arrayIntRanked353ChampTournReturnIndexes.Length);
        } //END

        public void setRanked353ChampTournReturnIndexes(int rankIndex, int teamIndex)
        {
            arrayIntRanked353ChampTournReturnIndexes[rankIndex] = teamIndex;
        } //END

        public int[] getRanked353ChampTournReturnIndexes()
        {
            return arrayIntRanked353ChampTournReturnIndexes;
        } //END

    }
}
