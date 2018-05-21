using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyQuestions;

namespace A4AA_Application.SurveyClasses.SurveyTables
{
    public class Exterior_StairsT
    {
        private Question ext_Sta_Sta_Req = new Ext_Sta_Sta_Req();
        private Question ext_Sta_Sta_Ava = new Ext_Sta_Sta_Ava();
        private Question ext_Sta_Num_Sta = new Ext_Sta_Num_Sta();
        private Question ext_Sta_Han_Bot_Sid = new Ext_Sta_Han_Bot_Sid();
        private Question ext_Sta_Han_Sid = new Ext_Sta_Han_Sid();
        private Question ext_Sta_Han_Reg_Hei = new Ext_Sta_Han_Reg_Hei();
        private Question ext_Sta_Han_Hei = new Ext_Sta_Han_Hei();
        private Question ext_Sta_Obs = new Ext_Sta_Obs();
        private Question ext_Sta_Cle_Mar = new Ext_Sta_Cle_Mar();
        private Question ext_Sta_Lig = new Ext_Sta_Lig();
        private Question ext_Sta_Lig_Opt = new Ext_Sta_Lig_Opt();
        private Question ext_Sta_Lig_Typ = new Ext_Sta_Lig_Typ();
        private Question ext_Sta_Com = new Ext_Sta_Com();
        private Question ext_Sta_Rec = new Ext_Sta_Rec();

        public Question Ext_Sta_Sta_Req { get => ext_Sta_Sta_Req; set => ext_Sta_Sta_Req = value; }
        public Question Ext_Sta_Sta_Ava { get => ext_Sta_Sta_Ava; set => ext_Sta_Sta_Ava = value; }
        public Question Ext_Sta_Num_Sta { get => ext_Sta_Num_Sta; set => ext_Sta_Num_Sta = value; }
        public Question Ext_Sta_Han_Bot_Sid { get => ext_Sta_Han_Bot_Sid; set => ext_Sta_Han_Bot_Sid = value; }
        public Question Ext_Sta_Han_Sid { get => ext_Sta_Han_Sid; set => ext_Sta_Han_Sid = value; }
        public Question Ext_Sta_Han_Reg_Hei { get => ext_Sta_Han_Reg_Hei; set => ext_Sta_Han_Reg_Hei = value; }
        public Question Ext_Sta_Han_Hei { get => ext_Sta_Han_Hei; set => ext_Sta_Han_Hei = value; }
        public Question Ext_Sta_Obs { get => ext_Sta_Obs; set => ext_Sta_Obs = value; }
        public Question Ext_Sta_Cle_Mar { get => ext_Sta_Cle_Mar; set => ext_Sta_Cle_Mar = value; }
        public Question Ext_Sta_Lig { get => ext_Sta_Lig; set => ext_Sta_Lig = value; }
        public Question Ext_Sta_Lig_Opt { get => ext_Sta_Lig_Opt; set => ext_Sta_Lig_Opt = value; }
        public Question Ext_Sta_Lig_Typ { get => ext_Sta_Lig_Typ; set => ext_Sta_Lig_Typ = value; }
        public Question Ext_Sta_Com { get => ext_Sta_Com; set => ext_Sta_Com = value; }
        public Question Ext_Sta_Rec { get => ext_Sta_Rec; set => ext_Sta_Rec = value; }


        /*private string stairs_required;
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
        }*/
    }
}
