using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoTutorials.Models.Sep19;

namespace VideoTutorials.Controllers.Sep19
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            List<SoccerTeam> listSoccerTeams = new List<SoccerTeam>();
            List<SoccerTeam> listSorted = new List<SoccerTeam>();
            int iTeamRank = 0;

            //Load Data
            listSoccerTeams.Add(new SoccerTeam("RSL", 35));
            listSoccerTeams.Add(new SoccerTeam("Colorado", 24));
            listSoccerTeams.Add(new SoccerTeam("FC Dallas", 42));
            listSoccerTeams.Add(new SoccerTeam("San Jose", 16));

            //Sort and reassign to listSorted
            listSorted = listSoccerTeams.OrderByDescending(oTeam => oTeam.teamPoints).ToList();
            
            //loop using Lambda to output team names, points, and rank into ViewBag.TeamNamesSorted
            foreach (SoccerTeam oTeam in listSorted)
            {
                ViewBag.TeamNamesSorted += "#" + ++iTeamRank + ". " + oTeam.teamName + " - " + oTeam.teamPoints + "<br />";
            }


            return View();
        }
    }
}