using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ApocalypseSupreme.Items.Materials;
using static Terraria.ModLoader.ModContent;

namespace ApocalypseSupreme.Items.Weapons.Melee
{
	public class SteelSaber : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Steel Saber"); 
		}

		public override void SetDefaults()
		{
			item.damage = 13;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 10;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = Item.buyPrice(gold: 1); ;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
		    item.autoReuse = false;
	    }
            
	     public override void AddRecipes()
		 {
			 ModRecipe recipe = new ModRecipe(mod);
			 recipe.AddIngredient(ItemType<SteelBar>(), 10);
			 recipe.AddTile(TileID.Anvils);
			 recipe.SetResult(this);
			 recipe.AddRecipe();
		 }
	}
}