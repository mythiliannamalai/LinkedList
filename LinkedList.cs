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
        public void AddingSpacifiedNode(Node node3,Node node6)
        {
            Head.next = node6;
            node6.next = node3;
        }
        public void DeleteNodeatFirst()
        {
            if (this.Head == null)
            {
                Console.WriteLine("Nothing to delete list is empty");
            }
            Node temp = this.Head;
            this.Head = this.Head.next;
            Console.WriteLine("\nRemoved from linkedlist");
        }
        public void DeleteNodeatEnd(Node node1)
        {
            node1.next = Tail;
            Tail.next = null;
            Console.WriteLine("\nRemoved from linkedlist");
        }
        public bool search(int data)
        {
           
            Node temp = this.Head;
            while (temp != null)
            {
                if (temp.data == data)
                {
                    return true;
                }
                temp = temp.next;
            }
            return false;
        }
        public void DeleteBetweenNode(Node node2)
        {
            Head.next= node2;
            node2 = node2.next;
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