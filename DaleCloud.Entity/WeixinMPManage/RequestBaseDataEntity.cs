﻿/*******************************************************************************
 * Copyright © 2018 DaleCloud.Framework 版权所有
 * Author: DaleCloud
 * Description: DaleCloud
 * Website：
*********************************************************************************/

using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;

namespace DaleCloud.Entity.WeixinManage 
{
	 	//WeixinMP_RequestBaseData
	 
	public class RequestBaseDataEntity : IEntityV2<RequestBaseDataEntity>
	{
   		     
		/// <summary>
		/// 编号
        /// </summary>		
        public string T_Id{ get; set; }        
		/// <summary>
		/// 用户的微信id
        /// </summary>		
        public string T_OpenId{ get; set; }        
		/// <summary>
		/// 数据类型 文本消息：text 图片消息:image 地理位置消息:location 链接消息:link 事件推送:event
        /// </summary>		
        public string T_MsgType{ get; set; }        
		/// <summary>
		/// 数据内容
        /// </summary>		
        public string T_DataContent{ get; set; }        
		/// <summary>
		/// 事件KEY值
        /// </summary>		
        public string T_EventKey{ get; set; }        
		/// <summary>
		/// 消息创建时间
        /// </summary>		
        public string T_CreateTime{ get; set; }        
		/// <summary>
		/// url路径
        /// </summary>		
        public string T_Url{ get; set; }        
		/// <summary>
		/// 链接地址2
        /// </summary>		
        public string T_Url2{ get; set; }        
		/// <summary>
		/// xml原始内容
        /// </summary>		
        public string T_XmlContent{ get; set; }        
		/// <summary>
		/// 录入系统的时间
        /// </summary>		
        public DateTime T_CreateDate{ get; set; }        
		/// <summary>
		/// 状态
        /// </summary>		
        public int T_Flag{ get; set; }        
		/// <summary>
		/// 自定义类型
        /// </summary>		
        public string T_RType{ get; set; }        
		/// <summary>
		/// 备注
        /// </summary>		
        public string T_Remark{ get; set; }        
		/// <summary>
		/// 扩展Int字段
        /// </summary>		
        public int T_ExtInt{ get; set; }        
		/// <summary>
		/// 扩展str
        /// </summary>		
        public string T_ExtStr{ get; set; }        
		/// <summary>
		/// 扩展str2
        /// </summary>		
        public string T_ExtStr2{ get; set; }        
		/// <summary>
		/// 扩展str3
        /// </summary>		
        public string T_ExtStr3{ get; set; }        
		   
	}
}

