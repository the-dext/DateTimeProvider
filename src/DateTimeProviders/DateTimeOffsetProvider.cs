namespace DateTimeProviders
{
    using System;
    using System.Globalization;

    public class DateTimeOffsetProvider : IDateTimeOffsetProvider
    {
        protected Func<DateTimeOffset> NowFunc = () => DateTimeOffset.Now;

        protected Func<DateTimeOffset> UtcNowFunc = () => DateTimeOffset.UtcNow;

        /// <summary>
        /// Initializes a new instance of the <see cref="DateTimeOffsetProvider"/> class.
        /// </summary>
        /// <param name="nowFunc">
        /// A replacement function to be used when Now is called. Pass null to use the default implementation.
        /// </param>
        /// <param name="utcNowFunc">
        /// A replacement function to be used when UtcNow is called. Pass null to use the default implementation.
        /// </param>
        public DateTimeOffsetProvider(Func<DateTimeOffset> nowFunc = null, Func<DateTimeOffset> utcNowFunc = null)
        {
            if (nowFunc != null)
            {
                this.NowFunc = nowFunc;
            }

            if (utcNowFunc != null)
            {
                this.UtcNowFunc = utcNowFunc;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DateTimeOffsetProvider"/> class.
        /// </summary>
        public DateTimeOffsetProvider()
        {
        }

        ///<inheritdoc/>
        public DateTimeOffset MaxValue
            => DateTimeOffset.MaxValue;

        ///<inheritdoc/>
        public DateTimeOffset MinValue
            => DateTimeOffset.MinValue;

        ///<inheritdoc/>
        public DateTimeOffset Now
            => this.NowFunc();

        ///<inheritdoc/>
        public DateTimeOffset UtcNow
            => this.UtcNowFunc();

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