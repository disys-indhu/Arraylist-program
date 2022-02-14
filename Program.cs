using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class ArrayListOperation
{
    public static void Main(string[] args)
    {
        ArrayList a1 = new ArrayList();
        ArrayList a2 = new ArrayList();
        string str, st;
        Console.Write("Initial size of a1:" + a1.Count);
        Console.Write("\n");
        a1.Add("Chennai\n");
        a1.Add("Coimbatore\n");
        a1.Add("Calcutta\n");
        a1.Add("Bangalore\n");
        a1.Add("Tirunelveli\n");
        Console.Write("Size of a1 after insertions:" + a1.Count);
        Console.Write("\n");
        Console.Write("Contents of a1:\n");
        Console.Write(a1[0]);
        Console.Write(a1[1]);
        Console.Write(a1[2]);
        Console.Write(a1[3]);
        Console.Write(a1[4]);
        Console.Write("Add Madurai at the end of the list\n");
        a1.Add("Madurai");
        Console.Write("Size of a1:" + a1.Count);
        Console.Write("\n");
        Console.Write(a1[0]);
        Console.Write(a1[1]);
        Console.Write(a1[2]);
        Console.Write(a1[3]);
        Console.Write(a1[4]);
        Console.Write(a1[5]);
        Console.Write("\n");
        Console.Write("Add Trichy at index position 3");
        Console.Write("\n");
        a1.Insert(3, "Trichy");
        Console.Write("Size of a1:" + a1.Count);
        Console.Write("\n");
        Console.Write(a1[0]);
        Console.Write(a1[1]);
        Console.Write(a1[2]);
        Console.Write(a1[3]);
        Console.Write("\n");
        Console.Write(a1[4]);
        Console.Write(a1[5]);
        Console.Write(a1[6]);
        Console.Write("\n");
        Console.Write("Search Erode\n");
        if (a1.Contains("Erode"))
        {
            Console.Write("Contents of a1:" + a1);
        }
        else
        {
            Console.Write("Element not found\n");
        }
        Console.WriteLine("Enter the starting letter to search:");
        string filterME = Console.ReadLine();
        int flag = 0;
        foreach (string s in a2)
        {
            if (s.Contains(filterME))
            {
                flag++;
            }
        }
        if (flag >= 1)
        {
            Console.WriteLine("Element found");
        }
        else
        {
            Console.WriteLine("Element not found");
        }
    }
}
