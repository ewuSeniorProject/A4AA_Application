using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyQuestions.SectionE
{
    class Is_elevator : YesNoQuestion
    {
		public Is_elevator() : base("Is there at least one ELEVATOR or lift? If ‘N/A’ (i.e. single level building) skip to next section.") { }
    }
}
