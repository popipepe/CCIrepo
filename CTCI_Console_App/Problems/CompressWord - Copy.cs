using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCI_Console_App
{
    public partial class Problem
    {
        private void NoDupes()
        {
            Console.WriteLine("--Write any number separated by Coma (1,2,10,2,8,25,1,47) no parentesis--");
            String strToSplit = getString();

            String[] strToPars = strToSplit.Split(',');

            int[] ToLinkedList = new int[strToPars.Length];

            for(int i = 0; i < strToPars.Length; i++)
            {
                ToLinkedList[i] = int.Parse(strToPars[i]);
            }

            LinkedList<int> LinkedList = new LinkedList<int>(ToLinkedList);
            LinkedList = mNoDupes(LinkedList);
            Console.WriteLine("--Final List with no Dupes--");

            LinkedListNode<int> current = LinkedList.First;

            while(current != null)
            {
                Console.Write(current.Value + ",");
                current = current.Next;
            }
            FinishProblem();

        }
        private LinkedList<int> mNoDupes(LinkedList<int> linkedInts)
        {
            HashSet<int> setUniques = new HashSet<int>();

            LinkedListNode<int> current = linkedInts.First;

            while(current != null)
            {
                if(setUniques.Contains(current.Value))
                {
                    LinkedListNode<int> DeleteThis = current;
                    current = current.Next;
                    linkedInts.Remove(DeleteThis);
                }
                else
                {
                    setUniques.Add(current.Value);
                    current = current.Next;
                }
            }

            return linkedInts;
        }
    }
}
