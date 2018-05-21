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
	public partial class SurveySectionB : ContentPage
	{
        private Survey theSurvey;
        private ArrayList QuestionLabels;
        private ArrayList QuestionAnswerSpaces;
        private ParkingT table1;
        private Route_From_ParkingT table2;
        private Passenger_LoadingT table3;
        private STA_BusT table4;
        private STA_RouteT table5;


        public SurveySectionB (Survey theSurvey)
		{
            this.theSurvey = theSurvey;
			InitializeComponent ();
            this.Title = "Parking, Loading Zones, Bus Stops";
            var layout = this.FindByName<StackLayout>("theStackLayoutB");

            QuestionLabels = new ArrayList();
            QuestionAnswerSpaces = new ArrayList();

            table1 = theSurvey.SectionB.ParkingT;
            table2 = theSurvey.SectionB.Route_From_ParkingT;
            table3 = theSurvey.SectionB.Passenger_LoadingT;
            table4 = theSurvey.SectionB.STA_BusT;
            table5 = theSurvey.SectionB.STA_RouteT;

            PropertyInfo[] properties = typeof(ParkingT).GetProperties();
            foreach (PropertyInfo prop in properties)
            {
                Question q = (Question)prop.GetValue(table1);
                String s = q.TheAnswer.GetType().ToString();
                QuestionLabels.Add(CreateLabel(q));

                if (q.HasOptions)
                {
                    Picker p;
                    if (q.HasBeenAnswered == true)
                    {
                        p = genCustomPicker(q);
                    }
                    else
                    {
                        p = genPicker();
                    }
                    AddToPicker(q, p);
                    p.SelectedIndexChanged += (sender, e) => SelectedIndexChanged(sender, e, q);

                }
                else if (s.Contains("Date"))
                {
                    DatePicker dp = new DatePicker();
                    if (q.HasBeenAnswered == true)
                    {
                        dp.Date = DateTime.Parse(q.TheAnswer.getAnswer());
                    }
                    QuestionAnswerSpaces.Add(dp);
                    dp.DateSelected += (sender, e) => SelectedDate(sender, e, q);
                }
                else if (s.Contains("Decimal") || s.Contains("Int"))
                {
                    Entry e;
                    if (q.HasBeenAnswered == true)
                    {
                        e = new Entry { Placeholder = q.TheAnswer.getAnswer(), Keyboard = Keyboard.Numeric };
                    }
                    else
                    {
                        e = new Entry { Placeholder = "Enter answer here...", Keyboard = Keyboard.Numeric };
                    }
                    EntryType(e, q);
                }
                else
                {
                    Entry e;
                    if (q.HasBeenAnswered == true)
                    {
                        e = new Entry { Placeholder = q.TheAnswer.getAnswer() };
                    }
                    else
                    {
                        e = new Entry { Placeholder = "Enter answer here..." };
                    }
                    EntryType(e, q);
                }
            }

            properties = typeof(Route_From_ParkingT).GetProperties();
            foreach (PropertyInfo prop in properties)
            {
                Question q = (Question)prop.GetValue(table2);
                String s = q.TheAnswer.GetType().ToString();
                QuestionLabels.Add(CreateLabel(q));

                if (q.HasOptions)
                {
                    Picker p;
                    if (q.HasBeenAnswered == true)
                    {
                        p = genCustomPicker(q);
                    }
                    else
                    {
                        p = genPicker();
                    }
                    AddToPicker(q, p);
                    p.SelectedIndexChanged += (sender, e) => SelectedIndexChanged(sender, e, q);

                }
                else if (s.Contains("Date"))
                {
                    DatePicker dp = new DatePicker();
                    if (q.HasBeenAnswered == true)
                    {
                        dp.Date = DateTime.Parse(q.TheAnswer.getAnswer());
                    }
                    QuestionAnswerSpaces.Add(dp);
                    dp.DateSelected += (sender, e) => SelectedDate(sender, e, q);
                }
                else if (s.Contains("Decimal") || s.Contains("Int"))
                {
                    Entry e;
                    if (q.HasBeenAnswered == true)
                    {
                        e = new Entry { Placeholder = q.TheAnswer.getAnswer(), Keyboard = Keyboard.Numeric };
                    }
                    else
                    {
                        e = new Entry { Placeholder = "Enter answer here...", Keyboard = Keyboard.Numeric };
                    }
                    EntryType(e, q);
                }
                else
                {
                    Entry e;
                    if (q.HasBeenAnswered == true)
                    {
                        e = new Entry { Placeholder = q.TheAnswer.getAnswer() };
                    }
                    else
                    {
                        e = new Entry { Placeholder = "Enter answer here..." };
                    }
                    EntryType(e, q);
                }
            }

            properties = typeof(Passenger_LoadingT).GetProperties();
            foreach (PropertyInfo prop in properties)
            {
                Question q = (Question)prop.GetValue(table3);
                String s = q.TheAnswer.GetType().ToString();
                QuestionLabels.Add(CreateLabel(q));

                if (q.HasOptions)
                {
                    Picker p;
                    if (q.HasBeenAnswered == true)
                    {
                        p = genCustomPicker(q);
                    }
                    else
                    {
                        p = genPicker();
                    }
                    AddToPicker(q, p);
                    p.SelectedIndexChanged += (sender, e) => SelectedIndexChanged(sender, e, q);

                }
                else if (s.Contains("Date"))
                {
                    DatePicker dp = new DatePicker();
                    if (q.HasBeenAnswered == true)
                    {
                        dp.Date = DateTime.Parse(q.TheAnswer.getAnswer());
                    }
                    QuestionAnswerSpaces.Add(dp);
                    dp.DateSelected += (sender, e) => SelectedDate(sender, e, q);
                }
                else if (s.Contains("Decimal") || s.Contains("Int"))
                {
                    Entry e;
                    if (q.HasBeenAnswered == true)
                    {
                        e = new Entry { Placeholder = q.TheAnswer.getAnswer(), Keyboard = Keyboard.Numeric };
                    }
                    else
                    {
                        e = new Entry { Placeholder = "Enter answer here...", Keyboard = Keyboard.Numeric };
                    }
                    EntryType(e, q);
                }
                else
                {
                    Entry e;
                    if (q.HasBeenAnswered == true)
                    {
                        e = new Entry { Placeholder = q.TheAnswer.getAnswer() };
                    }
                    else
                    {
                        e = new Entry { Placeholder = "Enter answer here..." };
                    }
                    EntryType(e, q);
                }
            }

            properties = typeof(STA_BusT).GetProperties();
            foreach (PropertyInfo prop in properties)
            {
                Question q = (Question)prop.GetValue(table4);
                String s = q.TheAnswer.GetType().ToString();
                QuestionLabels.Add(CreateLabel(q));

                if (q.HasOptions)
                {
                    Picker p;
                    if (q.HasBeenAnswered == true)
                    {
                        p = genCustomPicker(q);
                    }
                    else
                    {
                        p = genPicker();
                    }
                    AddToPicker(q, p);
                    p.SelectedIndexChanged += (sender, e) => SelectedIndexChanged(sender, e, q);

                }
                else if (s.Contains("Date"))
                {
                    DatePicker dp = new DatePicker();
                    if (q.HasBeenAnswered == true)
                    {
                        dp.Date = DateTime.Parse(q.TheAnswer.getAnswer());
                    }
                    QuestionAnswerSpaces.Add(dp);
                    dp.DateSelected += (sender, e) => SelectedDate(sender, e, q);
                }
                else if (s.Contains("Decimal") || s.Contains("Int"))
                {
                    Entry e;
                    if (q.HasBeenAnswered == true)
                    {
                        e = new Entry { Placeholder = q.TheAnswer.getAnswer(), Keyboard = Keyboard.Numeric };
                    }
                    else
                    {
                        e = new Entry { Placeholder = "Enter answer here...", Keyboard = Keyboard.Numeric };
                    }
                    EntryType(e, q);
                }
                else
                {
                    Entry e;
                    if (q.HasBeenAnswered == true)
                    {
                        e = new Entry { Placeholder = q.TheAnswer.getAnswer() };
                    }
                    else
                    {
                        e = new Entry { Placeholder = "Enter answer here..." };
                    }
                    EntryType(e, q);
                }
            }

            properties = typeof(STA_RouteT).GetProperties();
            foreach (PropertyInfo prop in properties)
            {
                Question q = (Question)prop.GetValue(table5);
                String s = q.TheAnswer.GetType().ToString();
                QuestionLabels.Add(CreateLabel(q));

                if (q.HasOptions)
                {
                    Picker p;
                    if (q.HasBeenAnswered == true)
                    {
                        p = genCustomPicker(q);
                    }
                    else
                    {
                        p = genPicker();
                    }
                    AddToPicker(q, p);
                    p.SelectedIndexChanged += (sender, e) => SelectedIndexChanged(sender, e, q);

                }
                else if (s.Contains("Date"))
                {
                    DatePicker dp = new DatePicker();
                    if (q.HasBeenAnswered == true)
                    {
                        dp.Date = DateTime.Parse(q.TheAnswer.getAnswer());
                    }
                    QuestionAnswerSpaces.Add(dp);
                    dp.DateSelected += (sender, e) => SelectedDate(sender, e, q);
                }
                else if (s.Contains("Decimal") || s.Contains("Int"))
                {
                    Entry e;
                    if (q.HasBeenAnswered == true)
                    {
                        e = new Entry { Placeholder = q.TheAnswer.getAnswer(), Keyboard = Keyboard.Numeric };
                    }
                    else
                    {
                        e = new Entry { Placeholder = "Enter answer here...", Keyboard = Keyboard.Numeric };
                    }
                    EntryType(e, q);
                }
                else
                {
                    Entry e;
                    if (q.HasBeenAnswered == true)
                    {
                        e = new Entry { Placeholder = q.TheAnswer.getAnswer() };
                    }
                    else
                    {
                        e = new Entry { Placeholder = "Enter answer here..." };
                    }
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
                q.HasBeenAnswered = true;
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
                q.TheAnswer.setAnswer(((DatePicker)sender).Date.ToShortDateString());
                q.HasBeenAnswered = true;
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

        private Picker genCustomPicker(Question q)
        {
            return new Picker { Title = q.TheAnswer.getAnswer() };
        }

        //Events
        private void SelectedIndexChanged(object sender, EventArgs e, Question q)
        {
            try
            {
                q.TheAnswer.setAnswer(((Picker)sender).SelectedItem.ToString());
                q.HasBeenAnswered = true;
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Unforseen error.", "OK");
            }
        }
    }
}