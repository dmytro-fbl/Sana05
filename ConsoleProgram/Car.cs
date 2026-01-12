using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgram
{
    public class Car : Vehicle
    {
        protected int _numberOfDoors;
        protected string _fuelType;

        public int NumberOfDoors
        {
            get { return _numberOfDoors; }

            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Неможлива машина без дверей або з від'ємною кількістю дверей");
                _numberOfDoors = value;
            }
        }
        public string FuelType
        {
            get { return _fuelType; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Тип палива не може бути пустим");
                _fuelType = value;
            }

        }
        public Car(string brand, string model, int year, decimal price, int numberOfDoors, string fuelType)
            : base(brand, model, year, price)
        {
            NumberOfDoors = numberOfDoors;
            FuelType = fuelType;
        }
        public override string DisplayInfo()
        {
            return $"Легковий автомобіль: {Brand} {Model} {Year}\nКількість дверей: {NumberOfDoors}\n Тип палива: {FuelType}\n" +
                $"Максимальна швидкість: {this.GetMaxSpeed()} км/год\nТранспортний податок: {this.CalculateTax()} грн";
        }

        public override decimal CalculateTax()
        {
            decimal tax;
            if (FuelType.ToLower() == "електро")
            {
                tax = (decimal)0.005;

            }
            else
            {
                tax = (decimal)0.015;
            }

            return Price * tax;
        }
        public override double GetMaxSpeed()
        {
            double maxSpeed = 180;
            return maxSpeed;
        }

    }
}
