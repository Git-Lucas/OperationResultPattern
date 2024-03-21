using FluentResults;

namespace OperationResultPattern.OperationResult;
public class ItemsUnavailable : Error
{
    public ItemsUnavailable(string namesItems) : base("There are items not available in the order.")
    {
        Metadata.Add(nameof(namesItems), namesItems);
    }
}