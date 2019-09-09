using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace jam.Projectiles
{
    public class book_of_shadowflame_skulls_projectile : ModProjectile
    {

        public override void SetDefaults()
        {
            projectile.CloneDefaults(585);
            aiType = 585;
            Main.projFrames[projectile.type] = 4; 

        }
       // public override void AI()
       // {
       //     projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
       // }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit) //When you hit an NPC
        {

            target.AddBuff(153, 510);    //this adds a buff to the npc hit. 210 it the time of the buff

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