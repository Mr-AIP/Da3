
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
    Console.WriteLine("\n1 - список всех сотрудников\n" +
      "2 - сумма затрат на зарплату\n" +
      "3 - мимнимальная зарплата\n" +
      "4 - максимальная зарплата\n" +
      "5 - средняя зарплата по сотрудникам в колекции\n" +
      "6 - вывод фио сотрудникв в колекции\n" +
      "7 - индексация зарплаты\n" +
      "8 - информация по отделам\n"+
      "9 - минимальная зарплата среди сотрудников определенного отдела\n"+
      "10- максимальная зарплата среди сотрудников определенного отдела\n" +
      "11- индексация зарплаты по определенному отделу\n"+
      "12- средняя зарплата среди сотрудиков отдела\n" +
      "13 - метод по условию вывода зарплаты сотрудников меньше числа\n"+
      "14 - метод по уловию вывода зарплаты сотрудников больше или равной числу \n"+
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
                Indexer(number);
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
                DeprtmentAvgInfo();
                              
                break;
            case 13:
                Console.WriteLine("Введите число");
                double n =double.Parse(Console.ReadLine());
                method(n);
                break;
            case 14:
                Console.WriteLine("Введите число");
                double num2 = double.Parse(Console.ReadLine());
                method2(num2);
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
            Console.Write($"id={e.Id}|{e.Fio}|{e.Salary}|{e.Department} ");
           
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
        Console.WriteLine($"Человек с самой минимальной зарплатой {people.Min(e => e.Salary + " рублей: " + e.Fio)} ");

    }

    void Indexer(double num)
    {

        foreach (Employee e in people)
        {
            e.Salary *= num;
        }
        foreach (Employee e in people)
        {
            Console.WriteLine($"{e.Fio}|{e.Salary}");
           

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

        var empInDpt = people.Where(p => p.Department == departmentID);
        if (empInDpt.Any())
        {
            foreach (var e in empInDpt)
            {
                Console.WriteLine($"{e.Id}|{e.Fio}|{e.Salary}");
            }
        }
        else
        {
            Console.WriteLine($"Отдел {departmentID} не найден или не имеет сотрудников.");
        }
    }

    void DeprtmentAvgInfo()
    {
       
       Console.WriteLine("Введите номер отдела");
        int dptChoi = int.Parse(Console.ReadLine());
        var empInDpt = people.Where(p => p.Department == dptChoi);
        
        var avg = empInDpt.Average(e => e.Salary);

        Console.WriteLine(avg);
         
        
        
        
    }
    void GetDepartamentSalaryMin()
    {
        Console.WriteLine("Введите номер отдела");
        double department = double.Parse(Console.ReadLine());
        var employeesInDepartment = people.Where(e => e.Department == department);
        if (employeesInDepartment.Any())
        {
            var employeeWithMinSalary = employeesInDepartment.OrderBy(e => e.Salary).First();
            Console.WriteLine($" {employeeWithMinSalary.Fio}|{employeeWithMinSalary.Salary}");
        }
        else
        {
            Console.WriteLine($"Отдел {department} не найден или не имеет сотрудников.");
        }
    }
    void GetDepartamentSalaryMax()
    {
        Console.WriteLine("Введите номер отдела"); double department = double.Parse(Console.ReadLine());
        var employeesInDepartment = people.Where(e => e.Department == department); 
        if (employeesInDepartment.Any())
        {
            var employeeWithMaxSalary = employeesInDepartment.OrderBy(e => e.Salary).Last();
            Console.WriteLine($" {employeeWithMaxSalary.Fio}|{employeeWithMaxSalary.Salary}");
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
            
           foreach(var e in employeesInDepartment)
            {
                e.Salary *= indexer;
                Console.WriteLine($"{e.Salary}");
            }

           
        }
        else
        {
            Console.WriteLine($"Отдел {department} не найден или не имеет сотрудников.");
        }
    }

    void method (double num)
    {
        var select = people.Where(p => p.Salary < num);

        foreach(var s in select)
        {
            Console.WriteLine($"{s.Id}|{s.Fio}|{s.Salary}");
        }
        
            

        


    }
    void method2(double num)
    {
        var select = people.Where(p => p.Salary >= num);

        foreach (var s in select)
        {
            Console.WriteLine($"{s.Id}|{s.Fio}|{s.Salary}");
        }






    }

}


