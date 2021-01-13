namespace DateTimeProviders
{
    using System;
    using System.Globalization;

    public class DateTimeOffsetProvider : IDateTimeOffsetProvider
    {
        ///<inheritdoc/>
        public DateTimeOffset MaxValue
            => DateTimeOffset.MaxValue;

        ///<inheritdoc/>
        public DateTimeOffset MinValue
            => DateTimeOffset.MinValue;

        ///<inheritdoc/>
        public DateTimeOffset Now
            => DateTimeOffset.Now;

        ///<inheritdoc/>
        public DateTimeOffset UtcNow
            => DateTimeOffset.UtcNow;

        ///<inheritdoc/>
        public DateTimeOffset FromFileTime(long fileTime)
            => DateTimeOffset.FromFileTime(fileTime);

        ///<inheritdoc/>
        public DateTimeOffset FromUnixTimeMilliseconds(long milliseconds)
            => DateTimeOffset.FromUnixTimeMilliseconds(milliseconds);

        ///<inheritdoc/>
        public DateTimeOffset FromUnixTimeSeconds(long seconds)
            => DateTimeOffset.FromUnixTimeSeconds(seconds);

        ///<inheritdoc/>
        public DateTimeOffset Parse(string input)
            => DateTimeOffset.Parse(input);

        ///<inheritdoc/>
        public DateTimeOffset Parse(string input, IFormatProvider formatProvider, DateTimeStyles styles)
            => DateTimeOffset.Parse(input, formatProvider, styles);

        ///<inheritdoc/>
        public DateTimeOffset Parse(string input, IFormatProvider formatProvider) => DateTimeOffset.Parse(input, formatProvider);

        ///<inheritdoc/>
        public DateTimeOffset ParseExact(string input, string format, IFormatProvider formatProvider)
            => DateTimeOffset.ParseExact(input, format, formatProvider);

        ///<inheritdoc/>
        public DateTimeOffset ParseExact(string input, string format, IFormatProvider formatProvider, DateTimeStyles styles)
            => DateTimeOffset.ParseExact(input, format, formatProvider, styles);

        ///<inheritdoc/>
        public DateTimeOffset ParseExact(string input, string[] formats, IFormatProvider formatProvider, DateTimeStyles styles)
            => DateTimeOffset.ParseExact(input, formats, formatProvider, styles);

        ///<inheritdoc/>
        public bool TryParse(string input, out DateTimeOffset result)
            => DateTimeOffset.TryParse(input, out result);

        ///<inheritdoc/>
        public bool TryParse(string input, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result)
            => DateTimeOffset.TryParse(input, formatProvider, styles, out result);

        ///<inheritdoc/>
        public bool TryParseExact(string input, string format, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result)
            => DateTimeOffset.TryParseExact(input, format, formatProvider, styles, out result);

        ///<inheritdoc/>
        public bool TryParseExact(string input, string[] formats, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result)
            => DateTimeOffset.TryParseExact(input, formats, formatProvider, styles, out result);
    }
}