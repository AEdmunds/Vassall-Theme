using System;
using System.Collections.Generic;
using System.Web.Mvc;


namespace Controllers {
    [ValidateInput(false)]
    public class AccessabilityController : Controller {

        private const string Contrast = "contrast";
       
        private readonly Dictionary<string, string> _colors; 

        public AccessabilityController() {
           _colors = new Dictionary<string, string> {
               {"black", "#000000"}, 
               {"white", "#ffffff"}, 
               {"yellow", "#ffff00"}, 
               {"blue", "#ddddff"}, 
               {"cream", "#ffffdd"}, 
               {"pink", "#ffdddd"}
           };
        }


        [HttpPost]
        public ActionResult SetTextSize(string submitButton) {
            
            var emsize = Session["TextSize"] == null ? new decimal(0.8) : decimal.Parse(Session["TextSize"].ToString());

            const decimal max = (decimal)1.7;
            const decimal min = (decimal)0.6;

            if ((submitButton == "increase-text") || (submitButton == "text"))
            {
                if(emsize < max)
                    emsize += new decimal(0.1);
            }
            else {
                if(emsize > min)
                    emsize -= new decimal(0.1);
            }

            SetSession("TextSize", emsize);
           
            if (Request.IsAjaxRequest()) {
                return Json(new {success = true, message = "", emsize=emsize});
            }
            else {
                if (Request.Url != null) {
                    return Redirect(Request.Url.AbsolutePath);
                }
                else {
                    return Redirect(Url.Content("~"));
                }
            }

        }


        [HttpPost]
        public ActionResult CycleContrast(string submitButton) {

            if (submitButton == "contrast") {
                return Redirect(Url.Content(@"~/accessibility/web-site"));
            }

            var contratsArray = new List<string> {
                "black-on-white",
                "black-on-yellow",
                "black-on-blue",
                "black-on-pink",
                "black-on-cream",
                "white-on-black",
                "yellow-on-black",
                "reset-contrast",
            };

            var currentContrast = (string)Session[Contrast];
            if (string.IsNullOrEmpty(currentContrast) || currentContrast == contratsArray[contratsArray.Count - 1]) {
                return SetContrast(contratsArray[0]);
            }
            else {
                var newcontrast = contratsArray.FindIndex(x => x == currentContrast) + 1;
                return SetContrast(contratsArray[newcontrast]);

            }
            
        }





        [HttpPost]
        public ActionResult SetContrast(string submitButton) {

            var logo = Url.Content(@"~/themes/bizStrap.1.3/content/img/vassall-logo.png");
            var message = "reset";
            var color = new[] { "black", "white" };

            if (submitButton == "reset-contrast") {
                Session.Remove(Contrast);
            }
            else {

                SetSession(Contrast, submitButton);
                message = "change";
                color = submitButton.Replace("-on-", "-").Split('-');

                if (submitButton.StartsWith("black"))
                {
                    logo = Url.Content(@"~/themes/bizStrap.1.3/content/img/vassall-logo-bw.gif");
                }
            }

            SetSession("Logo", logo);

            if (Request.IsAjaxRequest()) {
                return Json(new {
                    success = true,
                    message = message,
                    logo = logo,
                    forecolor = _colors[color[0]] ,
                    backcolor = _colors[color[1]]
                }, JsonRequestBehavior.AllowGet);
            }
            else {
                // reload the page with the correct style sheet. 
                return Redirect(Url.Content(@"~/accessibility/web-site"));
            }


        }

        


        private void SetSession(string name, object value) {
            // set session
            if (Session[name] == null)
            {
                Session.Add(name, value);
            }
            else {
                Session[name] = value;
            }

        }

    }
}