using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace jam.Items     //We need this to basically indicate the folder where it is to be read from, so you the texture will load correctly
{
    [AutoloadEquip(EquipType.Shield)]
    public class wooden_shield : ModItem
    {

        public override void SetDefaults()
        {
            item.width = 24;   //The size in width of the sprite in pixels.
            item.height = 28;    //The size in height of the sprite in pixels.
            item.value = Item.buyPrice(0, 0, 10, 0); //  How much the item is worth, in copper coins, when you sell it to a merchant. It costs 1/5th of this to buy it back from them. An easy way to remember the value is platinum, gold, silver, copper or PPGGSSCC (so this item price is 2 gold)
            item.rare = 1;          //The color the title of your Weapon when hovering over it ingame        
            item.accessory = true;  //this make the item an accessory, so you can equip it
            item.defense = 1;   //this sets the item defense given when equipped

        }


        public override void AddRecipes()
        {                                        //this is how to craft this item
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 12);      //this is how to add an ingredient from Terraria,  so for crafting this item you need 1 Cobalt Shield      
            recipe.AddIngredient(ItemID.IronBar, 2);       //and 4 lifecristals
            recipe.AddTile(TileID.Anvils);  //this is where craft the item ,WorkBenches = all WorkBenches    Anvils = all anvils , MythrilAnvil = Mythril Anvil and Orichalcum Anvil, Furnaces = all furnaces , DemonAltar = Demon Altar and Crimson Altar , TinkerersWorkbench = Tinkerer's Workbench
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}