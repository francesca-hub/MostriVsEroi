using MostriVsEroi.Modelli;

using MostriVsErori.SchermataServizi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostriVsEroi.View
{
public static class RichiestaDati
    {
        public static Utente InserisciUsernamePassword()
        {
            Console.WriteLine("Inserisci il tuo username");
            string username = Console.ReadLine();

            Console.WriteLine("Inserisci password");
            string password = Console.ReadLine();

           return UtenteSchermataService.GetUtente(username, password);
       
        }
    }
}
