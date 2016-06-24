using System.Web;
using System.Web.Mvc;

namespace MVCBaseApplication
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            // uncomment this code to strict access to entire website
            //filters.Add(new AuthorizeAttribute());
        }
    }
}
