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
            isRock.LineBot.Bot bot = new isRock.LineBot.Bot("YADVK0D8s2AGIOlgIBQTJE07TyTe3BlvVqGOh+V87O+CATG7HwCAyi65S9vOpdOBw/Cg/vqCYPJZzY1uYpwjNSPmK3XDkLA/6Xp8losIyojM6SiqZIa5J+4NUaRcvG/TfqFUE+Y4UigN0x3dFL0UgwdB04t89/1O/w1cDnyilFU=");
            var a = DateTime.Now.ToString();
            bot.PushMessage("U30ed70a8f14bd13db1458473ca0d9d4f", a);
            bot.PushMessage("U30ed70a8f14bd13db1458473ca0d9d4f", "Test1");
            bot.PushMessage("U30ed70a8f14bd13db1458473ca0d9d4f", 1,3);
           
        }
    }
}