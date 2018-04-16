using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyTables;

namespace A4AA_Application.SurveyClasses.SurveySections
{
    class SectionB
    {
        private ParkingT parkingT;
        private Route_From_ParkingT route_From_ParkingT;
        private STA_BusT sTA_BusT;
        private Passenger_LoadingT passenger_LoadingT;
        private STA_RouteT sTA_RouteT;

        public ParkingT ParkingT { get => parkingT; set => parkingT = value; }
        public Route_From_ParkingT Route_From_ParkingT { get => route_From_ParkingT; set => route_From_ParkingT = value; }
        public STA_BusT STA_BusT { get => sTA_BusT; set => sTA_BusT = value; }
        public Passenger_LoadingT Passenger_LoadingT { get => passenger_LoadingT; set => passenger_LoadingT = value; }
        public STA_RouteT STA_RouteT { get => sTA_RouteT; set => sTA_RouteT = value; }
    }
}
