using System;
using System.Collections.Generic;
using System.Text;

namespace CHO.Entity
{
  public class ClientTransaction : IEntity
  {
    public int ID { get; set; }

    public int CLIENTID { get; set; }
    public decimal AMOUNT { get; set; }
    public string DESCRIPTION { get; set; }
    public DateTime CREATEDDATETTIME { get; set; }
    public DateTime? UPDATEDDATETIME { get; set; }
    public bool ISDELETED { get; set; }

    
    //Fake object
    public Client CLIENT { get; set; } 
  }
}
