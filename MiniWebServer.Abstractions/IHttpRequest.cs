﻿using Microsoft.Extensions.Logging;
using MiniWebServer.Abstractions.Http;
using System;
using System.Collections.Generic;
using System.IO.Pipelines;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniWebServer.Abstractions
{
    public interface IHttpRequest: IParametersContainer, IRequestHeadersContainer, IFormContainer, IRequestBodyReader
    {
        Http.HttpMethod Method { get; }
        string Url { get; }
        bool KeepAliveRequested { get; }
        HttpCookies Cookies { get; }
        Pipe BodyPipeline { get; }
        string Hash { get; }
        string QueryString { get; }
        long ContentLength { get; }
        string ContentType { get; }
        string[] Segments { get; }
        public IRequestBodyManager BodyManager { get; }
    }
}
