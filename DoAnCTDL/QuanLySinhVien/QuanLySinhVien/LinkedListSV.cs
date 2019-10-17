using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    class LinkedListSV<L>
    {
        public LinkedListSV()
        {
            pHead = null;
            pTail = null;
            count = 0;
        }

        public class Node
        {
            public L data;
            public Node pNext;
        }
        public Node pHead;
        public Node pTail;
        public int count;

        public Node CreNode(L info)
        {
            Node pNode = new Node();
            if (pNode != null)
            {
                pNode.data = info;
                pNode.pNext = null;
            }
            return pNode;
        }
        public void AddHead(L info)
        {
            Node NewNode = CreNode(info);
            if (NewNode == null)
            {
                return;
            }
            if (pHead == null)
            {
                pHead = pTail = NewNode;
            }
            else
            {
                NewNode.pNext = pHead;
                pHead = NewNode;
            }
            count++;
        }

    }
}
