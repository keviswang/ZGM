﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Taizhou.PLE.Model.WebServiceModels
{
    /// <summary>
    /// 执法事件
    /// </summary>
    [Serializable]
    public class EnforceLawEvent
    {
        /// <summary>
        /// 事件编号
        /// </summary>
        public string code { get; set; }

        /// <summary>
        /// 事件标题
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// 事件地址
        /// </summary>
        public string address { get; set; }

        /// <summary>
        /// 事件内容
        /// </summary>
        public string content { get; set; }

        /// <summary>
        /// 事件来源
        /// </summary>
        public int source { get; set; }

        /// <summary>
        /// 问题大类标识
        /// </summary>
        public int mainClassID { get; set; }

        /// <summary>
        /// 问题小类标识
        /// </summary>
        public int sunClassID { get; set; }

        /// <summary>
        /// 所属区局标识
        /// </summary>
        public int regionID { get; set; }

        /// <summary>
        /// 所属中队标识
        /// </summary>
        public int unitID { get; set; }

        /// <summary>
        /// 发现时间
        /// </summary>
        public string discoverTime { get; set; }

        /// <summary>
        /// 地图位置（经度|纬度）
        /// </summary>
        public string mapLocation { get; set; }

        /// <summary>
        /// 事件照片一
        /// </summary>
        public byte[] eventPhoto1 { get; set; }

        /// <summary>
        /// 事件照片二
        /// </summary>
        public byte[] eventPhoto2 { get; set; }

        /// <summary>
        /// 事件照片三
        /// </summary>
        public byte[] eventPhoto3 { get; set; }

        /// <summary>
        /// 上报时间
        /// </summary>
        public string reportTime { get; set; }

        /// <summary>
        /// 上报人员
        /// </summary>
        public int userID { get; set; }

        /// <summary>
        /// 派遣意见
        /// </summary>
        public string comment { get; set; }

        /// <summary>
        /// 派遣时间
        /// </summary>
        public string dispatchTime { get; set; }

        /// <summary>
        /// 手机上传唯一标识
        /// </summary>
        public string PhoneID { get; set; }
    }
}
