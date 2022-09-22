using TrainSystem_RioCasanova;
using TrainSystem_RioCasanova.Data;


// TEST CASE: GOOD WEIGHT

Engine CreateEngine(string model, string serialnumber, int weight, int horsepower)
{
    Engine theEngine;
    return theEngine = new Engine(model, serialnumber, weight, horsepower);
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


Engine Engine1 = CreateEngine("CP 8002", "48807", 147700, 4400);
Console.WriteLine(Engine1.ToString());

RailCar Car1 = CreateRailCar("18172", 38800, 130000, 130200, true, RailCarType.COAL_CAR);
Console.WriteLine(Car1.ToString());

Train Train1 = CreateTrain(Engine1);

Train1.AddRailCar(Car1);
Console.WriteLine(Train1.ToString());