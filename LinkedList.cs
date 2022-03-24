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
        public void AddNodeFront(Node newNode)
        {
            newNode.next = Head;
            Head = newNode;
        }
        public void AddNodeEnd(Node endNode)
        {
            endNode.next = Tail;
            Tail = endNode;
        }
        public void AddNodeFrontSide(Node newNode1)
        {
            newNode1.next = Head;
            Head = newNode1;
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
                Console.WriteLine("Linked list as follows : ");
                while (temp != null)
                {
                    Console.Write(temp.data);
                    if (temp.next != null)
                    {
                        Console.Write("->");
                    }
                    temp = temp.next;                                  
                }
                Node temp2 = Tail;
                while (temp2 != null)
                {
                    if (temp2 != null)
                    {
                        Console.Write("->");
                        Console.Write(temp2.data);
                        temp2 = temp2.next;
                    }
                }
            }
        }
    }
}