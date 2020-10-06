using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ApocalypseSupreme.Items.Weapons.Range
{
	public class StoneBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Stone Bow");
		}

		public override void SetDefaults()
		{
			item.damage = 8;
			item.ranged = true;
			item.width = 20;
			item.height = 48;
			item.useTime = 16;
			item.useAnimation = 16;
			item.crit = 0;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.knockBack = 4;
			item.value = Item.sellPrice(0, 0, 60, 0);
			item.rare = ItemRarityID.Blue;
			item.UseSound = SoundID.Item5;
			item.autoReuse = false;
			item.shoot = ProjectileID.WoodenArrowFriendly;
			item.shootSpeed = 8f;
			item.useAmmo = AmmoID.Arrow;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.StoneBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}