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

        private void Add(int value)
        {
            Node aux = new Node(value);

            if (head == null)
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
        public Node GetAt(int pos)
        {
            if (IsEmpty() || pos>=Size)
            {
                return null;
            }

            int i = 0;
            Node current = head;
            while(current != null)
            {
                if(i == pos)
                {
                    return current;
                }
                i++;
                current = current.Next;
            }
            return null;
        }
        private bool DeleteFirst()
        {
            if (head == null)
            {
                return false;
            }
            Node current = head;
            head = current.Next;
            current.Next = null;
            size--;
            return true;
        }

        private bool DeleteLast()
        {
            if (head == null) { return false; }
            if (size == 1) { return DeleteFirst(); }

            Node aux = GetAt(Size - 2);
            aux.Next = null;
            tail = aux;
            size--;
            return true;
        }

        private bool DeleteAt(int pos)
        //vaya marcus te dejo esta webada ya ready para que solo hagas el coso de k y dejar ganador
        {
            if (head == null || pos > size || pos<0)
            {
                return false;
            }

            if (pos == size-1) //borrar el ultimo
            {
                return DeleteLast();
            }

            if (pos == 0) //borrar el primero
            {
                return DeleteFirst();
            }

            Node aux = GetAt(pos-1);
            Node deleted = aux.Next;
            aux.Next = deleted.Next;
            deleted = null;
            size--;
            return false;
        }

    }
}
