using System;
using System.Data.SqlClient;

namespace MostriVsEroi.DbRepository
{
    public class DbManager
    {

        const string connectionString = @"Data Source= (localdb)\MSSQLLocalDB;" +
                                          "Initial Catalog = MostriVsEroi;" +
                                          "Integrated Security=true;";

        // creo un metodo per la connessione
        public static void Connessione(out SqlConnection connection, out SqlCommand cmd)
        {
            connection = new SqlConnection(connectionString);
            //apro la connessione
            connection.Open();
            //creo il comando
            cmd = new SqlCommand();
            //gli associo la connesione 
            cmd.Connection = connection;
            cmd.CommandType = System.Data.CommandType.Text;
        }


    }
}
