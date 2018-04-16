using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyTables
{
    class Main_EntranceT
    {
        const double LARGEST_VALUE_ACCEPTED = 99999.99;
        const int NUM_DIGITS_AFTER_DECIMAL = 2;

        private int total_num_public_entrances;
        private string main_ent_accessible;
        private string alt_ent_accessible;
        private string accessible_signage;
        private string ground_level;
        private string threshold_level;
        private string threshold_beveled;
        private double beveled_height;
        private string door_action;
        private string door_open_clearance;
        private double opening_measurement;
        private string door_easy_open;
        private double door_open_force;
        private double door_use_with_fist;
        private string door_auto_open;
        private string second_door_inside;
        private string min_dist_between_doors;
        private string lighting;
        private string lighting_option;
        private string lighting_type;
        private string comment;
        private string recommendations;


        public int Total_num_public_entrances
        {
            get => total_num_public_entrances;
            set
            {
                total_num_public_entrances = value;
            }
        }
        public string Main_ent_accessible
        {
            get => main_ent_accessible;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                main_ent_accessible = value;
            }
        }
        public string Alt_ent_ccessible
        {
            get => alt_ent_accessible;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                alt_ent_accessible = value;
            }
        }
        public string Accessible_signage
        {
            get => accessible_signage;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                accessible_signage = value;
            }
        }
        public string Ground_level
        {
            get => ground_level;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                ground_level = value;
            }
        }
        public string Threshold_level
        {
            get => threshold_level;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                threshold_level = value;
            }
        }
        public string Threshold_beveled
        {
            get => threshold_beveled;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                threshold_beveled = value;
            }
        }
        public double Beveled_height
        {
            get => beveled_height;
            set
            {
                if (value > LARGEST_VALUE_ACCEPTED)
                    throw new ArgumentOutOfRangeException();

                beveled_height = Math.Round(value, NUM_DIGITS_AFTER_DECIMAL);
            }
        }
        public string Door_action
        {
            get => door_action;
            set
            {
                if (value.Length > 255)
                    throw new ArgumentOutOfRangeException();

                door_action = value;
            }
        }
        public string Door_open_clearance
        {
            get => door_open_clearance;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                door_open_clearance = value;
            }
        }
        public double Opening_measurement
        {
            get => opening_measurement;
            set
            {
                if (value > LARGEST_VALUE_ACCEPTED)
                    throw new ArgumentOutOfRangeException();

                opening_measurement = Math.Round(value, NUM_DIGITS_AFTER_DECIMAL);
            }
        }
        public string Door_easy_open
        {
            get => door_easy_open;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                door_easy_open = value;
            }
        }
        public double Door_open_force
        {
            get => door_open_force;
            set
            {
                if (value > LARGEST_VALUE_ACCEPTED)
                    throw new ArgumentOutOfRangeException();

                door_open_force = Math.Round(value, NUM_DIGITS_AFTER_DECIMAL);
            }
        }
        public double Door_use_with_fist
        {
            get => door_use_with_fist;
            set
            {
                if (value.ToString().Length > 4)
                    throw new ArgumentOutOfRangeException();

                door_use_with_fist = value;
            }
        }
        public string Door_auto_open
        {
            get => door_auto_open;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                door_auto_open = value;
            }
        }
        public string Second_door_inside
        {
            get => second_door_inside;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                second_door_inside = value;
            }
        }
        public string Min_dist_between_doors
        {
            get => min_dist_between_doors;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                min_dist_between_doors = value;
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
