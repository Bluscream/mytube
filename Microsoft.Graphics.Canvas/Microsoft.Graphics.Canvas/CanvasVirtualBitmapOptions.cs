using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas
{
	[ComImport]
	[Version(167772160u)]
	public enum CanvasVirtualBitmapOptions
	{
		None,
		ReleaseSource,
		CacheOnDemand
	}
}
