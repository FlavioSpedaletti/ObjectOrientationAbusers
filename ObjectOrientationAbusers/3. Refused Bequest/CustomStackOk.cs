using System.Collections.Generic;
using System.Linq;

namespace ObjectOrientationAbusers._3._Refused_Bequest
{
    public class CustomStackOk
    {
        private readonly List<string> _list = new List<string>();

        public List<string> push(string item)
        {
            _list.Insert(0, item);
            return _list;
        }

        public List<string> pop()
        {
            if (!_list.Any()) return null;

            _list.RemoveAt(0);
            return _list;
        }

        public string peek()
        {
            return _list.Any() ? _list[0] : null;
        }
    }
}
