using System;
using System.Collections.Generic;
using System.IO;
using WindowsFormsApp1.dto.req;
using WindowsFormsApp1.dto.res;
using WindowsFormsApp1.utils;

namespace WindowsFormsApp1
{
    class Test
    {

        public void refreshToken(string account, string code)
        {
            string path = "/user/login/background";
            UserLoginRequest req = new UserLoginRequest(account, code);
            BaseRes<UserLoginRespVO> res = HttpTool.doPost<BaseRes<UserLoginRespVO>>(path, JsonTool.toJson(req));
            if (null != res && null != res.data)
            {
                HttpTool.token = "Bearer " +  res.data.token;
            }
        }

        public GetDeviceResponse getDevice(string sn)
        {
            string path = "/tbuser/devices/getDevice";
            GetPublicInfoByDeviceRequest req = new GetPublicInfoByDeviceRequest();
            req.snCode = sn;
            BaseRes<GetDeviceResponse> res = HttpTool.doPost<BaseRes<GetDeviceResponse>>(path, JsonTool.toJson(req));
            return res.data;

        }

    }
}
