using InterfacesTestApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesTestApp1.Classes
{
    public class GameController : IComputerController, IDisposable
    {
        public void Connect()
        {

        }

        public void CurrentKeyPressed()
        {

        }

        public void Dispose()
        {
            // do whatever shutdown tasks required
        }
    }
}
