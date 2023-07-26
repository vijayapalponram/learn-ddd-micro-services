namespace Domain.ValueObjects
{
    public record Money
    {
        public string Currency  { get; private set; }

        public double Value { get; private set; }

        public Money(string currency, double value){
            Currency = currency;
            Value = value;
        }
    }
}