using System;

namespace CSharpConsole
{
	class Program
	{
		static void Main(string[] args)
		{
            Solution sol = new Solution();
            var l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
            var l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
            Console.WriteLine(sol.AddTwoNumbers(l1, l2));
		}
	}
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode dummyHead = new ListNode(0);
            ListNode p = l1, q = l2, curr = dummyHead;

            int carry = 0;
            while (p != null || q != null)
            {
                int x = (p != null) ? p.val : 0;
                int y = (q != null) ? q.val : 0;

                int sum = carry + x + y;
                carry = sum / 10;
                curr = curr.next;
                if (p != null) p = p.next;
                if (q != null) q = q.next;
            }

            if (carry > 0)
            {
                curr.next = new ListNode(carry);
            }
            return dummyHead.next;

        }
    }

  public class ListNode
    {
      public int val;
      public ListNode next;
      public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
            }
  }
}
