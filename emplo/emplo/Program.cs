
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
bool loop = true;
while (loop)
{
    Console.WriteLine("1 - список всех сотрудников\n" +
      "2 - сумма затрат на зарплату\n" +
      "3 - мимнимальная зарплата\n" +
      "4 - максимальная зарплата\n" +
      "5 - средняя зарплата\n" +
      "6 - фио\n" +
      "7 - индексация зарплаты\n" +
      "8 - информация по отделам\n"+
      "9 - минимальная зарплата среди сотруднико определенного отдела\n"+
      "10- максимальная зарплата среди сотруднико определенного отдела\n" +
      "11- индексация зарплаты по определенному отделу\n"+
      "12 - вывод информацию о сотрудниках по условию зарплаты меньше числа\n"+
      "13 - вывод информацию о сотрудниках по условию зарплаты больше или равно числу\n" +
      "0 - выход");
    try
    {
        switch (Convert.ToInt32(Console.ReadLine()))
        {
            case 1:
                GetInfoAboutPeople(people);

                break;

            case 2:
                Console.WriteLine($"Затраты в месяц: {GetSum()}");

                break;

            case 3:
                GetMin();
                break;

            case 4:
                GetMax();
                break;
            case 5:
                GetAverage();
                break;
            case 6:
                GetFio();
                break;
            case 7:
                Console.WriteLine("Ввведите процент индексации");
                double number = Convert.ToDouble(Console.ReadLine());
                Endexer(number);
                break;
            case 8:
                DeprtmentInfo();
                break;
            case 9:
                 GetDepartamentSalaryMin();
                 break;
                case 10:
                GetDepartamentSalaryMax();
                break;
                case 11:
                IndexerDept();
                break;
                case 12:
                double num =double.Parse(Console.ReadLine());
               
                break;
            case 13:
                double n =double.Parse(Console.ReadLine());
                
                break;
            case 0:
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

    void GetInfoAboutPeople(List<Employee> employee)
    {
        foreach (Employee e in people)
        {
            Console.Write($"id={e.Id} ");
            Console.Write(e.Fio + " ");
            Console.Write(e.Salary + " ");
            Console.Write(e.Department + "\n");
        }
    }
    double GetSum()
    {
        double sum = 0;
        foreach (Employee e in people)
        {
            sum += e.Salary;
        }
        return sum;
    }

    void GetMax()
    {

        Console.WriteLine($"Человек с самой максимальной зарплатой {people.Max(e => e.Salary + " рублей: " + e.Fio)} ");
    }
    void GetMin()
    {
        people.Min(e => e.Salary + "рублей: " + e.Fio);

    }

    void Endexer(double num)
    {

        foreach (Employee e in people)
        {
            e.Salary *= num;
        }
        foreach (Employee e in people)
        {
            Console.Write($"id={e.Id} ");
            Console.Write(e.Fio + " ");
            Console.Write(e.Salary + " ");
            Console.Write(e.Department + "\n");

        }

    }
    void GetAverage()
    {
        Console.WriteLine($"Среднее значение зарплат: {people.Average(e => e.Salary)}");

    }
    void GetFio()
    {
        foreach (Employee e in people)
        {
            Console.WriteLine(e.Fio);
        }
    }
    void DeprtmentInfo()
    {

        Console.WriteLine("Введите номер отдела:");
        int departmentID = int.Parse(Console.ReadLine());
        foreach (var emp in people)
        {
            if (emp.Department == departmentID)
            {
                Console.WriteLine($"{emp.Fio} {emp.Salary}");
            }
        }
    }

    void DeprtmentAvgInfo()
    {

        Console.WriteLine("Введите номер отдела:");
        double sum = 0, avg;
        
        int departmentID = int.Parse(Console.ReadLine());
        foreach (var emp in people)
        {
            if (emp.Department == departmentID)
            {
                foreach(var e in people)
                {
                    sum += e.Salary;
                }
                avg= sum /people.Count ;
                Console.WriteLine(avg);
            }
        }

    }
    void GetDepartamentSalaryMin()
    {
        Console.WriteLine("Введите номер отдела");
        double department = double.Parse(Console.ReadLine());
        var employeesInDepartment = people.Where(e => e.Department == department);
        if (employeesInDepartment.Any())
        {
            var employeeWithMinSalary = employeesInDepartment.OrderBy(e => e.Salary).First();
            Console.WriteLine($" {employeeWithMinSalary.Fio} - {employeeWithMinSalary.Salary}");
        }
        else
        {
            Console.WriteLine($"Отдел {department} не найден или не имеет сотрудников.");
        }
    }
    void GetDepartamentSalaryMax()
    {
        Console.WriteLine("Введите номер отдела"); double department = double.Parse(Console.ReadLine());
        var employeesInDepartment = people.Where(e => e.Department == department); if (employeesInDepartment.Any())
        {
            var employeeWithMaxSalary = employeesInDepartment.OrderBy(e => e.Salary).Last();
            Console.WriteLine($" {employeeWithMaxSalary.Fio} - {employeeWithMaxSalary.Salary}");
        }
        else
        {
            Console.WriteLine($"Отдел {department} не найден или не имеет сотрудников.");
        }

    }

    void IndexerDept()
    {
        Console.WriteLine("Введите номер отдела");
        double department = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите процент индексации зарплат в отделе в формате '1,05'");
        double indexer = double.Parse(Console.ReadLine());
        var employeesInDepartment = people.Where(e => e.Department == department);
        if (employeesInDepartment.Any())
        {
            foreach( var e in people)
            {
                e.Salary *= indexer;
            }
            foreach (var e in people)
            {
                Console.WriteLine(e.Salary);
            }

        }
        else
        {
            Console.WriteLine($"Отдел {department} не найден или не имеет сотрудников.");
        }
    }

    

    
}


