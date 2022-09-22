using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace TrainSystem_RioCasanova.Data
{

    public class Engine
    {
        private string _Model;
        private string _SerialNumber;
        private int _Weight;
        private int _Horsepower;


        public string Model
        {
            get { return _Model; }
            private set 
            {
                if (Utilities.IsEmpty(value))
                {
                    throw new ArgumentNullException("Model must be declared - Model is passed in as a string");
                }
                _Model = value; 
            }
        }

        public string SerialNumber
        {
            get { return _SerialNumber; }
            private set 
            { 
                if(Utilities.IsEmpty(value)) 
                { 
                    throw new ArgumentNullException("Serial Number must be declared - Serial Number is passed in as a string");
                } 
                _SerialNumber = value; 
            }
        }
        public int Weight
        {
            get { return _Weight; }
            private set 
            {
                if (!Utilities.IsPositive(value))
                {
                    throw new Exception("Weight must be a positive Integer");
                }
                _Weight = value; 
            }
            // weight is in lbs
        }
        public int Horsepower
        {
            get { return _Horsepower; }
            private set 
            {
                if (!Utilities.IsPositive(value))
                {
                    throw new Exception("Horsepower must be a positive Integer");
                }

                if (Utilities.AcceptableHorsepower(value))
                {
                    throw new Exception("Horsepower must be an Integer between 3500 and 5500");
                }
                _Horsepower = value; 
            }
            //- Horse Power must be a positive whole number between 3500 and 5500.
            //HP is measured in 100 HP increments.
        }

        public Engine(string model, string serialnumber, int weight, int horsepower)
        {
            Model = model;
            SerialNumber = serialnumber;
            Weight = weight;
            Horsepower = horsepower;
        }

        public Engine()
        {

        }

        public override string ToString()
        {
            return $"{Model},{SerialNumber},{Weight}, {Horsepower}";
        }
    } // end of class
} // end of namespace
