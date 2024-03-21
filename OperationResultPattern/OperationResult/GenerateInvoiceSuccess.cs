using FluentResults;

namespace OperationResultPattern.OperationResult;
public class GenerateInvoiceSuccess : Success
{
    public GenerateInvoiceSuccess(Guid invoiceGuid) : base()
    {
        Metadata.Add(nameof(invoiceGuid), invoiceGuid);
    }
}
