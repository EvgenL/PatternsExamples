// See https://aka.ms/new-console-template for more information


// var civilianShip = new SpaceShip(90, 400);
// var warShip = new SpaceShip(10, 50, 100500);
// var spaceStation = new SpaceShip();
//
// Телескопический конструктор - антипаттерн
// public class SpaceShip
// {
//     private int _speed;
//     private int _cargoCapacity;
//     private int _weaponPower;
//
//     public SpaceShip()
//     {
//     }
//     
//     public SpaceShip(int speed, int cargo)
//     {
//         _speed = speed;
//         _cargoCapacity = cargo;
//     }
//
//     public SpaceShip(int speed, int cargo, int weaponPower)
//     {
//         _speed = speed;
//         _cargoCapacity = cargo;
//         _weaponPower = weaponPower;
//     }
// }


// Билдер - паттерн
var civilianShip = SpaceShip.Build().Speed(90).CargoCapacity(400);
var warShip = SpaceShip.Build().Speed(10).CargoCapacity(50).WeaponPower(100500);
var spaceStation = SpaceShip.Build();


public class SpaceShip
{
    private int _speed;
    private int _cargoCapacity;
    private int _weaponPower;

    public static SpaceShip Build()
    {
        return new SpaceShip();
    }

    public SpaceShip Speed(int value)
    {
        _speed = value;
        return this;
    }

    public SpaceShip CargoCapacity(int value)
    {
        _cargoCapacity = value;
        return this;
    }

    public SpaceShip WeaponPower(int value)
    {
        _weaponPower = value;
        return this;
    }
}