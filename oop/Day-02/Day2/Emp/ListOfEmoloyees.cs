using System.Collections;
namespace Day2.Emp
{
    class ListOfEmoloyees : IEnumerable<Employee>
    {
        Dictionary<short,Employee> employees = new();
        public IEnumerator<Employee> GetEnumerator()
        {
            return employees.Values.GetEnumerator();

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return employees.Values.GetEnumerator();
        }
        public void Add(Employee employee)
        {
            if (IsValidId(employee.ID))
                employees.Add(employee.ID, employee);
        }
        public bool IsValidId(short id)
        {

            if (employees.ContainsKey(id))
                return false;
            return true;
        }


    }

   
}