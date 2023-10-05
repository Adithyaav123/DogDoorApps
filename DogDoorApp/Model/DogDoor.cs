using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogDoorApp.Model
{
    internal class DogDoor
    {
        private Boolean open;
        public DogDoor()
        {
            this.open = false;
        }
        public void Open()
        {
            Console.WriteLine("The dog door opens.\n");
            open = true;
        }
        public void Close()
        {
            Console.WriteLine("The dog door closes.\n");
            open = false;
        }
        public Boolean IsOpen()
        {
            return open;

        }
    }
}
