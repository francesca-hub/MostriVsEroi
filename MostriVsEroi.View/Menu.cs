

using System;
using MostriVsEroi.Modelli;

namespace MostriVsEroi.View
{
    public static class Menu
    {
        public static void MainMenu()
        {
            bool vuoiContinuare = true;
            {
                do
                {
                    Console.WriteLine("Bentornato!");
                    Console.WriteLine();
                    Console.WriteLine("Cosa vuoi fare?");

                    Console.WriteLine("Premi 1 per accedere");
                    Console.WriteLine("Premi 2 per registrarti");
                    Console.WriteLine("Premi 0 per uscire");

                    string scelta = Console.ReadLine();

                    switch (scelta)
                    {
                        case "1":
                            //devo far accedere l'utente
                            AccediView.Accedi();
                            break;

                        case "2":
                            RegistrazioneView.Registrazione();
                            break;

                        case "0":
                            Console.WriteLine("Ciao alla prossima");
                            vuoiContinuare = false;
                            break;
                        default:
                            Console.WriteLine("Scelta sbagliata... riprova");
                            break;
                    }
                } while (vuoiContinuare == true);
            }
        }

        internal static void MenuNonAutenticato(Utente utente)
        {
            bool vuoicontinuare = true;

            do {
                Console.WriteLine("Cosa vuoi fare?");
            Console.WriteLine("Premi 1 per giocare");
            Console.WriteLine("Premi 2 per creare un nuovo eroe");
            Console.WriteLine("Premi 3 per elimanre eroe");
            Console.WriteLine("premi 0 per tornare al menù principale");

            string scelta = Console.ReadLine();
            switch (scelta) { 
              case "1":
                        GiocaView.Gioca(utente);
                break;

            case "2":
                       CreaEroeView.CreaEroe(utente);
                break;

                case "3":
                        EliminaEroeView.EliminaEroe(utente);
                    break;

            case "0":
                Console.WriteLine("Ciao alla prossima");
                        MainMenu();
                vuoicontinuare = false;
                break;
            default:
                Console.WriteLine("Scelta sbagliata... riprova");
                break;
            }
        } while (vuoicontinuare == true);
            }
}


}

