using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace jam.Projectiles
{
    public class chlorophyte_stylet_projectile : ModProjectile
    {

        public override void SetDefaults()
        {
            projectile.CloneDefaults(207);
            aiType = 207;
        }
        public override void AI()
        {
            projectile.ai[0] += 1f;
            if (projectile.ai[0] >= 130f)       //how much time the projectile can travel before landing
            {
                projectile.velocity.Y = projectile.velocity.Y + 0.15f;    // projectile fall velocity
                projectile.velocity.X = projectile.velocity.X * 0.99f;    // projectile velocity
            }
        }
    }
}