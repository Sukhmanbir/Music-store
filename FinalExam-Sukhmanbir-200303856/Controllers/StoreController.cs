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

        // GET: /Store/Details/5

        public ActionResult Details(int id = 1)
        {
            Album album = storeDB.Albums.Find(id);

            return View(album);
        }

        // GET: /Store/Genre
        public ActionResult Genre()
        {
            List<Genre> genres = storeDB.Genres.ToList();

            return View(genres);
        }

        // GET: /Store/Album
        public ActionResult Albums()
        {
            List<Album> albums = storeDB.Albums.ToList();

            return View(albums);
        }

        // GET: /Store/Artist
        public ActionResult Artists()
        {
            List<Artist> artists = storeDB.Artists.ToList();

            return View(artists);
        }
    }
}
