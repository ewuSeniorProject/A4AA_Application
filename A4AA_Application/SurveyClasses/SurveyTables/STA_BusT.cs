using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyTables
{
    class STA_BusT
    {
        private const double LARGEST_VALUE_ACCEPTED = 99999.99;
        private const int NUM_DIGITS_AFTER_DECIMAL = 2;

        private string sta_service_area;
        private decimal distance;
        private string min_width;
        private string route_surface;
        private string tactile_warning_strips;
        private string curb_cuts;
        private string lighting;
        private string lighting_option;
        private string lighting_type;
        private string shelter_bench;
        private string comment;
        private string recommendations;



        public string Sta_service_area
        {
            get => sta_service_area;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                sta_service_area = value;
            }
        }
        public decimal Distance
        {
            get => distance;
            set
            {
                if (value > (decimal)LARGEST_VALUE_ACCEPTED)
                    throw new ArgumentOutOfRangeException();

                distance = (decimal)Math.Round(value, NUM_DIGITS_AFTER_DECIMAL);
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
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                route_surface = value;
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
        public string Curb_cuts
        {
            get => curb_cuts;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                curb_cuts = value;
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
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                lighting_type = value;
            }
        }
        public string Shelter_bench
        {
            get => shelter_bench;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                shelter_bench = value;
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
