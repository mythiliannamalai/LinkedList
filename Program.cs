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
            Console.WriteLine("\nAdding spacified number");
            Node node6=new Node(80);
            linkedList.AddingSpacifiedNode(node3,node6);
            linkedList.display();
            linkedList.DeleteNodeatFirst();
            linkedList.display();
            linkedList.DeleteNodeatEnd(node1);
            linkedList.display();
            Console.WriteLine("\nEnter the number want to search");
            int data = int.Parse(Console.ReadLine());
            bool res = linkedList.search(data);
            if (res == true)
            {
                Console.WriteLine("data is found");
            }
            else
            {
                Console.WriteLine("data is not found");
            }
            Console.WriteLine("\nDelete in between number");
            linkedList.DeleteBetweenNode(node2);
            linkedList.display();
            Stack stack = new Stack();
            stack.push(node1);
            stack.push(node2);
            stack.push(node3);
            stack.displayStack();
            stack.Top();
            stack.displayStack();
        }
    }
}