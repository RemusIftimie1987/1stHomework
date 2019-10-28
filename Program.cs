using System;

namespace DriverlessCarsClasses
{
    class Vehicle
    {
        public string name;
        public int year;
        public double price;
    }
    class DriverlessCar
    {
        public int automation_level;
    }
    class CompleteAutomation
    {
        public bool havePedals;
    }
    class HighAutomation
    {
        public int numberOfSensors;
    }
    class ConditionalAutomation
    {
        private bool require_human_input;
    }
    class ManualCar
    {
        public string transmission_type;
    }
    class NoAutomation
    {
        public int type;
    }
    class DriverAssistance
    {
        public string assist_functions;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
