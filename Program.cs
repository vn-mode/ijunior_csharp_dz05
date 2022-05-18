using System;

namespace vn_mode_csharp_dz05
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Нагибин";
            string lastName = "Виталий";
            string bufferString;

            Console.WriteLine($"Ваше имя: {firstName}, ваша фамилия: {lastName}.");
            Console.WriteLine("Ой, кто-то перепутал местами имя и фамилию. Чтобы исправить, введите слово ИСПРАВИТЬ и нажмите ENTER.");
            Console.ReadLine();

            bufferString = lastName;
            lastName = firstName;
            firstName = bufferString;

            Console.WriteLine($"Ваше имя: {firstName}, ваша фамилия: {lastName}.");
            Console.WriteLine("Вот теперь всё правильно!");
        }
    }
}




