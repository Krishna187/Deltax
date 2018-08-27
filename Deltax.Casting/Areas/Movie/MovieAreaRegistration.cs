using System.Web.Mvc;

namespace Deltax.Casting.Areas.Movie
{
    public class MovieAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Movie";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Movie_default",
                "Movie/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}