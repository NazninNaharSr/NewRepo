using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace UserService
{
    /// <summary>
    /// Summary description for UserService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class UserService : System.Web.Services.WebService
    {

        [WebMethod]
        public string UserInformation()
        {
            return "Hello World";
        }
        [WebMethod]
        public string AddUser()
        {
            return "Added Successfully";
        }

        [WebMethod]
        public string UpdateUser()
        {
            return "Updated Successfully";
        }

        [WebMethod]
        public string DeleteUser()
        {
            return "Deleted Successfully";
        }
        [WebMethod]
        public string ViewMenu()
        {
            return "View Menu List";
        }
    }
}
