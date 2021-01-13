namespace DateTimeProviders
{
    using System;
    using System.Globalization;

    public interface IDateTimeOffsetProvider
    {
        // Summary: Represents the greatest possible value of System.DateTimeOffset. This field is read-only.
        //
        // Exceptions: T:System.ArgumentOutOfRangeException: System.DateTime.MaxValue is outside the
        // range of the current or specified culture's default calendar.
        DateTimeOffset MaxValue { get; }

        // Summary: Represents the earliest possible System.DateTimeOffset value. This field is read-only.
        DateTimeOffset MinValue { get; }

        // Summary: Gets a System.DateTimeOffset object that is set to the current date and time on
        // the current computer, with the offset set to the local time's offset from Coordinated
        // Universal Time (UTC).
        //
        // Returns: A System.DateTimeOffset object whose date and time is the current local time and
        // whose offset is the local time zone's offset from Coordinated Universal Time (UTC).
        DateTimeOffset Now { get; }

        // Summary: Gets a System.DateTimeOffset object whose date and time are set to the current
        // Coordinated Universal Time (UTC) date and time and whose offset is System.TimeSpan.Zero.
        //
        // Returns: An object whose date and time is the current Coordinated Universal Time (UTC)
        // and whose offset is System.TimeSpan.Zero.
        DateTimeOffset UtcNow { get; }

        // Summary: Converts the specified Windows file time to an equivalent local time.
        //
        // Parameters: fileTime: A Windows file time, expressed in ticks.
        //
        // Returns: An object that represents the date and time of fileTime with the offset set to
        // the local time offset.
        //
        // Exceptions: T:System.ArgumentOutOfRangeException: filetime is less than zero. -or-
        // filetime is greater than DateTimeOffset.MaxValue.Ticks.
        DateTimeOffset FromFileTime(long fileTime);

        // Summary: Converts a Unix time expressed as the number of milliseconds that have elapsed
        // since 1970-01-01T00:00:00Z to a System.DateTimeOffset value.
        //
        // Parameters: milliseconds: A Unix time, expressed as the number of milliseconds that have
        // elapsed since 1970-01-01T00:00:00Z (January 1, 1970, at 12:00 AM UTC). For Unix times
        // before this date, its value is negative.
        //
        // Returns: A date and time value that represents the same moment in time as the Unix time.
        //
        // Exceptions: T:System.ArgumentOutOfRangeException: milliseconds is less than
        // -62,135,596,800,000. -or- milliseconds is greater than 253,402,300,799,999.
        DateTimeOffset FromUnixTimeMilliseconds(long milliseconds);

        // Summary: Converts a Unix time expressed as the number of seconds that have elapsed since
        // 1970-01-01T00:00:00Z to a System.DateTimeOffset value.
        //
        // Parameters: seconds: A Unix time, expressed as the number of seconds that have elapsed
        // since 1970-01-01T00:00:00Z (January 1, 1970, at 12:00 AM UTC). For Unix times before this
        // date, its value is negative.
        //
        // Returns: A date and time value that represents the same moment in time as the Unix time.
        //
        // Exceptions: T:System.ArgumentOutOfRangeException: seconds is less than -62,135,596,800.
        // -or- seconds is greater than 253,402,300,799.
        DateTimeOffset FromUnixTimeSeconds(long seconds);

        // Summary: Converts the specified string representation of a date, time, and offset to its
        // System.DateTimeOffset equivalent.
        //
        // Parameters: input: A string that contains a date and time to convert.
        //
        // Returns: An object that is equivalent to the date and time that is contained in input.
        //
        // Exceptions: T:System.ArgumentException: The offset is greater than 14 hours or less than
        // -14 hours.
        //
        // T:System.ArgumentNullException: input is null.
        //
        // T:System.FormatException: input does not contain a valid string representation of a date
        // and time. -or- input contains the string representation of an offset value without a date
        // or time.
        DateTimeOffset Parse(string input);

        // Summary: Converts the specified string representation of a date and time to its
        // System.DateTimeOffset equivalent using the specified culture-specific format information
        // and formatting style.
        //
        // Parameters: input: A string that contains a date and time to convert.
        //
        // formatProvider: An object that provides culture-specific format information about input.
        //
        // styles: A bitwise combination of enumeration values that indicates the permitted format
        // of input. A typical value to specify is System.Globalization.DateTimeStyles.None.
        //
        // Returns: An object that is equivalent to the date and time that is contained in input as
        // specified by formatProvider and styles.
        //
        // Exceptions: T:System.ArgumentException: The offset is greater than 14 hours or less than
        // -14 hours. -or- styles is not a valid System.Globalization.DateTimeStyles value. -or-
        // styles includes an unsupported System.Globalization.DateTimeStyles value. -or- styles
        // includes System.Globalization.DateTimeStyles values that cannot be used together.
        //
        // T:System.ArgumentNullException: input is null.
        //
        // T:System.FormatException: input does not contain a valid string representation of a date
        // and time. -or- input contains the string representation of an offset value without a date
        // or time.
        DateTimeOffset Parse(string input, IFormatProvider formatProvider, DateTimeStyles styles);

        // Summary: Converts the specified string representation of a date and time to its
        // System.DateTimeOffset equivalent using the specified culture-specific format information.
        //
        // Parameters: input: A string that contains a date and time to convert.
        //
        // formatProvider: An object that provides culture-specific format information about input.
        //
        // Returns: An object that is equivalent to the date and time that is contained in input, as
        // specified by formatProvider.
        //
        // Exceptions: T:System.ArgumentException: The offset is greater than 14 hours or less than
        // -14 hours.
        //
        // T:System.ArgumentNullException: input is null.
        //
        // T:System.FormatException: input does not contain a valid string representation of a date
        // and time. -or- input contains the string representation of an offset value without a date
        // or time.
        DateTimeOffset Parse(string input, IFormatProvider formatProvider);

        // Summary: Converts the specified string representation of a date and time to its
        // System.DateTimeOffset equivalent using the specified format and culture-specific format
        // information. The format of the string representation must match the specified format exactly.
        //
        // Parameters: input: A string that contains a date and time to convert.
        //
        // format: A format specifier that defines the expected format of input.
        //
        // formatProvider: An object that supplies culture-specific formatting information about input.
        //
        // Returns: An object that is equivalent to the date and time that is contained in input as
        // specified by format and formatProvider.
        //
        // Exceptions: T:System.ArgumentException: The offset is greater than 14 hours or less than
        // -14 hours.
        //
        // T:System.ArgumentNullException: input is null. -or- format is null.
        //
        // T:System.FormatException: input is an empty string (""). -or- input does not contain a
        // valid string representation of a date and time. -or- format is an empty string. -or- The
        // hour component and the AM/PM designator in input do not agree.
        DateTimeOffset ParseExact(string input, string format, IFormatProvider formatProvider);

        // Summary: Converts the specified string representation of a date and time to its
        // System.DateTimeOffset equivalent using the specified format, culture-specific format
        // information, and style. The format of the string representation must match the specified
        // format exactly.
        //
        // Parameters: input: A string that contains a date and time to convert.
        //
        // format: A format specifier that defines the expected format of input.
        //
        // formatProvider: An object that supplies culture-specific formatting information about input.
        //
        // styles: A bitwise combination of enumeration values that indicates the permitted format
        // of input.
        //
        // Returns: An object that is equivalent to the date and time that is contained in the input
        // parameter, as specified by the format, formatProvider, and styles parameters.
        //
        // Exceptions: T:System.ArgumentException: The offset is greater than 14 hours or less than
        // -14 hours. -or- The styles parameter includes an unsupported value. -or- The styles
        // parameter contains System.Globalization.DateTimeStyles values that cannot be used together.
        //
        // T:System.ArgumentNullException: input is null. -or- format is null.
        //
        // T:System.FormatException: input is an empty string (""). -or- input does not contain a
        // valid string representation of a date and time. -or- format is an empty string. -or- The
        // hour component and the AM/PM designator in input do not agree.
        DateTimeOffset ParseExact(string input, string format, IFormatProvider formatProvider, DateTimeStyles styles);

        // Summary: Converts the specified string representation of a date and time to its
        // System.DateTimeOffset equivalent using the specified formats, culture-specific format
        // information, and style. The format of the string representation must match one of the
        // specified formats exactly.
        //
        // Parameters: input: A string that contains a date and time to convert.
        //
        // formats: An array of format specifiers that define the expected formats of input.
        //
        // formatProvider: An object that supplies culture-specific formatting information about input.
        //
        // styles: A bitwise combination of enumeration values that indicates the permitted format
        // of input.
        //
        // Returns: An object that is equivalent to the date and time that is contained in the input
        // parameter, as specified by the formats, formatProvider, and styles parameters.
        //
        // Exceptions: T:System.ArgumentException: The offset is greater than 14 hours or less than
        // -14 hours. -or- styles includes an unsupported value. -or- The styles parameter contains
        // System.Globalization.DateTimeStyles values that cannot be used together.
        //
        // T:System.ArgumentNullException: input is null.
        //
        // T:System.FormatException: input is an empty string (""). -or- input does not contain a
        // valid string representation of a date and time. -or- No element of formats contains a
        // valid format specifier.
        // -or- The hour component and the AM/PM designator in input do not agree.
        DateTimeOffset ParseExact(string input, string[] formats, IFormatProvider formatProvider, DateTimeStyles styles);

        // Summary: Tries to converts a specified string representation of a date and time to its
        // System.DateTimeOffset equivalent, and returns a value that indicates whether the
        // conversion succeeded.
        //
        // Parameters: input: A string that contains a date and time to convert.
        //
        // result: When the method returns, contains the System.DateTimeOffset equivalent to the
        // date and time of input, if the conversion succeeded, or System.DateTimeOffset.MinValue,
        // if the conversion failed. The conversion fails if the input parameter is null or does not
        // contain a valid string representation of a date and time. This parameter is passed uninitialized.
        //
        // Returns: true if the input parameter is successfully converted; otherwise, false.
        bool TryParse(string input, out DateTimeOffset result);

        // Summary: Tries to convert a specified string representation of a date and time to its
        // System.DateTimeOffset equivalent, and returns a value that indicates whether the
        // conversion succeeded.
        //
        // Parameters: input: A string that contains a date and time to convert.
        //
        // formatProvider: An object that provides culture-specific formatting information about input.
        //
        // styles: A bitwise combination of enumeration values that indicates the permitted format
        // of input.
        //
        // result: When the method returns, contains the System.DateTimeOffset value equivalent to
        // the date and time of input, if the conversion succeeded, or
        // System.DateTimeOffset.MinValue, if the conversion failed. The conversion fails if the
        // input parameter is null or does not contain a valid string representation of a date and
        // time. This parameter is passed uninitialized.
        //
        // Returns: true if the input parameter is successfully converted; otherwise, false.
        //
        // Exceptions: T:System.ArgumentException: styles includes an undefined
        // System.Globalization.DateTimeStyles value. -or-
        // System.Globalization.DateTimeStyles.NoCurrentDateDefault is not supported. -or- styles
        // includes mutually exclusive System.Globalization.DateTimeStyles values.
        bool TryParse(string input, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result);

        // Summary: Converts the specified string representation of a date and time to its
        // System.DateTimeOffset equivalent using the specified format, culture-specific format
        // information, and style. The format of the string representation must match the specified
        // format exactly.
        //
        // Parameters: input: A string that contains a date and time to convert.
        //
        // format: A format specifier that defines the required format of input.
        //
        // formatProvider: An object that supplies culture-specific formatting information about input.
        //
        // styles: A bitwise combination of enumeration values that indicates the permitted format
        // of input. A typical value to specify is None.
        //
        // result: When the method returns, contains the System.DateTimeOffset equivalent to the
        // date and time of input, if the conversion succeeded, or System.DateTimeOffset.MinValue,
        // if the conversion failed. The conversion fails if the input parameter is null, or does
        // not contain a valid string representation of a date and time in the expected format
        // defined by format and provider. This parameter is passed uninitialized.
        //
        // Returns: true if the input parameter is successfully converted; otherwise, false.
        //
        // Exceptions: T:System.ArgumentException: styles includes an undefined
        // System.Globalization.DateTimeStyles value. -or-
        // System.Globalization.DateTimeStyles.NoCurrentDateDefault is not supported. -or- styles
        // includes mutually exclusive System.Globalization.DateTimeStyles values.
        bool TryParseExact(string input, string format, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result);

        // Summary: Converts the specified string representation of a date and time to its
        // System.DateTimeOffset equivalent using the specified array of formats, culture-specific
        // format information, and style. The format of the string representation must match one of
        // the specified formats exactly.
        //
        // Parameters: input: A string that contains a date and time to convert.
        //
        // formats: An array that defines the expected formats of input.
        //
        // formatProvider: An object that supplies culture-specific formatting information about input.
        //
        // styles: A bitwise combination of enumeration values that indicates the permitted format
        // of input. A typical value to specify is None.
        //
        // result: When the method returns, contains the System.DateTimeOffset equivalent to the
        // date and time of input, if the conversion succeeded, or System.DateTimeOffset.MinValue,
        // if the conversion failed. The conversion fails if the input does not contain a valid
        // string representation of a date and time, or does not contain the date and time in the
        // expected format defined by format, or if formats is null. This parameter is passed uninitialized.
        //
        // Returns: true if the input parameter is successfully converted; otherwise, false.
        //
        // Exceptions: T:System.ArgumentException: styles includes an undefined
        // System.Globalization.DateTimeStyles value. -or-
        // System.Globalization.DateTimeStyles.NoCurrentDateDefault is not supported. -or- styles
        // includes mutually exclusive System.Globalization.DateTimeStyles values.
        bool TryParseExact(string input, string[] formats, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result);
    }
}