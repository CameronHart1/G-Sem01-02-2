using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class StudentAccount : Account
    {
        private String Name;
        private String Email;
        private String BookedSlots;
        

        public StudentAccount(String _KeyIdentifier, bool IsOrganizer, String Name, String Email, String BookedSlots) : base(_KeyIdentifier, false)
        {
            
            this.Name = Name;
            this.Email = Email;
            this.BookedSlots = BookedSlots;
        }

        public override string ToString() => $"{KeyId},{Name},{Email},{BookedSlots}";
        

    }
}
