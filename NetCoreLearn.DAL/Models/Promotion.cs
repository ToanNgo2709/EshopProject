﻿using NetCoreLearn.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreLearn.DAL.Models
{
    public class Promotion
    {
        public int Id { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public bool ApplyForAll { get; set; }
        public int? DiscountPercent { get; set; }
        public decimal? DiscountAmmount { get; set; }
        public string ProductIds { get; set; }
        public string ProductCategoryIds { get; set; }
        public Status Status { get; set; }
        public string Name { get; set; }

    }
}
