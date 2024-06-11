

namespace Classses_class_work
{
    internal class Bus:Vehicle
    {
        public int PassengerCount { get; set; }

        public Bus(int year , int passengerCount):base(year)
        {
            PassengerCount = passengerCount;

        }
        public override void ShowInfo()
        {

            Console.WriteLine($"Passanger Count:{PassengerCount} -- Year: {Year}");

        }
    }
}
