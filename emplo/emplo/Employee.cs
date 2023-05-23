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
        private decimal _selary;
        private int _id;
        private static int count = 1;

        public Employee(string fio, decimal salary, int departament)
        {
            _departament = departament;
            _selary = salary;
            _fio = fio;
            _id = count++;

        }

        public string fio
        {
            get => _fio;
            set => _fio = value;

        }

        public int Departament
        {
            get => _departament;
            set => _departament = value;

        }

        public decimal Salary
        {
            get => _selary;
            set => _selary = value;

        }



    }
}
