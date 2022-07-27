using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataCapturing.Models
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Province { get; set; }
        public string District { get; set; }
        public string Ward { get; set; }
        public string Phone { get; set; }
        public string OrganazationName { get; set; }
        public string Town { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string Address { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

    }
}
