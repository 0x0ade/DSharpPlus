﻿using System;

namespace DSharpPlus
{
    public class GuildCreateEventArgs : EventArgs
    {
        public DiscordGuild Guild { get; internal set; }
    }
}
