using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace jam.Items
{
    public class light_shuriken : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Shuriken of Light");
            Tooltip.SetDefault("Shuriken made from light itself");
        }
        public override void SetDefaults()
        {
            item.damage = 150;           //this is the item damage
            item.thrown = true;             //this make the item do throwing damage
            item.noMelee = true;
            item.width = 38;
            item.height = 38;
            item.useTime = 15;       //this is how fast you use the item
            item.useAnimation = 30;   //this is how fast the animation when the item is used
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = 10;
            item.rare = 10;
            item.reuseDelay = 2;    //this is the item delay
            item.autoReuse = true;       //this make the item auto reuse
            item.shoot = mod.ProjectileType("light_shuriken_projectile");  //javelin projectile
            item.shootSpeed = 8f;     //projectile speed
            item.useTurn = true;
            item.maxStack = 1;       //this is the max stack of this item
            item.consumable = false;  //this make the item consumable when used
            item.noUseGraphic = true;

        }
        public override void AddRecipes()  //How to craft this item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(3458, 18);
            recipe.AddTile(412);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}