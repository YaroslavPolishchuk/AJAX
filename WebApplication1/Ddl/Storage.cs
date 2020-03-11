using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Ddl
{
    public class Storage
    {
        public static Dictionary<int, string> GetDdl()
        {
            var source = new Dictionary<int, string>();
            source.Add(1, "Javascript fetch");
            source.Add(2, "Jquery ajax");
            source.Add(3, "Jquery load(get)");
            source.Add(4, "Jquery load(post)");
            return source;
        }
    }
}