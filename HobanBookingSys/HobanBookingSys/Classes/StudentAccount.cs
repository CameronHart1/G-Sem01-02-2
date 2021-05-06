using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HobanBookingSys
{
    class StudentAccount : Account
    {
        private string Name;
        private string Email;
        private string[] BookedSlots;
        

        public StudentAccount(string _KeyIdentifier, bool IsOrganizer, string Name, string Email, string[] BookedSlots) : base(_KeyIdentifier, false)
        {
            
            this.Name = Name;
            this.Email = Email;
            this.BookedSlots = BookedSlots;
        }

        public override string ToString() => $"{KeyId},{Name},{Email},{ConvertToString(BookedSlots)}";
        

    }
}
