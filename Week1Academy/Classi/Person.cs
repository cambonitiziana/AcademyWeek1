using System;
using System.Collections.Generic;
using System.Text;
using Week1Academy.Classi.Interfaces;

namespace Week1Academy.Classi
{
    public class Person : ILogging
    {
        //campi
        private string _codiceFiscale;

        //proprietà
        public string CodiceFiscale
        {
            get { return _codiceFiscale; }
            set { _codiceFiscale = value; }
        }

        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime DateDiNascita { get; set; }
        public int NumeroFigli { get; set; }

        //Metodi
        public virtual string FullName(string title) //virtual-> chi eredita può sovrascrivere
        {
            return "[" + title + "]" + " " + Nome + " " + Cognome;
        }

       

        public void LogError(string message)
        {
            Console.WriteLine("[ERROR] {0}", message);
        }

        public void LogInfo(string message)
        {
            Console.WriteLine("[INFO] {0}", message);
        }

        public void LogWarning(string message)
        {
            Console.WriteLine("[WARNING] {0}", message);
        }

       
        
    }
}
