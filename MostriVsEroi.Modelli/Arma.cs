using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostriVsEroi.Modelli
{
   public class Arma
    {
        public string NomeArma { get; set; }
        public int PuntiDanno { get; set; }

        public Arma(string nomeArma, int puntiDanno)
        {
            NomeArma = nomeArma;
            PuntiDanno = puntiDanno;
        }
    }
}
