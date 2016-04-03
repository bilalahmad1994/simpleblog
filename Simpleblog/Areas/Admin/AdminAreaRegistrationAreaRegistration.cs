using System.Web.Mvc;

namespace Simpleblog.Areas.AdminAreaRegistration
{
    public class AdminAreaRegistrationAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "AdminAreaRegistration_default",
                "admin/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}