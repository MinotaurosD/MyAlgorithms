using System;

/// <summary>
/// 单向链表
/// </summary>
public class LinkedList<T>
{
    public class Node
    {
        public T Item;
        public Node Next;
    }

    public void AddNodeAtBegin(T item)
    {
        if (First == null)
        {
            First = new Node { Item = item };
        }
        else
        {
            Node node = new Node { Item = item, Next = First };
            First = node;
        }
    }

    public T DeleteNodeAtBegin()
    {
        if (First != null)
        {
            T result = First.Item;
            First = First.Next;
            return result;
        }

        return default;
    }

    public void AddNodeAtEnd(T item)
    {
        if (Last == null)
        {
            AddNodeAtBegin(item);
        }
        else
        {
            Node node = new Node { Item = item };
            Last.Next = node;
            Last = node;
        }
    }

    public T DeleteNodeAtEnd()
    {
        if (Last != null)
        {
            for (Node node = First; node.Next != null; node = node.Next)
            {
                if (node.Next == Last)
                {
                    T result = Last.Item;
                    Last = node;
                    return result;
                }
            }
        }

        return default;
    }

    private Node first;
    private Node last;
    public Node First
    {
        get => first;
        set
        {
            first = value;
            if (last == null)
            {
                Last = first;
            }
        }
    }
    public Node Last
    {
        get => last;
        set
        {
            last = value;
            last.Next = null;
        }
    }
}