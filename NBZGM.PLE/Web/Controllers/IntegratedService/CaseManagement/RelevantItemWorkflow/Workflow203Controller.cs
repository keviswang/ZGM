﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Taizhou.PLE.BLL.CaseBLLs;
using Taizhou.PLE.BLL.CaseBLLs.DocBuildBLLs;
using Taizhou.PLE.BLL.WorkFlowBLLs;
using Taizhou.PLE.Common;
using Taizhou.PLE.Common.Enums.CaseEnums;
using Taizhou.PLE.Model;
using Taizhou.PLE.Model.CaseDocModels;
using Taizhou.PLE.Model.RelevantItemWorkflowModels;
using Taizhou.PLE.Model.CaseWorkflowModels;
using Taizhou.PLE.WorkflowLib;
using Web.ViewModels.RelevantItemViewModels;
using Web.Workflows;

namespace Web.Controllers.IntegratedService.CaseManagement.RelevantItem
{
    public class Workflow203Controller : Controller
    {
        public const string THIS_VIEW_PATH =
 @"~/Views/IntegratedService/CaseManagement/RelevantItemWorkflow/Workflow203/";

        [HttpGet]
        public ActionResult Index(CaseForm CaseForm, RelevantItemForm RelevantItemForm)
        {
            ViewBag.CaseForm = CaseForm;
            ViewBag.RelevantItemForm = RelevantItemForm;

            return PartialView(THIS_VIEW_PATH + "Index.cshtml", new ViewModel203
            {
                ParentWIID = CaseForm.WIID,
                ParentAIID = CaseForm.FinalForm.CurrentForm.ID,
                WIID = RelevantItemForm.WIID,
                AIID = RelevantItemForm.RelevantItemForm3.ID,
                AJBH = CaseForm.WICode
            });
        }

        [HttpPost]
        public ActionResult Commit(ViewModel203 vm)
        {
            {
                RelevantItemWorkflow relevantItemWorkflow = new
                    RelevantItemWorkflow(vm.ParentWIID, vm.WIID);
                RelevantItemForm relevantItemForm = relevantItemWorkflow.RelevantItemForm;

                CaseForm caseForm = relevantItemWorkflow.ParentWorkflow.CaseForm;
                //一般案件流程活动标识
                string parentAIID = caseForm.FinalForm.CurrentForm.ID;
                //一般案件流程活动定义标识
                decimal parentADID = caseForm.FinalForm.CurrentForm.ADID;

                string aiid = relevantItemForm.RelevantItemForm3.ID;
                Activity activity = relevantItemWorkflow.Workflow.Activities[aiid];
                relevantItemForm.RelevantItemForm3.XZJGFZRSPYJ = vm.XZJGFZRSPYJ;
                relevantItemForm.RelevantItemForm3.ProcessUser = SessionManager.User;
                relevantItemForm.RelevantItemForm3.ProcessTime = DateTime.Now;
                activity.Submit();

                QTSXNBSPB qtsxnbspb = new QTSXNBSPB();
                qtsxnbspb.SQSX = relevantItemForm.RelevantItemForm1.SQSX;
                qtsxnbspb.WSBH = relevantItemForm.RelevantItemForm1.WSBH;
                qtsxnbspb.AY = relevantItemForm.RelevantItemForm1.AY;
                qtsxnbspb.LARQ = relevantItemForm.RelevantItemForm1.LARQ;
                qtsxnbspb.XM = relevantItemForm.RelevantItemForm1.XM;
                qtsxnbspb.XB = relevantItemForm.RelevantItemForm1.XB;
                qtsxnbspb.ZY = relevantItemForm.RelevantItemForm1.ZY;
                qtsxnbspb.MZ = relevantItemForm.RelevantItemForm1.MZ;
                qtsxnbspb.SFZHM = relevantItemForm.RelevantItemForm1.SFZH;
                qtsxnbspb.MC = relevantItemForm.RelevantItemForm1.MC;
                qtsxnbspb.FDDBR = relevantItemForm.RelevantItemForm1.FDDBR;
                qtsxnbspb.ZW = relevantItemForm.RelevantItemForm1.ZW;
                qtsxnbspb.GZDW = relevantItemForm.RelevantItemForm1.GZDW;
                qtsxnbspb.DH = relevantItemForm.RelevantItemForm1.DH;
                qtsxnbspb.ZZ = relevantItemForm.RelevantItemForm1.ZZ;
                qtsxnbspb.YZBM = relevantItemForm.RelevantItemForm1.YZBM;
                qtsxnbspb.JYAQ = relevantItemForm.RelevantItemForm1.YZBM;
                qtsxnbspb.CBRYJ = relevantItemForm.RelevantItemForm1.CBRYJ;
                qtsxnbspb.CBRQZ = relevantItemForm.RelevantItemForm1.ProcessUser.UserName;
                qtsxnbspb.CBRQZRQ = relevantItemForm.RelevantItemForm1.ProcessTime.Value.ToString("yyyy年MM月dd日");
                qtsxnbspb.CBJGSHYJ = relevantItemForm.RelevantItemForm2.CBJGSHYJ;
                qtsxnbspb.CBJGSHQZ = relevantItemForm.RelevantItemForm2.ProcessUser.UserName;
                qtsxnbspb.CBJGSHQZRQ = relevantItemForm.RelevantItemForm2.ProcessTime.Value.ToString("yyyy年MM月dd日");
                qtsxnbspb.XZJGFZRSPYJ = relevantItemForm.RelevantItemForm3.XZJGFZRSPYJ;
                qtsxnbspb.XZJGFZRSPQZ = relevantItemForm.RelevantItemForm3.ProcessUser.UserName;
                qtsxnbspb.XZJGFZRSPQZRQ = relevantItemForm.RelevantItemForm3.ProcessTime.Value.ToString("yyyy年MM月dd日");

                string savePDFFilePath = DocBuildBLL.DocBuildQTSXNBSPB(
                 SessionManager.User.RegionName, caseForm.WICode, qtsxnbspb);

                DOCINSTANCE docIntance = new DOCINSTANCE()
                {

                    DOCINSTANCEID = Guid.NewGuid().ToString("N"),
                    DDID = DocDefinition.QTSXNBSPB,
                    DOCTYPEID = (decimal)DocTypeEnum.PDF,
                    AIID = parentAIID,
                    DPID = DocBLL.GetDPIDByADID(parentADID),
                    VALUE = Serializer.Serialize(qtsxnbspb),
                    ASSEMBLYNAME = qtsxnbspb.GetType().Assembly.FullName,
                    TYPENAME = qtsxnbspb.GetType().FullName,
                    WIID = relevantItemForm.ParentWIID,
                    DOCPATH = savePDFFilePath,
                    CREATEDTIME = DateTime.Now,
                    DOCNAME = "其他事项内部审批表",
                    DOCBH = qtsxnbspb.WSBH
                };

                DocBLL.AddRelevantDocInstance(docIntance, true);

                return RedirectToAction("PendingCaseList", "GeneralCase");
            }
        }
    }
}
