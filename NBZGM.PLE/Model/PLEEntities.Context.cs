﻿//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Taizhou.PLE.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PLEEntities : DbContext
    {
        public PLEEntities()
            : base("name=PLEEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<ACITIVITYDEFINITION> ACITIVITYDEFINITIONS { get; set; }
        public DbSet<ACTIVITYDEFINITIONDOCPHAS> ACTIVITYDEFINITIONDOCPHASES { get; set; }
        public DbSet<ACTIVITYINSTANCE> ACTIVITYINSTANCES { get; set; }
        public DbSet<ACTIVITYPERMISSION> ACTIVITYPERMISSIONS { get; set; }
        public DbSet<ACTIVITYPERMISSIONTYPE> ACTIVITYPERMISSIONTYPES { get; set; }
        public DbSet<ACTIVITYPEROPERTy> ACTIVITYPEROPERTIES { get; set; }
        public DbSet<ACTIVITYSTATUS> ACTIVITYSTATUSES { get; set; }
        public DbSet<APP> APPS { get; set; }
        public DbSet<APPVERSION> APPVERSIONS { get; set; }
        public DbSet<ARTICLE> ARTICLES { get; set; }
        public DbSet<CAMERARELATION> CAMERARELATIONS { get; set; }
        public DbSet<CAMERA> CAMERAS { get; set; }
        public DbSet<CAMERATYPE> CAMERATYPES { get; set; }
        public DbSet<CARALARM> CARALARMS { get; set; }
        public DbSet<CARALARMTYPE> CARALARMTYPES { get; set; }
        public DbSet<CARCARD> CARCARDS { get; set; }
        public DbSet<CARCOMPANy> CARCOMPANIES { get; set; }
        public DbSet<CARDDEVICE> CARDDEVICES { get; set; }
        public DbSet<CARDLOG> CARDLOGS { get; set; }
        public DbSet<CARDRECORD> CARDRECORDS { get; set; }
        public DbSet<CARDTYPE> CARDTYPES { get; set; }
        public DbSet<CARHISTORYPOSITION> CARHISTORYPOSITIONS { get; set; }
        public DbSet<CARHISTORYTEMPPOSITION> CARHISTORYTEMPPOSITIONS { get; set; }
        public DbSet<CARLATESTPOSITION> CARLATESTPOSITIONS { get; set; }
        public DbSet<CARLOCATION> CARLOCATIONS { get; set; }
        public DbSet<CARLOCATIONTYPE> CARLOCATIONTYPES { get; set; }
        public DbSet<CAR> CARS { get; set; }
        public DbSet<CARSYNCPOSITION> CARSYNCPOSITIONS { get; set; }
        public DbSet<CARTYPE> CARTYPES { get; set; }
        public DbSet<CASEPHONESMS> CASEPHONESMSES { get; set; }
        public DbSet<CASESOURCE> CASESOURCES { get; set; }
        public DbSet<CONSTRSITE> CONSTRSITES { get; set; }
        public DbSet<CONTACT> CONTACTS { get; set; }
        public DbSet<CONTACTSGROUP> CONTACTSGROUPS { get; set; }
        public DbSet<DOCDEFINITIONRELATION> DOCDEFINITIONRELATIONS { get; set; }
        public DbSet<DOCDEFINITION> DOCDEFINITIONS { get; set; }
        public DbSet<DOCINSTANCE> DOCINSTANCES { get; set; }
        public DbSet<DOCPHAS> DOCPHASES { get; set; }
        public DbSet<DUMPINGSITE> DUMPINGSITES { get; set; }
        public DbSet<FUNCTION> FUNCTIONS { get; set; }
        public DbSet<GGFWCASENAME> GGFWCASENAMES { get; set; }
        public DbSet<GGFWEVENT> GGFWEVENTS { get; set; }
        public DbSet<GGFWMONTHLYREPORT> GGFWMONTHLYREPORTS { get; set; }
        public DbSet<GGFWSOURCE> GGFWSOURCES { get; set; }
        public DbSet<GGFWSTATUE> GGFWSTATUES { get; set; }
        public DbSet<GGFWTOZFZD> GGFWTOZFZDS { get; set; }
        public DbSet<GGFWXFDOC> GGFWXFDOCS { get; set; }
        public DbSet<GROUP> GROUPS { get; set; }
        public DbSet<ILLEGALCLASS> ILLEGALCLASSES { get; set; }
        public DbSet<ILLEGALITEM> ILLEGALITEMS { get; set; }
        public DbSet<LAYERTYPE> LAYERTYPEs { get; set; }
        public DbSet<LEADERWEEKWORKPLAN> LEADERWEEKWORKPLANS { get; set; }
        public DbSet<MAPINFO> MAPINFOS { get; set; }
        public DbSet<MENU> MENUS { get; set; }
        public DbSet<MESSAGE> MESSAGES { get; set; }
        public DbSet<MESSAGETOUSER> MESSAGETOUSERS { get; set; }
        public DbSet<ONDUTy> ONDUTIES { get; set; }
        public DbSet<PHONEERROR> PHONEERRORS { get; set; }
        public DbSet<PORTALCATEGORy> PORTALCATEGORIES { get; set; }
        public DbSet<QUESTIONID> QUESTIONIDS { get; set; }
        public DbSet<QUESTIONLIST> QUESTIONLISTS { get; set; }
        public DbSet<RCDCEVENT> RCDCEVENTS { get; set; }
        public DbSet<RCDCTOZFZD> RCDCTOZFZDS { get; set; }
        public DbSet<RECIPE> RECIPES { get; set; }
        public DbSet<ROLEFUNCTION> ROLEFUNCTIONS { get; set; }
        public DbSet<ROLEMENU> ROLEMENUS { get; set; }
        public DbSet<ROLE> ROLES { get; set; }
        public DbSet<SCHEDULE> SCHEDULES { get; set; }
        public DbSet<SCHEDULETYPE> SCHEDULETYPES { get; set; }
        public DbSet<SIGNRESUL> SIGNRESULS { get; set; }
        public DbSet<SIMPLECASEPICTURE> SIMPLECASEPICTURES { get; set; }
        public DbSet<SIMPLECAS> SIMPLECASES { get; set; }
        public DbSet<SINGNIN> SINGNINS { get; set; }
        public DbSet<SPECIALACTIVITICE> SPECIALACTIVITICES { get; set; }
        public DbSet<SPECIALACTIVITYDEFINITON> SPECIALACTIVITYDEFINITONS { get; set; }
        public DbSet<SPECIALTOZFSJ> SPECIALTOZFSJS { get; set; }
        public DbSet<SPECIALWORKFLOWINSTANCE> SPECIALWORKFLOWINSTANCES { get; set; }
        public DbSet<STREESTORE> STREESTORES { get; set; }
        public DbSet<STREESTORETYPE> STREESTORETYPES { get; set; }
        public DbSet<STREETASSESSMENTTYPE> STREETASSESSMENTTYPES { get; set; }
        public DbSet<STREETBAS> STREETBASES { get; set; }
        public DbSet<STREETEXAMINE> STREETEXAMINES { get; set; }
        public DbSet<STREETPROBLEM> STREETPROBLEMS { get; set; }
        public DbSet<STREET> STREETS { get; set; }
        public DbSet<STREETTYPE> STREETTYPES { get; set; }
        public DbSet<STREETUSER> STREETUSERS { get; set; }
        public DbSet<TJGHZF> TJGHZFS { get; set; }
        public DbSet<TRANSLICENSECARCOMPANy> TRANSLICENSECARCOMPANIES { get; set; }
        public DbSet<TRANSLICENSECAR> TRANSLICENSECARS { get; set; }
        public DbSet<TRANSLICENSEROAD> TRANSLICENSEROADS { get; set; }
        public DbSet<TRANSLICENS> TRANSLICENSES { get; set; }
        public DbSet<TRANSRECORD> TRANSRECORDS { get; set; }
        public DbSet<TRANSROAD> TRANSROADS { get; set; }
        public DbSet<UNIT> UNITS { get; set; }
        public DbSet<UNITTYPE> UNITTYPES { get; set; }
        public DbSet<USERARCHIVE> USERARCHIVES { get; set; }
        public DbSet<USERCATEGORy> USERCATEGORIES { get; set; }
        public DbSet<USERGROUP> USERGROUPs { get; set; }
        public DbSet<USERONDUTy> USERONDUTIES { get; set; }
        public DbSet<USERPHONESIGNIN> USERPHONESIGNINS { get; set; }
        public DbSet<USERPOSITION> USERPOSITIONS { get; set; }
        public DbSet<USERROLE> USERROLES { get; set; }
        public DbSet<USER> USERS { get; set; }
        public DbSet<WORKFLOWDEFINITION> WORKFLOWDEFINITIONS { get; set; }
        public DbSet<WORKFLOWINSTANCE> WORKFLOWINSTANCES { get; set; }
        public DbSet<WORKFLOWPEROPERTy> WORKFLOWPEROPERTIES { get; set; }
        public DbSet<WORKFLOWSTATUS> WORKFLOWSTATUSES { get; set; }
        public DbSet<WTUSERRELATION> WTUSERRELATIONS { get; set; }
        public DbSet<XCJGAREA> XCJGAREAS { get; set; }
        public DbSet<XCJGCARTASK> XCJGCARTASKS { get; set; }
        public DbSet<XCJGROUTE> XCJGROUTES { get; set; }
        public DbSet<XCJGSIGNIN> XCJGSIGNINS { get; set; }
        public DbSet<XCJGUSERTASK> XCJGUSERTASKS { get; set; }
        public DbSet<XZSPACTDEF> XZSPACTDEFS { get; set; }
        public DbSet<XZSPACTIST> XZSPACTISTS { get; set; }
        public DbSet<XZSPACTIVITYDEFINITION> XZSPACTIVITYDEFINITIONS { get; set; }
        public DbSet<XZSPAPPROVALPROJECT> XZSPAPPROVALPROJECTS { get; set; }
        public DbSet<XZSPKZHC> XZSPKZHCs { get; set; }
        public DbSet<XZSPNEWACTIVITYDEFINITION> XZSPNEWACTIVITYDEFINITIONS { get; set; }
        public DbSet<XZSPNEWTAB> XZSPNEWTABs { get; set; }
        public DbSet<XZSPNEWWORKFLOWINSTANCE> XZSPNEWWORKFLOWINSTANCES { get; set; }
        public DbSet<XZSPPROJECTNAME> XZSPPROJECTNAMEs { get; set; }
        public DbSet<XZSPSTU> XZSPSTUS { get; set; }
        public DbSet<XZSPWFDEF> XZSPWFDEFS { get; set; }
        public DbSet<XZSPWFIST> XZSPWFISTS { get; set; }
        public DbSet<XZSPWFISTS_DELETE> XZSPWFISTS_DELETE { get; set; }
        public DbSet<XZZFLISTSH> XZZFLISTSHS { get; set; }
        public DbSet<XZZFQUESTIONCLASS> XZZFQUESTIONCLASSES { get; set; }
        public DbSet<XZZFTABLIST> XZZFTABLISTS { get; set; }
        public DbSet<ZBRZLIST> ZBRZLISTS { get; set; }
        public DbSet<ZFGKCARHISTORYPOSITION> ZFGKCARHISTORYPOSITIONS { get; set; }
        public DbSet<ZFGKCARLATESTPOSITION> ZFGKCARLATESTPOSITIONS { get; set; }
        public DbSet<ZFGKCAR> ZFGKCARS { get; set; }
        public DbSet<ZFGKUSERHISTORYPOSITION> ZFGKUSERHISTORYPOSITIONS { get; set; }
        public DbSet<ZFGKUSERLATESTPOSITION> ZFGKUSERLATESTPOSITIONS { get; set; }
        public DbSet<ZFSJACTIVITYDEFINITION> ZFSJACTIVITYDEFINITIONs { get; set; }
        public DbSet<ZFSJACTIVITYINSTANCE> ZFSJACTIVITYINSTANCES { get; set; }
        public DbSet<ZFSJCHARTBYQL> ZFSJCHARTBYQLs { get; set; }
        public DbSet<ZFSJCHECKWAY> ZFSJCHECKWAYs { get; set; }
        public DbSet<ZFSJPROCESSWAY> ZFSJPROCESSWAYs { get; set; }
        public DbSet<ZFSJQUESTIONCLASS> ZFSJQUESTIONCLASSES { get; set; }
        public DbSet<ZFSJSOURCE> ZFSJSOURCES { get; set; }
        public DbSet<ZFSJSTATU> ZFSJSTATUS { get; set; }
        public DbSet<ZFSJSUMMARYINFORMATION> ZFSJSUMMARYINFORMATIONS { get; set; }
        public DbSet<ZFSJTIMELIMIT> ZFSJTIMELIMITS { get; set; }
        public DbSet<ZFSJWORKFLOWINSTANCE> ZFSJWORKFLOWINSTANCES { get; set; }
        public DbSet<XCJGREST> XCJGRESTS { get; set; }
        public DbSet<XCJGRESTALARM> XCJGRESTALARMS { get; set; }
    }
}