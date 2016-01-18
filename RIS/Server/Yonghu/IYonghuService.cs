using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Server.Yonghu
{
    [ServiceContract]
    public interface IYonghuService
    {
        //登录验证
        [OperationContract]
        bool yonghu_denglu(string zhanghao,string mima);

        [OperationContract]
        string say(string hua);
    }
}
