using Kmart.Code.Challenge.Tests.Setup;
using Moq;
using System;
using Xunit;

namespace Kmart.Code.Challenge.Tests
{
    public class BusinessServiceUnitTest
    {
        [Fact]
        public void GetSubsequence_With_EmptyInput_ThrowsArgumentNullException()
        {
            //given
            var mockSubsequenceService = new Mock<ISubsequenceService>();
            var sut = new BusinessService(mockSubsequenceService.Object);

            //when
            var exception = Assert.Throws<ArgumentNullException>(() => sut.GetSubsequence(string.Empty));

            //then
            Assert.Equal("Value cannot be null. (Parameter 'BusinessService:GetSubsequence- input is empty.')", exception.Message);
            mockSubsequenceService.Verify(v => v.GetLongestIncreasingSubsequence(It.IsAny<long[]>()), Times.Never);
        }

        [Theory]
        [ClassData(typeof(TestCaseData))]
        public void GetSubsequence_With_ValidInput_ReturnsOutput(string input, string expected)
        {
            //given
            var mockSubsequenceService = new Mock<ISubsequenceService>();
            mockSubsequenceService.Setup(m => m.GetLongestIncreasingSubsequence(It.IsAny<long[]>())).Returns(expected);
            var sut = new BusinessService(mockSubsequenceService.Object);

            //when
            var actual = sut.GetSubsequence(input);
            
            //then
            Assert.Equal(expected, actual);
            mockSubsequenceService.Verify(v => v.GetLongestIncreasingSubsequence(It.IsAny<long[]>()), Times.Once);
        }

        [Theory]
        [InlineData("azy 123")]     //Input with non-integer values
        [InlineData("1234  123")]   //Input with more than single space
        public void GetSubsequence_With_InvalidInput_ThrowsArgumentException(string input)
        {
            //given
            var mockSubsequenceService = new Mock<ISubsequenceService>();
            var sut = new BusinessService(mockSubsequenceService.Object);

            //when
            var exception = Assert.Throws<ArgumentException>(() => sut.GetSubsequence(input));
            
            //then
            mockSubsequenceService.Verify(v => v.GetLongestIncreasingSubsequence(It.IsAny<long[]>()), Times.Never);
            Assert.Equal("BusinessService:GetSubsequence-input: Input string was not in a correct format.", exception.Message);
        }
    }
}
