using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace unitedhyd5
{
    public partial class Default1 : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            #region--Show/hide language link
            if (!string.IsNullOrEmpty(Convert.ToString(Session["lang"])))
            {
                if (Convert.ToString(Session["lang"]) == "en")
                {
              //      linkMandarinLang.Visible = true;
                //    linkEnglishLang.Visible = false;
                }
                else
                {
                  //  linkEnglishLang.Visible = true;
                  //  linkMandarinLang.Visible = false;
                }
            }
            else
            {
                //linkMandarinLang.Visible = false;
                //linkEnglishLang.Visible = true;
            }
            #endregion--
        }
    }

}