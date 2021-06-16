using MostriVsEroi.MockRepository;
using MostriVsEroi.Modelli;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MostriVsEroi.Servizi
{
    public static class MostroService
    {
        static MostroMockRepository mmr = new MostroMockRepository();

        public static List<Mostro> GetMostri(Utente utente)
        {
            return mmr.FetchMostro(utente);
        }

        public static Mostro ScegliMostro(Utente utente)
        {
            Console.WriteLine("Scelta casuale mostro");
            int mostroscelto = 0;
            List<Mostro> mostri = GetMostri(utente);
            if (mostri.Count > 0)
            {
                
                    Random r = new Random();
                    mostroscelto = r.Next(0, mostri.Count-1);
                
                return mostri[mostroscelto];

            }
            else
            {
                return null;
            }
        }

        public static void AttaccoMostro(Giocatore eroe, Mostro mostro)
        {
            
                int nuovaVitaEroe = eroe.PuntiVita - mostro.Arma.PuntiDanno;
                // return nuovaVitaEroe;
                if (nuovaVitaEroe > 0)
                {
                    Console.WriteLine("Il turno di attacco passa all'eroe");
                    EroeService.AttaccoEroe(eroe, mostro);

                }
           
            } 
        }
    }

