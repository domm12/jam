using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace jam.Projectiles   //The directory for your .cs and .png; Example: TutorialMOD/Projectiles
{
    public class genie_YoYo_projectile : ModProjectile   //make sure the sprite file is named like the class name (CustomYoyoProjectile)
    {
        public override void SetDefaults()
        {
            projectile.extraUpdates = 0;
            projectile.width = 16;//Set the projectile hitbox width
            projectile.height = 16; //Set the projectile hitbox height            
            projectile.aiStyle = 99; // aiStyle 99 is used for all yoyos, and is Extremely suggested, as yoyo are extremely difficult without them
            projectile.friendly = true;  //Tells the game whether it is friendly to players/friendly npcs or not
            projectile.penetrate = -1; //Tells the game how many enemies it can hit before being destroyed. -1 = never
            projectile.melee = true; //Tells the game whether it is a melee projectile or not        
            // The following sets are only applicable to yoyo that use aiStyle 99.
            // YoyosLifeTimeMultiplier is how long in seconds the yoyo will stay out before automatically returning to the player.
            // Vanilla values range from 3f(Wood) to 16f(Chik), and defaults to -1f. Leaving as -1 will make the time infinite.
            ProjectileID.Sets.YoyosLifeTimeMultiplier[projectile.type] = 9f;
            // YoyosMaximumRange is the maximum distance the yoyo sleep away from the player.
            // Vanilla values range from 130f(Wood) to 400f(Terrarian), and defaults to 200f
            ProjectileID.Sets.YoyosMaximumRange[projectile.type] = 300f;
            // YoyosTopSpeed is top speed of the yoyo projectile.
            // Vanilla values range from 9f(Wood) to 17.5f(Terrarian), and defaults to 10f
            ProjectileID.Sets.YoyosTopSpeed[projectile.type] = 24f;
        }
        //Add this if you want the yoyo to make dust when used
        public override void AI()
        {
            if (Main.rand.Next(2) == 0) // this is how many duspt particles will spawn
            {// DustID.Fire is a vanilla terrraria dust, change it to what you like. To add a modded dust the change DustID.Fire with mod.DustType("DustName")
                Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 41, projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);
            }
        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit) //When you hit an NPC
        {
            if (Main.rand.Next(6) == 1)
            {
                target.AddBuff(39, 200);   //this make so when the projectile/flame hit a npc, gives it the buff  onfire , 80 = 3 seconds
            }
            if (Main.rand.Next(5) == 2)
            {
                target.AddBuff(20, 150);   //this make so when the projectile/flame hit a npc, gives it the buff  onfire , 80 = 3 seconds
            }
            if (Main.rand.Next(3) == 3)
            {
                target.AddBuff(32, 150);   //this make so when the projectile/flame hit a npc, gives it the buff  onfire , 80 = 3 seconds
            }
        }


    }
}