using MostriVsEroi.Modelli;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostriVsEori.MockRepository
{
   public class MostroMockRepository
    {
        public List<Mostro> FetchMostro(Utente utente)
        {
            List<Mostro> mostri = new List<Mostro>();
            mostri.Add(new Mostro( CategoriaMostro.Cultista, new Arma("Imprecazione", 5), 1, 20));
            mostri.Add(new Mostro( CategoriaMostro.Orco, new Arma("Clava", 5), 2, 40));

            return mostri;
        }


    }
}
