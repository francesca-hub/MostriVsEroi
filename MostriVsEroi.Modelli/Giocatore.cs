using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MostriVsEroi.Modelli
{
    public class Giocatore
    {
        public string Nome { get; set; }
        public Arma Arma { get; set; }
        public int Livello { get; set; }
        public int PuntiVita { get; set; }

        public Giocatore(string nome, Arma arma, int livello, int puntiVita)
        {
            Nome = nome;
            Arma = arma;
            Livello = livello;
            PuntiVita = puntiVita;
        }

        public Giocatore(string nome, Arma arma)
        {
            Nome = nome;
            Arma = arma;
        }
        public Giocatore (string nome)
        {
            Nome = nome;
        }

        public Giocatore()
        {
                
        }
    }

    public class Eroe : Giocatore
    {
        public CategoriaEroe Categoria { get; set; }

        public int PuntiAccumulati { get; set; }

        public Eroe(string nome, Arma arma, int livello, CategoriaEroe categoria, int puntiVita, int puntiAccumulati)
            : base(nome, arma, livello, puntiVita)
        {
            Categoria = categoria;
            PuntiAccumulati = puntiAccumulati;
            
        }

        public Eroe(string nome, Arma arma, CategoriaEroe categoria)
            :base (nome, arma)
        {
            Categoria = categoria;
            Livello = 1;
        }

        public Eroe (string nome)
            : base(nome)
        {

        }

        public Eroe()
        {
        }
    }



    public enum CategoriaEroe
    {
        Guerriero,
        Mago
    }


}
    