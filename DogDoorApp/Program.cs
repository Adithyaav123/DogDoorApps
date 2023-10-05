using DogDoorApp.Model;

namespace DogDoorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            DogDoor door = new DogDoor();
            Remote remote = new Remote(door);

            Console.WriteLine("Fido barks to go outside...");
            remote.PressButton();

            Console.WriteLine("\nFido has gone outside...");
            Console.WriteLine("\nFido's all done...");
            door.Close();

            try
            {
                Thread.Sleep(10000);
            }
            catch (ThreadInterruptedException te) { }

            Console.WriteLine("...but he's stuck outside!");

            Console.WriteLine("\nFido starts barking...");
            Console.WriteLine("...so Gina grabs the remote control.");
            remote.PressButton();

            Console.WriteLine("\nFido's back inside...");
            door.Close();
        }
    }

}
 