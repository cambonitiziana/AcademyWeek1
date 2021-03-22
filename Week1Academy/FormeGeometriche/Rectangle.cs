using System;
using System.Collections.Generic;
using System.Text;

namespace Week1Academy.FormeGeometriche
{
    public class Rectangle: geometricShapes
    {
        public double a { get; set; }
        public double b { get; set; }

     
       
        public override double Area()
        {
            return a * b;
        }

        public override void DisplayShape()
        {
            Console.WriteLine($"Forma {name}\t Lato A(base): {a}\t Lato B(altezza): {b}\t Area: {Area()}");
        }
        public override void SaveToFile(string fileName)
        {
            Console.WriteLine("Saving rectangle file: {0}", fileName);
        }
        public override void LoadFromFile(string fileName)
        {
            Console.WriteLine("Loading rectangle file: {0}", fileName);
        }
    }
}
