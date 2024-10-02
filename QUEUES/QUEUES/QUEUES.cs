using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUEUES
{
    public class QUEUES
    {
        Queue<string> spells = new Queue<string>();

        public void cast()
        {
            Console.Write("CAST YOUR SPELL HERE: ");
            string spell = Console.ReadLine();
            spells.Enqueue(spell);
            Console.WriteLine("SPELL CASTED {0}", spell);

            if (spells.Contains(spell))
            {
                Console.WriteLine("YOU ALREADY CASTED THIS SPELL");
            }
        }

        public void remove()
        {
            if (spells.Count > 0)
            {
                string removedSpell = spells.Dequeue();
                Console.WriteLine("DEBUFFED: ");
            }
        }

        public void status()
        {
            Console.WriteLine($"YOU HAVE {spells.Count} SPELLS");
        }

        public void clear()
        {
            spells.Clear();
            Console.WriteLine("All spells have been cleared.");
        }

        public void peek()
        {
            if (spells.Count > 0)
            {
                Console.WriteLine($"Next spell to be cast: {spells.Peek()}");
            }   
        }
    }



}
