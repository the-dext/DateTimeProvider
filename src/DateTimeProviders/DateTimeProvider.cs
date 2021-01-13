namespace DateTimeProviders
{
    using System;
    using System.Globalization;

    public class DateTimeProvider : IDateTimeProvider
    {
        ///<inheritdoc/>
        public DateTime MaxValue
            => DateTime.MaxValue;

        ///<inheritdoc/>
        public DateTime MinValue
            => DateTime.MinValue;

        ///<inheritdoc/>
        public DateTime Now
            => DateTime.Now;

        ///<inheritdoc/>
        public DateTime Today
            => DateTime.Today;

        ///<inheritdoc/>
        public DateTime UtcNow
            => DateTime.UtcNow;

        ///<inheritdoc/>
        public int DaysInMonth(int year, int month)
            => DateTime.DaysInMonth(year, month);

        ///<inheritdoc/>
        public DateTime FromBinary(long dateData)
            => DateTime.FromBinary(dateData);

        ///<inheritdoc/>
        public DateTime FromFileTime(long fileTime)
            => DateTime.FromFileTime(fileTime);

        ///<inheritdoc/>
        public DateTime FromFileTimeUtc(long fileTime)
            => DateTime.FromFileTimeUtc(fileTime);

        ///<inheritdoc/>
        public DateTime FromOADate(double d)
            => DateTime.FromOADate(d);

        ///<inheritdoc/>
        public bool IsLeapYear(int year)
            => DateTime.IsLeapYear(year);

        ///<inheritdoc/>
        public DateTime Parse(string s, IFormatProvider provider, DateTimeStyles styles)
            => DateTime.Parse(s, provider, styles);

        ///<inheritdoc/>
        public DateTime Parse(string s, IFormatProvider provider)
            => DateTime.Parse(s, provider);

        ///<inheritdoc/>
        public DateTime Parse(string s)
            => DateTime.Parse(s);

        ///<inheritdoc/>
        public DateTime ParseExact(string s, string[] formats, IFormatProvider provider, DateTimeStyles style)
            => DateTime.ParseExact(s, formats, provider, style);

        ///<inheritdoc/>
        public DateTime ParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style)
            => DateTime.ParseExact(s, format, provider, style);

        ///<inheritdoc/>
        public DateTime ParseExact(string s, string format, IFormatProvider provider)
            => DateTime.ParseExact(s, format, provider);

        ///<inheritdoc/>
        public DateTime SpecifyKind(DateTime value, DateTimeKind kind)
            => DateTime.SpecifyKind(value, kind);

        ///<inheritdoc/>
        public bool TryParse(string s, out DateTime result)
            => DateTime.TryParse(s, out result);

        ///<inheritdoc/>
        public bool TryParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style, out DateTime result)
            => DateTime.TryParseExact(s, format, provider, style, out result);
    }
}