using OperationResultPattern.Enums;

namespace OperationResultPattern.Entities;
public class Restaurant(int id, string name, IEnumerable<Items> availableItems, (TimeOnly, TimeOnly) openingHours)
{
    public int Id { get; } = id;
    public string Name { get; private set; } = name;
    public IEnumerable<Items> AvailableItems { get; private set; } = availableItems;
    public (TimeOnly Start, TimeOnly End) OpeningHours { get; private set; } = openingHours;
}
