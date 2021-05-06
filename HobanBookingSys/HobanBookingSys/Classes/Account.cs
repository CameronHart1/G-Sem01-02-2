using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Account
    {
        private string _KeyIdentifier;
        bool IsOrganizer;

        public Account(String _KeyIdentifier, bool IsOrganizer)
        {
            this._KeyIdentifier = _KeyIdentifier;
            this.IsOrganizer = IsOrganizer;
        }


        public string KeyId
        {
            get => _KeyIdentifier;
        }

    }
}
