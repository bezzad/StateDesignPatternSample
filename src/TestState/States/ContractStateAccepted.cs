using Servicialsoy.Core.Domain.Enums;
using Servicialsoy.Core.Services;

namespace TestState.States
{
    public class ContractStateAccepted : ContractState
    {
        public ContractStateAccepted(ContractState state) : base(state) { }
        public ContractStateAccepted(ContractContext context) : base(context) { }

        public override void Accept(int userId)
        {
            ChangeState(ContractStatus.InProgress);
        }

        public override void Complete(int userId)
        {
            ChangeState(ContractStatus.InProgress);
        }

        public override void Cancel(int userId)
        {
            ChangeState(ContractStatus.Cancelled);
        }
    }
}
