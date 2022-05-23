using Servicialsoy.Core.Domain.Entities;
using TestState.States;

namespace Servicialsoy.Core.Services
{
    public class ContractContext
    {
        public ContractState State { get; set; }
        public Contract Contract { get; set; }

        public ContractContext(Contract contract)
        {
            Contract = contract;
            State = new ContractStateDraft(this);
        }

        public void Accept(int userId)
        {
            State.Accept(userId);
        }

        public void Cancel(int userId)
        {
            State.Cancel(userId);
        }

        public void Complete(int userId)
        {
            State.Complete(userId);
        }
    }
}
