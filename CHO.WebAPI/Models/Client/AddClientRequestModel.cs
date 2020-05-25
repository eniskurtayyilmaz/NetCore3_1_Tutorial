using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CHO.WebAPI.Models
{
  public class AddClientRequestModel
  {
    [Required]
    [MinLength(1)]
    public string ClientName { get; set; }
  }
}
