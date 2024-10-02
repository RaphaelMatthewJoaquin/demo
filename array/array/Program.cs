using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //arsenal.Arsenal();

            string[] frames = new string[5];

            frames[0] = "XAKU";
            frames[1] = "VORUNA";
            frames[2] = "STYANAX";
            frames[3] = "DANTE";
            frames[4] = "JADE";

            string[] guns = { "IGNIS", "BASMU", "CEDO", "BUBONICO" };

            Console.WriteLine("WARFRAME: " + frames[0]);
            Console.WriteLine("PRIMARY: " + guns[2]);

            for (int i = 0; i < 5; i++)
            {
                Console.Write(frames[i]+" ");
            }

            Console.ReadLine();
        }

        public static void test()
        {
            string[][] companion = new string[0][];

            companion[0] = new string[0];
            companion[1] = new string[0];
            companion[2] = new string[0];
            companion[3] = new string[0];


            companion[0][0] = "MATILDA";
            companion[1][0] = "MATSUKI";
            companion[2][0] = "MATTIE";


        }





    }
}
