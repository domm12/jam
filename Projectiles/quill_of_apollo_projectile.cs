using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace jam.Projectiles
{
    public class quill_of_apollo_projectile : ModProjectile
    {

        public override void SetDefaults()
        {
            projectile.width = 16;
            projectile.height = 16;
            projectile.friendly = true;
            projectile.thrown = true;
            projectile.penetrate = 2;      //this is how many enemy this projectile penetrate before desapear
            projectile.extraUpdates = 1;
            projectile.timeLeft = 200;
            projectile.light = 0.5f;
            projectile.tileCollide = true;
        }
        public override void AI()
        {
            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
            if (Main.rand.Next(2) == 0) // this is how many duspt particles will spawn
            {// DustID.Fire is a vanilla terrraria dust, change it to what you like. To add a modded dust the change DustID.Fire with mod.DustType("DustName")
                Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 18, projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);
            }
        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit) //When you hit an NPC
        {

            target.AddBuff(72, 510);    //this adds a buff to the npc hit. 210 it the time of the buff

        }
    }
}