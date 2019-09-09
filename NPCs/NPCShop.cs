using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace jam.NPCs
{
    public class NPCShop : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (npc.type == 59)
            {
                if (Main.rand.Next(20) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ignis"));
                }
            }
            if (npc.type == 54)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("book_of_shadowflame_skulls"));
            }
        }
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            switch (type)
            {
                case NPCID.TravellingMerchant:
                    shop.item[nextSlot].SetDefaults(mod.ItemType("genie_YoYo"));  //this is an example of how to add your item
                    nextSlot++;
                    break;
                case NPCID.Cyborg:
                    shop.item[nextSlot].SetDefaults(mod.ItemType("genie_YoYo"));  //this is an example of how to add your item
                    nextSlot++;
                    break;
            }
        }
    }
}
