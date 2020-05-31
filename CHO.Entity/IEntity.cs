using System;
using System.Collections.Generic;
using System.Text;

namespace CHO.Entity
{
  public interface IEntity
  {
    int ID { get; set; }
    DateTime CREATEDDATETTIME { get; set; }
    DateTime? UPDATEDDATETIME { get; set; }
    bool ISDELETED { get; set; }
  }
}
