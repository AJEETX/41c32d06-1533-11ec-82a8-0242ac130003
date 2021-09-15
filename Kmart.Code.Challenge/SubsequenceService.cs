using System;
using System.Linq;

namespace Kmart.Code.Challenge
{
    public interface ISubsequenceService
    {
        string GetLongestIncreasingSubsequence(long[] integers);
    }
    //implementations be internal
    internal class SubsequenceService : ISubsequenceService
    {
        public string GetLongestIncreasingSubsequence(long[] integers)
        {
            //validate/check the integers count
            if (integers.Length < 1)
            {
                throw new ArgumentException($"{nameof(SubsequenceService)}:{nameof(GetLongestIncreasingSubsequence)}-{nameof(integers)} is empty.");
            }

            int longestSubsequenceCount = 1, longestStartIndex = 0, currentStartIndex = 0;

            for (int integerPositionIndex = 1; integerPositionIndex <= integers.Length; integerPositionIndex++)
            {

                if (integerPositionIndex < integers.Length && integers[integerPositionIndex] > integers[integerPositionIndex - 1])
                {
                    continue;
                }

                if (integerPositionIndex - currentStartIndex > longestSubsequenceCount)
                {
                    longestSubsequenceCount = integerPositionIndex - currentStartIndex;
                    longestStartIndex = currentStartIndex;
                }

                currentStartIndex = integerPositionIndex;
            }

            return string.Join(' ', integers.Skip(longestStartIndex).Take(longestSubsequenceCount));
        }
    }
}
