using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace jam.Projectiles
{
    public class stingy_spear_projectile : ModProjectile
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Spear");
		}

		public override void SetDefaults() {
            projectile.CloneDefaults(49);
            aiType = 49;
		}
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            if (Main.rand.Next(3) == 1)
            {
                target.AddBuff(20, 80);   //this make so when the projectile/flame hit a npc, gives it the buff  onfire , 80 = 3 seconds
            }
            
        }
    }
}