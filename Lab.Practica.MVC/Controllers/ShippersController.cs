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
    public class ShippersController : Controller
    {
        // GET: Shippers
        ShippersLogic shippersLogic = new ShippersLogic();
        public ActionResult Index()
        {
            List<Shippers> shippers = shippersLogic.GetAll();
            List<ShippersView> shippersViews = shippers.Select(s => new ShippersView
            {
                ShipperID = s.ShipperID,
                CompanyName = s.CompanyName,
                Phone = s.Phone
            }).ToList();

            return View(shippersViews);
        }
        public ActionResult Insert()
        {
            ViewBag.Message = "Insert";
            return View("Insert");
        }
        [HttpPost]
        public ActionResult Insert(ShippersView shippersView)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Shippers shippersEntity = new Shippers
                    {
                        ShipperID = shippersView.ShipperID,
                        CompanyName = shippersView.CompanyName,
                        Phone = shippersView.Phone
                    };
                    shippersLogic.Add(shippersEntity);
                    return RedirectToAction("Index");
                }
                return View(shippersView);
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
                shippersLogic.Delete(id);
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
                Shippers shippersEntity = shippersLogic.GetOne(id);
                ShippersView shippersView = new ShippersView
                {
                    ShipperID = shippersEntity.ShipperID,
                    CompanyName = shippersEntity.CompanyName,
                    Phone = shippersEntity.Phone
                };
                ViewBag.Message = "Edit";
                return View("Insert",shippersView);               
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return RedirectToAction("Index", "Error");
            }
        }
        [HttpPost]
        public ActionResult Edit(ShippersView shippersView)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Shippers shippersEntity = new Shippers
                    {
                        ShipperID = shippersView.ShipperID,
                        CompanyName = shippersView.CompanyName,
                        Phone = shippersView.Phone
                    };
                    shippersLogic.Update(shippersEntity);
                    return RedirectToAction("Index");
                }
                return View(shippersView);
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return RedirectToAction("Index", "Error");
            }
        }
    }
}