using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HobanBookingSys
{
    public class Account : StringListConverter
    {
        private string _KeyIdentifier;
        public readonly bool IsOrganizer;
        
        // initializer these 2 variables will be avaliable in any account
        public Account(string _KeyIdentifier, bool IsOrganizer)
        {
            this._KeyIdentifier = _KeyIdentifier;
            this.IsOrganizer = IsOrganizer;
        }

        // readonly property
        public string KeyId
        {
            get => _KeyIdentifier;
        }


    }
}
