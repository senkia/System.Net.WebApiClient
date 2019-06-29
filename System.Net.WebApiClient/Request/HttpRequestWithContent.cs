﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace System.Net.WebApiClient.Request
{
    /// <summary>
    /// Defines a base class for a HTTP request with a body. 
    /// </summary>
    public abstract class HttpRequestWithContent : HttpRequestBase
    {
        /// <summary>
        /// The object that must be serialized into the body of the HTTP request.
        /// </summary>
        public object Content { get; set; }

        public HttpRequestWithContent(HttpMethod method) : base(method)
        {
        }
    }
}
