﻿using System;
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
        }
    }
}