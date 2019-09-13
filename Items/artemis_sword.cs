using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace jam.Items
{
    class artemis_sword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Artemis Sword");
            Tooltip.SetDefault("Xiphos of a very passionate hunter");
        }
        public override void SetDefaults()
        {
            item.damage = 38;           //this is the item damage
            item.melee = true;
            item.crit = 47;
            item.width = 38;
            item.height = 38;
            item.useTime = 13;       //this is how fast you use the item
            item.useAnimation = 13;   //this is how fast the animation when the item is used
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = 10;
            item.rare = 3;
            item.reuseDelay = 5;    //this is the item delay
            item.autoReuse = true;       //this make the item auto reuse

        }
    }
}
