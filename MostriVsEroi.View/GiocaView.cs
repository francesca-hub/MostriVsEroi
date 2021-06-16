using MostriVsEroi.Modelli;
using MostriVsEroi.Servizi;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MostriVsEroi.View
{
    class GiocaView
    {
        internal static void Gioca(Utente utente)
        {
            //scelta eroe
            Giocatore eroe = ScegliEroe(utente);
            Mostro mostro = MostroService.ScegliMostro(utente);
            Partita(eroe, mostro, utente);

            //partita

        }

        private static void Partita(Giocatore eroe, Mostro mostro, Utente utente)
        { 
            if (mostro.Livello > eroe.Livello)
            {
                Console.WriteLine(MostroService.ScegliMostro(utente));
            }
            else
            {
                do
                {
                    Console.WriteLine("Gioca partita!");
                    Console.WriteLine("Premi 1 per attaccare");
                    Console.WriteLine("Premi 2 per la fuga");
                    Console.WriteLine();
                    string scelta = Console.ReadLine();

                    switch (scelta)
                    {
                        case "1":
                            do
                            {
                                EroeService.AttaccoEroe(eroe, mostro);
                                MostroService.AttaccoMostro(eroe, mostro);
                            } while (eroe.PuntiVita > 0 && mostro.PuntiVita > 0);
                            if (eroe.PuntiVita == 0)
                            {
                                Console.WriteLine("Hai perso!");
                               
                            }
                            if (mostro.PuntiVita == 0)
                            {
                                Console.WriteLine("Hai vinto");
                            }
                            break;

                        case "2":
                            //fuga();
                            break;
                    }
                } while (true);
            }

        }

        private static Giocatore ScegliEroe(Utente utente)
        {
            Console.WriteLine("Quale eroe vuoi scegliere?");
            List<Eroe> eroi = EroeService.GetEroi(utente);
            if (eroi.Count > 0)
            {
                int count = 1;
                bool conversioneRiuscita = false;
                int eroescelto = 0;
                do
                {
                    foreach (Giocatore eroe in eroi)
                    {
                        Console.WriteLine($"Premi {count} per scegliere l'eroe {eroe.Nome}, di tipo {CategoriaEroe.Guerriero} "+ 
                                $" con arma {eroe.Arma} che ha {eroe.Arma.PuntiDanno} punti danno, di livello {eroe.Livello} e vita {eroe.PuntiVita}");
                        count++;
                    }
                    conversioneRiuscita = int.TryParse(Console.ReadLine(), out eroescelto);

                } while (!conversioneRiuscita || eroescelto < 1 || eroescelto > eroi.Count);
                //ritorno l'eroe
                return eroi[--eroescelto];
            }
            else
            {
                Console.WriteLine("Nessun eroe in lista");
                return null;
            }
        }
    }
}