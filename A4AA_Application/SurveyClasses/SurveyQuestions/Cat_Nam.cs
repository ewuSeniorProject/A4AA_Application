using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyAnswers;

namespace A4AA_Application.SurveyClasses.SurveyQuestions
{
    public class Cat_Nam : Question
    {
        private string[] options;

        public Cat_Nam()
        {
            TheAnswer = new A_Text255();
            QuestionText = "Category of Establishment:";

            options = new string[] 
            {
                "Arts & Entertainment",
                "Automotive",
                "Bank & Finance",
                "Education",
                "Food & Drink",
                "Government & Community",
                "Healthcare",
                "News & Media",
                "Professional Service",
                "Real Estate",
                "Religion",
                "Retail",
                "Sports & Recreation",
                "Travel",
                "Utilities",
                "Other (explain in comments)"
            };
        }

        public string[] Options { get => options; set => options = value; }
        //NEED SOME OBJECT OR LOGIC HERE WHICH WILL PROVIDE USER WITH DROP DOWN OF CORRECT POTENTIAL OPTIONS
    }
}
