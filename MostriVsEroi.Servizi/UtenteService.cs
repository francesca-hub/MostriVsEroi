using MostriVsEroi.MockRepository;
using MostriVsEroi.Modelli;

using System;


namespace MostriVsEroi.Servizi
{
    public static class UtenteService
    {
        static UtenteMockrepository umr = new UtenteMockrepository();
        public static Utente VerifyAuthentication(Utente utente)
        {
            return umr.GetUser(utente);
        }
    }
}
