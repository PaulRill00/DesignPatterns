namespace State
{
    internal class StartState : IState
    {
        private int InternalCounter { get; set; }

        public void Handle(IContext context)
        {
            this.InternalCounter++;
            if (this.InternalCounter >= 3)
            {
                context.SetState(new StopState());
            }
        }

        public override string ToString()
        {
            return "StartState";
        }
    }
}
