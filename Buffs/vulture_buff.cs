using System;
using Terraria;
using Terraria.ModLoader;

namespace jam.Buffs
{
    public class vulture_buff : ModBuff
    {
        public override void SetDefaults()
        {
            Main.buffNoSave[Type] = true;
            Main.buffNoTimeDisplay[Type] = true;

        }

        public override void Update(Player player, ref int buffIndex)
        {
            MyPlayer modPlayer = (MyPlayer)player.GetModPlayer(mod, "MyPlayer");
            if (player.ownedProjectileCounts[mod.ProjectileType("MinionName")] > 0)
            {
                modPlayer.minionName = true;
            }
            if (!modPlayer.minionName)
            {
                player.DelBuff(buffIndex);
                buffIndex--;
            }
            else
            {
                player.buffTime[buffIndex] = 18000;
            }
        }
    }
}