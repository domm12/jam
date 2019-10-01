using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace jam.Projectiles
{
    class spectral_knife_wavy_projectile : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 16;
            projectile.height = 16;
            projectile.friendly = true;
            projectile.thrown = true;
            projectile.penetrate = 1;      //this is how many enemy this projectile penetrate before desapear
            projectile.extraUpdates = 1;
            projectile.timeLeft = 400;
            projectile.light = 1f;
            projectile.tileCollide = false;
        }
        public override void AI()
        {
            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit) //When you hit an NPC
        { 

            Projectile.NewProjectile(projectile.position.X + 70f, projectile.position.Y, -6, 2, mod.ProjectileType("spectral_knife_projectile"), (int)(20), projectile.knockBack, Main.myPlayer);

            Projectile.NewProjectile(projectile.position.X + 70f, projectile.position.Y, -6, -2, mod.ProjectileType("spectral_knife_projectile"), (int)(20), projectile.knockBack, Main.myPlayer);

            projectile.Kill();
        }
    }
}
