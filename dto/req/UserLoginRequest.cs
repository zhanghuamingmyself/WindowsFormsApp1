using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.dto.req
{
    [DataContract]
    internal class UserLoginRequest
    {
        [DataMember]
        public string account { set; get; }

        [DataMember]
        public string code { set; get; }

        public UserLoginRequest()
        {

        }

        public UserLoginRequest(string account, string code)
        {
            this.account = account;
            this.code = code;
        }
    }
}
