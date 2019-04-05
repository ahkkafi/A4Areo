using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A4Areo
{
    public class DependencyResolver
    {
        public static T GetService<T>()
        {
            return (T)HttpContext.Current.RequestServices.GetService(typeof(T));
        }

    }
}
