using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyQuestions;

namespace A4AA_Application.SurveyClasses.SurveyTables
{
    public class STA_RouteT
    {
        private Question sta_Rou_Rou_Num = new STA_Rou_Rou_Num();
        private Question sta_Rou_Nor_Bou_Sto = new STA_Rou_Nor_Bou_Sto();
        private Question sta_Rou_Sou_Bou_Sto = new STA_Rou_Sou_Bou_Sto();
        private Question sta_Rou_Eas_Bou_Sto = new STA_Rou_Eas_Bou_Sto();
        private Question sta_Rou_Wes_Bou_Sto = new STA_Rou_Wes_Bou_Sto();

        public Question Sta_Rou_Rou_Num { get => sta_Rou_Rou_Num; set => sta_Rou_Rou_Num = value; }
        public Question Sta_Rou_Nor_Bou_Sto { get => sta_Rou_Nor_Bou_Sto; set => sta_Rou_Nor_Bou_Sto = value; }
        public Question Sta_Rou_Sou_Bou_Sto { get => sta_Rou_Sou_Bou_Sto; set => sta_Rou_Sou_Bou_Sto = value; }
        public Question Sta_Rou_Eas_Bou_Sto { get => sta_Rou_Eas_Bou_Sto; set => sta_Rou_Eas_Bou_Sto = value; }
        public Question Sta_Rou_Wes_Bou_Sto { get => sta_Rou_Wes_Bou_Sto; set => sta_Rou_Wes_Bou_Sto = value; }
        /*private int route_num;
private int north_bound_stop;
private int south_bound_stop;
private int east_bound_stop;
private int west_bound_stop;


public int Route_num
{
get => route_num;
set
{
route_num = value;
}
}
public int North_bound_stop
{
get => north_bound_stop;
set
{
north_bound_stop = value;
}
}
public int South_bound_stop
{
get => south_bound_stop;
set
{
south_bound_stop = value;
}
}
public int East_bound_stop
{
get => east_bound_stop;
set
{
east_bound_stop = value;
}
}
public int West_bound_stop
{
get => west_bound_stop;
set
{
west_bound_stop = value;
}
}*/
    }
}
