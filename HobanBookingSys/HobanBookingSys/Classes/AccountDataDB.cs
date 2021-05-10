using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HobanBookingSys.Classes
{
    public class AccountDataDB : ReadWriteManager
    {
        private Dictionary<string, Account> AccountDictionry = new Dictionary<string, Account>();

        // converts and parses 4 strings into an Orginizer account
        private OrganizerAccount ConvertToOrganiserAccount(string Username, string OrganizedSessions, string SessionMade, string Password)
            => new OrganizerAccount(Username, true, ListFromString(OrganizedSessions), int.Parse(SessionMade), Password);

        // converts and parses 4 strings into a Student account
        private StudentAccount ConvertToStudentAccount(string StudentId, string Name, string Email, string BookedSessions)
    => new StudentAccount(StudentId, false, Name, Email, ListFromString(BookedSessions));

        // On initialization reads from the database (.txt file)
        public AccountDataDB()
        {
            string[] TmpDataBase = ReadFromFile(@"..\..\DBfiles\AccountDataFile.txt");
            foreach (string Line in TmpDataBase)
            {
                string[] TmpEntry = Line.Split(',');
                int tmpInt;
                if (Int32.TryParse(TmpEntry[2], out tmpInt))
                {
                    AccountDictionry.Add(TmpEntry[0], ConvertToOrganiserAccount(TmpEntry[0], TmpEntry[1], TmpEntry[2], TmpEntry[3]));
                }
                else
                {
                    AccountDictionry.Add(TmpEntry[0], ConvertToStudentAccount(TmpEntry[0], TmpEntry[1], TmpEntry[2], TmpEntry[3]));
                }
            }
        }

        // Adds a new student account to the database (and calls update)
        public void AddStudentAccount(string studentId, string name, string email)
        {
            AccountDictionry.Add(studentId, new StudentAccount(studentId, false, name, email, new List<string>()));
            UpdateFile();
        }

        // returns the account data with the matching key
        public Account FindAccount(string KeyId)
        {
            Account OutAccount;
            if (!AccountDictionry.TryGetValue(KeyId, out OutAccount))
            {
                throw new KeyNotFoundException("The account could not be found");
            }
            return OutAccount;
        }

        // Returns the Organiser account that matches the keyID if the password is correct
        //If not throws an UnauthorizedException
        public OrganizerAccount Login(string keyId, string Password)
        {
            var TmpAccount = (OrganizerAccount)FindAccount(keyId);
            if (TmpAccount.GetPassword() != Password)
            {
                throw new UnauthorizedAccessException("Invalid Password");
            }
            return TmpAccount;
        }

        // Just returns a casted Student Account
        public StudentAccount Login(string keyId) => (StudentAccount)FindAccount(keyId);

        //Writes all the data in here to the file
        public void UpdateFile()
        {
            List<string> TmpList = new List<string>();
            foreach (KeyValuePair<string, Account> entry in AccountDictionry)
            {
                TmpList.Add(entry.Value.ToString());
            }

            WriteToFile(@"..\..\DBfiles\AccountDataFile.txt", TmpList.ToArray());
        }

        // Returns a bool, checking if account that mathces the KeyId is an organiser
        public bool IsOrganiser(string KeyId) => FindAccount(KeyId).IsOrganizer;

        //Updates an account at the key position then writes to file.
        public void UpdateAccount(string keyId,Account InAccount)
        {
            AccountDictionry[keyId] = InAccount;
            UpdateFile();
        }


    }
}
