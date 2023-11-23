﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniWebServer.WebSocket.Abstractions
{
    public interface IWebSocketHandler
    {
        Task InvokeAsync(IWebSocket webSocket);
    }
}
