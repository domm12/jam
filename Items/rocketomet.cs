using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace jam.Items
{
    public class rocketomet : ModItem
    {
        public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("S. M. B");
            Tooltip.SetDefault("Left click fires a fast and strong missile; right click fires a weaker, slower, but homing missile");
		}
        public override void SetDefaults()
        {
            item.damage = 40;
            item.ranged = true;
            item.width = 70;
            item.height = 28;
            item.useTime = 30; //
            item.useAnimation = 30; //
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 4;
            item.value = 10000;
            item.rare = 11;
            item.reuseDelay = 10;
            item.autoReuse = false;
            item.shoot = mod.ProjectileType("rms");
            item.shootSpeed = 12f;
            item.useAmmo = 771;
        }
        public override bool AltFunctionUse(Player player)
        {
            return true;
        }
        public override void AddRecipes()  //How to craft this item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(324, 1);
            recipe.AddIngredient(3467, 10);
            recipe.AddIngredient(759, 1);
            recipe.AddIngredient(3456, 15);
            recipe.AddTile(16);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2)     //2 is right click
            {

                item.damage = 30;
                item.ranged = true;
                item.width = 70;
                item.height = 28;
                item.useTime = 20; //
                item.useAnimation = 20; //
                item.useStyle = 5;
                item.noMelee = true;
                item.knockBack = 4;
                item.value = 10000;
                item.rare = 2;
                item.reuseDelay = 10;
                item.autoReuse = true;
                item.shoot = mod.ProjectileType("sms");
                item.shootSpeed = 6f;
                item.useAmmo = 771;
            }
            else
            {

                item.damage = 120;
                item.ranged = true;
                item.width = 70;
                item.height = 28;
                item.useTime = 30; //
                item.useAnimation = 30; //
                item.useStyle = 5;
                item.noMelee = true;
                item.knockBack = 4;
                item.value = 10000;
                item.rare = 2;
                item.reuseDelay = 30;
                item.autoReuse = false;
                item.shoot = mod.ProjectileType("rms");
                item.shootSpeed = 12f;
                item.useAmmo = 771;
            }
            return base.CanUseItem(player);
        }
    }
}