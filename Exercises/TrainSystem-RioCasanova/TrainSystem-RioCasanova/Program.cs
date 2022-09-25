using TrainSystem_RioCasanova;
using TrainSystem_RioCasanova.Data;


// INSTRUCTOR:      James Thompson
// SECTION:         A01
// CLASS:           DMIT1517
// CREATED BY:      Rio Casanova
// lAST EDITED:     2022-09-25
// PURPOSE:         The pupose of this code is to demonstrate my understanding of C# but, the intention
//                  of the code is to screen and identify trains, railcars, and their engines for certain parameters
//                  and have the code run to show that the trains can contain engines and railcars with certain 
//                  parameters. This file contains four Classes, one Enum..






// DECLARATIONS -----------------------------------------------------------------------------------------
List<Engine> Engines = new List<Engine>();
List<RailCar> RailCars = new List<RailCar>();
List<Train> Trains = new List<Train>();

// OBJECT CREATION ---------------------------------------------------------------------------------------
Engine CreateEngine(string model, string serialnumber, int weight, int horsepower)
{
    Engine theEngine;
    theEngine = new Engine(model, serialnumber, weight, horsepower);
    return theEngine;
}

RailCar CreateRailCar(string serialnumber, int lightweight, int capacity,
                        int loadlimit, bool inservice, RailCarType type)
{
    RailCar Car = new RailCar(serialnumber, lightweight, capacity,
                        loadlimit, inservice, type);
    return Car;
}

Train CreateTrain(Engine engine)
{
    Train Train = new Train(engine);
    List<RailCar> cars = new List<RailCar>();
    return Train;
}


// TESTING AND EVALUATION -----------------------------------------------------------------------------------

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
//Engine Engine1 = CreateEngine("CP 8002", "48807", -147700, 4400);
//Utilities.AddEngine(Engines, Engine1);
//Console.WriteLine(Engine1.ToString());
//Utilities.RemoveEngine(Engines, Engine1);

// Weight is not in increments of 100 *************************************************************
//Engine Engine1 = CreateEngine("CP 8002", "48807", 147770, 4400);
//Utilities.AddEngine(Engines, Engine1);
//Console.WriteLine(Engine1.ToString());
//Utilities.RemoveEngine(Engines, Engine1);

// HP is negative *********************************************************************************
//Engine Engine1 = CreateEngine("CP 8002", "48807", 147700, -4400);
//Utilities.AddEngine(Engines, Engine1);
//Console.WriteLine(Engine1.ToString());
//Utilities.RemoveEngine(Engines, Engine1);

// HP is not in increments of 100 ******************************************************************
//Engine Engine1 = CreateEngine("CP 8002", "48807", 147700, 4440);
//Utilities.AddEngine(Engines, Engine1);
//Console.WriteLine(Engine1.ToString());
//Utilities.RemoveEngine(Engines, Engine1);




// TEST CASES FOR RAILCAR
// RecordScaleWeight Full **************************************************************************
//RailCar Car1 = CreateRailCar("18172", 38800, 130000, 130200, true, RailCarType.COAL_CAR);
//Car1.RecordScaleWeight(164900);
//Console.WriteLine(Car1.ToString());

// RecordScaleWeight Not Full **********************************************************************
//RailCar Car1 = CreateRailCar("18172", 38800, 130000, 130200, true, RailCarType.COAL_CAR);
//Car1.RecordScaleWeight(144900);
//Console.WriteLine(Car1.ToString());

// Scale Error *************************************************************************************
//RailCar Car1 = CreateRailCar("18172", 38800, 130000, 130200, true, RailCarType.COAL_CAR);
//Car1.RecordScaleWeight(194490);
//Console.WriteLine(Car1.ToString());

// UnsafeLoad Error ********************************************************************************
//RailCar Car1 = CreateRailCar("18172", 38800, 130000, 130200, true, RailCarType.COAL_CAR);
//Car1.RecordScaleWeight(194490);
//Console.WriteLine(Car1.ToString());

// Invalid SerialNumber ****************************************************************************
//RailCar Car1 = CreateRailCar(null, 38800, 130000, 130200, true, RailCarType.COAL_CAR);
//Car1.RecordScaleWeight(164900);
//Console.WriteLine(Car1.ToString());

// Invalid LightWeight *****************************************************************************
//RailCar Car1 = CreateRailCar("18172", -38800, 130000, 130200, true, RailCarType.COAL_CAR);
//Car1.RecordScaleWeight(164900);
//Console.WriteLine(Car1.ToString());

// Invalid Capacity ********************************************************************************
//RailCar Car1 = CreateRailCar("18172", 38800, -130000, 130200, true, RailCarType.COAL_CAR);
//Car1.RecordScaleWeight(164900);
//Console.WriteLine(Car1.ToString());

// Invalid LoadLimit *******************************************************************************
//RailCar Car1 = CreateRailCar("18172", 38800, 130000, -130200, true, RailCarType.COAL_CAR);
//RailCar Car1 = CreateRailCar("18172", 38800, 130000, 120200, true, RailCarType.COAL_CAR);
//Car1.RecordScaleWeight(164900);
//Console.WriteLine(Car1.ToString());


// TEST CASES FOR TRAIN
// GoodWeight **************************************************************************************
//Train Train1 = CreateTrain(Engine1);
//RailCar Car1 = CreateRailCar("18172", 38800, 130000, 130200, true, RailCarType.COAL_CAR, 164500);
//Train1.AddRailCar(Car1);
//Console.WriteLine(Train1.ToString());

// Over Gross Weight *******************************************************************************
//  YOU MUST COMMENT OUT THE HORSEPOWER EXCEPTION FOR VALUES BETWEEN 3500 AND 5500 FOR TEST TO WORK
//Engine Engine1 = CreateEngine("CP 8002", "48807", 200, 200);
//Train Train1 = CreateTrain(Engine1);
//RailCar Car1 = CreateRailCar("18172", 75000, 130000, 400000, true, RailCarType.COAL_CAR);
//Car1.RecordScaleWeight(450000);
//Train1.AddRailCar(Car1);
//Console.WriteLine(Train1.ToString());