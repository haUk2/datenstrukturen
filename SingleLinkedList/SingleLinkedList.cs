using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
    public class SingleLinkedListClass
    {
        public Node head;
        public Node sorted;

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
            Node current = head;
            while (current != null)
            {
                if (current.data == data)
                    return current;
                current = current.next;
            }
            return null;
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
        public Node GetNode_at_Position(int position)
        {
            Node current = head;
            int count = 0; 
            while (current != null)
            {
                if (count == position)
                    return current;
                count++;
                current = current.next;
            }
            return null;
        }
        public Node GetNode_mmu(int argData)
        {
            Node current = head;
            while (current != null)
            {
                if (current.data == argData)
                    return current;
                current = current.next;
            }
            return null;
        }
        public Node SwitchNodes(Node firstnode, Node secondnode)
        {
            if (firstnode == null)
            {
                return null;
            }
            else if (secondnode == null)
            {
                return null;
            }           
            int firstnodedata = firstnode.data;
            int secondnodedata = secondnode.data;
            Node pos1 = this.head;
            Node pos2 = this.head;
            while (pos1.data != firstnodedata)
            {
                pos1 = pos1.next;
            }
            while (pos2.data != secondnodedata)
            {
                pos2 = pos2.next;
            } 
            int val = pos1.data;
            pos1.data = pos2.data;
            pos2.data = val;
            return pos1;
        }
        public void insertionSort(Node headref)
        {          
            sorted = null;
            Node current = headref;        
            while (current != null)
            {             
                Node next = current.next;          
                sortedInsert(current);
                current = next;
            }      
            head = sorted;
        }
        public void sortedInsert(Node newnode)
        {
          
            if (sorted == null || sorted.data >= newnode.data)
            {
                newnode.next = sorted;
                sorted = newnode;
            }
            else
            {
                Node current = sorted;
                while (current.next != null &&
                        current.next.data < newnode.data)
                {
                    current = current.next;
                }
                newnode.next = current.next;
                current.next = newnode;
            }
        }


        public Node insertionSortinverse(Node headref)
        {
            if(headref == null)
            {
                return null;
            }
            sorted = null;
            Node current = headref;
            while (current != null)
            {
                Node next = current.next;
                sortedInsertinverse(current);
                current = next;
            }
            head = sorted;
            return headref;
        }
        public void sortedInsertinverse(Node newnode)
        {

            if (sorted == null || sorted.data <= newnode.data)
            {
                newnode.next = sorted;
                sorted = newnode;
            }
            else
            {
                Node current = sorted;
                while (current.next != null &&
                        current.next.data > newnode.data)
                {
                    current = current.next;
                }
                newnode.next = current.next;
                current.next = newnode;
            }
        }


    }
}

        
    


