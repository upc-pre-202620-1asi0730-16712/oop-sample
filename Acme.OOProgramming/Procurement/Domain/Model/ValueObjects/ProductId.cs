namespace Acme.OOProgramming.Procurement.Domain.Model.ValueObjects;

/// <summary>
/// Represents a product identifier value object in the Procurements bounded context.
/// </summary>
public record ProductId
{
    public Guid Id { get; init; }

    public ProductId(Guid id)
    {
        if (id == Guid.Empty)
            throw new ArgumentException("Product id cannot be empty GUID", nameof(id));
        
        Id = id;
    }
    
    /// <summary>
    /// Creates a new instance of <see cref="ProductId"/>
    /// </summary>
    /// <returns>
    ///     A new <see cref="ProductId"/> instance containing a <see cref="Guid"/> object.
    /// </returns>
    public static ProductId New() => new(Guid.NewGuid());
    
    public override string ToString() => Id.ToString();
}