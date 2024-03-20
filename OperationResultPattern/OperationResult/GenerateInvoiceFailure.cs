namespace OperationResultPattern.OperationResult;
public abstract record GenerateInvoiceFailure(string Reason) : GenerateInvoiceResult(false);