using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginVoLam.Web.Common
{
    [Serializable]
    public class UserLogin
    {
        public int? UserIp { get; set; }
        public string UserName { get; set; }
    }
}