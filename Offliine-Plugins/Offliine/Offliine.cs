﻿using Offliine.API.Plugin;

namespace Offliine
{
    [PluginInfo("Offliine", "offliine")]
    public class Offliine
    {
        [PluginInit]
        public void Init(IPluginInit init)
        {
            init.Log("OFFLIINE");
        }
    }
}
