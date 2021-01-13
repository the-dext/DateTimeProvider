namespace DateTimeProviders
{
    using System;
    using System.Globalization;

    public interface IDateTimeProvider
    {
        // Summary: Represents the largest possible value of System.DateTime. This field is read-only.
        DateTime MaxValue { get; }

        // Summary: Represents the smallest possible value of System.DateTime. This field is read-only.
        DateTime MinValue { get; }

        // Summary: Gets a System.DateTime object that is set to the current date and time on this
        // computer, expressed as the local time.
        //
        // Returns: An object whose value is the current local date and time.
        DateTime Now { get; }

        // Summary: Gets the current date.
        //
        // Returns: An object that is set to today's date, with the time component set to 00:00:00.
        DateTime Today { get; }

        // Summary: Gets a System.DateTime object that is set to the current date and time on this
        // computer, expressed as the Coordinated Universal Time (UTC).
        //
        // Returns: An object whose value is the current UTC date and time.
        DateTime UtcNow { get; }

        // Summary: Returns the number of days in the specified month and year.
        //
        // Parameters: year: The year.
        //
        // month: The month (a number ranging from 1 to 12).
        //
        // Returns: The number of days in month for the specified year. For example, if month equals
        // 2 for February, the return value is 28 or 29 depending upon whether year is a leap year.
        //
        // Exceptions: T:System.ArgumentOutOfRangeException: month is less than 1 or greater than
        // 12. -or- year is less than 1 or greater than 9999.
        int DaysInMonth(int year, int month);

        // Summary: Deserializes a 64-bit binary value and recreates an original serialized
        // System.DateTime object.
        //
        // Parameters: dateData: A 64-bit signed integer that encodes the System.DateTime.Kind
        // property in a 2-bit field and the System.DateTime.Ticks property in a 62-bit field.
        //
        // Returns: An object that is equivalent to the System.DateTime object that was serialized
        // by the System.DateTime.ToBinary method.
        //
        // Exceptions: T:System.ArgumentException: dateData is less than System.DateTime.MinValue or
        // greater than System.DateTime.MaxValue.
        DateTime FromBinary(long dateData);

        // Summary: Converts the specified Windows file time to an equivalent local time.
        //
        // Parameters: fileTime: A Windows file time expressed in ticks.
        //
        // Returns: An object that represents the local time equivalent of the date and time
        // represented by the fileTime parameter.
        //
        // Exceptions: T:System.ArgumentOutOfRangeException: fileTime is less than 0 or represents a
        // time greater than System.DateTime.MaxValue.
        DateTime FromFileTime(long fileTime);

        // Summary: Converts the specified Windows file time to an equivalent UTC time.
        //
        // Parameters: fileTime: A Windows file time expressed in ticks.
        //
        // Returns: An object that represents the UTC time equivalent of the date and time
        // represented by the fileTime parameter.
        //
        // Exceptions: T:System.ArgumentOutOfRangeException: fileTime is less than 0 or represents a
        // time greater than System.DateTime.MaxValue.
        DateTime FromFileTimeUtc(long fileTime);

        // Summary: Returns a System.DateTime equivalent to the specified OLE Automation Date.
        //
        // Parameters: d: An OLE Automation Date value.
        //
        // Returns: An object that represents the same date and time as d.
        //
        // Exceptions: T:System.ArgumentException: The date is not a valid OLE Automation Date value.
        DateTime FromOADate(double d);

        // Summary: Returns an indication whether the specified year is a leap year.
        //
        // Parameters: year: A 4-digit year.
        //
        // Returns: true if year is a leap year; otherwise, false.
        //
        // Exceptions: T:System.ArgumentOutOfRangeException: year is less than 1 or greater than 9999.
        bool IsLeapYear(int year);

        // Summary: Converts the string representation of a date and time to its System.DateTime
        // equivalent by using culture-specific format information and formatting style.
        //
        // Parameters: s: A string that contains a date and time to convert.
        //
        // provider: An object that supplies culture-specific formatting information about s.
        //
        // styles: A bitwise combination of the enumeration values that indicates the style elements
        // that can be present in s for the parse operation to succeed, and that defines how to
        // interpret the parsed date in relation to the current time zone or the current date. A
        // typical value to specify is System.Globalization.DateTimeStyles.None.
        //
        // Returns: An object that is equivalent to the date and time contained in s, as specified
        // by provider and styles.
        //
        // Exceptions: T:System.ArgumentNullException: s is null.
        //
        // T:System.FormatException: s does not contain a valid string representation of a date and time.
        //
        // T:System.ArgumentException: styles contains an invalid combination of
        // System.Globalization.DateTimeStyles values. For example, both
        // System.Globalization.DateTimeStyles.AssumeLocal and System.Globalization.DateTimeStyles.AssumeUniversal.
        DateTime Parse(string s, IFormatProvider provider, DateTimeStyles styles);

        // Summary: Converts the string representation of a date and time to its System.DateTime
        // equivalent by using culture-specific format information.
        //
        // Parameters: s: A string that contains a date and time to convert.
        //
        // provider: An object that supplies culture-specific format information about s.
        //
        // Returns: An object that is equivalent to the date and time contained in s as specified by provider.
        //
        // Exceptions: T:System.ArgumentNullException: s is null.
        //
        // T:System.FormatException: s does not contain a valid string representation of a date and time.
        DateTime Parse(string s, IFormatProvider provider);

        // Summary: Converts the string representation of a date and time to its System.DateTime equivalent.
        //
        // Parameters: s: A string that contains a date and time to convert.
        //
        // Returns: An object that is equivalent to the date and time contained in s.
        //
        // Exceptions: T:System.ArgumentNullException: s is null.
        //
        // T:System.FormatException: s does not contain a valid string representation of a date and time.
        DateTime Parse(string s);

        // Summary: Converts the specified string representation of a date and time to its
        // System.DateTime equivalent using the specified array of formats, culture-specific format
        // information, and style. The format of the string representation must match at least one
        // of the specified formats exactly or an exception is thrown.
        //
        // Parameters: s: A string that contains a date and time to convert.
        //
        // formats: An array of allowable formats of s. For more information, see the Remarks section.
        //
        // provider: An object that supplies culture-specific format information about s.
        //
        // style: A bitwise combination of enumeration values that indicates the permitted format of
        // s. A typical value to specify is System.Globalization.DateTimeStyles.None.
        //
        // Returns: An object that is equivalent to the date and time contained in s, as specified
        // by formats, provider, and style.
        //
        // Exceptions: T:System.ArgumentNullException: s or formats is null.
        //
        // T:System.FormatException: s is an empty string. -or- an element of formats is an empty
        // string. -or- s does not contain a date and time that corresponds to any element of
        // formats. -or- The hour component and the AM/PM designator in s do not agree.
        //
        // T:System.ArgumentException: style contains an invalid combination of
        // System.Globalization.DateTimeStyles values. For example, both
        // System.Globalization.DateTimeStyles.AssumeLocal and System.Globalization.DateTimeStyles.AssumeUniversal.
        DateTime ParseExact(string s, string[] formats, IFormatProvider provider, DateTimeStyles style);

        // Summary: Converts the specified string representation of a date and time to its
        // System.DateTime equivalent using the specified format, culture-specific format
        // information, and style. The format of the string representation must match the specified
        // format exactly or an exception is thrown.
        //
        // Parameters: s: A string containing a date and time to convert.
        //
        // format: A format specifier that defines the required format of s. For more information,
        // see the Remarks section.
        //
        // provider: An object that supplies culture-specific formatting information about s.
        //
        // style: A bitwise combination of the enumeration values that provides additional
        // information about s, about style elements that may be present in s, or about the
        // conversion from s to a System.DateTime value. A typical value to specify is System.Globalization.DateTimeStyles.None.
        //
        // Returns: An object that is equivalent to the date and time contained in s, as specified
        // by format, provider, and style.
        //
        // Exceptions: T:System.ArgumentNullException: s or format is null.
        //
        // T:System.FormatException: s or format is an empty string. -or- s does not contain a date
        // and time that corresponds to the pattern specified in format. -or- The hour component and
        // the AM/PM designator in s do not agree.
        //
        // T:System.ArgumentException: style contains an invalid combination of
        // System.Globalization.DateTimeStyles values. For example, both
        // System.Globalization.DateTimeStyles.AssumeLocal and System.Globalization.DateTimeStyles.AssumeUniversal.
        DateTime ParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style);

        // Summary: Converts the specified string representation of a date and time to its
        // System.DateTime equivalent using the specified format and culture-specific format
        // information. The format of the string representation must match the specified format exactly.
        //
        // Parameters: s: A string that contains a date and time to convert.
        //
        // format: A format specifier that defines the required format of s. For more information,
        // see the Remarks section.
        //
        // provider: An object that supplies culture-specific format information about s.
        //
        // Returns: An object that is equivalent to the date and time contained in s, as specified
        // by format and provider.
        //
        // Exceptions: T:System.ArgumentNullException: s or format is null.
        //
        // T:System.FormatException: s or format is an empty string. -or- s does not contain a date
        // and time that corresponds to the pattern specified in format. -or- The hour component and
        // the AM/PM designator in s do not agree.
        DateTime ParseExact(string s, string format, IFormatProvider provider);

        // Summary: Creates a new System.DateTime object that has the same number of ticks as the
        // specified System.DateTime, but is designated as either local time, Coordinated Universal
        // Time (UTC), or neither, as indicated by the specified System.DateTimeKind value.
        //
        // Parameters: value: A date and time.
        //
        // kind: One of the enumeration values that indicates whether the new object represents
        // local time, UTC, or neither.
        //
        // Returns: A new object that has the same number of ticks as the object represented by the
        // value parameter and the System.DateTimeKind value specified by the kind parameter.
        DateTime SpecifyKind(DateTime value, DateTimeKind kind);

        // Summary: Converts the specified string representation of a date and time to its
        // System.DateTime equivalent and returns a value that indicates whether the conversion succeeded.
        //
        // Parameters: s: A string containing a date and time to convert.
        //
        // result: When this method returns, contains the System.DateTime value equivalent to the
        // date and time contained in s, if the conversion succeeded, or System.DateTime.MinValue if
        // the conversion failed. The conversion fails if the s parameter is null, is an empty
        // string (""), or does not contain a valid string representation of a date and time. This
        // parameter is passed uninitialized.
        //
        // Returns: true if the s parameter was converted successfully; otherwise, false.
        bool TryParse(string s, out DateTime result);

        // Summary: Converts the specified string representation of a date and time to its
        // System.DateTime equivalent using the specified format, culture-specific format
        // information, and style. The format of the string representation must match the specified
        // format exactly. The method returns a value that indicates whether the conversion succeeded.
        //
        // Parameters: s: A string containing a date and time to convert.
        //
        // format: The required format of s.
        //
        // provider: An object that supplies culture-specific formatting information about s.
        //
        // style: A bitwise combination of one or more enumeration values that indicate the
        // permitted format of s.
        //
        // result: When this method returns, contains the System.DateTime value equivalent to the
        // date and time contained in s, if the conversion succeeded, or System.DateTime.MinValue if
        // the conversion failed. The conversion fails if either the s or format parameter is null,
        // is an empty string, or does not contain a date and time that correspond to the pattern
        // specified in format. This parameter is passed uninitialized.
        //
        // Returns: true if s was converted successfully; otherwise, false.
        //
        // Exceptions: T:System.ArgumentException: styles is not a valid
        // System.Globalization.DateTimeStyles value. -or- styles contains an invalid combination of
        // System.Globalization.DateTimeStyles values (for example, both
        // System.Globalization.DateTimeStyles.AssumeLocal and System.Globalization.DateTimeStyles.AssumeUniversal).
        bool TryParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style, out DateTime result);
    }
}