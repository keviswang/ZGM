﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DYQDTJ.aspx.cs" Inherits="ZGM.WUA.Web.Views.Report.SonView_Person.DYQDTJ" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>队员签到统计</title>
  <link href="../../../Styles/report.css" rel="stylesheet" />
</head>
<body>
   <div class="top">
       <div class="title"> 
           队员签到统计
       </div>
       <div class="tabDiv" style=" text-align:center;">
           <div class="tab tab_left_selected">日</div>
            <div class="tab ">月</div>
            <div class="tab ">年</div>
       </div>
   </div>
    <div class="content" id="chartDiv">

    </div>
    
</body>
</html>
<script src="../../../Scripts/base/jquery-1.8.2.min.js"></script>
<script src="../../../Scripts/Chart/echarts.min.js"></script>
<script src="../../../Scripts/Report/SonView_Person/DYQDTJ.js"></script>
