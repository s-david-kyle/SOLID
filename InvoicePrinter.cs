namespace SOLID;

public class InvoicePrinter
{
    public void PrintInvoice(Invoice invoice)
    {
        Console.WriteLine($"Subtotal: {invoice.Subtotal}");
        Console.WriteLine($"Total: {invoice.CalculateTotal()}");
    }
}
