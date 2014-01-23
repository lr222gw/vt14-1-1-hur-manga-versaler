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

            boxWithText.Enabled = false;
            int counter = 0;
            var content = boxWithText.Text;

            for (var i = 0; i < content.Length; i++ )
            {
                var letterChecker = content[i];
                if (char.IsUpper(letterChecker) && !(char.IsWhiteSpace(letterChecker))) // om letterChecker har stor bokstav och inte är ett mellanrum...
                {
                    counter++;
                }
            }

            outputData.Text = counter.ToString();
            countButton.Text = "Rensa";
            }
            else
            {
                boxWithText.Text = ""; // rensar formuläret
                countButton.Text = "count";
                boxWithText.Enabled = true;
            }
            

        }
    }
}