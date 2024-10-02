using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class arsenal
    {
        public static void Arsenal()
        {
            string[] frames = new string[5];

            frames[0] = "XAKU";
            frames[1] = "VORUNA";
            frames[2] = "STYANAX";
            frames[3] = "DANTE";

            string[] guns = { "IGNIS", "BASMU", "CEDO", "BUBONICO" };

            Console.WriteLine("WARFRAME: " + frames[0]);
            Console.WriteLine("PRIMARY: " + guns[2]);



        }

        public static void random()
        {
            string[] frames = new string[5];
            string[] guns = new string[5];

            Console.WriteLine("WARFRAME: {0}" + frames[0]);
            Console.WriteLine("PRIMARY: {0}" + guns[2]);
        
        
        }


    }
}
