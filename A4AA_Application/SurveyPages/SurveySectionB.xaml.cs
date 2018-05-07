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
            this.Title = "Parking, Loading Zones, Bus Stops";

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

            var rou_fro_par_dis = new Label { Text = theSurvey.SectionB.Route_From_ParkingT.Rou_Fro_Par_Dis.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var rou_fro_par_dis_ans = new Entry { Placeholder = "Enter answer here...", Keyboard = Keyboard.Numeric };
            rou_fro_par_dis_ans.Completed += Rou_fro_par_dis_ans_Completed;

            var rou_fro_par_min_wid = new Label { Text = theSurvey.SectionB.Route_From_ParkingT.Rou_Fro_Par_Min_Wid.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var rou_fro_par_min_wid_ans = new Picker { Title = "Yes or no?" };
            var temp6 = (Rou_Fro_Par_Min_Wid)theSurvey.SectionB.Route_From_ParkingT.Rou_Fro_Par_Min_Wid;
            foreach (string s in temp6.Options)
            {
                rou_fro_par_min_wid_ans.Items.Add(s);
            }
            rou_fro_par_min_wid_ans.SelectedIndexChanged += Rou_fro_par_min_wid_ans_SelectedIndexChanged;

            var rou_fro_par_rou_sur = new Label { Text = theSurvey.SectionB.Route_From_ParkingT.Rou_Fro_Par_Rou_Sur.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var rou_fro_par_rou_sur_ans = new Picker { Title = "Yes or no?" };
            var temp7 = (Rou_Fro_Par_Rou_Sur)theSurvey.SectionB.Route_From_ParkingT.Rou_Fro_Par_Rou_Sur;
            foreach (string s in temp7.Options)
            {
                rou_fro_par_rou_sur_ans.Items.Add(s);
            }
            rou_fro_par_rou_sur_ans.SelectedIndexChanged += Rou_fro_par_rou_sur_ans_SelectedIndexChanged;

            var rou_fro_par_rou_cur = new Label { Text = theSurvey.SectionB.Route_From_ParkingT.Rou_Fro_Par_Rou_Cur.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var rou_fro_par_rou_cur_ans = new Picker { Title = "Yes or no?" };
            var temp8 = (Rou_Fro_Par_Rou_Cur)theSurvey.SectionB.Route_From_ParkingT.Rou_Fro_Par_Rou_Cur;
            foreach (string s in temp8.Options)
            {
                rou_fro_par_rou_cur_ans.Items.Add(s);
            }
            rou_fro_par_rou_cur_ans.SelectedIndexChanged += Rou_fro_par_rou_cur_ans_SelectedIndexChanged;

            var rou_fro_par_tac_war = new Label { Text = theSurvey.SectionB.Route_From_ParkingT.Rou_Fro_Par_Tac_War.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var rou_fro_par_tac_war_ans = new Picker { Title = "Yes or no?" };
            var temp9 = (Rou_Fro_Par_Tac_War)theSurvey.SectionB.Route_From_ParkingT.Rou_Fro_Par_Tac_War;
            foreach (string s in temp9.Options)
            {
                rou_fro_par_tac_war_ans.Items.Add(s);
            }
            rou_fro_par_tac_war_ans.SelectedIndexChanged += Rou_fro_par_tac_war_ans_SelectedIndexChanged;

            var rou_fro_par_cov = new Label { Text = theSurvey.SectionB.Route_From_ParkingT.Rou_Fro_Par_Cov.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var rou_fro_par_cov_ans = new Picker { Title = "Yes or no?" };
            var temp10 = (Rou_Fro_Par_Cov)theSurvey.SectionB.Route_From_ParkingT.Rou_Fro_Par_Cov;
            foreach (string s in temp10.Options)
            {
                rou_fro_par_cov_ans.Items.Add(s);
            }
            rou_fro_par_cov_ans.SelectedIndexChanged += Rou_fro_par_cov_ans_SelectedIndexChanged;

            var rou_fro_par_lig = new Label { Text = theSurvey.SectionB.Route_From_ParkingT.Rou_Fro_Par_Lig.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var rou_fro_par_lig_ans = new Picker { Title = "Yes or no?" };
            var temp11 = (Rou_Fro_Par_Lig)theSurvey.SectionB.Route_From_ParkingT.Rou_Fro_Par_Lig;
            foreach (string s in temp11.Options)
            {
                rou_fro_par_lig_ans.Items.Add(s);
            }
            rou_fro_par_lig_ans.SelectedIndexChanged += Rou_fro_par_lig_ans_SelectedIndexChanged;

            var rou_fro_par_lig_opt = new Label { Text = theSurvey.SectionB.Route_From_ParkingT.Rou_Fro_Par_Lig_Opt.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var rou_fro_par_lig_opt_ans = new Picker { Title = "Day or night?" };
            var temp12 = (Rou_Fro_Par_Lig_Opt)theSurvey.SectionB.Route_From_ParkingT.Rou_Fro_Par_Lig_Opt;
            foreach (string s in temp12.Options)
            {
                rou_fro_par_lig_opt_ans.Items.Add(s);
            }
            rou_fro_par_lig_opt_ans.SelectedIndexChanged += Rou_fro_par_lig_opt_ans_SelectedIndexChanged;

            var rou_fro_par_lig_typ = new Label { Text = theSurvey.SectionB.Route_From_ParkingT.Rou_Fro_Par_Lig_Typ.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var rou_fro_par_lig_typ_ans = new Picker { Title = "Low, medium or bright?" };
            var temp13 = (Rou_Fro_Par_Lig_Typ)theSurvey.SectionB.Route_From_ParkingT.Rou_Fro_Par_Lig_Typ;
            foreach (string s in temp13.Options)
            {
                rou_fro_par_lig_typ_ans.Items.Add(s);
            }
            rou_fro_par_lig_typ_ans.SelectedIndexChanged += Rou_fro_par_lig_typ_ans_SelectedIndexChanged;

            var rou_fro_par_com = new Label { Text = theSurvey.SectionB.Route_From_ParkingT.Rou_Fro_Par_Com.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var rou_fro_par_com_ans = new Entry { Placeholder = "Enter answer here..." };
            rou_fro_par_com_ans.Completed += Rou_fro_par_com_ans_Completed;

            var rou_fro_par_rec = new Label { Text = theSurvey.SectionB.Route_From_ParkingT.Rou_Fro_Par_Rec.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var rou_fro_par_rec_ans = new Entry { Placeholder = "Enter answer here..." };
            rou_fro_par_rec_ans.Completed += Rou_fro_par_rec_ans_Completed;

            layout.Children.Add(rou_fro_par_dis);
            layout.Children.Add(rou_fro_par_dis_ans);
            layout.Children.Add(rou_fro_par_min_wid);
            layout.Children.Add(rou_fro_par_min_wid_ans);
            layout.Children.Add(rou_fro_par_rou_sur);
            layout.Children.Add(rou_fro_par_rou_sur_ans);
            layout.Children.Add(rou_fro_par_rou_cur);
            layout.Children.Add(rou_fro_par_rou_cur_ans);
            layout.Children.Add(rou_fro_par_tac_war);
            layout.Children.Add(rou_fro_par_tac_war_ans);
            layout.Children.Add(rou_fro_par_cov);
            layout.Children.Add(rou_fro_par_cov_ans);
            layout.Children.Add(rou_fro_par_lig);
            layout.Children.Add(rou_fro_par_lig_ans);
            layout.Children.Add(rou_fro_par_lig_opt);
            layout.Children.Add(rou_fro_par_lig_opt_ans);
            layout.Children.Add(rou_fro_par_lig_typ);
            layout.Children.Add(rou_fro_par_lig_typ_ans);
            layout.Children.Add(rou_fro_par_com);
            layout.Children.Add(rou_fro_par_com_ans);
            layout.Children.Add(rou_fro_par_rec);
            layout.Children.Add(rou_fro_par_rec_ans);

            var sta_bus_sta_ser_are = new Label { Text = theSurvey.SectionB.STA_BusT.Sta_Bus_Sta_Ser_Are.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var sta_bus_sta_ser_are_ans = new Picker { Title = "Yes or no?" };
            var temp14 = (STA_Bus_Sta_Ser_Are)theSurvey.SectionB.STA_BusT.Sta_Bus_Sta_Ser_Are;
            foreach (string s in temp14.Options)
            {
                sta_bus_sta_ser_are_ans.Items.Add(s);
            }
            sta_bus_sta_ser_are_ans.SelectedIndexChanged += Sta_bus_sta_ser_are_ans_SelectedIndexChanged;

            var sta_bus_dis = new Label { Text = theSurvey.SectionB.STA_BusT.Sta_Bus_Dis.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var sta_bus_dis_ans = new Entry { Placeholder = "Enter answer here...", Keyboard = Keyboard.Numeric };
            sta_bus_dis_ans.Completed += Sta_bus_dis_ans_Completed;

            var sta_bus_min_wid = new Label { Text = theSurvey.SectionB.STA_BusT.Sta_Bus_Min_Wid.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var sta_bus_min_wid_ans = new Picker { Title = "Yes or no?" };
            var temp15 = (STA_Bus_Min_Wid)theSurvey.SectionB.STA_BusT.Sta_Bus_Min_Wid;
            foreach (string s in temp15.Options)
            {
                sta_bus_min_wid_ans.Items.Add(s);
            }
            sta_bus_min_wid_ans.SelectedIndexChanged += Sta_bus_min_wid_ans_SelectedIndexChanged;

            var sta_bus_rou_sur = new Label { Text = theSurvey.SectionB.STA_BusT.Sta_Bus_Rou_Sur.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var sta_bus_rou_sur_ans = new Picker { Title = "Yes or no?" };
            var temp16 = (STA_Bus_Rou_Sur)theSurvey.SectionB.STA_BusT.Sta_Bus_Rou_Sur;
            foreach (string s in temp16.Options)
            {
                sta_bus_rou_sur_ans.Items.Add(s);
            }
            sta_bus_rou_sur_ans.SelectedIndexChanged += Sta_bus_rou_sur_ans_SelectedIndexChanged;

            var sta_bus_tac_war_str = new Label { Text = theSurvey.SectionB.STA_BusT.Sta_Bus_Tac_War_Str.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var sta_bus_tac_war_str_ans = new Picker { Title = "Yes or no?" };
            var temp17 = (STA_Bus_Tac_War_Str)theSurvey.SectionB.STA_BusT.Sta_Bus_Tac_War_Str;
            foreach (string s in temp17.Options)
            {
                sta_bus_tac_war_str_ans.Items.Add(s);
            }
            sta_bus_tac_war_str_ans.SelectedIndexChanged += Sta_bus_tac_war_str_ans_SelectedIndexChanged;

            var sta_bus_cur_cut = new Label { Text = theSurvey.SectionB.STA_BusT.Sta_Bus_Cur_Cut.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var sta_bus_cur_cut_ans = new Picker { Title = "Yes or no?" };
            var temp18 = (STA_Bus_Cur_Cut)theSurvey.SectionB.STA_BusT.Sta_Bus_Cur_Cut;
            foreach (string s in temp18.Options)
            {
                sta_bus_cur_cut_ans.Items.Add(s);
            }
            sta_bus_cur_cut_ans.SelectedIndexChanged += Sta_bus_cur_cut_ans_SelectedIndexChanged;

            var sta_bus_lig = new Label { Text = theSurvey.SectionB.STA_BusT.Sta_Bus_Lig.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var sta_bus_lig_ans = new Picker { Title = "Yes or no?" };
            var temp19 = (STA_Bus_Lig)theSurvey.SectionB.STA_BusT.Sta_Bus_Lig;
            foreach (string s in temp19.Options)
            {
                sta_bus_lig_ans.Items.Add(s);
            }
            sta_bus_lig_ans.SelectedIndexChanged += Sta_bus_lig_ans_SelectedIndexChanged;

            var sta_bus_lig_opt = new Label { Text = theSurvey.SectionB.STA_BusT.Sta_Bus_Lig_Opt.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var sta_bus_lig_opt_ans = new Picker { Title = "Day or night?" };
            var temp20 = (STA_Bus_Lig_Opt)theSurvey.SectionB.STA_BusT.Sta_Bus_Lig_Opt;
            foreach (string s in temp20.Options)
            {
                sta_bus_lig_opt_ans.Items.Add(s);
            }
            sta_bus_lig_opt_ans.SelectedIndexChanged += Sta_bus_lig_opt_ans_SelectedIndexChanged;

            var sta_bus_lig_typ = new Label { Text = theSurvey.SectionB.STA_BusT.Sta_Bus_Lig_Typ.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var sta_bus_lig_typ_ans = new Picker { Title = "Low, medium or bright?" };
            var temp21 = (STA_Bus_Lig_Typ)theSurvey.SectionB.STA_BusT.Sta_Bus_Lig_Typ;
            foreach (string s in temp21.Options)
            {
                sta_bus_lig_typ_ans.Items.Add(s);
            }
            sta_bus_lig_typ_ans.SelectedIndexChanged += Sta_bus_lig_typ_ans_SelectedIndexChanged;

            var sta_bus_she_ben = new Label { Text = theSurvey.SectionB.STA_BusT.Sta_Bus_She_Ben.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var sta_bus_she_ben_ans = new Picker { Title = "Yes or no?" };
            var temp22 = (STA_Bus_She_Ben)theSurvey.SectionB.STA_BusT.Sta_Bus_She_Ben;
            foreach (string s in temp22.Options)
            {
                sta_bus_she_ben_ans.Items.Add(s);
            }
            sta_bus_she_ben_ans.SelectedIndexChanged += Sta_bus_she_ben_ans_SelectedIndexChanged;

            var sta_bus_com = new Label { Text = theSurvey.SectionB.STA_BusT.Sta_Bus_Com.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var sta_bus_com_ans = new Entry { Placeholder = "Enter answer here..." };
            sta_bus_com_ans.Completed += Sta_bus_com_ans_Completed;

            var sta_bus_rec = new Label { Text = theSurvey.SectionB.STA_BusT.Sta_Bus_Rec.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var sta_bus_rec_ans = new Entry { Placeholder = "Enter answer here..." };
            sta_bus_rec_ans.Completed += Sta_bus_rec_ans_Completed;

            layout.Children.Add(sta_bus_sta_ser_are);
            layout.Children.Add(sta_bus_sta_ser_are_ans);
            layout.Children.Add(sta_bus_dis);
            layout.Children.Add(sta_bus_dis_ans);
            layout.Children.Add(sta_bus_min_wid);
            layout.Children.Add(sta_bus_min_wid_ans);
            layout.Children.Add(sta_bus_rou_sur);
            layout.Children.Add(sta_bus_rou_sur_ans);
            layout.Children.Add(sta_bus_tac_war_str);
            layout.Children.Add(sta_bus_tac_war_str_ans);
            layout.Children.Add(sta_bus_cur_cut);
            layout.Children.Add(sta_bus_cur_cut_ans);
            layout.Children.Add(sta_bus_lig);
            layout.Children.Add(sta_bus_lig_ans);
            layout.Children.Add(sta_bus_lig_opt);
            layout.Children.Add(sta_bus_lig_opt_ans);
            layout.Children.Add(sta_bus_lig_typ);
            layout.Children.Add(sta_bus_lig_typ_ans);
            layout.Children.Add(sta_bus_she_ben);
            layout.Children.Add(sta_bus_she_ben_ans);
            layout.Children.Add(sta_bus_com);
            layout.Children.Add(sta_bus_com_ans);
            layout.Children.Add(sta_bus_rec);
            layout.Children.Add(sta_bus_rec_ans);

            var pas_loa_des_zon = new Label { Text = theSurvey.SectionB.Passenger_LoadingT.Pas_Loa_Des_Zon.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var pas_loa_des_zon_ans = new Picker { Title = "Yes or no?" };
            var temp23 = (Pas_Loa_Des_Zon)theSurvey.SectionB.Passenger_LoadingT.Pas_Loa_Des_Zon;
            foreach (string s in temp23.Options)
            {
                pas_loa_des_zon_ans.Items.Add(s);
            }
            pas_loa_des_zon_ans.SelectedIndexChanged += Pas_loa_des_zon_ans_SelectedIndexChanged;

            var pas_loa_dis = new Label { Text = theSurvey.SectionB.Passenger_LoadingT.Pas_Loa_Dis.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var pas_loa_dis_ans = new Entry { Placeholder = "Enter answer here...", Keyboard = Keyboard.Numeric };
            pas_loa_dis_ans.Completed += Pas_loa_dis_ans_Completed;

            var pas_loa_min_wid = new Label { Text = theSurvey.SectionB.Passenger_LoadingT.Pas_Loa_Min_Wid.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var pas_loa_min_wid_ans = new Picker { Title = "Yes or no?" };
            var temp24 = (Pas_Loa_Min_Wid)theSurvey.SectionB.Passenger_LoadingT.Pas_Loa_Min_Wid;
            foreach (string s in temp24.Options)
            {
                pas_loa_min_wid_ans.Items.Add(s);
            }
            pas_loa_min_wid_ans.SelectedIndexChanged += Pas_loa_min_wid_ans_SelectedIndexChanged;

            var pas_loa_pas_sur = new Label { Text = theSurvey.SectionB.Passenger_LoadingT.Pas_Loa_Pas_Sur.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var pas_loa_pas_sur_ans = new Picker { Title = "Yes or no?" };
            var temp25 = (Pas_Loa_Pas_Sur)theSurvey.SectionB.Passenger_LoadingT.Pas_Loa_Pas_Sur;
            foreach (string s in temp25.Options)
            {
                pas_loa_pas_sur_ans.Items.Add(s);
            }
            pas_loa_pas_sur_ans.SelectedIndexChanged += Pas_loa_pas_sur_ans_SelectedIndexChanged;

            var pas_loa_tac_war_str = new Label { Text = theSurvey.SectionB.Passenger_LoadingT.Pas_Loa_Tac_War_Str.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var pas_loa_tac_war_str_ans = new Picker { Title = "Yes or no?" };
            var temp26 = (Pas_Loa_Tac_War_Str)theSurvey.SectionB.Passenger_LoadingT.Pas_Loa_Tac_War_Str;
            foreach (string s in temp26.Options)
            {
                pas_loa_tac_war_str_ans.Items.Add(s);
            }
            pas_loa_tac_war_str_ans.SelectedIndexChanged += Pas_loa_tac_war_str_ans_SelectedIndexChanged;

            var pas_loa_cov = new Label { Text = theSurvey.SectionB.Passenger_LoadingT.Pas_Loa_Cov.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var pas_loa_cov_ans = new Picker { Title = "Yes or no?" };
            var temp27 = (Pas_Loa_Cov)theSurvey.SectionB.Passenger_LoadingT.Pas_Loa_Cov;
            foreach (string s in temp27.Options)
            {
                pas_loa_cov_ans.Items.Add(s);
            }
            pas_loa_cov_ans.SelectedIndexChanged += Pas_loa_cov_ans_SelectedIndexChanged;

            var pas_loa_lig = new Label { Text = theSurvey.SectionB.Passenger_LoadingT.Pas_Loa_Lig.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var pas_loa_lig_ans = new Picker { Title = "Yes or no?" };
            var temp28 = (Pas_Loa_Lig)theSurvey.SectionB.Passenger_LoadingT.Pas_Loa_Lig;
            foreach (string s in temp28.Options)
            {
                pas_loa_lig_ans.Items.Add(s);
            }
            pas_loa_lig_ans.SelectedIndexChanged += Pas_loa_lig_ans_SelectedIndexChanged;

            var pas_loa_lig_opt = new Label { Text = theSurvey.SectionB.Passenger_LoadingT.Pas_Loa_Lig_Opt.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var pas_loa_lig_opt_ans = new Picker { Title = "Day or night?" };
            var temp29 = (Pas_Loa_Lig_Opt)theSurvey.SectionB.Passenger_LoadingT.Pas_Loa_Lig_Opt;
            foreach (string s in temp29.Options)
            {
                pas_loa_lig_opt_ans.Items.Add(s);
            }
            pas_loa_lig_opt_ans.SelectedIndexChanged += Pas_loa_lig_opt_ans_SelectedIndexChanged;

            var pas_loa_lig_typ = new Label { Text = theSurvey.SectionB.Passenger_LoadingT.Pas_Loa_Lig_Typ.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var pas_loa_lig_typ_ans = new Picker { Title = "Low, medium or bright?" };
            var temp30 = (Pas_Loa_Lig_Typ)theSurvey.SectionB.Passenger_LoadingT.Pas_Loa_Lig_Typ;
            foreach (string s in temp30.Options)
            {
                pas_loa_lig_typ_ans.Items.Add(s);
            }
            pas_loa_lig_typ_ans.SelectedIndexChanged += Pas_loa_lig_typ_ans_SelectedIndexChanged;

            var pas_loa_com = new Label { Text = theSurvey.SectionB.Passenger_LoadingT.Pas_Loa_Com.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var pas_loa_com_ans = new Entry { Placeholder = "Enter answer here..." };
            pas_loa_com_ans.Completed += Pas_loa_com_ans_Completed;

            var pas_loa_rec = new Label { Text = theSurvey.SectionB.Passenger_LoadingT.Pas_Loa_Rec.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var pas_loa_rec_ans = new Entry { Placeholder = "Enter answer here..." };
            pas_loa_rec_ans.Completed += Pas_loa_rec_ans_Completed;

            layout.Children.Add(pas_loa_des_zon);
            layout.Children.Add(pas_loa_des_zon_ans);
            layout.Children.Add(pas_loa_dis);
            layout.Children.Add(pas_loa_dis_ans);
            layout.Children.Add(pas_loa_min_wid);
            layout.Children.Add(pas_loa_min_wid_ans);
            layout.Children.Add(pas_loa_pas_sur);
            layout.Children.Add(pas_loa_pas_sur_ans);
            layout.Children.Add(pas_loa_tac_war_str);
            layout.Children.Add(pas_loa_tac_war_str_ans);
            layout.Children.Add(pas_loa_cov);
            layout.Children.Add(pas_loa_cov_ans);
            layout.Children.Add(pas_loa_lig);
            layout.Children.Add(pas_loa_lig_ans);
            layout.Children.Add(pas_loa_lig_opt);
            layout.Children.Add(pas_loa_lig_opt_ans);
            layout.Children.Add(pas_loa_lig_typ);
            layout.Children.Add(pas_loa_lig_typ_ans);
            layout.Children.Add(pas_loa_com);
            layout.Children.Add(pas_loa_com_ans);
            layout.Children.Add(pas_loa_rec);
            layout.Children.Add(pas_loa_rec_ans);

            var Sta_rou_rou_num = new Label { Text = theSurvey.SectionB.STA_RouteT.Sta_Rou_Rou_Num.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var Sta_rou_rou_num_ans = new Entry { Placeholder = "Enter answer here...", Keyboard = Keyboard.Numeric };
            Sta_rou_rou_num_ans.Completed += Sta_rou_rou_num_ans_Completed;

            var Sta_rou_nor_bou_sto = new Label { Text = theSurvey.SectionB.STA_RouteT.Sta_Rou_Nor_Bou_Sto.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var Sta_rou_nor_bou_sto_ans = new Entry { Placeholder = "Enter answer here...", Keyboard = Keyboard.Numeric };
            Sta_rou_nor_bou_sto_ans.Completed += Sta_rou_nor_bou_sto_ans_Completed;

            var Sta_rou_sou_bou_sto = new Label { Text = theSurvey.SectionB.STA_RouteT.Sta_Rou_Sou_Bou_Sto.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var Sta_rou_sou_bou_sto_ans = new Entry { Placeholder = "Enter answer here...", Keyboard = Keyboard.Numeric };
            Sta_rou_sou_bou_sto_ans.Completed += Sta_rou_sou_bou_sto_ans_Completed;

            var Sta_rou_eas_bou_sto = new Label { Text = theSurvey.SectionB.STA_RouteT.Sta_Rou_Eas_Bou_Sto.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var Sta_rou_eas_bou_sto_ans = new Entry { Placeholder = "Enter answer here...", Keyboard = Keyboard.Numeric };
            Sta_rou_eas_bou_sto_ans.Completed += Sta_rou_eas_bou_sto_ans_Completed;

            var Sta_rou_wes_bou_sto = new Label { Text = theSurvey.SectionB.STA_RouteT.Sta_Rou_Wes_Bou_Sto.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var Sta_rou_wes_bou_sto_ans = new Entry { Placeholder = "Enter answer here...", Keyboard = Keyboard.Numeric };
            Sta_rou_wes_bou_sto_ans.Completed += Sta_rou_wes_bou_sto_ans_Completed;

            layout.Children.Add(Sta_rou_rou_num);
            layout.Children.Add(Sta_rou_rou_num_ans);
            layout.Children.Add(Sta_rou_nor_bou_sto);
            layout.Children.Add(Sta_rou_nor_bou_sto_ans);
            layout.Children.Add(Sta_rou_sou_bou_sto);
            layout.Children.Add(Sta_rou_sou_bou_sto_ans);
            layout.Children.Add(Sta_rou_eas_bou_sto);
            layout.Children.Add(Sta_rou_eas_bou_sto_ans);
            layout.Children.Add(Sta_rou_wes_bou_sto);
            layout.Children.Add(Sta_rou_wes_bou_sto_ans);
        }

        private void Sta_rou_wes_bou_sto_ans_Completed(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionB.STA_RouteT.Sta_Rou_Wes_Bou_Sto.TheAnswer.setAnswer(((Entry)sender).Text);
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Please enter valid data. Your number was too long. This answer is allowed to be up to 11 characters long.", "OK");
            }
        }

        private void Sta_rou_eas_bou_sto_ans_Completed(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionB.STA_RouteT.Sta_Rou_Eas_Bou_Sto.TheAnswer.setAnswer(((Entry)sender).Text);
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Please enter valid data. Your number was too long. This answer is allowed to be up to 11 characters long.", "OK");
            }
        }

        private void Sta_rou_sou_bou_sto_ans_Completed(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionB.STA_RouteT.Sta_Rou_Sou_Bou_Sto.TheAnswer.setAnswer(((Entry)sender).Text);
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Please enter valid data. Your number was too long. This answer is allowed to be up to 11 characters long.", "OK");
            }
        }

        private void Sta_rou_nor_bou_sto_ans_Completed(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionB.STA_RouteT.Sta_Rou_Nor_Bou_Sto.TheAnswer.setAnswer(((Entry)sender).Text);
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Please enter valid data. Your number was too long. This answer is allowed to be up to 11 characters long.", "OK");
            }
        }

        private void Sta_rou_rou_num_ans_Completed(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionB.STA_RouteT.Sta_Rou_Rou_Num.TheAnswer.setAnswer(((Entry)sender).Text);
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Please enter valid data. Your number was too long. This answer is allowed to be up to 11 characters long.", "OK");
            }
        }

        private void Pas_loa_rec_ans_Completed(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionB.Passenger_LoadingT.Pas_Loa_Rec.TheAnswer.setAnswer(((Entry)sender).Text);
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Unforseen error.", "OK");
            }
        }

        private void Pas_loa_com_ans_Completed(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionB.Passenger_LoadingT.Pas_Loa_Com.TheAnswer.setAnswer(((Entry)sender).Text);
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Unforseen error.", "OK");
            }
        }

        private void Pas_loa_lig_typ_ans_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionB.Passenger_LoadingT.Pas_Loa_Lig_Typ.TheAnswer.setAnswer(((Picker)sender).SelectedItem.ToString());
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Unforseen error.", "OK");
            }
        }

        private void Pas_loa_lig_opt_ans_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionB.Passenger_LoadingT.Pas_Loa_Lig_Opt.TheAnswer.setAnswer(((Picker)sender).SelectedItem.ToString());
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Unforseen error.", "OK");
            }
        }

        private void Pas_loa_lig_ans_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionB.Passenger_LoadingT.Pas_Loa_Lig.TheAnswer.setAnswer(((Picker)sender).SelectedItem.ToString());
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Unforseen error.", "OK");
            }
        }

        private void Pas_loa_cov_ans_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionB.Passenger_LoadingT.Pas_Loa_Cov.TheAnswer.setAnswer(((Picker)sender).SelectedItem.ToString());
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Unforseen error.", "OK");
            }
        }

        private void Pas_loa_tac_war_str_ans_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionB.Passenger_LoadingT.Pas_Loa_Tac_War_Str.TheAnswer.setAnswer(((Picker)sender).SelectedItem.ToString());
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Unforseen error.", "OK");
            }
        }

        private void Pas_loa_pas_sur_ans_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionB.Passenger_LoadingT.Pas_Loa_Pas_Sur.TheAnswer.setAnswer(((Picker)sender).SelectedItem.ToString());
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Unforseen error.", "OK");
            }
        }

        private void Pas_loa_min_wid_ans_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionB.Passenger_LoadingT.Pas_Loa_Min_Wid.TheAnswer.setAnswer(((Picker)sender).SelectedItem.ToString());
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Unforseen error.", "OK");
            }
        }

        private void Pas_loa_dis_ans_Completed(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionB.Passenger_LoadingT.Pas_Loa_Dis.TheAnswer.setAnswer(((Entry)sender).Text);
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Please enter valid data. This answer allows 5 characters left of the decimal, and 2 to the right of the decimal.", "OK");
            }
        }

        private void Pas_loa_des_zon_ans_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionB.Passenger_LoadingT.Pas_Loa_Des_Zon.TheAnswer.setAnswer(((Picker)sender).SelectedItem.ToString());
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Unforseen error.", "OK");
            }
        }

        private void Sta_bus_rec_ans_Completed(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionB.STA_BusT.Sta_Bus_Rec.TheAnswer.setAnswer(((Entry)sender).Text);
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Unforseen error.", "OK");
            }
        }

        private void Sta_bus_com_ans_Completed(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionB.STA_BusT.Sta_Bus_Com.TheAnswer.setAnswer(((Entry)sender).Text);
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Unforseen error.", "OK");
            }
        }

        private void Sta_bus_she_ben_ans_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionB.STA_BusT.Sta_Bus_She_Ben.TheAnswer.setAnswer(((Picker)sender).SelectedItem.ToString());
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Unforseen error.", "OK");
            }
        }

        private void Sta_bus_lig_typ_ans_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionB.STA_BusT.Sta_Bus_Lig_Typ.TheAnswer.setAnswer(((Picker)sender).SelectedItem.ToString());
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Unforseen error.", "OK");
            }
        }

        private void Sta_bus_lig_opt_ans_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionB.STA_BusT.Sta_Bus_Lig_Opt.TheAnswer.setAnswer(((Picker)sender).SelectedItem.ToString());
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Unforseen error.", "OK");
            }
        }

        private void Sta_bus_lig_ans_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionB.STA_BusT.Sta_Bus_Lig.TheAnswer.setAnswer(((Picker)sender).SelectedItem.ToString());
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Unforseen error.", "OK");
            }
        }

        private void Sta_bus_cur_cut_ans_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionB.STA_BusT.Sta_Bus_Cur_Cut.TheAnswer.setAnswer(((Picker)sender).SelectedItem.ToString());
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Unforseen error.", "OK");
            }
        }

        private void Sta_bus_tac_war_str_ans_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionB.STA_BusT.Sta_Bus_Tac_War_Str.TheAnswer.setAnswer(((Picker)sender).SelectedItem.ToString());
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Unforseen error.", "OK");
            }
        }

        private void Sta_bus_rou_sur_ans_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionB.STA_BusT.Sta_Bus_Rou_Sur.TheAnswer.setAnswer(((Picker)sender).SelectedItem.ToString());
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Unforseen error.", "OK");
            }
        }

        private void Sta_bus_min_wid_ans_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionB.STA_BusT.Sta_Bus_Min_Wid.TheAnswer.setAnswer(((Picker)sender).SelectedItem.ToString());
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Unforseen error.", "OK");
            }
        }

        private void Sta_bus_dis_ans_Completed(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionB.STA_BusT.Sta_Bus_Dis.TheAnswer.setAnswer(((Entry)sender).Text);
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Please enter valid data. This answer allows 5 characters left of the decimal, and 2 to the right of the decimal.", "OK");
            }
        }

        private void Sta_bus_sta_ser_are_ans_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionB.STA_BusT.Sta_Bus_Sta_Ser_Are.TheAnswer.setAnswer(((Picker)sender).SelectedItem.ToString());
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Unforseen error.", "OK");
            }
        }

        private void Rou_fro_par_rec_ans_Completed(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionB.Route_From_ParkingT.Rou_Fro_Par_Rec.TheAnswer.setAnswer(((Entry)sender).Text);
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Unforseen error.", "OK");
            }
        }

        private void Rou_fro_par_com_ans_Completed(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionB.Route_From_ParkingT.Rou_Fro_Par_Com.TheAnswer.setAnswer(((Entry)sender).Text);
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Unforseen error.", "OK");
            }
        }

        private void Rou_fro_par_lig_typ_ans_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionB.Route_From_ParkingT.Rou_Fro_Par_Lig_Typ.TheAnswer.setAnswer(((Picker)sender).SelectedItem.ToString());
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Unforseen error.", "OK");
            }
        }

        private void Rou_fro_par_lig_opt_ans_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionB.Route_From_ParkingT.Rou_Fro_Par_Lig_Opt.TheAnswer.setAnswer(((Picker)sender).SelectedItem.ToString());
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Unforseen error.", "OK");
            }
        }

        private void Rou_fro_par_lig_ans_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionB.Route_From_ParkingT.Rou_Fro_Par_Lig.TheAnswer.setAnswer(((Picker)sender).SelectedItem.ToString());
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Unforseen error.", "OK");
            }
        }

        private void Rou_fro_par_cov_ans_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionB.Route_From_ParkingT.Rou_Fro_Par_Cov.TheAnswer.setAnswer(((Picker)sender).SelectedItem.ToString());
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Unforseen error.", "OK");
            }
        }

        private void Rou_fro_par_tac_war_ans_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionB.Route_From_ParkingT.Rou_Fro_Par_Tac_War.TheAnswer.setAnswer(((Picker)sender).SelectedItem.ToString());
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Unforseen error.", "OK");
            }
        }

        private void Rou_fro_par_rou_cur_ans_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionB.Route_From_ParkingT.Rou_Fro_Par_Rou_Cur.TheAnswer.setAnswer(((Picker)sender).SelectedItem.ToString());
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Unforseen error.", "OK");
            }
        }

        private void Rou_fro_par_rou_sur_ans_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionB.Route_From_ParkingT.Rou_Fro_Par_Rou_Sur.TheAnswer.setAnswer(((Picker)sender).SelectedItem.ToString());
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Unforseen error.", "OK");
            }
        }

        private void Rou_fro_par_min_wid_ans_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionB.Route_From_ParkingT.Rou_Fro_Par_Min_Wid.TheAnswer.setAnswer(((Picker)sender).SelectedItem.ToString());
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Unforseen error.", "OK");
            }
        }

        private void Rou_fro_par_dis_ans_Completed(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionB.Route_From_ParkingT.Rou_Fro_Par_Dis.TheAnswer.setAnswer(((Entry)sender).Text);
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Please enter valid data. This answer allows 5 characters left of the decimal, and 2 to the right of the decimal.", "OK");
            }
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