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
        public bool listEmpty()
        {
            if (LAST == null)
                return true;
            else
                return false;
        }
    }
}