﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
    public class SingleLinkedListClass
    {
        public Node head;

        public void insertFirst(int newElement)
        {
            Node newNode = new Node(0);
            newNode.data = newElement;
            newNode.next = head;
            head = newNode;
        }
        public void insertLast(int newElement)
        {

            Node newNode = new Node(0);
            newNode.data = newElement;
            newNode.next = null;
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node temp = new Node(0);
                temp = head;
                while (temp.next != null)
                    temp = temp.next;
                temp.next = newNode;
            }
        }
        public int countNodes()
        {
            Node temp = new Node(0);
            temp = this.head;
            int i = 0;
            while (temp != null)
            {
                i++;
                temp = temp.next;
            }

            Console.WriteLine(i);
            return i;
        }

        public void printList()
        {
            Node n = head;
            while (n != null)
            {
                Console.Write(n.data + " ");
                n = n.next;
            }
        }

        public Node GetNode(int data)
        {
            Node temp = new Node(0);
            temp = this.head;
            int found = 0;
            int i = 0;
            if (temp != null)
            {
                while (temp != null)
                {
                    i++;
                    if (temp.data == data)
                    {
                        found++;
                        break;
                    }
                    temp = temp.next;
                }
                if (found == 1)
                {
                    return temp;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
        public void Delete(Node value)
        {
            if (head == null) return;

            if (head.data == value.data)
            {
                head = head.next;
                return;
            }

            var n = head;
            while (n.next != null)
            {
                if (n.next.data == value.data)
                {
                    n.next = n.next.next;
                    return;
                }
                n = n.next;
            }
        }

        public void InsertAfter(Node insertafter, int new_data)
        {
            if (InsertAfter == null)
            {
                Console.WriteLine("Diese Node existiert nicht");
                return;
            }
            Node new_node = new Node(new_data);
            new_node.next = insertafter.next;
            insertafter.next = new_node;
        }
        public int GetNode_at_Position(int position)
        {
            Node current = head;
            int count = 0; 
            while (current != null)
            {
                if (count == position)
                    return current.data;
                count++;
                current = current.next;
            }


            return 0;
        }

    }
}

        
    
