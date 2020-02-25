namespace ObjectOrientationAbusers.Temporary_Field
{
    public class OrderOk
    {
        public double Price()
        {
            return new PriceCalculator(this).Compute();
        }

        public string Print()
        {
            return " ** Order **";
        }
    }

    public class PriceCalculator
    {
        private double primaryBasePrice;
        private double secondaryBasePrice;
        private double tertiaryBasePrice;

        public PriceCalculator(OrderOk order)
        {
            // Copy relevant information from the
            // order object.
        }

        public double Compute()
        {
            // Perform long computation.

            return primaryBasePrice + secondaryBasePrice * tertiaryBasePrice;
        }
    }
}
