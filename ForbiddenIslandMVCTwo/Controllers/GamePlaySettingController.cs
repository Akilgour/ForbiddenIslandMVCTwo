using ForbiddenIslandMVCTwo.Context;
using ForbiddenIslandMVCTwo.Enum.Repository.Enums;
using ForbiddenIslandMVCTwo.Factory;
using ForbiddenIslandMVCTwo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ForbiddenIslandMVCTwo.Controllers
{
    public class GamePlaySettingController : Controller
    {
        //
        // GET: /GamePlaySetting/

        public ActionResult Index()
        {
            using (var context = new ForbiddenIslandContext())
            {
                var query = context.GamePlaySettings.Include("FirstMovePlayer").Include("SecondMovePlayer").Include("ThirdMovePlayer").Include("FourthMovePlayer").Include("DrawDeck").Include("IslandTiles");
                return View(query.ToList());
            }
        }

        public ActionResult CreateUsingFactory()
        {

            using (var context = new ForbiddenIslandContext())
            {
                var playerListFactory = new PlayerListFactory();
                var gamePlaySettingsFactory = new GamePlaySettingsFactory();
                var treasureDeckFactory = new TreasureDeckFactory();
                var islandFactory = new IslandFactory();

                var gamePlaySettings = gamePlaySettingsFactory.Create(DifficultyLevel.Normal, playerListFactory, 4, treasureDeckFactory, islandFactory);
                gamePlaySettings.MoveNumber = 1;
                context.GamePlaySettings.Add(gamePlaySettings);
                context.SaveChanges();

                // Place the player here, this will get moved out when there is a create screen
                gamePlaySettingsFactory.PlacePlayersOnStartingTiles(gamePlaySettings);
                context.SaveChanges();

                var query = context.GamePlaySettings.Include("FirstMovePlayer").Include("SecondMovePlayer").Include("ThirdMovePlayer").Include("FourthMovePlayer").Include("DrawDeck").Include("IslandTiles");
                return View("Index", query.ToList());
            }
        }

        //
        // GET: /GamePlaySetting/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /GamePlaySetting/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /GamePlaySetting/Create

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

        //
        // GET: /GamePlaySetting/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /GamePlaySetting/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /GamePlaySetting/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /GamePlaySetting/Delete/5

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
