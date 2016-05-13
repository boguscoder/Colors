namespace Colors
{
	using System;

	using Newtonsoft.Json;

	public class Color
	{
		[JsonProperty(PropertyName = "name")]
		public String Name { get; set; }

		[JsonProperty(PropertyName = "hex")]
		public String HexString { get; set; }

		[JsonIgnore]
		public Android.Graphics.Color AndroidColor => Android.Graphics.Color.ParseColor(HexString);
	}
}

