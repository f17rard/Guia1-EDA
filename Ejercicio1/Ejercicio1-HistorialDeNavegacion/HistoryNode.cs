namespace Ejercicio1_HistorialDeNavegacion;

public class HistoryNode
{
    private string url;
    private HistoryNode previousNode;
    private HistoryNode nextNode;

    public HistoryNode(string url)
    {
        this.url = url;
        previousNode = null;
        nextNode = null;
    }

    public string Url
    {
        get { return url; }
        set { url = value; }
    }

    public HistoryNode PreviousNode
    {
        get { return previousNode; }
        set { previousNode = value; }
    }

    public HistoryNode NextNode
    {
        get { return nextNode; }
        set { nextNode = value; }
    }
}
