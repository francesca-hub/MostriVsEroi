
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MostriVsEroi.MockRepository;
using MostriVsEroi.Modelli;

namespace MostriVsEroi.Servizi
{
  public static class EroeService
    {
        static EroeMockRepository emr = new EroeMockRepository();

        public static List<Eroe> GetEroi(Utente utente)
        {
            return emr.FetchEroi(utente);
        }

        public static void AttaccoEroe(Giocatore eroe, Mostro mostro)
        {
            int nuoviPuntiVitaMostro = mostro.PuntiVita - eroe.Arma.PuntiDanno;
            //return nuoviPuntiVitaMostro;
            if (mostro.PuntiVita == 0)
            {
                Console.WriteLine("Hai vinto");
            }
            else
            {
                Console.WriteLine("Il turno di attacco passa al mostro");
                MostroService.AttaccoMostro(eroe, mostro);
            }
        }
    }
}
