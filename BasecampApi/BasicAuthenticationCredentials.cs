﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;

namespace Buru.BasecampApi
{
    public class BasicAuthenticationCredentials : IAuthenticationCredentials
    {
        public BasicAuthenticationCredentials()
        {

        }

        public string UserName { get; set; }
        public string Password { get; set; }
        public int AccountId { get; set; }

        public NetworkCredential GetCredentials()
        {
            return new NetworkCredential(UserName, Password);
        }

        public string GetEndPointUrlBase()
        {
            return string.Format("https://basecamp.com/{0}/api/v1/", AccountId);
        }
    }
}