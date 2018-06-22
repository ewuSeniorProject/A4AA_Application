using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyQuestions;

namespace A4AA_Application.SurveyClasses.SurveyTables
{
    public class UserT
    {
        private Question use_Fna = new Use_Fna();
        private Question use_Lna = new Use_Lna();
        private Question use_Pas = new Use_Pas();
        private Question use_Act = new Use_Act();
        private Question use_Use_Rol = new Use_Use_Rol();

        public Question Use_Fna { get => use_Fna; set => use_Fna = value; }
        public Question Use_Lna { get => use_Lna; set => use_Lna = value; }
        public Question Use_Pas { get => use_Pas; set => use_Pas = value; }
        public Question Use_Act { get => use_Act; set => use_Act = value; }
        public Question Use_Use_Rol { get => use_Use_Rol; set => use_Use_Rol = value; }
        /*
private string fname;
private string lname;
private string password;
private string active;
private string user_roll;

public string Fname
{
get => fname;
set
{
if (value.Length > 255)
throw new ArgumentOutOfRangeException();

fname = value;
}
}
public string Lname
{
get => lname;
set
{
if (value.Length > 255)
throw new ArgumentOutOfRangeException();

lname = value;
}
}
public string Password
{
get => password;
set
{
if (value.Length > 255)
throw new ArgumentOutOfRangeException();

password = value;
}
}
public string Active
{
get => active;
set
{
if (value.Length > 255)
throw new ArgumentOutOfRangeException();

active = value;
}
}
public string User_roll
{
get => user_roll;
set
{
if (value.Length > 255)
throw new ArgumentOutOfRangeException();

user_roll = value;
}
}*/
    }
}
