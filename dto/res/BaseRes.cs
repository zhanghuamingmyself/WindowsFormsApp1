using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.dto.res
{
    [DataContract]
    class BaseRes<T>
    {
      
        [DataMember]
        public int code { get; set; }

        [DataMember]
        public String msg { get; set; }

        [DataMember]
        public T data { get; set; }
    }
}
