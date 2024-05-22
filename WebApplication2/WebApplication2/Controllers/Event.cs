using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class EventController : Controller
    {
        public static List<EventModel> events = new List<EventModel>()
        {
            new EventModel() {Id=1,Ime="Sara",Lokacija="Skopje"},
            new EventModel(){Id=2,Ime="Mila",Lokacija="Rim"},
        };
        // GET: Event
        public ActionResult Index()
        {
            return View(events);
        }
        public ActionResult NewEvent()
        {
            EventModel model = new EventModel();
            return View(model);
        }
        [HttpPost]
        public ActionResult InsertNewEvent(EventModel model)
        {
            if (events == null)
            {
                model.Id = 1;
            }
            else
            {
                model.Id = events.Max(e => e.Id) + 1;
            }
            events.Add(model);
            return View("Index", events);
        }
        public ActionResult DeleteEvent(int id)
        {
            var eventToDelete = events.FirstOrDefault(e => e.Id == id);
            if (eventToDelete != null)
            {
                events.Remove(eventToDelete);
            }
            return RedirectToAction("Index");
        }
        public ActionResult EditEvent(int id)
        {
            var model = events.FirstOrDefault(e => e.Id == id);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }


        [HttpPost]
        public ActionResult EditEvent(EventModel model)
        {
            if (ModelState.IsValid == false)
            {
                return View("Index", model);
            }
            var forUpdate = events.FirstOrDefault(e=>e.Id==model.Id);
            forUpdate.Lokacija = model.Lokacija;
            forUpdate.Ime = model.Ime;
            return View("Index", events);
        }
    }
}