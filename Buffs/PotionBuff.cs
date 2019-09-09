using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace jam.Buffs
{
    public class PotionBuff : ModBuff
    {
        public override void SetDefaults()
        {
            Main.buffNoTimeDisplay[Type] = false;
        }
        public override void Update(Player player, ref int buffIndex)
        {                                             //
            player.AddBuff(mod.BuffType("BuffName"), 1); //this is an example of how to add your own buff
            player.AddBuff(BuffID.PotionSickness, 2);
            player.meleeDamage += 10;  //
        }
    }
}