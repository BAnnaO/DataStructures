using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class LinkedList
    {
        private int size = 0;
        private Node head;

        public void printAllNodes()
        {
            Console.WriteLine("Printing all the nodes: ");
            Node tmp = this.head;
            while (tmp != null)
            {
                Console.WriteLine(tmp.data);
                tmp = tmp.next;
            }
        }

        public void AddAtHead(Object obj)
        {
            size++;
            Node newNode = new Node();
            newNode.data = obj;
            if (this.head == null)
            { this.head = newNode; }
            else
            {

                newNode.next = head;
                this.head = newNode;
            }
        }
        public int getSize() { return size; }
        public void AddAtTail(Object obj)
        {
            size++;
            Node newNode = new Node();
            newNode.data = obj;
            if (this.head == null)
            { this.head = newNode; }
            else
            {
                Node tmp = this.head;
                while (tmp.next != null)
                {
                    tmp = tmp.next;
                }
                tmp.next = newNode;
            }

        }
        public void DeleteNode(Object obj)
        {
            if (this.head.data.Equals(obj))
            { head = head.next; }
            else
            {
                Node temp = head;
                Node Pretemp = head;
                bool mached = false;
                while (!(mached = temp.data.Equals(obj)) && temp.next != null)
                {
                    Pretemp = temp;
                    temp = temp.next;
                }
                if (mached)
                { Pretemp.next = temp.next; }
                else { Console.WriteLine("Not Found! "); }
            }
        }
        public bool searchNode(Object obj)
        {
            Node temp = this.head;
            bool mached = false;
            while (!(mached = temp.data.Equals(obj)) && temp.next != null)
            {
                temp = temp.next;
            }
            return mached;
        }
    }
}
