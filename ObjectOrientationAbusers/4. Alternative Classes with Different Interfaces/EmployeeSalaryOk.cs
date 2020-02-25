namespace ObjectOrientationAbusers._3._Alternative_Classes_with_Different_Interfaces
{
    public class EmployeeSalaryOk
    {
        private double _salary;

        public double raise(double percentage)
        {
            return _salary * (1 + percentage);
        }
    }
}
