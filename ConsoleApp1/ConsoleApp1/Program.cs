using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Car
    {
        public string x, z; //Марка и Гос номер
        public int y; // Пробег
        public void show()
        {
            Console.WriteLine($"Марка: {x} \nПробег: {y} \nНомер: {z}");
            Console.WriteLine();
            return;
        }
    }


    internal class Program
    {

        static void Main(string[] args)
        {
            Car BMW = new Car();
            BMW.x = "BMW";
            BMW.y = 145562;
            BMW.z = "А124ВЕ777";
            BMW.show();
            Car Mercedes = new Car();
            Mercedes.x = "Mercedes";
            Mercedes.y = 166662;
            Mercedes.z = "К891ОХ197";
            Mercedes.show();
            Car Volkswagen = new Car();
            Volkswagen.x = "Volkswagen";
            Volkswagen.y = 185462;
            Volkswagen.z = "М352СТ799";
            Volkswagen.show();
            Car Toyota = new Car();
            Toyota.x = "Toyota";
            Toyota.y = 147862;
            Toyota.z = "О713УК116";
            Toyota.show();
            Car Nissan = new Car();
            Nissan.x = "Nissan";
            Nissan.y = 145562;
            Nissan.z = "Р465ВН78";
            Nissan.show();
            Car Lexus = new Car();
            Lexus.x = "Lexus";
            Lexus.y = 147467;
            Lexus.z = "С902РЕ154";
            Lexus.show();
            Car Lada = new Car();
            Lada.x = "Lada";
            Lada.y = 127762;
            Lada.z = "Т238МУ93";
            Lada.show();
            Car Volga = new Car();
            Volga.x = "Volga";
            Volga.y = 165362;
            Volga.z = "У551ЕХ750";
            Volga.show();
            Car UAZ = new Car();
            UAZ.x = "UAZ";
            UAZ.y = 636700;
            UAZ.z = "Х604АО123";
            UAZ.show();
        }
    }
}
