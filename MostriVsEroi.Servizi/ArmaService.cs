
using MostriVsEroi.MockRepository;
using MostriVsEroi.Modelli;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostriVsEroi.Servizi
{
   public static class ArmaService
    {
        static ArmaMockRepository amr = new ArmaMockRepository();

        public static List<Arma> GetArmi(Eroe eroe)
        {
            return amr.FetchArma(eroe);
        }
    }
}
