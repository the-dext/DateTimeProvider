namespace DateTimeProviders.Tests
{
    using System;
    using System.Globalization;

    using FluentAssertions;

    using Xunit;

    public class DateTimeOffsetTests
    {
        [Fact]
        public void DateTimeProvider_Implements_IDateTimeProvider()
        {
            var sut = new DateTimeOffsetProvider();
            sut.Should().BeAssignableTo<IDateTimeOffsetProvider>();
        }

        [Fact]
        public void FromFileTime_IsImplemented()
        {
            DateTimeOffset localDate = new DateTimeOffset(new DateTime(2010, 3, 14, 2, 30, 0, DateTimeKind.Local));
            var filetime = localDate.ToFileTime();

            var sut = new DateTimeOffsetProvider();
            sut.FromFileTime(filetime)
                .Should().Be(DateTime.FromFileTime(filetime));
        }

        [Fact]
        public void FromUnixTimeMilliseconds_IsImplemented()
        {
            var sut = new DateTimeOffsetProvider();
            sut.FromUnixTimeMilliseconds(300000)
                .Should().Be(DateTimeOffset.FromUnixTimeMilliseconds(300000));
        }

        [Fact]
        public void FromUnixTimeSecond_IsImplemented()
        {
            var sut = new DateTimeOffsetProvider();
            sut.FromUnixTimeSeconds(300)
                .Should().Be(DateTimeOffset.FromUnixTimeSeconds(300));
        }

        [Fact]
        public void MaxValue_IsImplemented()
        {
            var sut = new DateTimeOffsetProvider();
            sut.MaxValue.Should().Be(DateTime.MaxValue);
        }

        [Fact]
        public void MinValue_IsImplemented()
        {
            var sut = new DateTimeOffsetProvider();
            sut.MinValue.Should().Be(DateTime.MinValue);
        }

        [Fact]
        public void Now_IsImplemented()
        {
            var sut = new DateTimeOffsetProvider().Now;
            sut.Should().BeCloseTo(DateTime.Now);
        }

        [Fact]
        public void Parse_IsImplemented()
        {
            var sut = new DateTimeOffsetProvider().Parse("31-Dec-2019 13:55:22");
            var expected = DateTime.Parse("31-Dec-2019 13:55:22");
            sut.Should().Be(expected);
        }

        [Fact]
        public void Parse_With_DateTimeStyles_IsImplemented()
        {
            var sut = new DateTimeOffsetProvider().Parse("31-Dec-2019 13:55:22 ", new CultureInfo("en-US"), DateTimeStyles.AllowWhiteSpaces);
            var expected = DateTime.Parse("31-Dec-2019 13:55:22 ", new CultureInfo("en-US"), DateTimeStyles.AllowWhiteSpaces);
            sut.Should().Be(expected);
        }

        [Fact]
        public void Parse_With_FormatProvider_IsImplemented()
        {
            var sut = new DateTimeOffsetProvider().Parse("31-Dec-2019 13:55:22", new CultureInfo("en-US"));
            var expected = DateTime.Parse("31-Dec-2019 13:55:22", new CultureInfo("en-US"));
            sut.Should().Be(expected);
        }

        [Fact]
        public void ParseExact_With_DateTimeStyle_IsImplemented()
        {
            var dateString = "15/06/2008 08:30";
            var format = "g";
            var provider = new CultureInfo("fr-FR");

            var sut = new DateTimeOffsetProvider().ParseExact(dateString, format, provider, DateTimeStyles.AdjustToUniversal);
            var expected = DateTime.ParseExact(dateString, format, provider, DateTimeStyles.AdjustToUniversal);
            sut.Should().Be(expected);
        }

        [Fact]
        public void ParseExact_With_FormatProvider_IsImplemented()
        {
            var dateString = "15/06/2008 08:30";
            var format = "g";
            var provider = new CultureInfo("fr-FR");

            var sut = new DateTimeOffsetProvider().ParseExact(dateString, format, provider);
            var expected = DateTime.ParseExact(dateString, format, provider);
            sut.Should().Be(expected);
        }

        [Fact]
        public void ParseExact_With_FormatStrings_And_DateTimeStyle_IsImplemented()
        {
            var dateString = "15/06/2008 08:30";
            var format = "g";
            var provider = new CultureInfo("fr-FR");

            var sut = new DateTimeOffsetProvider().ParseExact(dateString, new string[] { format }, provider, DateTimeStyles.AdjustToUniversal);
            var expected = DateTime.ParseExact(dateString, new string[] { format }, provider, DateTimeStyles.AdjustToUniversal);
            sut.Should().Be(expected);
        }

        [Fact]
        public void TryParse_IsImplemented()
        {
            DateTime expected;
            DateTime.TryParse("1 Jan 2021", out expected);

            DateTimeOffset result;
            var parseResult = new DateTimeOffsetProvider().TryParse("1 Jan 2021", out result);

            parseResult.Should().BeTrue();
            result.Should().Be(expected);
        }

        [Fact]
        public void TryParse_With_Format_Provider_IsImplemented()
        {
            var provider = new CultureInfo("fr-FR");
            DateTimeOffset expected;
            DateTimeOffset.TryParse("1 Jan 2021", provider, DateTimeStyles.AssumeUniversal, out expected);

            DateTimeOffset result;
            var parseResult = new DateTimeOffsetProvider().TryParse("1 Jan 2021", provider, DateTimeStyles.AssumeUniversal, out result);

            parseResult.Should().BeTrue();
            result.Should().Be(expected);
        }

        [Fact]
        public void TryParseExact_IsImplemented()
        {
            var dateString = "15/06/2008 08:30";
            var format = "g";
            var provider = new CultureInfo("fr-FR");

            DateTime expected;
            DateTime.TryParseExact(dateString, format, provider, DateTimeStyles.AdjustToUniversal, out expected);

            DateTimeOffset result;
            var parseResult = new DateTimeOffsetProvider().TryParseExact(dateString, format, provider, DateTimeStyles.AdjustToUniversal, out result);

            parseResult.Should().BeTrue();
            result.Should().Be(expected);
        }

        [Fact]
        public void TryParseExact_With_Formats_IsImplemented()
        {
            var dateString = "15/06/2008 08:30";
            var format = "g";
            var provider = new CultureInfo("fr-FR");

            DateTime expected;
            DateTime.TryParseExact(dateString, format, provider, DateTimeStyles.AdjustToUniversal, out expected);

            DateTimeOffset result;
            var parseResult = new DateTimeOffsetProvider().TryParseExact(dateString, new string[] { format }, provider, DateTimeStyles.AdjustToUniversal, out result);

            parseResult.Should().BeTrue();
            result.Should().Be(expected);
        }

        [Fact]
        public void UtcNow_IsImplemented()
        {
            var sut = new DateTimeOffsetProvider().UtcNow;
            sut.Should().BeCloseTo(DateTime.UtcNow);
        }
    }
}