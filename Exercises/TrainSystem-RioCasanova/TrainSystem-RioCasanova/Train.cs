using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TrainSystem_RioCasanova.Data
{
    public class Train
    {
        // FIELDS
        private int _GrossWeight;
        private int _MaxGrossWeight;
        private int _TotalCars;


        // PROPERTIES
        public Engine Specs { get; private set; }
        public List<RailCar> RailCars { get; private set; }
        List<RailCar> cars = new List<RailCar>();

        // CALCULATED PROPERTIES
        public int TotalCars
        {
            get 
            { 
                int numOfCars = RailCars.Count;
                _TotalCars = numOfCars;
                return _TotalCars; 
            }
        }
        public int GrossWeight
        {
            get 
            {
                int totalCarWeight = Utilities.TotalCarWeight(RailCars);
                int theWeight = totalCarWeight;
                _GrossWeight =+ theWeight;
                return _GrossWeight; 
            }
        }
        public int MaxGrossWeight
        {
            get 
            {
                int horsepower = Specs.Horsepower;
                _MaxGrossWeight = Utilities.MaxGrossWeight(horsepower);
                return _MaxGrossWeight;
            }
        }


        // CONSTRUCTORS
        public Train(Engine engine)
        {
            _GrossWeight =+ engine.Weight;
        }
        public Train()
        {

        }

        // METHODS
        public void AddRailCar(RailCar car)
        {

            RailCars.Add(car);
            if (GrossWeight > MaxGrossWeight)
            {
                RailCars.Remove(car);
                throw new Exception("Could not add new car - The Gross Weight exceeds the maximum gross weight limit");
            }
        }
        public override string ToString()
        {
            return $"{TotalCars},{GrossWeight},{MaxGrossWeight}";
        }
    }
}
