using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace NewPasswordSoap
{
    /// <summary>
    /// Summary description for NewPasswordCreatorService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class NewPasswordCreatorService : System.Web.Services.WebService
    {

        [WebMethod]
        public string NewPasswordCreator()
        {
            Random random = new Random();
            int sifreKodu = random.Next(999999);
            string sifreKod = sifreKodu.ToString();

            return sifreKod;
        }
    }
}
