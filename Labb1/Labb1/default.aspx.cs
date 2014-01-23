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
            boxWithText.Enabled = false;
            int counter = 0;
            var content = boxWithText.Text;

            for (var i = 0; i < content.Length; i++ )
            {
                var letterChecker = content[i];
                if (letterChecker == char.ToUpper(letterChecker)) // om letterChecker är samma som när letterChecker har stor bokstav...
                {
                    counter++;
                }
            }

            outputData.Text = counter.ToString();

        }
    }
}