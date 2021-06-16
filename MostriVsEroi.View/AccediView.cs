using MostriVsEroi.View;
using MostriVsEroi.Modelli;
using MostriVsEroi.Servizi;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostriVsEroi.View
{
   static class AccediView
    {
        public static void Accedi()
        {
          Utente utente=  RichiestaDati.InserisciUsernamePassword();
          utente= UtenteService.VerifyAuthentication(utente);
            if(utente.IsAuthenticated && utente.IsAdmin)
            {
                //menuAdmin
            }
            else if(utente.IsAuthenticated && !utente.IsAdmin)
            {
                Menu.MenuNonAutenticato(utente);
            }
            else
            {
                Console.WriteLine("Devi prima registrarti");
                RegistrazioneView.Registrazione();
                
            }
        }
    }
}
