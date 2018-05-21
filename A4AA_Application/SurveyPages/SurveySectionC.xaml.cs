using System;
using System.Collections;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A4AA_Application.SurveyClasses;
using A4AA_Application.SurveyClasses.SurveyQuestions;
using A4AA_Application.SurveyClasses.SurveyTables;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace A4AA_Application.SurveyPages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SurveySectionC : ContentPage
	{
        private Survey theSurvey;

        private ArrayList QuestionLabels;
        private ArrayList QuestionAnswerSpaces;
        private Exterior_PathwaysT table1;
        private Exterior_StairsT table2;
        private Exterior_RampsT table3;
        private Main_EntranceT table4;

		public SurveySectionC (Survey theSurvey)
		{
            this.theSurvey = theSurvey;
			InitializeComponent ();
            this.Title = "Exterior & Entrance";
            var layout = this.FindByName<StackLayout>("theStackLayoutC");

            QuestionLabels = new ArrayList();
            QuestionAnswerSpaces = new ArrayList();

            table1 = theSurvey.SectionC.Exterior_PathwaysT;
            table2 = theSurvey.SectionC.Exterior_StairsT;
            table3 = theSurvey.SectionC.Exterior_RampsT;
            table4 = theSurvey.SectionC.Main_entranceT;

            PropertyInfo[] properties = typeof(Exterior_PathwaysT).GetProperties();
            foreach (PropertyInfo prop in properties)
            {
                Question q = (Question)prop.GetValue(table1);
                String s = q.TheAnswer.GetType().ToString();
                QuestionLabels.Add(CreateLabel(q));

                if (q.HasOptions)
                {
                    Picker p = genPicker();
                    AddToPicker(q, p);
                    p.SelectedIndexChanged += (sender, e) => SelectedIndexChanged(sender, e, q);

                }
                else if (s.Contains("Date"))
                {
                    DatePicker dp = new DatePicker { };
                    QuestionAnswerSpaces.Add(dp);
                    dp.DateSelected += (sender, e) => SelectedDate(sender, e, q);
                }
                else if (s.Contains("Decimal") || s.Contains("Int"))
                {
                    Entry e = new Entry { Placeholder = "Enter answer here...", Keyboard = Keyboard.Numeric };
                    EntryType(e, q);
                }
                else
                {
                    Entry e = new Entry { Placeholder = "Enter answer here..." };
                    EntryType(e, q);
                }
            }

            properties = typeof(Exterior_StairsT).GetProperties();
            foreach (PropertyInfo prop in properties)
            {
                Question q = (Question)prop.GetValue(table2);
                String s = q.TheAnswer.GetType().ToString();
                QuestionLabels.Add(CreateLabel(q));

                if (q.HasOptions)
                {
                    Picker p = genPicker();
                    AddToPicker(q, p);
                    p.SelectedIndexChanged += (sender, e) => SelectedIndexChanged(sender, e, q);

                }
                else if (s.Contains("Date"))
                {
                    DatePicker dp = new DatePicker { };
                    QuestionAnswerSpaces.Add(dp);
                    dp.DateSelected += (sender, e) => SelectedDate(sender, e, q);
                }
                else if (s.Contains("Decimal") || s.Contains("Int"))
                {
                    Entry e = new Entry { Placeholder = "Enter answer here...", Keyboard = Keyboard.Numeric };
                    EntryType(e, q);
                }
                else
                {
                    Entry e = new Entry { Placeholder = "Enter answer here..." };
                    EntryType(e, q);
                }
            }

            properties = typeof(Exterior_RampsT).GetProperties();
            foreach (PropertyInfo prop in properties)
            {
                Question q = (Question)prop.GetValue(table3);
                String s = q.TheAnswer.GetType().ToString();
                QuestionLabels.Add(CreateLabel(q));

                if (q.HasOptions)
                {
                    Picker p = genPicker();
                    AddToPicker(q, p);
                    p.SelectedIndexChanged += (sender, e) => SelectedIndexChanged(sender, e, q);

                }
                else if (s.Contains("Date"))
                {
                    DatePicker dp = new DatePicker { };
                    QuestionAnswerSpaces.Add(dp);
                    dp.DateSelected += (sender, e) => SelectedDate(sender, e, q);
                }
                else if (s.Contains("Decimal") || s.Contains("Int"))
                {
                    Entry e = new Entry { Placeholder = "Enter answer here...", Keyboard = Keyboard.Numeric };
                    EntryType(e, q);
                }
                else
                {
                    Entry e = new Entry { Placeholder = "Enter answer here..." };
                    EntryType(e, q);
                }
            }

            properties = typeof(Main_EntranceT).GetProperties();
            foreach (PropertyInfo prop in properties)
            {
                Question q = (Question)prop.GetValue(table4);
                String s = q.TheAnswer.GetType().ToString();
                QuestionLabels.Add(CreateLabel(q));

                if (q.HasOptions)
                {
                    Picker p = genPicker();
                    AddToPicker(q, p);
                    p.SelectedIndexChanged += (sender, e) => SelectedIndexChanged(sender, e, q);

                }
                else if (s.Contains("Date"))
                {
                    DatePicker dp = new DatePicker { };
                    QuestionAnswerSpaces.Add(dp);
                    dp.DateSelected += (sender, e) => SelectedDate(sender, e, q);
                }
                else if (s.Contains("Decimal") || s.Contains("Int"))
                {
                    Entry e = new Entry { Placeholder = "Enter answer here...", Keyboard = Keyboard.Numeric };
                    EntryType(e, q);
                }
                else
                {
                    Entry e = new Entry { Placeholder = "Enter answer here..." };
                    EntryType(e, q);
                }
            }

            for (int i = 0; i < QuestionLabels.Count; i++)
            {
                layout.Children.Add((Label)QuestionLabels[i]);
                layout.Children.Add((View)QuestionAnswerSpaces[i]);
            }
        }

        private void EntryType(Entry ent, Question q)
        {
            QuestionAnswerSpaces.Add(ent);
            ent.Unfocused += (sender, e) => Ans_Completed(sender, e, q); ;
        }

        private void Ans_Completed(object sender, EventArgs e, Question q)
        {
            try
            {
                q.TheAnswer.setAnswer(((Entry)sender).Text);
            }
            catch (Exception)
            {
                DisplayAlert("Error", q.TheAnswer.getErrorMessage(), "OK");
            }
        }

        private void SelectedDate(object sender, DateChangedEventArgs e, Question q)
        {
            try
            {
                q.TheAnswer.setAnswer(((DatePicker)sender).Date.ToString());
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Unforseen error.", "OK");
            }
        }

        private void AddToPicker(Question q, Picker p)
        {
            QuestionAnswerSpaces.Add(p);
            foreach (string s in q.Options)
            {
                p.Items.Add(s);
            }

        }

        private Label CreateLabel(Question q)
        {
            Label l = new Label { Text = q.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };

            return l;

        }

        private Picker genPicker()
        {
            return new Picker { Title = "Select one" };
        }


        //Events
        private void SelectedIndexChanged(object sender, EventArgs e, Question q)
        {
            try
            {
                q.TheAnswer.setAnswer(((Picker)sender).SelectedItem.ToString());
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Unforseen error.", "OK");
            }
        }
    }
}