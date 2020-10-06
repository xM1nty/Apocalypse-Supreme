using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ApocalypseSupreme.Items.Materials;
using static Terraria.ModLoader.ModContent;

namespace ApocalypseSupreme.Items.Weapons.Melee
{
	public class SteelSpear : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Steel Spear");
		}

		public override void SetDefaults()
		{
			item.damage = 25;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.useAnimation = 24;
			item.useTime = 30;
			item.knockBack = 6.5f;
			item.width = 44;
			item.height = 48;
			item.scale = 0.8f;
			item.rare = ItemRarityID.Green;
			item.crit = 1;
			item.value = Item.sellPrice(0, 1, 20, 0);
			item.melee = true;
			item.noMelee = true;
			item.autoReuse = false;
			item.UseSound = SoundID.Item1;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemType<SteelBar>(), 15);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}