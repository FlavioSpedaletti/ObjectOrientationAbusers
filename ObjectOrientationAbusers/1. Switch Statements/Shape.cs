namespace ObjectOrientationAbusers.Switch_Statements
{
    public class Shape
    {
        private int height;
        private int width;

        public void SetValue(string name, int value)
        {
            if (name.Equals("height"))
            {
                height = value;
                return;
            }
            if (name.Equals("width"))
            {
                width = value;
                return;
            }
        }
    }
}
