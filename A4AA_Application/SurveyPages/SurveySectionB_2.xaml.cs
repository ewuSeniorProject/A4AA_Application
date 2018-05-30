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
	public partial class SurveySectionB_2 : ContentPage
	{
		private Survey theSurvey;

		private ArrayList QuestionLabels;
		private ArrayList QuestionAnswerSpaces;
		private STA_RouteT Table;//here
		private int numRoutePages;
		private int curRoutePg;

		public SurveySectionB_2(Survey theSurvey, int numRoutePages, int curRoutePg)
		{
			this.theSurvey = theSurvey;
			this.numRoutePages = numRoutePages;
			this.curRoutePg = curRoutePg;
			InitializeComponent();
			Title = "Route " + curRoutePg+ " Information";

			var layout = this.FindByName<StackLayout>("theStackLayoutB_2");
			QuestionLabels = new ArrayList();
			QuestionAnswerSpaces = new ArrayList();

			SectionB4 section = new SectionB4();
			Table = section.sta_RouteT;//here
			theSurvey.sectionB.sectionB3.STA_Route_InfoT.Add(section);


			PropertyInfo[] properties = typeof(STA_RouteT).GetProperties();//here

			foreach (PropertyInfo prop in properties)
			{
				Question q = (Question)prop.GetValue(Table);
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

			//Submit button
			Button Sub_Button = new Button { Text = "Next Route" };
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

		public async void Sub_but_clicked(object sender, EventArgs args)
		{

			if (curRoutePg < numRoutePages)
			{
				await Navigation.PushAsync(new SurveySectionB_2(theSurvey, numRoutePages, curRoutePg + 1));
			}
			else
			{
				await Navigation.PushAsync(new MainSurveyPage(theSurvey));

			}

		}



	}
}
