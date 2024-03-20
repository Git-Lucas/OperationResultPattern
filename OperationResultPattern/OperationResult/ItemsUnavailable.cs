using OperationResultPattern.Enums;

namespace OperationResultPattern.OperationResult;
public record ItemsUnavailable(IEnumerable<Items> Items) : GenerateInvoiceFailure("There are items not available in the order.");