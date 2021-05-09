using Lab.Practica.Entities;
using Lab.Practica.Logic;
using Lab.Practica.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab.Practica.MVC.Controllers
{
    public class TerritoriesController : Controller
    {
        // GET: Territories
        TerritoriesLogic territoriesLogic = new TerritoriesLogic();
        public ActionResult Index()
        {
            List<Territories> territories = territoriesLogic.GetAll();
            List<TerritoriesView> territoriesViews = territories.Select(t => new TerritoriesView
            {
                TerritoryID = t.TerritoryID,
                TerritoryDescription = t.TerritoryDescription,
                RegionID = t.RegionID
            }).ToList();

            return View(territoriesViews);
        }
        public ActionResult Insert()
        {
            ViewBag.Message = "Insert";
            return View("Insert");
        }
        [HttpPost]
        public ActionResult Insert(TerritoriesView territoriesView)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Territories territoriesEntity = new Territories
                    {
                        TerritoryID = territoriesView.TerritoryID,
                        TerritoryDescription = territoriesView.TerritoryDescription,
                        RegionID = territoriesView.RegionID                        
                    };
                    territoriesLogic.Add(territoriesEntity);
                    return RedirectToAction("Index");
                }
                return View(territoriesView);
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return RedirectToAction("Index", "Error");
            }

        }
        public ActionResult Delete(int id)
        {
            try
            {
                territoriesLogic.Delete(id);
                return RedirectToAction("Index");

            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return RedirectToAction("Index", "Error");
            }
        }
        public ActionResult Edit(int id)
        {
            try
            {
                Territories territoriesEntity = territoriesLogic.GetOne(id);
                TerritoriesView territoriesView = new TerritoriesView
                {
                   TerritoryID = territoriesEntity.TerritoryID,
                    TerritoryDescription = territoriesEntity.TerritoryDescription,
                    RegionID = territoriesEntity.RegionID
                };
                ViewBag.Message = "Edit";
                return View("Insert", territoriesView);
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return RedirectToAction("Index", "Error");
            }
        }
        [HttpPost]
        public ActionResult Edit(TerritoriesView territoriesView)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Territories territoriesEntity = new Territories
                    {
                        TerritoryID = territoriesView.TerritoryID,
                        TerritoryDescription = territoriesView.TerritoryDescription,
                        RegionID = territoriesView.RegionID
                    };
                    territoriesLogic.Update(territoriesEntity);
                    return RedirectToAction("Index");
                }
                return View(territoriesView);
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return RedirectToAction("Index", "Error");
            }
        }
    }
}