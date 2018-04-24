using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyTables
{
    public class Exterior_PathwaysT
    {
        private string service_animal;
        private string service_animal_location;
        private string has_exterior_path;
        private string min_width;
        private string pathway_surface;
        private string pathway_curbs;
        private string tactile_warning;
        private string slope;
        private string lighting;
        private string lighting_option;
        private string lighting_type;
        private string comment;
        private string text;

        public string Service_animal
        {
            get => service_animal;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                service_animal = value;
            }
        }
        public string Service_animal_loacation
        {
            get => service_animal_location;
            set
            {
                if (value.Length > 255)
                    throw new ArgumentOutOfRangeException();

                service_animal_location = value;
            }
        }
        public string Has_exterior_path
        {
            get => Has_exterior_path;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                has_exterior_path = value;
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
        public string Pathway_surface
        {
            get => pathway_surface;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                pathway_surface = value;
            }
        }
        public string Pathway_curbs
        {
            get => pathway_curbs;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                pathway_curbs = value;
            }
        }
        public string Tactile_warning
        {
            get => tactile_warning;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                tactile_warning = value;
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
        public string Text
        {
            get => text;
            set
            {
                text = value;
            }
        }

        public string Slope
        {
            get => slope;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                slope = value;
            }
        }
    }
}
