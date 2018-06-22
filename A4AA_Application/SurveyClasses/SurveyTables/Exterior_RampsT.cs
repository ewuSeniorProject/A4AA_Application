using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyQuestions;

namespace A4AA_Application.SurveyClasses.SurveyTables
{
    public class Exterior_RampsT
    {
        private Question ext_Ram_Ram_Req = new Ext_Ram_Ram_Req();
        private Question ext_Ram_Ram_Ava = new Ext_Ram_Ram_Ava();
        private Question ext_Ram_Min_Wid = new Ext_Ram_Min_Wid();
        private Question ext_Ram_Wid_Bet_Han = new Ext_Ram_Wid_Bet_Han();
        private Question ext_Ram_Min_Slo = new Ext_Ram_Min_Slo();
        private Question ext_Ram_Slo = new Ext_Ram_Slo();
        private Question ext_Ram_Lev_Lan_Bot = new Ext_Ram_Lev_Lan_Bot();
        private Question ext_Ram_Lev_Lan_Loc = new Ext_Ram_Lev_Lan_Loc();
        private Question ext_Ram_Obs = new Ext_Ram_Obs();
        private Question ext_Ram_Han_Bot_Sid = new Ext_Ram_Han_Bot_Sid();
        private Question ext_Ram_Han_Sid = new Ext_Ram_Han_Sid();
        private Question ext_Ram_Han_Reg_Hei = new Ext_Ram_Han_Reg_Hei();
        private Question ext_Ram_Han_Hei = new Ext_Ram_Han_Hei();
        private Question ext_Ram_Sid_Gua = new Ext_Ram_Sid_Gua();
        private Question ext_Ram_Lig = new Ext_Ram_Lig();
        private Question ext_Ram_Lig_Opt = new Ext_Ram_Lig_Opt();
        private Question ext_Ram_Lig_Typ = new Ext_Ram_Lig_Typ();
        private Question ext_Ram_Com = new Ext_Ram_Com();
        private Question ext_Ram_Rec = new Ext_Ram_Rec();

        public Question Ext_Ram_Ram_Req { get => ext_Ram_Ram_Req; set => ext_Ram_Ram_Req = value; }
        public Question Ext_Ram_Ram_Ava { get => ext_Ram_Ram_Ava; set => ext_Ram_Ram_Ava = value; }
        public Question Ext_Ram_Min_Wid { get => ext_Ram_Min_Wid; set => ext_Ram_Min_Wid = value; }
        public Question Ext_Ram_Wid_Bet_Han { get => ext_Ram_Wid_Bet_Han; set => ext_Ram_Wid_Bet_Han = value; }
        public Question Ext_Ram_Min_Slo { get => ext_Ram_Min_Slo; set => ext_Ram_Min_Slo = value; }
        public Question Ext_Ram_Slo { get => ext_Ram_Slo; set => ext_Ram_Slo = value; }
        public Question Ext_Ram_Lev_Lan_Bot { get => ext_Ram_Lev_Lan_Bot; set => ext_Ram_Lev_Lan_Bot = value; }
        public Question Ext_Ram_Lev_Lan_Loc { get => ext_Ram_Lev_Lan_Loc; set => ext_Ram_Lev_Lan_Loc = value; }
        public Question Ext_Ram_Obs { get => ext_Ram_Obs; set => ext_Ram_Obs = value; }
        public Question Ext_Ram_Han_Bot_Sid { get => ext_Ram_Han_Bot_Sid; set => ext_Ram_Han_Bot_Sid = value; }
        public Question Ext_Ram_Han_Sid { get => ext_Ram_Han_Sid; set => ext_Ram_Han_Sid = value; }
        public Question Ext_Ram_Han_Reg_Hei { get => ext_Ram_Han_Reg_Hei; set => ext_Ram_Han_Reg_Hei = value; }
        public Question Ext_Ram_Han_Hei { get => ext_Ram_Han_Hei; set => ext_Ram_Han_Hei = value; }
        public Question Ext_Ram_Sid_Gua { get => ext_Ram_Sid_Gua; set => ext_Ram_Sid_Gua = value; }
        public Question Ext_Ram_Lig { get => ext_Ram_Lig; set => ext_Ram_Lig = value; }
        public Question Ext_Ram_Lig_Opt { get => ext_Ram_Lig_Opt; set => ext_Ram_Lig_Opt = value; }
        public Question Ext_Ram_Lig_Typ { get => ext_Ram_Lig_Typ; set => ext_Ram_Lig_Typ = value; }
        public Question Ext_Ram_Com { get => ext_Ram_Com; set => ext_Ram_Com = value; }
        public Question Ext_Ram_Rec { get => ext_Ram_Rec; set => ext_Ram_Rec = value; }
        /*const double LARGEST_VALUE_ACCEPTED = 99999.99;
const int NUM_DIGITS_AFTER_DECIMAL = 2;

private string ramp_required;
private string ramp_available;
private string min_width;
private double width_between_handrails;
private decimal slope;
private string level_landing_both;
private string level_landing_location;
private string obstacles;
private string handrail_both_sides;
private string handrail_side;
private string handrail_regulations_height;
private string handrail_height;
private string side_guards;
private string lighting;
private string lighting_option;
private string lighting_type;
private string comment;
private string recommendations;


public string Ramp_required
{
get => ramp_required;
set
{
if (value.Length > 4)
throw new ArgumentOutOfRangeException();

ramp_required = value;
}
}
public string Ramp_available
{
get => ramp_available;
set
{
if (value.Length > 4)
throw new ArgumentOutOfRangeException();

ramp_available = value;
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
public double Width_between_handrails
{
get => width_between_handrails;
set
{
if (value > LARGEST_VALUE_ACCEPTED)
throw new ArgumentOutOfRangeException();

width_between_handrails = Math.Round(value, NUM_DIGITS_AFTER_DECIMAL);
}
}
public string Level_landing_both
{
get => level_landing_both;
set
{
if (value.Length > 4)
throw new ArgumentOutOfRangeException();

level_landing_both = value;
}
}
public string Level_landing_location
{
get => level_landing_location;
set
{
if (value.Length > 4)
throw new ArgumentOutOfRangeException();

level_landing_location = value;
}
}
public string Obstacles
{
get => obstacles;
set
{
if (value.Length > 4)
throw new ArgumentOutOfRangeException();

obstacles = value;
}
}
public string Handrail_both_sides
{
get => handrail_both_sides;
set
{
if (value.Length > 4)
throw new ArgumentOutOfRangeException();

handrail_both_sides = value;
}
}
public string Handrail_side
{
get => handrail_side;
set
{
if (value.Length > 32)
throw new ArgumentOutOfRangeException();

handrail_side = value;
}
}
public string Handrail_regulations_height
{
get => handrail_regulations_height;
set
{
if (value.Length > 4)
throw new ArgumentOutOfRangeException();

handrail_regulations_height = value;
}
}
public string Handrail_height
{
get => handrail_height;
set
{
if (value.Length > 4)
throw new ArgumentOutOfRangeException();

handrail_height = value;
}
}
public string Side_guard
{
get => side_guards;
set
{
if (value.Length > 4)
throw new ArgumentOutOfRangeException();

side_guards = value;
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
if (value.Length > 32)
throw new ArgumentOutOfRangeException();

lighting_type = value;
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
}

public decimal Slope
{
get => slope;
set
{
if (value > (decimal)LARGEST_VALUE_ACCEPTED)
throw new ArgumentOutOfRangeException();

slope = (decimal)Math.Round(value, NUM_DIGITS_AFTER_DECIMAL);
}
}*/
    }
}
