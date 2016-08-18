/*    
    File: controllers/StoreController.cs
    Desc: Controller for the viewing genre, album and artist items
    Author: Sukhmanbir Kaur
    Student #: 200303856
    Date Modified: Aug 18, 2016
    History:
        initial commit
        display index page, genre items
        display album and artist items
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalExam_Sukhmanbir_200303856.Models;

namespace FinalExam_Sukhmanbir_200303856.Controllers
{
    public class StoreController : Controller
    {
        MVCMusicStoreContext storeDB = new MVCMusicStoreContext();

        // GET: /Store/
        public ActionResult Index()
        {
            return View();
        }

        // GET: /Store/Genre
        public ActionResult Genre()
        {
            List<Genre> genres = storeDB.Genres.ToList();

            return View(genres);
        }

        // GET: /Store/Album
        public ActionResult Album()
        {
            List<Album> albums = storeDB.Albums.ToList();

            return View(albums);
        }

        // GET: /Store/Artist
        public ActionResult Artist()
        {
            List<Artist> artists = storeDB.Artists.ToList();

            return View(artists);
        }
    }
}
