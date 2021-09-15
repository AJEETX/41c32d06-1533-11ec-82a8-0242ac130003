using System;
using System.Linq;

namespace Kmart.Code.Challenge
{
    public interface IBusinessService
    {
        string GetSubsequence(string input);
    }
    //implementations be internal
    internal class BusinessService : IBusinessService
    {
        private const char SINGLE_SPACE = ' ';
        private readonly ISubsequenceService _subsequenceService;

        public BusinessService(ISubsequenceService subsequenceService)
        {
            _subsequenceService = subsequenceService;
        }
        public string GetSubsequence(string input)
        {
            //validate/check the input
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentNullException($"{nameof(BusinessService)}:{nameof(GetSubsequence)}- {nameof(input)} is empty.");
            }

            try
            {
                //splitting the input string into list of values separated by SINGLE white-space
                var integers = input.Split(SINGLE_SPACE).Select(long.Parse).ToArray();

                //pull the longest increasing sub-sequence
                return _subsequenceService.GetLongestIncreasingSubsequence(integers);
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"{nameof(BusinessService)}:{nameof(GetSubsequence)}-{nameof(input)}: {ex.Message}");
            }
        }
    }
}
