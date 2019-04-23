using System;
using System.Collections.Generic;
using System.Text;

namespace SaverMate.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Value { get; set; }
        public string Notes { get; set; }
        public bool HasPositiveAction { get; set; }
        public bool HasNegativeAction { get; set; }
    }
}
