using System;

/// <summary>
/// 单向链表
/// </summary>
public class LinkedList<T>
{
    /// <summary>
    /// 节点数据类型
    /// </summary>
    public class Node
    {
        public T Item;
        public Node Next;
    }

    /// <summary>
    /// 在链表开始处插入节点
    /// </summary>
    /// <param name="item"></param>
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

    /// <summary>
    /// 在链表开始处删除节点
    /// </summary>
    /// <returns></returns>
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

    /// <summary>
    /// 在链表结尾处插入节点
    /// </summary>
    /// <param name="item"></param>
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

    /// <summary>
    /// 在链表结尾处删除节点
    /// </summary>
    /// <returns></returns>
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
    /// <summary>
    /// 首节点
    /// </summary>
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
    /// <summary>
    /// 尾结点
    /// </summary>
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