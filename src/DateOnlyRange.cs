namespace DateRange;

/// <summary>
/// Models an inclusive date range without a meaningful time range.
/// </summary>
/// <param name="Start">The inclusive start date.</param>
/// <param name="End">The inclusive end date.</param>
public readonly record struct DateOnlyRange(DateOnly Start, DateOnly End)
{
    public bool Contains(DateOnly value) => Start <= value && value <= End;

    public DateTimeRange ToDateTimeRange() => new(Start.ToDateTime(TimeOnly.MinValue), End.ToDateTime(TimeOnly.MinValue));

    public TimeSpan ToTimeSpan() => ToDateTimeRange().ToTimeSpan();

    public double TotalWeeks => ToDateTimeRange().TotalWeeks;

    public double TotalDays => ToDateTimeRange().TotalDays;

    public double TotalHours => ToDateTimeRange().TotalHours;

    public double TotalMinutes => ToDateTimeRange().TotalMinutes;
    
    public double TotalSeconds => ToDateTimeRange().TotalSeconds;

    public double TotalMilliseconds => ToDateTimeRange().TotalMilliseconds;
}