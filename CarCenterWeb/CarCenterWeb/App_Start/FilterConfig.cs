using System.Web;
using System.Web.Mvc;

namespace CarCenterWeb
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            //habilitar el filtro de sesecion para cada submit en la aplicacion
            filters.Add(new Filters.VerificarSesion());
        }
    }
}
