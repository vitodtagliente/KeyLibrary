using System;
using System.Collections.Generic;
using System.Text;

namespace KeyLibrary.Data
{
    class Account
    {
		public string Service { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public List<string> OptionalUsernames { get; set; } = new List<string>();
        public List<string> OptionalPasswords { get; set; } = new List<string>();
    }
}
