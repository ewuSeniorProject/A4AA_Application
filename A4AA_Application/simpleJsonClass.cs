using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application
{
    class simpleJsonClass
    {
        String data;
        public simpleJsonClass(String data)
        {
            this.data = data;
        }

        public String toJsonString()
        {
            return "{'data':'" + this.data + "'}";
        }
    }
}
//a comment