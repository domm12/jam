using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace jam.Items.Armor
{
    [AutoloadEquip(EquipType.Legs)]
    public class harpy_legs : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Harpy leggings");
            Tooltip.SetDefault("Increases all damage by 5%. Increases mininons and ranged damage by 7%. Increaces speed by 6%"
                + "\nThese are just feathers, how can they protect?");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 10000;
            item.rare = 2;
            item.defense = 6;
        }

        public override void UpdateEquip(Player player)
        {
            player.allDamage += player.allDamage * (float)0.05;
            player.moveSpeed += player.moveSpeed * (float)0.06;
            player.minionDamage += player.minionDamage * (float)0.07;
            player.rangedDamage += player.rangedDamage * (float)0.07;
        }

        public override void AddRecipes()
        {

        }
    }
}