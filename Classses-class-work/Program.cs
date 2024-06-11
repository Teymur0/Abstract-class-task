namespace Classses_class_work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region person task
            //SmsSender sms= new SmsSender();
            // EmailSender email= new EmailSender();   

            // bool isTerminateApp = false;

            //repeat:
            //while (!isTerminateApp)
            //{
            //    int userCommand =int.Parse(Console.ReadLine());


            //    if (userCommand == 0)
            //    {
            //        isTerminateApp = true;
            //    }

            //    if (userCommand == 1) {

            //        email.SendMessage();
            //    }

            //    if(userCommand == 2){
            //      sms.SendMessage();
            //    }

            //    else
            //    {
            //        goto repeat;

            //    }





            //}

            #endregion
            Car car = new Car(2005, "Jaguar",  "F-type" , 220);
            Bus bus = new Bus(2002, 35);

            Vehicle[] vehicles = {car,bus };


            foreach (var vehicle in vehicles)
            {

               vehicle.ShowInfo();
            }
        }
    }
}
