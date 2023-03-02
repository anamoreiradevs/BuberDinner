using BubberDinner.Application.Common.Interfaces.Services;

namespace BubberDinner.Infrastructur.Services;
public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}