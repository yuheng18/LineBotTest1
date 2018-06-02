using isRock.LineBot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LineBotTest3
{
    public partial class _default : System.Web.UI.Page
    {
        const string channelAccessToken = "wOh7iK8n4beLEVqJlnsQ+mwWXKgBJtRcnM9PF3WULetkYAF4XNjdb1ItmRkqENpXw/Cg/vqCYPJZzY1uYpwjNSPmK3XDkLA/6Xp8losIyoiWDnvgXCXWQHUhu7uxrwLb5PYhLhL8yG6c+XzMiO1IxAdB04t89/1O/w1cDnyilFU=";
        const string AdminUserId= "U30ed70a8f14bd13db1458473ca0d9d4f";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var bot = new Bot(channelAccessToken);
            bot.PushMessage(AdminUserId, $"測試 {DateTime.Now.ToString()} ! ");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var bot = new Bot(channelAccessToken);
            bot.PushMessage(AdminUserId, 1,2);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            var bot = new Bot(channelAccessToken);

            var actions = new List<isRock.LineBot.TemplateActionBase>();
            actions.Add(new isRock.LineBot.MessageAction() { label = "標題-文字回復", text = "回復文字" });
            actions.Add(new isRock.LineBot.UriAction() { label = "標題-開啟URL", uri=new Uri("Http://www.google.com")});
            actions.Add(new isRock.LineBot.PostbackAction() { label = "標題-發生postback", data = "abc=aaa&def=111" });

            var ButtonTempaleMsg = new isRock.LineBot.ButtonsTemplate()
            {
                title = "選項",
                text = "請選其中之一",
                altText = "請在手機上檢視",
                thumbnailImageUrl = new Uri("https://arock.blob.core.windows.net/blogdata201706/22-124357-ad3c87d6-b9cc-488a-8150-1c2fe642d237.png"),
                actions =actions
            };
            bot.PushMessage(AdminUserId, ButtonTempaleMsg);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            var bot = new Bot(channelAccessToken);

            var actions = new List<isRock.LineBot.TemplateActionBase>();
            actions.Add(new isRock.LineBot.MessageAction() { label = "Yes", text = "Yes" });
            actions.Add(new isRock.LineBot.MessageAction() { label = "No", text = "No" });

            var ConfirmTemplate = new isRock.LineBot.ConfirmTemplate()
            {             
                text = "請選其中之一",
                altText = "請在手機上檢視",              
                actions = actions
            };
            bot.PushMessage(AdminUserId, ConfirmTemplate);
        }
    }
}