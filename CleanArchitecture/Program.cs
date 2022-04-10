using System;
using System.Net;
using CleanArchitecture.Modules;
using Domain.UseCases;
using Ninject;

namespace CleanArchitecture
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel(new IpAddressModule());
            var useCase = kernel.Get<GetIpAddressInteractor>();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Введите ip адрес, о котором вы хотите узнать информацию:");
                
                Console.ForegroundColor = ConsoleColor.White;
                string ip = Console.ReadLine();

                bool ipIsValid = IPAddress.TryParse(ip, out IPAddress ipAdress);

                if (ipIsValid)
                {
                    var ipData = useCase.Handle(ip);

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"Информация об адресе {ip}:");
                    Console.WriteLine($"Страна: {ipData.Country}");
                    Console.WriteLine($"Город: {ipData.City}");
                    Console.WriteLine($"Широта: {ipData.Latitude}°");
                    Console.WriteLine($"Долгота: {ipData.Longitude}°");
                    Console.WriteLine($"Интернет провайдер: {ipData.InternetProvider}");
                }
                else Console.WriteLine("Введенное значение не является ip адресом", ip);

                Console.WriteLine("\n");
            }
        }
    }
}
