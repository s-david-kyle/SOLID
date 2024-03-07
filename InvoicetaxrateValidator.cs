namespace SOLID;

public class InvoicetaxrateValidator : Validator
{
    public override bool Validate(Invoice invoice)
    {
        return invoice.TaxRate > 0;
    }
}
