using Acme.OOProgramming.Procurement.Domain.Model.ValueObjects;
using Acme.OOProgramming.Shared.Domain.Model.ValueObjects;

namespace Acme.OOProgramming.Procurement.Domain.Model.Aggregates;

public class PurchaseOrderItem(ProductId productId, int quantity, Money unitPrice)
{
    
    public ProductId ProductId { get; } = productId ?? throw new ArgumentNullException(nameof(productId), "Product ID cannot be null");
    public int Quantity { get; } = quantity > 0 ? quantity : throw new ArgumentOutOfRangeException(nameof(quantity), "Quantity must be greater than zero.");
    public Money UnitPrice { get; } = unitPrice ?? throw new ArgumentNullException(nameof(unitPrice), "Unit Price cannot be null.");
    
    /// <summary>
    /// Calculates the total price of the item
    /// </summary>
    /// <returns>The total price as a <see cref="Money"/> object.</returns>
    public Money CalculateItemTotal() => new(UnitPrice.Amount * Quantity, UnitPrice.Currency);
}