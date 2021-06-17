using MostriVsEroi.Modelli;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostriVsEroi.DbRepository
{
    class ArmaDbRepository : DbManager
    {
        public List<Arma> FetchArma(Eroe eroe)
        {
            List<Arma> armi = new List<Arma>();
            //Console.WriteLine("Inserire il nome dell'arma cercata");
            //string arma = Console.ReadLine();
            Connessione(out SqlConnection connection, out SqlCommand cmd);
            cmd.CommandText = "SELECT * from dbo.Arma ";
            
            SqlDataReader reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                Console.WriteLine("Arma non trovata");
            }
            else
                while (reader.Read())
                {
                    var id = reader[0];
                    var nome = reader[1];
                    var puntiDanno = reader[2];
                    Console.WriteLine($"{id} - {nome} - {puntiDanno}");
                  
                }
            return armi;
            
        }



    }
}