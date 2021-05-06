using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HobanBookingSys
{
    class OrganizerAccount : Account
    {
        string[] OrganizedSession;
        int SessionsMade;
        string Password;
        

        public OrganizerAccount(string _KeyIdentifier, bool IsOrganizer, string[] OrganizedSession, int SessionsMade, string Password) : base(_KeyIdentifier, true)
        {
            this.OrganizedSession = OrganizedSession;
            this.SessionsMade = SessionsMade;
            this.Password = Password;
        }


        public override string ToString() => $"{KeyId},{ConvertToString(OrganizedSession)},{SessionsMade},{Password}";


    }
}
