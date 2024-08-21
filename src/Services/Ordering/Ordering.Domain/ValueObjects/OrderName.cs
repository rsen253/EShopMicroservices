namespace Ordering.Domain.ValueObjects;

public record OrderName
{
    // adding a constant that the order name length should be 5 
    private const int DefaultLength = 5;
    public string Value { get; }
    private OrderName(string value) => Value = value;
    public static OrderName Of(string value)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(value);
        ArgumentOutOfRangeException.ThrowIfNotEqual(value.Length, DefaultLength);

        return new OrderName(value);
    }
}
