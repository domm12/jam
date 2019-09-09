using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace jam.Items
{
    public class hallowed_bow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hallowed Bow");
            Tooltip.SetDefault("Turns arrows into holy arrows");
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
            item.knockBack = 7;
            item.value = 10000;
            item.rare = 2;
            item.reuseDelay = 15;
            item.autoReuse = false;
            item.shoot = 91;
            item.shootSpeed = 8f;
            item.useAmmo = 40;
            item.UseSound = SoundID.Item1;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(1225, 12);
            recipe.AddTile(134);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY,ref int type,ref int damage,ref float knockBack)
        {
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, 91, damage, knockBack, player.whoAmI,0f,0f);
            return false;
        }
    }
}