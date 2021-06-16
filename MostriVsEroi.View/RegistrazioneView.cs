using MostriVsEroi.Modelli;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostriVsEroi.View
{
  public static  class RegistrazioneView
    {
        public static void Registrazione()
        {
          Utente utente=RichiestaDati.InserisciUsernamePassword();
          


            
            Console.WriteLine("Registrazione effettuata con successo!");
 
        }
    }
}
