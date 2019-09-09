using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace jam.Items         //The directory for your .cs and .png; Example: Mod Sources/TutorialMOD/Items
{
    public class crystallic_sword : ModItem
    {
        public override void SetDefaults()
        {
            item.damage = 24;     //The damage stat for the Weapon.
            item.melee = true;      //This defines if it does Melee damage and if its effected by Melee increasing Armor/Accessories.
            item.width = 40;   //The size of the width of the hitbox in pixels.
            item.height = 40;  //The size of the height of the hitbox in pixels.
            item.useTime = 20;   //How fast the Weapon is used.
            item.useAnimation = 20;     //How long the Weapon is used for.
            item.useStyle = 1;            //The way your Weapon will be used, 1 is the regular sword swing for example
            item.knockBack = 6;  //The knockback stat of your Weapon.
            item.value = Item.buyPrice(0, 5, 0, 0); // How much the item is worth, in copper coins, when you sell it to a merchant. It costs 1/5th of this to buy it back from them. An easy way to remember the value is platinum, gold, silver, copper or PPGGSSCC (so this item price is 10gold)
            item.rare = 2;    //The color the title of your Weapon when hovering over it ingame
            item.UseSound = SoundID.Item1;   //The sound played when using your Weapon
            item.autoReuse = false; //Weather your Weapon will be used again after use while holding down, if false you will need to click again after use to use it again.
        }

        public override void AddRecipes()
        {                                        //this is how to craft this item
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MeteoriteBar, 2);
            recipe.AddIngredient(ItemID.Diamond, 3);
            recipe.AddIngredient(ItemID.Emerald, 3);
            recipe.AddIngredient(ItemID.Ruby, 2); //this is how to add an ingredient from Terraria,  so for crafting this item you need 10 Dirt Block        
            recipe.AddTile(16);  //this is where to craft the item ,WorkBenches = all WorkBenches    Anvils = all anvils , MythrilAnvil = Mythril Anvil and Orichalcum Anvil, Furnaces = all furnaces , DemonAltar = Demon Altar and Crimson Altar , TinkerersWorkbench = Tinkerer's Workbench
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}