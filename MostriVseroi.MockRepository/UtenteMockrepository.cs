using System;
using MostriVsEroi.Modelli;


namespace MostriVsEori.MockRepository
{
    public class UtenteMockrepository: IUtenteRepository
    {
        public Utente GetUser(Utente utente)
        {
            utente.IsAuthenticated = true;
            return utente;
        }

    }
}
