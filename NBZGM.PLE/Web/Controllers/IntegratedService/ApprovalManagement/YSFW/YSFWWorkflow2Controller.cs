﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Taizhou.PLE.Model;
using Taizhou.PLE.BLL.XZSPBLLs;
using Taizhou.PLE.Common.Enums.XZSPEnums;
using Taizhou.PLE.Model.XZSPWorkflowModels.YSFW;
using Taizhou.PLE.Web.Process.XZSPProcess;
using Taizhou.PLE.Model.XZSPWorkflowModels.Base;

namespace Web.Controllers.IntegratedService.ApprovalManagement.YSFW
{
    public class YSFWWorkflow2Controller : Controller
    {
        //预审环节
        // GET: /YSFWWorkflow2/
        public const string THIS_VIEW_PATH = @"~/Views/IntegratedService/ApprovalManagement/YSFW/";

        [HttpGet]
        public ActionResult Index(string WIID, string AIID,string ADID, YSFWForm ysfwForm) 
        {
            ViewBag.WIID = WIID;
            ViewBag.AIID = AIID;
            ViewBag.ADID = ADID;
            ViewBag.ysfwForm = ysfwForm;

            return View(THIS_VIEW_PATH + "YSFWWorkflow2.cshtml");
        }

        public ActionResult Commit(Form102 form102) 
        {

            string wiID = this.Request.Form["WIID"];
            string aiID = this.Request.Form["AIID"];
            string adID = this.Request.Form["ADID"];
            //获取运输服务表单
            YSFWForm _ysfwForm = YSFWProcess.GetYSFWFormByWIID(wiID);
            form102.ID = aiID;
            form102.ADID = decimal.Parse(adID);
            XZSPACTIST instance = ActivityInstanceBLL.Single(aiID);
            form102.ADName = instance.XZSPACTDEF.ADNAME;

            form102.ProcessUserID = SessionManager.User.UserID.ToString();
            form102.ProcessUserName = SessionManager.User.UserName;
            form102.ProcessTime = DateTime.Now;

            TotalForm totalForm = new TotalForm();
            BaseForm baseForm = new BaseForm();

            baseForm.ID = aiID;
            baseForm.ADID = decimal.Parse(adID);
            baseForm.ADName = form102.ADName;
            baseForm.ProcessUserID = form102.ProcessUserID;
            baseForm.ProcessUserName = form102.ProcessUserName;
            baseForm.ProcessTime = form102.ProcessTime;
            totalForm.Form102 = form102;
            totalForm.Form101 = _ysfwForm.FinalForm.Form101;
            totalForm.CurrentForm = baseForm;

            List<TotalForm> totalFromList = new List<TotalForm>();
            totalFromList.Add(totalForm);

            YSFWForm ysfwForm = new YSFWForm()
            {
                WIID = wiID,
                WIName = "",
                WICode = "",
                //UnitID="",
                UnitName = "",
                WDID = instance.XZSPACTDEF.WDID.Value,
                ProcessForms = totalFromList,
                FinalForm = totalForm,
                CreatedTime = form102.ProcessTime.Value
            };

            if (this.Request.Form["bc"] == "1")//保存
            {
                YSFWProcess.Save(wiID, aiID, ysfwForm);
            }
            else//提交
            {
                YSFWProcess.Submit(wiID, aiID, ysfwForm, "", "", "");
            }            

            return RedirectToAction("Approval", "Approval");
        }

        public ActionResult ControlWorkflowForm(YSFWForm ysfwForm) 
        {
            ViewBag.Step = "2";

            return PartialView(THIS_VIEW_PATH + "ControlWorkflowForm.cshtml", ysfwForm);
        }

    }
}
