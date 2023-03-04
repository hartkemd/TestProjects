using InterfacesTestApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesTestApp1.Classes
{
    public class Keyboard : IComputerController
    {
        public string ConnectionType { get; set; }

        public void Connect()
        {

        }

        public void CurrentKeyPressed()
        {

        }
    }
}
