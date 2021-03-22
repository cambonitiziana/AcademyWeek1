using System;
using System.Collections.Generic;
using System.Text;
using Week1Academy.Classi.Interfaces;

namespace Week1Academy.FormeGeometriche
{
    public class Circle : geometricShapes
    {
        //proprietà
        public double r { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        //costruttore


        public override double Area()
        {

            return Math.Pow(r, 2) * Math.PI;
        }

        public override void DisplayShape()
        {

            Console.WriteLine($"Forma {name}\tRaggio.: {r}\tArea: {Area()}");
        }

        public override void SaveToFile(string fileName)
        {
            Console.WriteLine("Saving circle file: {0}  ", fileName);
        }
        public override void LoadFromFile(string fileName)
        {
            Console.WriteLine("Loading circle file: {0} ", fileName);
        }
    }
}
