using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostriVsEroi.Modelli
{
   public class Mostro
    {
        
        public CategoriaMostro CategoriaMostro { get; set; }
        public Arma Arma { get; set; }
        public int Livello { get; set; }
        public int PuntiVita { get; set; }

        public Mostro( CategoriaMostro categoriaMostro, Arma arma, int livello, int puntiVita)
        {
           
            CategoriaMostro = categoriaMostro;
            Arma = arma;
            Livello = livello;
            PuntiVita = PuntiVita;
        }

    }
    public enum CategoriaMostro
    {
        Cultista,
        Orco,
       SignoreDelMale
    }
}
