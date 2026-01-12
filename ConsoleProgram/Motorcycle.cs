using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgram
{
    public class Motorcycle : Vehicle
    {
        protected double _engineVolume;
        protected bool _hasWindshield;
        public double EngineVolume
        {
            get { return _engineVolume; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Об'єм не може бути від'ємним");
                _engineVolume = value;
            }
        }
        public bool HasWindshield
        {
            get { return _hasWindshield; }
            set
            {
                _hasWindshield = value;
            }
        }

        public Motorcycle(string brand, string model, int year, decimal price, double engineVolume, bool hasWindshield)
            : base(brand, model, year, price)
        {
            EngineVolume = engineVolume;
            HasWindshield = hasWindshield;
        }

        public override string DisplayInfo()
        {
            return $"Мотоцикл: {Brand} {Model} {Year}\nЦіна: {Price} грн\n"
                + $"Наявність вітрового вікна: {HasWindshield}\n Об'єм двигуна: {EngineVolume} см3\n" +
                $"Максимальна швидкість: {this.GetMaxSpeed()} км/год\nТранспортний податок: {this.CalculateTax()} грн";
        }

        public override decimal CalculateTax()
        {
            return Price * (decimal)0.008 + (decimal)EngineVolume * (decimal)0.5;
        }
        public override double GetMaxSpeed()
        {
            return 200;
        }
    }
}
