using Terraria.ModLoader;
using Terraria.ID;

namespace LegendOfWaterbolt
{
	public class LegendOfWaterbolt : Mod
	{
		public LegendOfWaterbolt()
		{
		}
		public override void AddRecipes()
		{
			ModRecipe waterbolt = new ModRecipe(this);
			waterbolt.AddIngredient(ItemID.Book, 2);
			waterbolt.AddIngredient(ItemID.Obsidian, 4);
			waterbolt.AddIngredient(ItemID.EbonstoneBlock, 12);
			waterbolt.AddIngredient(ItemID.BottledWater, 1);
			waterbolt.AddTile(TileID.Bookcases);
			waterbolt.AddTile(this.GetTile("WaterBoltPedestal"));
			waterbolt.SetResult(ItemID.WaterBolt);
			waterbolt.AddRecipe();
			waterbolt = new ModRecipe(this);
			waterbolt.AddIngredient(ItemID.Book, 2);
			waterbolt.AddIngredient(ItemID.Obsidian, 4);
			waterbolt.AddIngredient(ItemID.CrimstoneBlock, 12);
			waterbolt.AddIngredient(ItemID.BottledWater, 1);
			waterbolt.AddTile(TileID.Bookcases);
			waterbolt.AddTile(this.GetTile("WaterBoltPedestal"));
			waterbolt.SetResult(ItemID.WaterBolt);
			waterbolt.AddRecipe();
		}
	}
}
