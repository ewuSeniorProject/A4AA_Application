using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyQuestions;

namespace A4AA_Application.SurveyClasses.SurveyTables
{
    public class Passenger_LoadingT
    {
        private Question pas_Loa_Des_Zon = new Pas_Loa_Des_Zon();
        private Question pas_Loa_Dis = new Pas_Loa_Dis();
        private Question pas_Loa_Min_Wid = new Pas_Loa_Min_Wid();
        private Question pas_Loa_Pas_Sur = new Pas_Loa_Pas_Sur();
        private Question pas_Loa_Tac_War_Str = new Pas_Loa_Tac_War_Str();
        private Question pas_Loa_Cur_Cut = new Pas_Loa_Cur_Cut();
        private Question pas_Loa_Cov = new Pas_Loa_Cov();
        private Question pas_Loa_Lig = new Pas_Loa_Lig();
        private Question pas_Loa_Lig_Opt = new Pas_Loa_Lig_Opt();
        private Question pas_Loa_Lig_Typ = new Pas_Loa_Lig_Typ();
        private Question pas_Loa_Com = new Pas_Loa_Com();
        private Question pas_Loa_Rec = new Pas_Loa_Rec();

        public Question Pas_Loa_Des_Zon { get => pas_Loa_Des_Zon; set => pas_Loa_Des_Zon = value; }
        public Question Pas_Loa_Dis { get => pas_Loa_Dis; set => pas_Loa_Dis = value; }
        public Question Pas_Loa_Min_Wid { get => pas_Loa_Min_Wid; set => pas_Loa_Min_Wid = value; }
        public Question Pas_Loa_Pas_Sur { get => pas_Loa_Pas_Sur; set => pas_Loa_Pas_Sur = value; }
        public Question Pas_Loa_Tac_War_Str { get => pas_Loa_Tac_War_Str; set => pas_Loa_Tac_War_Str = value; }
        public Question Pas_Loa_Cur_Cut { get => pas_Loa_Cur_Cut; set => pas_Loa_Cur_Cut = value; }
        public Question Pas_Loa_Cov { get => pas_Loa_Cov; set => pas_Loa_Cov = value; }
        public Question Pas_Loa_Lig { get => pas_Loa_Lig; set => pas_Loa_Lig = value; }
        public Question Pas_Loa_Lig_Opt { get => pas_Loa_Lig_Opt; set => pas_Loa_Lig_Opt = value; }
        public Question Pas_Loa_Lig_Typ { get => pas_Loa_Lig_Typ; set => pas_Loa_Lig_Typ = value; }
        public Question Pas_Loa_Com { get => pas_Loa_Com; set => pas_Loa_Com = value; }
        public Question Pas_Loa_Rec { get => pas_Loa_Rec; set => pas_Loa_Rec = value; }
        /*const double LARGEST_VALUE_ACCEPTED = 99999.99;
const int NUM_DIGITS_AFTER_DECIMAL = 2;

private string designated_zone;
private double distance;
private string min_width;
private string passenger_surface;
private string tactile_warning_strips;
private string covered;
private string lighting;
private string lighting_option;
private string lighting_type;
private string comment;
private string recommendations;

public string Designated_zone
{
get => designated_zone;
set
{
if (value.Length > 4)
throw new ArgumentOutOfRangeException();

designated_zone = value;
}
}
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
public string Passenger_surface
{
get => passenger_surface;
set
{
if (value.Length > 255)
throw new ArgumentOutOfRangeException();

passenger_surface = value;
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
