using forum.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace forum.Controllers
{
    public class HomeController : Controller
    {
        ForumContext forumContext;
        public HomeController(ForumContext forumContext)
        {
            this.forumContext = forumContext;
        }

        public IActionResult Index(int? topic)
        {
            List<Post> content;
            try
            {
                if (topic == null)
                    content = forumContext.Posts.ToList();
                else
                    content = forumContext.Posts.Where(p => p.Id == topic).ToList();
            } catch
            {
                return Redirect("/");
            }
            return View(content);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}