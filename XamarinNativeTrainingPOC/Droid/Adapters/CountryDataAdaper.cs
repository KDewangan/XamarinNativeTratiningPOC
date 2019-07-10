
using System.Collections.Generic;
using Android.Content;
using Android.Net;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Views.Animations;
using Android.Widget;
using Com.Bumptech.Glide;

namespace XamarinNativeTrainingPOC.Droid.Adapters
{
    public class CountryDataAdaper : RecyclerView.Adapter
    {

        Context mContext;
        List<Row> mData;
        List<Row> mDataFiltered;
        bool isDark = false;

        public CountryDataAdaper(Context mContext, List<Row> mData, bool isDark)
        {
            this.mContext = mContext;
            this.mData = mData;
            this.isDark = isDark;
            this.mDataFiltered = mData;
        }

        public CountryDataAdaper(Context mContext, List<Row> mData)
        {
            this.mContext = mContext;
            this.mData = mData;
            this.mDataFiltered = mData;
        }

        public override int ItemCount => mData.Count;

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {

            NewsViewHolder newsViewHolder = holder as NewsViewHolder;
            newsViewHolder.img_user.StartAnimation(AnimationUtils.LoadAnimation(mContext, Resource.Animation.fade_transition_animation));

            newsViewHolder.container.StartAnimation(AnimationUtils.LoadAnimation(mContext, Resource.Animation.fade_scale_animation));

            newsViewHolder.tv_title.SetText(mDataFiltered[position].Title, TextView.BufferType.Normal);
            newsViewHolder.tv_content.SetText(mDataFiltered[position].Description, TextView.BufferType.Normal);
            newsViewHolder.tv_date.SetText(System.DateTime.Today.Date.ToString(), TextView.BufferType.Normal);
            // newsViewHolder.img_user.SetImageURI(Uri.Parse(mDataFiltered[position].imageUri??""));

            int radius = 30; // corner radius, higher value = more rounded
            int margin = 10; // crop margin, set to 0 for corners with no crop
            Glide.With(mContext)
                .Load(mDataFiltered[position]
                .imageUri??"http://via.placeholder.com/300.png")
                //.Transition(TransitionOptions.)
                .Into(newsViewHolder.img_user);
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View layout;
            layout = LayoutInflater.From(mContext).Inflate(Resource.Layout.item_news, parent, false);
            return new NewsViewHolder(layout);
        }


        public class NewsViewHolder : RecyclerView.ViewHolder
        {
            public TextView tv_title, tv_content, tv_date;
            public ImageView img_user;
            public RelativeLayout container;

            public NewsViewHolder(View itemView) : base(itemView)
            {
                container = itemView.FindViewById<RelativeLayout>(Resource.Id.container);
                tv_title = itemView.FindViewById<TextView>(Resource.Id.tv_title);
                tv_content = itemView.FindViewById<TextView>(Resource.Id.tv_description);
                tv_date = itemView.FindViewById<TextView>(Resource.Id.tv_date);
                img_user = itemView.FindViewById<ImageView>(Resource.Id.img_user);
            }

        }

    }
}
