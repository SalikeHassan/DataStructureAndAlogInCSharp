using System;

namespace DSLinkList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Link List Operation");

            int[] testCase1Data = { 10, 12, 13 };

            var linkListOperation = new LinkListOperation();

            //Add Element at tail

            for (var index = 0; index < 3; index++)
            {
                linkListOperation.CreateAndAddAtTail(testCase1Data[index]);
            }

            linkListOperation.Display();

            linkListOperation.CreateAndAddAtTail(30);

            linkListOperation.CreateAndAddAtHead(1);

            Console.WriteLine("Link List After Data Added At Head and Tail");
            linkListOperation.Display();

            Console.WriteLine("");
            //linkListOperation.DeleteAtTail();
            //linkListOperation.Display();
            linkListOperation.DeleteAtIndex(3);
            linkListOperation.Display();
            Console.ReadKey();
        }
    }
}

/// <summary>
/// Link List Node Data Structure
/// </summary>
internal class Node
{
    internal int data;
    internal Node next;
}


/// <summary>
/// Basic Operation of Link List
/// </summary>
internal class LinkListOperation
{
    Node first, last = null;
    private int count = 0;
    internal void CreateAndAddAtHead(int data)
    {
        if (this.first == null)
        {
            this.first = new Node();
            this.first.data = data;
            this.first.next = null;
        }

        else
        {
            var newNode = new Node();
            newNode.data = data;
            newNode.next = this.first;
            this.first = newNode;
        }
        this.count++;
    }

    internal void CreateAndAddAtTail(int data)
    {
        if (this.first == null)
        {
            this.first = new Node();
            this.first.data = data;
            this.first.next = null;

            this.last = this.first;
        }

        else
        {
            var newNode = new Node();
            newNode.data = data;
            newNode.next = null;
            this.last.next = newNode;
            this.last = newNode;
        }
        this.count++;
    }

    internal void Display()
    {
        var traverse = this.first;
        while (traverse != null)
        {
            Console.Write(traverse.data);
            Console.Write(",");
            traverse = traverse.next;
        }
    }

    internal void DeleteAtTail()
    {
        var temp = this.first;
        for (var index = 1; index <= this.count; index++)
        {
            if (index == this.count - 1)
            {
                this.first.next = null;
                break;
            }

            else
            {
                this.first = this.first.next;
            }
        }

        this.first = temp;
    }

    internal void AddAtIndex() { }

    internal void DeleteAtIndex(int delIndex)
    {
        var temp = this.first;
        Node delAfterNode = null;

        var index = 1;
        while (index <= this.count && delIndex <= this.count)
        {
            if (index == delIndex + 1)
            {
                delAfterNode = this.first;
                break;
            }
            index++;
            this.first = this.first.next;
        }
     
        this.first.next = delAfterNode;

        this.first = temp;
    }
}