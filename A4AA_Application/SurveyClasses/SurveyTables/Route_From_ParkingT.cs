using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyTables
{
    class Route_From_ParkingT
    {
        private const double LARGEST_VALUE_ACCEPTED = 99999.99;
        private const int NUM_DIGITS_AFTER_DECIMAL = 2;

        private double distance;
        private string min_width;
        private string route_surface;
        private string route_curbs;
        private string tactile_warning;
        private string covered;
        private string lighting;
        private string lighting_option;
        private string lighting_type;
        private string comment;
        private string recommendations;


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
        public string Route_surface
        {
            get => route_surface;
            set
            {
                if (value.Length > 255)
                    throw new ArgumentOutOfRangeException();

                route_surface = value;
            }
        }
        public string Route_curbs
        {
            get => route_curbs;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                route_curbs = value;
            }
        }
        public string Tactile_warning
        {
            get => tactile_warning;
            set
            {
                if (value.Length > 255)
                    throw new ArgumentOutOfRangeException();

                tactile_warning = value;
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
