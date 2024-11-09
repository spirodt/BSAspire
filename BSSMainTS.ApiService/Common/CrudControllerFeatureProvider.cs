using BSSMainTS.ApiService.Controllers;
using BSSMainTS.ApiService.Models;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.AspNetCore.Mvc.Controllers;
using System.Reflection;

namespace BSSMainTS.ApiService.Common;
public class CrudControllerFeatureProvider : IApplicationFeatureProvider<ControllerFeature>
{
    public void PopulateFeature(IEnumerable<ApplicationPart> parts, ControllerFeature feature)
    {
        string targetNamespace = "BSSMainTS.ApiService.Models";
        var types = Assembly.GetExecutingAssembly().GetTypes();
        var classTypes = types
            .Where(t => t.IsClass
                    && t.Namespace == targetNamespace
                    && t.BaseType == typeof(EntityBase)
                    && t.GetCustomAttributes<GeneratedCrudControllerRouteAttribute>().Any());

        var entityTypes = new List<Type>();
        foreach (var classType in classTypes)
        {
            entityTypes.Add(classType);
        }

        foreach (var entityType in entityTypes)
        {
            var controllerType = typeof(CrudControllerBase<>).MakeGenericType(entityType).GetTypeInfo();
            feature.Controllers.Add(controllerType); 
        }
    }
}