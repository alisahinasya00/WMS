using System.Web.Mvc;
using System.Web.Routing;

namespace WMS.MvcUI.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Admin_default",
                "Admin/{Controller}/{Action}/{id}",
                new { action = "AdminLogin", id = UrlParameter.Optional }
            );
        }

    }
}
