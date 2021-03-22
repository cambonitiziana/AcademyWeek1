using System;
using System.Collections.Generic;
using System.Text;

namespace Week1Academy.Classi.Interfaces
{
   public interface IFileSerializable
    {
        void SaveToFile(string fileName);

        void LoadFromFile(string fileName);
    }
}
