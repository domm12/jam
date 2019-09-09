using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace jam.Items
{
    public class bam : ModItem
    {
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("bam");
			Tooltip.SetDefault("It's a red jam.");
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
            item.buffType = 13;
            item.buffTime = 1800;
            item.value = 500;//item is the buff duration   
            return;
        }
        public override void AddRecipes()   //������ ��������
        {
            ModRecipe recipe = new ModRecipe(mod);  //������ ����� ������
            recipe.AddIngredient(23, 10);  //��������� �����������
            recipe.AddIngredient(1111, 1);  //��������� �����������
            recipe.AddTile(TileID.WorkBenches);       // �� ��� ������� ���������
            recipe.SetResult(this, 15);             //��������� ������
            recipe.AddRecipe();              //����������� ������
        }
    }
}