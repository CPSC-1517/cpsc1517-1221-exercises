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
        // FIELDS ------------------------------------------------
        private int _GrossWeight;
        private int _MaxGrossWeight;
        private int _TotalCars;
        List<RailCar> cars = new List<RailCar>();


        // PROPERTIES --------------------------------------------
        public Engine Engine { get; private set; }
        public List<RailCar> RailCars
        {
            get
            {
                return cars;
            }
            private set
            {
                if (true == Utilities.IsEmptyList(cars))
                {
                    cars = new List<RailCar>();
                }
            }
        }

        // CALCULATED PROPERTIES ---------------------------------
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
                int theWeight = Engine.Weight + totalCarWeight;
                _GrossWeight =+ theWeight;
                return _GrossWeight; 
            }
        }
        public int MaxGrossWeight
        {
            get 
            {
                int horsepower = Engine.Horsepower;
                _MaxGrossWeight = Utilities.MaxGrossWeight(horsepower);
                return _MaxGrossWeight;
            }
        }


        // CONSTRUCTORS ------------------------------------------
        public Train(Engine engine)
        {
            Engine = engine;
        }
        public Train()
        {

        }

        // METHODS -----------------------------------------------
        public void AddRailCar(RailCar car)
        {

            RailCars.Add(car);
            if (GrossWeight > MaxGrossWeight)
            {
                RailCars.Remove(car);
                throw new ArgumentException("Could not add new car - The Gross Weight exceeds the maximum gross weight limit");
            }
        }
        public override string ToString()
        {
            return $"{TotalCars},{GrossWeight},{MaxGrossWeight}";
        }
    }
}
