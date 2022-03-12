using System;

namespace DSLinkList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Link List Operation");

            int[] testCase1Data = { 10, 12, 13 };

            var dataAtTail = 1;
            var dataAtHead = 30;

            var linkListOperation = new LinkListOperation();

            //Add Element at tail

            for (var index = 0; index < 3; index++)
            {
                linkListOperation.CreateAndAddAtTail(testCase1Data[index]);
            }

            linkListOperation.Display();

            linkListOperation.CreateAndAddAtTail(dataAtHead);

            linkListOperation.CreateAndAddAtHead(dataAtTail);

            Console.WriteLine("Link List After Data Added At Head and Tail");
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
    }

    internal void Display()
    {
        var traverse = this.first;
        while (traverse != null)
        {
            Console.WriteLine(traverse.data);
            traverse = traverse.next;
        }
    }

    internal void DeleteAtTail() { }

    internal void AddAtIndex() { }

    internal void DeleteAtIndex(int index) { }
}