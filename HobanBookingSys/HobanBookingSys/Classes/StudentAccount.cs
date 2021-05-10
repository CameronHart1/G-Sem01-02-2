using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HobanBookingSys
{
    public class StudentAccount : Account
    {
        public string Name;
        private string Email;
        private List<string> BookedSlots;

        public void AddBooking(string Id)
        {
            BookedSlots.Add(Id);
        }


        public StudentAccount(string _KeyIdentifier, bool IsOrganizer, string Name, string Email, List<string> BookedSlots) : base(_KeyIdentifier, false)
        {
            this.Name = Name;
            this.Email = Email;
            this.BookedSlots = BookedSlots;
        }

        public override string ToString() => $"{KeyId},{Name},{Email},{ConvertToString(BookedSlots)}";


    }
}
