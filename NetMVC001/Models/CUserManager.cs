using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetMVC001.Models
{
    public class CUserManager
    {
        private List<CUser> theUsers;
        public CUserManager()
        {
            theUsers = new List<CUser>();
        }
        public List<CUser> GetUsers()
        {
            return theUsers;
        }
        public int AddUser(CUser aUser)
        {
            CUser tmpUser = new CUser();
            tmpUser.theUniqueID = 0;
            tmpUser.theID = aUser.theID;
            tmpUser.thePW = aUser.thePW;
            tmpUser.theName = aUser.theName;
            tmpUser.theEmail = aUser.theEmail;
            tmpUser.theDate = DateTime.Now;
            aUser.theDate = tmpUser.theDate;
            theUsers.Add(tmpUser);
            return 1;
        }
        public int CheckUser(string aID, string aPW)
        {
            foreach(CUser iter in theUsers)
            {
                if(iter.theID.Equals(aID) && iter.Equals(aPW))
                {
                    return 1;
                }
            }
            return 0;
        }
    }
}