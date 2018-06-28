using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web_esm.Models;

namespace web_esm.Controllers
{
    public class EseController : Controller
    {
		FilterSessionModels chk = new FilterSessionModels();

		// GET: Ese SENDER ESE 정보 관리
		public ActionResult EseInfo(string searchString, string msg)
        {
			//권한 체크===================================================
			if (!chk.chkPermission("EseInfo", "PER_SELECT"))
				return RedirectToAction("Index", "Home", new { msg = chk.alertStr });
			//===========================================================

			TempData["PublicMsg"] = null;
			if (!string.IsNullOrEmpty(msg))
				TempData["PublicMsg"] = msg;

			return View();
        }
    }
}