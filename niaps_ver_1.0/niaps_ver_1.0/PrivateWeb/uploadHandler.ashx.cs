using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace niaps_ver_1._0.PrivateWeb
{
    /// <summary>
    /// Summary description for uploadHandler
    /// </summary>
    public class uploadHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string path = context.Request["path"];
            FileInfo fn = new FileInfo(path);
            fn.CopyTo(context.Server.MapPath("~/uploads/" + fn.Name));
            context.Response.Write(fn.Name + ":" + fn.Length + ":" + fn.Extension);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}