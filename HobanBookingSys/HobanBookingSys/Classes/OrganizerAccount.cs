using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HobanBookingSys
{
    public class OrganizerAccount : Account
    {
        private List<string> OrganizedSession;
        private int SessionsMade;
        private string Password;

        public string GetPassword() => Password;

        public void AddSession(string SessionId)
        {
            OrganizedSession.Add(SessionId);
            SessionsMade++;
        }

        public OrganizerAccount(string _KeyIdentifier, bool IsOrganizer, List<string> OrganizedSession, int SessionsMade, string Password) : base(_KeyIdentifier, true)
        {
            this.OrganizedSession = OrganizedSession;
            this.SessionsMade = SessionsMade;
            this.Password = Password;
        }


        public override string ToString() => $"{KeyId},{ConvertToString(OrganizedSession)},{SessionsMade},{Password}";


    }
}
