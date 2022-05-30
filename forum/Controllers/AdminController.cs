using forum.Models;
using Microsoft.AspNetCore.Mvc;

namespace forum.Controllers
{
    public class AdminController : Controller
    {
        ForumContext forumContext;
        public AdminController(ForumContext forumContext)
        {
            this.forumContext = forumContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult CreatePost(Post post)
        {
            return View();
        }

        [HttpDelete]
        public IActionResult DeletePost(Post post)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            try
            {
                bool isCorrect = forumContext.Users.Where(l => l.Login == user.Login).Where(p => p.Password == user.Password).Any();
                if (isCorrect)
                    return Redirect("/admin/index");
                else
                    return View();
            } catch
            {
                return ValidationProblem();
            }
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            try
            {
                user.CreatedDate = DateTime.Now;
                forumContext.Users.Add(user);
                forumContext.SaveChanges();
                return Redirect("/");
            }
            catch
            {
                return ValidationProblem();
            }
        }
    }
}
