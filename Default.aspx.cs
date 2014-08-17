using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Senparc.Weixin.MP;
using WeChat.Code;

namespace WeChat
{
    public partial class Default : System.Web.UI.Page
    {
        public readonly string Token = ConfigSetHelper.Token;
        protected void Page_Load(object sender, EventArgs e)
        {
            var _signature = Request["signature"];
            var _timestamp = Request["timestamp"];
            var _nonce = Request["nonce"];
            var _echostr = Request["echostr"];
            if (Request.HttpMethod == "GET")
            {
                if (CheckSignature.Check(_signature, _timestamp, _nonce, Token))
                {
                    WirteContent(_echostr);
                }
                else
                {
                    WirteContent("failed:" + _signature + "," + CheckSignature.GetSignature(_timestamp, _nonce, Token));
                }
            }

        }
        void WirteContent(string str)
        {
            Response.Output.Write(str);
        }
    }
}