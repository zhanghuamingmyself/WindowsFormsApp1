using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.dto.req
{
    [DataContract]
    internal class GetPublicInfoByDeviceRequest
    {
        [DataMember]
        public string snCode { set; get; }
    }
}
