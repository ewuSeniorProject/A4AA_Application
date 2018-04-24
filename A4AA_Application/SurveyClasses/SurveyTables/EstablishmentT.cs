using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyQuestions;

namespace A4AA_Application.SurveyClasses.SurveyTables
{
    public class EstablishmentT
    {
        private Question est_Nam = new Est_Nam();
        private Question est_Web = new Est_Web();
        private Question est_Sub = new Est_Sub();
        private Question est_Dat = new Est_Dat();
        private Question est_Str = new Est_Str();
        private Question est_Cit = new Est_Cit();
        private Question est_Sta = new Est_Sta();
        private Question est_Zip = new Est_Zip();
        private Question est_Pho = new Est_Pho();
        private Question est_Tty = new Est_Tty();
        private Question est_Con_Fna = new Est_Con_Fna();
        private Question est_Con_Lna = new Est_Con_Lna();
        private Question est_Con_Tit = new Est_Con_Tit();
        private Question est_Con_Ema = new Est_Con_Ema();
        private Question est_Con_Com = new Est_Con_Com();

        internal Question Est_Nam { get => est_Nam; set => est_Nam = value; }
        internal Question Est_Web { get => est_Web; set => est_Web = value; }
        internal Question Est_Sub { get => est_Sub; set => est_Sub = value; }
        internal Question Est_Dat { get => est_Dat; set => est_Dat = value; }
        internal Question Est_Str { get => est_Str; set => est_Str = value; }
        internal Question Est_Cit { get => est_Cit; set => est_Cit = value; }
        internal Question Est_Sta { get => est_Sta; set => est_Sta = value; }
        internal Question Est_Zip { get => est_Zip; set => est_Zip = value; }
        internal Question Est_Pho { get => est_Pho; set => est_Pho = value; }
        internal Question Est_Tty { get => est_Tty; set => est_Tty = value; }
        internal Question Est_Con_Fna { get => est_Con_Fna; set => est_Con_Fna = value; }
        internal Question Est_Con_Lna { get => est_Con_Lna; set => est_Con_Lna = value; }
        internal Question Est_Con_Tit { get => est_Con_Tit; set => est_Con_Tit = value; }
        internal Question Est_Con_Ema { get => est_Con_Ema; set => est_Con_Ema = value; }
        internal Question Est_Con_Com { get => est_Con_Com; set => est_Con_Com = value; }

        /*private string name;
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
        }*/
    }
}
