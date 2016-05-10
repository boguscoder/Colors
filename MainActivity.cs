namespace Colors
{
	using Android.App;
	using Android.OS;
	using Android.Support.V7.Widget;

	[Activity(Label = "Colors", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		private string testUrl = "https://gist.githubusercontent.com/jjdelc/1868136/raw/c9160b1e60bd8c10c03dbd1a61b704a8e977c46b/crayola.json";
		protected override async void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.Main);

			ColorsContainer colors = new ColorsContainer();
			await colors.LoadAsync(testUrl);

			var colorList = FindViewById<RecyclerView>(Resource.Id.colorList);
			colorList.SetAdapter(new ColorsAdapter(colors));
			colorList.SetLayoutManager(new LinearLayoutManager(this));
		}
	}
}


