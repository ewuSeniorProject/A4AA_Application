using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyTables
{
    class ElevatorT
    {
        private string is_elevator;
        private string location;
        private string works;
        private string no_assist;
        private string button_height;
        private string outside_btn_height;
        private string inside_btn_height;
        private string button_use_fist;
        private string braille;
        private string audible_tones;
        private string lighting;
        private string lighting_type;
        private string elevator_depth;
        private string comment;
        private string recommendation;

        public string Is_elevator
        {
            get => is_elevator;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                is_elevator = value;
            }
        }

        public string Location
        {
            get => location;
            set
            {
                if (value.Length > 500)
                    throw new ArgumentOutOfRangeException();

                location = value;
            }
        }
        public string Works
        {
            get => works;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                works = value;
            }
        }
        public string No_assist
        {
            get => no_assist;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                no_assist = value;
            }
        }

        public string Button_height
        {
            get => button_height;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                button_height = value;
            }
        }

        public string Outside_btn_height
        {
            get => outside_btn_height;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                outside_btn_height = value;
            }
        }

        public string Inside_btn_height
        {
            get => inside_btn_height;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                inside_btn_height = value;
            }
        }

        public string Button_use_fist
        {
            get => button_use_fist;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                button_use_fist = value;
            }
        }

        public string Braille
        {
            get => braille;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                braille = value;
            }
        }

        public string Audible_tones
        {
            get => audible_tones;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                audible_tones = value;
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
                if (value.Length > 32)
                    throw new ArgumentOutOfRangeException();

                lighting_type = value;
            }
        }

        public string Elevator_depth
        {
            get => elevator_depth;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                elevator_depth = value;
            }
        }
        public string Comment { get => comment; set => comment = value; }
        public string Recommendation { get => recommendation; set => recommendation = value; }
    }
}
