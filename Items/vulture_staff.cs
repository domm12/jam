using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace jam.Items
{
    public class vulture_staff : ModItem
    {
        public override void SetDefaults()
        {
            item.CloneDefaults(1802);
            item.shoot = mod.ProjectileType("vulture_summon");
            item.buffType = mod.BuffType("vulture_buff");
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 1);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}