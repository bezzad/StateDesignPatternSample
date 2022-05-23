using Servicialsoy.Core.Services;

namespace TestState.States
{
    public class ContractStateCancelled : ContractState
    {
        public ContractStateCancelled(ContractState state) : base(state) { }
        public ContractStateCancelled(ContractContext context) : base(context) { }
    }
}
