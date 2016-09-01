using System.Web.Mvc;

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
    }
}