namespace BuberDinner.Application.Services;

public interface IDateTimeProvider
{
    DateTime UtcNow { get; }
}