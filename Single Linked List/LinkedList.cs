using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
    public class LinkedList
    {
        public Node Head;
        public int Count
        {
            get { return GetCount(); }
        }


        public LinkedList() 
        {
            Head = null;
        }

        public void AddFirst(string data) 
        {
            Node newNode = new Node(data);
            newNode.Next = Head;
            Head = newNode;
        }

        public void AddLast(string data)
        {
            Node newNode = new Node(data);

            if (Head == null)
            {
                Head = newNode;
                return;
            }

            Node temporaryNode = Head;

            while (temporaryNode.Next != null)
            {
                temporaryNode = temporaryNode.Next;
            }

            temporaryNode.Next = newNode;
        }

        public void RemoveFirst()
        {
            if (Head == null) return; 
            
            Head = Head.Next;          
        }

        public void RemoveLast()
        {
            if (Head == null) return;

            if (Head.Next == null)
            {
                Head = null;
                return;
            }

            Node temporaryNode = Head;
            while (temporaryNode.Next.Next != null)
            {
                temporaryNode = temporaryNode.Next;
            }
            temporaryNode.Next = null;
        }

        public string GetValue(int index)
        {
            int count = 0;

            Node temporaryNode = Head;

            while (temporaryNode != null) 
            {
                if (count == index)
                {
                    return temporaryNode.Data;
                }

                else
                {
                    count++;
                    temporaryNode = temporaryNode.Next;
                }
            }

            return $"Node with the index: '{index}' was not found.";
        }

        public int GetCount()
        {
            int count = 0;

            Node temporaryNode = Head;

            while (temporaryNode != null)
            {
                count++;
                temporaryNode = temporaryNode.Next;
            }

            return count;
        }

        public string GetLastNode()
        {
            if (Head == null)
                return null;

            Node temporaryNode = Head;
            while (temporaryNode.Next != null)
            {
                temporaryNode = temporaryNode.Next;
            }
            return temporaryNode.Data;
        }
    }
}
