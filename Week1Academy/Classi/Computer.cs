using System;
using System.Collections.Generic;
using System.Text;
using Week1Academy.Classi.Interfaces;

namespace Week1Academy.Classi
{
    public class Computer : ILogging
    {
        //
        public string Model { get; set; }

       

        //metodi
        public void LogError(string message)
        {
            Console.WriteLine("[ERROR] {0} (C)", message);
        }

        public void LogInfo(string message)
        {
            Console.WriteLine("[INFO] {0} (C)", message);
        }

        public void LogWarning(string message)
        {
            Console.WriteLine("[WARNING] {0} (C)", message);
        }
        
    }
}
