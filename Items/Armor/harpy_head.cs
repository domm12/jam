using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace jam.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class harpy_head : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Harpy head");
            Tooltip.SetDefault("Increases all damage by 6%. Increases magic damage by 6%"
                + "\nThese are just feathers, how can they protect you?");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 10000;
            item.rare = 2;
            item.defense = 7;
        }

        public override void UpdateEquip(Player player)
        {
            player.allDamage += player.allDamage * (float)0.06;
            player.magicDamage += player.moveSpeed * (float)0.06;
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "There is a power of feathers with you. Defense decreased by 1, jump height increased";
            player.statDefense -= 1;
            player.jumpBoost = true;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == ItemType<harpy_breastplate>() && legs.type == ItemType<harpy_legs>();
        }

        public override void AddRecipes()
        {
            
        }
    }
}
