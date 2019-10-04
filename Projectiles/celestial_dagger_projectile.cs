using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace jam.Projectiles
{
    public class celestial_dagger_projectile : ModProjectile
    {

        public override void SetDefaults()
        {
            projectile.width = 16;
            projectile.height = 16;
            projectile.friendly = true;
            projectile.thrown = true;
            projectile.penetrate = 1;      //this is how many enemy this projectile penetrate before desapear
            projectile.extraUpdates = 1;
            projectile.timeLeft = 200;
            projectile.light = 1f;
            projectile.tileCollide = true;
        }
        public override void AI()
        {
            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
        }
        public override void Kill(int timeLeft)
        {
            int rand = Main.rand.Next(1, 4);
            for (int i = 0; i < rand; i++)
            {
                Projectile.NewProjectile(projectile.position.X+ i * 80, projectile.position.Y - 300f, 0, 8, mod.ProjectileType("HarpFeather"), (int)(20), projectile.knockBack, Main.myPlayer); // This spawns a projectile after this projectile is dead
            }
        }
    }
}