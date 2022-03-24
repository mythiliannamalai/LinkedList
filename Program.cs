using System;
namespace Datastructure
{
    class Program
    {
        static void Main()
        {
            LinkedList linkedList = new LinkedList();
            Node node1 = new Node(22);
            Node node2 = new Node(23);
            Node node3 = new Node(24);
            linkedList.AddNode(node1);
            linkedList.AddNode(node2);
            linkedList.AddNode(node3);
            linkedList.display();
            Console.WriteLine("\n Add new node in front");
            Node newNode=new Node(55);
            Node newNode2 = new Node(90);
            linkedList.AddNodeFront(newNode);
            linkedList.AddNodeFront(newNode2);
            linkedList.display();
            Console.WriteLine("\n Add new node in end");
            Node endNode = new Node(16);
            linkedList.AddNodeEnd(endNode);
            linkedList.display();
            Node newnode1=new Node(41);
            linkedList.AddNodeFrontSide(newnode1);
            linkedList.display();
            Console.WriteLine("Delete the first node");
            linkedList.DeleteNodeatFirst();
            linkedList.display();
        }
    }
}