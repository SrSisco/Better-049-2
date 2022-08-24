using System;
using Exiled.API.Features;
using Exiled.Events.EventArgs;
using Exiled.Events.Handlers;


namespace Better_049_2
{
    public class EventHandlers
    {
        private readonly Plugin plugin;
        public EventHandlers(Plugin plugin) => this.plugin = plugin;
        internal void OnDying(DyingEventArgs ev)
        {
            if (ev.Target is null || ev.Killer is null) return;
            if (ev.Killer.Role == RoleType.Scp0492)
            {
                Random random = new System.Random();
                int randnum = random.Next(0, 99);
                if (randnum < plugin.Config.InfectionProbability)
{
                    ev.Target.DropItems();
                    ev.Target.SetRole(RoleType.Scp0492,lite: true);
                    ev.IsAllowed = false;
                }
            }
        }
    }
}