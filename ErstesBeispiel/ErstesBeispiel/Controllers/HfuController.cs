using System.Collections.Generic;
using System.Web.Mvc;
using ErstesBeispiel.Models;
using System.Collections;

namespace ErstesBeispiel.Controllers
{
    public class HfuController : Controller
    {
        public string SetPerson(string familienname)
        {
            int alter = 23;
            string antwort = "<html><head><title>HFU</title></head><body><h1>Hallo "+familienname+"</h1>Alter: "+alter+"</body></html>";

            return antwort;
        }

        public ActionResult AboutMe()
        {
            ViewBag.Title = "HFU";
            ViewBag.Vorname = "Janosch";
            ViewBag.Name = "Spielmann";
            ViewBag.Alter = 23;

            return View("HfuView");
        }

        public ActionResult CdListe()
        {            
            List<Cd> cds = new List<Cd>();
            Cd cd = new Cd();
            cds = cd.GetCds();
            
            ViewBag.CdListe = cds;
            
            return View("CdListe");
        }
    }
}