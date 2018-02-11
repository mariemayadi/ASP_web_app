using System.Web;
using System.Web.Mvc;

namespace ASP_web_app_boilerplate {
    public class FilterConfig {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
