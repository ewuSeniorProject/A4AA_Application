using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyTables;
using Newtonsoft.Json;

namespace A4AA_Application.SurveyClasses.SurveySections
{
	public class SectionB : Section
	{
		public SectionB()
		{
			sectionB0 = new SectionB0();
			sectionB1 = new SectionB1();
			sectionB2 = new SectionB2();
			sectionB3 = new SectionB3();
			parkingT = sectionB0.ParkingT;
			route_From_ParkingT = sectionB1.route_From_ParkingT;
			passenger_LoadingT = sectionB2.passenger_LoadingT;
			sTA_BusT = sectionB3.sta_BusT;
			

		}

		private ParkingT parkingT;
		private Route_From_ParkingT route_From_ParkingT;
		private STA_BusT sTA_BusT;
		private Passenger_LoadingT passenger_LoadingT;
		

		public SectionB0 sectionB0 { get; }
		public SectionB1 sectionB1 { get; }
		public SectionB2 sectionB2 { get; }
		public SectionB3 sectionB3 { get; }

		[JsonIgnore]
		public ParkingT ParkingT { get => parkingT; set => parkingT = value; }
		[JsonIgnore]
		public Route_From_ParkingT Route_From_ParkingT { get => route_From_ParkingT; set => route_From_ParkingT = value; }
		[JsonIgnore]
		public STA_BusT STA_BusT { get => sTA_BusT; set => sTA_BusT = value; }
		[JsonIgnore]
		public Passenger_LoadingT Passenger_LoadingT { get => passenger_LoadingT; set => passenger_LoadingT = value; }

		public override void SetAnswers()
		{
			sectionB0.SetAnswers();
			sectionB1.SetAnswers();
			sectionB2.SetAnswers();
			sectionB3.SetAnswers();
			
		}
	}
}
