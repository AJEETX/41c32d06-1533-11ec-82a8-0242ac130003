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
            //good to validate/check the input at the entry of public method
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentNullException($"{nameof(BusinessService)}:{nameof(GetSubsequence)}- {nameof(input)} is empty.");
            }

            try
            {
                var integers = input.Split(SINGLE_SPACE).Select(long.Parse).ToArray();

                return _subsequenceService.GetLongestIncreasingSubsequence(integers);
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"{nameof(BusinessService)}:{nameof(GetSubsequence)}-{nameof(input)}: {ex.Message}");
            }
        }
    }
}
