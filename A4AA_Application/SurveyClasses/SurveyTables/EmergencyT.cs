using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyTables
{
    class EmergencyT
    {
        private string evac_info;
        private string alt_evac_info;
        private string evac_info_format;
        private string alarms;
        private string location_no_flash;
        private string shelter;
        private string signs_to_exit;
        private string wheelschair_plan;
        private string floor_plan_routes;
        private string fire_alarm_height;
        private string fire_extinguisher_height;
        private string comment;
        private string recommendations;



        public string Evac_info
        {
            get => evac_info;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                evac_info = value;
            }
        }
        public string Alt_evac_info
        {
            get => alt_evac_info;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                alt_evac_info = value;
            }
        }
        public string Evac_info_format
        {
            get => evac_info_format;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                evac_info_format = value;
            }
        }
        public string Alarms
        {
            get => alarms;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                alarms = value;
            }
        }
        public string Location_no_flash
        {
            get => location_no_flash;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                location_no_flash = value;
            }
        }
        public string Shelter
        {
            get => shelter;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                shelter = value;
            }
        }
        public string Signs_to_exit
        {
            get => signs_to_exit;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                signs_to_exit = value;
            }
        }
        public string Wheelchar_plan
        {
            get => wheelschair_plan;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                wheelschair_plan = value;
            }
        }
        public string Floor_plan_routes
        {
            get => floor_plan_routes;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                floor_plan_routes = value;
            }
        }
        public string Fire_alarm_height
        {
            get => fire_alarm_height;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                fire_alarm_height = value;
            }
        }
        public string Fire_extinguisher_height
        {
            get => fire_extinguisher_height;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                fire_extinguisher_height = value;
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
