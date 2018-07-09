using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCI_Console_App
{
    public partial class Problem
    {
        private void WhereIsLoop()
        {
            Console.WriteLine("--Problem Started (no input)--");

            int[] toList = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            NodeForLoop Before = null;
            NodeForLoop toLoop = null;
            int indexToLoop = 7;
            LinkedListWithLoop head = new LinkedListWithLoop();
            for(int i = 0; i < toList.Length; i++)
            {

                NodeForLoop node = new NodeForLoop(toList[i], null);
                if(i == 0)
                {
                    head.head = node;
                }
                else
                {
                    Before.next = node;
                }
                Before = node;
                if(indexToLoop == i)
                {
                    toLoop = node;
                }
            }
            Before.next = toLoop;

            mWhereIsLoop(head);
            FinishProblem();

        }
        private void mWhereIsLoop(LinkedListWithLoop first)
        {
            NodeForLoop fast = first.head.next, slow = first.head;

            while(!slow.Equals(fast))
            {
                Console.WriteLine("Value: " + fast.values);
                fast = fast.next.next;
                slow = slow.next;
            }
            Console.WriteLine("Loop Found in: " + fast.values);
        }
        internal partial class LinkedListWithLoop
        {
            public NodeForLoop head;
        }
        internal partial class NodeForLoop
        {
            public NodeForLoop next;
            public int values;

            public NodeForLoop(int value, NodeForLoop Next)
            {
                next = Next;
                values = value;
            }
        }
    }
}
