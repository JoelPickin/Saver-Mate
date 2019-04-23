using System;
using System.Collections.Generic;
using System.Text;

namespace SaverMate.Models
{
    public class Goal
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string Name { get; set; }
        public decimal CurrentTargetValue { get; set; }
        public decimal GoalTargetValue { get; set; }
        public decimal GoalPercentage { get; set; }
        public bool GoalComplete { get; set; }
        public bool Deleted { get; set; }
    }
}
