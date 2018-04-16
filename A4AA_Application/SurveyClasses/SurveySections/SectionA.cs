using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyTables;

namespace A4AA_Application.SurveyClasses.SurveySections
{
    class SectionA
    {
        private EstablishmentT establishmentT;
        private ConfigurationT configurationT;
        private CategoryT categoryT;
        private UserT userT;

        public EstablishmentT EstablishmentT { get => establishmentT; set => establishmentT = value; }
        public ConfigurationT ConfigurationT { get => configurationT; set => configurationT = value; }
        public CategoryT CategoryT { get => categoryT; set => categoryT = value; }
        public UserT UserT { get => userT; set => userT = value; }
    }
}
