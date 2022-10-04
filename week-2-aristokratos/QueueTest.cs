using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK2ASSIGNMENT
{
    internal class QUEUE
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
        public class Myqueue<T>
        {
            Node<T> head;
            T Value;
            int size = 0;


            public void MyQueue(T value)
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

            public void Dequeue()
            {
                var checkList = IsEmpty();
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
                size--;
            }
            public int Size()
            {
                return size;
            }
        }
    }
}
