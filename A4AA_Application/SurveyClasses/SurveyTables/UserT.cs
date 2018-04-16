using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyTables
{
    class UserT
    {
        private string fname;
        private string lname;
        private string password;
        private string active;
        private string user_roll;

        public string Fname
        {
            get => fname;
            set
            {
                if (value.Length > 255)
                    throw new ArgumentOutOfRangeException();

                fname = value;
            }
        }
        public string Lname
        {
            get => lname;
            set
            {
                if (value.Length > 255)
                    throw new ArgumentOutOfRangeException();

                lname = value;
            }
        }
        public string Password
        {
            get => password;
            set
            {
                if (value.Length > 255)
                    throw new ArgumentOutOfRangeException();

                password = value;
            }
        }
        public string Active
        {
            get => active;
            set
            {
                if (value.Length > 255)
                    throw new ArgumentOutOfRangeException();

                active = value;
            }
        }
        public string User_roll
        {
            get => user_roll;
            set
            {
                if (value.Length > 255)
                    throw new ArgumentOutOfRangeException();

                user_roll = value;
            }
        }
    }
}
