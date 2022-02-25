using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models.Roster;
using System.Collections.Generic;

namespace WebApplication3.Controllers
{
    public class RosterController : Controller
    {

        static IList<Roster> rosters = new List<Roster>
        {
            new Roster() { Id = 1, Name = "Jhonas Enroth", NR = 1, Pos = "G", GAA = 92.7, SVS = 1.82},
            new Roster() { Id = 2, Name = "Jonas Arntzen", NR = 31, Pos = "G", GAA = 89.2, SVS = 2.99},

            new Roster() { Id = 3, Name = "Gustav Backström", NR = 5, Pos = "D", GP = 40, Goals = 4, Ass = 6, P = 10},
            new Roster() { Id = 4, Name = "Nick Ebert", NR = 74, Pos = "D", GP = 39, Goals = 8, Ass = 16, P = 24 },
            new Roster() { Id = 5, Name = "Simon Forsmark", NR = 27, Pos = "D", GP = 30, Goals = 0, Ass = 3, P = 3},
            new Roster() { Id = 6, Name = "Marcus Hardegård", NR = 7, Pos = "D", GP = 38, Goals = 0, Ass = 8, P = 8},
            new Roster() { Id = 7, Name = "Niklas Nilsson", NR = 4, Pos = "D", GP = 5, Goals = 0, Ass = 0, P = 0},
            new Roster() { Id = 8, Name = "Kristian Näkyvä", NR = 51, Pos = "D", GP = 35, Goals = 11, Ass = 17, P = 28},
            new Roster() { Id = 9, Name = "Elias Pettersson", NR = 25, Pos = "D", GP = 15, Goals = 0, Ass = 1, P = 1},
            new Roster() { Id = 10, Name = "Rasmus Rissanen", NR = 2, Pos = "D", GP = 23, Goals = 2, Ass = 4, P = 6},
            new Roster() { Id = 11, Name = "Libor Sulak", NR = 00, Pos = "D", GP = 0, Goals = 0, Ass = 0, P = 0},
            new Roster() { Id = 12, Name = "Petr Zámorský", NR = 23, Pos = "D", GP = 37, Goals = 3, Ass = 7, P = 10},
            new Roster() { Id = 13, Name = "Kristaps Zile", NR = 00, Pos = "D", GP = 0, Goals = 0, Ass = 0, P = 0},

            new Roster() { Id = 14, Name = "Rodrigo Abols", NR = 18, Pos = "C", GP = 35, Goals = 10, Ass = 15, P = 25},
            new Roster() { Id = 15, Name = "Daniel Audette", NR = 00, Pos = "C", GP = 0, Goals = 0, Ass = 0, P = 0},
            new Roster() { Id = 16, Name = "Leo Carlsson", NR = 10, Pos = "C", GP = 29, Goals = 2, Ass = 5, P = 7},
            new Roster() { Id = 17, Name = "Oliver Eklind", NR = 73, Pos = "C/LW", GP = 40, Goals = 7, Ass = 8, P = 15},
            new Roster() { Id = 18, Name = "Elias Ekström", NR = 40, Pos = "LW/RW", GP = 40, Goals = 4, Ass = 9, P = 13},
            new Roster() { Id = 19, Name = "Nick Halloran", NR = 9, Pos = "RW", GP = 8, Goals = 3, Ass = 1, P = 4},
            new Roster() { Id = 20, Name = "Gustav Karlsson", NR = 34, Pos = "C", GP = 1, Goals = 0, Ass = 0, P = 0},
            new Roster() { Id = 20, Name = "Robin  Kovács", NR = 96, Pos = "LW/RW", GP = 40, Goals = 17, Ass = 14, P = 31},
            new Roster() { Id = 21, Name = "Jani Lajunen", NR = 96, Pos = "C", GP = 38, Goals = 6, Ass = 12, P = 18},
            new Roster() { Id = 22, Name = "Emil Larsson", NR = 24, Pos = "LW/RW", GP = 40, Goals = 9, Ass = 9, P = 18},
            new Roster() { Id = 23, Name = "Robert Leino", NR = 36, Pos = "C", GP = 38, Goals = 1, Ass = 10, P = 11},
            new Roster() { Id = 24, Name = "Christopher Mastomäki", NR = 62, Pos = "C", GP = 40, Goals = 6, Ass = 10, P = 16},
            new Roster() { Id = 25, Name = "Joel Mustonen", NR = 33, Pos = "C/LW", GP = 36, Goals = 4, Ass = 4, P = 8},
            new Roster() { Id = 26, Name = "Milton Oscarson", NR = 39, Pos = "C/RW", GP = 22, Goals = 0, Ass = 1, P = 1},
            new Roster() { Id = 27, Name = "Juuso Puustinen", NR = 29, Pos = "RW/LW", GP = 14, Goals = 3, Ass = 1, P = 4},
            new Roster() { Id = 28, Name = "Miikka Salomäki", NR = 71, Pos = "W/C", GP = 34, Goals = 3, Ass = 8, P = 11},
            new Roster() { Id = 29, Name = "Linus Öberg", NR = 20, Pos = "C/RW", GP = 40, Goals = 11, Ass = 6, P = 17},
         };
        public IActionResult Index()
        {
            return View(rosters);
        }

        public IActionResult Edit(int id)
        {
            var roster = rosters.FirstOrDefault(x => x.Id == id);
            return View(roster);
        }
        //public IActionResult Edit2(int gaa)
        //{
        //    var roster = rosters.FirstOrDefault(x => x.GAA == gaa);
        //    return View(roster);
        //}

        [HttpPost]
        public IActionResult Edit(Roster model)
        {
            if (!ModelState.IsValid)
            {

            }
            return View(model);
        }


        //public IActionResult Edit(int Goals)
        //{
        //    var goals = Goals.FirstOrDefault(x => x.Goals == Goals);
        //    return View(goals);
        //}
    }
}
