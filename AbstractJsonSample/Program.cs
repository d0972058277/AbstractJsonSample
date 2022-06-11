// See https://aka.ms/new-console-template for more information
using AbstractJsonSample;
using AbstractJsonSample.DomainModels;
using AbstractJsonSample.DomainModels.Engines;
using AbstractJsonSample.DomainModels.Vehicles;

var repository = new Repository();
var man = Man.Create();

man.Buy(new ExtendedRangeElectricVehicle(new RacingEngine("Model-R")));
man.Buy(new BatteryElectricVehicle(new GeneralEngine("Model-G")));

repository.Save(man);
var m = repository.Find(man.Id);
Console.ReadLine();