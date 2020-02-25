using System;

namespace ObjectOrientationAbusers.Switch_Statements
{
    public class Bird
    {
        private BirdType _type;
        private int _numberOfCoconuts;
        private bool _isNailed;

        public Bird(BirdType type)
        {
            _type = type;
        }

        public double GetSpeed()
        {
            switch (_type)
            {
                case BirdType.EUROPEAN:
                    return GetBaseSpeed();
                case BirdType.AFRICAN:
                    return GetBaseSpeed() - GetLoadFactor() * _numberOfCoconuts;
                case BirdType.NORWEGIAN_BLUE:
                    return _isNailed ? 0 : GetBaseSpeed();
                default:
                    throw new Exception("Should be unreachable");
            }
        }
        private double GetBaseSpeed()
        {
            return 20;
        }

        private int GetLoadFactor()
        {
            return 2;
        }
    }

    public enum BirdType
    {
        EUROPEAN,
        AFRICAN,
        NORWEGIAN_BLUE
    }
}
