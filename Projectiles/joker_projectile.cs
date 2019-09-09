using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace jam.Projectiles
{
    public class joker_projectile : ModProjectile
    {

        public override void SetDefaults()
        {
            projectile.width = 38;
            projectile.height = 38;
            projectile.friendly = true;
            projectile.thrown = true;
            projectile.penetrate = 1;      //this is how many enemy this projectile penetrate before desapear
            projectile.extraUpdates = 1;
            projectile.timeLeft = 200;
            projectile.light = 0.5f;
            projectile.tileCollide = true;
            Main.projFrames[projectile.type] = 13; 
        }
        public override void AI()
        {
            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X);//+ 1.57f;
            if (Main.rand.Next(2) == 0) // this is how many duspt particles will spawn
            {// DustID.Fire is a vanilla terrraria dust, change it to what you like. To add a modded dust the change DustID.Fire with mod.DustType("DustName")
                Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 65, projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);
            }
        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(39, 80);
            //Projectile.NewProjectile(projectile.position.X, projectile.position.Y, 0, 0, ProjectileID.DeathSickle, (int)(projectile.damage * 1.5), projectile.knockBack, Main.myPlayer); // This spawns a projectile after this projectile is dead
        }
        public override void Kill(int timeLeft)
        {

            Projectile.NewProjectile(projectile.position.X, projectile.position.Y, 0, 0, ProjectileID.DeathSickle, (int)(70), projectile.knockBack, Main.myPlayer); // This spawns a projectile after this projectile is dead

        }
        public override bool PreDraw(SpriteBatch sb, Color lightColor) //this is where the animation happens
        {
            projectile.frameCounter++; //increase the frameCounter by one
            if (projectile.frameCounter >= 15) //once the frameCounter has reached 10 - change the 10 to change how fast the projectile animates
            {
                projectile.frame++; //go to the next frame
                projectile.frameCounter = 0; //reset the counter
                if (projectile.frame > 3) //if past the last frame
                    projectile.frame = 0; //go back to the first frame
            }
            return true;
        }
    }
}