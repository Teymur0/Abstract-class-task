
namespace Classses_class_work
{
    public class Car:Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int MaxSpeed { get; set; }



        public Car(int year, string brand, string model ,int maxSpeed):base(year)
        {
            Brand = brand;
            Model = model;
            MaxSpeed = maxSpeed;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Brand: {Brand} -  Model: {Model} - Max Speed: {MaxSpeed}  Year: {Year}");
        }
    }
}
