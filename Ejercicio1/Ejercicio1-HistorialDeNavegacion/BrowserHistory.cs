namespace Ejercicio1_HistorialDeNavegacion;

public class BrowserHistory
{
    private HistoryNode? head;
    private HistoryNode? tail;
    private HistoryNode? current;
    private int size;

    public BrowserHistory()
    {
        head = tail = current = null;
        size = 0;
    }

    public HistoryNode? Current
    {
        // Lectura desde fuera
        get { return current; }
    }

    public int Size
    {
        get { return size; }
    }

    public void VisitPage(string url)
    {
        HistoryNode newNode = new HistoryNode(url);

        if (head == null)
        {
            head = newNode;
            tail = newNode;
            current = newNode;
        }
        else
        {
            current.NextNode = newNode;
            newNode.PreviousNode = current;
            tail = newNode;
            current = newNode;
        }

        size++;
    }

    public string GoBack()
    {
        if (current.PreviousNode != null)
        {
            current = current.PreviousNode;
            return current.Url;
        }
        else
        {
            return "No hay paginas anteriores.";
        }
    }

    public string GoForward()
    {
        if (current.NextNode != null)
        {
            current = current.NextNode;
            return current.Url;
        }
        else if (current.NextNode == tail)
        {
            return current.Url;
        }
        else
        {
            return "No hay paginas siguientes.";
        }
    }

    public void PrintHistory()
    {
        if (head == null)
        {
            Console.WriteLine("No hay historial de navegación.");
            return;
        }

        Console.WriteLine("=== Historial de Navegación ===");

        HistoryNode pointer = head;

        while (pointer != null)
        {
            if (pointer == current)
            {
                Console.WriteLine($" >>> {pointer.Url} (Actual)");
            }
            else
            {
                Console.WriteLine($"    {pointer.Url}");
            }
            pointer = pointer.NextNode;
        }

        Console.WriteLine("==============================");
    }

    public void ClearForward()
    {
        if (current != null && current.NextNode != null)
        {
            HistoryNode pointer = current.NextNode;
            while (pointer != null)
            {
                HistoryNode nextPointer = pointer.NextNode;
                pointer.PreviousNode = null;
                pointer.NextNode = null;
                pointer = nextPointer;
                size--;
            }
            current.NextNode = null;
            tail = current;
        }
    }

}
