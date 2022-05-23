namespace TestState.States
{
    public class ContractStateCompleted : ContractState
    {
        public ContractStateCompleted(ContractState state) : base(state) { }
        public ContractStateCompleted(ContractContext context) : base(context) { }
    }
}
