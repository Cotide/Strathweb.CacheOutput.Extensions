﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebApi.OutputCache.V2.Demo.Controllers.Base
{
    /// <summary>
    /// WebAPI基类
    /// </summary>
    public class BaseApiController : ApiController
    {
        /// <summary>
        /// 用户Session Key
        /// </summary>
        protected string UserSessionKey = "USER_SESSION_KEY";

        /// <summary>
        /// 用户Cookies Key
        /// </summary>
        protected string UserCookiesKey = "USER_COOKIES_KEY";


        /// <summary>
        /// 获取用户
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        protected string GetUserCookiesKey(string userName)
        {
            return UserCookiesKey + "_" + userName;
        }
       
    }
}
