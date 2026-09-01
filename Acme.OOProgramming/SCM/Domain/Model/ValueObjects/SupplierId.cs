namespace Acme.OOProgramming.SCM.Domain.Model.ValueObjects;

public record SupplierId
{
    public string Identifier { get; init; }
    
    public SupplierId(string identifier)
    {
        if (string.IsNullOrWhiteSpace(identifier))
            throw new ArgumentException("Supplier identifier cannot be null or empty.", nameof(identifier));
        
        Identifier = identifier;
    }
}