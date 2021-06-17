using System;
using System.Collections.Generic;
using MostriVsEroi.Modelli;


namespace MostriVsEroi.MockRepository
{
    public class UtenteMockrepository : IUtenteRepository
    {
        List<Utente> utenti = new List<Utente>();

        public Utente GetUser(Utente utente)
        {
            utente.IsAuthenticated = true;
            return utente;
        }

        public void AddUtente(Utente utente)
        {
            utenti.Add(utente);
        }
    }
}