namespace State
{
    internal class StopState : IState
    {
        public void Handle(IContext context)
        {
        }

        public override string ToString()
        {
            return "StopState";
        }
    }
}
