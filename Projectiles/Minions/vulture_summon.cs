using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace jam.Projectiles.Minions
{
    public class vulture_summon : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.CloneDefaults(317);
            aiType =317;
            projectile.tileCollide = false;
            Main.projFrames[projectile.type] = 4; 
        }
        public override bool PreKill(int timeLeft)
        {
            projectile.type = 317;
            return true;
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