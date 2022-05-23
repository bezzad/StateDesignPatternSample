namespace TestState.States
{
    public abstract class ContractState
    {
        public ContractContext Context { get; set; }
        public Contract Contract => Context?.Contract;

        public ContractState(ContractState state)
            : this(state.Context) { }

        public ContractState(ContractContext context)
        {
            Context = context;
            StateChangeCheck();
        }

        protected void ChangeState(ContractStatus status)
        {
            Console.WriteLine($"ChangeState({status})");
            Contract.Status = status;
            StateChangeCheck();
        }
        protected void StateChangeCheck()
        {
            Context.State = Contract.Status switch
            {
                ContractStatus.Draft when this is not ContractStateDraft => new ContractStateDraft(this),
                ContractStatus.Waiting when this is not ContractStateWaiting => new ContractStateWaiting(this),
                ContractStatus.Accepted when this is not ContractStateAccepted => new ContractStateAccepted(this),
                ContractStatus.Aborted or ContractStatus.Cancelled or ContractStatus.Rejected
                    when this is not ContractStateCancelled => new ContractStateCancelled(this),
                ContractStatus.Expired when this is not ContractStateExpired => new ContractStateExpired(this),
                ContractStatus.InProgress when this is not ContractStateInProgress => new ContractStateInProgress(this),
                ContractStatus.Completed when this is not ContractStateCompleted => new ContractStateCompleted(this),
                _ => this
            };
            Console.WriteLine(Contract.Status);
        }

        public virtual void Accept(int userId)
        {
            throw new InvalidOperationException($"Contract was {Contract.Status} and can't transition to this state");
        }
        public virtual void Cancel(int userId)
        {
            throw new InvalidOperationException($"Contract was {Contract.Status} can't transition to this state");
        }
        public virtual void Complete(int userId)
        {
            throw new InvalidOperationException($"Contract was {Contract.Status} can't transition to this state");
        }
    }
}
