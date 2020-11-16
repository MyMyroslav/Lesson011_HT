using System;

namespace Lesson011_HT_Task3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Vehicle car1 = new Car();
            car1.price = 20000;
            car1.speed = 180;
            car1.year = 2002;
            car1.x = 20;
            car1.y = 0;
            Console.WriteLine($"Price of car = {car1.price}, speed = {car1.speed}, year = {car1.year}, coordinates x: {car1.x}, y: {car1.y}");
            Console.WriteLine(" ");
            Plane plane1 = new Plane();
            plane1.price = 199999;
            plane1.speed = 800;
            plane1.year = 2018;
            plane1.x = 173;
            plane1.y = 2000;
            Console.WriteLine($"Price of plane = {plane1.price}, speed = {plane1.speed}, year = {plane1.year}, coordinates x: {plane1.x}, y: {plane1.y}, hight = {plane1.hight}, people = {plane1.count}");
            Console.WriteLine(" ");
            Ship ship1 = new Ship();
            ship1.price = 59999999;
            ship1.speed = 360;
            ship1.year = 2020;
            ship1.x = 289;
            ship1.y = 0;
            Console.WriteLine($"Price of ship = {ship1.price}, speed = {ship1.speed}, year = {ship1.year}, coordinates x: {ship1.x}, y: {ship1.y}, port = {ship1.port}, people = {ship1.countPassangers}");
            Console.WriteLine(" ");
        }
    }
}
