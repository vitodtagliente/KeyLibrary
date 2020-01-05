using System;
using System.Collections.Generic;
using System.Text;

namespace KeyLibrary.Data
{
    class Database
    {
        public string Filename { get; private set; }

        public List<Account> Accounts { get; set; } = new List<Account>();

        public void Clear()
        {
            Accounts.Clear();
        }

        public bool Load(string filename)
        {

            return true;
        }

        public bool Save()
        {
            return Save(Filename);
        }

        public bool Save(string filename)
        {

            return true;
        }
    }
}
