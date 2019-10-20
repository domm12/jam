using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace jam.Buffs
{
    public class radioactive : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Radioactive");
            Description.SetDefault("Wow, you are glowing");
            Main.debuff[Type] = true;
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
            longerExpertDebuff = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.poisoned = true;
            MyPlayer.isRadioactive = true;
            player.AddBuff(BuffID.Shine, 1);
        }
    }
}