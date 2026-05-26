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
 */
 
public class Solution {
    public ListNode ReverseList(ListNode head) {
        if (head == null) return null;
        if (head.next==null) return head;
        var prevTemp= head;
        head=head.next;
        prevTemp.next = null;
        while(head!=null)
        {
            var nextTemp=head.next;
            head.next=prevTemp;
            prevTemp= head;
            if(nextTemp==null)
                break;
            head=nextTemp;
        }
        return head;
    }
}
