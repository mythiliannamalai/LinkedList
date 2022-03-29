using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure
{
    public class LinkedList
    {
        public Node Head;
        public Node Tail;
        public LinkedList()
        {
            Head = null;
            Tail = null;
        }
        public void AddNode(Node node)
        {                        
            if (Head == null && Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                node.next = Head;
                Head = node;              
            }
        }
        public void addNodeEnd(Node node4)
        {
            Console.WriteLine("\n Add element at end");
            Tail.next = node4;
            Node temp2 = Tail;
            temp2 = temp2.next;
        }
        public void AddNodeFrontSide(Node node5)
        {
            node5.next = Head;
            Head = node5;
        }
        public void display()
        {
            Node temp = Head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
            }
            else
            {                
                while (temp!= null)
                {
                    Console.Write(temp.data);
                    if (temp.next != null)
                    {                       
                        Console.Write("->");
                    }
                    temp = temp.next;
                }
            }           
        }
    }
}