using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUEUES
{
    internal class Program
    {
        static void Main(string[] args)
        {
                string action = string.Empty;
                QUEUES queue = new QUEUES();

            do
            {
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("IT IS NOW YOUR TURN WIZARD WHAT SHALL YOU DO?");
                Console.WriteLine("CAST"); // Enqueue
                Console.WriteLine("REMOVE"); // Dequeue
                Console.WriteLine("STATUS"); // Count
                Console.WriteLine("STATUS CLEAR"); // Clear
                Console.WriteLine("PEEK"); // Peek
                Console.WriteLine("EXIT"); // Exit
                Console.WriteLine("------------------------------------");
                Console.Write("ACTION: ");

                action = Console.ReadLine();

                switch (action.ToUpper())
                {
                    case "CAST":
                        queue.cast();
                        break;

                    case "REMOVE":
                        queue.remove();
                        break;

                    case "STATUS":
                        queue.status();
                        break;

                    case "STATUS CLEAR":
                        queue.clear();
                        break;

                    case "PEEK":
                        queue.peek();
                        break;

                    case "EXIT":
                        Console.WriteLine("LEAVING COMBAT");
                        return;

                    default:
                        Console.WriteLine("FORBIDDEN SPELL, YOU DIED");
                        break;
                }



            } while (action != "EXIT");

            Console.WriteLine("LEAVING COMBAT");
            Console.ReadLine();
            
            
        }




    }

    //--------------------------------------------------------------------









}

