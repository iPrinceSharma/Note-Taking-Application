using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NotemakingApplication.Controllers
{
    [RoutePrefix("group")]
    public class GroupController : Controller
    {
        // GET: Group
        public ActionResult Index()
        {
            return View();
        }

        [Route("groupbyid")]
        public string GetGroupbyId(int id)
        {
            return "Create By id";
        }

        [Route("create")]
        public string CreateGroup()
        {
            return "Create";
        }

        [Route("update")]
        public string UpdateGroup(int id)
        {
            return "Create";
        }

        [Route("delete")]
        public string DeleteGroup(int id)
        {
            return "Create";
        }
    }
}