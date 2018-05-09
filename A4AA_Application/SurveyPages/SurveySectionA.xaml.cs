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
            
            /*PropertyInfo[] properties2 = typeof(ConfigurationT).GetProperties();
            foreach (PropertyInfo prop in properties2)
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

            PropertyInfo[] properties3 = typeof(CategoryT).GetProperties();
            foreach (PropertyInfo prop in properties3)
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
            }*/

            for (int i = 0; i < QuestionLabels.Count; i++)
            {
                layout.Children.Add((Label)QuestionLabels[i]);
                layout.Children.Add((View)QuestionAnswerSpaces[i]);
            }
            /*
            //Questions
            var est_nam = new Label { Text = theSurvey.SectionA.EstablishmentT.Est_Nam.QuestionText , HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))};
            var est_nam_ans = new Entry { Placeholder = "Enter answer here..." };
            est_nam_ans.Completed += Est_nam_ans_Completed;

            var est_web = new Label { Text = theSurvey.SectionA.EstablishmentT.Est_Web.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var est_web_ans = new Entry { Placeholder = "Enter answer here..." };
            est_web_ans.Completed += Est_web_ans_Completed;

            var est_sub = new Label { Text = theSurvey.SectionA.EstablishmentT.Est_Sub.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var est_sub_ans = new Entry { Placeholder = "Enter answer here..." };
            est_sub_ans.Completed += Est_sub_ans_Completed;

            var est_dat = new Label { Text = theSurvey.SectionA.EstablishmentT.Est_Dat.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var est_dat_ans = new DatePicker { };
            est_dat_ans.DateSelected += Est_dat_ans_Completed;

            var est_str = new Label { Text = theSurvey.SectionA.EstablishmentT.Est_Str.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var est_str_ans = new Entry { Placeholder = "Enter answer here..." };
            est_str_ans.Completed += Est_str_ans_Completed;

            var est_cit = new Label { Text = theSurvey.SectionA.EstablishmentT.Est_Cit.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var est_cit_ans = new Entry { Placeholder = "Enter answer here..." };
            est_cit_ans.Completed += Est_cit_ans_Completed;

            var est_sta = new Label { Text = theSurvey.SectionA.EstablishmentT.Est_Sta.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var est_sta_ans = new Entry { Placeholder = "Enter answer here..." };
            est_sta_ans.Completed += Est_sta_ans_Completed;

            var est_zip = new Label { Text = theSurvey.SectionA.EstablishmentT.Est_Zip.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var est_zip_ans = new Entry { Placeholder = "Enter answer here...", Keyboard = Keyboard.Numeric };
            est_zip_ans.Completed += Est_zip_ans_Completed;

            var est_pho = new Label { Text = theSurvey.SectionA.EstablishmentT.Est_Pho.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var est_pho_ans = new Entry { Placeholder = "Enter answer here...", Keyboard = Keyboard.Numeric };
            est_pho_ans.Completed += Est_pho_ans_Completed;

            var est_tty = new Label { Text = theSurvey.SectionA.EstablishmentT.Est_Tty.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var est_tty_ans = new Entry { Placeholder = "Enter answer here..." };
            est_tty_ans.Completed += Est_tty_ans_Completed;

            var est_con_fna = new Label { Text = theSurvey.SectionA.EstablishmentT.Est_Con_Fna.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var est_con_fna_ans = new Entry { Placeholder = "Enter answer here..." };
            est_con_fna_ans.Completed += Est_con_fna_ans_Completed;

            var est_con_lna = new Label { Text = theSurvey.SectionA.EstablishmentT.Est_Con_Lna.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var est_con_lna_ans = new Entry { Placeholder = "Enter answer here..." };
            est_con_lna_ans.Completed += Est_con_lna_ans_Completed;

            var est_con_tit = new Label { Text = theSurvey.SectionA.EstablishmentT.Est_Con_Tit.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var est_con_tit_ans = new Entry { Placeholder = "Enter answer here..." };
            est_con_tit_ans.Completed += Est_con_tit_ans_Completed;

            var est_con_ema = new Label { Text = theSurvey.SectionA.EstablishmentT.Est_Con_Ema.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var est_con_ema_ans = new Entry { Placeholder = "Enter answer here..." };
            est_con_ema_ans.Completed += Est_con_ema_ans_Completed;

            var est_con_com = new Label { Text = theSurvey.SectionA.EstablishmentT.Est_Con_Com.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var est_con_com_ans = new Entry { Placeholder = "Enter answer here..." };
            est_con_com_ans.Completed += Est_con_com_ans_Completed;

            var con_nam = new Label { Text = theSurvey.SectionA.ConfigurationT.Con_Nam.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var con_nam_ans = new Picker { Title = "Select Premises Configuration" };
            Con_Nam temp = (Con_Nam)theSurvey.SectionA.ConfigurationT.Con_Nam;
            foreach (string s in temp.Options)
            {
                con_nam_ans.Items.Add(s);
            }
            con_nam_ans.SelectedIndexChanged += Con_nam_ans_SelectedIndexChanged;

            var cat_nam = new Label { Text = theSurvey.SectionA.CategoryT.Cat_Nam.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            var cat_nam_ans = new Picker { Title = "Select Category of Establishment" };
            Cat_Nam temp2 = (Cat_Nam)theSurvey.SectionA.CategoryT.Cat_Nam;
            foreach (string s in temp2.Options)
            {
                cat_nam_ans.Items.Add(s);
            }
            cat_nam_ans.SelectedIndexChanged += Cat_nam_ans_SelectedIndexChanged;

			//adding elemetns to form
            layout.Children.Add(est_nam);
            layout.Children.Add(est_nam_ans);
            layout.Children.Add(est_dat);
            layout.Children.Add(est_dat_ans);
            layout.Children.Add(est_web);
            layout.Children.Add(est_web_ans);
            layout.Children.Add(cat_nam);
            layout.Children.Add(cat_nam_ans);
            layout.Children.Add(est_sub);
            layout.Children.Add(est_sub_ans);
            layout.Children.Add(con_nam);
            layout.Children.Add(con_nam_ans);
            layout.Children.Add(est_str);
            layout.Children.Add(est_str_ans);
            layout.Children.Add(est_cit);
            layout.Children.Add(est_cit_ans);
            layout.Children.Add(est_sta);
            layout.Children.Add(est_sta_ans);
            layout.Children.Add(est_zip);
            layout.Children.Add(est_zip_ans);
            layout.Children.Add(est_pho);
            layout.Children.Add(est_pho_ans);
            layout.Children.Add(est_tty);
            layout.Children.Add(est_tty_ans);
            layout.Children.Add(est_con_fna);
            layout.Children.Add(est_con_fna_ans);
            layout.Children.Add(est_con_lna);
            layout.Children.Add(est_con_lna_ans);
            layout.Children.Add(est_con_tit);
            layout.Children.Add(est_con_tit_ans);
            layout.Children.Add(est_con_ema);
            layout.Children.Add(est_con_ema_ans);
            layout.Children.Add(est_con_com);
            layout.Children.Add(est_con_com_ans);*/
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

        /*public void Sub_but_clicked(object sender, EventArgs args)
        {
            String message = "";
            PropertyInfo[] properties = typeof(EstablishmentT).GetProperties();
            foreach (PropertyInfo prop in table1.GetType().GetProperties())
            {
                Question q = (Question)prop.GetValue(table1);
                message += q.TheAnswer.getAnswer() + "\n";

            }

            properties = typeof(ConfigurationT).GetProperties();
            foreach (PropertyInfo prop in table2.GetType().GetProperties())
            {
                Question q = (Question)prop.GetValue(table2);
                message += q.TheAnswer.getAnswer() + "\n";

            }

            properties = typeof(CategoryT).GetProperties();
            foreach (PropertyInfo prop in table3.GetType().GetProperties())
            {
                Question q = (Question)prop.GetValue(table3);
                message += q.TheAnswer.getAnswer() + "\n";

            }

            DisplayAlert("Answers", message, "OK");
        }*/

        /*
		//Events
        private void Cat_nam_ans_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionA.CategoryT.Cat_Nam.TheAnswer.setAnswer(((Picker)sender).SelectedItem.ToString());
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Unforseen error.", "OK");
            }
        }

        private void Con_nam_ans_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionA.ConfigurationT.Con_Nam.TheAnswer.setAnswer(((Picker)sender).SelectedItem.ToString());
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Unforseen error.", "OK");
            }
        }

        private void Est_con_com_ans_Completed(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionA.EstablishmentT.Est_Con_Com.TheAnswer.setAnswer(((Entry)sender).Text);
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Unforseen error.", "OK");
            }
        }

        private void Est_con_ema_ans_Completed(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionA.EstablishmentT.Est_Con_Ema.TheAnswer.setAnswer(((Entry)sender).Text);
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Please enter valid data. Your text was too long. Text for this answer is allowed to be up to 255 characters long.", "OK");
            }
        }

        private void Est_con_tit_ans_Completed(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionA.EstablishmentT.Est_Con_Tit.TheAnswer.setAnswer(((Entry)sender).Text);
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Please enter valid data. Your text was too long. Text for this answer is allowed to be up to 255 characters long.", "OK");
            }
        }

        private void Est_con_lna_ans_Completed(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionA.EstablishmentT.Est_Con_Lna.TheAnswer.setAnswer(((Entry)sender).Text);
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Please enter valid data. Your text was too long. Text for this answer is allowed to be up to 255 characters long.", "OK");
            }
        }

        private void Est_con_fna_ans_Completed(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionA.EstablishmentT.Est_Con_Fna.TheAnswer.setAnswer(((Entry)sender).Text);
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Please enter valid data. Your text was too long. Text for this answer is allowed to be up to 255 characters long.", "OK");
            }
        }

        private void Est_tty_ans_Completed(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionA.EstablishmentT.Est_Tty.TheAnswer.setAnswer(((Entry)sender).Text);
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Please enter valid data. Your text was too long. Text for this answer is allowed to be up to 32 characters long.", "OK");
            }
        }

        private void Est_pho_ans_Completed(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionA.EstablishmentT.Est_Pho.TheAnswer.setAnswer(((Entry)sender).Text);
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Please enter valid data. Your number was too long. This answer is allowed to be up to 32 characters long.", "OK");
            }
        }

        private void Est_zip_ans_Completed(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionA.EstablishmentT.Est_Zip.TheAnswer.setAnswer(((Entry)sender).Text);
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Please enter valid data. Your number was too long. This answer is allowed to be up to 11 characters long.", "OK");
            }
        }

        private void Est_sta_ans_Completed(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionA.EstablishmentT.Est_Sta.TheAnswer.setAnswer(((Entry)sender).Text);
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Please enter valid data. Your text was too long. Text for this answer is allowed to be up to 8 characters long. Consider abbreviations.", "OK");
            }
        }

        private void Est_cit_ans_Completed(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionA.EstablishmentT.Est_Cit.TheAnswer.setAnswer(((Entry)sender).Text);
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Please enter valid data. Your text was too long. Text for this answer is allowed to be up to 255 characters long.", "OK");
            }
        }

        private void Est_str_ans_Completed(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionA.EstablishmentT.Est_Str.TheAnswer.setAnswer(((Entry)sender).Text);
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Please enter valid data. Your text was too long. Text for this answer is allowed to be up to 255 characters long.", "OK");
            }
        }

        private void Est_dat_ans_Completed(object sender, EventArgs e)
        {
            theSurvey.SectionA.EstablishmentT.Est_Dat.TheAnswer.setAnswer(((DatePicker)sender).Date.ToString());
        }

        private void Est_sub_ans_Completed(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionA.EstablishmentT.Est_Sub.TheAnswer.setAnswer(((Entry)sender).Text);
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Please enter valid data. Your text was too long. Text for this answer is allowed to be up to 255 characters long.", "OK");
            }
        }

        private void Est_web_ans_Completed(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionA.EstablishmentT.Est_Web.TheAnswer.setAnswer(((Entry)sender).Text);
            }
            catch (Exception)
            {
                DisplayAlert("Error", "Please enter valid data. Your text was too long. Text for this answer is allowed to be up to 255 characters long.", "OK");
            }
        }

        private void Est_nam_ans_Completed(object sender, EventArgs e)
        {
            try
            {
                theSurvey.SectionA.EstablishmentT.Est_Nam.TheAnswer.setAnswer(((Entry)sender).Text);
            }
            catch (Exception)
            {
                DisplayAlert("Error","Please enter valid data. Your text was too long. Text for this answer is allowed to be up to 255 characters long.","OK");
            }
        }*/
    }
}