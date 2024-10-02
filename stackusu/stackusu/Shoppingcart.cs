using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace stackusu
{
    internal class Shoppingcart
    {     
           
        Stack<string> cart = new Stack<string>();
        Stack<string> redostack = new Stack<string>();

        public void Add(string itemName)
        {
            cart.Push(itemName);
        }

        public void Undo()
        { 
            var item = cart.Pop();
            redostack.Push(item);
        }
        
        public void Redo()
        {
            var item = redostack.Pop();
            cart.Push(item);
        }

        public void View()
        {
            foreach (var item in cart)
            {
                Console.WriteLine("\t " + item);
            }
        }
           
        

        

    }
}
