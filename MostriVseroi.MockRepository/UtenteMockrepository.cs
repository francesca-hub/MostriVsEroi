using System;
using System.Collections.Generic;
using MostriVsEroi.Modelli;


namespace MostriVsEroi.MockRepository
{
    public class UtenteMockrepository : IUtenteRepository
    {
        static List<Utente> utente = new List<Utente>();

        public Utente GetUser(Utente utente)
        {
            utente.IsAuthenticated = true;
            return utente;
        }


    }
}