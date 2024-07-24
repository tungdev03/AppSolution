using AppSolutionData.Enum;

namespace AppSolutionData.Entities
{
	public class Transaction
	{
		public int Id { get; set; }
		public DateTime TransactionDate { get; set; }
		public int ExternalTransactionId { get; set; }
		public decimal Amount { get; set; }
		public decimal Fee { get; set; }
		public string? Result {  get; set; }
		public string? Massege { get; set; }
		public TransactionStatus Status { get; set; }
		public string? Providers { get; set; }

	}
}
