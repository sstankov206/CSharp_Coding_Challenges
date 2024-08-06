namespace Employee.Hierarchy.Models.Employees
{
    public class Employee
    {
        public required int ID { get; init; }
        public required string Department { get; set; }
        public required string FullName { get; set; }
        public virtual decimal AdustPay(decimal percentege) { return percentege; }

        public override string ToString()
        => $"{ID}: {FullName}, {Department}";
    }
}
