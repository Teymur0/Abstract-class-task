
namespace Classses_class_work
{
    public abstract class Vehicle
    {
        public string Color { get; set; }
        public int Year { get; set; }


        protected Vehicle(int year)
        {
            Year = year;
        }

        public abstract void ShowInfo();

    }
}
