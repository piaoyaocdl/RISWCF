using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace Server.Yonghu
{
    [DataContract]
    public class Yonghu
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string zhanghao { get; set; }
        [DataMember]
        public string mima { get; set; }
    }
}
