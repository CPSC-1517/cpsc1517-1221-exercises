namespace TrainSystem_RioCasanova.Data
{

    public class Engine
    {
        // FIELDS --------------------------------------------------------------------------
        private string _Model;
        private string _SerialNumber;
        private int _Weight;
        private int _Horsepower;

        // PROPERTIES -----------------------------------------------------------------------
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
                if (Utilities.IsEmpty(value))
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
                    throw new ArgumentOutOfRangeException("Weight must be a positive Integer");
                }
                if (Utilities.CorrectIncrementedWeight(value))
                {
                    throw new ArgumentOutOfRangeException("Weight must be in an increment of 100");
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
                    throw new ArgumentOutOfRangeException("Horsepower must be a positive Integer");
                }

                if (!Utilities.AcceptableHorsepower(value))
                {
                    throw new ArgumentOutOfRangeException("Horsepower must be an Integer between 3500 and 5500");
                }
                if (Utilities.CorrectIncrementedHorsepower(value))
                {
                    throw new ArgumentOutOfRangeException("Horsepower must be in an increment of 100");
                }
                _Horsepower = value;
            }
            //- Horse Power must be a positive whole number between 3500 and 5500.
            //HP is measured in 100 HP increments.
        }

        // CONSTRUCTORS ---------------------------------------------------------------------
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

        // METHODS --------------------------------------------------------------------------
        public override string ToString()
        {
            return $"{Model},{SerialNumber},{Weight}, {Horsepower}";
        }
    } // end of class
} // end of namespace
