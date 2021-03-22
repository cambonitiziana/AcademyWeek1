using System;
using System.Collections.Generic;
using System.Text;
using Week1Academy.Classi.Interfaces;

namespace Week1Academy.FormeGeometriche
{
    public class geometricShapes : IFileSerializable
    {

        //proprietà
        public string name { get; set; }



        // Metodi

        public virtual double Area()
        {
            return 0;
        }

        public virtual void DisplayShape()
        {

            Console.WriteLine("This is a generic shape");
        }

        public virtual void SaveToFile(string fileName)
        {
            Console.WriteLine("Saving file: {0}  ... (base class)", fileName);
        }
        public virtual void LoadFromFile(string fileName)
        {
            Console.WriteLine("Loading: File {0}... (base class) ", fileName);
        }
    }
}
