namespace DateRange;

/// <summary>
/// Models an inclusive date range with a meaningful time component.
/// </summary>
/// <param name="Start">The inclusive start date and time.</param>
/// <param name="End">The inclusive end date and time.</param>
public readonly record struct DateTimeRange(DateTime Start, DateTime End)
{
    public bool Contains(DateTime value) => Start <= value && value <= End;

    public DateOnly ToDateOnlyRange() => new(Start.Year, Start.Month, Start.Day);

    public TimeSpan ToTimeSpan() => TimeSpan.FromDays((Start - End).TotalDays);

    public double TotalWeeks => (End - Start).TotalDays / 7;

    public double TotalDays => (End - Start).TotalDays;

    public double TotalHours => (End - Start).TotalHours;

    public double TotalMinutes => (End - Start).TotalMinutes;

    public double TotalSeconds => (End - Start).TotalSeconds;

    public double TotalMilliseconds => (End - Start).TotalMilliseconds;
}