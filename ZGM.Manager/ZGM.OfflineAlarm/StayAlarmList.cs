﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZGM.OfflineAlarm
{
    public class StayAlarmList
    {
        //离线报警记录
        //存放全部当前所处位置的记录
        public static List<AlarmList> OffLineLists = new List<AlarmList>();
        //存放离线报警数据
        public static List<AlarmList> OffLineAlarmLists = new List<AlarmList>();
    }
}
