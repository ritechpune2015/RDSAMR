using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RDSAMR.Application.Interfaces;
using RDSAMR.Application.ViewModels;
using RDSAMR.ASPNETCore.AuthFilter;

namespace RDSAMR.ASPNETCore.Areas.SuperAdmin.Controllers
{

    [SuperAdminAuth]
    [Area("SuperAdmin")]
    public class StatesController : Controller
    {
        IStateService statesvr;
        ICountryService countrysvr;
        IMapper map;
        public StatesController(IStateService stemp,IMapper mtemp,ICountryService ctemp)
        {
            this.statesvr = stemp;
            this.map = mtemp;
            this.countrysvr = ctemp;
        }
        public IActionResult Index()
        {
            return View(this.statesvr.GetAll());

        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.CountryID = new SelectList(this.countrysvr.GetAll(), "CountryID", "CountryName");
            return View();
        }

        [HttpPost]
        public IActionResult Create(StateVM rec)
        {
            //check for country name already exists 
            if (ModelState.IsValid)
            {
                if (!this.statesvr.GetAll().Any(p => p.StateName.ToLower() == rec.StateName.ToLower()))
                {
                    this.statesvr.Add(rec, 1);
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "State Name Already Exists!");
                }
            }

            ViewBag.CountryID = new SelectList(this.countrysvr.GetAll(), "CountryID", "CountryName");
            return View(rec);
        }

        [HttpGet]
        public IActionResult Details(Int64 id)
        {
            var rec = this.statesvr.GetByID(id);
            return View(rec);
        }



        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            var rec = this.statesvr.GetByID(id);
            ViewBag.CountryID = new SelectList(this.countrysvr.GetAll(), "CountryID", "CountryName");
            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(StateVM rec)
        {
            if (ModelState.IsValid)
            {
                if (!this.statesvr.GetAll().Any(p => p.StateName.ToLower() == rec.StateName.ToLower() && p.StateID != rec.StateID))
                {
                    this.statesvr.Update(rec, 1);
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "State Name Already Exists!");
                }

            }

            ViewBag.CountryID = new SelectList(this.countrysvr.GetAll(), "CountryID", "CountryName");
            return View(rec);
        }

        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            //   rec.IsDeleted = true;
            this.statesvr.Delete(id, 1);
            return RedirectToAction("Index");
        }
    }
}
