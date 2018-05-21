using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyQuestions;

namespace A4AA_Application.SurveyClasses.SurveyTables
{
    public class Main_EntranceT
    {
        private Question mai_Ent_Tot_Num_Pub_Ent = new Mai_Ent_Tot_Num_Pub_Ent();
        private Question mai_Ent_Mai_Ent_Acc = new Mai_Ent_Mai_Ent_Acc();
        private Question mai_Ent_Alt_Ent_Acc = new Mai_Ent_Alt_Ent_Acc();
        private Question mai_Ent_Acc_Sig = new Mai_Ent_Acc_Sig();
        private Question mai_Ent_Gro_Lev = new Mai_Ent_Gro_Lev();
        private Question mai_Ent_Thr_Lev = new Mai_Ent_Thr_Lev();
        private Question mai_Ent_Thr_Bev = new Mai_Ent_Thr_Bev();
        private Question mai_Ent_Bev_Hei = new Mai_Ent_Bev_Hei();
        private Question mai_Ent_Doo_Act = new Mai_Ent_Doo_Act();
        private Question mai_Ent_Doo_Ope_Cle = new Mai_Ent_Doo_Ope_Cle();
        private Question mai_Ent_Ope_Mea = new Mai_Ent_Ope_Mea();
        private Question mai_Ent_Doo_Eas_Ope = new Mai_Ent_Doo_Eas_Ope();
        private Question mai_Ent_Doo_Ope_For = new Mai_Ent_Doo_Ope_For();
        private Question mai_Ent_Doo_Use_Wit_Fis = new Mai_Ent_Doo_Use_Wit_Fis();
        private Question mai_Ent_Doo_Aut_Ope = new Mai_Ent_Doo_Aut_Ope();
        private Question mai_Ent_Sec_Doo_Ins = new Mai_Ent_Sec_Doo_Ins();
        private Question mai_Ent_Min_Dis_Bet_Doo = new Mai_Ent_Min_Dis_Bet_Doo();
        private Question mai_Ent_Lig = new Mai_Ent_Lig();
        private Question mai_Ent_Lig_Opt = new Mai_Ent_Lig_Opt();
        private Question mai_Ent_Lig_Typ = new Mai_Ent_Lig_Typ();
        private Question mai_Ent_Com = new Mai_Ent_Com();
        private Question mai_Ent_Rec = new Mai_Ent_Rec();

        public Question Mai_Ent_Tot_Num_Pub_Ent { get => mai_Ent_Tot_Num_Pub_Ent; set => mai_Ent_Tot_Num_Pub_Ent = value; }
        public Question Mai_Ent_Mai_Ent_Acc { get => mai_Ent_Mai_Ent_Acc; set => mai_Ent_Mai_Ent_Acc = value; }
        public Question Mai_Ent_Alt_Ent_Acc { get => mai_Ent_Alt_Ent_Acc; set => mai_Ent_Alt_Ent_Acc = value; }
        public Question Mai_Ent_Acc_Sig { get => mai_Ent_Acc_Sig; set => mai_Ent_Acc_Sig = value; }
        public Question Mai_Ent_Gro_Lev { get => mai_Ent_Gro_Lev; set => mai_Ent_Gro_Lev = value; }
        public Question Mai_Ent_Thr_Lev { get => mai_Ent_Thr_Lev; set => mai_Ent_Thr_Lev = value; }
        public Question Mai_Ent_Thr_Bev { get => mai_Ent_Thr_Bev; set => mai_Ent_Thr_Bev = value; }
        public Question Mai_Ent_Bev_Hei { get => mai_Ent_Bev_Hei; set => mai_Ent_Bev_Hei = value; }
        public Question Mai_Ent_Doo_Act { get => mai_Ent_Doo_Act; set => mai_Ent_Doo_Act = value; }
        public Question Mai_Ent_Doo_Ope_Cle { get => mai_Ent_Doo_Ope_Cle; set => mai_Ent_Doo_Ope_Cle = value; }
        public Question Mai_Ent_Ope_Mea { get => mai_Ent_Ope_Mea; set => mai_Ent_Ope_Mea = value; }
        public Question Mai_Ent_Doo_Eas_Ope { get => mai_Ent_Doo_Eas_Ope; set => mai_Ent_Doo_Eas_Ope = value; }
        public Question Mai_Ent_Doo_Ope_For { get => mai_Ent_Doo_Ope_For; set => mai_Ent_Doo_Ope_For = value; }
        public Question Mai_Ent_Doo_Use_Wit_Fis { get => mai_Ent_Doo_Use_Wit_Fis; set => mai_Ent_Doo_Use_Wit_Fis = value; }
        public Question Mai_Ent_Doo_Aut_Ope { get => mai_Ent_Doo_Aut_Ope; set => mai_Ent_Doo_Aut_Ope = value; }
        public Question Mai_Ent_Sec_Doo_Ins { get => mai_Ent_Sec_Doo_Ins; set => mai_Ent_Sec_Doo_Ins = value; }
        public Question Mai_Ent_Min_Dis_Bet_Doo { get => mai_Ent_Min_Dis_Bet_Doo; set => mai_Ent_Min_Dis_Bet_Doo = value; }
        public Question Mai_Ent_Lig { get => mai_Ent_Lig; set => mai_Ent_Lig = value; }
        public Question Mai_Ent_Lig_Opt { get => mai_Ent_Lig_Opt; set => mai_Ent_Lig_Opt = value; }
        public Question Mai_Ent_Lig_Typ { get => mai_Ent_Lig_Typ; set => mai_Ent_Lig_Typ = value; }
        public Question Mai_Ent_Com { get => mai_Ent_Com; set => mai_Ent_Com = value; }
        public Question Mai_Ent_Rec { get => mai_Ent_Rec; set => mai_Ent_Rec = value; }

        /*const double LARGEST_VALUE_ACCEPTED = 99999.99;
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
        }*/
    }
}
