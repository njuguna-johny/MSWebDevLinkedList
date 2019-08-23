using System;
using System.Collections.Generic;
using System.Text;

namespace microsoftWebDevInterview
{
    public class linkedListHelper
    {
        private Node head;
        private int count;
        public linkedListHelper()
        {
            head = null;
            count = 0;
        }
        public bool Empty
        {
            get { return count == 0; }
        }
        public int Count
        {
            get { return this.count; }
        }
        public object Add(int index, object node)
        {
            if (index < 0)
                return null;
            if (index > count)
                index = count;
            Node current = head;
            if (Empty || index == 0)
            {
                head = new Node(node, head);
            }
            else
            {
                for (int i = 0; i < index - 1; i++)
                    current = current.Next;
                current.Next = new Node(node, current.Next);
            }
            count++;
            return node;

        }
        public object Add(object node)
        {
            return Add(count, node);
        }
        public object Remove(int index)
        {
            if (index < 0)
                return null;
            if (index > count)
                index = count - 1;
            Node current = head;
            object result = null;

            if (index == 0)
            {
                result = current.Data;
                head = current.Next;
            }
            else
            {
                for (int i = 0; i < index - 1; i++)
                    current= current.Next;
                result = current.Next.Data;
                current.Next = current.Next.Next;
            }
            count--;
            return result;
        }
        public object RemoveDuplicate()
        {
            int index;
            int nodeindex;
            Node currentNode = head;
          
            while (currentNode.Next != null)
            {
                index=1;
                // conter to get node item index
                nodeindex = 0;
                // Check muiltiple occurance of item in list if more than 2 time remove
                Node originalNode = head;
                while (originalNode != null)
                {
                    if (originalNode.Data == currentNode.Data)
                    {
                        //Check if node item has occurred more than 2 times
                        if (index > 2)
                        {
                            Remove(nodeindex);
                        }
                        index++;
                    };
                    nodeindex++;
                    originalNode = originalNode.Next;
                }
                currentNode = currentNode.Next;
            }
            return head;
        }
    }
}
