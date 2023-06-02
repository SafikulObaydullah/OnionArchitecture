﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models.Response
{
   public class GetDistrict
   {
      public int Id { get; set; }
      public string? Name { get; set; }
      public int? intDivisionId { get; set; }
      public string? CreatedBy { get; set; }
      public DateTime CreatedAt { get; set; }
      public string? UpdatedBy { get; set; }
      public DateTime UpdatedAt { get; set; }
      public bool IsActive { get; set; }
   }
}
