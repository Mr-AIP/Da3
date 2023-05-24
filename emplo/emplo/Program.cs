
using emplo;
using System;
using System.Linq;

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

void GetInfoAboutPeople(List<Employee> employee)
{
    foreach (Employee e in people)
    {
        Console.Write(e.Id + " ");
        Console.Write(e.Fio + " ");
        Console.Write(e.Salary + " ");
        Console.Write(e.Department + "\n");
    }
}
int GetSum(List<Employee> employee)
{
    int sum = 0;
    foreach (Employee e in people)
    {
        sum += e.Salary;
    }
    return sum;
}

void GetMax(List<Employee> employee)
{
    Employee MaxSalary;
    for (int i = 0; i < employee.Count; i++)
    {
        for (int j = i + 1; j < employee.Count; j++)
        {
            if (employee[i].Salary > employee[j].Salary)
            {
                MaxSalary = employee[i];
                employee[i] = employee[j];
                employee[j] = MaxSalary;
            }
        }
    }
    Console.Write($"{employee[employee.Count - 1].Id}" + " ");
    Console.Write($"{employee[employee.Count - 1].Fio}" + " ");
    Console.Write($"{employee[employee.Count - 1].Department}" + " ");
    Console.Write($"{employee[employee.Count - 1].Salary}\n");


}
static void GetMin(List<Employee> employee)
{
    Employee MinSalary;
    for (int i = 0; i < employee.Count; i++)
    {
        for (int j = i + 1; j < employee.Count; j++)
        {
            if (employee[i].Salary > employee[j].Salary)
            {
                MinSalary = employee[i];
                employee[i] = employee[j];
                employee[j] = MinSalary;
            }
        }
    }
    Console.Write($"{employee[0].Id}" + " ");
    Console.Write($"{employee[0].Fio}" + " ");
    Console.Write($"{employee[0].Department}" + " ");
    Console.Write($"{employee[0].Salary}\n");




}
void GetAverage(List<Employee> employee)
{

    Console.WriteLine($"{GetSum(employee) / employee.Count}");
}
void GetFio(List<Employee> employee)
{
    foreach (Employee e in people)
    {
        Console.WriteLine(e.Fio);
    }
}
bool loop = true;
while (loop)
{
    Console.WriteLine("1 - список всех сотрудников\n" +
      "2 - сумма затрат на зарплату\n" +
      "3 - мимнимальная зарплата\n" +
      "4 - максимальная зарплата\n" +
      "5 - средняя зарплата\n" +
      "6 - фио\n" +
      "7 - выйти");
    try
    {
        switch (Convert.ToInt32(Console.ReadLine()))
        {
            case 1:
                GetInfoAboutPeople(people);

                break;

            case 2:
                Console.WriteLine($"Затраты в месяц: {GetSum(people)}");

                break;

            case 3:
                GetMin(people);
                break;

            case 4:
                GetMax(people);
                break;
            case 5:
                GetAverage(people);
                break;
            case 6:
                GetFio(people);

                break;
            case 7:
                loop = false;
                break;

        }
    }
    catch
    {
        Console.Clear();
        Console.WriteLine("Вы выбрали другое значени отличное от списка выше.\nПопробуйте стнова!\nНажмите любую клавишу.");
        Console.ReadKey();
        Console.Clear();

    }
}


