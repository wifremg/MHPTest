using System;
using System.Collections.Generic;

namespace MHPTest.Models
{
    public class FormClass            // Main class
    {
         
        public FormClass()            // Constructor
        {
            this.Text = new List<String>();
            this.Error_Message = "Polish Reverse Notation Calculator";
            this.Operation = "";
        }

        public String Operation       // String that the user inserts
        {
            get;
            set;
        }

        public List<String> Text     // List of texts to be printed on screen
        {
            get;
            set;
        }

        public String Error_Message  // Feedback Message
        {
            get;
            set;
        }
    }
}
