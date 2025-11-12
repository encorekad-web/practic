class Program
{
    static void Main()
    {
        Employee employee1 = new Employee("Иван", 80000);
        Employee employee2 = new Employee("Анна");
        employee1.Work(); 
        employee2.Work(); 
        employee1.Salary = -1000; 
    }
}