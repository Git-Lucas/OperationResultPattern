namespace OperationResultPattern.OperationResult;
public record GenerateInvoiceSuccess(Guid InvoiceGuid) : GenerateInvoiceResult(true);
