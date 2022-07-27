using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataCapturing.Models
{
    public class Organisaztion
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string DonationType { get; set; }
        public string RegistrationNumber { get; set; }
        public string Address { get; set; }
        public string HeadOfficeLocation { get; set; }
        public string Contact { get; set; }
    }
}
