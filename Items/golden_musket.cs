using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace jam.Items
{

    public class golden_musket : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Golden Musket");
            Tooltip.SetDefault("Only for the richest");
        }
        public override void SetDefaults()
        {
            item.damage = 40;
            item.ranged = true;
            item.width = 70;
            item.height = 28;
            item.useTime = 40; //
            item.useAnimation = 20; //
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 4;
            item.value = 10000;
            item.rare = 2;
            item.reuseDelay = 10;
            item.autoReuse = true;
            item.shoot = 10;
            item.shootSpeed = 8f;
            item.useAmmo = 97;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(96, 1);
            recipe.AddIngredient(21, 2);
            recipe.AddIngredient(19, 2);
            recipe.AddTile(16);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}