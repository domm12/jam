using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace jam.Items
{
    public class uranium_soup : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Soup with uranium");
            Tooltip.SetDefault("Pure insanty...");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.useTurn = true;
            item.maxStack = 30;
            item.rare = 1;
            item.useAnimation = 17;
            item.useTime = 17;
            item.useStyle = 2;
            item.UseSound = SoundID.Item3;
            item.consumable = true;
            item.buffType = mod.BuffType("radioactive");
            item.buffTime = 2 * (60 * 60 * 60); // 2 hours
            item.value = Item.sellPrice(0, 0, 0, 1);

            
        }

        public override void AddRecipes()
        {
            
        }
    }
}