
using emplo;
using System.Security.Cryptography.X509Certificates;


List<Employee> people = new List<Employee>()
{
   new Employee("Moky", 10000, 1),
   new Employee("Doky", 12200, 2),
   new Employee("Loky", 12200, 4),
   new Employee("Shmoky", 15200, 3),
   new Employee("Miky", 11200, 5),
   new Employee("Dily", 15200, 4),
   new Employee("Fill", 16200, 3),
   new Employee("Miner", 1200, 2),
   new Employee("Dummy", 15200, 5),
   new Employee("Fruit", 11200, 1),
   new Employee("Porry", 11200, 3),
};

void getInfoAboutPeople()
{
    foreach (Employee e in people)
    {
        Console.Write(e.fio+" ");
        Console.Write(e.Salary+" ");
        Console.Write(e.Departament+"\n");
        
    }
}
void getSum() 
{
    decimal sum = 0;
    foreach(Employee e in people) 
    {
        sum += e.Salary;
    }
    Console.WriteLine($"Затраты в месяц: {sum}");
}
void getMax() 
{  
    
}
getInfoAboutPeople();
getSum();

