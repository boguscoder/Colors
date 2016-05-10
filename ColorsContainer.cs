namespace Colors
{
	using System;
	using System.Net.Http;
	using System.Collections.Generic;
	using System.Threading.Tasks;
	using Newtonsoft.Json;

	public class ColorsContainer
	{
		List<Color> _colors;

		public int Size
		{
			get
			{
				return _colors?.Count ?? 0;
			}
		}

		public Color this[int idx]
		{
			get
			{
				return _colors?[idx] ?? null;
			}
		}

		public async Task LoadAsync(String url, Action<String> progressReporter = null)
		{
			progressReporter?.Invoke("Initializing...");
			var http = new HttpClient();

			progressReporter?.Invoke("Downloading...");
			var rawJson = await http.GetStringAsync(url).ConfigureAwait(false);

			progressReporter?.Invoke("Unpacking...");
			_colors = JsonConvert.DeserializeObject<List<Color>>(rawJson);
		}
	}
}

