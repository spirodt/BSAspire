namespace BSSMainTS.ApiService.Common;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
public class GeneratedCrudControllerRouteAttribute : Attribute
{
    public GeneratedCrudControllerRouteAttribute(string route)
    {
        Route = route;
    }

    public string Route { get; set; }
}
