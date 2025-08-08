// Solution for Reverse Linked List

public class Solution
{
    public ListNode ReverseList(ListNode head)
    {

        ListNode prev = null;
        var current = head;
        while (current != null)
        {
            var nextTemp = current.next;
            current.next = prev;
            prev = current;
            current = nextTemp;

        }


        return prev;


    }
}