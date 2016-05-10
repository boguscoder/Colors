namespace Colors
{
	using Android.Support.V7.Widget;
	using Android.Views;
	using Android.Widget;

	public class ColorsViewHolder : RecyclerView.ViewHolder
	{
		public RelativeLayout Bkg { get; private set; }
		public TextView Title { get; private set; }

		public ColorsViewHolder(View itemView) : base(itemView)
		{
			Bkg = itemView.FindViewById<RelativeLayout>(Resource.Id.color);
			Title = itemView.FindViewById<TextView>(Resource.Id.colorName);
		}
	}
}

