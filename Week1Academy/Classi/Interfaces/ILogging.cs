using System;
using System.Collections.Generic;
using System.Text;

namespace Week1Academy.Classi.Interfaces
{
    public interface ILogging
    {
        //metodi che devono essere implementati 
        void LogInfo(string message);

        void LogWarning(string message);

        void LogError(string message);
    }
}
