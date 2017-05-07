using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;

namespace unitedhyd5
{
    public partial class BasePage : System.Web.UI.Page
    {
            
        protected override void InitializeCulture()
        {
            if (!string.IsNullOrEmpty(Request["lang"]))
            {

                Session["lang"] = Request["lang"];
            }
            string lang = Convert.ToString(Session["lang"]);
            string culture = string.Empty;
            /* // In case, if you want to set vietnamese as default language, then removing this comment
            if(lang.ToLower().CompareTo("vi") == 0 ||string.IsNullOrEmpty(culture))
            {               
				culture = "vi-VN";
            }
             */
            if (lang.ToLower().CompareTo("en") == 0 || string.IsNullOrEmpty(culture))
            {
                culture = "en-US";
            }
            if (lang.ToLower().CompareTo("ch") == 0)
            {
                culture = "mn-MN";
            }
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(culture);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);

            base.InitializeCulture();
        }
    }
}

