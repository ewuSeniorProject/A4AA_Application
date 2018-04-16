using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyTables
{
    class SignageT
    {
        private string is_directory;
        private string door_signs;
        private double sign_height;
        private string pub_sign_braile;
        private string sign_high_contrast;
        private string sign_images;
        private string written_material_images;
        private string menu_access;
        private string alt_info;
        private string alt_info_type;
        private string comment;
        private string recommendation;

        public string Is_directory
        {
            get => is_directory;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                is_directory = value;
            }
        }
        public string Door_signs
        {
            get => door_signs;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                door_signs = value;
            }
        }
        public double Sign_height
        {
            get => sign_height;
            set
            {
                //if (value.Length > 4)
                //   throw new ArgumentOutOfRangeException();

                sign_height = value;
            }
        }
        public string Pub_sign_braile
        {
            get => pub_sign_braile;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                pub_sign_braile = value;
            }
        }
        public string Sign_high_contrast
        {
            get => sign_high_contrast;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                sign_high_contrast = value;
            }
        }
        public string Sign_images
        {
            get => sign_images;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                sign_images = value;
            }
        }
        public string Written_material_images
        {
            get => written_material_images;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                written_material_images = value;
            }
        }
        public string Menu_access
        {
            get => menu_access;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                menu_access = value;
            }
        }
        public string Alt_info
        {
            get => alt_info;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                alt_info = value;
            }
        }
        public string Alt_info_type
        {
            get => alt_info_type;
            set
            {
                if (value.Length > 32)
                    throw new ArgumentOutOfRangeException();

                alt_info_type = value;
            }
        }
        public string Comment_text { get => comment; set => comment = value; }
        public string Recommendation_text { get => recommendation; set => recommendation = value; }
    }
}
