using System.Text.RegularExpressions;

namespace Routing.CustomerRouterConstraint
{
    public class monthConstraints: IRouteConstraint
    {
        public bool Match(HttpContext? httpContext, IRouter? route, 
            string routeKey, RouteValueDictionary values,
            RouteDirection routeDirection)
        {
            Console.WriteLine(route);
            Console.WriteLine(routeKey);
            Console.WriteLine(string.Join(",", values.Keys));
            // check whether the value exists
            if (!values.ContainsKey(routeKey)) // month
            {
                return false; // not a match
            }
            Regex regex = new Regex("^(apr|jul|oct|jan)$");
            string? monthValue = Convert.ToString(values[routeKey]);

            if (regex.IsMatch(monthValue)) {
                return true; // it's match
            }
            return false;
        }
    }
}
