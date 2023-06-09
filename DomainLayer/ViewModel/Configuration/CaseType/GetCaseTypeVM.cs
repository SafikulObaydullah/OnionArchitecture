﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.ViewModel.Configuration.CaseType
{
    public class GetCaseTypeVM
    {
        public int ID { get; set; }
        public int CaseCategoryID { get; set; }
        public string NameE { get; set; }
        public string NameB { get; set; }
        public string Description { get; set; }
        public string AbbreviatedForm { get; set; }
        public bool isActive { get; set; }
    }
}
