using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyTables
{
    class STA_RouteT
    {
        private int route_num;
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
        }
    }
}
