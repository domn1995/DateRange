namespace DateRange;

public static class DateTimeExtensions
{
    public static DateTime YearsAgo(this DateTime date, int years) => date.AddYears(-1 * years);

    public static DateTime MonthsAgo(this DateTime date, int months) => date.AddMonths(-1 * months);

    public static DateTime WeeksAgo(this DateTime date, double weeks) => date.AddDays(-7 * weeks);

    public static DateTime DaysAgo(this DateTime date, double days) => date.AddDays(-1 * days);

    public static DateTime MinutesAgo(this DateTime date, double minutes) => date.AddMinutes(-1 * minutes);

    public static DateTime SecondsAgo(this DateTime date, double seconds) => date.AddSeconds(-1 * seconds);

    public static DateTime MillisecondsAgo(this DateTime date, double milliseconds) => date.AddMilliseconds(-1 * milliseconds);
}