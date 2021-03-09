using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_Basketball_Simulator
{
    class SettingsDirector
    {

        //USER SETTINGS

        //LOWEST POINTS AVERAGE
        public int minScoringAverage { get; set; }

        //HIGHEST POINTS AVERAGE
        public int maxScoringAverage { get; set; }

        //RANGE FROM AVERAGE
        public int scoringDistribution { get; set; }

        //SIMULATION TYPE
        public string simulationType { get; set; }

        //IMPORT SETTINGS

        //EARLIEST GAME
        private DateTime earliestGameDate = new DateTime(2020, 9, 1, 0, 0, 0, 0);

        //HIGHEST OFFENSIVE RATING
        private double highestOffensiveRating = 0.0;

        //LOWEST OFFENSIVE RATING
        private double lowestOffensiveRating = 1000.0;

        //HIGHEST DEFENSIVE RATING
        private double highestDefensiveRating = 0.0;

        //LOWEST DEFENSIVE RATING
        private double lowestDefensiveRating = 1000.0;

        //---------------------------------------------------------------------

        public SettingsDirector()
        {
            //DEFAULT SETTINGS
            minScoringAverage = 35;
            maxScoringAverage = 105;
            scoringDistribution = 40;
            simulationType = "";
        } //END

        public SettingsDirector(SettingsDirector settings)
        {
            //DEFAULT SETTINGS
            minScoringAverage = settings.minScoringAverage;
            maxScoringAverage = settings.maxScoringAverage;
            scoringDistribution = settings.scoringDistribution;
            simulationType = settings.simulationType;

            highestOffensiveRating = settings.highestOffensiveRating;
            lowestOffensiveRating = settings.lowestOffensiveRating;
            highestDefensiveRating = settings.highestDefensiveRating;
            lowestDefensiveRating = settings.lowestDefensiveRating;
            earliestGameDate = new DateTime(settings.getEarliestGameDate().Year, 
                settings.getEarliestGameDate().Month, 
                settings.getEarliestGameDate().Day, 
                0, 0, 0, 0);
        } //END

        //---------------------------------------------------------------------
        //---------------------------------------------------------------------
        //RESET IMPORT SETTINGS------------------------------------------------
        //---------------------------------------------------------------------
        //---------------------------------------------------------------------

        public void resetImportSettings()
        {
            highestOffensiveRating = 0.0;
            lowestOffensiveRating = 1000.0;
            highestDefensiveRating = 0.0;
            lowestDefensiveRating = 1000.0;
            earliestGameDate = new DateTime(2020, 9, 1, 0, 0, 0, 0);
        } //END

        public void resetImportSettingsRatings()
        {
            highestOffensiveRating = 0.0;
            lowestOffensiveRating = 1000.0;
            highestDefensiveRating = 0.0;
            lowestDefensiveRating = 1000.0;
        } //END

        public void resetImportSettingsEarliestDate()
        {
            earliestGameDate = new DateTime(2020, 9, 1, 0, 0, 0, 0);
        } //END

        //---------------------------------------------------------------------
        //---------------------------------------------------------------------
        //EARLIEST GAME--------------------------------------------------------
        //---------------------------------------------------------------------
        //---------------------------------------------------------------------

        //---------------------------------------------------------------------
        //SET------------------------------------------------------------------
        //---------------------------------------------------------------------

        public void setEarliestGameDate(DateTime date)
        {
            //IF DATE EARLIER 
            //SET NEW EARLIEST DATE
            if (0 > DateTime.Compare(date, earliestGameDate))
            {
                earliestGameDate = new DateTime(date.Year, date.Month, date.Day, 0, 0, 0, 0); 
            }
        } //END

        //---------------------------------------------------------------------
        //GET------------------------------------------------------------------
        //---------------------------------------------------------------------

        public DateTime getEarliestGameDate()
        {
            return earliestGameDate;
        } //END

        //---------------------------------------------------------------------
        //---------------------------------------------------------------------
        //RATINGS--------------------------------------------------------------
        //---------------------------------------------------------------------
        //---------------------------------------------------------------------

        //---------------------------------------------------------------------
        //SET------------------------------------------------------------------
        //---------------------------------------------------------------------

        //SET OFFENSIVE RATINGS-----------------------------------------------

        public void setHighLowOffensiveRatings(double offensiveRating)
        {
            //IF OFFENSIVE RATING HIGHER
            //SET NEW HIGH OFFENSIVE RATING
            if(highestOffensiveRating > offensiveRating)
            {
                highestOffensiveRating = offensiveRating;
            } //END IF

            //IF OFFENSIVE RATING LOWER
            //SET NEW LOW OFFENSIVE RATING
            if (lowestOffensiveRating < offensiveRating)
            {
                lowestOffensiveRating = offensiveRating;
            } //END IF
        } //END

        //SET DEFENSIVE RATINGS------------------------------------------------

        public void setHighLowDefensiveRatings(double defensiveRating)
        {
            //IF DEFENSIVE RATING HIGHER
            //SET NEW HIGH DEFENSIVE RATING
            if (highestDefensiveRating > defensiveRating)
            {
                highestDefensiveRating = defensiveRating;
            } //END IF

            //IF DEFENSIVE RATING LOWER
            //SET NEW LOW DEFENSIVE RATING
            if (lowestDefensiveRating < defensiveRating)
            {
                lowestDefensiveRating = defensiveRating;
            } //END IF
        } //END

        //---------------------------------------------------------------------
        //GET------------------------------------------------------------------
        //---------------------------------------------------------------------

        //GET HIGHEST OFFENSIVE RATING-----------------------------------------

        public double getHighestOffensiveRating()
        {
            return highestOffensiveRating;
        } //END

        //GET LOWEST OFFENSIVE RATING------------------------------------------

        public double getLowestOffensiveRating()
        {
            return lowestOffensiveRating;
        } //END

        //GET HIGHEST DEFENSIVE RATING-----------------------------------------

        public double getHighestDefensiveRating()
        {
            return highestDefensiveRating;
        } //END

        //GET LOWEST DEFENSIVE RATING------------------------------------------

        public double getLowestDefensiveRating()
        {
            return lowestDefensiveRating;
        } //END

    } //END
} //END
