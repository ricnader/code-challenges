//You are given the pointer to the head node of a linked list and an 
//integer to add to the list. Create a new node with the given integer. 
//Insert this node at the tail of the linked list and return the head 
//node of the linked list formed after inserting this new node.
//The given head pointer may be null, meaning that the initial list is empty.


//Input Format
//5 (input item count)

//141 302 164 530 474

//output Format
//141 302 164 530 474



using HackerRankChallenges.Classes;
using System.IO;

namespace HackerRankChallenges
{
    public static class InsertTailLinkedList
    {
        public static void Initialize()
        {
            SinglyLinkedList llist = new SinglyLinkedList();
            int llistCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < llistCount; i++)
            {
                int llistItem = Convert.ToInt32(Console.ReadLine());
                SinglyLinkedListNode llist_head = insertNodeAtTail(llist.head, llistItem);
                llist.head = llist_head;
            }



            printLinkedList(llist.head);

        }

        static SinglyLinkedListNode insertNodeAtTail(SinglyLinkedListNode head, int data)
        {
            var next = new SinglyLinkedListNode(data);

            if (head == null)
                return next;

            if (head.next == null)
                head.next = next;
            else
                head.next = insertNodeAtTail(head.next, data);

            return head;
        }


        static void printLinkedList(SinglyLinkedListNode head)
        {
            if (head == null)
            {
                Console.WriteLine(string.Empty);
                return;
            }

            Console.WriteLine(head.data.ToString());
            printLinkedList(head.next);
        }
    }
}
