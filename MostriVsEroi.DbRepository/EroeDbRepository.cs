using MostriVsEroi.Modelli;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostriVsEroi.DbRepository
{
    class EroeDbRepository:DbManager
    {
        public List<Eroe> FetchEroi(Utente utente)
        {
            List<Eroe> eroi = new List<Eroe>();
            //eroi.Add(new Eroe("PrimoEroeDiProva", new Arma("Ascia", 8), 1, CategoriaEroe.Guerriero, 20, 0));
            //eroi.Add(new Eroe("SecondoEroeDiProva", new Arma("Bastone Magico", 10), 2, CategoriaEroe.Mago, 40, 0));

            return eroi;
        }
    }
}
