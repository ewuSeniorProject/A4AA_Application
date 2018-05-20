using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses;

namespace A4AA_Application.SurveyPages
{
	public class Pages
	{
		private Survey theSurvey;
		public MainSurveyPage mainPg { get; }
		public SurveySectionA A { get; }
		public SurveySectionB B { get; }
		public SurveySectionC C { get; }
		public SurveySectionD D { get; }
		public SurveySectionE E { get; }
		public SurveySectionF F { get; }
		public SurveySectionG G { get; }
		public SurveySectionH H { get; }
		public SurveySectionI I { get; }
		public SurveySectionJ J { get; }

		public Pages(Survey theSurvey)
		{
			this.theSurvey = theSurvey;
			mainPg = new MainSurveyPage(this, theSurvey);
			A = new SurveySectionA(theSurvey);
			B = new SurveySectionB(theSurvey);
			C = new SurveySectionC(theSurvey);
			D = new SurveySectionD(theSurvey);
			E = new SurveySectionE(theSurvey);
			F = new SurveySectionF(theSurvey);
			G = new SurveySectionG(theSurvey);
			H = new SurveySectionH(theSurvey);
			I = new SurveySectionI(theSurvey, this);
			J = new SurveySectionJ(theSurvey);

		}
	}
}
