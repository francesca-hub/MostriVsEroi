using MostriVsEroi.Modelli;

using System;
using System.Collections.Generic;



namespace MostriVsEroi.MockRepository
{
  public  class EroeMockRepository
    {
        public List<Eroe> FetchEroi(Utente utente)
        {
            List<Eroe> eroi = new List<Eroe>();
            eroi.Add(new Eroe("PrimoEroeDiProva", new Arma("Ascia", 8), 1, CategoriaEroe.Guerriero, 20, 0));
            eroi.Add(new Eroe("SecondoEroeDiProva", new Arma("Bastone Magico", 10), 2, CategoriaEroe.Mago, 40, 0));

            return eroi;
        }
    }
    }
