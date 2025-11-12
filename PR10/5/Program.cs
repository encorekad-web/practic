using System;
class Program
{
    static void Main()
    {
        Car myCar = new Car("BMW", 150);
        myCar.Drive();
        myCar.Speed = 400;
        myCar.Drive();
        myCar.Speed = -50;
        myCar.Drive();
    }
}