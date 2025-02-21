﻿using System;
using System.Collections.Generic;

namespace Usine_Core.Models
{
    public partial class HrdDepartments
    {
        public HrdDepartments()
        {
            HrdDesignations = new HashSet<HrdDesignations>();
            HrdEmployees = new HashSet<HrdEmployees>();
        }

        public int RecordId { get; set; }
        public string MGrp { get; set; }
        public string SGrp { get; set; }
        public int? Sno { get; set; }
        public int? Chk { get; set; }
        public string GroupCode { get; set; }
        public string GrpTag { get; set; }
        public int? Statu { get; set; }
        public string Branchid { get; set; }
        public int? CustomerCode { get; set; }

        public virtual ICollection<HrdDesignations> HrdDesignations { get; set; }
        public virtual ICollection<HrdEmployees> HrdEmployees { get; set; }
    }
}
