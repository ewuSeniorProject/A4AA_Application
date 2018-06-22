using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyQuestions;

namespace A4AA_Application.SurveyClasses.SurveyTables
{
    public class Exterior_PathwaysT
    {
        private Question ext_Pat_Ser_Ani = new Ext_Pat_Ser_Ani();
        private Question ext_Pat_Ser_Ani_Loc = new Ext_Pat_Ser_Ani_Loc();
        private Question ext_Pat_Has_Ext_Pat = new Ext_Pat_Has_Ext_Pat();
        private Question ext_Pat_Min_Wid = new Ext_Pat_Min_Wid();
        private Question ext_Pat_Pat_Sur = new Ext_Pat_Pat_Sur();
        private Question ext_Pat_Pat_Cur = new Ext_Pat_Pat_Cur();
        private Question ext_Pat_Tac_War = new Ext_Pat_Tac_War();
        private Question ext_Pat_Slo = new Ext_Pat_Slo();
        private Question ext_Pat_Lig = new Ext_Pat_Lig();
        private Question ext_Pat_Lig_Opt = new Ext_Pat_Lig_Opt();
        private Question ext_Pat_Lig_Typ = new Ext_Pat_Lig_Typ();
        private Question ext_Pat_Com = new Ext_Pat_Com();
        private Question ext_Pat_Rec = new Ext_Pat_Rec();

        public Question Ext_Pat_Ser_Ani { get => ext_Pat_Ser_Ani; set => ext_Pat_Ser_Ani = value; }
        public Question Ext_Pat_Ser_Ani_Loc { get => ext_Pat_Ser_Ani_Loc; set => ext_Pat_Ser_Ani_Loc = value; }
        public Question Ext_Pat_Has_Ext_Pat { get => ext_Pat_Has_Ext_Pat; set => ext_Pat_Has_Ext_Pat = value; }
        public Question Ext_Pat_Min_Wid { get => ext_Pat_Min_Wid; set => ext_Pat_Min_Wid = value; }
        public Question Ext_Pat_Pat_Sur { get => ext_Pat_Pat_Sur; set => ext_Pat_Pat_Sur = value; }
        public Question Ext_Pat_Pat_Cur { get => ext_Pat_Pat_Cur; set => ext_Pat_Pat_Cur = value; }
        public Question Ext_Pat_Tac_War { get => ext_Pat_Tac_War; set => ext_Pat_Tac_War = value; }
        public Question Ext_Pat_Slo { get => ext_Pat_Slo; set => ext_Pat_Slo = value; }
        public Question Ext_Pat_Lig { get => ext_Pat_Lig; set => ext_Pat_Lig = value; }
        public Question Ext_Pat_Lig_Opt { get => ext_Pat_Lig_Opt; set => ext_Pat_Lig_Opt = value; }
        public Question Ext_Pat_Lig_Typ { get => ext_Pat_Lig_Typ; set => ext_Pat_Lig_Typ = value; }
        public Question Ext_Pat_Com { get => ext_Pat_Com; set => ext_Pat_Com = value; }
        public Question Ext_Pat_Rec { get => ext_Pat_Rec; set => ext_Pat_Rec = value; }
        /*private string service_animal;
private string service_animal_location;
private string has_exterior_path;
private string min_width;
private string pathway_surface;
private string pathway_curbs;
private string tactile_warning;
private string slope;
private string lighting;
private string lighting_option;
private string lighting_type;
private string comment;
private string text;

public string Service_animal
{
get => service_animal;
set
{
if (value.Length > 4)
throw new ArgumentOutOfRangeException();

service_animal = value;
}
}
public string Service_animal_loacation
{
get => service_animal_location;
set
{
if (value.Length > 255)
throw new ArgumentOutOfRangeException();

service_animal_location = value;
}
}
public string Has_exterior_path
{
get => Has_exterior_path;
set
{
if (value.Length > 4)
throw new ArgumentOutOfRangeException();

has_exterior_path = value;
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
public string Pathway_surface
{
get => pathway_surface;
set
{
if (value.Length > 4)
throw new ArgumentOutOfRangeException();

pathway_surface = value;
}
}
public string Pathway_curbs
{
get => pathway_curbs;
set
{
if (value.Length > 4)
throw new ArgumentOutOfRangeException();

pathway_curbs = value;
}
}
public string Tactile_warning
{
get => tactile_warning;
set
{
if (value.Length > 4)
throw new ArgumentOutOfRangeException();

tactile_warning = value;
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
public string Text
{
get => text;
set
{
text = value;
}
}

public string Slope
{
get => slope;
set
{
if (value.Length > 4)
throw new ArgumentOutOfRangeException();

slope = value;
}
}*/
    }
}
