namespace Employee.Business.Business
{
    public class EmployeeBusiness : IEmployeeBusiness
    {
        private List<EmployeeS> _employee;
        public EmployeeBusiness()
        {
            List<EmployeeS> employee = new()
            {
                new(){EmployeeId=1,Name="raghav",Position="JrD",Salary=40000,JoinDate=new DateTime(2024, 05, 10)},
                new(){EmployeeId=2,Name="aryan",Position="SrD",Salary=50000,JoinDate=new DateTime(2024, 05, 15)},
                new(){EmployeeId=3,Name="gita",Position="Sale",Salary=30000,JoinDate=new DateTime(2024, 05, 20)},
                new(){EmployeeId=4,Name="raaz",Position="SrD",Salary=41000,JoinDate=new DateTime(2024, 05, 05)},
             
            };
            _employee = employee;
        }

        public IEnumerable<EmployeeS> GetEmployee()
        {
            var result = _employee;
            return result;
        }

    }
}
