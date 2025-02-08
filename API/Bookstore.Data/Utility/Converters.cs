using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
namespace Bookstore.Data.Utility;

public class UtcDateTimeConverter : ValueConverter<DateTime, DateTime>
{
    public UtcDateTimeConverter() : base(
        v => v.Kind == DateTimeKind.Utc ? 
        v : v.ToUniversalTime(), 
        v => DateTime.SpecifyKind(v.ToUniversalTime(), DateTimeKind.Utc)
        )
    {
    }
}