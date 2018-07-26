namespace SOLID._02_OpenClosed
{
    public class Employee : SalaryAdministration
    {
        public int ID { get; set; }
        public string EmployeeType { get; set; }
        public string Name { get; set; }

        public override decimal CalculateBonus(decimal salary)
        {
            return EmployeeType == "Permanent" ? salary * .1M : salary * .05M;
        }
    }
}