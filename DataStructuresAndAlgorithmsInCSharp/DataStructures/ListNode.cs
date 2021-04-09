using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructuresAndAlgorithmsInCSharp.DataStructures
{
   /// <summary>
   /*
    Based on the interface provided on https://leetcode.com/problems/add-two-numbers/ for singly-linked list:
    public class ListNode {
        int val;
        ListNode next;
        ListNode() {}
        ListNode(int val) { this.val = val; }
        ListNode(int val, ListNode next) { this.val = val; this.next = next; }
   */
   /// </summary>
   public class ListNode
   {
      public int Value { get; set; }
      public ListNode Next { get; set; }

      public ListNode()
      {
      }

      public ListNode(int value)
      {
         Value = value;
      }

      public ListNode(int value, ListNode next)
      {
         Value = value;
         Next = next;
      }

      // for easy initialization and unit-testing
      public ListNode(List<int> values)
      {
         if (values.Count == 0)
            return;

         Value = values[0];
         var currentNode = this;
         foreach (var value in values.Skip(1))
         {
            var newNode = new ListNode(value);
            currentNode.Next = newNode;
            currentNode = currentNode.Next;
         }
      }

      public void Print()
      {
         var currentNode = this;
         while (currentNode != null)
         {
            Console.Write($"{currentNode.Value}->");
            currentNode = currentNode.Next;
         }

         Console.WriteLine("*");
      }
   }
}
