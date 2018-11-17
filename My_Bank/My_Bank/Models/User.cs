using System;
using System.Collections.Generic;
using System.Text;

namespace My_Bank.Models
{
    class User
    {
        public int ID { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public string password { get; set; }

        public string emailAddress { get; set; }
        
        //public ICollection<Account> Accounts { get; set; }
    }
}
