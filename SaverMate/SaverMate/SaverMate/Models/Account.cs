using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic;
using System.Text;

namespace SaverMate.Models
{
    public class Account
    {
        public int Id { get; set; }
        public bool HasNegativeAction { get; set;}
        public bool HasPositiveAction { get; set; }
        public decimal Value { get; set;}
        public string Title { get; set; }
        public string Notes { get; set; }
        public decimal CurrentValue { get; set; }
        public int Lvl { get; set; }
        public decimal Xp { get; set; }
        public decimal XpTarget { get; set; }      
        public Goal CurrentGoal { get; set; }
        public ObservableCollection<Goal> Goals { get; set; }
        public bool Deleted { get; set; }
    }
}
