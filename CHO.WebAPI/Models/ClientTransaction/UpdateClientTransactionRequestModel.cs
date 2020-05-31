using System;

namespace CHO.WebAPI.Models
{
  public class UpdateClientTransactionRequestModel
  {
    public int ClientId { get; set; }
    public DateTime Date { get; set; }
    public decimal Amount { get; set; }
    public string Description { get; set; }
  }
}