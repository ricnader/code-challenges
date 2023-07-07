namespace HackerRankChallenges.Classes
{
    public class SinglyLinkedList
    {
        public SinglyLinkedListNode head { get;  set; }

        public void InsertNodeAtTail(int value)
        {
            SinglyLinkedListNode newNode = new SinglyLinkedListNode()
            {
                data = value,
                next = null
            };

            if (head == null)
            {
                this.head = new SinglyLinkedListNode()
                {
                    next = newNode
                };

                return;
            }

            newNode.next = new SinglyLinkedListNode()
            {
                data = head.data,
                next = head
            };

            head.next = newNode;
        }
    }
}
