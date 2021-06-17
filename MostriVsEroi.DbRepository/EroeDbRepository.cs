using MostriVsEroi.Modelli;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            Connessione(out SqlConnection connection, out SqlCommand cmd);
            

            cmd.CommandText = "SELECT * FROM dbo.Utenti WHERE Username = @Username;";

            cmd.Parameters.AddWithValue("@Username", utente.Username);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var nome = (string)reader[1];
                var categoriaEroe = (CategoriaEroe)reader[2];
                var livello = (int)reader[3];
                var puntiVita = (int)reader[4];
                var nomeArma = (string)reader[5];
                var puntiDannoArma = (int)reader[6];
                var puntiAccumulati = (int)reader[7];

                Eroe eroe = new Eroe(nome, new Arma (nomeArma,puntiDannoArma),livello,categoriaEroe, puntiVita,puntiAccumulati);
                eroi.Add(eroe);
            }
            connection.Close();
            
            return eroi;
        }
    }
}
