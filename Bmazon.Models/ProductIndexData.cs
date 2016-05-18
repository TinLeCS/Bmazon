﻿using Bmazon.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bmazon.Models
{
    public class ProductIndexData
    {
        public IEnumerable<SellerProductModel> Products { get; set; }

        public IEnumerable<Review> Reviews { get; set; }

        [DisplayFormat(DataFormatString = "{0:0.0}")]
        public double AverageRating { get; set; }
    }
}