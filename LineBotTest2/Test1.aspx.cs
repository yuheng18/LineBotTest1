using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LineBotTest2
{
    public partial class Test1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            isRock.LineBot.Bot bot = new isRock.LineBot.Bot("wOh7iK8n4beLEVqJlnsQ+mwWXKgBJtRcnM9PF3WULetkYAF4XNjdb1ItmRkqENpXw/Cg/vqCYPJZzY1uYpwjNSPmK3XDkLA/6Xp8losIyoiWDnvgXCXWQHUhu7uxrwLb5PYhLhL8yG6c+XzMiO1IxAdB04t89/1O/w1cDnyilFU=");
            var a = DateTime.Now.ToString();
            bot.PushMessage("U30ed70a8f14bd13db1458473ca0d9d4f", a);
            bot.PushMessage("U30ed70a8f14bd13db1458473ca0d9d4f", "Test1");
            bot.PushMessage("U30ed70a8f14bd13db1458473ca0d9d4f", 1,3);
           
        }
    }
}