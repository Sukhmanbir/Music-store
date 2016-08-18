using System.Web;
using System.Web.Mvc;

namespace FinalExam_Sukhmanbir_200303856
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
