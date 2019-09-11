using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace jam.NPCs
{
    public class JamGlobalNPC : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (npc.type == NPCID.BigMimicHallow)
            {
                if (Main.rand.Next(5) == 0)   //item rarity 1/5 = 20%
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("dart_machine_gun"));
                }
            }
        }
    }
}
