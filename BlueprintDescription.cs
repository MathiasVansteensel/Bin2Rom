public class BlueprintDescription
{
	const string DefaultDescription = "A ROM generated to contain a bin file.\n\nINPUT: (white) Address\nOUTPUT: (yellow) Value at address";
	public string Description { get; set; } = DefaultDescription;
	public string LocalId { get; set; }
	public string Name { get; set; }
	public string Type { get; set; } = "Blueprint";
	public int Version { get; set; } = 0;
}
