using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackusu
{
    internal class Program
    {
        static Shoppingcart sc = new Shoppingcart();
        static void Main(string[] args)
        {
            int option = 0;

            while (option != 5)
            {
                Console.WriteLine("\n\t\t Menu - select an option");
                Console.WriteLine("\t\t--------------------------");
                Console.WriteLine("\t\t 1. add item");
                Console.WriteLine("\t\t 2. undo");
                Console.WriteLine("\t\t 3. redo");
                Console.WriteLine("\t\t 4. view");
                Console.WriteLine("\t\t 5. exit");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        bool repeat = true;
                        while (repeat)
                        {
                            Console.WriteLine("ENTER ITEM NAME (type n to stop)");
                            var itemName = Console.ReadLine();
                            if (itemName != "n")
                            {
                                sc.Add(itemName);
                            }
                            repeat = itemName == "n" ? false : true;
                        }
                        break;
                    //--------------------------
                    case 2:
                        sc.Undo();
                        ShowCartItems();
                        break;
                    //--------------------------
                    case 3:
                        sc.Redo();
                        ShowCartItems();
                        break;
                    //---------------------------
                    case 4:
                        ShowCartItems();
                        break;

                    case 5:
                        Environment.Exit(0);
                        break;
                    //-----------------------------
                    default:
                        Console.WriteLine("INVALID RESPONSE U MUST BE TERMINATED");
                        break;
                }

            }

            Console.Read();


        }

        public static void ShowCartItems()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\tCart Items");
            Console.WriteLine("\t--------------");
            sc.View();
            Console.WriteLine("\t--------------");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
