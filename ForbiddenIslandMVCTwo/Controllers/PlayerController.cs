using ForbiddenIslandMVCTwo.Context;
using ForbiddenIslandMVCTwo.Factory;
using ForbiddenIslandMVCTwo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ForbiddenIslandMVCTwo.Controllers
{
    public class PlayerController : Controller
    {
        //
        // GET: /Player/

        public ActionResult Index()
        {
            var players = new PlayerListFactory().Create();
            return View(players);
        }

        public ActionResult AllPlayer()
        {
            using (var context = new ForbiddenIslandContext())
            {
                var players = context.Players.ToList();
                return View(players);
            }
        }

        //
        // GET: /Player/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Player/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Player/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

     
        /// <summary>
        /// Load the player of the passed in id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Edit(Guid id)
        {
            using (var context = new ForbiddenIslandContext())
            {
                var players = context.Players.Single(x => x.Id == id);
                return View(players);
            }
        }

        /// <summary>
        /// Save the player that has been passed in
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Edit(Player player)
        {
            using (var context = new ForbiddenIslandContext())
            {
                context.Entry(player).State = EntityState.Modified;
                context.SaveChanges();
                return View(player);
            }
        }

        //
        // GET: /Player/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Player/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
