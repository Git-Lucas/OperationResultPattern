using OperationResultPattern.DTOs;
using OperationResultPattern.Entities;
using OperationResultPattern.Enums;
using OperationResultPattern.OperationResult;

namespace OperationResultPattern.UseCase;
public class GenerateInvoiceUseCase
{
    public GenerateInvoiceResult Execute(InvoiceRequest invoiceRequest)
    {
        Restaurant restaurant = GetRestaurantById(invoiceRequest.RestaurantId);

        if (!invoiceRequest.HourInvoice.IsBetween(restaurant.OpeningHours.Start, restaurant.OpeningHours.End))
        {
            return new OutsideOfHours(restaurant.OpeningHours);
        }

        IEnumerable<Items> itemsUnavailable = invoiceRequest.Items
            .Where(invoiceItem => !restaurant.AvailableItems.Contains(invoiceItem));
        if (itemsUnavailable.Any())
        {
            List<string> itemsUnavailableToString = itemsUnavailable.ToList().ConvertAll(x => x.ToString());
            return new ItemsUnavailable(string.Join(",", itemsUnavailableToString));
        }

        Invoice invoice = new(invoiceRequest.RestaurantId, invoiceRequest.Items);
        return new GenerateInvoiceSuccess(invoice.Id);
    }

    private Restaurant GetRestaurantById(int restaurantId)
    {
        Restaurant restaurant = new(id: 1,
                            name: "Bella Italia Trattoria",
                            availableItems: [Items.MargheritaPizza, Items.PastaCarbonara, Items.GrilledChickenCaesarSalad],
                            openingHours: (new TimeOnly(18, 00), new TimeOnly(00, 00)));
        
        return restaurant;
    }
}
