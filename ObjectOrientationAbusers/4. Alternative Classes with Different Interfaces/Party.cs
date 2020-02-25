using System.Collections.Generic;
using System.Linq;

namespace ObjectOrientationAbusers._3._Alternative_Classes_with_Different_Interfaces
{
    public abstract class Party
    {
        private double _annualCost;
        private string _name;

        public double getAnnualCost()
        {
            return _annualCost;
        }

        public string getName()
        {
            return _name;
        }
    }

    public class DepartmentOk : Party
    {
        private List<string> _head;

        public int getHeadCount()
        {
            return _head.Count();
        }
    }

    public class EmployeeOk : Party
    {
        private int _id;

        public int getId()
        {
            return _id;
        }
    }
}
