using Servicialsoy.Core.Domain.Enums;
using Servicialsoy.Core.Services;

namespace TestState.States
{
    public class ContractStateDraft : ContractState
    {
        public ContractStateDraft(ContractState state) : base(state) { }
        public ContractStateDraft(ContractContext context) : base(context) { }

        public override void Accept(int userId)
        {
            ChangeState(ContractStatus.Waiting);
        }

        public override void Cancel(int userId)
        {
            ChangeState(ContractStatus.Rejected);
        }
    }
}
