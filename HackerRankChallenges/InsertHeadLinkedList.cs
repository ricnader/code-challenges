//Given a pointer to the head of a linked list, insert a new node before 
//the head. The NEXT value in the new node should point to DATA and the DATA 
//value should be replaced with a given value. Return a reference to 
//the new head of the list. The head pointer given may be null meaning
//that the initial list is empty.


//Input Format
//5 (input item count)

//141 302 164 530 474

//output Format
//141 302 164 530 474


using HackerRankChallenges.Classes;


namespace HackerRankChallenges
{
    public static class InsertHeadLinkedList
    {
        public static void Initialize()
        {
            SinglyLinkedList llist = new SinglyLinkedList();
            int llistCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < llistCount; i++)
            {
                int llistItem = Convert.ToInt32(Console.ReadLine());
                SinglyLinkedListNode llist_head = insertNodeAtHead(llist.head, llistItem);
                llist.head = llist_head;
            }
            printLinkedList(llist.head);

        }

        static SinglyLinkedListNode insertNodeAtHead(SinglyLinkedListNode lList, int? data)
        {
            SinglyLinkedList singlyLinkedList = new SinglyLinkedList();
            SinglyLinkedListNode  nHead = new SinglyLinkedListNode()
            {
                data = data
            }; 


            if (lList == null)
            {
                return nHead;
            }

            if (lList.next != null)
            {
                insertNodeAtHead(lList.next, data.Value);
                //lList.data = null;
                //lList.next = next;
            }
            else
            {
                lList.next = nHead;
            }
            //else
            //{
            //    insertNodeAtHead(lList, data.Value);
            //}

            return lList;
        }

        //static SinglyLinkedListNode insertNodeAtTail(SinglyLinkedListNode head, int data)
        //{
        //    var next = new SinglyLinkedListNode(data);

        //    if (head == null)
        //        return next;

        //    if (head.next == null)
        //        head.next = next;
        //    else
        //        head.next = insertNodeAtTail(head.next, data);

        //    return head;
        //}


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
