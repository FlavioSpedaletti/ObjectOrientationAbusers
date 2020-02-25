using System.Collections.Generic;
using System.Linq;

namespace ObjectOrientationAbusers._3._Refused_Bequest
{
    public class CustomStack : List<string>
    {
        public List<string> push(string item)
        {
            Insert(0, item);
            return this;
        }

        public List<string> pop()
        {
            if (!this.Any()) return null;

            RemoveAt(0);
            return this;
        }

        public string peek()
        {
            return this.Any() ? this[0] : null;
        }
    }
}
