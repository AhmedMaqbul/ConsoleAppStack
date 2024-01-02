using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStackInLinkedListForm
{
    public class MyLinkedStack
    {
        public Node Head;

        public bool IsEmpty()
        { 
            return Head == null; 
        }

        public void Push(int data) //insertion of new element
        {
            Node newNode = new Node(data);
            if(IsEmpty())
            {
                Head = newNode;
                return;
            }
            newNode.Next = Head;
            Head = newNode;
        }

        public int Pop() //deletion of exiting element from top/peek
        {
            if(IsEmpty())
                return -1;

            int top = Head.Data;
            Head = Head.Next;
            return top;
        }

        public int Peek()
        {
            if (IsEmpty())
                return -1;

            return Head.Data;
        }
    }
}
