using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK2ASSIGNMENT
{
    internal class STACK
    {
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
        public class MyLinkedList<T>
        {
            Node<T> head;
            T Value;
            int size = 0;


            public void Push(T value)
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

            public void PrintList()
            {
                Node<T> current = head;
                while (current != null)
                {
                    Console.Write(current.value + "-->");
                    current = current.Next;
                }

            }
            public bool IsEmpty()
            {
                return head == null;
            }

            public void Pop()
            {
                var checkList = IsEmpty();
                if (checkList)
                {
                    Console.WriteLine("Empty List....");
                    return;
                }
                Node<T> current = head;
                while (current.Next.Next != null)
                {
                    current = current.Next;
                }
                current.Next = null;
                size--;
            }

            public int Size()
            {
                return size;
            }

            public T Peek()
            {
                Node<T> current = head;
                while (current.Next != null)
                {
                    current = current.Next;

                }
                return current.value;
            }

        }
    }
}
