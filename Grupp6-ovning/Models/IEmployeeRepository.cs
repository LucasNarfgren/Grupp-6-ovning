namespace Grupp6_ovning.Models
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees { get; }
        Employee GetEmployeeById(int id);

    }
}
