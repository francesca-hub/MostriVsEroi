using MostriVsEroi.Modelli;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostriVsEroi.DbRepository
{
  public class MostroDbRepository:DbManager
    {

        public List<Mostro> FetchMostro(Utente utente) {
            List<Mostro> mostri = new List<Mostro>();
            Connessione(out SqlConnection connection, out SqlCommand cmd);
           cmd.CommandText = "SELECT * from dbo.Mostri;";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
       
        var categoria = (CategoriaMostro)reader[1];
        var nomeArma = (string)reader[2];
        var dannoArma = (int)reader[3];
        var livello = (int)reader[4];
        var puntiVita = (int)reader[5];

                Mostro mostro1 = new Mostro (categoria, new Arma(nomeArma, dannoArma),livello, puntiVita);
                mostri.Add(mostro1);
            }
    connection.Close();
            return mostri;
        }
    }
}
