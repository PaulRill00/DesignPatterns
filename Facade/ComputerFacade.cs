using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Facade
{
    class ComputerFacade
    {
        private HardDrive HardDrive;
        private CPU CPU;

        public ComputerFacade()
        {
            HardDrive = new HardDrive();
            CPU = new CPU();
        }

        public void Start()
        {
            CPU.Freeze();
            Memory.Load("dummy", HardDrive.Load());
            CPU.Jump("dummy");
            CPU.Execute();
        }
    }
}
