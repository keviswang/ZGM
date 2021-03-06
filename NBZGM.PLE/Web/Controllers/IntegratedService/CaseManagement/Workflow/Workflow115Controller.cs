﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Taizhou.PLE.Common;
using Taizhou.PLE.Model.CaseWorkflowModels;
using Taizhou.PLE.WorkflowLib;
using Web.ViewModels.CaseViewModels;
using Web.Workflows;

namespace Web.Controllers.IntegratedService.CaseManagement.Workflow
{
    public class Workflow115Controller : Controller
    {
        /// <summary>
        /// 当事人意见反馈
        /// </summary>

        public const string THIS_VIEW_PATH = @"~/Views/IntegratedService/CaseManagement/Workflow/Workflow115/";

        [HttpGet]
        public ActionResult Index(string AIID, CaseForm CaseForm)
        {
            ViewBag.CaseForm = CaseForm;
            ViewData["WIID"] = CaseForm.WIID;
            ViewData["AIID"] = AIID;

            ViewModel15 viewModel15 = new ViewModel15
            {
                AIID = AIID,
                WIID = CaseForm.WIID
            };

            return PartialView(THIS_VIEW_PATH + "index.cshtml", viewModel15);
        }

        public ActionResult Commit(ViewModel15 viewModel15)
        {
            CaseWorkflow caseWorkflow = new CaseWorkflow(viewModel15.WIID);
            Activity activity = caseWorkflow.Workflow.Activities[viewModel15.AIID];
            CaseForm caseForm = caseWorkflow.CaseForm;

            caseForm.FinalForm.Form115.ProcessTime = DateTime.Now;
            caseForm.FinalForm.Form115.ProcessUser = SessionManager.User;
            caseForm.FinalForm.Form115.FKNR = viewModel15.FKNR;
            caseForm.FinalForm.Form115.DSRYJ = viewModel15.DSRYJ;

            activity.Submit();

            //短信内容
            string SMStoUserNAme = this.Request.Form["ZBDYNAME"];
            string megContent = SMStoUserNAme + ",您在案件管理子系统中有一条新任务等待处理";
            //电话号码
            string phoneNumber = this.Request.Form["FSDX"];
            //发送短信
            if (!string.IsNullOrWhiteSpace(phoneNumber))
            {
                SMSUtility.SendMessage(phoneNumber, megContent + "[" + SessionManager.User.UserName + "]", DateTime.Now.Ticks);
            }

            return RedirectToAction("PendingCaseList", "GeneralCase");
        }

    }
}
