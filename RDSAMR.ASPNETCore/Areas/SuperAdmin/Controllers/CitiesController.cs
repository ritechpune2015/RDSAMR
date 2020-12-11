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

    [UserAuth]
    [Area("SuperAdmin")]
    public class CitiesController : Controller
    {
        IStateService statesvr;
        ICityService citysvr;
        IMapper map;
        public CitiesController(IStateService stemp,IMapper mtemp,ICityService ctemp)
        {
            this.statesvr = stemp;
            this.map = mtemp;
            this.citysvr = ctemp;
        }
        public IActionResult Index()
        {
            return View(this.citysvr.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.StateID = new SelectList(this.statesvr.GetAll(), "StateID", "StateName");
            return View();
        }

        [HttpPost]
        public IActionResult Create(CityVM rec)
        {
            //check for country name already exists 
            if (ModelState.IsValid)
            {
                if (!this.citysvr.GetAll().Any(p => p.CityName.ToLower() == rec.CityName.ToLower()))
                {
                    this.citysvr.Add(rec, 1);
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "City Name Already Exists!");
                }
            }

            ViewBag.StateID = new SelectList(this.statesvr.GetAll(), "StateID", "StateName");
            return View(rec);
        }

        [HttpGet]
        public IActionResult Details(Int64 id)
        {
            var rec = this.citysvr.GetByID(id);
            return View(rec);
        }



        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            var rec = this.citysvr.GetByID(id);
            ViewBag.StateID = new SelectList(this.statesvr.GetAll(), "StateID", "StateName");
            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(CityVM rec)
        {
            if (ModelState.IsValid)
            {
                if (!this.citysvr.GetAll().Any(p => p.CityName.ToLower() == rec.CityName.ToLower() && p.CityID != rec.CityID))
                {
                    this.citysvr.Update(rec, 1);
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "City Name Already Exists!");
                }

            }

            ViewBag.CountryID = new SelectList(this.statesvr.GetAll(), "StateID", "StateName");
            return View(rec);
        }

        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            //   rec.IsDeleted = true;
            this.citysvr.Delete(id, 1);
            return RedirectToAction("Index");
        }
    }
}
