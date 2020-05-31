using System;
using System.Collections.Generic;
using System.Text;

namespace CHO.Entity
{
  public class Client : IEntity
  {
    public string NAME { get; set; }
    public string EMAIL { get; set; }


    public int ID { get; set; }
    public DateTime CREATEDDATETTIME { get; set; }
    public DateTime? UPDATEDDATETIME { get; set; }
    public bool ISDELETED { get; set; }
  }
}
