using System;
namespace Colors
{
	public static class Extensions
	{
		public static Android.Graphics.Color Invert(this Android.Graphics.Color color)
		{
			return new Android.Graphics.Color(255 - color.R, 255 - color.G, 255 - color.B);
		}
	}
}

