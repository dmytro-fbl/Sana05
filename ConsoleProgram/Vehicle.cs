using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgram
{
    public class Vehicle
    {
        protected string _brand;
        protected string _model;
        protected int _year;
        protected decimal _price;

        public string Brand
        {
            get { return _brand; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Бренд не може бути порожнім");
                _brand = value; 
            }
        }
        public string Model
        {
            get { return _model; } 
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Модель не може бути пустим рядком");
                _model = value;
            }
        }
        public int Year
        {
            get { return _year; }
            set
            {
                if (value > DateTime.Now.Year || value < 1800)
                    throw new ArgumentOutOfRangeException("Рік випуску не може буьти більшим за поточний рік або меншим за 1800");
                _year = value;
            }
        }
        public decimal Price
        {
            get { return _price; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Ціна не можк бути від'ємною");
                _price = value;
            }
        }

        public Vehicle(string brand, string model, int year, decimal price)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Price = price;
        }

        public virtual string DisplayInfo()
        {
            return $"Бренд: {Brand}\n Модель: {Model}\n Рік випуску: {Year}\n Ціна: {Price} грн\n";
        }

        public virtual decimal CalculateTax()
        {
            decimal tax = (decimal)0.01;
            return Price * tax;
        }

        public virtual double GetMaxSpeed()
        {
            double maxSpeed = 100;
            return maxSpeed;
        }

    }
}
