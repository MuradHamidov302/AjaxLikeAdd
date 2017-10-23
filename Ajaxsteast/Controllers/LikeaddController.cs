using Ajaxsteast.Models;
using System.Linq;
using System.Web.Mvc;

namespace Ajaxsteast.Controllers
{
    public class LikeaddController : Controller
    {
        Ajax1234Entities1 db = new Ajax1234Entities1();


        // GET: Likeadd
        public ActionResult Index()
        {
            return View(db.products.ToList());
        }

        
        public string Likes(int id)
        {
            product prolike = db.products.FirstOrDefault(x => x.id == id);
            prolike.product_like++;
            db.SaveChanges();
            return prolike.product_like.ToString();

        }

      
    }
}