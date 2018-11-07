using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoTutorials.Models.Sep19
{
    public class SoccerTeam : Team
    {
        public int draw { get; set; }
        public int goalsFor { get; set; }
        public int goalsAgainst { get; set; }
        public int differential { get; set; }
        public int points { get; set; }

        // Make a default constructor and overloaded constructor too!
        public SoccerTeam()
        {

        }

        // This loads up parents attributes with parameters
        public SoccerTeam(string sName, int iPoints)
        {
            base.teamName = sName;
            base.teamPoints = iPoints;
        }

    }
}