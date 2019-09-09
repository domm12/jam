using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace jam.Items
{
    public class joker : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Joker");
            Tooltip.SetDefault("");
        }
        public override void SetDefaults()
        {
            item.damage = 20;           //this is the item damage
            item.thrown = true;             //this make the item do throwing damage
            item.noMelee = true;
            item.width = 38;
            item.height = 38;
            item.useTime = 30;       //this is how fast you use the item
            item.useAnimation = 30;   //this is how fast the animation when the item is used
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = 10;
            item.rare = 8;
            item.reuseDelay = 2;    //this is the item delay
            item.autoReuse = true;       //this make the item auto reuse
            item.shoot = mod.ProjectileType("joker_projectile");  //javelin projectile
            item.shootSpeed = 8f;     //projectile speed
            item.useTurn = true;
            item.maxStack = 1;       //this is the max stack of this item
            item.consumable = true;  //this make the item consumable when used
            item.noUseGraphic = true;

        }
        public override void AddRecipes()  //How to craft this item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(547, 3);
            recipe.AddIngredient(3261, 5);
            recipe.AddIngredient(521, 3);
            recipe.AddTile(26);
            recipe.SetResult(this,50);
            recipe.AddRecipe();
        }
    }
}