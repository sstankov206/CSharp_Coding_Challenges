namespace Employee.Hierarchy.Models.Employees
{
    public class HourlyEmployee : Employee
    {
        public decimal PayRate { get; set; }

        public override decimal AdustPay(decimal percentege)
        {
            return PayRate += PayRate * percentege;
        }
    }
}
