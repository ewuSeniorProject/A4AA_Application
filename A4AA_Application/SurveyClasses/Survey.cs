using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveySections;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using System.Reflection;

namespace A4AA_Application.SurveyClasses
{
    public class Survey
    {
        public Survey()
        {
            sectionA = new SectionA();
            sectionB = new SectionB();
            sectionC = new SectionC();
            sectionD = new SectionD();
            sectionE = new SectionE();
            sectionF = new SectionF();
            sectionG = new SectionG();
            sectionH = new SectionH();
            sectionI = new SectionI();
            sectionJ = new SectionJ();
			DB = new DatabaseCommunication();
        }

        private SectionA SectionA;
        private SectionB SectionB;
        private SectionC SectionC;
        private SectionD SectionD;
        private SectionE SectionE;
        private SectionF SectionF;
        private SectionG SectionG;
        private SectionH SectionH;
        private SectionI SectionI;
        private SectionJ SectionJ;
		private DatabaseCommunication DB;

        public SectionA sectionA { get => SectionA; set => SectionA = value; }
        public SectionB sectionB { get => SectionB; set => SectionB = value; }
        public SectionC sectionC { get => SectionC; set => SectionC = value; }
        public SectionD sectionD { get => SectionD; set => SectionD = value; }
        public SectionE sectionE { get => SectionE; set => SectionE = value; }
        public SectionF sectionF { get => SectionF; set => SectionF = value; }
        public SectionG sectionG { get => SectionG; set => SectionG = value; }
        public SectionH sectionH { get => SectionH; set => SectionH = value; }
        public SectionI sectionI { get => SectionI; set => SectionI = value; }
        public SectionJ sectionJ { get => SectionJ; set => SectionJ = value; }


		/*This method creates the Json string for each of the sections*/
		public Task<HttpResponseMessage> AddTablesToDB()
		{

			SetAllSectionAnswers();

			string json = JsonConvert.SerializeObject(this);//Looks at each of the public fields in this object and converts them to Json

			var content = new StringContent(json, Encoding.UTF8, "application/json");//sends to DB

			return DB.Client.PostAsync(DB.Path, content);//gets response message

		}

		/*This method goes through and calls all of the set answer methods in each of the sections,
		 this takes all of the answers from the text boxes and sets them as the values in each of the corresponding classes*/
		private void SetAllSectionAnswers()
		{
			PropertyInfo[] properties = typeof(Survey).GetProperties();
			//PropertyInfo[] properties2 = typeof(SectionC3).GetProperties();
			for (int i = 0; i < properties.Length; i++)
			{
				Section s = (Section)properties[i].GetValue(this);
				s.SetAnswers();
			}
		}
	}

	
}