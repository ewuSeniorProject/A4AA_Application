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
            var par_lot_fre_ans = new Picker { Title = "Free or paid?" };
            var temp = (Par_Lot_Fre)theSurvey.SectionB.ParkingT.Par_Lot_Fre;
            foreach (string s in temp.Options)
            {
                par_lot_fre_ans.Items.Add(s);
            }
            par_lot_fre_ans.SelectedIndexChanged += Par_lot_fre_ans_SelectedIndexChanged;

            var par_str_met = new Label { Text = theSurvey.SectionB.ParkingT.Par_Str_Met.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var par_str_met_ans = new Picker { Title = "Metered or not metered?" };
            var temp2 = (Par_Str_Met)theSurvey.SectionB.ParkingT.Par_Str_Met;
            foreach (string s in temp2.Options)
            {
                par_str_met_ans.Items.Add(s);
            }
            par_str_met_ans.SelectedIndexChanged += Par_str_met_ans_SelectedIndexChanged;

            var par_par_typ = new Label { Text = theSurvey.SectionB.ParkingT.Par_Par_Typ.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var par_par_typ_ans = new Picker { Title = "Garage, valet or other?" };
            var temp3 = (Par_Par_Typ)theSurvey.SectionB.ParkingT.Par_Par_Typ;
            foreach (string s in temp3.Options)
            {
                par_par_typ_ans.Items.Add(s);
            }
            par_par_typ_ans.SelectedIndexChanged += Par_par_typ_ans_SelectedIndexChanged;

            var par_tot_num_spa = new Label { Text = theSurvey.SectionB.ParkingT.Par_Tot_Num_Spa.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var par_tot_num_spa_ans = new Entry { Placeholder = "Enter answer here...", Keyboard = Keyboard.Numeric };
            par_tot_num_spa_ans.Completed += Par_tot_num_spa_ans_Completed;

            var par_num_res_spa = new Label { Text = theSurvey.SectionB.ParkingT.Par_Num_Res_Spa.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var par_num_res_spa_ans = new Entry { Placeholder = "Enter answer here...", Keyboard = Keyboard.Numeric };
            par_num_res_spa_ans.Completed += Par_num_res_spa_ans_Completed;

            var par_num_acc_spa = new Label { Text = theSurvey.SectionB.ParkingT.Par_Num_Acc_Spa.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var par_num_acc_spa_ans = new Entry { Placeholder = "Enter answer here...", Keyboard = Keyboard.Numeric };
            par_num_acc_spa_ans.Completed += Par_num_acc_spa_ans_Completed;

            var par_num_van_acc = new Label { Text = theSurvey.SectionB.ParkingT.Par_Num_Van_Acc.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var par_num_van_acc_ans = new Entry { Placeholder = "Enter answer here...", Keyboard = Keyboard.Numeric };
            par_num_van_acc_ans.Completed += Par_num_van_acc_ans_Completed;

            var par_res_spa_sig = new Label { Text = theSurvey.SectionB.ParkingT.Par_Res_Spa_Sig.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var par_res_spa_sig_ans = new Picker { Title = "Yes or no?" };
            var temp4 = (Par_Res_Spa_Sig)theSurvey.SectionB.ParkingT.Par_Res_Spa_Sig;
            foreach (string s in temp4.Options)
            {
                par_res_spa_sig_ans.Items.Add(s);
            }
            par_res_spa_sig_ans.SelectedIndexChanged += Par_res_spa_sig_ans_SelectedIndexChanged;

            var par_res_spa_obs = new Label { Text = theSurvey.SectionB.ParkingT.Par_Res_Spa_Obs.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var par_res_spa_obs_ans = new Picker { Title = "Yes or no?" };
            var temp5 = (Par_Res_Spa_Obs)theSurvey.SectionB.ParkingT.Par_Res_Spa_Obs;
            foreach (string s in temp4.Options)
            {
                par_res_spa_obs_ans.Items.Add(s);
            }
            par_res_spa_obs_ans.SelectedIndexChanged += Par_res_spa_obs_ans_SelectedIndexChanged;

            var par_com = new Label { Text = theSurvey.SectionB.ParkingT.Par_Com.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var par_com_ans = new Entry { Placeholder = "Enter answer here..." };
            par_com_ans.Completed += Par_com_ans_Completed;

            var par_rec = new Label { Text = theSurvey.SectionB.ParkingT.Par_Rec.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var par_rec_ans = new Entry { Placeholder = "Enter answer here..." };
            par_rec_ans.Completed += Par_rec_ans_Completed;

            layout.Children.Add(par_lot_fre);
            layout.Children.Add(par_lot_fre_ans);
            layout.Children.Add(par_str_met);
            layout.Children.Add(par_str_met_ans);
            layout.Children.Add(par_par_typ);
            layout.Children.Add(par_par_typ_ans);
            layout.Children.Add(par_tot_num_spa);
            layout.Children.Add(par_tot_num_spa_ans);
            layout.Children.Add(par_num_res_spa);
            layout.Children.Add(par_num_res_spa_ans);
            layout.Children.Add(par_num_acc_spa);
            layout.Children.Add(par_num_acc_spa_ans);
            layout.Children.Add(par_num_van_acc);
            layout.Children.Add(par_num_van_acc_ans);
            layout.Children.Add(par_res_spa_sig);
            layout.Children.Add(par_res_spa_sig_ans);
            layout.Children.Add(par_res_spa_obs);
            layout.Children.Add(par_res_spa_obs_ans);
            layout.Children.Add(par_com);
            layout.Children.Add(par_com_ans);
            layout.Children.Add(par_rec);
            layout.Children.Add(par_rec_ans);
        }

        private void Par_rec_ans_Completed(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionB.ParkingT.Par_Rec.TheAnswer.setAnswer(((Entry)sender).Text);
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Unforseen error.", "OK");
            }
        }

        private void Par_com_ans_Completed(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionB.ParkingT.Par_Com.TheAnswer.setAnswer(((Entry)sender).Text);
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Unforseen error.", "OK");
            }
        }

        private void Par_res_spa_obs_ans_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionB.ParkingT.Par_Res_Spa_Obs.TheAnswer.setAnswer(((Picker)sender).SelectedItem.ToString());
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Unforseen error.", "OK");
            }
        }

        private void Par_res_spa_sig_ans_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionB.ParkingT.Par_Res_Spa_Sig.TheAnswer.setAnswer(((Picker)sender).SelectedItem.ToString());
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Unforseen error.", "OK");
            }
        }

        private void Par_num_van_acc_ans_Completed(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionB.ParkingT.Par_Num_Van_Acc.TheAnswer.setAnswer(((Entry)sender).Text);
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Please enter valid data. Your number was too long. This answer is allowed to be up to 11 characters long.", "OK");
            }
        }

        private void Par_num_acc_spa_ans_Completed(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionB.ParkingT.Par_Num_Acc_Spa.TheAnswer.setAnswer(((Entry)sender).Text);
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Please enter valid data. Your number was too long. This answer is allowed to be up to 11 characters long.", "OK");
            }
        }

        private void Par_num_res_spa_ans_Completed(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionB.ParkingT.Par_Num_Res_Spa.TheAnswer.setAnswer(((Entry)sender).Text);
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Please enter valid data. Your number was too long. This answer is allowed to be up to 11 characters long.", "OK");
            }
        }

        private void Par_tot_num_spa_ans_Completed(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionB.ParkingT.Par_Tot_Num_Spa.TheAnswer.setAnswer(((Entry)sender).Text);
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Please enter valid data. Your number was too long. This answer is allowed to be up to 11 characters long.", "OK");
            }
        }

        private void Par_par_typ_ans_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionB.ParkingT.Par_Par_Typ.TheAnswer.setAnswer(((Picker)sender).SelectedItem.ToString());
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Unforseen error.", "OK");
            }
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