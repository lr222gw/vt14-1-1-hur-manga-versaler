using Labb1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Labb1
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void countButton_Click(object sender, EventArgs e)
        {
            if (countButton.Text == "count")
            {
                boxWithText.Enabled = false; // stänger av möjligheten att skriva i rutan..

                var content = boxWithText.Text; // hämtar ner data som ska bearbetas i GetNumberOfCapitals metoden..

                int counter = TextAnalyzer.GetNumberOfCapitals(content); // hämtar ner data från funktionen som räknar ut hur många versaler...

                outputData.Text = counter.ToString(); // skriver in antalet versaler till outputData...
                countButton.Text = "Rensa";
            }
            else //återställer allt som det var innan man tryckt på knappen...
            {
                boxWithText.Text = ""; // rensar formuläret
                countButton.Text = "count";
                boxWithText.Enabled = true;
                outputData.Text = "0";
            }
            

        }
    }
}