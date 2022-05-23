using Servicialsoy.Core.Domain.Enums;
using Servicialsoy.Core.Services;

namespace TestState.States
{
    public class ContractStateWaiting : ContractState
    {
        public ContractStateWaiting(ContractState state) : base(state) { }
        public ContractStateWaiting(ContractContext context) : base(context) { }

        public override void Accept(int userId)
        {
            if (Contract.StartTime.Value.AddDays(2) < DateTime.UtcNow)
                ChangeState(ContractStatus.Expired);
            else
                ChangeState(ContractStatus.Accepted);
        }

        public override void Cancel(int userId)
        {
            ChangeState(ContractStatus.Rejected);
        }
    }
}
