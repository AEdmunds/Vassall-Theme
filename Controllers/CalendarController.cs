using System.Web.Mvc;

namespace Controllers {
    public class CalendarController : Controller{

        
        public JsonResult Index(string mes, string ano) {

            var results = new {
                items = new dynamic[] {
                    new {
                        date = string.Format("27/{0}/{1}",mes, ano),
                        title = "Getting Contacts Barcelona",
                        link = "http://gettingcontacts.com/events/view/barcelona"
                    },
                    new {
                        date = string.Format("7/{0}/{1}",mes, ano),
                        title = "2º Getting Contacts Alaquás",
                        link = "http://gettingcontacts.com/events/view/alaquas",
                        color = "#3B4",
                        htmlPopup = "contingut popover"
                    },
                    new {
                        date = string.Format("17/{0}/{1}",mes, ano),
                        title ="4º Getting Contacts Barberà",
                        link = "#",
                        color = "#3B4",
                        htmlPopup = "contingut popover"
                    }
                }
            };


            return Json(results,  JsonRequestBehavior.AllowGet);

        }


    }
}