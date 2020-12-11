using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RDSAMR.Application.Interfaces;
using RDSAMR.Application.ViewModels;
using RDSAMR.ASPNETCore.AuthFilter;

namespace RDSAMR.ASPNETCore.Areas.SuperAdmin.Controllers
{
    [SuperAdminAuth]
    [Area("SuperAdmin")]
    public class CountriesController : Controller
    {
        ICountryService countrysvr;

        public CountriesController(ICountryService ctemp)
        {
            this.countrysvr = ctemp;
        }
        public IActionResult Index()
        {
            return View(this.countrysvr.GetAll());
            
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CountryVM rec)
        {
            //check for country name already exists 
            if (ModelState.IsValid)
            {
                try
                {
                    if (!this.countrysvr.GetAll().Any(p => p.CountryName.ToLower() == rec.CountryName.ToLower()))
                    {
                        this.countrysvr.Add(rec, 1);
                        TempData["Create"] = "Country Created Successfully!";
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Country Name Already Exists!");
                        //return View(rec);
                    }
                }
                catch (Exception ex)
                {
                    TempData["Create"] = "Exception!" + ex.ToString();
                    return View();
                }
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Details(Int64 id)
        {
            var rec = this.countrysvr.GetByID(id);
            return View(rec);
        }



        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            var rec = this.countrysvr.GetByID(id);
            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(CountryVM rec)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (!this.countrysvr.GetAll().Any(p => p.CountryName.ToLower() == rec.CountryName.ToLower() && p.CountryID != rec.CountryID))
                    {
                        this.countrysvr.Update(rec, 1);
                        TempData["Edit"] = "Country Edited Successfully!";
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Country Name Already Exists!");
                    }
                }
                catch (Exception ex)
                {
                    TempData["Edit"] = "Exception!" + ex.ToString();
                    return View();
                }
            }
                return View(rec);
        }

        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            //   rec.IsDeleted = true;
            try
            {
                this.countrysvr.Delete(id, 1);
                TempData["Delete"] = "Country Deleted Successfully!";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["Delete"] = "Exception!" + ex.ToString();
                return View();
            }
        }
    }
}
