using System;

public class LinkedListTest
{
    public void Test1()
    {
        LinkedList<string> linkedList = new LinkedList<string>();
        linkedList.AddNodeAtBegin("are");
        linkedList.AddNodeAtBegin("what");
        linkedList.AddNodeAtEnd("you");
        linkedList.AddNodeAtEnd("doing");

        Console.WriteLine("======unroll loop start:======");
        for (LinkedList<string>.Node node = linkedList.First; node.Next != null; node = node.Next)
        {
            Console.WriteLine(node.Item);
        }
        Console.WriteLine(linkedList.Last?.Item);
        Console.WriteLine("======unroll loop end.======");

        Console.WriteLine("======delete node at begin.");
        Console.WriteLine(linkedList.DeleteNodeAtBegin());
        Console.WriteLine("======delete node at end.");
        Console.WriteLine(linkedList.DeleteNodeAtEnd());

        Console.WriteLine("======unroll loop start:======");
        for (LinkedList<string>.Node node = linkedList.First; node.Next != null; node = node.Next)
        {
            Console.WriteLine(node.Item);
        }
        Console.WriteLine(linkedList.Last?.Item);
        Console.WriteLine("======unroll loop end.======");

        Console.ReadKey();
    }
}