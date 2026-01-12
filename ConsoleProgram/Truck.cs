using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace ConsoleProgram
{
    public class Truck : Vehicle
    {
        protected double _loadCapacity;
        protected int _numberOfAxles;

        public double LoadCapacity
        {
            get { return _loadCapacity; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Внтажопідйомність не може бути менше 0");
                _loadCapacity = value;
            }
        }

        public int NumberOfAxles
        {
            get { return _numberOfAxles; }
            set
            {
                if (value < 0 || value % 1 != 0)
                    throw new ArgumentOutOfRangeException("Кількість осей не може бути від'ємною та число не може бути дробовим");
            }
        }

        public Truck(string brand, string model, int year, decimal price, double loadCapacity, int numberOfAxles)
            : base(brand, model, year, price)
        {
            LoadCapacity = loadCapacity;
            NumberOfAxles = numberOfAxles;
        }

        public override string DisplayInfo()
        {
            return $"Вантажівка: {Brand} {Model} {Year}\nЦіна: {Price} грн\n"
                + $"Вантажопідйомність: {LoadCapacity} тонн\n Кількість осей: {NumberOfAxles}\n" +
                $"Максимальна швидкість: {this.GetMaxSpeed()} км/год\nТранспортний податок: {this.CalculateTax()} грн";
        }

        public override decimal CalculateTax()
        {
            return Price * (decimal)0.02 + (decimal)LoadCapacity * (decimal)1000;
        }

        public override double GetMaxSpeed()
        {
            return 120;
        }
    }
}
