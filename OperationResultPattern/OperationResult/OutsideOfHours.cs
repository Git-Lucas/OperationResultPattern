using FluentResults;

namespace OperationResultPattern.OperationResult;
public class OutsideOfHours : Error
{
    public OutsideOfHours((TimeOnly, TimeOnly) openingHours) : base("The restaurant is already closed.")
    {
        Metadata.Add(nameof(openingHours), openingHours);
    }
}
