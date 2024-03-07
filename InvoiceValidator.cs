namespace SOLID;

public class InvoiceValidator
{
    private List<Validator> _validators = new List<Validator>();
    public InvoiceValidator(List<Validator> validators)
    {
        _validators = validators;
    }

    public bool Validate(Invoice invoice)
    {
        return _validators.All(v => v.Validate(invoice));
    }
}
