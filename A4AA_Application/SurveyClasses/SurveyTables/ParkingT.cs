using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyQuestions;

namespace A4AA_Application.SurveyClasses.SurveyTables
{
    public class ParkingT
    {
        private Question par_Lot_Fre = new Par_Lot_Fre();
        private Question par_Str_Met = new Par_Str_Met();
        private Question par_Par_Typ = new Par_Par_Typ();
        private Question par_Tot_Num_Spa = new Par_Tot_Num_Spa();
        private Question par_Num_Res_Spa = new Par_Num_Res_Spa();
        private Question par_Num_Acc_Spa = new Par_Num_Acc_Spa();
        private Question par_Num_Van_Acc = new Par_Num_Van_Acc();
        private Question par_Res_Spa_Sig = new Par_Res_Spa_Sig();
        private Question par_Res_Spa_Obs = new Par_Res_Spa_Obs();
        private Question par_Com = new Par_Com();
        private Question par_Rec = new Par_Rec();

        public Question Par_Lot_Fre { get => par_Lot_Fre; set => par_Lot_Fre = value; }
        public Question Par_Str_Met { get => par_Str_Met; set => par_Str_Met = value; }
        public Question Par_Par_Typ { get => par_Par_Typ; set => par_Par_Typ = value; }
        public Question Par_Tot_Num_Spa { get => par_Tot_Num_Spa; set => par_Tot_Num_Spa = value; }
        public Question Par_Num_Res_Spa { get => par_Num_Res_Spa; set => par_Num_Res_Spa = value; }
        public Question Par_Num_Acc_Spa { get => par_Num_Acc_Spa; set => par_Num_Acc_Spa = value; }
        public Question Par_Num_Van_Acc { get => par_Num_Van_Acc; set => par_Num_Van_Acc = value; }
        public Question Par_Res_Spa_Sig { get => par_Res_Spa_Sig; set => par_Res_Spa_Sig = value; }
        public Question Par_Res_Spa_Obs { get => par_Res_Spa_Obs; set => par_Res_Spa_Obs = value; }
        public Question Par_Com { get => par_Com; set => par_Com = value; }
        public Question Par_Rec { get => par_Rec; set => par_Rec = value; }
    }
}
