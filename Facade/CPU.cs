using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class CPU
    {
        private bool Frozen;
        private string Pointer;

        public void Freeze()
        {
            Frozen = true;
        }

        public void Jump(string key)
        {
            Pointer = key;
        }

        public void Execute()
        {
            var x = Memory.Read(Pointer);
            Console.WriteLine(x);
        }
    }
}
