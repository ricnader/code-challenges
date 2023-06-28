namespace HackerRankChallenges.Classes
{
    public class SinglyLinkedList
    {
        public SinglyLinkedListNode head { get;  set; }

        public void InsertNode(int value)
        {


            if (head == null)
                this.head = new SinglyLinkedListNode()
                {
                    next = new SinglyLinkedListNode()
                    {
                        data = value,
                        next = null
                    }
                };
            else
            {
                SinglyLinkedListNode nHead = new SinglyLinkedListNode()
                {
                    data = head.next.data,
                    next = null
                };

                SinglyLinkedListNode nNext = new SinglyLinkedListNode()
                {
                    data = head.data,
                    next = head
                };

                head = nHead;
                head.next = new SinglyLinkedListNode()
                {
                    data = value,
                    next = nNext
                };

            }
        }
    }
}
