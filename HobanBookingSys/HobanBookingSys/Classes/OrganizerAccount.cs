using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class OrganizerAccount : Account
    {
        string OrganizedSession;
        int SessionsMade;
        string Password;
        

        public OrganizerAccount(string _KeyIdentifier, bool IsOrganizer, String OrganizedSession, int SessionsMade, string Password) : base(_KeyIdentifier, true)
        {
            this.OrganizedSession = OrganizedSession;
            this.SessionsMade = SessionsMade;
            this.Password = Password;
        }


        public override string ToString() => $"{KeyId},{OrganizedSession},{SessionsMade},{Password}";


    }
}
