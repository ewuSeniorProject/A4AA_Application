using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyTables
{
    class Passenger_LoadingT
    {
        const double LARGEST_VALUE_ACCEPTED = 99999.99;
        const int NUM_DIGITS_AFTER_DECIMAL = 2;

        private string designated_zone;
        private double distance;
        private string min_width;
        private string passenger_surface;
        private string tactile_warning_strips;
        private string covered;
        private string lighting;
        private string lighting_option;
        private string lighting_type;
        private string comment;
        private string recommendations;

        public string Designated_zone
        {
            get => designated_zone;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                designated_zone = value;
            }
        }
        public double Distance
        {
            get => distance;
            set
            {
                if (value > LARGEST_VALUE_ACCEPTED)
                    throw new ArgumentOutOfRangeException();

                distance = Math.Round(value, NUM_DIGITS_AFTER_DECIMAL);
            }
        }
        public string Min_width
        {
            get => min_width;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                min_width = value;
            }
        }
        public string Passenger_surface
        {
            get => passenger_surface;
            set
            {
                if (value.Length > 255)
                    throw new ArgumentOutOfRangeException();

                passenger_surface = value;
            }
        }
        public string Tactile_warning_strips
        {
            get => tactile_warning_strips;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                tactile_warning_strips = value;
            }
        }
        public string Covered
        {
            get => covered;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                covered = value;
            }
        }
        public string Lighting
        {
            get => lighting;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                lighting = value;
            }
        }
        public string Lighting_option
        {
            get => lighting_option;
            set
            {
                if (value.Length > 32)
                    throw new ArgumentOutOfRangeException();

                lighting_option = value;
            }
        }
        public string Lighting_type
        {
            get => lighting_type;
            set
            {
                if (value.Length > 32)
                    throw new ArgumentOutOfRangeException();

                lighting_type = value;
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
    }
}
