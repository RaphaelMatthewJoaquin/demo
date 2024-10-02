using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> frames = new List<string>();
            string reply;

            do
            {

          
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("1: ADD");
                Console.WriteLine("2: ADD RANGE");
                Console.WriteLine("3: CALL A FRAME");
                Console.WriteLine("4: COUNT");
                Console.WriteLine("5: INSERT");
                Console.WriteLine("6: REMOVE");
                Console.WriteLine("7: REMOVE RANGE");
                Console.WriteLine("8: CONTAINS");
                Console.WriteLine("9: SORT");
                Console.WriteLine("0: EXIT");
                Console.Write("REPLY: ");
                reply = Console.ReadLine();

                switch (reply)
                {
                    case "1": //add
                        Console.Write("ENTER FRAME HERE: ");
                        String add = Console.ReadLine().ToUpper();
                       
                        
                        if (frames.Contains(add))
                        {
                            Console.WriteLine("item already exists within the list");
                        }
                        else
                        {
                            frames.Add(add);
                        }

                        break;
                    //--------------------------------------------------------
                    case "2": //addrange
                        Console.WriteLine("ADD MULTIPLE FRAMES HERE");
                        string input = Console.ReadLine().ToUpper();
                        string[] newframes = input.Split(',');

                        for (int i = 0; i < newframes.Length; i++)
                        {
                            newframes[i] = newframes[i].Trim();
                        }

                        frames.AddRange(newframes);

                        Console.WriteLine("ALL DONE");

                        break;
                    //--------------------------------------------------------
                    case "3": //call an element
                        int index = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(frames[index]);
                        break;
                    //--------------------------------------------------------
                    case "4"://count
                        Console.WriteLine(frames.Count);
                        break;
                    //--------------------------------------------------------
                    case "5": //insert
                        string reply3 = Console.ReadLine().ToUpper();
                        if (reply3 == "SINGLE")
                        {
                            int ii = Convert.ToInt32(Console.ReadLine());
                            string frame = Console.ReadLine();
                            frames.Insert(ii, frame);
                        }
                        else if (reply3 == "MULTI")
                        {

                        }
                        break;
                    //--------------------------------------------------------
                    case "6": //REMOVE
                        string reply4 = Console.ReadLine().ToUpper();
                        if (frames.Contains(reply4))
                        {
                            frames.Remove(reply4);
                            
                        }
                        else
                        {
                            Console.WriteLine("THAT FRAME IS NOT IN THE LIST U TWAT");
                        }
                       
                        break;
                    //--------------------------------------------------------
                    case "7": // REMOVE RANGE
                        Console.Write("ENTER STARTING INDEX FOR REMOVAL: ");
                        int start = Convert.ToInt32(Console.ReadLine());
                        Console.Write("ENTER NUMBER OF ELEMENTS TO REMOVE: ");
                        int count = Convert.ToInt32(Console.ReadLine());

                        if (start >= 0 && start + count <= frames.Count)
                        {
                            frames.RemoveRange(start, count);
                            Console.WriteLine($"{count} frames removed successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid range for removal.");
                        }
                        break;
                    //--------------------------------------------------------
                    case "8": // CONTAINS
                        Console.Write("ENTER FRAME TO CHECK: ");
                        string checkFrame = Console.ReadLine().ToUpper();

                        if (frames.Contains(checkFrame))
                        {
                            Console.WriteLine("Frame exists in the list.");
                        }
                        else
                        {
                            Console.WriteLine("Frame does not exist in the list.");
                        }
                        break;
                    //--------------------------------------------------------
                    case "9": // SORT
                        Console.WriteLine("HOW YOU LIKE TO ARRAGE THE LIST?");
                        Console.WriteLine("1: for ascending");
                        Console.WriteLine("2: for descending");
                        int reply5 = Convert.ToInt32(Console.ReadLine());
                        
                        if (reply5 == 1)
                        {
                            frames.Sort();
                            Console.WriteLine("Frames sorted successfully.");
                        }
                        else if (reply5 == 2) 
                        { 
                            frames.Reverse();
                            Console.WriteLine("Frames sorted successfully.");
                        }
                        else
                        {
                            Console.WriteLine("INVALID RESPONSE");
                        }
                        
                        
                        break;
                    //--------------------------------------------------------
                    default:
                        Console.WriteLine("INVALID RESPONSE");
                        break;

                }

                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("BELOW IS THE CURRENT LIST");
                foreach (var war in frames)
                {
                    Console.WriteLine(war + " ");
                }
                
                

            } while (reply  != "0");



            Console.ReadLine();
            
        }
    }
}
