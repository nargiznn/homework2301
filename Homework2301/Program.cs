using System;
using System.Diagnostics;
using System.Xml.Linq;

namespace Homework2301
{
    class Program
    {
        static void Main(string[] args)
        {
            Student std1 = new Student();
            do
            {
                Console.Write("Ad: ");
                std1.Name = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(std1.Name));
            do
            {
                Console.Write("Soyad: ");
                std1.Surname = Console.ReadLine();
            } while (!Student.CheckFullname(std1.Name, std1.Surname));

            do
            {
                Console.Write("GroupNo (Axxx): ");
                std1.GroupNo = Console.ReadLine();
            } while (!Student.CheckGroupNo(std1.GroupNo));
            string AgeStr;
            byte Age;
            do
            {
                Console.Write("Yaş: ");
                AgeStr = Console.ReadLine();

            } while (!byte.TryParse(AgeStr, out Age));
            std1.Age = Age;
            Console.WriteLine(std1.Fullname);
            Console.WriteLine($"Tələbə məlumatları:\nName: {std1.Name}\nSurname: {std1.Surname}\nAge: {std1.Age}\nGroupNo: {std1.GroupNo}");



        }
    }
}

