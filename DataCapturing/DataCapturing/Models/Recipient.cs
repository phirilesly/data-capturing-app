using SQLite;
using System;

namespace DataCapturing.Models
{
   
    public class Recipient
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalId { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public string Status { get; set; }
        public string Village { get; set; }
        public string Province { get; set; }

    }


    
}