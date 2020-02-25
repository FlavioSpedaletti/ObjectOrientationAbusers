namespace ObjectOrientationAbusers.Switch_Statements
{
    public abstract class BirdOk
    {
        public abstract double GetSpeed();

        protected double GetBaseSpeed()
        {
            return 20;
        }
    }

    public class European : BirdOk
    {
        public override double GetSpeed()
        {
            return GetBaseSpeed();
        }
    }

    public class African : BirdOk
    {
        private int numberOfCoconuts;

        public override double GetSpeed()
        {
            return GetBaseSpeed() - GetLoadFactor() * numberOfCoconuts;
        }

        protected int GetLoadFactor()
        {
            return 2;
        }
    }

    public class NorwegianBlue : BirdOk
    {
        private bool isNailed;

        public override double GetSpeed()
        {
            return isNailed ? 0 : GetBaseSpeed();
        }
    }
}
