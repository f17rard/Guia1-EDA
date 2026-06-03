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

        public void Start(int k)
        {
            if (IsEmpty())
            {
                Console.WriteLine("No hay jugadores para iniciar el juego.");
                return;
            }

            DeleteRecursive(head!, k);
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

        public bool IsEmpty()
        {
            if (head == null)
            {
                return true;
            }
            else
            {
                return false;
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

        private void DeleteRecursive(Node origin, int k)
        {
            if (size == 1)
            {
                Console.WriteLine($"El ganador es el jugador {head.Data}");
                return;
            }

            Node previous = origin;
            for (int i = 1; i < k; i++)
            {
                previous = previous.Next!;
            }

            Node deleted = previous.Next!;
            Node next = deleted.Next!;
            Console.WriteLine($"Jugador eliminado: {deleted.Data}");
            
            previous.Next = next;

            if (deleted == head)
            {
                head = next;
            }
            if (deleted == tail)
            {
                tail = previous;
            }
            size--;

            Console.WriteLine($"Jugadores restantes: ");
            Remain();
            Console.WriteLine();

            DeleteRecursive(next, k);
        }

    }
}
