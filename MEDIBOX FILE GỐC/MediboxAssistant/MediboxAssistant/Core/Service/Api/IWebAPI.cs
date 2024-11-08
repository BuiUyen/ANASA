﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Medibox.Model;
using Medibox.Service.Model;

namespace Medibox.Service.Api
{
    [ServiceContract]
    public interface IWebAPI
    {
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, UriTemplate = "/spotify/callback?code={code}&state={state}")]
        Stream API_Spotify_Callback(String code, String state);

        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, UriTemplate = "/tro_ly_ao/webhook")]
        API_WebHookData_Out TroLyAo_Webhook(API_WebHookData_In data);

        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, UriTemplate = "/tro_ly_ao/command")]
        API_TroLyAoData_Out TroLyAo_Execute(API_TroLyAoData_In data);
    }
}
