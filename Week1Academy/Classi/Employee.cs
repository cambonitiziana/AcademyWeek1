using System;
using System.Collections.Generic;
using System.Text;
using Week1Academy.Classi.Interfaces;

namespace Week1Academy.Classi
{
    public class Employee: Person
    {
        // ho tutto ciò che è marchiato public or protected

        public string Details()
        {
            return Cognome + "(" + NumeroFigli + ")";
        }

        public override string FullName(string title)
        {
            return "[Impiegato]" + Nome + " " + Cognome + "[" + NumeroFigli + "]";
        }

    }
}
