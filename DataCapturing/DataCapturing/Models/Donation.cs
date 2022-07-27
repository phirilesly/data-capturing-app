using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataCapturing.Models
{
    public class Donation
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Proof { get; set; }
        public string Day { get; set; }
        public string Month { get; set; }
        public string Type { get; set; }
        public string Beneficiary { get; set; }
        public string Location { get; set; }
      
    }
}
