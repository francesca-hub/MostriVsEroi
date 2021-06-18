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
            
            
            Connessione(out SqlConnection connection, out SqlCommand cmd);
            

            cmd.CommandText = "SELECT * FROM dbo.Eroe";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var idEroe = (int)reader[0];
                var nomeEroe = (string)reader[1];
                var livello = (int)reader[2];
                var idGiocatore = (int)reader[3];
                var idCategoria = (int)reader[4];
                var idArma = (int)reader[5];

                Console.WriteLine($"{idEroe} - Nome eroe: {nomeEroe} - Categoria: {idCategoria} - Livello: {livello} - Arma:{idArma}");
            }
            connection.Close();
            
            return eroi;
        }
        public void CreaEroe(Eroe eroe, Utente utente)
        {
          
            int idGiocatore = FetchIdGiocatore(utente);
            int idCategoria = FetchIdCategoria(eroe);
            int idArma = FetchIdArma(eroe);

          
           Connessione(out SqlConnection connection, out SqlCommand cmd);
            cmd.CommandText = "insert into dbo.Eroe (NomeEroe,Livello,IdUtente,IDCategoria,IDArma) values (@NomeEroe, @Livello, @IdUtente, @IDCategoriaEroe,@IdArma)";
            cmd.Parameters.AddWithValue("@NomeEroe", eroe.Nome);
            cmd.Parameters.AddWithValue("@IDCategoriaEroe", idCategoria);
            cmd.Parameters.AddWithValue("@IdUtente", idGiocatore);
            cmd.Parameters.AddWithValue("@IdArma", idArma);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void EliminaEroe(Utente utente, Eroe eroe)
        {
            
            int idUtente = FetchIdGiocatore(utente);

            Connessione(out SqlConnection connection, out SqlCommand cmd);
            cmd.CommandText = "DELETE FROM dbo.Eroe WHERE NomeEroe = @NomeEroe AND IdUtente = @IdUtente; ";
            cmd.Parameters.AddWithValue("@NomeEroe", eroe.Nome);
            cmd.Parameters.AddWithValue("@IdUtente", idUtente);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private int FetchIdArma(Eroe eroe)
        {
            Connessione(out SqlConnection connection, out SqlCommand cmd);
            cmd.CommandText = "select from dbo.Eroe WHERE IDArma=@IDArma;";
            cmd.Parameters.AddWithValue("@Nome", eroe.Categoria);
            SqlDataReader reader = cmd.ExecuteReader();
            int idArma = 0;
            while (reader.Read())
            {
                var id = (int)reader[5];
                idArma= id;
            }
            connection.Close();
            return idArma;
        }

        private int FetchIdCategoria(Eroe eroe)
        {
            Connessione(out SqlConnection connection, out SqlCommand cmd);
            cmd.CommandText = "select from dbo.Eroe WHERE IDCategoria=@IDCategoria;";
            cmd.Parameters.AddWithValue("@Nome", eroe.Categoria);
            SqlDataReader reader = cmd.ExecuteReader();
            int idCategoria = 0;
            while (reader.Read())
            {
                var id = (int)reader[4];
                idCategoria = id;
            }
            connection.Close();
            return idCategoria;
        }

        private int FetchIdGiocatore(Utente utente)
        {
            Connessione(out SqlConnection connection, out SqlCommand cmd);
            cmd.CommandText = "select  from dbo.Giocatore WHERE Username = @Username;";
            cmd.Parameters.AddWithValue("@Username", utente.Username);
            SqlDataReader reader = cmd.ExecuteReader();
            int idUtente = 0;
            while (reader.Read())
            {
                var id = (int)reader[3];
                idUtente = id;
            }
            connection.Close();
            return idUtente;
        }

    }
}
