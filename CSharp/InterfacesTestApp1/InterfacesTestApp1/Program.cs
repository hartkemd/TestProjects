using InterfacesTestApp1.Classes;
using InterfacesTestApp1.Interfaces;

List<IComputerController> controllers = new List<IComputerController>();
Keyboard keyboard = new Keyboard();
GameController gameController = new GameController();
BatteryPoweredGameController batteryPoweredGameController = new BatteryPoweredGameController();
BatteryPoweredKeyboard batteryKeyboard = new BatteryPoweredKeyboard();

controllers.Add(keyboard);
controllers.Add(gameController);
controllers.Add(batteryPoweredGameController);

foreach (IComputerController controller in controllers)
{
    controller.Connect();
}

using (GameController gc = new GameController())
{

}

List<IBatteryPowered> powereds = new List<IBatteryPowered>();
powereds.Add(batteryPoweredGameController);
powereds.Add(batteryKeyboard);

Console.ReadLine();
