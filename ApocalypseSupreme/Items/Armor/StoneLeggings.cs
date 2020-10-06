using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ApocalypseSupreme.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class StoneLeggings : ModItem
	{
		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("Stone Leggings");
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 20;
			item.value = Item.sellPrice(0, 0, 30, 0);
			item.rare = ItemRarityID.White;
			item.defense = 2;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.StoneBlock, 15);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}