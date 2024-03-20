using OperationResultPattern.Enums;

namespace OperationResultPattern.OperationResult;
public record ItemsUnavailable(string NamesItems) : GenerateInvoiceFailure("There are items not available in the order.");