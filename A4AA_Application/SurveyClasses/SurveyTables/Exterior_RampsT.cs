using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyTables
{
    public class Exterior_RampsT
    {
        const double LARGEST_VALUE_ACCEPTED = 99999.99;
        const int NUM_DIGITS_AFTER_DECIMAL = 2;

        private string ramp_required;
        private string ramp_available;
        private string min_width;
        private double width_between_handrails;
        private decimal slope;
        private string level_landing_both;
        private string level_landing_location;
        private string obstacles;
        private string handrail_both_sides;
        private string handrail_side;
        private string handrail_regulations_height;
        private string handrail_height;
        private string side_guards;
        private string lighting;
        private string lighting_option;
        private string lighting_type;
        private string comment;
        private string recommendations;


        public string Ramp_required
        {
            get => ramp_required;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                ramp_required = value;
            }
        }
        public string Ramp_available
        {
            get => ramp_available;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                ramp_available = value;
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
        public double Width_between_handrails
        {
            get => width_between_handrails;
            set
            {
                if (value > LARGEST_VALUE_ACCEPTED)
                    throw new ArgumentOutOfRangeException();

                width_between_handrails = Math.Round(value, NUM_DIGITS_AFTER_DECIMAL);
            }
        }
        public string Level_landing_both
        {
            get => level_landing_both;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                level_landing_both = value;
            }
        }
        public string Level_landing_location
        {
            get => level_landing_location;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                level_landing_location = value;
            }
        }
        public string Obstacles
        {
            get => obstacles;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                obstacles = value;
            }
        }
        public string Handrail_both_sides
        {
            get => handrail_both_sides;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                handrail_both_sides = value;
            }
        }
        public string Handrail_side
        {
            get => handrail_side;
            set
            {
                if (value.Length > 32)
                    throw new ArgumentOutOfRangeException();

                handrail_side = value;
            }
        }
        public string Handrail_regulations_height
        {
            get => handrail_regulations_height;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                handrail_regulations_height = value;
            }
        }
        public string Handrail_height
        {
            get => handrail_height;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                handrail_height = value;
            }
        }
        public string Side_guard
        {
            get => side_guards;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                side_guards = value;
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

        public decimal Slope
        {
            get => slope;
            set
            {
                if (value > (decimal)LARGEST_VALUE_ACCEPTED)
                    throw new ArgumentOutOfRangeException();

                slope = (decimal)Math.Round(value, NUM_DIGITS_AFTER_DECIMAL);
            }
        }
    }
}
