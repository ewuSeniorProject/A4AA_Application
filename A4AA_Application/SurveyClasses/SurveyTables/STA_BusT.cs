using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyQuestions;

namespace A4AA_Application.SurveyClasses.SurveyTables
{
    public class STA_BusT
    {
        private Question sta_Bus_Sta_Ser_Are = new STA_Bus_Sta_Ser_Are();
        private Question sta_Bus_Dis = new STA_Bus_Dis();
        private Question sta_Bus_Min_Wid = new STA_Bus_Min_Wid();
        private Question sta_Bus_Rou_Sur = new STA_Bus_Rou_Sur();
        private Question sta_Bus_Tac_War_Str = new STA_Bus_Tac_War_Str();
        private Question sta_Bus_Cur_Cut = new STA_Bus_Cur_Cut();
        private Question sta_Bus_Lig = new STA_Bus_Lig();
        private Question sta_Bus_Lig_Opt = new STA_Bus_Lig_Opt();
        private Question sta_Bus_Lig_Typ = new STA_Bus_Lig_Typ();
        private Question sta_Bus_She_Ben = new STA_Bus_She_Ben();
        private Question sta_Bus_Com = new STA_Bus_Com();
        private Question sta_Bus_Rec = new STA_Bus_Rec();

        public Question Sta_Bus_Sta_Ser_Are { get => sta_Bus_Sta_Ser_Are; set => sta_Bus_Sta_Ser_Are = value; }
        public Question Sta_Bus_Dis { get => sta_Bus_Dis; set => sta_Bus_Dis = value; }
        public Question Sta_Bus_Min_Wid { get => sta_Bus_Min_Wid; set => sta_Bus_Min_Wid = value; }
        public Question Sta_Bus_Rou_Sur { get => sta_Bus_Rou_Sur; set => sta_Bus_Rou_Sur = value; }
        public Question Sta_Bus_Tac_War_Str { get => sta_Bus_Tac_War_Str; set => sta_Bus_Tac_War_Str = value; }
        public Question Sta_Bus_Cur_Cut { get => sta_Bus_Cur_Cut; set => sta_Bus_Cur_Cut = value; }
        public Question Sta_Bus_Lig { get => sta_Bus_Lig; set => sta_Bus_Lig = value; }
        public Question Sta_Bus_Lig_Opt { get => sta_Bus_Lig_Opt; set => sta_Bus_Lig_Opt = value; }
        public Question Sta_Bus_Lig_Typ { get => sta_Bus_Lig_Typ; set => sta_Bus_Lig_Typ = value; }
        public Question Sta_Bus_She_Ben { get => sta_Bus_She_Ben; set => sta_Bus_She_Ben = value; }
        public Question Sta_Bus_Com { get => sta_Bus_Com; set => sta_Bus_Com = value; }
        public Question Sta_Bus_Rec { get => sta_Bus_Rec; set => sta_Bus_Rec = value; }
        /*private const double LARGEST_VALUE_ACCEPTED = 99999.99;
private const int NUM_DIGITS_AFTER_DECIMAL = 2;

private string sta_service_area;
private decimal distance;
private string min_width;
private string route_surface;
private string tactile_warning_strips;
private string curb_cuts;
private string lighting;
private string lighting_option;
private string lighting_type;
private string shelter_bench;
private string comment;
private string recommendations;



public string Sta_service_area
{
get => sta_service_area;
set
{
if (value.Length > 4)
throw new ArgumentOutOfRangeException();

sta_service_area = value;
}
}
public decimal Distance
{
get => distance;
set
{
if (value > (decimal)LARGEST_VALUE_ACCEPTED)
throw new ArgumentOutOfRangeException();

distance = (decimal)Math.Round(value, NUM_DIGITS_AFTER_DECIMAL);
}
}
public string Min_width
{
get => min_width;
set
{
if (value.Length > 4)
throw new ArgumentOutOfRangeException();

min_width = value;
}
}
public string Route_surface
{
get => route_surface;
set
{
if (value.Length > 4)
throw new ArgumentOutOfRangeException();

route_surface = value;
}
}
public string Tactile_warning_strips
{
get => tactile_warning_strips;
set
{
if (value.Length > 4)
throw new ArgumentOutOfRangeException();

tactile_warning_strips = value;
}
}
public string Curb_cuts
{
get => curb_cuts;
set
{
if (value.Length > 4)
throw new ArgumentOutOfRangeException();

curb_cuts = value;
}
}
public string Lighting
{
get => lighting;
set
{
if (value.Length > 4)
throw new ArgumentOutOfRangeException();

lighting = value;
}
}
public string Lighting_option
{
get => lighting_option;
set
{
if (value.Length > 32)
throw new ArgumentOutOfRangeException();

lighting_option = value;
}
}
public string Lighting_type
{
get => lighting_type;
set
{
if (value.Length > 4)
throw new ArgumentOutOfRangeException();

lighting_type = value;
}
}
public string Shelter_bench
{
get => shelter_bench;
set
{
if (value.Length > 4)
throw new ArgumentOutOfRangeException();

shelter_bench = value;
}
}
public string Comment
{
get => comment;
set
{
comment = value;
}
}
public string Recommendations
{
get => recommendations;
set
{
recommendations = value;
}
}*/
    }
}
