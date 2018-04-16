using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyTables
{
    class CategoryT
    {
        private string name;

        public string Name
        {
            get => name;
            set
            {
                if (value.Length > 255)
                    throw new ArgumentOutOfRangeException();

                name = value;
            }
        }
    }
}
