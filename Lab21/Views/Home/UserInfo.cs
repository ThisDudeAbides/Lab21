using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab21.Views.Home
{
    public class UserInfo
    {
        [Required]
            public string First { get; set; }
        [Required]
            public string Last { get; set; }
        [Required]
            public string Username { get; set; }
        [Required]
            public string Password { get; set; }
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$
        ", ErrorMessage = "Bad Email!")]
        public string Email { get; set; }
            public string Address { get; set; }
            public string State { get; set; }
            public DateTime Bday { get; set; }
            public string Male { get; set; }
            public string Female { get; set; }
            public string Other { get; set; }
            
            public UserInfo()
            {
            }
            
        public UserInfo(string first, string last, string username, string password, 
            string email, string address, string state, DateTime bday, string male, string female, string other)
        {
            First = first;
            Last = last;
            Username = username;
            Password = password;
            Email = email;
            Address = address;
            State = state;
            Bday = bday;
            Male = male;
            Female = female;
            Other = other;

        }
    }
}