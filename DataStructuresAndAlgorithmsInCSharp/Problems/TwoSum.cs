using System.Collections.Generic;

namespace DataStructuresAndAlgorithmsInCSharp.Problems
{
   public class TwoSum:ProblemBase
   {
      public override void SetBaseValues()
      {
         Name = "com.company.TwoSum";
         Description = @"
         Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
            You may assume that each input would have exactly one solution, and you may not use the same element twice.
            You can return the answer in any order.
            Example 1:              
         Input: nums = [2, 7, 11, 15], target = 9
         Output:[0,1]
         Output: Because nums[0] +nums[1] == 9, we return [0, 1].

         Example 2:              
         Input: nums = [3, 2, 4], target = 6
         Output:[1,2]
         ";
         Source = "https://leetcode.com/problems/two-sum/";
         Level = Level.Easy;
         Keywords = new List<string>{Tags.Arrays.ToString()};
      }

      /// <summary>
      /// finds the indices of the values in numbers that sum up to the target value
      /// </summary>
      /// <param name="numbers">the input array</param>
      /// <param name="target">the target value</param>
      /// <returns></returns>
      public int[] TwoSumSolver(int[] numbers, int target)
      {
         if (numbers.Length < 2)
            return null;

         var complementIndexMap = new Dictionary<int, int>();
         var indices = new [] { 0, 0 };
         for (var index = 0; index < numbers.Length; index++)
         {
            var number = numbers[index];
            // check if the complement has already found
            if (complementIndexMap.ContainsKey(number))
            {
               indices[0] = complementIndexMap[number];
               indices[1] = index;
               break;
            }

            // add the complement and its index to the dictionary
            var complement = target - number;
            complementIndexMap.Add(complement, index);
         }

         return indices;
      }
   }
}
