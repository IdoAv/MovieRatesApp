using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRatesApp.Models
{
    public class Entry
    {
        public int EntryId { get; set; }
        public int UserId { get; set; }
        public DateTime EntryTime { get; set; }

        public virtual User User { get; set; }
    }
}
