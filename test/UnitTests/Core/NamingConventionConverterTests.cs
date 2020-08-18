using Xunit;
using BuildingBlocks.Core;

namespace UnitTests.Core
{
    public class NamingConventionConverterTests
    {
        private readonly NamingConventionConverter _converter;

        public NamingConventionConverterTests()
        {
            _converter = new NamingConventionConverter();
        }

        [Theory]
        [InlineData("QuinntyneBrown", NamingConvention.CamelCase, "quinntyneBrown")]
        [InlineData("quinntyne-brown", NamingConvention.PascalCase, "QuinntyneBrown")]
        [InlineData("QuinntyneBrown", NamingConvention.SnakeCase, "quinntyne-brown")]
        [InlineData("QuinntyneBrown", NamingConvention.TitleCase, "Quinntyne Brown")]
        public void ShouldConvertToExpectingCasing(string value, NamingConvention convention, string expected ) {

            Assert.Equal(expected, _converter.Convert(convention, value));
        }
    }

}
