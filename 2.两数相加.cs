/*
 * @lc app=leetcode.cn id=2 lang=csharp
 *
 * [2] 两数相加
 *
 * https://leetcode-cn.com/problems/add-two-numbers/description/
 *
 * algorithms
 * Medium (41.13%)
 * Likes:    7251
 * Dislikes: 0
 * Total Accepted:    1.1M
 * Total Submissions: 2.7M
 * Testcase Example:  '[2,4,3]\n[5,6,4]'
 *
 * 给你两个 非空 的链表，表示两个非负的整数。它们每位数字都是按照 逆序 的方式存储的，并且每个节点只能存储 一位 数字。
 * 
 * 请你将两个数相加，并以相同形式返回一个表示和的链表。
 * 
 * 你可以假设除了数字 0 之外，这两个数都不会以 0 开头。
 * 
 * 
 * 
 * 示例 1：
 * 
 * 
 * 输入：l1 = [2,4,3], l2 = [5,6,4]
 * 输出：[7,0,8]
 * 解释：342 + 465 = 807.
 * 
 * 
 * 示例 2：
 * 
 * 
 * 输入：l1 = [0], l2 = [0]
 * 输出：[0]
 * 
 * 
 * 示例 3：
 * 
 * 
 * 输入：l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
 * 输出：[8,9,9,9,0,0,0,1]
 * 
 * 
 * 
 * 
 * 提示：
 * 
 * 
 * 每个链表中的节点数在范围 [1, 100] 内
 * 0 
 * 题目数据保证列表表示的数字不含前导零
 * 
 * 
 */

// @lc code=start
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
public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode returnListNode = GetNum(0, l1, l2);

        ListNode GetNum(int add, ListNode l1 = null, ListNode l2 = null)
        {
            ListNode returnListNode = null;

            if (l1 != null || l2 != null || add != 0)
            {
                returnListNode = new ListNode();
                var addNumber = (l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val) + add;
                if (addNumber >= 10)
                {
                    returnListNode.val = addNumber % 10;
                    returnListNode.next = GetNum(1, l1 == null ? null : l1.next, l2 == null ? null : l2.next);
                }
                else
                {
                    returnListNode.val = addNumber;
                    returnListNode.next = GetNum(0, l1 == null ? null : l1.next, l2 == null ? null : l2.next);
                }
            }

            return returnListNode;
        }
        return returnListNode;
    }
}
// @lc code=end

