using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.dto.res
{

    [DataContract]
    internal class UserLoginRespVO
    {
        [DataMember]
        public string token { set; get; }
    }
}
