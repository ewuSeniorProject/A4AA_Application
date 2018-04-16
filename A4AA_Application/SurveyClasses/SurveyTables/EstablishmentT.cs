using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyTables
{
    class EstablishmentT
    {
        private string name;
        private string webSite;
        private string subtype;
        private DateTime date;
        private string street;
        private string city;
        private string state;
        private int zip;
        private string phone;
        private string tty;
        private string contact_fname;
        private string contact_lname;
        private string contact_title;
        private string contact_email;
        private int user_id;
        private int cat_id;
        private int config_id;
        private string config_comment;

        public string Name
        {
            get => name;
            set
            {
                if (value.Length > 255)
                    throw new ArgumentOutOfRangeException();

                name = value;
            }
        }
        public string WebSite
        {
            get => webSite;
            set
            {
                if (value.Length > 255)
                    throw new ArgumentOutOfRangeException();

                webSite = value;
            }
        }
        public string Subtype
        {
            get => subtype;
            set
            {
                if (value.Length > 255)
                    throw new ArgumentOutOfRangeException();

                subtype = value;
            }
        }
        public DateTime Date
        {
            get => date;
            set
            {
                date = value;
            }
        }
        public string Street
        {
            get => street;
            set
            {
                if (value.Length > 255)
                    throw new ArgumentOutOfRangeException();

                street = value;
            }
        }
        public string City
        {
            get => city;
            set
            {
                if (value.Length > 255)
                    throw new ArgumentOutOfRangeException();

                city = value;
            }
        }
        public string State
        {
            get => state;
            set
            {
                if (value.Length > 255)
                    throw new ArgumentOutOfRangeException();

                state = value;
            }
        }
        public int Zip
        {
            get => zip;
            set
            {
                zip = value;
            }
        }
        public string Phone
        {
            get => phone;
            set
            {
                if (value.Length > 255)
                    throw new ArgumentOutOfRangeException();

                phone = value;
            }
        }
        public string Tty
        {
            get => tty;
            set
            {
                if (value.Length > 255)
                    throw new ArgumentOutOfRangeException();

                tty = value;
            }
        }
        public string Contact_fname
        {
            get => contact_fname;
            set
            {
                if (value.Length > 255)
                    throw new ArgumentOutOfRangeException();

                contact_fname = value;
            }
        }
        public string Contact_lname
        {
            get => contact_lname;
            set
            {
                if (value.Length > 255)
                    throw new ArgumentOutOfRangeException();

                contact_lname = value;
            }
        }
        public string Contact_title
        {
            get => contact_title;
            set
            {
                if (value.Length > 255)
                    throw new ArgumentOutOfRangeException();

                contact_title = value;
            }
        }
        public string Contact_email
        {
            get => contact_email;
            set
            {
                if (value.Length > 255)
                    throw new ArgumentOutOfRangeException();

                contact_email = value;
            }
        }
        public int User_id
        {
            get => user_id;
            set
            {
                user_id = value;
            }
        }
        public int Cat_id
        {
            get => cat_id;
            set
            {
                cat_id = value;
            }
        }
        public int Config_id
        {
            get => config_id;
            set
            {
                config_id = value;
            }
        }
        public string Config_comment
        {
            get => config_comment;
            set
            {
                config_comment = value;
            }
        }
    }
}
