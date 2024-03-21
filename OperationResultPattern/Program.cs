using FluentResults;
using OperationResultPattern.DTOs;
using OperationResultPattern.Enums;
using OperationResultPattern.UseCase;
using System.Net;

GenerateInvoiceUseCase generateInvoice = new();
InvoiceRequest invoiceRequestOutsideOfHours = new(1, new TimeOnly(00, 05), [Items.MargheritaPizza]);
InvoiceRequest invoiceRequestItemUnavailable = new(1, new TimeOnly(18, 05), [Items.GrilledSalmonFillet]);
InvoiceRequest invoiceRequestValid = new(1, new TimeOnly(22, 00), [Items.MargheritaPizza]);

Result generateInvoiceResult = generateInvoice.Execute(invoiceRequestOutsideOfHours);
Console.WriteLine(DisplayWithHttpCode(generateInvoiceResult));

generateInvoiceResult = generateInvoice.Execute(invoiceRequestItemUnavailable);
Console.WriteLine(DisplayWithHttpCode(generateInvoiceResult));

generateInvoiceResult = generateInvoice.Execute(invoiceRequestValid);
Console.WriteLine(DisplayWithHttpCode(generateInvoiceResult));

static string DisplayWithHttpCode(Result generateInvoiceResult)
{
    return generateInvoiceResult switch
    {
        { IsSuccess: true } => $"HttpCode = {(int)HttpStatusCode.OK} {generateInvoiceResult}",
        { IsSuccess: false } => $"HttpCode = {(int)HttpStatusCode.BadRequest} {generateInvoiceResult}",
        _ => $"HttpCode = {(int)HttpStatusCode.InternalServerError} Unknown error."
    };
}