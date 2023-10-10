using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using self_blog.Models;
using self_blog.Models.Post;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace self_blog.Controllers
{
    public class PostController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ResponseModel Create([FromBody] Post post)
        {
            var rs = new ResponseModel();
            return rs.Ok();
        }



        public IActionResult Modify()
        {
            return View();
        }

        [HttpPost]
        public ResponseModel Modify([FromBody] Post post)
        {
            var rs = new ResponseModel();
            return rs.Ok();
        }
    }
}

