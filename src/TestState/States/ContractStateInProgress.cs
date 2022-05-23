using Servicialsoy.Core.Domain.Enums;
using Servicialsoy.Core.Services;

namespace TestState.States
{
    public class ContractStateInProgress : ContractState
    {
        public ContractStateInProgress(ContractState state) : base(state) { }
        public ContractStateInProgress(ContractContext context) : base(context) { }

        public override void Complete(int userId)
        {
            ChangeState(ContractStatus.Completed);
        }

        public override void Cancel(int userId)
        {
            ChangeState(ContractStatus.Aborted);
        }
    }
}
