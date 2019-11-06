using System;

namespace Linkedlist
{
    public class Node
    {
        public int data;
        public Node next;

        public Node(int i)
        {
            data = i;
            next = null;
        }

        public void print()
        {
            Console.Write(" | " + data + " |->");
            if (next != null)
            {
                next.print();
            }
        }
        public void AddtoEnd(int data)
        {
            if (next == null)
            {
                next = new Node(data);
            }
            else
            {
                next.AddtoEnd(data);
            }
        }
    }

    public class Mylist
    {
        public Node headnode;

        public Mylist()
        {
            headnode = null;
        }

        public void AddtoEnd(int data)
        {
            if (headnode == null)
            {
                headnode = new Node(data);
            }
            else
            {
                headnode.AddtoEnd(data);
            }
        }
        public void AddtoBeginning(int data)
        {
            if(headnode == null)
            {
                headnode = new Node(data);
            }
            else
            {
                Node temp = new Node(data);
                temp.next = headnode;
                headnode = temp;

            }
        }
        public void print()
        {
            if (headnode != null)
            {
                headnode.print();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Node myNode = new Node(1);
            myNode.next = new Node(2);
            myNode.next.next = new Node(3);
            myNode.next.next.next = new Node(4);
            myNode.AddtoEnd(5);
            myNode.AddtoEnd(6);
            myNode.AddtoEnd(7);
            myNode.AddtoEnd(8);
            myNode.print();

            Mylist list = new Mylist();
            list.AddtoEnd(9);
            list.AddtoEnd(10);
            list.AddtoEnd(11);
            list.AddtoEnd(12);
            list.AddtoBeginning(13);
            list.AddtoBeginning(14);
            list.AddtoBeginning(15);
            list.AddtoBeginning(16);
            list.print();







        }
    }
}
