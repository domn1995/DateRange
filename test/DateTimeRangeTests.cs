using FluentAssertions;
using System;
using Xunit;

namespace DateRange.Test;

/// <summary>
/// Provides unit tests for <see cref="DateTimeRange"/>.
/// </summary>
public class DateTimeRangeTests
{
    [Fact]
    public void DateRange_contains_itself()
    {
        var now = DateTime.Now;
        var range = new DateTimeRange(now, now);
        range.Contains(now).Should().BeTrue();
    }
}
