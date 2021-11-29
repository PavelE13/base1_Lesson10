using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base1_Lesson10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите угол, состоящий из целочисленнных значений в диапазоне: градусы(0-360) минуты``(0-60) секунды`(0-60)");
            Console.Write(" угловой градус := ");
            int Input1 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" минуты ``:= ");
            byte Input2 = Convert.ToByte(Console.ReadLine());
            Console.Write(" секунды `:= ");
            byte Input3 = Convert.ToByte(Console.ReadLine());
            Anglegradminsec AngleInput = new Anglegradminsec(Input1, Input2, Input3); // копия класса
            AngleInput.ToRadians(Input1, Input2, Input3); // вызов метода в радианы
            Console.ReadKey();
        }
    }
    class Anglegradminsec // Класс Угол в радианы
    {
        // Поля
        int grad;
        double gradC;
        double radian;
        byte minute;
        byte sec;
        bool flag=true;
        // Свойства 3 шт
        public int Grad // По переменной градусы
        {
            set
            {
                if (value < 0 || value > 360)
                {
                    Console.WriteLine("Ошибка ввода данных!Угловые градусы - диапазон 0-360");
                    flag = false;
                }
                else
                {
                    grad = value;
                }
            }
            get
            {
                return grad;
            }
        }
        public byte Minute // По переменной минуты
        {
            set
            {
                if (value < 0 || value > 60)
                {
                    Console.WriteLine("Ошибка ввода данных!Минуты - диапазон 0-60");
                    flag = false;
                }
                else
                {
                    minute = value;
                }
            }
            get
            {
                return minute;
            }
        }
        public byte Sec // По переменной секунды
        {
            set
            {
                if (value < 0 || value > 60)
                {
                    Console.WriteLine("Ошибка ввода данных!Секунды - диапазон 0-60");
                    flag = false;
                }
                else
                {
                    sec = value;
                }
            }
            get
            {
                return sec;
            }
        }
        public Anglegradminsec(int gradus, byte minute, byte second) // Конструктор
        {
            this.Grad = gradus;
            this.Minute = minute;
            this.Sec = second;
            if (flag)
            {
                Console.Write(" Угол: {0} градуса {1} `` {2} `", gradus, minute, second);
            }
        }
        public void ToRadians(int gradus, byte minute, byte second) // Метод в радианы
        {
            if (!flag)
            {
                Console.WriteLine(" Перевод в радианы невозможен!");
            }
            else
            {
                gradC = gradus + ((minute + (second/60)) / 60);
                radian = gradC * (Math.PI/180);
                Console.WriteLine(" успешно переведено! Результат = {0:f7} радиан.", radian);
            }
        }  
    }
}