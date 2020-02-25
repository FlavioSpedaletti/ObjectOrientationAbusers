using System.Collections.Generic;
using System.Linq;

namespace ObjectOrientationAbusers._3._Alternative_Classes_with_Different_Interfaces
{
    public class Department
    {
        private double _TotalAnnualCost;
        private string _name;
        private List<string> _head;

        public double getTotalAnnualCost()
        {
            return _TotalAnnualCost;
        }

        public string getName()
        {
            return _name;
        }

        public int getHeadCount()
        {
            return _head.Count();
        }
    }

    public class Employee
    {
        private double _annualCost;
        private string _name;
        private int _id;

        public double getAnnualCost()
        {
            return _annualCost;
        }

        public string getName()
        {
            return _name;
        }

        public int getId()
        {
            return _id;
        }
    }
}
