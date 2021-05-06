using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HobanBookingSys
{
    class Account : StringArrayConverter
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
