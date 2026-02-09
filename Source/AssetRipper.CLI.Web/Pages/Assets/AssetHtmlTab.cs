using AssetRipper.Assets;

namespace AssetRipper.CLI.Web.Pages.Assets;

internal abstract class AssetHtmlTab(IUnityObjectBase asset) : HtmlTab
{
	public IUnityObjectBase Asset { get; } = asset;
}
