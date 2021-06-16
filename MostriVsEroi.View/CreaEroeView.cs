
using MostriVsEroi.Modelli;
using MostriVsEroi.Servizi;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MostriVsEroi.View
{
 public static class CreaEroeView
    {
        public static Eroe CreaEroe(Utente utente)
        {
            Console.WriteLine("Crea un eroe");
            Console.WriteLine("Inserisci nome eroe");
            string nome = Console.ReadLine();
            Console.WriteLine("Scegli la categoria dell'eroe: premi 0 per Guerriero - premi 1 per Mago ");
            int categoria = int.Parse(Console.ReadLine());
            Console.WriteLine($"Hai scelto la categoria {categoria}");

            Console.WriteLine("Scegli l'arma");
            Console.WriteLine("Scegli i punti danno");
            
           List<Arma> armi= ArmaService.GetArmi(utente);
            foreach (Arma arma in armi)
            {
                Console.WriteLine(arma.Nome);
            }

            string armanome = Console.ReadLine();
            int puntiDanno = int.Parse(Console.ReadLine());
            Arma arma1 = new Arma(armanome, puntiDanno);
            Eroe eroe1 = new Eroe(nome, arma1, (CategoriaEroe)categoria);
            List<Eroe> eroi = new List<Eroe>();
            
            eroi.Add(eroe1);
            Console.WriteLine("Hai aggiunto un nuovo eroe");
            return eroe1;
            







        }
    }
}
