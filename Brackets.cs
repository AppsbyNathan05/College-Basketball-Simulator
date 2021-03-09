using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_Basketball_Simulator
{
    class Brackets
    {
        //STATIC DATA RESOURCES
        private Resources appResources = new Resources();

        //UPDATED STATES
        private Boolean projectionUpdated = false;
        private Boolean championshipUpdated = false;
        private Boolean[] conferenceUpdated;

        private string[] projection68Bracket = new string[135];

        private string[] championship68Bracket = new string[135];
        private string[] championship16Bracket = new string[31];
        private string[] championshipWestBracket;
        private string[] championshipMidwestBracket;
        private string[] championshipSouthBracket;
        private string[] championshipEastBracket;

        private string[][] conferenceBrackets = new string[][]
        {
            new string[15],
            new string[30],
            new string[35],
            new string[35],
            new string[15],
            new string[23],
            new string[23],
            new string[29],
            new string[29],
            new string[35],
            new string[15],
            new string[23],
            new string[30],
            new string[20],
            new string[7],
            new string[29],
            new string[30],
            new string[23],
            new string[23],
            new string[29],
            new string[15],
            new string[19],
            new string[30],
            new string[23],
            new string[35],
            new string[23],
            new string[19],
            new string[15],
            new string[15],
            new string[25],
            new string[25],
            new string[15]
        };

        private string[] playInGameLetters = new string[] {"A", "B", "C", "D"};

        public Brackets()
        {
            conferenceUpdated = new Boolean[appResources.getLengthOfConferenceNames()];

            resetAllUpdatedStates();
        }

        public Brackets(Brackets brackets)
        {
            conferenceUpdated = new Boolean[appResources.getLengthOfConferenceNames()];

            projectionUpdated = brackets.getProjectionUpdated();
            championshipUpdated = brackets.getChampionshipUpdated();

            for (int confIndex = 0; confIndex < conferenceUpdated.Length; confIndex++)
            {
                conferenceUpdated[confIndex] = brackets.getConferenceUpdated()[confIndex];
            }//END FOR

            for (int index = 0; index < projection68Bracket.Length; index++)
            {
                projection68Bracket[index] = brackets.getProjection68Bracket()[index];
            }//END FOR

            for (int index = 0; index < championship68Bracket.Length; index++)
            {
                championship68Bracket[index] = brackets.getChampionship68Bracket()[index];
            }//END FOR

            for (int index = 0; index < championship16Bracket.Length; index++)
            {
                championship16Bracket[index] = brackets.getChampionship16Bracket()[index];
            }//END FOR

            //WEST
            championshipWestBracket = new string[brackets.getChampionshipWestBracket().Length];

            for (int index = 0; index < championshipWestBracket.Length; index++)
            {
                championshipWestBracket[index] = brackets.getChampionshipWestBracket()[index];
            }//END FOR

            //MIDWEST
            championshipMidwestBracket = new string[brackets.getChampionshipMidwestBracket().Length];

            for (int index = 0; index < championshipMidwestBracket.Length; index++)
            {
                championshipMidwestBracket[index] = brackets.getChampionshipMidwestBracket()[index];
            }//END FOR

            //SOUTH
            championshipSouthBracket = new string[brackets.getChampionshipSouthBracket().Length];

            for (int index = 0; index < championshipSouthBracket.Length; index++)
            {
                championshipSouthBracket[index] = brackets.getChampionshipSouthBracket()[index];
            }//END FOR

            //EAST
            championshipEastBracket = new string[brackets.getChampionshipEastBracket().Length];

            for (int index = 0; index < championshipEastBracket.Length; index++)
            {
                championshipEastBracket[index] = brackets.getChampionshipEastBracket()[index];
            }//END FOR

            for (int confIndex = 0; confIndex < conferenceBrackets.Length; confIndex++)
            {
                for (int rowIndex = 0; rowIndex < conferenceBrackets[confIndex].Length; rowIndex++)
                {
                    conferenceBrackets[confIndex][rowIndex] = brackets.getConferenceBracket(confIndex)[rowIndex];
                }//END FOR ROWS
            }//END FOR CONFERENCES

        }

        //---------------------------------------------------------------------
        //GET------------------------------------------------------------------
        //---------------------------------------------------------------------

        public Boolean getProjectionUpdated()
        {
            return projectionUpdated;
        } //END

        public Boolean getChampionshipUpdated()
        {
            return championshipUpdated;
        } //END

        public Boolean[] getConferenceUpdated()
        {
            return conferenceUpdated;
        } //END

        public string[] getProjection68Bracket()
        {
            return projection68Bracket;
        } //END

        public string[] getChampionship68Bracket()
        {
            return championship68Bracket;
        } //END

        public string[] getChampionship16Bracket()
        {
            return championship16Bracket;
        } //END

        public string[] getChampionshipWestBracket()
        {
            return championshipWestBracket;
        } //END

        public string[] getChampionshipMidwestBracket()
        {
            return championshipMidwestBracket;
        } //END

        public string[] getChampionshipSouthBracket()
        {
            return championshipSouthBracket;
        } //END

        public string[] getChampionshipEastBracket()
        {
            return championshipEastBracket;
        } //END

        public string[] getConferenceBracket(int confIndex)
        {
            return conferenceBrackets[confIndex];
        } //END

        //---------------------------------------------------------------------
        //RESET UPDATED STATES-------------------------------------------------
        //---------------------------------------------------------------------

        private void resetAllUpdatedStates()
        {
            for (int confIndex = 0; confIndex < conferenceUpdated.Length; confIndex++)
            {
                conferenceUpdated[confIndex] = false;
            }//END FOR ALL CONFERENCES

            projectionUpdated = false;

            championshipUpdated = false;
        } //END

        public void resetConfUpdatedStates(int confIndex)
        {
            conferenceUpdated[confIndex] = false;
        } //END

        public void resetProjectionUpdatedStates()
        {
            projectionUpdated = false;
            championshipUpdated = false;
        } //END

        public void resetChampUpdatedStates()
        {
            championshipUpdated = false;
        } //END

        //---------------------------------------------------------------------
        //BRACKET FUNCTIONS----------------------------------------------------
        //---------------------------------------------------------------------

        private string getLineString()
        {
            string lineString = "_";

            return lineString.PadRight(30, '_');
        }//END

        //---------------------------------------------------------------------

        private string getBlankSectionString()
        {
            string blankString = " ";

            return blankString.PadRight(30, ' ');
        }//END

        //---------------------------------------------------------------------
        //---------------------------------------------------------------------
        //CONFERENCE BRACKETS--------------------------------------------------
        //---------------------------------------------------------------------
        //---------------------------------------------------------------------

        public string[] getConferenceBracket(int[][] teamIndexes, Team[] teams, int confIndex)
        {
            if (conferenceUpdated[confIndex] == true)
            {
                return conferenceBrackets[confIndex];
            }
            else
            {
                Array.Copy(
                    fillConfTournamentTeams(conferenceBrackets[confIndex], teamIndexes, teams),
                    conferenceBrackets[confIndex],
                    conferenceBrackets[confIndex].Length);

                if (conferenceBrackets[confIndex].Length == 7)
                {
                    Array.Copy(
                        getConference21Bracket(conferenceBrackets[confIndex]),
                        conferenceBrackets[confIndex],
                        conferenceBrackets[confIndex].Length);

                    return conferenceBrackets[confIndex];
                }
                else if (conferenceBrackets[confIndex].Length == 15)
                {
                    Array.Copy(
                        getConference421Bracket(conferenceBrackets[confIndex]),
                        conferenceBrackets[confIndex],
                        conferenceBrackets[confIndex].Length);

                    return conferenceBrackets[confIndex];
                }
                else if (conferenceBrackets[confIndex].Length == 19)
                {
                    Array.Copy(
                        getConference2221Bracket(conferenceBrackets[confIndex]),
                        conferenceBrackets[confIndex],
                        conferenceBrackets[confIndex].Length);

                    return conferenceBrackets[confIndex];
                }
                else if (conferenceBrackets[confIndex].Length == 20)
                {
                    Array.Copy(
                        getConference3221Bracket(conferenceBrackets[confIndex]),
                        conferenceBrackets[confIndex],
                        conferenceBrackets[confIndex].Length);

                    return conferenceBrackets[confIndex];
                }
                else if (conferenceBrackets[confIndex].Length == 23)
                {
                    Array.Copy(
                        getConference2421Bracket(conferenceBrackets[confIndex]),
                        conferenceBrackets[confIndex],
                        conferenceBrackets[confIndex].Length);

                    return conferenceBrackets[confIndex];
                }
                else if (conferenceBrackets[confIndex].Length == 25)
                {
                    Array.Copy(
                        getConference22221Bracket(conferenceBrackets[confIndex]),
                        conferenceBrackets[confIndex],
                        conferenceBrackets[confIndex].Length);

                    return conferenceBrackets[confIndex];
                }
                else if (conferenceBrackets[confIndex].Length == 29)
                {
                    Array.Copy(
                        getConference3421Bracket(conferenceBrackets[confIndex]),
                        conferenceBrackets[confIndex],
                        conferenceBrackets[confIndex].Length);

                    return conferenceBrackets[confIndex];
                }
                else if (conferenceBrackets[confIndex].Length == 30)
                {
                    Array.Copy(
                        getConference4421Bracket(conferenceBrackets[confIndex]),
                        conferenceBrackets[confIndex],
                        conferenceBrackets[confIndex].Length);

                    return conferenceBrackets[confIndex];
                }
                else if (conferenceBrackets[confIndex].Length == 35)
                {
                    Array.Copy(
                        getConference24421Bracket(conferenceBrackets[confIndex]),
                        conferenceBrackets[confIndex],
                        conferenceBrackets[confIndex].Length);

                    return conferenceBrackets[confIndex];
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("ERROR: CONFERENCE TOURNAMENT BRACKET");
                    return conferenceBrackets[confIndex];
                }//END IF

            }//END IF
        }//END

        //---------------------------------------------------------------------

        private string[] fillConfTournamentTeams(string[] displayLines, int[][] teamIndexes, Team[] teams)
        {
            int lineIndex = 0;

            for (int roundIndex = 0; roundIndex < teamIndexes.Length; roundIndex++)
            {
                for (int rowIndex = 0; rowIndex < teamIndexes[roundIndex].Length; rowIndex++)
                {
                    if (teamIndexes[roundIndex][rowIndex] > -1)
                    {
                        //ADD TEAM
                        displayLines[lineIndex] = getTeamConfTournString(teamIndexes[roundIndex][rowIndex], roundIndex, teams);
                    }
                    else
                    {
                        //ADD BLANK
                        displayLines[lineIndex] = getLineString();
                    }//END IF

                    lineIndex++;
                }//END FOR ROWS
            }//END FOR ALL ROUNDS

            return displayLines;
        }//END

        //---------------------------------------------------------------------

        private string getTeamConfTournString(int teamIndex, int round, Team[] teams)
        {
            string score = "";

            int confTournRound = 0;

            string teamTournString = "#" + (teams[teamIndex].champTournSeed + 1);

            teamTournString.PadRight(4, '_');

            teamTournString = teamTournString + teams[teamIndex].teamNameDisplay;

            teamTournString.PadRight(27, '_');

            confTournRound = teams[teamIndex].getConfTournRound(0, appResources.getScheduleTypeText(6));
            score = teams[teamIndex].getPoints(round - confTournRound, appResources.getScheduleTypeText(6)).ToString();

            score.PadLeft(3, '_');

            teamTournString = teamTournString + score;

            //#SE XXXXXXXTEAMNAMEXXXXXXX SCO

            return teamTournString;
        }//END

        //---------------------------------------------------------------------

        private string[] getConference21Bracket(string[] displayLines)
        {
            string[] displayBracket = new string[]
            {
                displayLines[0],
                getBlankSectionString() + "|" + displayLines[4],
                displayLines[1] + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[6],
                displayLines[2] + " " + getBlankSectionString() + "|",
                getBlankSectionString() + "|" + displayLines[5] + "|",
                displayLines[3] + "|"
            };

            return displayBracket;
        }//END

        //---------------------------------------------------------------------

        private string[] getConference421Bracket(string[] displayLines)
        {
            string[] displayBracket = new string[]
            {
                displayLines[0],
                getBlankSectionString() + "|" + displayLines[8],
                displayLines[1] + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[12],
                displayLines[2] + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + "|" + displayLines[9] + "|" + getBlankSectionString() + "|",
                displayLines[3] + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[14],
                displayLines[4] + " " + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + "|" + displayLines[10] + " " + getBlankSectionString() + "|",
                displayLines[5] + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[13] + "|",
                displayLines[6] + " " + getBlankSectionString() + "|",
                getBlankSectionString() + "|" + displayLines[11] + "|",
                displayLines[7] + "|"
            };

            return displayBracket;
        }//END

        //---------------------------------------------------------------------

        private string[] getConference2221Bracket(string[] displayLines)
        {
            string[] displayBracket = new string[]
            {
                getBlankSectionString() + " " + getBlankSectionString() + " " + displayLines[8],
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[12],
                getBlankSectionString() + " " + displayLines[4] + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[9] + "|" + getBlankSectionString() + "|",
                displayLines[0] + " " + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + "|" + displayLines[5] + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|",
                displayLines[1] + "|" + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[14],
                getBlankSectionString() + " " + getBlankSectionString() + " " + displayLines[10] + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[13] + "|",
                getBlankSectionString() + " " + displayLines[6] + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[11] + "|",
                displayLines[2] + " " + getBlankSectionString() + "|",
                getBlankSectionString() + "|" + displayLines[7] + "|",
                displayLines[3] + "|"
            };

            return displayBracket;
        }//END

        //---------------------------------------------------------------------

        private string[] getConference3221Bracket(string[] displayLines)
        {
            string[] displayBracket = new string[]
            {
                getBlankSectionString() + " " + getBlankSectionString() + " " + displayLines[10],
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[14],
                displayLines[0] + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + "|" + displayLines[6] + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                displayLines[1] + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[11] + "|" + getBlankSectionString() + "|",
                displayLines[2] + " " + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + "|" + displayLines[7] + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|",
                displayLines[3] + "|" + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[16],
                getBlankSectionString() + " " + getBlankSectionString() + " " + displayLines[12] + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[15] + "|",
                getBlankSectionString() + " " + displayLines[8] + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[13] + "|",
                displayLines[4] + " " + getBlankSectionString() + "|",
                getBlankSectionString() + "|" + displayLines[9] + "|",
                displayLines[5] + "|"
            };

            return displayBracket;
        }//END

        //---------------------------------------------------------------------

        private string[] getConference2421Bracket(string[] displayLines)
        {
            string[] displayBracket = new string[]
            {
                getBlankSectionString() + " " + displayLines[4],
                getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[12],
                displayLines[0] + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + "|" + displayLines[5] + "|" + getBlankSectionString() + "|",
                displayLines[1] + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[16],
                getBlankSectionString() + " " + displayLines[6] + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[13] + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + displayLines[7] + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[18],
                getBlankSectionString() + " " + displayLines[8] + " " + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[14] + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + displayLines[9] + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[17] + "|",
                getBlankSectionString() + " " + displayLines[10] + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[15] + "|",
                displayLines[2] + " " + getBlankSectionString() + "|",
                getBlankSectionString() + "|" + displayLines[11] + "|",
                displayLines[3] + "|"
            };

            return displayBracket;
        }//END

        //---------------------------------------------------------------------

        private string[] getConference22221Bracket(string[] displayLines)
        {
            string[] displayBracket = new string[]
            {
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + " " + displayLines[12],
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[16],
                getBlankSectionString() + " " + getBlankSectionString() + " " + displayLines[8] + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[13] + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + displayLines[4] + " " + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[9] + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|",
                displayLines[0] + " " + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + "|" + displayLines[5] + "|" + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|",
                displayLines[1] + "|" + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[18],
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + " " + displayLines[14] + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[17] + "|",
                getBlankSectionString() + " " + getBlankSectionString() + " " + displayLines[10] + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[15] + "|",
                getBlankSectionString() + " " + displayLines[6] + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[11] + "|",
                displayLines[2] + " " + getBlankSectionString() + "|",
                getBlankSectionString() + "|" + displayLines[7] + "|",
                displayLines[3] + "|"
            };

            return displayBracket;
        }//END

        //---------------------------------------------------------------------

        private string[] getConference3421Bracket(string[] displayLines)
        {
            string[] displayBracket = new string[]
            {
                getBlankSectionString() + " " + displayLines[6],
                getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[14],
                displayLines[0] + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + "|" + displayLines[7] + "|" + getBlankSectionString() + "|",
                displayLines[1] + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[18],
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + displayLines[8] + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[15] + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + displayLines[9] + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[20],
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + displayLines[10] + " " + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[16] + " " + getBlankSectionString() + "|",
                displayLines[2] + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + "|" + displayLines[11] + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                displayLines[3] + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[19] + "|",
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + displayLines[12] + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[17] + "|",
                displayLines[4] + " " + getBlankSectionString() + "|",
                getBlankSectionString() + "|" + displayLines[13] + "|",
                displayLines[5] + "|"
            };

            return displayBracket;
        }//END

        //---------------------------------------------------------------------

        private string[] getConference4421Bracket(string[] displayLines)
        {
            string[] displayBracket = new string[]
            {
                getBlankSectionString() + " " + displayLines[8],
                getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[16],
                displayLines[0] + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + "|" + displayLines[9] + "|" + getBlankSectionString() + "|",
                displayLines[1] + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[20],
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + displayLines[10] + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[17] + "|" + getBlankSectionString() + "|",
                displayLines[2] + " " + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + "|" + displayLines[11] + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|",
                displayLines[3] + "|" + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[22],
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + displayLines[12] + " " + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[18] + " " + getBlankSectionString() + "|",
                displayLines[4] + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + "|" + displayLines[13] + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                displayLines[5] + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[21] + "|",
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + displayLines[14] + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[19] + "|",
                displayLines[6] + " " + getBlankSectionString() + "|",
                getBlankSectionString() + "|" + displayLines[15] + "|",
                displayLines[7] + "|"
            };

            return displayBracket;
        }//END

        //---------------------------------------------------------------------

        private string[] getConference24421Bracket(string[] displayLines)
        {
            string[] displayBracket = new string[]
            {
                getBlankSectionString() + " " + getBlankSectionString() + " " + displayLines[12],
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[20],
                getBlankSectionString() + " " + displayLines[4] + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[13] + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + displayLines[5] + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[24],
                getBlankSectionString() + " " + getBlankSectionString() + " " + displayLines[14] + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[21] + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + displayLines[6] + " " + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[15] + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|",
                displayLines[0] + " " + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + "|" + displayLines[7] + "|" + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|",
                displayLines[1] + "|" + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[26],
                getBlankSectionString() + " " + getBlankSectionString() + " " + displayLines[16] + " " + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[22] + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + displayLines[8] + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[17] + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                displayLines[2] + " " + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + "|" + displayLines[9] + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                displayLines[3] + "|" + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[25] + "|",
                getBlankSectionString() + " " + getBlankSectionString() + " " + displayLines[18] + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[23] + "|",
                getBlankSectionString() + " " + displayLines[10] + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[19] + "|",
                getBlankSectionString() + " " + displayLines[11] + "|"
            };

            return displayBracket;
        }//END

        //---------------------------------------------------------------------
        //---------------------------------------------------------------------
        //CHAMPIONSHIP BRACKETS------------------------------------------------
        //---------------------------------------------------------------------
        //---------------------------------------------------------------------

        public string[] getChampionshipBracket(int[][] teamIndexes, Team[] teams)
        {
            string[] displayLines;

            int lineIndex = 0;

            if (teamIndexes.Length == 2 && projectionUpdated)
            {
                return projection68Bracket;
            }
            else if (teamIndexes.Length == 2 && !projectionUpdated)
            {
                displayLines = new string[127];

                projectionUpdated = true;

                Array.Copy(
                fillAllPlayInTeams(teamIndexes, teams),
                projection68Bracket,
                teamIndexes[0].Length);

                lineIndex = 0;

                for (int index = 0; index < teamIndexes[1].Length; index++)
                {
                    if (teamIndexes[1][index] > -1)
                    {
                        //ADD TEAM
                        displayLines[lineIndex] = getTeamTournString(teamIndexes[1][index], 1, teams);
                    }
                    else
                    {
                        //ADD PLAY IN GAME REFERENCE
                        displayLines[lineIndex] = getPlayInGameReferenceString(index / 2);
                    }//END IF
                    
                    lineIndex++;
                }//END FOR ALL FIRST ROUND TEAMS

                for (int index = lineIndex; index < displayLines.Length; index++)
                {
                    //ADD BLANK
                    displayLines[index] = getLineString();
                }//END FOR ALL REMAINING ROUNDS TEAMS

                return fill68ChampBracket(displayLines, true);
            }
            else if (teamIndexes.Length == 8 && championshipUpdated)
            {
                return championship68Bracket;
            }
            else if (teamIndexes.Length == 8 && !championshipUpdated)
            {
                displayLines = new string[127]; championshipUpdated = true;

                championshipUpdated = true;

                Array.Copy(
                fillAllPlayInTeams(teamIndexes, teams),
                championship68Bracket,
                teamIndexes[0].Length);

                Array.Copy(
                fillChampTournamentTeams(displayLines, teamIndexes, teams),
                displayLines,
                displayLines.Length);

                return fill68ChampBracket(displayLines, false);
            }
            else if (teamIndexes.Length == 5 && championshipUpdated)
            {
                return championship16Bracket;
            }
            else if (teamIndexes.Length == 5 && !championshipUpdated)
            {
                displayLines = new string[31];

                lineIndex = 0;

                championshipUpdated = true;

                for (int roundIndex = 0; roundIndex < teamIndexes.Length; roundIndex++)
                {
                    for (int rowIndex = 0; rowIndex < teamIndexes[roundIndex].Length; rowIndex++)
                    {
                        if (teamIndexes[roundIndex][rowIndex] > -1)
                        {
                            //ADD TEAM
                            displayLines[lineIndex] = getTeamTournString(teamIndexes[roundIndex][rowIndex], roundIndex, teams);
                        }
                        else
                        {
                            //ADD BLANK
                            displayLines[lineIndex] = getLineString();
                        }//END IF

                        lineIndex++;
                    }//END FOR ROWS
                }//END FOR ALL ROUNDS

                return fill16ChampBracket(displayLines, "");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("ERROR: INVALID TOURNAMENT ARRAY SENT TO BRACKETS");
                displayLines = new string[1];
                return displayLines;
            }//END IF
        }//END

        //---------------------------------------------------------------------

        public string[] getChampionshipBracket(int[][] teamIndexes, Team[] teams, string region)
        {
            int playInLength = 0;

            string[] displayLines = new string[31];

            for (int index = 0; index < teamIndexes[0].Length; index++)
            {
                if (0 == string.Compare(teams[teamIndexes[0][index]].champTournRegion, region))
                {
                    playInLength++;
                }//END IF
            }//END FOR ALL PLAY IN TEAMS

            if (0 == string.Compare(appResources.getChampTounRegionTypeText(0), region) && championshipUpdated)
            {
                return championshipWestBracket;
            }
            else if (0 == string.Compare(appResources.getChampTounRegionTypeText(0), region) && !championshipUpdated)
            {
                championshipWestBracket = new string[31 + playInLength];

                championshipUpdated = true;

                Array.Copy(
                fillPlayInTeams(playInLength, teamIndexes, teams, region),
                championshipWestBracket,
                playInLength);

                Array.Copy(
                fillChampTournamentTeams(displayLines, teamIndexes, teams),
                displayLines,
                displayLines.Length);

                return fill16ChampBracket(displayLines, region);
            }
            else if (0 == string.Compare(appResources.getChampTounRegionTypeText(1), region) && championshipUpdated)
            {
                return championshipMidwestBracket;
            }
            else if (0 == string.Compare(appResources.getChampTounRegionTypeText(1), region) && !championshipUpdated)
            {
                championshipMidwestBracket = new string[31 + playInLength];

                championshipUpdated = true;

                Array.Copy(
                fillPlayInTeams(playInLength, teamIndexes, teams, region),
                championshipMidwestBracket,
                playInLength);

                Array.Copy(
                fillChampTournamentTeams(displayLines, teamIndexes, teams),
                displayLines,
                displayLines.Length);

                return fill16ChampBracket(displayLines, region);
            }
            else if (0 == string.Compare(appResources.getChampTounRegionTypeText(2), region) && championshipUpdated)
            {
                return championshipSouthBracket;
            }
            else if (0 == string.Compare(appResources.getChampTounRegionTypeText(2), region) && !championshipUpdated)
            {
                championshipSouthBracket = new string[31 + playInLength];

                championshipUpdated = true;

                Array.Copy(
                fillPlayInTeams(playInLength, teamIndexes, teams, region),
                championshipSouthBracket,
                playInLength);

                Array.Copy(
                fillChampTournamentTeams(displayLines, teamIndexes, teams),
                displayLines,
                displayLines.Length);

                return fill16ChampBracket(displayLines, region);
            }
            else if (0 == string.Compare(appResources.getChampTounRegionTypeText(3), region) && championshipUpdated)
            {
                return championshipEastBracket;
            }
            else if (0 == string.Compare(appResources.getChampTounRegionTypeText(3), region) && !championshipUpdated)
            {
                championshipEastBracket = new string[31 + playInLength];

                championshipUpdated = true;

                Array.Copy(
                fillPlayInTeams(playInLength, teamIndexes, teams, region),
                championshipEastBracket,
                playInLength);

                Array.Copy(
                fillChampTournamentTeams(displayLines, teamIndexes, teams),
                displayLines,
                displayLines.Length);

                return fill16ChampBracket(displayLines, region);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("ERROR: INVALID TOURNAMENT INFO SENT TO BRACKETS");
                displayLines = new string[1];
                return displayLines;
            }//END IF

        }//END

        //---------------------------------------------------------------------

        private string[] fillAllPlayInTeams(int[][] teamIndexes, Team[] teams)
        {
            string[] playInTeams = new string[teamIndexes[0].Length];

            for (int index = 0; index < teamIndexes[0].Length; index += 2)
            {
                //ADD PLAY IN TEAMS
                playInTeams[index] = getPlayInGameString(teamIndexes[0][index], teamIndexes[0][index + 1], index / 2, teams);
                playInTeams[index + 1] = "";
            }//END FOR ALL PLAY IN TEAMS

            return playInTeams;
        }//END

        //---------------------------------------------------------------------

        private string[] fillPlayInTeams(int playInLength, int[][] teamIndexes, Team[] teams, string region)
        {
            string[] playInTeams = new string[playInLength];

            int lineIndex = 0;

            for (int index = 0; index < teamIndexes[0].Length; index += 2)
            {
                if (0 == string.Compare(teams[teamIndexes[0][index]].champTournRegion, region))
                {
                    //ADD PLAY IN TEAMS
                    playInTeams[lineIndex] = getPlayInGameString(teamIndexes[0][index], teamIndexes[0][index + 1], index / 2, teams);
                    playInTeams[lineIndex + 1] = "";
                    lineIndex += 2;
                }//END IF
            }//END FOR ALL PLAY IN TEAMS

            return playInTeams;
        }//END

        //---------------------------------------------------------------------

        private string[] fillChampTournamentTeams(string[] displayLines, int[][] teamIndexes, Team[] teams)
        {
            int lineIndex = 0;

            for (int roundIndex = 1; roundIndex < teamIndexes.Length; roundIndex++)
            {
                for (int rowIndex = 0; rowIndex < teamIndexes[roundIndex].Length; rowIndex++)
                {
                    if (teamIndexes[roundIndex][rowIndex] > -1)
                    {
                        //ADD TEAM
                        displayLines[lineIndex] = getTeamTournString(teamIndexes[roundIndex][rowIndex], roundIndex, teams);
                    }
                    else if (roundIndex == 1)
                    {
                        //ADD PLAY IN GAME REFERENCE
                        displayLines[lineIndex] = getPlayInGameReferenceString(rowIndex / 2);
                    }
                    else
                    {
                        //ADD BLANK
                        displayLines[lineIndex] = getLineString();
                    }//END IF

                    lineIndex++;
                }//END FOR ROWS
            }//END FOR ALL ROUNDS

            return displayLines;
        }//END

        //---------------------------------------------------------------------

        private string getPlayInGameString(int teamIndex1, int teamIndex2, int playInIndex, Team[] teams)
        {
            string playInGameString = "Play In " + playInGameLetters[playInIndex] + " #" + 
                (teams[teamIndex1].champTournSeed + 1) + " " + teams[teamIndex1].teamNameDisplay + 
                " " + teams[teamIndex1].getPoints(0, appResources.getScheduleTypeText(7)) + 
                " Vs. #" +
                (teams[teamIndex2].champTournSeed + 1) + " " + teams[teamIndex2].teamNameDisplay +
                " " + teams[teamIndex2].getPoints(0, appResources.getScheduleTypeText(7));

            //Play In G #SE XXXXXXXTEAMNAMEXXXXXXX SCO Vs. #SE XXXXXXXTEAMNAMEXXXXXXX SCO

            return playInGameString;
        }//END

        //---------------------------------------------------------------------

        private string getTeamTournString(int teamIndex, int round, Team[] teams)
        {
            string score = "";

            string teamTournString = "#" + (teams[teamIndex].champTournSeed + 1);

            teamTournString.PadRight(4, '_');

            teamTournString = teamTournString + teams[teamIndex].teamNameDisplay;

            teamTournString.PadRight(27, '_');

            if (teams[teamIndex].playInParticipant)
            {
                score = teams[teamIndex].getPoints(round, appResources.getScheduleTypeText(7)).ToString();
            }
            else 
            {
                score = teams[teamIndex].getPoints(round - 1, appResources.getScheduleTypeText(7)).ToString();
            }//END IF

            score.PadLeft(3, '_');

            teamTournString = teamTournString + score;

            //#SE XXXXXXXTEAMNAMEXXXXXXX SCO

            return teamTournString;
        }//END

        //---------------------------------------------------------------------

        private string getPlayInGameReferenceString(int playInIndex)
        {
            string playInGameReferenceString = "Play_In_" + playInGameLetters[playInIndex];

            return playInGameReferenceString.PadRight(30, '_');
        }//END

        //---------------------------------------------------------------------

        private string[] fill16ChampBracket(string[] displayLines, string region)
        {

            int bracketLength = 0;

            int startIndex = 0;

            string[] displayBracket = new string[]
            {
                displayLines[0],
                getBlankSectionString() + "|" + displayLines[16],
                displayLines[1] + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[24],
                displayLines[2] + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + "|" + displayLines[17] + "|" + getBlankSectionString() + "|",
                displayLines[3] + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[28],
                displayLines[4] + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + "|" + displayLines[18] + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                displayLines[5] + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[25] + "|" + getBlankSectionString() + "|",
                displayLines[6] + " " + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + "|" + displayLines[19] + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|",
                displayLines[7] + "|" + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[30],
                displayLines[8] + " " + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + "|" + displayLines[20] + " " + getBlankSectionString() + " " + getBlankSectionString() + "|",
                displayLines[9] + "|" + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[26] + " " + getBlankSectionString() + "|",
                displayLines[10] + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + "|" + displayLines[21] + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                displayLines[11] + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[29] + "|",
                displayLines[12] + " " + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + "|" + displayLines[22] + " " + getBlankSectionString() + "|",
                displayLines[13] + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[27] + "|",
                displayLines[14] + " " + getBlankSectionString() + "|",
                getBlankSectionString() + "|" + displayLines[23] + "|",
                displayLines[15] + "|"
            };

            if (0 == string.Compare(appResources.getChampTounRegionTypeText(0), region))
            {
                //WEST
                bracketLength = championshipWestBracket.Length;

                startIndex = bracketLength - displayBracket.Length;

                for (int index = startIndex; index < bracketLength; index++)
                {
                    championshipWestBracket[index] = displayBracket[index - startIndex];
                }//END FOR ALL LINES

                return championshipWestBracket;
            }
            else if (0 == string.Compare(appResources.getChampTounRegionTypeText(1), region))
            {
                //MIDWEST
                bracketLength = championshipMidwestBracket.Length;

                startIndex = bracketLength - displayBracket.Length;

                for (int index = startIndex; index < bracketLength; index++)
                {
                    championshipMidwestBracket[index] = displayBracket[index - startIndex];
                }//END FOR ALL LINES

                return championshipMidwestBracket;
            }
            else if (0 == string.Compare(appResources.getChampTounRegionTypeText(2), region))
            {
                //SOUTH
                bracketLength = championshipSouthBracket.Length;

                startIndex = bracketLength - displayBracket.Length;

                for (int index = startIndex; index < bracketLength; index++)
                {
                    championshipSouthBracket[index] = displayBracket[index - startIndex];
                }//END FOR ALL LINES

                return championshipSouthBracket;
            }
            else if (0 == string.Compare(appResources.getChampTounRegionTypeText(3), region))
            {
                //EAST
                bracketLength = championshipEastBracket.Length;

                startIndex = bracketLength - displayBracket.Length;

                for (int index = startIndex; index < bracketLength; index++)
                {
                    championshipEastBracket[index] = displayBracket[index - startIndex];
                }//END FOR ALL LINES

                return championshipEastBracket;
            }
            else
            {
                //SWEET 16
                for (int index = 0; index < championship16Bracket.Length; index++)
                {
                    championship16Bracket[index] = displayBracket[index - startIndex];
                }//END FOR ALL LINES

                return championship16Bracket;
            }//END IF
        }//END

        //---------------------------------------------------------------------

        private string[] fill68ChampBracket(string[] displayLines, Boolean projected)
        {
            string[] displayBracket = new string[]
            {
                displayLines[0],
                getBlankSectionString() + "|" + displayLines[64],
                displayLines[1] + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[96],
                displayLines[2] + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + "|" + displayLines[65] + "|" + getBlankSectionString() + "|",
                displayLines[3] + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[112],
                displayLines[4] + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + "|" + displayLines[66] + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                displayLines[5] + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[97] + "|" + getBlankSectionString() + "|",
                displayLines[6] + " " + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + "|" + displayLines[67] + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|",
                displayLines[7] + "|" + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[120],
                displayLines[8] + " " + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + "|" + displayLines[68] + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                displayLines[9] + "|" + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[98] + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                displayLines[10] + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + "|" + displayLines[69] + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                displayLines[11] + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[113] + "|" + getBlankSectionString() + "|",
                displayLines[12] + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + "|" + displayLines[70] + " " + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|",
                displayLines[13] + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[99] + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|",
                displayLines[14] + " " + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + "|" + displayLines[71] + "|" + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|",
                displayLines[15] + "|" + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[124],
                displayLines[16] + " " + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + "|" + displayLines[72] + " " + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                displayLines[17] + "|" + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[100] + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                displayLines[18] + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + "|" + displayLines[73] + "|" + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                displayLines[19] + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[114] + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                displayLines[20] + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + "|" + displayLines[74] + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                displayLines[21] + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[101] + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                displayLines[22] + " " + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + "|" + displayLines[75] + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                displayLines[23] + "|" + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[121] + "|" + getBlankSectionString() + "|",
                displayLines[24] + " " + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + "|" + displayLines[76] + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|",
                displayLines[25] + "|" + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[102] + " " + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|",
                displayLines[26] + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + "|" + displayLines[77] + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|",
                displayLines[27] + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[115] + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|",
                displayLines[28] + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + "|" + displayLines[78] + " " + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|",
                displayLines[29] + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[103] + "|" + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|",
                displayLines[30] + " " + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + "|" + displayLines[79] + "|" + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|",
                displayLines[31] + "|" + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[126],
                displayLines[32] + " " + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + "|" + displayLines[80] + " " + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|",
                displayLines[33] + "|" + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[104] + " " + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|",
                displayLines[34] + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + "|" + displayLines[81] + "|" + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|",
                displayLines[35] + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[116] + " " + getBlankSectionString() + " " + getBlankSectionString() + "|",
                displayLines[36] + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + "|" + displayLines[82] + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|",
                displayLines[37] + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[105] + "|" + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|",
                displayLines[38] + " " + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + "|" + displayLines[83] + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|",
                displayLines[39] + "|" + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[122] + " " + getBlankSectionString() + "|",
                displayLines[40] + " " + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + "|" + displayLines[84] + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                displayLines[41] + "|" + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[106] + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                displayLines[42] + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + "|" + displayLines[85] + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                displayLines[43] + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[117] + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                displayLines[44] + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + "|" + displayLines[86] + " " + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                displayLines[45] + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[107] + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                displayLines[46] + " " + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + "|" + displayLines[87] + "|" + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                displayLines[47] + "|" + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[125] + "|",
                displayLines[48] + " " + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + "|" + displayLines[88] + " " + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|",
                displayLines[49] + "|" + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[108] + " " + getBlankSectionString() + " " + getBlankSectionString() + "|",
                displayLines[50] + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + "|" + displayLines[89] + "|" + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|",
                displayLines[51] + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[118] + " " + getBlankSectionString() + "|",
                displayLines[52] + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + "|" + displayLines[90] + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                displayLines[53] + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[109] + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                displayLines[54] + " " + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + "|" + displayLines[91] + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                displayLines[55] + "|" + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[123] + "|",
                displayLines[56] + " " + getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + "|" + displayLines[92] + " " + getBlankSectionString() + " " + getBlankSectionString() + "|",
                displayLines[57] + "|" + getBlankSectionString() + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[110] + " " + getBlankSectionString() + "|",
                displayLines[58] + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + "|" + displayLines[93] + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                displayLines[59] + "|" + getBlankSectionString() + " " + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[119] + "|",
                displayLines[60] + " " + getBlankSectionString() + " " + getBlankSectionString() + "|",
                getBlankSectionString() + "|" + displayLines[94] + " " + getBlankSectionString() + "|",
                displayLines[61] + "|" + getBlankSectionString() + "|" + getBlankSectionString() + "|",
                getBlankSectionString() + " " + getBlankSectionString() + "|" + displayLines[111] + "|",
                displayLines[62] + " " + getBlankSectionString() + "|",
                getBlankSectionString() + "|" + displayLines[95] + "|",
                displayLines[63] + "|"
            };

            if (projected)
            {
                //PROJECTED BRACKET
                for (int index = 8; index < projection68Bracket.Length; index++)
                {
                    projection68Bracket[index] = displayBracket[index - 8];
                }//END FOR ALL LINES 

                return projection68Bracket;
            }
            else
            {
                //CHAMPIONSHIP BRACKET
                for (int index = 8; index < championship68Bracket.Length; index++)
                {
                    championship68Bracket[index] = displayBracket[index - 8];
                }//END FOR ALL LINES 

                return championship68Bracket;
            }//END IF

        }//END

    }
}
