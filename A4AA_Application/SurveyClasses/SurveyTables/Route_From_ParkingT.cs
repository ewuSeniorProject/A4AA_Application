using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyQuestions;

namespace A4AA_Application.SurveyClasses.SurveyTables
{
    public class Route_From_ParkingT
    {
        private Question rou_Fro_Par_Dis = new Rou_Fro_Par_Dis();
        private Question rou_Fro_Par_Min_Wid = new Rou_Fro_Par_Min_Wid();
        private Question rou_Fro_Par_Rou_Sur = new Rou_Fro_Par_Rou_Sur();
        private Question rou_Fro_Par_Rou_Cur = new Rou_Fro_Par_Rou_Cur();
        private Question rou_Fro_Par_Tac_War = new Rou_Fro_Par_Tac_War();
        private Question rou_Fro_Par_Cov = new Rou_Fro_Par_Cov();
        private Question rou_Fro_Par_Lig = new Rou_Fro_Par_Lig();
        private Question rou_Fro_Par_Lig_Opt = new Rou_Fro_Par_Lig_Opt();
        private Question rou_Fro_Par_Lig_Typ = new Rou_Fro_Par_Lig_Typ();
        private Question rou_Fro_Par_Com = new Rou_Fro_Par_Com();
        private Question rou_Fro_Par_Rec = new Rou_Fro_Par_Rec();

        public Question Rou_Fro_Par_Dis { get => rou_Fro_Par_Dis; set => rou_Fro_Par_Dis = value; }
        public Question Rou_Fro_Par_Min_Wid { get => rou_Fro_Par_Min_Wid; set => rou_Fro_Par_Min_Wid = value; }
        public Question Rou_Fro_Par_Rou_Sur { get => rou_Fro_Par_Rou_Sur; set => rou_Fro_Par_Rou_Sur = value; }
        public Question Rou_Fro_Par_Rou_Cur { get => rou_Fro_Par_Rou_Cur; set => rou_Fro_Par_Rou_Cur = value; }
        public Question Rou_Fro_Par_Tac_War { get => rou_Fro_Par_Tac_War; set => rou_Fro_Par_Tac_War = value; }
        public Question Rou_Fro_Par_Cov { get => rou_Fro_Par_Cov; set => rou_Fro_Par_Cov = value; }
        public Question Rou_Fro_Par_Lig { get => rou_Fro_Par_Lig; set => rou_Fro_Par_Lig = value; }
        public Question Rou_Fro_Par_Lig_Opt { get => rou_Fro_Par_Lig_Opt; set => rou_Fro_Par_Lig_Opt = value; }
        public Question Rou_Fro_Par_Lig_Typ { get => rou_Fro_Par_Lig_Typ; set => rou_Fro_Par_Lig_Typ = value; }
        public Question Rou_Fro_Par_Com { get => rou_Fro_Par_Com; set => rou_Fro_Par_Com = value; }
        public Question Rou_Fro_Par_Rec { get => rou_Fro_Par_Rec; set => rou_Fro_Par_Rec = value; }
        /*
private const double LARGEST_VALUE_ACCEPTED = 99999.99;
private const int NUM_DIGITS_AFTER_DECIMAL = 2;

private double distance;
private string min_width;
private string route_surface;
private string route_curbs;
private string tactile_warning;
private string covered;
private string lighting;
private string lighting_option;
private string lighting_type;
private string comment;
private string recommendations;


public double Distance
{
get => distance;
set
{
if (value > LARGEST_VALUE_ACCEPTED)
throw new ArgumentOutOfRangeException();

distance = Math.Round(value, NUM_DIGITS_AFTER_DECIMAL);
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
if (value.Length > 255)
throw new ArgumentOutOfRangeException();

route_surface = value;
}
}
public string Route_curbs
{
get => route_curbs;
set
{
if (value.Length > 4)
throw new ArgumentOutOfRangeException();

route_curbs = value;
}
}
public string Tactile_warning
{
get => tactile_warning;
set
{
if (value.Length > 255)
throw new ArgumentOutOfRangeException();

tactile_warning = value;
}
}
public string Covered
{
get => covered;
set
{
if (value.Length > 4)
throw new ArgumentOutOfRangeException();

covered = value;
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
}*/
    }
}
