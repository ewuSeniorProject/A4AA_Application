﻿using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyQuestions;

namespace A4AA_Application.SurveyClasses.SurveyTables
{
    public class CategoryT
    {
        private Question cat_Nam = new Cat_Nam();

        public Question Cat_Nam { get => cat_Nam; set => cat_Nam = value; }

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
