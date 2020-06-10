using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Covid19.Models;

namespace Covid19.Controllers
{
    public class HomeController : Controller
    {
        Covid1920200603125049_dbEntities dbContext = new Covid1920200603125049_dbEntities();
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Return list of country wise total cases
        /// </summary>
        /// <returns></returns>
        public ActionResult GetCountryWiseData()
        {

            List<CountryWiseCases> lstCountry = new List<CountryWiseCases>();
            var CountryWise = dbContext.CountryWiseCases.ToList();

            for (int i = 0; i < CountryWise.Count; i++)
            {
                var Country = new CountryWiseCases();
                Country.ContryName = CountryWise[i].ContryName;
                Country.TotalCasesPercentage = CountryWise[i].TotalCasesPercentage;
                Country.TotalCases = CountryWise[i].TotalCases;

                lstCountry.Add(Country);
            }

            return this.Json(lstCountry, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// Return list of total cases by day
        /// </summary>
        /// <returns></returns>
        public ActionResult GetDayWiseCountryData()
        {
            List<CountryWiseTotalCasesByDay> lstCountry = new List<CountryWiseTotalCasesByDay>();
            var CountryWise = dbContext.CountryWiseTotalCasesByDays.ToList();

            for (int i = 0; i < CountryWise.Count; i++)
            {
                var Country = new CountryWiseTotalCasesByDay();
                Country.CountryName = CountryWise[i].CountryName;
                Country.TotalCases = CountryWise[i].TotalCases;

                lstCountry.Add(Country);
            }

            return this.Json(lstCountry, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// Retunn list of total death by day
        /// </summary>
        /// <returns></returns>
        public ActionResult GetNoOfDeathByDay()
        {
            List<NoofDeathByDay> lstDeath = new List<NoofDeathByDay>();
            var NoofDeath = dbContext.NoofDeathByDays.ToList();

            for (int i = 0; i < NoofDeath.Count; i++)
            {
                var Death = new NoofDeathByDay();
                Death.CountryName = NoofDeath[i].CountryName;
                Death.TotalDeath = NoofDeath[i].TotalDeath;

                lstDeath.Add(Death);
            }

            return this.Json(lstDeath, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// Give the list of daily new cases
        /// </summary>
        /// <returns></returns>
        public ActionResult DailyNewCases()
        {
            List<DailyNewCase> lstNewCase = new List<DailyNewCase>();
            var dailyNewCase = dbContext.DailyNewCases.ToList();

            for (int i = 0; i < dailyNewCase.Count; i++)
            {
                var newCase = new DailyNewCase();
                newCase.Date = dailyNewCase[i].Date;
                newCase.NewCase = dailyNewCase[i].NewCase;

                lstNewCase.Add(newCase);
            }

            return this.Json(lstNewCase, JsonRequestBehavior.AllowGet);
        }
    }
}