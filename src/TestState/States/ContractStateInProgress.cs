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
