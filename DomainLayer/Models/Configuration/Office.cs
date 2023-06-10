﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models.Configuration
{
    public class Office
    {
        public int ID { get; set; }
        public int ParentId { get; set; }
        public int MinistryOrDepartmentId { get; set; }
        public string NameE { get; set; }
        public string NameB { get; set; }
        public string Address { get; set; }
        public string? Description { get; set; }
        public bool isActive { get; set; }
        public int Creator { get; set; }
        public DateTime CreationDate { get; set; }
        public int? Modifier { get; set; }
        public DateTime? ModificationDate { get; set; }
    }
}
