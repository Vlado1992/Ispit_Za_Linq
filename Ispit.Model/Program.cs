using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Model
{
    internal class Program
    {
        static void Main(string[] args)
        {             
            // 5. zadatak            
            Console.WriteLine("Ovdje je lista proizvoda:");
            Console.WriteLine("===========================================================");
            foreach (var proizvod in Proizvod.ListaProizvoda)
            {
                Console.WriteLine($"ID proizvoda: {proizvod.ProizvodID}, Naziv proizvoda: {proizvod.Naziv}");
            }
                        
            Console.WriteLine("\nLista računa:");
            Console.WriteLine("===========================================================");
            foreach (var racun in Racun.ListaRacuna)
            {
                Console.WriteLine($"Broj računa: {racun.BrojRacuna}, ID proizvoda: {racun.ProizvodID}, Količina: {racun.Kolicina}");
            }

            // 6. a. zadatak
            var SortiraniProizvodi = Proizvod.ListaProizvoda.OrderBy(p => p.Naziv).ToList();

            // 6. b. zadatak
            Console.WriteLine("\nSortirani proizvodi:");
            Console.WriteLine("===========================================================");
            foreach (var proizvod in SortiraniProizvodi)
            {
                Console.WriteLine($"ID proizvoda: {proizvod.ProizvodID}, Naziv proizvoda: {proizvod.Naziv}");
            }
            
            // 6. c. zadatak
            var ListaSpojenihPodataka = from racun in Racun.ListaRacuna
                                        join proizvod in Proizvod.ListaProizvoda
                                        on racun.ProizvodID equals proizvod.ProizvodID
                                        orderby proizvod.ProizvodID
                                        select new
                                        {
                                            racun.ProizvodID,
                                            proizvod.Naziv,
                                            racun.Kolicina
                                        };

            // 6. d. zadatak
            Console.WriteLine("\nPopis nakon pridruživanja:\n");
            Console.WriteLine($"ID proizvoda\t Naziv proizvoda\t\t Kupljena količina");
            Console.WriteLine("==================================================================");
            foreach (var item in ListaSpojenihPodataka)
            {                
                Console.WriteLine($"{item.ProizvodID}\t\t {item.Naziv}\t\t {item.Kolicina}");
            }
            Console.ReadKey();
        }
    }
}
