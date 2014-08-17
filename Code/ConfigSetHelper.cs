using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace WeChat.Code
{
    /// <summary>
    /// 配置帮助类
    /// </summary>
    public class ConfigSetHelper
    {
        /// <summary>
        /// 调用接口凭证
        /// </summary>
        public static string Token = ConfigurationManager.AppSettings["Token"];
    }
}