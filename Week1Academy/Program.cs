using System;
using Week1Academy.FormeGeometriche;

namespace Week1Academy
{
    class Program
    {
        delegate int Somma(int primoNum, int secondoNum);//definisco la classe delegate somma
        //accetta come ingresso il metodo somma con questa firma
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Funzionalita.EseciziTipo();
            // Funzionalita.Esercizione();
            // Funzionalita.EsercizioInterfacce();


            Somma somma = new Somma(Funzionalita.MySum);
            //Somma somma2 = new Somma(Funzionalita.MySum3);
            int risultato = somma(1, 2);
        }


    }
}
