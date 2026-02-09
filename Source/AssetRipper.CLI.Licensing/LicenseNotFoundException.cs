namespace AssetRipper.CLI.Licensing;

public sealed class LicenseNotFoundException : Exception
{
	public LicenseNotFoundException(string fileName) : base($"Could not find license file {fileName}.md")
	{
	}
}
