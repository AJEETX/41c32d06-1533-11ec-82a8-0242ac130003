using Kmart.Code.Challenge.Tests.Setup;
using System;
using Xunit;

namespace Kmart.Code.Challenge.Tests
{
    public class BusinessServiceIntegrationTest
    {
        ISubsequenceService _subsequenceService;
        public BusinessServiceIntegrationTest()
        {
            _subsequenceService = new SubsequenceService();
        }
        [Fact]
        public void GetSubsequence_With_EmptyInput_ThrowsArgumentNullException()
        {
            //given
            var sut = new BusinessService(_subsequenceService);

            //when
            var exception = Assert.Throws<ArgumentNullException>(() => sut.GetSubsequence(string.Empty));

            //then
            Assert.Equal("Value cannot be null. (Parameter 'BusinessService:GetSubsequence- input is empty.')", exception.Message);
        }

        [Theory]
        [ClassData(typeof(TestCaseData))]
        public void GetSubsequence_With_ValidInput_ReturnsOutput(string input, string expected)
        {
            //given
            var sut = new BusinessService(_subsequenceService);

            //when
            var actual = sut.GetSubsequence(input);
            
            //then
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("azy 123")]     //Input with non-integer values
        [InlineData("1234  123")]   //Input with more than single space
        public void GetSubsequence_With_InvalidInput_ThrowsArgumentException(string input)
        {
            //given
            var sut = new BusinessService(_subsequenceService);

            //when
            var exception = Assert.Throws<ArgumentException>(() => sut.GetSubsequence(input));
            
            //then
            Assert.Equal("BusinessService:GetSubsequence-input: Input string was not in a correct format.", exception.Message);
        }
    }
}
