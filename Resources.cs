using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_Basketball_Simulator
{
    class Resources
    {

        // 0 MainMenuIntro 
        // 1 MainMenu 
        // 2 Settings
        // 3 SaveFold 
        // 4 SaveAs 
        // 5 Load 
        // 6 SimTo 
        // 7 StartFrom
        // 8 SchedFind 
        // 9 TeamSched 
        // 10 DateSched 
        // 11 Stand
        // 12 Top25 
        // 13 TournProList 
        // 14 TournProBrac 
        // 15 ConTournBrac
        // 16 ConTournFind 
        // 17 TournList 
        // 18 TournBrac

        private static readonly string[] arrayStringMenus = new string[]
        {
            "MainMenuIntro", "MainMenu", "Settings",
            "SaveFold", "SaveAs", "Load", "SimTo", "StartFrom",
            "SchedFind", "TeamSched", "DateSched", "Stand",
            "Top25", "TournProList", "TournProBrac", "ConTournBrac",
            "ConTournFind", "TournList", "TournBrac"
        };

        // 0 NoDataState 
        // 1 PreseasonState
        // 2 SeasonState 
        // 3 ConferenceTournamentState 
        // 4 ChampionshipTournamentState 
        // 5 PostSeasonState

        private static readonly string[] arrayStringStates = new string[] {"NoDataState", "PreseasonState",
        "SeasonState", "ConferenceTournamentState", "ChampionshipTournamentState", "PostSeasonState"};

        // 0 NotPlayed
        // 1 Win
        // 2 Loss

        private static readonly string[] arrayStringGameResultType = new string[]
        {"NotPlayed", "Win", "Loss"};

        // 0 RegularSeason
        // 1 ConferenceTournament
        // 2 ChampionshipTournament
        // 3 SecondaryTournament

        private static readonly string[] arrayStringGameType = new string[]
        {"RegularSeason", "ConferenceTournament", "ChampionshipTournament", "SecondaryTournament"};

        // 0 Real Schedule
        // 1 Real RegularSeason
        // 2 Real ConferenceTournament
        // 3 Real ChampionshipTournament
        // 4 Sim Schedule
        // 5 Sim RegularSeason
        // 6 Sim ConferenceTournament
        // 7 Sim ChampionshipTournament

        private static readonly string[] arrayStringScheduleType = new string[]
        {
            "RealSchedule", "RealRegSeason", "RealConfTourn", "RealChampTourn",
            "SimSchedule", "SimRegSeason", "SimConfTourn", "SimChampTourn"
        };

        private static readonly string simulationType = "Normal";

        // 0 West
        // 1 Midwest
        // 2 South
        // 3 East

        private static readonly string[] arrayStringChampTounRegionType = new string[]
        {"West", "Midwest", "South", "East"};

        private static readonly string[] arrayStringMonths = new string[]
        {
            "Jan", "Feb", "Mar", "Apr",
            "May", "Jun", "Jul", "Aug",
            "Sept", "Oct", "Nov", "Dec"
        };

        //---------------------------------------------------------------------

        private static readonly string[] arrayStringTeamNames = new string[]
        {
            "Abilene Christian", "Air Force", "Akron", "Alabama", "Alabama A&M",
            "Alabama St.", "Albany", "Alcorn St.", "American", "Appalachian St.",
            "Arizona", "Arizona St.", "Arkansas", "Arkansas Pine Bluff", "Arkansas St.",
            "Army", "Auburn", "Austin Peay", "Ball St.", "Baylor",
            "Belmont", "Bethune Cookman", "Binghamton", "Boise St.", "Boston College",
            "Boston University", "Bowling Green", "Bradley", "Brown", "Bryant",
            "Bucknell", "Buffalo", "Butler", "BYU", "Cal Baptist",
            "Cal Poly", "Cal St. Bakersfield", "Cal St. Fullerton", "Cal St. Northridge", "California",
            "Campbell", "Canisius", "Central Arkansas", "Central Connecticut", "Central Michigan",
            "Charleston", "Charleston Southern", "Charlotte", "Chattanooga", "Chicago St.",
            "Cincinnati", "Clemson", "Cleveland St.", "Coastal Carolina", "Colgate",
            "Colorado", "Colorado St.", "Columbia", "Connecticut", "Coppin St.",
            "Cornell", "Creighton", "Dartmouth", "Davidson", "Dayton",
            "Delaware", "Delaware St.", "Denver", "DePaul", "Detroit",
            "Drake", "Drexel", "Duke", "Duquesne", "East Carolina",
            "East Tennessee St.", "Eastern Illinois", "Eastern Kentucky", "Eastern Michigan", "Eastern Washington",
            "Elon", "Evansville", "Fairfield", "Fairleigh Dickinson", "FIU",
            "Florida", "Florida A&M", "Florida Atlantic", "Florida Gulf Coast", "Florida St.",
            "Fordham", "Fresno St.", "Furman", "Gardner Webb", "George Mason",
            "George Washington", "Georgetown", "Georgia", "Georgia Southern", "Georgia St.",
            "Georgia Tech", "Gonzaga", "Grambling St.", "Grand Canyon", "Green Bay",
            "Hampton", "Hartford", "Harvard", "Hawaii", "High Point",
            "Hofstra", "Holy Cross", "Houston", "Houston Baptist", "Howard",
            "Idaho", "Idaho St.", "Illinois", "Illinois Chicago", "Illinois St.",
            "Incarnate Word", "Indiana", "Indiana St.", "Iona", "Iowa",
            "Iowa St.", "IUPUI", "Jackson St.", "Jacksonville", "Jacksonville St.",
            "James Madison", "Kansas", "Kansas St.", "Kennesaw St.", "Kent St.",
            "Kentucky", "La Salle", "Lafayette", "Lamar", "Lehigh",
            "Liberty", "Lipscomb", "Little Rock", "LIU", "Long Beach St.",
            "Longwood", "Louisiana", "Louisiana Monroe", "Louisiana Tech", "Louisville",
            "Loyola Chicago", "Loyola Marymount", "Loyola MD", "LSU", "Maine",
            "Manhattan", "Marist", "Marquette", "Marshall", "Maryland",
            "Maryland Eastern Shore", "Massachusetts", "McNeese St.", "Memphis", "Mercer",
            "Merrimack", "Miami FL", "Miami OH", "Michigan", "Michigan St.",
            "Middle Tennessee", "Milwaukee", "Minnesota", "Mississippi", "Mississippi St.",
            "Mississippi Valley St.", "Missouri", "Missouri St.", "Monmouth", "Montana",
            "Montana St.", "Morehead St.", "Morgan St.", "Mount St. Mary's", "Murray St.",
            "N.C. State", "Navy", "Nebraska", "Nebraska Omaha", "Nevada",
            "New Hampshire", "New Mexico", "New Mexico St.", "New Orleans", "Niagara",
            "Nicholls St.", "NJIT", "Norfolk St.", "North Alabama", "North Carolina",
            "North Carolina A&T", "North Carolina Central", "North Dakota", "North Dakota St.", "North Florida",
            "North Texas", "Northeastern", "Northern Arizona", "Northern Colorado", "Northern Illinois",
            "Northern Iowa", "Northern Kentucky", "Northwestern", "Northwestern St.", "Notre Dame",
            "Oakland", "Ohio", "Ohio St.", "Oklahoma", "Oklahoma St.",
            "Old Dominion", "Oral Roberts", "Oregon", "Oregon St.", "Pacific",
            "Penn", "Penn St.", "Pepperdine", "Pittsburgh", "Portland",
            "Portland St.", "Prairie View A&M", "Presbyterian", "Princeton", "Providence",
            "Purdue", "Purdue Fort Wayne", "Quinnipiac", "Radford", "Rhode Island",
            "Rice", "Richmond", "Rider", "Robert Morris", "Rutgers",
            "Sacramento St.", "Sacred Heart", "Saint Joseph's", "Saint Louis", "Saint Mary's",
            "Saint Peter's", "Sam Houston St.", "Samford", "San Diego", "San Diego St.",
            "San Francisco", "San Jose St.", "Santa Clara", "Seattle", "Seton Hall",
            "Siena", "SIU Edwardsville", "SMU", "South Alabama", "South Carolina",
            "South Carolina St.", "South Dakota", "South Dakota St.", "South Florida", "Southeast Missouri St.",
            "Southeastern Louisiana", "Southern", "Southern Illinois", "Southern Miss", "Southern Utah",
            "St. Bonaventure", "St. Francis NY", "St. Francis PA", "St. John's", "Stanford",
            "Stephen F. Austin", "Stetson", "Stony Brook", "Syracuse", "TCU",
            "Temple", "Tennessee", "Tennessee Martin", "Tennessee St.", "Tennessee Tech",
            "Texas", "Texas A&M", "Texas A&M Corpus Chris", "Texas Southern", "Texas St.",
            "Texas Tech", "The Citadel", "Toledo", "Towson", "Troy",
            "Tulane", "Tulsa", "UAB", "UC Davis", "UC Irvine",
            "UC Riverside", "UC Santa Barbara", "UCF", "UCLA", "UMass Lowell",
            "UMBC", "UMKC", "UNC Asheville", "UNC Greensboro", "UNC Wilmington",
            "UNLV", "USC", "USC Upstate", "UT Arlington", "UT Rio Grande Valley",
            "Utah", "Utah St.", "Utah Valley", "UTEP", "UTSA",
            "Valparaiso", "Vanderbilt", "VCU", "Vermont", "Villanova",
            "Virginia", "Virginia Tech", "VMI", "Wagner", "Wake Forest",
            "Washington", "Washington St.", "Weber St.", "West Virginia", "Western Carolina",
            "Western Illinois", "Western Kentucky", "Western Michigan", "Wichita St.", "William & Mary",
            "Winthrop", "Wisconsin", "Wofford", "Wright St.", "Wyoming",
            "Xavier", "Yale", "Youngstown St."
        };

        //---------------------------------------------------------------------

        private static readonly string[] arrayStringESPNTeamIDs = new string[]
        {
            "2000", "2005", "2006", "333", "2010", "2011", "399", "2016", "44", "2026",
            "12", "9", "8", "2029", "2032", "349", "2", "2046", "2050", "239",
            "2057", "2065", "2066", "68", "103", "104", "189", "71", "225", "2803",
            "2083", "2084", "2086", "252", "2856", "13", "2934", "2239", "2463", "25",
            "2097", "2099", "2110", "2115", "2117", "232", "2127", "2429", "236", "2130",
            "2132", "228", "325", "324", "2142", "38", "36", "171", "41", "2154",
            "172", "156", "159", "2166", "2168", "48", "2169", "2172", "305", "2174",
            "2181", "2182", "150", "2184", "151", "2193", "2197", "2198", "2199", "331",
            "2210", "339", "2217", "161", "2229", "57", "50", "2226", "526", "52",
            "2230", "278", "231", "2241", "2244", "45", "46", "61", "290", "2247",
            "59", "2250", "2755", "2253", "2739", "2261", "42", "108", "62", "2272",
            "2275", "107", "248", "2277", "47", "70", "304", "356", "82", "2287",
            "2916", "84", "282", "314", "2294", "66", "85", "2296", "294", "55",
            "256", "2305", "2306", "338", "2309", "96", "2325", "322", "2320", "2329",
            "2335", "288", "2031", "112358", "299", "2344", "309", "2433", "2348", "97",
            "2350", "2351", "2352", "99", "311", "2363", "2368", "269", "276", "120",
            "2379", "113", "2377", "235", "2382", "2771", "2390", "193", "130", "127",
            "2393", "270", "135", "145", "344", "2400", "142", "2623", "2405", "149",
            "147", "2413", "2415", "116", "93", "152", "2426", "158", "2437", "2440",
            "160", "167", "166", "2443", "315", "2447", "2885", "2450", "2453", "153",
            "2448", "2428", "155", "2449", "2454", "249", "111", "2464", "2458", "2459",
            "2460", "94", "77", "2466", "87", "2473", "195", "194", "201", "197",
            "295", "198", "2483", "204", "279", "219", "213", "2492", "221", "2501",
            "2502", "2504", "2506", "163", "2507", "2509", "2870", "2514", "2515", "227",
            "242", "257", "2520", "2523", "164", "16", "2529", "2603", "139", "2608",
            "2612", "2534", "2535", "301", "21", "2539", "23", "2541", "2547", "2550",
            "2561", "2565", "2567", "6", "2579", "2569", "233", "2571", "58", "2546",
            "2545", "2582", "79", "2572", "253", "179", "2597", "2598", "2599", "24",
            "2617", "56", "2619", "183", "2628", "218", "2633", "2630", "2634", "2635",
            "251", "245", "357", "2640", "326", "2641", "2643", "2649", "119", "2653",
            "2655", "202", "5", "302", "300", "27", "2540", "2116", "26", "2349",
            "2378", "140", "2427", "2430", "350", "2439", "30", "2908", "250", "292",
            "254", "328", "3084", "2638", "2636", "2674", "238", "2670", "261", "222",
            "258", "259", "2678", "2681", "154", "264", "265", "2692", "277", "2717",
            "2710", "98", "2711", "2724", "2729", "2737", "275", "2747", "2750", "2751",
            "2752", "43", "2754"
        };

        //---------------------------------------------------------------------

        private static readonly int[][] arrayTeamIndexesByConference = new int[][]
        {
            new int[] { 6, 22, 106, 154, 190, 282, 309, 310, 328},
            new int[] { 50, 58, 74, 112, 163, 262, 268, 285, 300, 301, 307, 343},
            new int[] { 63, 64, 73, 90, 94, 95, 136, 161, 239, 241, 247, 248, 275, 327},
            new int[] { 24, 51, 72, 89, 100, 149, 166, 185, 199, 214, 228, 283, 330, 331, 334},
            new int[] { 88, 128, 133, 140, 141, 196, 198, 204, 281},
            new int[] { 19, 125, 131, 132, 218, 219, 284, 290, 295, 338},
            new int[] { 32, 61, 68, 96, 157, 234, 259, 278, 329, 350},
            new int[] { 79, 115, 116, 179, 180, 207, 208, 230, 245, 274, 337},
            new int[] { 40, 46, 93, 105, 109, 145, 232, 238, 312, 317, 345},
            new int[] { 117, 121, 124, 159, 168, 169, 172, 187, 212, 217, 226, 235, 244, 346},
            new int[] { 35, 37, 38, 108, 144, 303, 304, 305, 306},
            new int[] { 45, 65, 71, 80, 110, 130, 206, 298, 314, 344},
            new int[] { 47, 84, 87, 148, 158, 170, 205, 220, 240, 273, 302, 323, 324, 341},
            new int[] { 52, 69, 104, 118, 126, 171, 211, 215, 348, 352},
            new int[] { 28, 57, 60, 62, 107, 225, 233, 351},
            new int[] { 41, 82, 123, 155, 156, 178, 194, 237, 242, 250, 260},
            new int[] { 2, 18, 26, 31, 44, 78, 134, 167, 209, 216, 297, 342},
            new int[] { 21, 59, 66, 86, 114, 160, 182, 197, 200, 201, 265},
            new int[] { 27, 70, 81, 119, 122, 150, 177, 210, 272, 325},
            new int[] { 1, 23, 56, 91, 189, 191, 254, 256, 315, 321, 349},
            new int[] { 29, 43, 83, 143, 165, 183, 243, 246, 276, 277, 333},
            new int[] { 17, 20, 76, 77, 129, 181, 184, 261, 269, 287, 288, 289},
            new int[] { 10, 11, 39, 55, 222, 223, 279, 308, 316, 320, 335, 336},
            new int[] { 8, 15, 25, 30, 54, 111, 137, 139, 152, 186},
            new int[] { 3, 12, 16, 85, 97, 135, 153, 173, 174, 176, 264, 286, 291, 326},
            new int[] { 48, 75, 92, 164, 252, 296, 313, 332, 339, 347},
            new int[] { 0, 42, 113, 120, 138, 162, 193, 195, 213, 251, 270, 280, 292},
            new int[] { 4, 5, 7, 13, 102, 127, 175, 231, 271, 293},
            new int[] { 67, 188, 202, 203, 221, 236, 266, 267, 340},
            new int[] { 9, 14, 53, 98, 99, 142, 146, 147, 263, 294, 299, 318},
            new int[] { 33, 101, 151, 224, 227, 229, 249, 253, 255, 257},
            new int[] { 34, 36, 49, 103, 192, 258, 311, 319, 322}
        };

        //---------------------------------------------------------------------

        private static readonly string[] arrayStringConferenceAbrvByTeam = new string[]
        {
            "Slnd", "MWC", "MAC", "SEC", "SWAC", "SWAC", "AE", "SWAC", "Pat", "SB",
            "P12", "P12", "SEC", "SWAC", "SB", "Pat", "SEC", "OVC", "MAC", "B12",
            "OVC", "MEAC", "AE", "MWC", "ACC", "Pat", "MAC", "MVC", "Ivy", "NEC",
            "Pat", "MAC", "BE", "WCC", "WAC", "BW", "WAC", "BW", "BW", "P12",
            "BSth", "MAAC", "Slnd", "NEC", "MAC", "CAA", "BSth", "CUSA", "SC", "WAC",
            "Amer", "ACC", "Horz", "SB", "Pat", "P12", "MWC", "Ivy", "Amer", "MEAC",
            "Ivy", "BE", "Ivy", "A10", "A10", "CAA", "MEAC", "Sum", "BE", "Horz",
            "MVC", "CAA", "ACC", "A10", "Amer", "SC", "OVC", "OVC", "MAC", "BSky",
            "CAA", "MVC", "MAAC", "NEC", "CUSA", "SEC", "MEAC", "CUSA", "ASun", "ACC",
            "A10", "MWC", "SC", "BSth", "A10", "A10", "BE", "SEC", "SB", "SB",
            "ACC", "WCC", "SWAC", "WAC", "Horz", "BSth", "AE", "Ivy", "BW", "BSth",
            "CAA", "Pat", "Amer", "Slnd", "MEAC", "BSky", "BSky", "B10", "Horz", "MVC",
            "Slnd", "B10", "MVC", "MAAC", "B10", "B12", "Horz", "SWAC", "ASun", "OVC",
            "CAA", "B12", "B12", "ASun", "MAC", "SEC", "A10", "Pat", "Slnd", "Pat",
            "ASun", "ASun", "SB", "NEC", "BW", "BSth", "SB", "SB", "CUSA", "ACC",
            "MVC", "WCC", "Pat", "SEC", "AE", "MAAC", "MAAC", "BE", "CUSA", "B10",
            "MEAC", "A10", "Slnd", "Amer", "SC", "NEC", "ACC", "MAC", "B10", "B10",
            "CUSA", "Horz", "B10", "SEC", "SEC", "SWAC", "SEC", "MVC", "MAAC", "BSky",
            "BSky", "OVC", "MEAC", "NEC", "OVC", "ACC", "Pat", "B10", "Sum", "MWC",
            "AE", "MWC", "WAC", "Slnd", "MAAC", "Slnd", "ASun", "MEAC", "ASun", "ACC",
            "MEAC", "MEAC", "Sum", "Sum", "ASun", "CUSA", "CAA", "BSky", "BSky", "MAC",
            "MVC", "Horz", "B10", "Slnd", "ACC", "Horz", "MAC", "B10", "B12", "B12",
            "CUSA", "Sum", "P12", "P12", "WCC", "Ivy", "B10", "WCC", "ACC", "WCC",
            "BSky", "SWAC", "BSth", "Ivy", "BE", "B10", "Sum", "MAAC", "BSth", "A10",
            "CUSA", "A10", "MAAC", "NEC", "B10", "BSky", "NEC", "A10", "A10", "WCC",
            "MAAC", "Slnd", "SC", "WCC", "MWC", "WCC", "MWC", "WCC", "WAC", "BE",
            "MAAC", "OVC", "Amer", "SB", "SEC", "MEAC", "Sum", "Sum", "Amer", "OVC",
            "Slnd", "SWAC", "MVC", "CUSA", "BSky", "A10", "NEC", "NEC", "BE", "P12",
            "Slnd", "ASun", "AE", "ACC", "B12", "Amer", "SEC", "OVC", "OVC", "OVC",
            "B12", "SEC", "Slnd", "SWAC", "SB", "B12", "SC", "MAC", "CAA", "SB",
            "Amer", "Amer", "CUSA", "BW", "BW", "BW", "BW", "Amer", "P12", "AE",
            "AE", "WAC", "BSth", "SC", "CAA", "MWC", "P12", "BSth", "SB", "WAC",
            "P12", "MWC", "WAC", "CUSA", "CUSA", "MVC", "SEC", "A10", "AE", "BE",
            "ACC", "ACC", "SC", "NEC", "ACC", "P12", "P12", "BSky", "B12", "SC",
            "Sum", "CUSA", "MAC", "Amer", "CAA", "BSth", "B10", "SC", "Horz", "MWC",
            "BE", "Ivy", "Horz"
        };

        //---------------------------------------------------------------------

        private static readonly string[] arrayStringFindFullConferenceNames = new string[]
        {
            "America East Conference", "American Athletic Conference", "Atlantic 10 Conference", "Atlantic Coast Conference", "Atlantic Sun Conference",
            "Big 12 Conference", "Big East Conference", "Big Sky Conference", "Big South Conference", "Big Ten Conference",
            "Big West Conference", "Colonial Athletic Association", "Conference USA", "Horizon League", "Ivy League",
            "Metro Atlantic Athletic Conference", "Mid-American Conference", "Mid-Eastern Athletic Conference", "Missouri Valley Conference", "Mountain West Conference",
            "Northeast Conference", "Ohio Valley Conference", "Pac-12 Conference", "Patriot League", "Southeastern Conference",
            "Southern Conference", "Southland Conference", "Southwestern Athletic Conference", "Summit League", "Sun Belt Conference",
            "West Coast Conference", "Western Athletic Conference"
        };

        //---------------------------------------------------------------------

        private static readonly string[] arrayStringFindAbrvConferenceNames = new string[]
        {
            "AE", "Amer", "A10", "ACC", "ASun", "B12", "BE", "BSky", "BSth", "B10",
            "BW", "CAA", "CUSA", "Horz", "Ivy", "MAAC", "MAC", "MEAC", "MVC", "MWC",
            "NEC", "OVC", "P12", "Pat", "SEC", "SC", "Slnd", "SWAC", "Sum", "SB",
            "WCC", "WAC"
        };

        //---------------------------------------------------------------------

        private static readonly int[][] arraysIntSeedStartRound = new int[][]
        {
            new int[] { 0, 0, 0, 0, 0, 0, 0, 0},
            new int[] { 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0},
            new int[] { 2, 2, 2, 2, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0},
            new int[] { 2, 2, 2, 2, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0},
            new int[] { 0, 0, 0, 0, 0, 0, 0, 0},
            new int[] { 1, 1, 1, 1, 1, 1, 0, 0, 0, 0},
            new int[] { 1, 1, 1, 1, 1, 1, 0, 0, 0, 0},
            new int[] { 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0},
            new int[] { 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0},
            new int[] { 2, 2, 2, 2, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0},
            new int[] { 0, 0, 0, 0, 0, 0, 0, 0},
            new int[] { 1, 1, 1, 1, 1, 1, 0, 0, 0, 0},
            new int[] { 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0},
            new int[] { 2, 2, 1, 0, 0, 0, 0, 0, 0},
            new int[] { 0, 0, 0, 0},
            new int[] { 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0},
            new int[] { 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0},
            new int[] { 1, 1, 1, 1, 1, 1, 0, 0, 0, 0},
            new int[] { 1, 1, 1, 1, 1, 1, 0, 0, 0, 0},
            new int[] { 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0},
            new int[] { 0, 0, 0, 0, 0, 0, 0, 0},
            new int[] { 2, 2, 1, 1, 0, 0, 0, 0},
            new int[] { 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0},
            new int[] { 1, 1, 1, 1, 1, 1, 0, 0, 0, 0},
            new int[] { 2, 2, 2, 2, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0},
            new int[] { 1, 1, 1, 1, 1, 1, 0, 0, 0, 0},
            new int[] { 2, 2, 1, 1, 0, 0, 0, 0},
            new int[] { 0, 0, 0, 0, 0, 0, 0, 0},
            new int[] { 0, 0, 0, 0, 0, 0, 0, 0},
            new int[] { 3, 3, 2, 2, 1, 1, 0, 0, 0, 0},
            new int[] { 3, 3, 2, 2, 1, 1, 0, 0, 0, 0},
            new int[] { 0, 0, 0, 0, 0, 0, 0, 0}
        };

        private static readonly int[][] arraysIntSeedStartRow = new int[][]
        {
            new int[] { 0, 4, 6, 2, 3, 7, 5, 1},
            new int[] { 0, 7, 5, 2, 2, 4, 6, 0, 1, 7, 5, 3},
            new int[] { 0, 6, 4, 2, 2, 4, 6, 0, 1, 7, 2, 0, 1, 3},
            new int[] { 0, 6, 4, 2, 2, 4, 6, 0, 1, 7, 2, 0, 1, 3},
            new int[] { 0, 4, 6, 2, 3, 7, 5, 1},
            new int[] { 0, 6, 4, 2, 3, 5, 2, 0, 1, 3},
            new int[] { 0, 6, 4, 2, 3, 5, 2, 0, 1, 3},
            new int[] { 0, 6, 4, 2, 3, 2, 4, 0, 1, 5, 3},
            new int[] { 0, 6, 4, 2, 3, 2, 4, 0, 1, 5, 3},
            new int[] { 0, 6, 4, 2, 2, 4, 6, 0, 1, 7, 2, 0, 1, 3},
            new int[] { 0, 4, 6, 2, 3, 7, 5, 1},
            new int[] { 0, 6, 4, 2, 3, 5, 2, 0, 1, 3},
            new int[] { 0, 7, 5, 2, 2, 4, 6, 0, 1, 7, 5, 3},
            new int[] { 0, 2, 2, 0, 2, 4, 5, 3, 1},
            new int[] { 0, 2, 3, 1},
            new int[] { 0, 6, 4, 2, 3, 2, 4, 0, 1, 5, 3},
            new int[] { 0, 7, 5, 2, 2, 4, 6, 0, 1, 7, 5, 3},
            new int[] { 0, 6, 4, 2, 3, 5, 2, 0, 1, 3},
            new int[] { 0, 6, 4, 2, 3, 5, 2, 0, 1, 3},
            new int[] { 0, 6, 4, 2, 3, 2, 4, 0, 1, 5, 3},
            new int[] { 0, 4, 6, 2, 3, 7, 5, 1},
            new int[] { 0, 2, 2, 0, 0, 2, 3, 1},
            new int[] { 0, 7, 5, 2, 2, 4, 6, 0, 1, 7, 5, 3},
            new int[] { 0, 6, 4, 2, 3, 5, 2, 0, 1, 3},
            new int[] { 0, 6, 4, 2, 2, 4, 6, 0, 1, 7, 2, 0, 1, 3},
            new int[] { 0, 6, 4, 2, 3, 5, 2, 0, 1, 3},
            new int[] { 0, 2, 2, 0, 0, 2, 3, 1},
            new int[] { 0, 4, 6, 2, 3, 7, 5, 1},
            new int[] { 0, 4, 6, 2, 3, 7, 5, 1},
            new int[] { 0, 2, 2, 0, 0, 2, 2, 0, 1, 3},
            new int[] { 0, 2, 2, 0, 0, 2, 2, 0, 1, 3},
            new int[] { 0, 4, 6, 2, 3, 7, 5, 1}
        };

        private static readonly int[][] arrayConferenceTournamentCode = new int[][]
        {
            new int[] { 4, 2, 1},
            new int[] { 4, 4, 2, 1},
            new int[] { 2, 4, 4, 2, 1},
            new int[] { 2, 4, 4, 2, 1},
            new int[] { 4, 2, 1},
            new int[] { 2, 4, 2, 1},
            new int[] { 2, 4, 2, 1},
            new int[] { 3, 4, 2, 1},
            new int[] { 3, 4, 2, 1},
            new int[] { 2, 4, 4, 2, 1},
            new int[] { 4, 2, 1},
            new int[] { 2, 4, 2, 1},
            new int[] { 4, 4, 2, 1},
            new int[] { 3, 2, 2, 1},
            new int[] { 2, 1},
            new int[] { 3, 4, 2, 1},
            new int[] { 4, 4, 2, 1},
            new int[] { 2, 4, 2, 1},
            new int[] { 2, 4, 2, 1},
            new int[] { 3, 4, 2, 1},
            new int[] { 4, 2, 1},
            new int[] { 2, 2, 2, 1},
            new int[] { 4, 4, 2, 1},
            new int[] { 2, 4, 2, 1},
            new int[] { 2, 4, 4, 2, 1},
            new int[] { 2, 4, 2, 1},
            new int[] { 2, 2, 2, 1},
            new int[] { 4, 2, 1},
            new int[] { 4, 2, 1},
            new int[] { 2, 2, 2, 2, 1},
            new int[] { 2, 2, 2, 2, 1},
            new int[] { 4, 2, 1}
        };

        //---------------------------------------------------------------------

        private static readonly DateTime programInitialStartDate = new DateTime(2019, 9, 1, 0, 0, 0, 0);

        private static readonly DateTime seasonStartDate = new DateTime(2019, 10, 1, 0, 0, 0, 0);
        private static readonly DateTime conferenceTournamentStartDate = new DateTime(2020, 3, 3, 0, 0, 0, 0);
        private static readonly DateTime championshipTournamentStartDate = new DateTime(2020, 3, 17, 0, 0, 0, 0);
        private static readonly DateTime postSeasonStartDate = new DateTime(2020, 4, 7, 0, 0, 0, 0);

        private static readonly DateTime[] conferenceTournamentStartDates = new DateTime[]
        {
            new DateTime(2020, 3, 7, 0, 0, 0, 0),
            new DateTime(2020, 3, 12, 0, 0, 0, 0),
            new DateTime(2020, 3, 11, 0, 0, 0, 0),
            new DateTime(2020, 3, 10, 0, 0, 0, 0),
            new DateTime(2020, 3, 3, 0, 0, 0, 0),
            new DateTime(2020, 3, 11, 0, 0, 0, 0),
            new DateTime(2020, 3, 11, 0, 0, 0, 0),
            new DateTime(2020, 3, 11, 0, 0, 0, 0),
            new DateTime(2020, 3, 3, 0, 0, 0, 0),
            new DateTime(2020, 3, 11, 0, 0, 0, 0),
            new DateTime(2020, 3, 12, 0, 0, 0, 0),
            new DateTime(2020, 3, 7, 0, 0, 0, 0),
            new DateTime(2020, 3, 11, 0, 0, 0, 0),
            new DateTime(2020, 3, 3, 0, 0, 0, 0),
            new DateTime(2020, 3, 14, 0, 0, 0, 0),
            new DateTime(2020, 3, 10, 0, 0, 0, 0),
            new DateTime(2020, 3, 9, 0, 0, 0, 0),
            new DateTime(2020, 3, 10, 0, 0, 0, 0),
            new DateTime(2020, 3, 6, 0, 0, 0, 0),
            new DateTime(2020, 3, 4, 0, 0, 0, 0),
            new DateTime(2020, 3, 4, 0, 0, 0, 0),
            new DateTime(2020, 3, 4, 0, 0, 0, 0),
            new DateTime(2020, 3, 11, 0, 0, 0, 0),
            new DateTime(2020, 3, 3, 0, 0, 0, 0),
            new DateTime(2020, 3, 11, 0, 0, 0, 0),
            new DateTime(2020, 3, 6, 0, 0, 0, 0),
            new DateTime(2020, 3, 11, 0, 0, 0, 0),
            new DateTime(2020, 3, 10, 0, 0, 0, 0),
            new DateTime(2020, 3, 7, 0, 0, 0, 0),
            new DateTime(2020, 3, 7, 0, 0, 0, 0),
            new DateTime(2020, 3, 5, 0, 0, 0, 0),
            new DateTime(2020, 3, 12, 0, 0, 0, 0)
        };

        //DATE OF CONFERENCE CHAMPIONSHIP GAME
        private static readonly DateTime[] conferenceTournamentEndDates = new DateTime[]
        {
            new DateTime(2020, 3, 14, 0, 0, 0, 0),
            new DateTime(2020, 3, 15, 0, 0, 0, 0),
            new DateTime(2020, 3, 15, 0, 0, 0, 0),
            new DateTime(2020, 3, 14, 0, 0, 0, 0),
            new DateTime(2020, 3, 8, 0, 0, 0, 0),
            new DateTime(2020, 3, 14, 0, 0, 0, 0),
            new DateTime(2020, 3, 14, 0, 0, 0, 0),
            new DateTime(2020, 3, 14, 0, 0, 0, 0),
            new DateTime(2020, 3, 8, 0, 0, 0, 0),
            new DateTime(2020, 3, 15, 0, 0, 0, 0),
            new DateTime(2020, 3, 14, 0, 0, 0, 0),
            new DateTime(2020, 3, 10, 0, 0, 0, 0),
            new DateTime(2020, 3, 14, 0, 0, 0, 0),
            new DateTime(2020, 3, 10, 0, 0, 0, 0),
            new DateTime(2020, 3, 15, 0, 0, 0, 0),
            new DateTime(2020, 3, 14, 0, 0, 0, 0),
            new DateTime(2020, 3, 14, 0, 0, 0, 0),
            new DateTime(2020, 3, 14, 0, 0, 0, 0),
            new DateTime(2020, 3, 8, 0, 0, 0, 0),
            new DateTime(2020, 3, 7, 0, 0, 0, 0),
            new DateTime(2020, 3, 10, 0, 0, 0, 0),
            new DateTime(2020, 3, 7, 0, 0, 0, 0),
            new DateTime(2020, 3, 14, 0, 0, 0, 0),
            new DateTime(2020, 3, 11, 0, 0, 0, 0),
            new DateTime(2020, 3, 15, 0, 0, 0, 0),
            new DateTime(2020, 3, 9, 0, 0, 0, 0),
            new DateTime(2020, 3, 14, 0, 0, 0, 0),
            new DateTime(2020, 3, 14, 0, 0, 0, 0),
            new DateTime(2020, 3, 10, 0, 0, 0, 0),
            new DateTime(2020, 3, 15, 0, 0, 0, 0),
            new DateTime(2020, 3, 10, 0, 0, 0, 0),
            new DateTime(2020, 3, 14, 0, 0, 0, 0)
        };

        private static readonly DateTime[] championshipTournamentDates = new DateTime[]
        {
            new DateTime(2020, 3, 17, 0, 0, 0, 0),
            new DateTime(2020, 3, 19, 0, 0, 0, 0),
            new DateTime(2020, 3, 21, 0, 0, 0, 0),
            new DateTime(2020, 3, 26, 0, 0, 0, 0),
            new DateTime(2020, 3, 28, 0, 0, 0, 0),
            new DateTime(2020, 4, 4, 0, 0, 0, 0),
            new DateTime(2020, 4, 6, 0, 0, 0, 0)
        };

        //---------------------------------------------------------------------

        private static readonly int[] arrayBellCurveValues = new int[]
        {
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
            1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2,
            2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3,
            3, 4, 4, 4, 4, 4, 4, 5, 5, 5, 5, 5, 5, 6, 6, 6, 6, 6, 7, 7,
            7, 7, 8, 8, 8, 8, 9, 9, 9, 10, 10, 10, 11, 11, 11, 12, 12, 13, 13, 13,
            14, 14, 15, 15, 16, 16, 17, 18, 18, 19, 19, 20, 21, 21, 22, 23, 23, 24, 25, 26,
            26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 43, 44, 45, 47,
            48, 49, 51, 52, 54, 55, 57, 59, 60, 62, 64, 66, 68, 69, 71, 73, 75, 78, 80, 82,
            84, 87, 89, 91, 94, 96, 99, 102, 104, 107,
            110, 113, 116, 119, 122, 125, 129, 132, 136, 139,
            143, 146, 150, 154, 158, 162, 166, 170, 174, 179,
            183, 188, 192, 197, 202, 207, 212, 217, 222, 228,
            233, 239, 244, 250, 256, 262, 268, 274, 281, 287,
            294, 301, 307, 314, 322, 329, 336, 344, 351, 359,
            367, 375, 384, 392, 401, 409, 418, 427, 436, 446,
            455, 465, 475, 485, 495, 505, 516, 526, 537, 548,
            559, 571, 582, 594, 606, 618, 630, 643, 655, 668,
            681, 694, 708, 721, 735, 749, 764, 778, 793, 808,
            823, 838, 853, 869, 885, 901, 918, 934, 951, 968,
            985, 1003, 1020, 1038, 1056, 1075, 1093, 1112, 1131, 1151,
            1170, 1190, 1210, 1230, 1251, 1271, 1292, 1314, 1335, 1357,
            1379, 1401, 1423, 1446, 1469, 1492, 1515, 1539, 1562, 1587,
            1611, 1635, 1660, 1685, 1711, 1736, 1762, 1788, 1814, 1841,
            1867, 1894, 1922, 1949, 1977, 2005, 2033, 2061, 2090, 2119,
            2148, 2177, 2206, 2236, 2266, 2296, 2327, 2358, 2389, 2420,
            2451, 2483, 2514, 2546, 2578, 2611, 2643, 2676, 2709, 2743,
            2776, 2810, 2843, 2877, 2912, 2946, 2981, 3015, 3050, 3085,
            3121, 3156, 3192, 3228, 3264, 3300, 3336, 3372, 3409, 3446,
            3483, 3520, 3557, 3594, 3632, 3669, 3707, 3745, 3783, 3821,
            3859, 3897, 3936, 3974, 4013, 4052, 4090, 4129, 4168, 4207,
            4247, 4286, 4325, 4364, 4404, 4443, 4483, 4522, 4562, 4602,
            4641, 4681, 4721, 4761, 4801, 4840, 4880, 4920, 4960, 5000,
            5000, 5040, 5080, 5120, 5160, 5199, 5239, 5279, 5319, 5359,
            5398, 5438, 5478, 5517, 5557, 5596, 5636, 5675, 5714, 5753,
            5793, 5832, 5871, 5910, 5948, 5987, 6026, 6064, 6103, 6141,
            6179, 6217, 6255, 6293, 6331, 6368, 6406, 6443, 6480, 6517,
            6554, 6591, 6628, 6664, 6700, 6736, 6772, 6808, 6844, 6879,
            6915, 6950, 6985, 7019, 7054, 7088, 7123, 7157, 7190, 7224,
            7257, 7291, 7324, 7357, 7389, 7422, 7454, 7486, 7517, 7549,
            7580, 7611, 7642, 7673, 7704, 7734, 7764, 7794, 7823, 7852,
            7881, 7910, 7939, 7967, 7995, 8023, 8051, 8078, 8106, 8133,
            8159, 8186, 8212, 8238, 8264, 8289, 8315, 8340, 8365, 8389,
            8413, 8438, 8461, 8485, 8508, 8531, 8554, 8577, 8599, 8621,
            8643, 8665, 8686, 8708, 8729, 8749, 8770, 8790, 8810, 8830,
            8849, 8869, 8888, 8907, 8925, 8944, 8962, 8980, 8997, 9015,
            9032, 9049, 9066, 9082, 9099, 9115, 9131, 9147, 9162, 9177,
            9192, 9207, 9222, 9236, 9251, 9265, 9279, 9292, 9306, 9319,
            9332, 9345, 9357, 9370, 9382, 9394, 9406, 9418, 9429, 9441,
            9452, 9463, 9474, 9484, 9495, 9505, 9515, 9525, 9535, 9545,
            9554, 9564, 9573, 9582, 9591, 9599, 9608, 9616, 9625, 9633,
            9641, 9649, 9656, 9664, 9671, 9678, 9686, 9693, 9699, 9706,
            9713, 9719, 9726, 9732, 9738, 9744, 9750, 9756, 9761, 9767,
            9772, 9778, 9783, 9788, 9793, 9798, 9803, 9808, 9812, 9817,
            9821, 9826, 9830, 9834, 9838, 9842, 9846, 9850, 9854, 9857,
            9861, 9864, 9868, 9871, 9875, 9878, 9881, 9884, 9887, 9890,
            9893, 9896, 9898, 9901, 9904, 9906, 9909, 9911, 9913, 9916,
            9918, 9920, 9922, 9925, 9927, 9929, 9931, 9932, 9934, 9936,
            9938, 9940, 9941, 9943, 9945, 9946, 9948, 9949, 9951, 9952,
            9953, 9955, 9956, 9957, 9959, 9960, 9961, 9962, 9963, 9964,
            9965, 9966, 9967, 9968, 9969, 9970, 9971, 9972, 9973, 9974,
            9974, 9975, 9976, 9977, 9977, 9978, 9979, 9979, 9980, 9981,
            9981, 9982, 9982, 9983, 9984, 9984, 9985, 9985, 9986, 9986,
            9987, 9987, 9987, 9988, 9988, 9989, 9989, 9989, 9990, 9990,
            9990, 9991, 9991, 9991, 9992, 9992, 9992, 9992, 9993, 9993,
            9993, 9993, 9994, 9994, 9994, 9994, 9994, 9995, 9995, 9995,
            9995, 9995, 9995, 9996, 9996, 9996, 9996, 9996, 9996, 9997,
            9997, 9997, 9997, 9997, 9997, 9997, 9997, 9997, 9997, 9998,
            9998, 9998, 9998, 9998, 9998, 9998, 9998, 9998, 9998, 9998,
            9998, 9998, 9999, 9999, 9999, 9999, 9999, 9999, 9999, 9999,
            9999, 9999, 9999, 9999, 9999, 9999, 9999, 9999, 9999, 9999,
            9999, 9999, 9999, 9999, 9999, 9999, 9999, 9999, 9999, 9999,
            10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000
        };

        //---------------------------------------------------------------------

        public Resources()
        {

        } //END

        //---------------------------------------------------------------------
        //MENUS AND STATES-----------------------------------------------------
        //---------------------------------------------------------------------

        //STRING---------------------------------------------------------------

        public string getMenuText(int index)
        {
            return arrayStringMenus[index];
        } //END

        public string getStateText(int index)
        {
            return arrayStringStates[index];
        } //END

        //---------------------------------------------------------------------
        //SCHEDULE-------------------------------------------------------------
        //---------------------------------------------------------------------

        //STRING---------------------------------------------------------------

        public string getGameResultTypeText(int index)
        {
            return arrayStringGameResultType[index];
        } //END

        public string getGameTypeText(int index)
        {
            return arrayStringGameType[index];
        } //END

        public string getScheduleTypeText(int index)
        {
            return arrayStringScheduleType[index];
        } //END

        public string getSimulationTypeText()
        {
            return simulationType;
        } //END

        //---------------------------------------------------------------------
        //CHAMPIONSHIP TOURNAMENT REGIONS--------------------------------------
        //---------------------------------------------------------------------

        //STRING---------------------------------------------------------------

        public string getChampTounRegionTypeText(int index)
        {
            return arrayStringChampTounRegionType[index];
        } //END

        //---------------------------------------------------------------------
        //TEAMS----------------------------------------------------------------
        //---------------------------------------------------------------------

        //TEAMS LENGTH---------------------------------------------------------

        public int getLengthOfTeamNames()
        {
            return arrayStringTeamNames.Length;
        } //END

        //TEAM NAME------------------------------------------------------------

        //TEAM INDEX -> TEAM NAME
        public string getTeamName(int teamIndex)
        {
            return arrayStringTeamNames[teamIndex];
        } //END

        //TEAM ID -> TEAM NAME
        public string getTeamName(string id)
        {
            //RETURNS TEAM NAME OF CORESPONDING TEAM ID

            int index = Array.IndexOf(arrayStringESPNTeamIDs, id);

            if (index == -1)
            {
                return "DIV II SCHOOL";
            }
            else
            {
                return arrayStringTeamNames[index];
            } //END

        } //END

        //TEAM ID--------------------------------------------------------------

        //TEAM INDEX -> TEAM ID
        public string getESPNTeamID(int teamIndex)
        {
            return arrayStringESPNTeamIDs[teamIndex];
        } //END

        //TEAM INDEX-----------------------------------------------------------

        //TEAM NAME-> TEAM INDEX
        public int getTeamIndexFromTeamName(string teamName)
        {
            //RETURNS TEAM NAME OF CORESPONDING TEAM ID

            int index = Array.IndexOf(arrayStringTeamNames, teamName);

            if (index == -1)
            {
                if (0 == string.Compare(teamName, "DIV II SCHOOL"))
                {
                    return -2; 
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("ERROR: NO INDEX FOUND FOR " + teamName + " TEAM'S INDEX");
                    return -3;
                }
            }
            else
            {
                return index;
            } //END

        } //END

        //TEAM ID -> TEAM INDEX
        public int getTeamIndexFromTeamID(string teamID)
        {
            //RETURN TEAM INDEX
            return Array.IndexOf(arrayStringESPNTeamIDs, teamID);
        } //END

        //ARRAY TEAM INDEXES---------------------------------------------------

        //CONFERENCE NAME -> ARRAY TEAM INDEXES
        public int[] getConferenceTeamIndexes(string conferenceName)
        {
            //RETURN CONFERENCE OF TEAM INDEXES
            return arrayTeamIndexesByConference[Array.IndexOf(arrayStringFindFullConferenceNames, conferenceName)];
        } //END

        //CONFERENCE INDEX -> ARRAY TEAM INDEXES
        public int[] getConferenceTeamIndexes(int conferenceIndex)
        {
            //RETURN CONFERENCE OF TEAM INDEXES
            return arrayTeamIndexesByConference[conferenceIndex];
        } //END

        //---------------------------------------------------------------------
        //CONFERENCES----------------------------------------------------------
        //---------------------------------------------------------------------

        //LENGTH---------------------------------------------------------------

        public int getLengthOfConferenceNames()
        {
            return arrayStringFindFullConferenceNames.Length;
        } //END

        //SAME CONFERENCE------------------------------------------------------

        public Boolean sameConference(int teamA, int teamB, int conferenceIndex)
        {
            if (Array.IndexOf(arrayTeamIndexesByConference[conferenceIndex], teamA) >= 0 &&
                Array.IndexOf(arrayTeamIndexesByConference[conferenceIndex], teamB) >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }//END IF
        } //END

        //CONFERENCE ABBREVIATION----------------------------------------------

        //TEAM INDEX -> CONFERENCE ABBREVIATION
        public string getConferenceAbrv(int teamIndex)
        {
            return arrayStringConferenceAbrvByTeam[teamIndex];
        } //END

        //CONFERENCE NAME------------------------------------------------------

        //CONFERENCE INDEX -> CONFERENCE NAME
        public string getConferenceName(int conferenceIndex)
        {
            return arrayStringFindFullConferenceNames[conferenceIndex];
        } //END

        //TEAM INDEX -> CONFERENCE NAME
        public string getTeamsConferenceName(int teamIndex)
        {
            //RETURNS THE CONFERENCE NAME FOR ANY TEAM INDEX

            int conferenceIndex = -1;

            if (teamIndex >= 0)
            {
                conferenceIndex = Array.IndexOf(arrayStringFindAbrvConferenceNames, arrayStringConferenceAbrvByTeam[teamIndex]);

                if (conferenceIndex >= 0)
                {
                    return arrayStringFindFullConferenceNames[conferenceIndex];
                }
                else
                {
                    return "";
                }//END IF
            }
            else
            {
                return "";
            }//END IF

        } //END

        //TEAM NAME -> CONFERENCE NAME
        public string getTeamsConferenceName(string teamName)
        {
            if (string.Compare(teamName, "DIV II SCHOOL") == 0)
            {
                System.Windows.Forms.MessageBox.Show("ERROR: DIV II SCHOOL SENT TO GET CONFERENCE NAME");
                //RETURN SOMETHING
                return "DIV II SCHOOL";
            }
            else
            {
                //RETURNS THE CONFERENCE NAME FOR ANY TEAM INDEX
                //return arrayStringConferenceNames[getIndexOfKenPomConferenceAbrv(getConferenceByTeam(index))];
                return arrayStringFindFullConferenceNames[Array.IndexOf(arrayStringFindAbrvConferenceNames, arrayStringConferenceAbrvByTeam[Array.IndexOf(arrayStringTeamNames, teamName)])];
            }
        } //END

        //CONFERENCE INDEX-----------------------------------------------------

        //CONFERENCE NAME -> CONFERENCE INDEX
        public int getConferenceIndex(string conferenceName)
        {
            //RETURNS THE CONFERENCE INDEX
            return Array.IndexOf(arrayStringFindFullConferenceNames, conferenceName);
        } //END

        //TEAM INDEX -> CONFERENCE INDEX
        public int getConferenceIndex(int teamIndex)
        {
            //RETURNS THE CONFERENCE INDEX
            return Array.IndexOf(arrayStringFindAbrvConferenceNames, arrayStringConferenceAbrvByTeam[teamIndex]);
        } //END

        //---------------------------------------------------------------------
        //CONFERENCE TOURNAMENT------------------------------------------------
        //---------------------------------------------------------------------

        public int[] getSeedStartRound(int index)
        {
            return arraysIntSeedStartRound[index];
        } //END

        public int[] getSeedStartRow(int index)
        {
            return arraysIntSeedStartRow[index];
        } //END

        public int[] getConferenceTournamentCode(int index)
        {
            return arrayConferenceTournamentCode[index];
        } //END

        public int getConfTournRoundNumberOfGames(int conference, int round)
        {
            return arrayConferenceTournamentCode[conference][round] * 2;
        } //END

        //---------------------------------------------------------------------
        //DATES----------------------------------------------------------------
        //---------------------------------------------------------------------

        //MONTHS---------------------------------------------------------------

        public string getMonth(int index)
        {
            return arrayStringMonths[index];
        } //END

        public int getIndexOfMonth(string month)
        {
            return Array.IndexOf(arrayStringMonths, month) + 1;
        } //END

        //INITIAL PROGRAM DEFAULT START DATE-----------------------------------

        public DateTime getProgramInitalStartDate()
        {
            return programInitialStartDate;
        } //END

        //SEASON DATES---------------------------------------------------------

        public DateTime getSeasonStartDate()
        {
            return seasonStartDate;
        } //END

        public DateTime getConferenceTournamentStartDate()
        {
            return conferenceTournamentStartDate;
        } //END

        public DateTime getChampionshipTournamentStartDate()
        {
            return championshipTournamentStartDate;
        } //END

        public DateTime getPostSeasonStartDate()
        {
            return postSeasonStartDate;
        } //END

        //CONFERENCE DATES-----------------------------------------------------

        public DateTime getConferenceTournamentStartDate(int conferenceIndex)
        {
            //GIVEN A FULL CONFERENCE NAME IT RETURNS THE START DATE FOR CONFERENCE TOURNAMENT
            return conferenceTournamentStartDates[conferenceIndex];
        } //END

        public DateTime getConferenceTournamentStartDate(string teamID)
        {
            //GIVEN A FULL CONFERENCE NAME IT RETURNS THE START DATE FOR CONFERENCE TOURNAMENT
            return conferenceTournamentStartDates[Array.IndexOf(arrayStringFindAbrvConferenceNames,
                arrayStringConferenceAbrvByTeam[Array.IndexOf(arrayStringESPNTeamIDs, teamID)])];
        } //END

        public DateTime getConferenceTournamentEndDate(int conferenceIndex)
        {
            //GIVEN A FULL CONFERENCE NAME IT RETURNS THE END DATE FOR CONFERENCE TOURNAMENT
            return conferenceTournamentEndDates[conferenceIndex];
        } //END

        public DateTime getConferenceTournamentEndDate(string teamID)
        {
            //GIVEN A FULL CONFERENCE NAME IT RETURNS THE END DATE FOR CONFERENCE TOURNAMENT
            return conferenceTournamentEndDates[Array.IndexOf(arrayStringFindAbrvConferenceNames,
                arrayStringConferenceAbrvByTeam[Array.IndexOf(arrayStringESPNTeamIDs, teamID)])];
        } //END

        //CHAMPIONSHIP TOURNAMENT DATES----------------------------------------

        public DateTime getChampionshipTournamentDates(int roundIndex)
        {
            //GIVEN A FULL CONFERENCE NAME IT RETURNS THE START DATE FOR CONFERENCE TOURNAMENT
            if (roundIndex<championshipTournamentDates.Length)
            {
                return championshipTournamentDates[roundIndex]; 
            }
            else
            {
                DateTime irrelevantDate = new DateTime(2025, 8, 6, 0, 0, 0, 0);

                //JUST IN CASE BOOLEAN FUNCTION CHECKS 2ND ARGUMENT
                return irrelevantDate;
            }//END IF
        } //END

        //---------------------------------------------------------------------

        public int getTournamentRound(int conferenceIndex, DateTime currentDate)
        {
            if (DateTime.Compare(currentDate, conferenceTournamentStartDates[conferenceIndex]) >= 0 &&
                DateTime.Compare(currentDate, conferenceTournamentEndDates[conferenceIndex]) <= 0)
            {
                //CALCULATE LOOP VARIABLE
                int totalDays = (int)Math.Round((
                        conferenceTournamentEndDates[conferenceIndex] -
                        conferenceTournamentStartDates[conferenceIndex]
                        ).TotalDays) + 1;

                //INCREMENT DATE
                DateTime incrementDate = new DateTime(
                    conferenceTournamentStartDates[conferenceIndex].Year,
                    conferenceTournamentStartDates[conferenceIndex].Month,
                    conferenceTournamentStartDates[conferenceIndex].Day, 
                    0, 0, 0, 0);

                for (int index = 0; index < totalDays; index++)
                {
                    if (DateTime.Compare(incrementDate, currentDate) == 0)
                    {
                        return index;
                    }//END IF
                    incrementDate.AddDays(1.0);
                }//END FOR

            }//END IF

            return -1;
        }//END

        //---------------------------------------------------------------------
        //BELL CURVE-----------------------------------------------------------
        //---------------------------------------------------------------------

        //VALUE----------------------------------------------------------------

        public int getBellCurveValue(int index)
        {
            return arrayBellCurveValues[index];
        } //END

        //LENGTH---------------------------------------------------------------

        public int getLengthOfBellCurve()
        {
            return arrayBellCurveValues.Length;
        } //END

    } //END
} //END
