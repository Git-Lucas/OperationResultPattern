using OperationResultPattern.Enums;

namespace OperationResultPattern.DTOs;
public record InvoiceRequest(int RestaurantId, TimeOnly HourInvoice, IEnumerable<Items> Items);
