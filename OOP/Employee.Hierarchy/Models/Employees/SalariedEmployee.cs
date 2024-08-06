namespace Employee.Hierarchy.Models.Employees
{
    public class SalariedEmployee : Employee
    {
        public decimal Salary { get; set; }

        public override decimal AdustPay(decimal percentege)
        {
            return Salary += Salary * percentege;
        }
    }
}
