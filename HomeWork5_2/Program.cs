using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HomeWork5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var startTimeText = $"{DateTime.Now.ToString()} - время позорного копирования";
            File.WriteAllText("startup.txt", startTimeText);
       
           

        }
    }
}
