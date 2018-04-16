using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyTables
{
    class RestroomT
    {
        private string public_restroom;
        private int total_num;
        private int designated_number;
        private int num_wheelchair_sign;
        private string sign_accessable;
        private string sign_location;
        private string key_needed;
        private string comment;
        private string recommendation;

        public string Public_restroom
        {
            get => public_restroom;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                public_restroom = value;
            }
        }
        public int Total_num
        {
            get => total_num;
            set
            {
                total_num = value;
            }
        }
        public int Designated_number
        {
            get => designated_number;
            set
            {
                designated_number = value;
            }
        }
        public int Num_wheelchar_sign
        {
            get => num_wheelchair_sign;
            set
            {
                num_wheelchair_sign = value;
            }
        }
        public string Sign_accessable
        {
            get => sign_accessable;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                sign_accessable = value;
            }
        }
        public string Sign_location
        {
            get => sign_location;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                sign_location = value;
            }
        }
        public string Key_needed
        {
            get => key_needed;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                key_needed = value;
            }
        }
        public string Comment
        {
            get => comment;
            set
            {
                comment = value;
            }
        }
        public string Recommendation
        {
            get => recommendation;
            set
            {
                recommendation = value;
            }
        }
    }
}
