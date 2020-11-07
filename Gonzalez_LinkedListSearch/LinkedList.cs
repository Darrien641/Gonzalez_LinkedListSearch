using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Gonzalez_LinkedListSearch
{
    class LinkedList
    {
        private Node head;
        private Node tail;
       

        public Node Add(MetaData mdata)
        {
           
            if (head == null)
            {
              
                head = new Node(mdata);
                tail = head;
                return head;
            }
            Node current = head;
            
            while (current != null)
            {
                Node next = current.Next;

                if (next == null)
                {
                    if (current.MData.GetName().CompareTo(mdata.GetName()) > 0)
                    {
                        Node temp = new Node(mdata);
                        temp.Next = head;
                        head = temp;
                        return temp;
                    }
                    else
                    {
                        tail.Next = new Node(mdata);
                        tail.Next.Prev = tail;
                        tail = tail.Next;
                        return tail;
                    }
                }

                if (current.MData.GetName().CompareTo(mdata.GetName()) > 0)
                {
                    Node temp = new Node(mdata);
                    temp.Next = head;
                    head = temp;
                    return temp;
                }
                
                if (current.MData.GetName().CompareTo(mdata.GetName()) < 0 && next.MData.GetName().CompareTo(mdata.GetName()) >= 0)
                {
                    current.Next = new Node(mdata);
                    current.Next.Prev = current;
                    current.Next.Next = next;
                    next.Prev = current.Next;
                    return current.Next;
                }
                
                current = current.Next;
            }
            
            return null;
        }
        public string Print()
        {
            Node current = head;
            
            StringBuilder sb = new StringBuilder();
            while (current != null)
            {
                MetaData tempMdata = current.MData;
                sb.Append($"{tempMdata.GetName()}, " +
                    $"{tempMdata.GetGender()}, " +
                    $"{tempMdata.GetRank()}\n");
                current = current.Next;
            }
            return sb.ToString();
        }

        public Node Search(string name)
        {
            // stopwatch to time Search function
            
            Node current = head;
            
            while (current != null)
            {
                string currentName = current.MData.GetName();
                if (current == null)
                {
                    return null;
                }
                if (currentName.ToLower().CompareTo(name.ToLower()) == 0)
                {

                    return current;
                }
                current = current.Next;
            }
            return null;
        }
        public Node MalePopSearch()
        {
            
            Node current = head;
            
            while (current != null)
            {
                Node Next = current.Next;
                if (current == null)
                {
                    return null;
                }
                if (Next == null) 
                {
                    return current;
                }
                if ((current.MData.GetGender() == 'M') && (current.MData.GetRank() > Next.MData.GetRank()))
                {
                    return current;
                }
                current = current.Next;
            }
            
            return null;
        }
        public Node FemalePopSearch()
        {

            Node current = head;

            while (current != null)
            {
                Node Next = current.Next;
                if (current == null)
                {
                    return null;
                }
                if (Next == null) 
                {
                    return current;
                }
                if ((current.MData.GetGender() == 'F') && (current.MData.GetRank() > Next.MData.GetRank()))
                {
                    return current;
                }
                current = current.Next;
            }

            return null;
        }



    }
}
