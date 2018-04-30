using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A4AA_Application.SurveyClasses;
using A4AA_Application.SurveyClasses.SurveyQuestions;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace A4AA_Application.SurveyPages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SurveySectionB : ContentPage
	{
        private Survey theSurvey;

        public SurveySectionB (Survey theSurvey)
		{
            this.theSurvey = theSurvey;
			InitializeComponent ();
            this.Title = "Section B";

            var layout = this.FindByName<StackLayout>("theStackLayoutB");

            var par_lot_fre = new Label { Text = theSurvey.SectionB.ParkingT.Par_Lot_Fre.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var par_lot_fre_ans = new Picker { Title = "Is the parking lot free or paid?" };
            var temp = (Par_Lot_Fre)theSurvey.SectionB.ParkingT.Par_Lot_Fre;
            foreach (string s in temp.Options)
            {
                par_lot_fre_ans.Items.Add(s);
            }
            par_lot_fre_ans.SelectedIndexChanged += Par_lot_fre_ans_SelectedIndexChanged;

            var par_str_met = new Label { Text = theSurvey.SectionB.ParkingT.Par_Str_Met.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var par_str_met_ans = new Picker { Title = "Is the street metered or not metered?" };
            var temp2 = (Par_Str_Met)theSurvey.SectionB.ParkingT.Par_Str_Met;
            foreach (string s in temp2.Options)
            {
                par_str_met_ans.Items.Add(s);
            }
            par_str_met_ans.SelectedIndexChanged += Par_str_met_ans_SelectedIndexChanged; 



            layout.Children.Add(par_lot_fre);
            layout.Children.Add(par_lot_fre_ans);
            layout.Children.Add(par_str_met);
            layout.Children.Add(par_str_met_ans);
        }

        private void Par_str_met_ans_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionB.ParkingT.Par_Str_Met.TheAnswer.setAnswer(((Picker)sender).SelectedItem.ToString());
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Unforseen error.", "OK");
            }
        }

        private void Par_lot_fre_ans_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionB.ParkingT.Par_Lot_Fre.TheAnswer.setAnswer(((Picker)sender).SelectedItem.ToString());
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Unforseen error.", "OK");
            }
        }
    }
}