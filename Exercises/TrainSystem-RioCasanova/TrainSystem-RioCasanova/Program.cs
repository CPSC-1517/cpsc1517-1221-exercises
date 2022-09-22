using TrainSystem_RioCasanova;
using TrainSystem_RioCasanova.Data;


List<Engine> Engines = new List<Engine>();

Engine CreateEngine(string model, string serialnumber, int weight, int horsepower)
{
    Engine theEngine;
    theEngine = new Engine(model, serialnumber, weight, horsepower);
    return theEngine;
}

//RailCar CreateRailCar(string serialnumber, int lightweight, int capacity,
//                        int loadlimit, bool inservice, RailCarType type)
//{
//    RailCar Car = new RailCar(serialnumber, lightweight, capacity,
//                        loadlimit, inservice, type);
//    return Car;
//}

//Train CreateTrain(Engine engine)
//{
//    Train Train = new Train(engine);
//    List<RailCar> cars = new List<RailCar>();
//    return Train;
//}




//RailCar Car1 = CreateRailCar("18172", 38800, 130000, 130200, true, RailCarType.COAL_CAR);
//Console.WriteLine(Car1.ToString());

//Train Train1 = CreateTrain(Engine1);

//Train1.AddRailCar(Car1);
//Console.WriteLine(Train1.ToString());

// TEST CASES FOR ENGINE

// valid data ************************************************************************************
//Engine Engine1 = CreateEngine("CP 8002", "48807", 147700, 4400);
//Utilities.AddEngine(Engines, Engine1);
//Console.WriteLine(Engine1.ToString());
//Utilities.RemoveEngine(Engines, Engine1);


// Model is null **********************************************************************************
//Engine Engine2 = CreateEngine( null, "48807", 147700, 4400);
//Utilities.AddEngine(Engines, Engine2);
//Console.WriteLine(Engine2.ToString());
//Utilities.RemoveEngine(Engines, Engine2);

// SerialNumber is null ***************************************************************************
//Engine Engine3 = CreateEngine("CP 8002", null, 147700, 4400);
//Utilities.AddEngine(Engines, Engine3);
//Console.WriteLine(Engine3.ToString());
//Utilities.RemoveEngine(Engines, Engine3);

// Weight is negative *****************************************************************************
Engine Engine1 = CreateEngine("CP 8002", "48807", -147700, 4400);
Utilities.AddEngine(Engines, Engine1);
Console.WriteLine(Engine1.ToString());
Utilities.RemoveEngine(Engines, Engine1);

// Weight is not in increments of 100 *************************************************************
//Engine Engine1 = CreateEngine("CP 8002", "48807", 147700, 4400);
//Utilities.AddEngine(Engines, Engine1);
//Console.WriteLine(Engine1.ToString());
//Utilities.RemoveEngine(Engines, Engine1);

// HP is negative *********************************************************************************
//Engine Engine1 = CreateEngine("CP 8002", "48807", 147700, 4400);
//Utilities.AddEngine(Engines, Engine1);
//Console.WriteLine(Engine1.ToString());
//Utilities.RemoveEngine(Engines, Engine1);

// TEST CASES FOR TRAIN
// TEST CASES FOR RAILCAR