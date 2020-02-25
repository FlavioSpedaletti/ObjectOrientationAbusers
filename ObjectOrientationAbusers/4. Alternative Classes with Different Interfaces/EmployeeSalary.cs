namespace ObjectOrientationAbusers._3._Alternative_Classes_with_Different_Interfaces
{
    public class EmployeeSalary
    {
        private double _salary;

        public double fivePercentRaise()
        {
            return _salary * 1.05;
        }

        public double tenPercentRaise()
        {
            return _salary * 1.1;
        }
    }
}
