using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TablaPeriodica.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        string[,,] Row1 = new string[,,] {{ {"3","Li","darkcyan"},{"4","Be","lightblue"},{"5","B","coral"},{"6","C","aquamarine"},
                                          {"7", "N", "aquamarine"}, {"8", "O", "aquamarine"}, {"9", "F", "aquamarine"},
                                          {"10", "Ne", "aquamarine"}
        }};
        string[,,] Row2 = new string[,,] 
        {
            {
                {"11","Na","darkcyan"},{"12","Mg","lightblue"},{"13","Al","deepskyblue"},{"14","Si","coral"},
                {"15", "P", "aquamarine"}, {"16", "S", "aquamarine"},
                {"17", "Cl", "aquamarine"}, {"18", "Ar", "aquamarine"},
            }

        };

        string[,,] Row3 = new string[,,]
        {
            {
                {"19", "K", "darkcyan"}, {"20", "Ca", "lightblue"}, {"21", "Sc", "cyan"}, {"22", "Ti", "cyan"},
                {"23", "V", "cyan"}, {"24", "Cr", "cyan"}, {"25", "Mn", "cyan"}, {"26", "Fe", "cyan"},
                {"27", "Co", "cyan"}, {"28", "Ni", "cyan"}, {"29", "Cu", "cyan"}, {"30", "Zn", "cyan"},
                {"31", "Ga", "deepskyblue"}, {"32", "Ge", "coral"}, {"33", "As", "coral"}, {"34", "Se", "aquamarine"},
                {"35", "Br", "aquamarine"}, {"36", "Kr", "aquamarine"}

            }
        };

        private string[,,] Row4 = new string[,,]
        {
            {
                {"37", "Rb", "darkcyan"}, {"38", "Sr", "lightblue"}, {"39", "Y", "cyan"}, {"40", "Zr", "cyan"},
                {"41", "Nb", "cyan"},
                {"42", "Mo", "cyan"}, {"43", "Tc", "cyan"}, {"44", "Ru", "cyan"}, {"45", "Rh", "cyan"},
                {"46", "Pd", "cyan"}, {"47", "Ag", "cyan"}, {"48", "Cd", "cyan"}, {"49", "In", "deepskyblue"},
                {"50", "Sn", "deepskyblue"}, {"51", "Sb", "coral"}, {"52", "Te", "coral"}, {"53", "I", "aquamarine"},
                {"54", "Xe", "aquamarine"}

            }
        };

        private string[,,] Row5 = new string[,,]
        {
            {
                {"55", "Cs", "darkcyan"}, {"56", "Ba", "lightblue"}, {"57-71", "La-Lu", "plum"}, {"72", "Hf", "cyan"},
                {"73", "Ta", "cyan"}, {"74", "W", "cyan"}, {"75", "Re", "cyan"}, {"76", "Os", "cyan"},
                {"77", "Ir", "cyan"},{"78", "Pt", "cyan"}, {"79", "Au", "cyan"}, {"80", "Hg", "cyan"},
                 {"81", "Tl", "deepskyblue"},{"82", "Pb", "deepskyblue"}, {"83", "Bi", "deepskyblue"}, {"84", "Po", "coral"},
                 {"85", "At", "aquamarine"}, {"86", "Rn", "aquamarine"}

            }
        };

        private string[,,] Row6 = new string[,,]
        {
            {
                {"87", "Fr", "darkcyan"}, {"88", "Ra", "lightblue"}, {"89-103", "Ac-Lr", "plum"}, {"104", "Rf", "cyan"},
                {"105", "Db", "cyan"}, {"106", "Sg", "cyan"}, {"107", "Bh", "cyan"}, {"108", "Hs", "cyan"},
                {"109", "Mt", "cyan"}, {"110", "Ds", "cyan"}, {"111", "Rg", "cyan"}, {"112", "Cn", "cyan"},
                {"113", "Nh", "deepskyblue"}, {"114", "Fl", "deepskyblue"}, {"115", "Mc", "deepskyblue"}, {"116", "Lv", "deepskyblue"},
                {"117", "Ts", "aquamarine"}, {"118", "Og", "aquamarine"},
            }
        };

        private string[,,] Row7 = new string[,,]
        {
            {
                {"57", "La", "plum"}, {"58", "Ce", "plum"}, {"59", "Pr", "plum"},
                {"60", "Nd", "plum"}, {"61", "Pm", "plum"}, {"62", "Sm", "plum"},
                {"63", "Eu", "plum"}, {"64", "Gd", "plum"}, {"65", "Tb", "plum"},
                {"66", "Dy", "plum"}, {"67", "Ho", "plum"}, {"68", "Er", "plum"},
                {"69", "Tm", "plum"}, {"70", "Yb", "plum"}, {"71", "Lu", "plum"},
            }
        };

        private string[,,] Row8 = new string[,,]
        {
            {
                {"89", "Ac", "plum"}, {"90", "Th", "plum"}, {"91", "Pa", "plum"},
                {"92", "U", "plum"}, {"93", "Np", "plum"}, {"94", "Pu", "plum"},
                {"95", "Am", "plum"}, {"96", "Cm", "plum"}, {"97", "Bk", "plum"},
                {"98", "Cf", "plum"}, {"99", "Es", "plum"}, {"100", "Fm", "plum"},
                {"101", "Md", "plum"}, {"102", "No", "plum"}, {"103", "Lr", "plum"},
            }
        };
        
        public ActionResult Index()
        {
            ViewBag.Row1 = Row1;
            ViewBag.Row2 = Row2;
            ViewBag.Row3 = Row3;
            ViewBag.Row4 = Row4;
            ViewBag.Row5 = Row5;
            ViewBag.Row6 = Row6;
            ViewBag.Row7 = Row7;
            ViewBag.Row8 = Row8;
            return View();
        }
    }
}