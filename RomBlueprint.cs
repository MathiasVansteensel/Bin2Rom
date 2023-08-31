// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
using Scrap_mechanic_ROM_builder__BIN_2_ROM_;
using System.Text.Json.Serialization;
public class RomBlueprint
{
	[JsonPropertyName("bodies")]
	public List<Body> Bodies { get; set; } = new();

	[JsonPropertyName("dependencies")]
	public List<Dependency> Dependencies { get; set; } = new();

	[JsonPropertyName("version")]
	public int Version { get; set; } = 4;

	public class Body
	{
		[JsonPropertyName("childs")]
		public List<Child> Childs { get; set; } = new();
	}

	public class Child
	{
		[JsonConverter(typeof(HexColorConverter))]
		[JsonPropertyName("color")]
		public Color Color { get; set; }

		[JsonPropertyName("controller")]
		public Controller Controller { get; set; } = new();

		[JsonPropertyName("pos")]
		public Pos Pos { get; set; } = new();

		[JsonPropertyName("shapeId")]
		public string ShapeId { get; set; }

		[JsonPropertyName("xaxis")]
		public int Xaxis { get; set; }

		[JsonPropertyName("zaxis")]
		public int Zaxis { get; set; }
	}

	public class Controller
	{
		[JsonPropertyName("containers")]
		public object Containers { get; set; } = null;

		[JsonPropertyName("controllers")]
		public List<ControllerId> Controllers { get; set; } = new();

		[JsonPropertyName("data")]
		public string Data { get; set; }

		[JsonPropertyName("id")]
		public int Id { get; set; }

		[JsonPropertyName("joints")]
		public object Joints { get; set; } = null;
	}

	public class ControllerId
	{
		[JsonPropertyName("id")]
		public int Id { get; set; }
	}

	public class Dependency
	{
		[JsonPropertyName("contentId")]
		public string ContentId { get; set; }

		[JsonPropertyName("name")]
		public string Name { get; set; }

		[JsonPropertyName("shapeIds")]
		public List<string> ShapeIds { get; set; } = new();

		[JsonPropertyName("steamFileId")]
		public long SteamFileId { get; set; }
	}

	public class Pos
	{
		[JsonPropertyName("x")]
		public int X { get; set; }

		[JsonPropertyName("y")]
		public int Y { get; set; }

		[JsonPropertyName("z")]
		public int Z { get; set; }

		public static implicit operator Pos(Vector3I vector) => new Pos { X = vector.X, Y = vector.Y, Z = vector.Z };
	}
}

