using HRLib;
namespace HRAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConfirmEmployee confirmEmployee;
            try
            {
                confirmEmployee = new ConfirmEmployee();
                Console.WriteLine(confirmEmployee);
                Console.WriteLine($"Salary : {confirmEmployee.CalculateSalary()}");

            }
            catch (MinimumBasicException ex)
            {
                Console.WriteLine(ex.Message);
            }

            ConfirmEmployee confirmEmployee1 = new ConfirmEmployee(40000, "manager", "Aditya", "Nagpur");
            Console.WriteLine(confirmEmployee1);
            Console.WriteLine($"Salary : {confirmEmployee1.CalculateSalary()}");



            Trainee trainee = new Trainee();
            Console.WriteLine(trainee);
            Console.WriteLine($"Salary : {trainee.CalculateSalary()}");

            Trainee trainee1 = new Trainee(28,500,"Rohit","Pune");
            Console.WriteLine(trainee1);
            Console.WriteLine($"Salary : {trainee1.CalculateSalary()}");

        }
    }
}
