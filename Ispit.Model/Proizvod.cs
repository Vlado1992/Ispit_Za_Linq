using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Model
{
    // 2. a. zadatak
    public class Proizvod
    {
        public int ProizvodID { get; set; }
        public string Naziv { get; set; }

        public Proizvod(int proizvoidID, string naziv)
        {
            ProizvodID = proizvoidID;
            Naziv = naziv;
        }
        // 3. zadatak
        public static List<Proizvod> ListaProizvoda = new List<Proizvod>()
        {
            new Proizvod (1, "Čokolada - za kuhanje"),
            new Proizvod (2, "Lino Lada – Gold"),
            new Proizvod (3, "Papir za pečenje"),
            new Proizvod (4, "Brašno – pšenično"),
            new Proizvod (5, "Šećer – standard")
        };
    }
}
