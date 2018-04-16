using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyTables
{
    class Exterior_StairsT
    {
        private string stairs_required;
        private string stairs_available;
        private int num_stairs;
        private string handrail_both_sides;
        private string handrail_side;
        private string handrail_regulations_height;
        private string handrail_height;
        private string obstacles;
        private string clearly_marked;
        private string lighting;
        private string lighting_option;
        private string lighting_type;
        private string comment;
        private string recommendations;


        public string Stairs_required
        {
            get => stairs_required;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                stairs_required = value;
            }
        }
        public string Stairs_available
        {
            get => stairs_available;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                stairs_available = value;
            }
        }
        public int Num_stairs
        {
            get => num_stairs;
            set
            {
                num_stairs = value;
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
        public string Clearly_marked
        {
            get => clearly_marked;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                clearly_marked = value;
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
