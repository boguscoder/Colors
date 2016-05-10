namespace Colors
{
	using Android.Support.V7.Widget;
	using Android.Views;

	public class ColorsAdapter : RecyclerView.Adapter
	{
		ColorsContainer _container;

		public ColorsAdapter(ColorsContainer container)
		{
			_container = container;
		}

		public override int ItemCount
		{
			get
			{
				return _container.Size;
			}
		}

		public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
		{
			var colorHolder = holder as ColorsViewHolder;

			colorHolder.Bkg.SetBackgroundColor(_container[position].AndroidColor);
			colorHolder.Title.Text = _container[position].Name;
			colorHolder.Title.SetTextColor(_container[position].AndroidColor.Invert());
		}

		public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
		{
			View itemView = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.ColorView, parent, false);
			return new ColorsViewHolder(itemView);
		}
	}
}

