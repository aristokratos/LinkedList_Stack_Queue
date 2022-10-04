using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_2_aristokratos
{
    class program
    {
        public static void Main()
        {
            Console.WriteLine("Start Linked List");
            LinkedListTask<int> list = new LinkedListTask<int>();
            Console.WriteLine(list.IsListEmpty());

            list.AddToTail(16);
            list.AddToTail(19);
            list.AddToTail(29);
            list.AddToTail(19);
            list.AddToTail(18);
            list.AddToTail(19);
            list.AddToTail(20);
            list.RemoveLast();
            list.RemoveFirst();

            Console.WriteLine("Is List Empty?");
            Console.WriteLine(list.IsListEmpty());

            list.PrintList();

        }
    }
    class Node<T>
    {
        public T value;
        public Node<T> Next;

        public Node(T value)
        {
            this.value = value;
            Next = null;
        }
    }
    public class LinkedListTask<T>
    {
        Node<T> head;
        T Value;
        int size = 0;


        public void AddToTail(T value)
        {
            if (head == null)
            {
                head = new Node<T>(value);
                size++;
                return;
            }
            Node<T> current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = new Node<T>(value);
            size++;
        }

        public bool IsListEmpty()
        {
            return head == null;
        }
        public void PrintList()
        {
            Node<T> current = head;
            while (current != null)
            {
                Console.Write(current.value + "-->");
                current = current.Next;
            }

        }


        public void RemoveFirst()
        {
            var checkList = IsListEmpty();
            if (checkList)
            {
                Console.WriteLine("Empty List....");
                return;
            }
            if (head.Next == null)
            {
                head = null;
            }
            Node<T> current = head.Next;
            head = current;
        }


        public void RemoveLast()
        {
            var cheackList = IsListEmpty();
            if (cheackList)
            {
                Console.Write("Empty list.....");
                return;
            }
            Node<T> current = head;
            while (current.Next.Next != null)
            {
                current = current.Next;
            }
            current.Next = null;
        }

    }

}
