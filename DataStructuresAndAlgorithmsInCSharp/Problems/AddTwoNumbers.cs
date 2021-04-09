using System;
using System.Collections.Generic;
using DataStructuresAndAlgorithmsInCSharp.DataStructures;

namespace DataStructuresAndAlgorithmsInCSharp.Problems
{
   public class AddTwoNumbers : ProblemBase
   {
      public override void SetBaseValues()
      {
         Name = "AddTwoNumbers";
         Description = @"
                    You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.     
                    You may assume the two numbers do not contain any leading zero, except the number 0 itself.
                    Example 1:
                      Input: l1 = [2,4,3], l2 = [5,6,4]
                      Output: [7,0,8]
                      Explanation: 342 + 465 = 807.
                    Example 2:
                      Input: l1 = [0], l2 = [0]
                      Output: [0]
                    Example 3:
                      Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
                      Output: [8,9,9,9,0,0,0,1]";
         Source = "https://leetcode.com/problems/add-two-numbers/";
         Levels = Levels.Intermediate;
         Keywords = new List<string> { Tags.LinkedLists.ToString() };
      }
      public ListNode SolveAddTwoNumbers(ListNode list1, ListNode list2)
      {
         if (list1 == null || list2 == null)
            throw new ArgumentNullException("lists cannot be null");

         var sumList = new ListNode(0);
         var head = sumList;
         var carry = 0;
         while (list1 != null || list2 != null)
         {
            var value1 = list1?.Value ?? 0;
            var value2 = list2?.Value ?? 0;

            var sum = value1 + value2 + carry;
            carry = sum > 9 ? 1 : 0;
            sumList.Next = new ListNode(sum % 10);
            sumList = sumList.Next;
            list1 = list1?.Next;
            list2 = list2?.Next;
         }
         if (carry > 0)
            sumList.Next = new ListNode(1);

         return head.Next;
      }
   }
}
