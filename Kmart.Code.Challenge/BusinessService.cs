using System;
using System.Linq;

namespace Kmart.Code.Challenge
{
    public interface IBusinessService
    {
        string FindSubsequence(string input);
    }
    class BusinessService : IBusinessService
    {
        private const char SINGLE_SPACE = ' ';
        private readonly ISubsequenceService _subsequenceService;

        public BusinessService(ISubsequenceService subsequenceService)
        {
            _subsequenceService = subsequenceService;
        }
        public string FindSubsequence(string input)
        {
            //validate/check the input
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentNullException($"{nameof(BusinessService)}:{nameof(FindSubsequence)}- {nameof(input)} is empty.");
            }

            try
            {
                //splitting the input string into list of values separated by SINGLE white-space
                var integers = input.Split(SINGLE_SPACE).Select(long.Parse).ToArray();

                if (integers.Length < 1)
                {
                    throw new ArgumentException($"{nameof(BusinessService)}:{nameof(FindSubsequence)}-{nameof(input)} is invalid.");
                }
                //pull the longest increasing sub-sequence
                return _subsequenceService.FindLongestIncreasingSubsequence(integers);
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"{nameof(BusinessService)}:{nameof(FindSubsequence)}-{nameof(input)}: {ex.Message}");
            }
        }
    }
}
