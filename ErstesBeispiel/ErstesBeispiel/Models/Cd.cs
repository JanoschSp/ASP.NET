using System.Collections.Generic;

namespace ErstesBeispiel.Models
{
    public class Cd
    {
        public string Interpret { get; set; }
        public string CdTitel { get; set; }
        public int Jahr { get; set; }
        public int AnzahlTitel { get; set; }

        public List<Cd> CdList = new List<Cd>();

        public List<Cd> GetCds()
        {
            CdList.Add(new Cd() { Interpret = "Baschi", CdTitel = "Neu", Jahr = 2016, AnzahlTitel = 24 });
            CdList.Add(new Cd() { Interpret = "Eminem", CdTitel = "Blue", Jahr = 2015, AnzahlTitel = 12 });
            CdList.Add(new Cd() { Interpret = "Blood Hound Gang", CdTitel = "Index", Jahr = 2008, AnzahlTitel = 9 });
            CdList.Add(new Cd() { Interpret = "Rihanna", CdTitel = "Diamond", Jahr = 1999, AnzahlTitel = 17 });
            return CdList;
        }     
    }
}