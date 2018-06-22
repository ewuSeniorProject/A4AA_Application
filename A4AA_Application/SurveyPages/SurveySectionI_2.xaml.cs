using System;
using System.Collections;
using System.Reflection;
using A4AA_Application.SurveyClasses;
using A4AA_Application.SurveyClasses.SurveyQuestions;
using A4AA_Application.SurveyClasses.SurveySections;
using A4AA_Application.SurveyClasses.SurveyTables;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace A4AA_Application.SurveyPages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SurveySectionI_2 : ContentPage
	{

		private Survey theSurvey;

		private ArrayList QuestionLabels;
		private ArrayList QuestionAnswerSpaces;
		private Restroom_InfoT Table;//here
		private int restroomPages;
		private int curRestPg;

		public SurveySectionI_2(Survey theSurvey, int restroomPages, int curRestPg)
		{
			this.restroomPages = restroomPages;
			this.curRestPg = curRestPg;
			this.theSurvey = theSurvey;
			InitializeComponent();
			Title = "Restroom " + curRestPg + " Info";

			var layout = this.FindByName<StackLayout>("theStackLayoutI_2");
			QuestionLabels = new ArrayList();
			QuestionAnswerSpaces = new ArrayList();

			SectionI_2 section = new SectionI_2();
			Table = section.Restroom_InfoT;//here
			theSurvey.sectionI.Restroom_InfoT.Add(section);

			PropertyInfo[] properties = typeof(Restroom_InfoT).GetProperties();//here
			foreach (PropertyInfo prop in properties)
			{
				Question q = (Question)prop.GetValue(Table);
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

			//Adding to the page
			for (int i = 0; i < QuestionLabels.Count; i++)
			{
				layout.Children.Add((Label)QuestionLabels[i]);
				layout.Children.Add((View)QuestionAnswerSpaces[i]);
			}

			//Adding Submit Button
			Button Sub_Button = new Button { Text = "Next Restroom" };
			Sub_Button.Clicked += Sub_but_clicked;
			layout.Children.Add(Sub_Button);

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
                q.TheAnswer.setAnswer(((DatePicker)sender).Date.ToString("yyyy-MM-dd"));
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

		public async void Sub_but_clicked(object sender, EventArgs args)
		{
			
			if (curRestPg < restroomPages)
			{
				 await Navigation.PushAsync(new SurveySectionI_2(theSurvey, restroomPages, curRestPg+1));
				//Parent = null;
			}
			else
			{
				await Navigation.PushAsync(new MainSurveyPage(theSurvey));
				
			}
			
		}

		
	}
}
