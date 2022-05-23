namespace TestState
{
    public partial class Contract
    {
        public int ServiceId { get; set; }
        public int SellerUserId { get; set; }
        public int BuyerUserId { get; set; }
        public int? BuyerAddressId { get; set; }
        public string Descriptions { get; set; }
        public int? ContractPrice { get; set; }
        public int TotalPrice { get; set; }
        public ContractStatus Status { get; set; }
        public bool IsCashPaymentEnabled { get; set; }
        public DateTime? EndTime { get; set; }
        public DateTime? StartTime { get; set; }
    }
}
