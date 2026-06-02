using System;
using System.Collections.Generic;

List<int> ListA = new List<int>();
ListA.Add(1);
ListA.Add(3);
ListA.Add(5);
ListA.Add(7);
ListA.Add(12);

List<int> ListB = new List<int>();
ListB.Add(2);
ListB.Add(3);
ListB.Add(7);
ListB.Add(9);
ListB.Add(10);

PrintList(ListA, "Lista A");
PrintList(ListB, "Lista B");

List<int> merged = MergeSortedLists(ListA, ListB);
PrintList(merged, "Lista Fusionada");

List<int> mergedNoDuplicates = MergeSortedListsNoDuplicates(ListA, ListB);
PrintList(mergedNoDuplicates, "Lista Fusionada Sin Duplicados");

Console.ReadKey();

static List<int> MergeSortedLists(List<int> ListA, List<int> ListB)
{
    List<int> result = new List<int>();
    int i = 0;
    int j = 0;

    while (i < ListA.Count && j < ListB.Count)
    {
        if (ListA[i] <= ListB[j])
        {
            result.Add(ListA[i]);
            i++;
        }
        else
        {
            result.Add(ListB[j]);
            j++;}
    }

    while (i < ListA.Count)
    {
        result.Add(ListA[i]);
        i++;
    }

    while (j < ListB.Count)
    {
        result.Add(ListB[j]);
        j++;
    }

    return result;
}

static List<int> MergeSortedListsNoDuplicates(List<int> ListA, List<int> ListB)
{
    List<int> result = new List<int>();
    int i = 0;
    int j = 0;
    while (i < ListA.Count && j < ListB.Count)
    {
        if (ListA[i] < ListB[j])
        {
            result.Add(ListA[i]);
            i++;
        }
        else if (ListA[i] == ListB[j])
        {
            result.Add(ListA[i]);
            i++;
            j++;
        }
        else
        {
            result.Add(ListB[j]);
            j++;
        }
    }

    if (ListA.Count > ListB.Count)
    {
        while (i < ListA.Count)
        {
            result.Add(ListA[i]);
            i++;
        }
    }
    else
    {
        while (j < ListB.Count)
        {
            result.Add(ListB[j]);
            j++;
        }
    }
    return result;
}

static void PrintList(List<int> list, string label)
{
    Console.WriteLine(label + ":");
    Console.Write("[ ");

    for (int i = 0; i < list.Count; i++)
    {
        Console.Write(list[i]);
        if (i < list.Count - 1)
        {
            Console.Write(", ");
        }
    }

    Console.WriteLine(" ]");
}