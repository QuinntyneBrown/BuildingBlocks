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
        [Fact]
        public void ShouldConvertToCamelCase() {

            var value = "QuinntyneBrown";

            var result = _converter.Convert(NamingConvention.CamelCase, value);

            Assert.Equal("quinntyneBrown", result);
        }
    }

}
