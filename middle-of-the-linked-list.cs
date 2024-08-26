/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }

 https://leetcode.com/problems/middle-of-the-linked-list/
 */
public class Solution {
    public ListNode MiddleNode(ListNode head) {
        ListNode turtle = head;
        ListNode rabbit = head;

        int count = 0;
        while(rabbit.next != null)
        {
            rabbit = rabbit.next;

            if(count % 2 == 0)
            {
                turtle = turtle.next;
            }

            count++;
        }
        return turtle;
    }
}