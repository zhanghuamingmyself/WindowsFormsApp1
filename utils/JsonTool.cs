using System.IO;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace WindowsFormsApp1.utils
{
    public static class JsonTool
    {
        /// <summary>
        /// Converts the obj to json.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t">The t.</param>
        /// <returns>System.String.</returns>
        /// <remarks>Editor：v-liuhch CreateTime：2015/6/21 21:40:55</remarks>
        public static string toJson<T>(T t)
        {
            DataContractJsonSerializer ser = new DataContractJsonSerializer(t.GetType());

            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    ser.WriteObject(ms, t);
                    return Encoding.UTF8.GetString(ms.ToArray());
            
                }

            }
            catch (IOException)
            {
                //自己处理异常吧
                return null;
            }


        }

        /// <summary>
        /// Jsons the deserialize.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="strJson">The STR json.</param>
        /// <returns>``0.</returns>
        /// <remarks>Editor：v-liuhch CreateTime：2015/6/21 21:46:37</remarks>
        public static T fromJson<T>(string strJson)
            where T : class //约束T为class,也可以放宽类型，这里只是个例子，写着玩儿的，欧巴们，此处可改
        {

            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));

            try
            {
                using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(strJson)))
                {
                    return ser.ReadObject(ms) as T;
            
                }
            }
            catch (IOException e)
            {
                //自己处理异常吧
                return null;
            }

        }
    }
}
