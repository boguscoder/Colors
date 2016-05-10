namespace Colors
{
	using System.Threading.Tasks;
	using Android.App;
	using Android.OS;
	using Android.Support.V7.Widget;
	using Android.Widget;

	[Activity(Label = "Colors", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		private string testUrl = "https://gist.githubusercontent.com/jjdelc/1868136/raw/c9160b1e60bd8c10c03dbd1a61b704a8e977c46b/crayola.json";

		protected override async void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.Main);
			await InitViewsAsync();
		}

		async Task InitViewsAsync()
		{
			var progressView = FindViewById<TextView>(Resource.Id.progress);

			ColorsContainer colors = new ColorsContainer();
			await colors.LoadAsync(testUrl,
			   (string info) =>
				{
					// in case of ConfigureAwait(false) 
					RunOnUiThread(() => progressView.Text = info);
				}
			);

			progressView.Visibility = Android.Views.ViewStates.Gone;

			var colorList = FindViewById<RecyclerView>(Resource.Id.colorList);
			colorList.SetAdapter(new ColorsAdapter(colors));
			colorList.SetLayoutManager(new LinearLayoutManager(this));
		}
	}
}


