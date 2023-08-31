using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Drawing;

public class HexColorConverter : JsonConverter<Color>
{
	public override Color Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		string hexColor = reader.GetString();
		if ((hexColor.Length == 7 || hexColor.Length == 4)) // Validate format
		{
			if (int.TryParse(hexColor.Substring(0), System.Globalization.NumberStyles.HexNumber, null, out int colorValue))
			{
				byte r, g, b;

				if (hexColor.Length == 7) // Full hex color code
				{
					r = (byte)((colorValue >> 16) & 0xFF);
					g = (byte)((colorValue >> 8) & 0xFF);
					b = (byte)(colorValue & 0xFF);
				}
				else // Short hex color code (#FFF or #000)
				{
					r = (byte)(((colorValue >> 8) & 0xF) * 17);
					g = (byte)(((colorValue >> 4) & 0xF) * 17);
					b = (byte)((colorValue & 0xF) * 17);
				}

				return Color.FromArgb(r, g, b);
			}
		}
		throw new JsonException("Invalid color format.");
	}

	public override void Write(Utf8JsonWriter writer, Color value, JsonSerializerOptions options)
	{
		string hexColor = $"{value.R:X2}{value.G:X2}{value.B:X2}";
		writer.WriteStringValue(hexColor);
	}
}
