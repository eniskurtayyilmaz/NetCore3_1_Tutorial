using System.ComponentModel.DataAnnotations;

namespace CHO.WebAPI.Models
{
  public class UpdateClientRequestModel
  {
    [Required]
    [MinLength(1)]
    public string ClientName { get; set; }
  }
}