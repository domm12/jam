using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace jam.Items
{
    class mandible_staff : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mandible Staff");
            Tooltip.SetDefault("Casts enchanted mandibles at your foes");
        }
        public override void SetDefaults()
        {
            item.damage = 27;           //this is the item damage
            item.noMelee = true;
            item.magic = true;
            item.width = 38;
            item.mana = 7;
            item.height = 38;
            item.width = 38;
            item.useTime = 20;       //this is how fast you use the item
            item.useAnimation = 20;   //this is how fast the animation when the item is used
            item.useStyle = 5;
            item.knockBack = 3;
            item.value = 10;
            item.rare = 3;
            item.reuseDelay = 3;    //this is the item delay
            item.autoReuse = true;       //this make the item auto reuse
            item.shoot = mod.ProjectileType("mandible_staff_projectile");  //projectile
            item.shootSpeed = 9f;     //projectile speed

        }
        public override void AddRecipes()  //How to craft this item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
