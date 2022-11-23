using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseLinkedList_A_149
{
    class Node
    {
        /*Nodes class for the circular nexted list*/
        public int rollNumber;
        public string name;
        public Node next;
        public Node prev;
    }
    class CircularList
    {
        Node LAST;
        public CircularList()
        {
            LAST = null;
        }
        public bool Search(int rollNo, ref Node previous, ref Node current) /*search for the specified node*/
        {
            for (previous = current = LAST.next; current != LAST; previous = current, previous = previous.next)
            {
                if (rollNo == current.rollNumber)
                    return true; /*returns true if the node is found*/
            }
            if (rollNo == LAST.rollNumber) /*if the node is present at the end*/
                return true;
            else
                return false; /*returns false if the node is not found*/
        }
        public void traverse() /*traverse all nodes of the list*/
        {
            if (listEmpty())
                Console.WriteLine("\nList is empty");
            else
            {
                Console.WriteLine("\nRecords in the list are:\n");
                Node currentNode;
                currentNode = LAST.next;
                while (currentNode != LAST)
                {
                    Console.Write(currentNode.rollNumber + "  " + currentNode.name + "\n");
                    currentNode = currentNode.next;
                }
                Console.Write(LAST.rollNumber + "  " + LAST.name + "\n");
            }
        }
        public void firstNode()
        {
            if (listEmpty())
                Console.WriteLine("\nList is empty");
            else
                Console.WriteLine("\nThe first record in the list is: \n\n " + LAST.next.rollNumber + "  " + LAST.next.name);
        }
        public bool listEmpty()
        {
            if (LAST == null)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            CircularList obj = new CircularList();
            while (true)
            {

            }
        }
    }
}