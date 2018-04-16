using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyTables
{
    class ParkingT
    {
        private string lot_free;
        private string street_metered;
        private string parking_type;
        private int total_num_spaces;
        private int num_reserved_spaces;
        private int num_accessable_space;
        private int num_van_accessible_space;
        private string reserve_space_sign;
        private string reserve_space_obstacles;
        private string comment;
        private string recommendations;

        public string Lot_free
        {
            get => lot_free;
            set
            {
                if (value.Length > 24)
                    throw new ArgumentOutOfRangeException();

                lot_free = value;
            }
        }
        public string Street_metered
        {
            get => street_metered;
            set
            {
                if (value.Length > 255)
                    throw new ArgumentOutOfRangeException();

                street_metered = value;
            }
        }
        public string Parking_type
        {
            get => parking_type;
            set
            {
                if (value.Length > 255)
                    throw new ArgumentOutOfRangeException();

                parking_type = value;
            }
        }
        public int Num_reserved_spaces
        {
            get => num_reserved_spaces;
            set
            {
                if (value.ToString().Length > 11)
                    throw new ArgumentOutOfRangeException();

                num_reserved_spaces = value;
            }
        }
        public int Num_accessible_space
        {
            get => num_accessable_space;
            set
            {
                if (value.ToString().Length > 11)
                    throw new ArgumentOutOfRangeException();

                num_accessable_space = value;
            }
        }
        public int Num_van_accessible_space
        {
            get => num_van_accessible_space;
            set
            {
                if (value.ToString().Length > 11)
                    throw new ArgumentOutOfRangeException();

                num_van_accessible_space = value;
            }
        }
        public string Reserve_space_sign
        {
            get => reserve_space_sign;
            set
            {
                if (value.Length > 255)
                    throw new ArgumentOutOfRangeException();

                reserve_space_sign = value;
            }
        }
        public string Reserve_space_obstacles
        {
            get => reserve_space_obstacles;
            set
            {
                if (value.Length > 255)
                    throw new ArgumentOutOfRangeException();

                reserve_space_obstacles = value;
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
        public string Recommendations
        {
            get => recommendations;
            set
            {
                recommendations = value;
            }
        }

        public int Total_num_spaces
        {
            get => total_num_spaces;
            set
            {
                if (value.ToString().Length > 11)
                    throw new ArgumentOutOfRangeException();

                total_num_spaces = value;
            }
        }
    }
}
