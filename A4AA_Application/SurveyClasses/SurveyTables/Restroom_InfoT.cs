using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyTables
{
    class Restroom_InfoT
    {
        const double LARGEST_VALUE_ACCEPTED = 99999.99;
        const int NUM_DIGITS_AFTER_DECIMAL = 2;

        private string restroom_desc;
        private string easy_open;
        private string lbs_force;
        private string clearance;
        private double opening;
        private string opens_out;
        private string use_fist;
        private string can_turn_around;
        private double turn_width;
        private double turn_depth;
        private string close_chair_inside;
        private string grab_bars;
        private string seat_height_req;
        private double seat_height;
        private string flush_auto_fist;
        private string ambulatory_accessible;
        private double bar_height;
        private string coat_hook;
        private double hook_height;
        private string sink;
        private double sink_height;
        private string faucet;
        private double faucet_depth;
        private string faucet_auto_fist;
        private string sink_clearance;
        private double sink_clearance_height;
        private string sink_pipes;
        private string soap_dispenser;
        private double soap_height;
        private string dry_first;
        private string dry_fist_type;
        private string dry_controls;
        private decimal dry_control_height;
        private string mirror;
        private decimal mirror_height;
        private string shelves;
        private decimal shelf_height;
        private string trash_receptacles;
        private string hygiene_seat_cover;
        private decimal hygience_cover_height;
        private string lighting;
        private string lighting_type;
        private string comment;
        private string recommendation;



        public string Restroom_desc
        {
            get => restroom_desc;
            set
            {
                if (value.Length > 32)
                    throw new ArgumentOutOfRangeException();

                restroom_desc = value;
            }
        }
        public string Easy_open
        {
            get => easy_open;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                easy_open = value;
            }
        }
        public string Lbs_force
        {
            get => lbs_force;
            set
            {
                if (value.Length > 10)
                    throw new ArgumentOutOfRangeException();

                lbs_force = value;
            }
        }
        public string Clearance
        {
            get => clearance;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                clearance = value;
            }
        }
        public double Opening
        {
            get => opening;
            set
            {
                if (value > LARGEST_VALUE_ACCEPTED)
                    throw new ArgumentOutOfRangeException();

                opening = Math.Round(value, NUM_DIGITS_AFTER_DECIMAL);
            }
        }
        public string Open_out
        {
            get => opens_out;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                opens_out = value;
            }
        }
        public string Use_fist
        {
            get => use_fist;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                use_fist = value;
            }
        }
        public string Can_turn_around
        {
            get => can_turn_around;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                can_turn_around = value;
            }
        }
        public double Turn_width
        {
            get => turn_width;
            set
            {
                if (value > LARGEST_VALUE_ACCEPTED)
                    throw new ArgumentOutOfRangeException();

                turn_width = Math.Round(value, NUM_DIGITS_AFTER_DECIMAL);
            }
        }
        public double Turn_depth
        {
            get => turn_depth;
            set
            {
                if (value > LARGEST_VALUE_ACCEPTED)
                    throw new ArgumentOutOfRangeException();

                turn_depth = Math.Round(value, NUM_DIGITS_AFTER_DECIMAL);
            }
        }
        public string Close_chair_inside
        {
            get => close_chair_inside;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                close_chair_inside = value;
            }
        }
        public string Grab_bars
        {
            get => grab_bars;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                grab_bars = value;
            }
        }
        public string Seat_height_req
        {
            get => seat_height_req;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                seat_height_req = value;
            }
        }
        public double Seat_height
        {
            get => seat_height;
            set
            {
                if (value > LARGEST_VALUE_ACCEPTED)
                    throw new ArgumentOutOfRangeException();

                seat_height = Math.Round(value, NUM_DIGITS_AFTER_DECIMAL);
            }
        }
        public string Flush_auto_fist
        {
            get => flush_auto_fist;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                flush_auto_fist = value;
            }
        }
        public string Ambulatory_accessible
        {
            get => ambulatory_accessible;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                ambulatory_accessible = value;
            }
        }
        public double Bar_height
        {
            get => bar_height;
            set
            {
                if (value > LARGEST_VALUE_ACCEPTED)
                    throw new ArgumentOutOfRangeException();

                bar_height = Math.Round(value, NUM_DIGITS_AFTER_DECIMAL);
            }
        }
        public string Coat_hook
        {
            get => coat_hook;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                coat_hook = value;
            }
        }
        public double Hook_height
        {
            get => hook_height;
            set
            {
                if (value > LARGEST_VALUE_ACCEPTED)
                    throw new ArgumentOutOfRangeException();

                hook_height = Math.Round(value, NUM_DIGITS_AFTER_DECIMAL);
            }
        }
        public string Sink
        {
            get => sink;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                sink = value;
            }
        }
        public double Sink_height
        {
            get => sink_height;
            set
            {
                if (value > LARGEST_VALUE_ACCEPTED)
                    throw new ArgumentOutOfRangeException();

                sink_height = Math.Round(value, NUM_DIGITS_AFTER_DECIMAL);
            }
        }
        public string Faucet
        {
            get => faucet;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                faucet = value;
            }
        }
        public double Faucet_depth
        {
            get => faucet_depth;
            set
            {
                if (value > LARGEST_VALUE_ACCEPTED)
                    throw new ArgumentOutOfRangeException();

                faucet_depth = Math.Round(value, NUM_DIGITS_AFTER_DECIMAL);
            }
        }
        public string Faucet_auto_fist
        {
            get => faucet_auto_fist;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                faucet_auto_fist = value;
            }
        }
        public string Sink_clearance
        {
            get => sink_clearance;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                sink_clearance = value;
            }
        }
        public double Sink_clearance_height
        {
            get => sink_clearance_height;
            set
            {
                if (value > LARGEST_VALUE_ACCEPTED)
                    throw new ArgumentOutOfRangeException();

                sink_clearance_height = Math.Round(value, NUM_DIGITS_AFTER_DECIMAL);
            }
        }
        public string Sink_pipes
        {
            get => sink_pipes;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                sink_pipes = value;
            }
        }
        public string Soap_dispenser
        {
            get => soap_dispenser;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                soap_dispenser = value;
            }
        }
        public double Soap_height
        {
            get => soap_height;
            set
            {
                if (value > LARGEST_VALUE_ACCEPTED)
                    throw new ArgumentOutOfRangeException();

                soap_height = Math.Round(value, NUM_DIGITS_AFTER_DECIMAL);
            }
        }
        public string Dry_first
        {
            get => dry_first;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                dry_first = value;
            }
        }
        public string Dry_fist_type
        {
            get => dry_fist_type;
            set
            {
                if (value.Length > 32)
                    throw new ArgumentOutOfRangeException();

                dry_fist_type = value;
            }
        }
        public string Dry_controls
        {
            get => dry_controls;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                dry_controls = value;
            }
        }
        public decimal Dry_control_height
        {
            get => dry_control_height;
            set
            {
                if (value > (decimal)LARGEST_VALUE_ACCEPTED)
                    throw new ArgumentOutOfRangeException();

                dry_control_height = (decimal)Math.Round(value, NUM_DIGITS_AFTER_DECIMAL);
            }
        }
        public string Mirror
        {
            get => mirror;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                mirror = value;
            }
        }
        public decimal Mirror_height
        {
            get => mirror_height;
            set
            {
                if (value > (decimal)LARGEST_VALUE_ACCEPTED)
                    throw new ArgumentOutOfRangeException();

                mirror_height = (decimal)Math.Round(value, NUM_DIGITS_AFTER_DECIMAL);
            }
        }
        public string Shelves
        {
            get => shelves;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                shelves = value;
            }
        }
        public decimal Shelf_height
        {
            get => shelf_height;
            set
            {
                if (value > (decimal)LARGEST_VALUE_ACCEPTED)
                    throw new ArgumentOutOfRangeException();

                shelf_height = (decimal)Math.Round(value, NUM_DIGITS_AFTER_DECIMAL);
            }
        }
        public string Trash_receptacles
        {
            get => trash_receptacles;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                trash_receptacles = value;
            }
        }
        public string Hygiene_seat_cover
        {
            get => hygiene_seat_cover;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                hygiene_seat_cover = value;
            }
        }
        public decimal Hygiene_cover_height
        {
            get => hygience_cover_height;
            set
            {
                if (value > (decimal)LARGEST_VALUE_ACCEPTED)
                    throw new ArgumentOutOfRangeException();

                hygience_cover_height = (decimal)Math.Round(value, NUM_DIGITS_AFTER_DECIMAL);
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
        public string Comment
        {
            get => comment;
            set
            {
                comment = value;
            }
        }
        public string Recommendation
        {
            get => recommendation;
            set
            {
                recommendation = value;
            }
        }
    }
}
