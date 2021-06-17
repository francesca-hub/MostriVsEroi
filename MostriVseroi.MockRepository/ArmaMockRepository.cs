using MostriVsEroi.Modelli;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostriVsEroi.MockRepository
{
    public class ArmaMockRepository
    {
        public  List<Arma> FetchArma(Eroe eroe)
        {
            List<Arma> armi = new List<Arma>();
            armi.Add(new Arma("Bacchetta", 5));
            armi.Add(new Arma("Mazza", 5));

            return armi;
        }
    }
}
