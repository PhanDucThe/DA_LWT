using System.Web;
using System.Web.Mvc;

namespace Quan_Li_Nha_Thuoc
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
