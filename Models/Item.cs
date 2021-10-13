﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace InAndOut.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        public string Borrower { get; set; }
        public string Lender { get; set; }
        [System.ComponentModel.DisplayName("Item name")]
        public string ItemName { get; set; }
    }
}
