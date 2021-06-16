using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MostriVsEroi.Modelli;
using MostriVsEroi.Servizi;


namespace MostriVsEroi.View
{
    public static class EliminaEroeView
    {
        public static void EliminaEroe(Utente utente)
        {
            Console.WriteLine("Procedi con l'eliminazione dell'eroe");
            Console.WriteLine("Ecco la lista di eroi, scegli quello che vuoi eliminare");
            List<Eroe> eroi = EroeService.GetEroi(utente);
            foreach (Eroe eroe in eroi)
            {
                Console.WriteLine(eroe);
            }
            string nomeEroe = Console.ReadLine();

            Eroe EroeEliminato = new Eroe(nomeEroe);
            eroi.Remove(EroeEliminato);
                
        }
    }
}