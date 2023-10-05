using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace DogDoorApp.Model
{
    internal class Remote
    {
        private DogDoor door;
        private System.Timers.Timer timer;

        public Remote(DogDoor door)
        {
            this.door = door;
            timer = new System.Timers.Timer(5000); 
            timer.AutoReset = false; 
            timer.Elapsed += TimerElapsed;


        }

        private void TimerElapsed(object? sender, ElapsedEventArgs e)
        {
            door.Close();
            timer.Stop();
        }

        public void PressButton()
        {
            Console.WriteLine("Pressing the remote control button...");
            if (door.IsOpen())
            {
                door.Close();
            }
            else
            {
                door.Open();


            }

        }
    }
}


