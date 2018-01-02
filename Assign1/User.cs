using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign1
{
    class User
    {
        private string userID = "";
        private string userName = "";
        private string userPass = "";
        private string userPic = "";
        private Cart userTourList = new Cart(false);
        private string userFont = "";
        private string userFontSize = "";
        public User(string username, string password, string picture)
        {
            userName = username;
            userPass = password;
            userPic = picture;
        }
        /*
        public String[] getDetails()
        {
            string tourList = "";
            return new String[] { userID, userName, userPass, userPic, userTourList, userFont, userFontSize };
        }
        */
    }
}
