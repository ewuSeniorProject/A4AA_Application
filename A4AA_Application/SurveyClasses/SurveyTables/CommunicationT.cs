using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyTables
{
    public class CommunicationT
    {
        private string public_phone;
        private string phone_clearance;
        private int num_phone;
        private string tty;
        private string staff_tty;
        private string assisted_listening;
        private string assisted_listen_type;
        private string assisted_listen_receiver;
        private string listening_signage;
        private string acoustics;
        private string acoustics_level;
        private string alt_comm_methods;
        private string alt_comm_type;
        private string staff_ASL;
        private string captioning_default;
        private string theater_captioning;
        private string theater_capt_type;
        private string auditory_info_visual;
        private string visual_info_auditory;
        private string website_text_reader;
        private string alt_contact;
        private string alt_contact_type;
        private string shopping_assist;
        private string assist_service;
        private string assist_fee;
        private string store_scooter;
        private string scooter_fee;
        private string scooter_location;
        private string restaurant_allergies;
        private string staff_disable_trained;
        private string staff_disable_trained_desc;
        private string items_reach;
        private string service_alt_manner;
        private string senior_discount;
        private int senior_age;
        private string annual_A4A_review;
        private string comment;
        private string recommendation;

        public string Public_phone
        {
            get => public_phone;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                public_phone = value;
            }
        }
        public string Phone_clearance
        {
            get => phone_clearance;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                phone_clearance = value;
            }
        }
        public int Num_phone
        {
            get => num_phone;
            set
            {
                if (value.ToString().Length > 4)
                    throw new ArgumentOutOfRangeException();

                num_phone = value;
            }
        }
        public string Tty
        {
            get => tty;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                tty = value;
            }
        }
        public string Staff_tty
        {
            get => staff_tty;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                staff_tty = value;
            }
        }
        public string Assisted_listening
        {
            get => assisted_listening;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                assisted_listening = value;
            }
        }
        public string Assisted_listen_type
        {
            get => assisted_listen_type;
            set
            {
                if (value.Length > 32)
                    throw new ArgumentOutOfRangeException();

                assisted_listen_type = value;
            }
        }
        public string Assisted_listen_receiver
        {
            get => assisted_listen_receiver;
            set
            {
                if (value.Length > 32)
                    throw new ArgumentOutOfRangeException();

                assisted_listen_receiver = value;
            }
        }
        public string Listening_signage
        {
            get => listening_signage;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                listening_signage = value;
            }
        }
        public string Acoustics
        {
            get => acoustics;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                acoustics = value;
            }
        }
        public string Acoustics_level
        {
            get => acoustics_level;
            set
            {
                if (value.Length > 50)
                    throw new ArgumentOutOfRangeException();

                acoustics_level = value;
            }
        }
        public string Alt_comm_methods
        {
            get => alt_comm_methods;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                alt_comm_methods = value;
            }
        }
        public string Alt_comm_type
        {
            get => alt_comm_type;
            set
            {
                if (value.Length > 50)
                    throw new ArgumentOutOfRangeException();

                alt_comm_type = value;
            }
        }
        public string Staff_ASL
        {
            get => staff_ASL;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                staff_ASL = value;
            }
        }
        public string Captioning_default
        {
            get => captioning_default;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                captioning_default = value;
            }
        }
        public string Theater_captioning
        {
            get => theater_captioning;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                theater_captioning = value;
            }
        }
        public string Theater_capt_type
        {
            get => theater_capt_type;
            set
            {
                if (value.Length > 50)
                    throw new ArgumentOutOfRangeException();

                theater_capt_type = value;
            }
        }
        public string Auditory_info_visual
        {
            get => auditory_info_visual;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                auditory_info_visual = value;
            }
        }
        public string Visual_info_auditory
        {
            get => visual_info_auditory;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                visual_info_auditory = value;
            }
        }
        public string Website_text_reader
        {
            get => website_text_reader;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                website_text_reader = value;
            }
        }
        public string Alt_contact
        {
            get => alt_contact;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                alt_contact = value;
            }
        }
        public string Alt_contact_type
        {
            get => alt_contact_type;
            set
            {
                if (value.Length > 100)
                    throw new ArgumentOutOfRangeException();

                alt_contact_type = value;
            }
        }
        public string Shopping_assist
        {
            get => shopping_assist;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                shopping_assist = value;
            }
        }
        public string Assist_service
        {
            get => assist_service;
            set
            {
                if (value.Length > 32)
                    throw new ArgumentOutOfRangeException();

                assist_service = value;
            }
        }
        public string Assist_fee
        {
            get => assist_fee;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                assist_fee = value;
            }
        }
        public string Store_scooter
        {
            get => store_scooter;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                store_scooter = value;
            }
        }
        public string Scooter_fee
        {
            get => scooter_fee;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                scooter_fee = value;
            }
        }
        public string Scooter_location
        {
            get => scooter_location;
            set => scooter_location = value;
        }
        public string Restaurant_allergies
        {
            get => restaurant_allergies;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                restaurant_allergies = value;
            }
        }
        public string Staff_disable_trained
        {
            get => staff_disable_trained;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                staff_disable_trained = value;
            }
        }
        public string Staff_disable_trained_desc
        {
            get => staff_disable_trained_desc;
            set => staff_disable_trained_desc = value;
        }
        public string Items_reach
        {
            get => items_reach;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                items_reach = value;
            }
        }
        public string Service_alt_manner
        {
            get => service_alt_manner;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                service_alt_manner = value;
            }
        }
        public string Senior_discount
        {
            get => senior_discount;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                senior_discount = value;
            }
        }
        public int Senior_age
        {
            get => senior_age;
            set
            {
                if (value.ToString().Length > 11)
                    throw new ArgumentOutOfRangeException();

                senior_age = value;
            }
        }
        public string Annual_A4A_review
        {
            get => annual_A4A_review;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                public_phone = value;
            }
        }
        public string Comment { get => comment; set => comment = value; }
        public string Recommendation { get => recommendation; set => recommendation = value; }

        public string Annual_A4A_review1
        {
            get => annual_A4A_review;
            set
            {
                if (value.Length > 4)
                    throw new ArgumentOutOfRangeException();

                annual_A4A_review = value;
            }
        }
    }
}