using ObjectOrientationAbusers._3._Alternative_Classes_with_Different_Interfaces;
using ObjectOrientationAbusers._3._Refused_Bequest;
using ObjectOrientationAbusers.Switch_Statements;
using ObjectOrientationAbusers.Temporary_Field;

namespace ObjectOrientationAbusers
{
    class Program
    {
        static void Main(string[] args)
        {
            //1) Switch Statements: You have a complex switch operator or sequence of if statements.
            //  - Muitas condições
            Bird bird1 = new Bird(BirdType.AFRICAN);
            double speed1 = bird1.GetSpeed();
            //BirdOk bird2 = new African(); //Replace Conditional with Polymorphism
            //double speed2 = bird2.GetSpeed();

            //  - Poucas condições
            Shape shape1 = new Shape();
            shape1.SetValue("width", 5);
            //ShapeOk shape2 = new ShapeOk(); //Replace Parameter with Explicit Methods
            //shape2.SetWidth(5);

            //2) Temporary Fileds: Temporary fields get their values (and thus are needed by objects)
            //only under certain circumstances. Outside of these circumstances, they’re empty.
            Order order1 = new Order();
            double price1 = order1.Price();
            order1.Print();
            //OrderOk order2 = new OrderOk();
            //double price2 = order2.Price(); //Extract Class, Replace Method with Method Object
            //order2.Print();

            //3) Refused Bequest: If a subclass uses only some of the methods and properties inherited
            //from its parents, the hierarchy is off-kilter. The unneeded methods may simply go unused
            //or be redefined and give off exceptions.
            CustomStack stack1 = new CustomStack();
            stack1.push("item1");
            stack1.RemoveAt(10); //não pode fazer isso
            //CustomStackOk stack2 = new CustomStackOk(); //Replace Inheritance with Delegation
            //stack2.push("item1");
            //stack2.RemoveAt(10); //não existe

            //4) Alternative Classes with Different Interfaces: Two classes perform identical functions but have different method names.
            //  - Métodos que fazem a mesma coisa mas possuem um valor dinâmico
            EmployeeSalary employeeSalary1 = new EmployeeSalary();
            double salaryRaise5Pct1 = employeeSalary1.fivePercentRaise();
            double salaryRaise10Pct1 = employeeSalary1.tenPercentRaise();
            //EmployeeSalaryOk employeeSalary2 = new EmployeeSalaryOk(); //Parameterize Method
            //double salaryRaise5Pct2 = employeeSalary2.raise(0.05);
            //double salaryRaise10Pct2 = employeeSalary2.raise(0.1);

            // - Classes que apenas parte dos métodos são repetidos
            Department department1 = new Department();
            string dptoName1 = department1.getName();
            Employee employee1 = new Employee();
            string employeeName1 = employee1.getName();
            //Party department2 = new DepartmentOk(); //Extract Superclass
            //string dptoName2 = department2.getName();
            //Party employee2 = new EmployeeOk();
            //string employeeName2 = employee2.getName();
        }
    }
}
