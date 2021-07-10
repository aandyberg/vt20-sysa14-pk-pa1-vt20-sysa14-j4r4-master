using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.IO;

namespace Assignment_3
{
    /// <summary>
    /// Summary description for WebService3
    /// </summary>
    [WebService(Namespace = "http://rentacar.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService3 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public String rentacar(String rentacar)
        {
            try
            {
                StreamReader sr = File.OpenText("C:\\Users\\Administrator\\Desktop\\" + rentacar);
                {
                    String line = sr.ReadToEnd();
                    return line;
                }
            }
            catch (FileNotFoundException)
            {
                return "Hittade ej filen";
            }
            catch (Exception)
            {
                return "Kunde ej skriva ut filens innehåll. Kontakta supporten";
            }

        }
    }
}
