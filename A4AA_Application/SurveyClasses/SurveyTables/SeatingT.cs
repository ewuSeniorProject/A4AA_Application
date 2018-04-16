using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyTables
{
    class SeatingT
    {
        private string seating_no_step;
        private string table_aisles;
        private string legroom;
        private string num_legroom;
        private string rearranged;
        private string num_table_rearranged;
        private string num_chair_rearranged;
        private string round_tables;
        private int num_round_tables;
        private string lighting;
        private string lighting_option;
        private string lighting_type;
        private string adjustable_lighting;
        private string low_visual_slim;
        private string quiet_table;
        private string low_sound;
        private string designated_space;
        private int num_desig_space;
        private string companion_space;
        private string comment;
        private string recommendation;

        public string Seating_no_step
        {
            get => seating_no_step;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                seating_no_step = value;
            }
        }
        public string Table_aisles
        {
            get => table_aisles;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                table_aisles = value;
            }
        }
        public string Legroom
        {
            get => legroom;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                legroom = value;
            }
        }
        public string Num_legroom
        {
            get => num_legroom;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                num_legroom = value;
            }
        }
        public string Rearranged
        {
            get => rearranged;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                rearranged = value;
            }
        }
        public string Num_table_rearranged
        {
            get => num_table_rearranged;
            set
            {
                if (value.Length > 32)
                    throw new ArgumentOutOfRangeException();

                num_table_rearranged = value;
            }
        }
        public string Num_chair_rearranged
        {
            get => num_chair_rearranged;
            set
            {
                if (value.Length > 32)
                    throw new ArgumentOutOfRangeException();

                num_chair_rearranged = value;
            }
        }
        public string Round_tables
        {
            get => round_tables;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                round_tables = value;
            }
        }
        public int Num_round_tables
        {
            get => num_round_tables;
            set
            {
                if (value.ToString().Length > 11)
                    throw new ArgumentOutOfRangeException();

                num_round_tables = value;
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
        public string Adjustable_lighting
        {
            get => adjustable_lighting;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                adjustable_lighting = value;
            }
        }
        public string Low_visual_slim
        {
            get => low_visual_slim;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                low_visual_slim = value;
            }
        }
        public string Quiet_table
        {
            get => quiet_table;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                quiet_table = value;
            }
        }
        public string Low_sound
        {
            get => low_sound;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                low_sound = value;
            }
        }
        public string Designated_space
        {
            get => designated_space;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                designated_space = value;
            }
        }
        public int Num_desig_space
        {
            get => num_desig_space;
            set
            {
                if (value.ToString().Length > 11)
                    throw new ArgumentOutOfRangeException();

                num_desig_space = value;
            }
        }
        public string Companion_space
        {
            get => companion_space;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                companion_space = value;
            }
        }
        public string Comment { get => comment; set => comment = value; }
        public string Recommendation { get => recommendation; set => recommendation = value; }
    }
}
