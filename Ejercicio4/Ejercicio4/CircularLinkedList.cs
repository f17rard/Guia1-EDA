using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio4
{
    internal class CircularGame
    {
        private Node? head;
        private Node? tail;
        private int size;
        public int Size
        {
            get { return size; }
            set { size = value; }
        }

         public void Add(int value)
        {
            Node aux = new Node(value);

            if (this.head == null)
            {
                head = tail = aux;
                tail.Next = head;
                Size++;
                return;
            }

            //si ya habia nodo
            tail.Next = aux;
            aux.Next = head;
            tail = aux;
            Size++;
        }
        public void Remain()
        {
            if (head == null)
            {
                Console.WriteLine("La lista no tiene nada vo");
                return;
            }
            Node? current = head;
            do
            {
                Console.Write("J"+ current.Data + " -> ");
                current = current.Next;
            }while (current != head);
        }
        
        public void insertion(int n)
        {
            for(int i = 1; i<n+1; i++)
            {
                Add(i);
            }
        }
    }
}
