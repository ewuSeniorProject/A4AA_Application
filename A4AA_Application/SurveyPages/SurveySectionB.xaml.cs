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
	public partial class SurveySectionB : ContentPage
	{
		private Survey theSurvey;
		private ArrayList QuestionLabels;
		private ArrayList QuestionAnswerSpaces;
		private ParkingT table1;
		private Route_From_ParkingT table2;
		private Passenger_LoadingT table3;
		private STA_BusT table4;



		public SurveySectionB(Survey theSurvey)
		{
			this.theSurvey = theSurvey;
			InitializeComponent();
			this.Title = "Parking, Loading Zones, Bus Stops";
			var layout = this.FindByName<StackLayout>("theStackLayoutB");

			QuestionLabels = new ArrayList();
			QuestionAnswerSpaces = new ArrayList();

			table1 = theSurvey.sectionB.ParkingT;
			table2 = theSurvey.sectionB.Route_From_ParkingT;
			table3 = theSurvey.sectionB.Passenger_LoadingT;
			table4 = theSurvey.sectionB.STA_BusT;
			//table5 = theSurvey.SectionB.STA_RouteT;

			PropertyInfo[] properties = typeof(ParkingT).GetProperties();

			generateFields(properties, table1);

			properties = typeof(Route_From_ParkingT).GetProperties();
			generateFields(properties, table2);

			properties = typeof(Passenger_LoadingT).GetProperties();
			generateFields(properties, table3);

			properties = typeof(STA_BusT).GetProperties();
			generateFields(properties, table4);

			for (int i = 0; i < QuestionLabels.Count; i++)
			{
				layout.Children.Add((Label)QuestionLabels[i]);
				layout.Children.Add((View)QuestionAnswerSpaces[i]);
			}

			//Adding submit button
			Button Sub_Button = new Button { Text = "Enter information for routes" };
			Sub_Button.Clicked += Sub_but_clicked;
			layout.Children.Add(Sub_Button);
		}

		private void generateFields(PropertyInfo[] properties, Object table)
		{
			foreach (PropertyInfo prop in properties)
			{
				Question q = (Question)prop.GetValue(table);
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




		public async void Sub_but_clicked(object sender, EventArgs args)
		{


			int maxPages = int.Parse(table4.Sta_Bus_Rou_Num.TheAnswer.getAnswer());

			if (maxPages > 0)
				await Navigation.PushAsync(new SurveySectionB_2(theSurvey, maxPages, 1));
			else
				await Navigation.PushAsync(new MainSurveyPage(theSurvey));

		}

	}
}
