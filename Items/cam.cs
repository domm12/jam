using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace jam.Items
{
    public class cam : ModItem
    {
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cam");
			Tooltip.SetDefault("It's a cyanic jam.");
		}
        public override void SetDefaults()
        {
            item.useStyle = 2;
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.maxStack = 100;
            item.consumable = true;
            item.width = 14;
            item.height = 24;
            item.rare = 1;
            item.potion = true;
            item.buffType = 109;
            item.buffTime = 1800;
            item.value = 500;//item is the buff duration      //this is the buff duration        20000 = 6 min
            return;
        }
        public override void AddRecipes()   //ðåöåïò ïðåäìåòà
        {
            ModRecipe recipe = new ModRecipe(mod);  //Ñîçäà¸ì íîâûé ðåöåïò
            recipe.AddIngredient(23, 10);  //Äîáàâëÿåì èíãðåäèåíòû
            recipe.AddIngredient(1116, 1);  //Äîáàâëÿåì èíãðåäèåíòû
            recipe.AddTile(TileID.WorkBenches);       // Íà ÷¸ì ïðåäìåò êðàôòèòñÿ
            recipe.SetResult(this, 10);             //ðåçóëüòàò êðàôòà
            recipe.AddRecipe();              //Çàêàí÷èâàåì ðåöåïò
        }
    }
}
