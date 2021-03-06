﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers.IntegratedService.ApprovalManagement.XZSPAttachment
{
    public class XZSPAttachment2Controller : Controller
    {
        //
        // GET: /XZSPAttachment2/

        public const string THIS_VIEW_PATH = @"~/Views/IntegratedService/ApprovalManagement/XZSPAttachment/";
        [HttpGet]
        public ActionResult Index(string WIID, string AIID,
            string ADID, string APID, string WDID,
            string currentActivityName, string WorkflowView)
        {
            ViewBag.WIID = WIID;
            ViewBag.AIID = AIID;
            ViewBag.ADID = ADID;
            ViewBag.APID = APID;
            ViewBag.WDID = WDID;
            ViewBag.currentActivityName = currentActivityName;
            ViewBag.WorkflowView = WorkflowView;

            return View(THIS_VIEW_PATH + "XZSPAttachment2.cshtml");
        }

    }
}
