namespace AssetRipper.CLI.Web.Pages;

internal abstract class AccordianItem
{
	public virtual string? Name => null;
	public abstract void Write(TextWriter writer);
}
