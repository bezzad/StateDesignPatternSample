namespace TestState
{
    public enum ContractStatus
    {
        Draft = 0,      // before buyer confirmation
        Waiting = 1,    // after buyer confirmation
        Accepted = 2,   // seller confirmation
        InProgress = 3, // seller in work
        Completed = 4,  // seller work completed successfully

        Rejected = 6,  // seller ignore the contract
        Aborted = 7,   // cancel after accepting the contract (No-Show)
        Expired = 8,   // seller no action on contracts after 24H !
        Cancelled = 9, // cancel after accepting the contract 
    }
}
