using OperationResultPattern.Enums;

namespace OperationResultPattern.Entities;
public class Invoice(int restaurantId, IEnumerable<Items> items)
{
    public Guid Id { get; } = Guid.NewGuid();
    public int RestaurantId { get; } = restaurantId;
    public IEnumerable<Items> Items { get; set; } = items;
}
