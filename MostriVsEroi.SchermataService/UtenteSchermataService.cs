using MostriVsEroi.Modelli;

using System;

namespace MostriVsErori.SchermataServizi
{
    public static class UtenteSchermataService
    {
        public static Utente GetUtente(string username, string password)
        {
            return new Utente(username, password);
         }
    }
}
