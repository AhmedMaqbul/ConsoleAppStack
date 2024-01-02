using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStackInLinkedListForm
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyLinkedStack stack = new MyLinkedStack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            while(!stack.IsEmpty())
            {
                Console.WriteLine(stack.Peek());
                stack.Pop();
            }

            Console.ReadLine();
        }
    }
}
