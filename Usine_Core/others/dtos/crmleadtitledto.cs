﻿using System;
namespace Usine_Core.others.dtos
{
    public class crmleadtitledto
    {

        public int id { get; set; }
        public string description { get; set; }
        public string branch_id { get; set; }
        public string customer_code { get; set; }
        public DateTime? created_at { get; set; }
        public DateTime? modified_at { get; set; }
    }
}
