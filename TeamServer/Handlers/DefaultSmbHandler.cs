﻿using System.Collections.Generic;

using TeamServer.Models;

namespace TeamServer.Handlers
{
    public class DefaultSmbHandler : Handler
    {
        public override string Name { get; } = "default-smb";

        public override List<HandlerParameter> Parameters => new()
        {
            new HandlerParameter("PipeName", "SharpPipe", false)
        };

        public override void Stop()
        {
            // does nothing
        }
    }
}