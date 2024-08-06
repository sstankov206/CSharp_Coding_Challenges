namespace Employee.Hierarchy.Repository
{

    /// <summary>
    /// Store all models into own Collections
    /// </summary>
    public class Repository
    {
        public List<Models.Employees.Employee> Employees { get; init; } = new();
        //public List<Ingrdiants> Orders { get; init; } = new() { 
        //new { Name= "Strawbery", price=1,5}

        //};
       
    }
}
