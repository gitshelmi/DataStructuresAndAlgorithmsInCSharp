using System;
using System.Collections.Generic;
using DataStructuresAndAlgorithmsInCSharp.DataStructures;
using DataStructuresAndAlgorithmsInCSharp.Problems;
using FluentAssertions;
using Xunit;

namespace DataStructuresAndAlgorithmsInCSharpUnitTests
{
   public class AddTwoNumbersTests
   {
      [Fact]
      public void SolveAddTwoNumbers_WithNullList_ShouldThrowException()
      {
         //arrange
         var list1 = new ListNode(0);
         ListNode list2 = null;

         //act
         Action action = () => new AddTwoNumbers().SolveAddTwoNumbers(list1, list2);

         //assert
         action.Should().Throw<ArgumentNullException>();
      }

      [Fact]
      public void SolveAddTwoNumbers_WithZeroList_ShouldSumToZero()
      {
         //arrange
         var list1 = new ListNode(0);
         var list2 = new ListNode(0);

         // act
         var sumList = new AddTwoNumbers().SolveAddTwoNumbers(list1, list2);

         //assert
         sumList.Value.Should().Be(0);
         sumList.Next.Should().BeNull();
      }

      [Fact]
      public void SolveAddTwoNumbers_WithTwoLists_ShouldSumCorrectly()
      {
         //arrange
         var list1 = new ListNode(new List<int> { 4, 5 }); //54
         var list2 = new ListNode(new List<int> { 6, 4 }); //46

         // act
         var sumList = new AddTwoNumbers().SolveAddTwoNumbers(list1, list2);

         //assert
         sumList.Value.Should().Be(0);
         sumList.Next.Value.Should().Be(0);
         sumList.Next.Next.Value.Should().Be(1);
      }
   }
}
