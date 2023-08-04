using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.grind_169
{

    public class ListNode {
        public int? val;
        public ListNode? next;
        public int length;
        public ListNode(int? val = null, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    internal class LinkList 
    { 
        public ListNode CreateLinkList(int[] list) 
        {
            ListNode linklist = new ListNode();
            ListNode head = linklist;
            for (int i = 0; i < list.Length; i++)
            {
                linklist.length++;
                if (i == 0)
                {
                    linklist.val = list[i];
                }
                else {
                    linklist.next = new ListNode(list[i]);
                    linklist = linklist.next;
                }
            }
            ViewLinkList(head);
            return head;
        }
        public void ViewLinkList(ListNode head)
        {
            while (head.val != null)
            {
                Console.WriteLine(head.val);
                if (head.next != null)
                {
                    head = head.next;
                }
                else
                {
                    break;
                }
            }
        }
    }


    public class Merge_two_sorted_list_21
    {
        int[] list1 = new int[] { 1, 2, 4 };
        int[] list2 = new int[] { 1, 3, 4 };
        public ListNode GetResult()
        {
            LinkList linklist = new LinkList();
            ListNode linklist1 = linklist.CreateLinkList(list1);
            ListNode linklist2 = linklist.CreateLinkList(list2);
            ListNode result = GetResult(linklist1, linklist2);
            linklist.ViewLinkList(result);
            return result;
        }

        private ListNode? GetResult(ListNode list1, ListNode list2)
        {
            if (list1 == null && list2 == null)
            {
                return null;
            }
            else if (list1 == null)
            {
                return list2;
            }
            else if (list2 == null)
            {
                return list1;
            }

            ListNode dummyNode = new ListNode();
            ListNode head = dummyNode;
            ListNode p1 = list1, p2 = list2;

            while (p1 != null && p2 != null)
            {
                if (p1.val > p2.val)
                {
                    dummyNode.next = p2;
                    dummyNode = dummyNode.next;
                    p2 = p2.next;
                }
                else if (p1.val < p2.val)
                {
                    dummyNode.next = p1;
                    dummyNode = dummyNode.next;
                    p1 = p1.next;
                }
                else if (p1.val == p2.val)
                {
                    dummyNode.next = p1;
                    dummyNode = dummyNode.next;
                    p1 = p1.next;
                    dummyNode.next = p2;
                    dummyNode = dummyNode.next;
                    p2 = p2.next;
                }
            }
            if (p1 != null)
            {
                dummyNode.next = p1;
            }
            else if (p2 != null)
            {
                dummyNode.next = p2;
            }

            return head.next;
        }
    }
}
