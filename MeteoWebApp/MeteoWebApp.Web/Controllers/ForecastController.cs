﻿using MeteoWebApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeteoWebApp.Web.Controllers
{
    [AllowAnonymous]
    public class ForecastController : Controller
    {
        //
        // GET: /Forecast/

        public ActionResult Index(ForecastViewModel model)
        {
            if(model.FirstDate == null || model.FirstDate.Year < 2016)
            {
                model.FirstDate = new DateTimeOffset(DateTime.Now);
            }
            if(model.CityId <= 0)
            {
                model.CityId = 1;
            }

            model.FirstDate = new DateTimeOffset(model.FirstDate.Date, new TimeSpan(0));
            
            return View(model);
        }
    }
}
