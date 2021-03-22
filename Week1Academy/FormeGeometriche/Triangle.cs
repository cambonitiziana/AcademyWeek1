using System;
using System.Collections.Generic;
using System.Text;

namespace Week1Academy.FormeGeometriche
{
    public class Triangle : geometricShapes
    {
        public double a { get; set; }
        public double b { get; set; }


        public Triangle() 
        {
            name = "Triangle";
        }
        public override double Area()
        {
            return ((a * b) / 2d);
        }

        public override void DisplayShape()
        {

            Console.WriteLine($"Forma {name}\t Base: {a}\t Altezza: {b}\t Area: {Area()}");
        }

        public override void SaveToFile(string fileName)
        {
            Console.WriteLine("Saving triangle file: {0}  ", fileName);
        }
        public override void LoadFromFile(string fileName)
        {
            Console.WriteLine("Loading triangle file: {0} ", fileName);
        }

    }
    
}
