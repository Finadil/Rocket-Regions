﻿using System.Collections.Generic;
using Rocket.Unturned.Player;

namespace RocketRegions.Model.Flag.Impl
{
    public class NoEquipFlag : BoolFlag
    {
        public override string Description => "Allow/Disallow equipping items";

        public override void UpdateState(List<UnturnedPlayer> players)
        {
            foreach (var player in players)
            {
                if (player?.Player?.Equipment?.useable == null)
                    continue;
                if (!player.Player.Equipment.isEquipped)
                    continue;
                if (!GetValueSafe(Region.GetGroup(player)))
                    continue;
                player.Player.Equipment.dequip();
            }    
        }

        public override void OnRegionEnter(UnturnedPlayer player)
        {
            
        }

        public override void OnRegionLeave(UnturnedPlayer player)
        {
           
        }
    }
}