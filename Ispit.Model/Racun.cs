using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Model
{
    // 2. b. zadatak
    public class Racun
    {
        public int BrojRacuna { get; set; }
        public int ProizvodID { get; set; }
        public int Kolicina { get; set; }

        public Racun(int brojRacuna, int proizvodID, int kolicina)
        {
            BrojRacuna = brojRacuna;
            ProizvodID = proizvodID;
            Kolicina = kolicina;
        }
        // 4. zadatak
        public static List<Racun> ListaRacuna = new List<Racun>()
        {
            new Racun (100, 3, 800),
            new Racun (101, 2, 650),
            new Racun (102, 3, 900),
            new Racun (103, 4, 700),
            new Racun (104, 3, 900),
            new Racun (105, 4, 650),
            new Racun (106, 1, 458)
        };
    }
}
