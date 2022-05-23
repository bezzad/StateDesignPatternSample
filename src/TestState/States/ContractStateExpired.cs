namespace TestState.States
{
    public class ContractStateExpired : ContractState
    {
        public ContractStateExpired(ContractState state) : base(state) { }
        public ContractStateExpired(ContractContext context) : base(context) { }
    }
}
