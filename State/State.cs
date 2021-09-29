namespace State
{
    internal interface IState
    {
        public void Handle(IContext context);
    }
}
