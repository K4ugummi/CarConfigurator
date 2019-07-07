using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarConfigurator.Models;
using CarConfigurator.ViewModels;

namespace CarConfigurator.Controllers
{
    public class CarConfiguratorController : Controller
    {
        private CarConfiguratorDbContext _context;

        // Constructor to initialize the DBContext.
        public CarConfiguratorController()
        {
            _context = new CarConfiguratorDbContext();
        }

        // Disposes the DBContext created in the constructor.
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // A configurator index page from which a car to configure can be chosen.
        public ActionResult Index()
        {
            var cars = _context.Cars.ToList();
            return View(cars);
        }

        // Main Configurator page where users can configure the car of their dreams.
        // Input:
        // - (int) id: Car Id from DBContext
        public ActionResult Build(int id = 0)
        {
            var car = _context.Cars.SingleOrDefault(c => c.Id == id);

            if (car == null)
            {
                return HttpNotFound();
            }

            var engines = _context.Engines.ToList();
            var paints = _context.Paints.ToList();
            var rims = _context.Rims.ToList();
            var extras = _context.Extras.ToList();

            var carConfiguration = new CarConfiguration
            {
                CarID = car.Id,
            };

            var configViewModel = new CarConfigViewModel
            {
                Car = car,
                Engines = engines,
                Paints = paints,
                Rims = rims,
                Extras = extras,

                CarConfiguration = carConfiguration,
            };

            return View(configViewModel);
        }

        // Load a stored car configuration by its guid and display the configured result
        // Input:
        // - (Guid) guid: Unique identifier for each stored car configuration
        public ActionResult Load(Guid guid)
        {
            var configuration = _context.CarConfigurations.SingleOrDefault(c => c.Guid == guid);

            if (configuration == null)
            {
                return HttpNotFound();
            }

            // This is super ugly
            var extras = new List<Extra>();
            if (configuration.Extra1 > 0)
            {
                extras.Add(_context.Extras.Single(c => c.Id == configuration.Extra1));
            }
            if (configuration.Extra2 > 0)
            {
                extras.Add(_context.Extras.Single(c => c.Id == configuration.Extra2));
            }
            if (configuration.Extra3 > 0)
            {
                extras.Add(_context.Extras.Single(c => c.Id == configuration.Extra3));
            }
            if (configuration.Extra4 > 0)
            {
                extras.Add(_context.Extras.Single(c => c.Id == configuration.Extra4));
            }
            if (configuration.Extra5 > 0)
            {
                extras.Add(_context.Extras.Single(c => c.Id == configuration.Extra5));
            }

            var carViewModel = new LoadConfigurationViewModel
            {
                Guid = configuration.Guid,
                Car = _context.Cars.Single(c => c.Id == configuration.CarID),
                Engine = _context.Engines.Single(c => c.Id == configuration.EngineID),
                Paint = _context.Paints.Single(c => c.Id == configuration.PaintID),
                Rims = _context.Rims.Single(c => c.Id == configuration.RimID),
                Extras = extras,
            };

            return View(carViewModel);
        }

        // Create a Guid and store the ordered car configuration
        // Input:
        // - carConfiguration: JSON formatted data send from the view via ajax
        [HttpPost]
        public ActionResult Create(CarConfiguration carConfiguration)
        {
            var guid = Guid.NewGuid();
            
            carConfiguration.Guid = guid;

            _context.CarConfigurations.Add(carConfiguration);
            _context.SaveChanges();

            var successurl = Url.Action("Load", "CarConfigurator", new { guid = guid });
            return Json(new { redirecturl = successurl });

            //return RedirectToAction("Load", new { guid = guid });
        }
    }
}