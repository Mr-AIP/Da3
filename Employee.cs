using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emplo
{
    public class Employee
    {
        private string _fio;
        private int _departament;
        private int _selary;
        private int _id;
        private static int count = 1;

        public Employee(string fio, int salary, int departament)
        {
            _departament = departament;
            _selary = salary;
            _fio = fio;
            _id = count++;

        }

        public string Fio
        {
            get => _fio;
            set => _fio = value;

        }

        public int Department
        {
            get => _departament;
            set => _departament = value;

        }

        public int Salary
        {
            get => _selary;
            set => _selary = value;

        }

        public int Id { get=> _id;}

    }
}
