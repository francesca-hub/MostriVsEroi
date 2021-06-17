using MostriVsEroi.Modelli;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostriVsEroi.DbRepository
{
    public class UtenteDbRepository : DbManager
    {

        static List<Utente> utenti = new List<Utente>();
        public Utente GetUser(Utente utente)
        {

            Connessione(out SqlConnection connection, out SqlCommand cmd);

            cmd.CommandText = "SELECT * from dbo.Giocatore WHERE Username = @Username AND Password = @Password;";
            cmd.Parameters.AddWithValue("@Username", utente.Username);
            cmd.Parameters.AddWithValue("@Password", utente.Password);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                utente.IsAuthenticated = true;
            }
            else
            {
                utente.IsAuthenticated = false;

            }
            connection.Close();
            return utente;
        }
    }
}