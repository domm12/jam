using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace jam.Items.Armor
{
    [AutoloadEquip(EquipType.Body)]
    public class harpy_breastplate : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Harpy breastplate");
            Tooltip.SetDefault("Increases all damage by 5%. Increases melee speed by 13%. Increaces max minions by 1"
                + "\nThese are just feathers, how can they protect you?");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 10000;
            item.rare = 2;
            item.defense = 9;
        }

        public override void UpdateEquip(Player player)
        {
            player.allDamage += player.allDamage * (float)0.06;
            player.meleeSpeed += player.moveSpeed * (float)0.13;
            player.maxMinions += 1;
        }

        public override void AddRecipes()
        {

        }
    }
}
