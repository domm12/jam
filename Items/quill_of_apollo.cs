using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace jam.Items
{
    public class quill_of_apollo : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Quill of Apollo");
            Tooltip.SetDefault("Makes your enemies 'greedi'");
        }
        public override void SetDefaults()
        {
            item.damage = 17;           //this is the item damage
            item.noMelee = true;
            item.magic = true;
            item.width = 38;
            item.mana = 13;
            item.height = 38;
            item.useTime = 25;       //this is how fast you use the item
            item.useAnimation = 25;   //this is how fast the animation when the item is used
            item.useStyle = 4;
            item.knockBack = 6;
            item.value = 10;
            item.rare = 1;
            item.reuseDelay = 5;    //this is the item delay
            item.autoReuse = false;       //this make the item auto reuse
            item.shoot = mod.ProjectileType("quill_of_apollo_projectile");  //javelin projectile
            item.shootSpeed = 5f;     //projectile speed

        }
        public override void AddRecipes()  //How to craft this item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(13, 10);
            recipe.AddIngredient(320, 1);
            recipe.AddIngredient(1119, 1);
            recipe.AddTile(13);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}