namespace OperationResultPattern.OperationResult;
public record OutsideOfHours((TimeOnly, TimeOnly) OpeningHours) : GenerateInvoiceFailure("The restaurant is already closed.");
