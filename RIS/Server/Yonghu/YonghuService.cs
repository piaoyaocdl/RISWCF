using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.IdentityModel.Selectors;
namespace Server.Yonghu
{
    public class YonghuService :  IYonghuService
    {
             public bool yonghu_denglu(string zhanghao, string mima)
        {
            using (Shujuku shujuku = new Shujuku())
            {
                if (shujuku.Yonghu.Where(z => z.zhanghao.Equals(zhanghao) && z.mima.Equals(mima)).Count() == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
