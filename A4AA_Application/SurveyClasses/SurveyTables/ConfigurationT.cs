using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyQuestions;

namespace A4AA_Application.SurveyClasses.SurveyTables
{
    public class ConfigurationT
    {
        private Question con_Nam = new Con_Nam();

        public Question Con_Nam { get => con_Nam; set => con_Nam = value; }

        /*private string name;

        public string Name
        {
            get => name;
            set
            {
                if (value.Length > 255)
                    throw new ArgumentOutOfRangeException();

                name = value;
            }
        }*/
    }
}
