using System;
using Better049_2;
using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.Events.EventArgs;
using Exiled.Events.EventArgs.Player;
using Exiled.Events.Handlers;
using PlayerRoles;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Better_049_2
{
    public class EventHandlers
    {
        private readonly Plugin plugin;
        public EventHandlers(Plugin plugin) => this.plugin = plugin;
        internal void OnDying(DyingEventArgs ev)
        {
            if (ev.Player is null || ev.Attacker is null) return;
            if (ev.Attacker.Role == RoleTypeId.Scp0492)
            {
                if (Random.Range(0,99) < plugin.Config.InfectionProbability)
                {
                    ev.Player.DropItems();
                    ev.Player.Role.Set(RoleTypeId.Scp0492, SpawnReason.ForceClass, RoleSpawnFlags.None);
                    ev.IsAllowed = false;
                }
            }
        }
    }
}