using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;


namespace DogDoorAppChapter3.Model
{
    internal class DogDoor
    {

        private bool open;

        public DogDoor()
        {
            this.open = false;
        }

        public void Open()
        {
            Console.WriteLine("The dog door opens.");
            open = true;

            System.Timers.Timer timer = new System.Timers.Timer(5000);
            timer.Elapsed += (sender, e) =>
            {
                Close();
                timer.Stop();
                timer.Dispose();
            };
            timer.AutoReset = false;
            timer.Start();
        }

        public void Close()
        {
            Console.WriteLine("The dog door closes.");
            open = false;
        }

        public bool IsOpen()
        {
            return open;
        }
    }
}

