using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System.Reflection;

namespace BSSMainTS.ApiService.Common;
public class GenericCrudControllerRouteConvention : IControllerModelConvention
{
    public void Apply(ControllerModel controller)
    {
        if (controller.ControllerType.IsGenericType)
        {
            var genericType = controller.ControllerType.GenericTypeArguments[0];
            var customNameAttribute = genericType.GetCustomAttribute<GeneratedCrudControllerRouteAttribute>();

            if (customNameAttribute?.Route != null)
            {
                controller.Selectors.Add(new SelectorModel
                {
                    AttributeRouteModel = new AttributeRouteModel(new RouteAttribute(customNameAttribute.Route)),
                });
                controller.Attributes.Append(new RouteAttribute(customNameAttribute.Route));
                controller.ControllerName = customNameAttribute.Route;
            }
            else
            {
                controller.ControllerName = genericType.Name;
            }
        }
        else
        {
            var controllerName = controller.ControllerType.GetCustomAttributes().OfType<RouteAttribute>().FirstOrDefault()?.Template;
            if (controllerName != null)
                controller.ControllerName = controllerName;
        }
    }
}
