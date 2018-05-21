using System;
using System.Collections;
using System.Reflection;
using A4AA_Application.SurveyClasses;
using A4AA_Application.SurveyClasses.SurveyQuestions;
using A4AA_Application.SurveyClasses.SurveyTables;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace A4AA_Application.SurveyPages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SurveySectionA : ContentPage
	{
        private Survey theSurvey;

        private ArrayList QuestionLabels;
        private ArrayList QuestionAnswerSpaces;
        private EstablishmentT table1;
        private ConfigurationT table2;
        private CategoryT table3;

		public SurveySectionA ( Survey theSurvey )
		{
            this.theSurvey = theSurvey;
			InitializeComponent ();
            this.Title = "Premises Information";
            var layout = this.FindByName<StackLayout>("theStackLayoutA");

            QuestionLabels = new ArrayList();
            QuestionAnswerSpaces = new ArrayList();

            table1 = theSurvey.SectionA.EstablishmentT;
            table2 = theSurvey.SectionA.ConfigurationT;
            table3 = theSurvey.SectionA.CategoryT;

            PropertyInfo[] properties = typeof(EstablishmentT).GetProperties();
            foreach (PropertyInfo prop in properties)
            {
                Question q = (Question)prop.GetValue(table1);
                String s = q.TheAnswer.GetType().ToString();

                String ts = q.GetType().ToString();

                if (ts.Contains("Est_Sub"))
                {
                    Question q2 = theSurvey.SectionA.CategoryT.Cat_Nam;
                    QuestionLabels.Add(CreateLabel(q2));
                    Picker p2 = genPicker();
                    AddToPicker(q2, p2);
                    p2.SelectedIndexChanged += (sender, e) => SelectedIndexChanged(sender, e, q2);
                }
                if (ts.Contains("Est_Dat"))
                {
                    Question q2 = theSurvey.SectionA.ConfigurationT.Con_Nam;
                    QuestionLabels.Add(CreateLabel(q2));
                    Picker p2 = genPicker();
                    AddToPicker(q2, p2);
                    p2.SelectedIndexChanged += (sender, e) => SelectedIndexChanged(sender, e, q2);
                }

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
                else if (s.Contains("Decimal") || s.Contains("Int") || ts.Contains("Est_Pho") || ts.Contains("Est_Tty"))
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