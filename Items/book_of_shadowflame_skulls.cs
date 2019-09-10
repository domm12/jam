using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace jam.Items
{
    public class book_of_shadowflame_skulls : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Book of Shadowflame Skulls");
            Tooltip.SetDefault("Shoots a shadowflame skull");
        }
        public override void SetDefaults()
        {
            item.damage = 17;           //this is the item damage
            item.noMelee = true;
            item.magic = true;
            item.width = 38;
            item.mana = 13;
            item.height = 38;
            item.useTime = 25;       //this is how fast you use the item
            item.useAnimation = 25;   //this is how fast the animation when the item is used
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = 10;
            item.rare = 3;
            item.reuseDelay = 5;    //this is the item delay
            item.autoReuse = false;       //this make the item auto reuse
            item.shoot = mod.ProjectileType("book_of_shadowflame_skulls_projectile");  //javelin projectile
            item.shootSpeed = 9f;     //projectile speed

        }
    }
}
