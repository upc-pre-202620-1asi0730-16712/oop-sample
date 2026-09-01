namespace Acme.OOProgramming.Shared.Domain.Model.ValueObjects;

public record Money
{
    public decimal Amount { get; init; }
    public string Currency { get; init; }
    
    public Money(decimal amount, string currency)
    {
        if (string.IsNullOrWhiteSpace(currency) || 
            currency.Length != 3)
            throw new ArgumentException("Currency must be a valid 3-letter ISO Code", nameof(currency));
        
        Amount = amount;
        Currency = currency;
    }
    
    public override string ToString() => $"{Amount} {Currency}";
    
}