using HackerRankChallenges.Classes;

namespace HackerRankChallenges
{
    public static class PrintElementsFromLinkedList
    {
        public static void Initialize()
        {
            SinglyLinkedList llist = new SinglyLinkedList();

            int llistCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < llistCount; i++)
            {
                int llistItem = Convert.ToInt32(Console.ReadLine());
                llist.InsertNodeAtTail(llistItem);
            }

            printLinkedList(llist.head);
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
