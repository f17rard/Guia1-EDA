List<int> ListA = new List<int>();
ListA.Add(1);
ListA.Add(2);
ListA.Add(3);
ListA.Add(4);
ListA.Add(5);

PrintList(ListA, "lista A");
ReverseList(ListA, "Lista A reversa");

static void PrintList(List<int> list, string label)
{
    Console.Write(label + ": [ ");

    for (int i = 0; i < list.Count; i++)
    {
        Console.Write(list[i]);
        if (i < list.Count - 1) Console.Write(", ");
    }

    Console.Write(" ] ");
}

static void ReverseList(List<int> list, string label)
{
    Console.Write(label + ": [ ");

    for (int i = list.Count - 1; i >= 0; i--)
    {
        Console.Write(list[i]);
        if (i > 0) Console.Write(", ");
    }

    Console.Write(" ] ");
}
