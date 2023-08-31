using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrap_mechanic_ROM_builder__BIN_2_ROM_;

internal static class ScrapReference
{
	public readonly static RomBlueprint.Dependency ModPackDependency = new RomBlueprint.Dependency
	{
		ContentId = "b7443f95-67b7-4f1e-82f4-9bef0c62c4b3",
		Name = "The Modpack Continuation",
		ShapeIds = new List<string>
		{
			"289e08ef-e3d8-4f1b-bc10-a0bcf36fa0ce",
			"d8296109-2ffb-4efb-819a-54bd8cadf549",
			"efbd14a8-f896-4268-a273-b2b382db520c"
		},
		SteamFileId = 2448492759
	};

	public static class Color 
	{
		//White Column
		public static readonly System.Drawing.Color White = ColorTranslator.FromHtml("#EEEEEE");
		public static readonly System.Drawing.Color LightGrey = ColorTranslator.FromHtml("#7F7F7F");
		public static readonly System.Drawing.Color DarkGrey = ColorTranslator.FromHtml("#4A4A4A");
		public static readonly System.Drawing.Color Black = ColorTranslator.FromHtml("#222222");

		//Yellow Column
		public static readonly System.Drawing.Color LightYellow = ColorTranslator.FromHtml("#F5F071");
		public static readonly System.Drawing.Color Yellow = ColorTranslator.FromHtml("#E2DB13");
		public static readonly System.Drawing.Color DarkYellow = ColorTranslator.FromHtml("#817C00");
		public static readonly System.Drawing.Color VeryDarkYellow = ColorTranslator.FromHtml("#323000");

		//Piss Column
		public static readonly System.Drawing.Color LightPiss = ColorTranslator.FromHtml("#CBF66F");
		public static readonly System.Drawing.Color Piss = ColorTranslator.FromHtml("#A0EA00");
		public static readonly System.Drawing.Color DarkPiss = ColorTranslator.FromHtml("#577D07");
		public static readonly System.Drawing.Color VeryDarkPiss = ColorTranslator.FromHtml("#375000");

		//Green Column
		public static readonly System.Drawing.Color LightGreen = ColorTranslator.FromHtml("#68FF88");
		public static readonly System.Drawing.Color Green = ColorTranslator.FromHtml("#19E753");
		public static readonly System.Drawing.Color DarkGreen = ColorTranslator.FromHtml("#0E8031");
		public static readonly System.Drawing.Color VeryDarkGreen = ColorTranslator.FromHtml("#064023");

		//Cyan Column
		public static readonly System.Drawing.Color LightCyan = ColorTranslator.FromHtml("#7EEDED");
		public static readonly System.Drawing.Color Cyan = ColorTranslator.FromHtml("#2CE6E6");
		public static readonly System.Drawing.Color DarkCyan = ColorTranslator.FromHtml("#118787");
		public static readonly System.Drawing.Color VeryDarkCyan = ColorTranslator.FromHtml("#0A4444");

		//Blue Column
		public static readonly System.Drawing.Color LightBlue = ColorTranslator.FromHtml("#4C6FE3");
		public static readonly System.Drawing.Color Blue = ColorTranslator.FromHtml("#0A3EE2");
		public static readonly System.Drawing.Color DarkBlue = ColorTranslator.FromHtml("#0F2E91");
		public static readonly System.Drawing.Color VeryDarkBlue = ColorTranslator.FromHtml("#0A1D5A");

		//Purple Column
		public static readonly System.Drawing.Color LightPurple = ColorTranslator.FromHtml("#AE79F0");
		public static readonly System.Drawing.Color Purple = ColorTranslator.FromHtml("#7514ED");
		public static readonly System.Drawing.Color DarkPurple = ColorTranslator.FromHtml("#500AA6");
		public static readonly System.Drawing.Color VeryDarkPurple = ColorTranslator.FromHtml("#35086C");

		//Pink Column
		public static readonly System.Drawing.Color LightPink = ColorTranslator.FromHtml("#EE7BFO");
		public static readonly System.Drawing.Color Pink = ColorTranslator.FromHtml("#CF11D2");
		public static readonly System.Drawing.Color DarkPink = ColorTranslator.FromHtml("#720A74");
		public static readonly System.Drawing.Color VeryDarkPink = ColorTranslator.FromHtml("#520653");

		//Red Column
		public static readonly System.Drawing.Color LightRed = ColorTranslator.FromHtml("#F06767");
		public static readonly System.Drawing.Color Red = ColorTranslator.FromHtml("#D02525");
		public static readonly System.Drawing.Color DarkRed = ColorTranslator.FromHtml("#7C0000");
		public static readonly System.Drawing.Color VeryDarkRed = ColorTranslator.FromHtml("#560202");

		//Orange Column
		public static readonly System.Drawing.Color LightOrange = ColorTranslator.FromHtml("#EEAF5C");
		public static readonly System.Drawing.Color Orange = ColorTranslator.FromHtml("#DF7F00");
		public static readonly System.Drawing.Color Brown = ColorTranslator.FromHtml("#673B00");
		public static readonly System.Drawing.Color DarkBrown = ColorTranslator.FromHtml("#472800");
	}

	public static class Block 
	{
		public const string MathBlockUUID = "289e08ef-e3d8-4f1b-bc10-a0bcf36fa0ce";
		public const string NumberBlockUUID = "efbd14a8-f896-4268-a273-b2b382db520c";
		public const string CounterUUID = "d8296109-2ffb-4efb-819a-54bd8cadf549";
	}

}
