namespace DateTimeProviders.Tests
{
    using System;
    using System.Globalization;

    using FluentAssertions;

    using Xunit;

    public class DateTimeProviderTests
    {
        [Fact]
        public void DateTimeProvider_Implements_IDateTimeProvider()
        {
            var sut = new DateTimeProvider();
            sut.Should().BeAssignableTo<IDateTimeProvider>();
        }

        [Fact]
        public void DaysInMonth_IsImplemented()
        {
            var sut = new DateTimeProvider();
            sut.DaysInMonth(2021, 3)
                .Should().Be(DateTime.DaysInMonth(2021, 3));
        }

        [Fact]
        public void FromBinary_IsImplemented()
        {
            DateTime localDate = new DateTime(2010, 3, 14, 2, 30, 0, DateTimeKind.Local);
            long binLocal = localDate.ToBinary();

            var sut = new DateTimeProvider();
            sut.FromBinary(binLocal)
                .Should().Be(DateTime.FromBinary(binLocal));
        }

        [Fact]
        public void FromFileTime_IsImplemented()
        {
            DateTime localDate = new DateTime(2010, 3, 14, 2, 30, 0, DateTimeKind.Local);
            var filetime = localDate.ToFileTime();

            var sut = new DateTimeProvider();
            sut.FromFileTime(filetime)
                .Should().Be(DateTime.FromFileTime(filetime));
        }

        [Fact]
        public void FromFileTimeUtc_IsImplemented()
        {
            DateTime localDate = new DateTime(2010, 3, 14, 2, 30, 0, DateTimeKind.Local);
            var filetime = localDate.ToFileTimeUtc();

            var sut = new DateTimeProvider();
            sut.FromFileTimeUtc(filetime)
                .Should().Be(DateTime.FromFileTimeUtc(filetime));
        }

        [Fact]
        public void FromOADate_IsImplemented()
        {
            var sut = new DateTimeProvider();

            sut.FromOADate(10)
                .Should().Be(DateTime.FromOADate(10));
        }

        [Fact]
        public void IsLeapYear_IsImplemented()
        {
            var sut = new DateTimeProvider();
            sut.IsLeapYear(2020).Should().Be(DateTime.IsLeapYear(2020));
            sut.IsLeapYear(2021).Should().Be(DateTime.IsLeapYear(2021));
        }

        [Fact]
        public void MaxValue_IsImplemented()
        {
            var sut = new DateTimeProvider();
            sut.MaxValue.Should().Be(DateTime.MaxValue);
        }

        [Fact]
        public void MinValue_IsImplemented()
        {
            var sut = new DateTimeProvider();
            sut.MinValue.Should().Be(DateTime.MinValue);
        }

        [Fact]
        public void Now_IsImplemented()
        {
            var sut = new DateTimeProvider().Now;
            sut.Should().BeCloseTo(DateTime.Now);
        }

        [Fact]
        public void Parse_IsImplemented()
        {
            var sut = new DateTimeProvider().Parse("31-Dec-2019 13:55:22");
            var expected = DateTime.Parse("31-Dec-2019 13:55:22");
            sut.Should().Be(expected);
        }

        [Fact]
        public void Parse_With_DateTimeStyles_IsImplemented()
        {
            var sut = new DateTimeProvider().Parse("31-Dec-2019 13:55:22 ", new CultureInfo("en-US"), DateTimeStyles.AllowWhiteSpaces);
            var expected = DateTime.Parse("31-Dec-2019 13:55:22 ", new CultureInfo("en-US"), DateTimeStyles.AllowWhiteSpaces);
            sut.Should().Be(expected);
        }

        [Fact]
        public void Parse_With_FormatProvider_IsImplemented()
        {
            var sut = new DateTimeProvider().Parse("31-Dec-2019 13:55:22", new CultureInfo("en-US"));
            var expected = DateTime.Parse("31-Dec-2019 13:55:22", new CultureInfo("en-US"));
            sut.Should().Be(expected);
        }

        [Fact]
        public void ParseExact_With_DateTimeStyle_IsImplemented()
        {
            var dateString = "15/06/2008 08:30";
            var format = "g";
            var provider = new CultureInfo("fr-FR");

            var sut = new DateTimeProvider().ParseExact(dateString, format, provider, DateTimeStyles.NoCurrentDateDefault);
            var expected = DateTime.ParseExact(dateString, format, provider, DateTimeStyles.NoCurrentDateDefault);
            sut.Should().Be(expected);
        }

        [Fact]
        public void ParseExact_With_FormatProvider_IsImplemented()
        {
            var dateString = "15/06/2008 08:30";
            var format = "g";
            var provider = new CultureInfo("fr-FR");

            var sut = new DateTimeProvider().ParseExact(dateString, format, provider);
            var expected = DateTime.ParseExact(dateString, format, provider);
            sut.Should().Be(expected);
        }

        [Fact]
        public void ParseExact_With_FormatStrings_And_DateTimeStyle_IsImplemented()
        {
            var dateString = "15/06/2008 08:30";
            var format = "g";
            var provider = new CultureInfo("fr-FR");

            var sut = new DateTimeProvider().ParseExact(dateString, new string[] { format }, provider, DateTimeStyles.NoCurrentDateDefault);
            var expected = DateTime.ParseExact(dateString, new string[] { format }, provider, DateTimeStyles.NoCurrentDateDefault);
            sut.Should().Be(expected);
        }

        [Fact]
        public void SpecifyKind_IsImplemented()
        {
            var sut = new DateTimeProvider().SpecifyKind(new DateTime(2020, 11, 1), DateTimeKind.Local);
            sut.Should().Be(DateTime.SpecifyKind(new DateTime(2020, 11, 1), DateTimeKind.Local));
        }

        [Fact]
        public void Today_IsImplemented()
        {
            var sut = new DateTimeProvider();
            sut.Today.Should().Be(DateTime.Today);
        }

        [Fact]
        public void TryParse_IsImplemented()
        {
            DateTime expected;
            DateTime.TryParse("1 Jan 2021", out expected);

            DateTime result;
            var parseResult = new DateTimeProvider().TryParse("1 Jan 2021", out result);

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

            DateTime result;
            var parseResult = new DateTimeProvider().TryParseExact(dateString, format, provider, DateTimeStyles.AdjustToUniversal, out result);

            parseResult.Should().BeTrue();
            result.Should().Be(expected);
        }

        [Fact]
        public void UtcNow_IsImplemented()
        {
            var sut = new DateTimeProvider().UtcNow;
            sut.Should().BeCloseTo(DateTime.UtcNow);
        }
    }
}