using System;
using System.Collections.Generic;
using System.Text;
using Week1Academy.Classi;
using Week1Academy.Classi.Interfaces;
using Week1Academy.FormeGeometriche;

namespace Week1Academy
{
    public enum State
    { 
    New=0,
    Open=1,
    OnHold=2,
    Closed = 3
    }
    public class Funzionalita
    {
        public static void EseciziTipo()
        {
            //valueType vs referece type

            //valuetype
            bool x = true;
            bool y = false;

            bool z = !y;


            float f = 1f / 3f;
            double doub = 1d / 3d;
            decimal dec = 1m / 3m;

            State myState = State.New;
            if (myState == State.New)
            {
                Console.WriteLine("La variabile mystate contiene New");
            }
            String nome = "Tiziana Camboni";
            string sub = nome.Substring(4);

            Console.Clear();
            Console.WriteLine("_________CLASSI__________");

            Person persona = new Person();
            persona.Nome = "Mario";
            persona.Cognome = "Rossi";
            persona.CodiceFiscale = " RSSMRA58V1234V";
            persona.DateDiNascita = new DateTime(1978, 09, 20);

            Person persona2 = new Person()
            {
                Nome = "Alessia",
                Cognome = "Bianchi",
                CodiceFiscale = "BNCALSHSJ55"
            };

            Console.WriteLine(persona.FullName("Signor"));
            Console.WriteLine(persona2.FullName("Signora"));

            Employee employee = new Employee()
            {
                Nome = "Luca",
                Cognome = "Gialli",
                CodiceFiscale = "AGGS6556SM",
                NumeroFigli = 1
            };

            Console.WriteLine(employee.FullName(""));

            Person employee2 = new Employee()
            {
                Nome = "Anna",
                Cognome = "Neri",
                CodiceFiscale = "FKS78FBSKS",
                DateDiNascita = new DateTime(1989, 09, 02),
                NumeroFigli = 3
            };

            Console.WriteLine(employee2.FullName(""));
            Manager m = new Manager();

        }

        public static void Esercizione()
        {
            Circle Cerchio = new Circle()
            {
                name = "Mio Cerchio",
                r = 3d,
                X = 20,
                Y = 10
            };
            Cerchio.DisplayShape();


            Rectangle rett = new Rectangle()
            {
                name = "Mio Rettangolo",
                a = 3,
                b = 4
            };
            rett.DisplayShape();

            Triangle trian = new Triangle()
            {
                name = "mio Triangolo",
                a = 3,
                b = 4
            };
            trian.DisplayShape();


            //parte2

            Console.Clear();

            Cerchio.SaveToFile("test");
            Circle newCircle = new Circle();
            newCircle.LoadFromFile("Test");
            newCircle.DisplayShape();
            newCircle.name = "Modified Circle";
            newCircle.SaveToFile("test");

            rett.SaveToFile("Test rettangolo");
            Rectangle newRett = new Rectangle();
            newRett.LoadFromFile("Test rettangolo");
            newRett.DisplayShape();
            newRett.name = "Modified rett";
            newRett.SaveToFile("Test rettangolo");

            trian.SaveToFile("Test triangolo");
            Triangle newTrian = new Triangle();
            newTrian.LoadFromFile("Test triangolo");
            newTrian.DisplayShape();
            newTrian.name = "Modified triangle";
            newTrian.SaveToFile("Test triangolo");
        }

        public static void EsercizioInterfacce()
        {
            Person person = new Person();
            person.Nome = "Pio";
            person.Cognome = "Rossi";
            person.CodiceFiscale = "HSOSABSIOO";
            person.DateDiNascita = new DateTime(1956, 09, 30);

            person.LogInfo("Log funziona");

            Person p = new Employee()
            {
                Nome = "Alice",
                Cognome = "Colella"
            };


            p.LogInfo("Funziona anche nell'implementazione di employee");

            Computer myComputer = new Computer()
            {
                Model = "DELL XPS 9570"
            };
            myComputer.LogInfo("Funziona anche per la classe computer");

            ILogging[] loggingItems = { myComputer, p };
            foreach (ILogging item in loggingItems)
            {
                item.LogInfo("Prova");
            }

        }

        //due metodi
        public static int MySum(int a, int b)
        { return a + b; }


        public static int MySum3(int a, int b, int c)
        {
            return a + b + c;
        }
        
    }
}
