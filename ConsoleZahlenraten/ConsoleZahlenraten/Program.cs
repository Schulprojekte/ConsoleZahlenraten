using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleZahlenraten
{
    class Program
    {
        static int zuErrateneZahl; //Muss auch static sein, wenn die Variable außerhalb der Methode deklariert

        static void Main(string[] args)
        {
            MethodeZahlenraten(); //Methodenaufruf
        }

        private static void MethodeZahlenraten()
        {
            Random random = new Random(); //erzeugt ein neues Objekt mit dem Bezeichner random aus der Klasse Random
            zuErrateneZahl = random.Next(1, 6); //Bereich der Zufallszahl liegt zwischen 1 und 5
            Console.WriteLine("Erraten Sie eine Zahl zwischen 1 und 5.");
            Console.Write("Geben Sie eine ganze Zahl ein."); //in der geschweiften Klammer steht der Index (muss 0 sein)
            //der mit i nach dem Komma numeriert die Anzahl der Versuche mit Zählung von i
            int Zahl = Convert.ToInt32(Console.ReadLine());

            //if, else if und else entsteht Verzweigungsstruktur
            if (Zahl == zuErrateneZahl) //wenn die Bedingung erfüllt ist, if können unendlich viele hintereinander kommen
            {
                Console.WriteLine("Herzlichen Glückwunsch, Sie haben die Zahl " + zuErrateneZahl + " erraten");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Falsch geraten es war die Zahl " + zuErrateneZahl);
                Console.ReadKey();
            }
        }
    }
}