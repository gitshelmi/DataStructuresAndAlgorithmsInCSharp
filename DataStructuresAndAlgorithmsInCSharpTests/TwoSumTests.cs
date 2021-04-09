using DataStructuresAndAlgorithmsInCSharp.Problems;
using FluentAssertions;
using Xunit;

namespace DataStructuresAndAlgorithmsInCSharpUnitTests
{
   public class TwoSumTests
   {
      [Fact]
      public void SolveTwoSum_WithProperValues_ShouldReturnCorrectIndices()
      {
         //arrange
         var input = new [] { 2, 7, 11, 15 };
         var target = 9;
         var expectedOutput = new [] { 0, 1 };

         //act
         var actualOutput = new TwoSum().SolveTwoSum(input, target);

         //assert
         actualOutput.Should().BeEquivalentTo(expectedOutput);
      }

      [Fact]
      void SolveTwoSum_WithFewInputs_ShouldReturnNull()
      {
         //arrange
         var input = new [] { 2 };
         var target = 9;

         //act
         var actualOutput = new TwoSum().SolveTwoSum(input, target);

         //assert
         actualOutput.Should().BeNull();
      }

      [Fact]
      void SolveTwoSum_WithNoValidAnswer_ShouldReturn00()
      {
         //arrange
         var input = new int[] { 2, 3, 4 };
         var target = 100;
         var expectedOutput = new[] {0, 0};

         //act
         var actualOutput = new TwoSum().SolveTwoSum(input, target);

         //assert
         actualOutput.Should().BeEquivalentTo(expectedOutput);
      }
   }
}
