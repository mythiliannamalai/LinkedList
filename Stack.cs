using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure
{
    internal class Stack
    {
        LinkedList linkedList;
        public Stack()
        {
            linkedList = new LinkedList();
        }
        public void push(Node node)
        {
            linkedList.AddNode(node);
        }
        public void displayStack()
        {
            Console.WriteLine("\n\nStack");
            linkedList.Stackdisplay();
        }
        
    }
}
