namespace ObjectOrientationAbusers.Temporary_Field
{
    public class Order
    {
        double primaryBasePrice;
        double secondaryBasePrice;
        double tertiaryBasePrice;

        public double Price()
        {
            // Perform long computation.

            return primaryBasePrice + secondaryBasePrice * tertiaryBasePrice;
        }

        public string Print()
        {
            return " ** Order **";
        }
    }
}
