using System;

namespace State
{

    internal class Context : IContext
    {
        private IState State { get; set; }

        public Context()
        {
            State = new StartState();
        }

        public void SetState(IState state)
        {
            this.State = state;
        }

        public void Handle()
        {
            Console.WriteLine($"Current State is {this.State}");
            State.Handle(this);
        }
    }
}
