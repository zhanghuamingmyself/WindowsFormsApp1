using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.dto.res
{
    [DataContract]
    internal class GetDeviceResponse
    {
        [DataMember]
        public string snCode { set; get; }

        [DataMember]
        public string pnCode { set; get; }

        [DataMember]
        public string imei { set; get; }
    }
}
