using System;
namespace Datastructure
{
    class Program
    {
        static void Main()
        {
            LinkedList linkedList = new LinkedList();
            Node node1 = new Node(56);
            Node node2 = new Node(30);
            Node node3 = new Node(70);
            linkedList.AddNode(node1);
            linkedList.AddNode(node2);
            linkedList.AddNode(node3);
            linkedList.display();
            Node node4=new Node(50);
            linkedList.addNodeEnd(node4);
            linkedList.display();
            Console.WriteLine("\nAdding node at starting");
            Node node5 = new Node(40);
            linkedList.AddNodeFrontSide(node5);
            linkedList.display();
        }
    }
}