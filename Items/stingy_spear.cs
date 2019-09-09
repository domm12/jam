using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace jam.Items
{
    public class stingy_spear : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Stingy Spear");
            Tooltip.SetDefault("Has a chanse to poison enemies");
        }
        public override void SetDefaults()
        {
            item.damage = 23;           //this is the item damage
            item.melee = true;
            item.noMelee = true;
            item.width = 46;
            item.height = 48;
            item.useTime = 15;       //this is how fast you use the item
            item.useAnimation = 30;   //this is how fast the animation when the item is used
            item.useStyle = 5;
            item.scale = 1.3f;
            item.knockBack = 6;
            item.value = 10;
            item.rare = 3;
            item.reuseDelay = 2;    //this is the item delay
            item.autoReuse = true;       //this make the item auto reuse
            item.shoot = mod.ProjectileType("stingy_spear_projectile");  //javelin projectile
            item.shootSpeed = 8f;     //projectile speed
            item.useTurn = true;
            item.maxStack = 1;       //this is the max stack of this item
            item.noUseGraphic = true;

        }
        public override void AddRecipes()  //How to craft this item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(209, 1);
            recipe.AddIngredient(210, 2);
            recipe.AddIngredient(331, 6);
            recipe.AddTile(16);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}