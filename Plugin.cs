﻿using System;
using Better049_2;
using Exiled.API.Features;
using Player = Exiled.Events.Handlers.Player;

namespace Better_049_2
{
    public class Plugin : Plugin<Config>
    {
        private EventHandlers EventHandler;
        public override string Name => "Better 049-2";
        public override string Author => "SrSisco";
        public override Version Version => new Version(1, 1, 0);

        public override void OnEnabled()
        {
            EventHandler = new EventHandlers(this);
            Log.Info("Better 049-2 has been enabled.");
            Player.Dying += EventHandler.OnDying;
            base.OnEnabled();

        }

        public override void OnDisabled()
        {
            Player.Dying -= EventHandler.OnDying;
            EventHandler = null;
            Log.Info("Better 049-2 has been disabled.");
            base.OnDisabled();
        }
    }
}