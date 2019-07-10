using System;
using System.Collections.Generic;
using Android.Content;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Views.Animations;
using Android.Widget;
using Java.Lang;

namespace XamarinNativeTrainingPOC.Droid.Adapters
{
    public class NewsAdapter : RecyclerView.Adapter
    {

        Context mContext;
        List<NewsItem> mData;
        List<NewsItem> mDataFiltered;
        bool isDark = false;

        public NewsAdapter(Context mContext, List<NewsItem> mData, bool isDark)
        {
            this.mContext = mContext;
            this.mData = mData;
            this.isDark = isDark;
            this.mDataFiltered = mData;
        }

        public NewsAdapter(Context mContext, List<NewsItem> mData)
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

            
            newsViewHolder.tv_title.SetText( mDataFiltered[position].Title, TextView.BufferType.Normal);
            newsViewHolder.tv_content.SetText(mDataFiltered[position].Content, TextView.BufferType.Normal);
            newsViewHolder.tv_date.SetText(mDataFiltered[position].Date, TextView.BufferType.Normal);
            newsViewHolder.img_user.SetImageResource(mDataFiltered[position].UserPhoto);
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View layout;
            layout = LayoutInflater.From(mContext).Inflate(Resource.Layout.item_news, parent, false);
            return new NewsViewHolder(layout);
        }


        public class NewsViewHolder : RecyclerView.ViewHolder
        {
           public  TextView tv_title, tv_content, tv_date;
           public ImageView img_user;
           public RelativeLayout container;

            public NewsViewHolder(View itemView) : base(itemView)
            {
                container = itemView.FindViewById<RelativeLayout >(Resource.Id.container);
                tv_title = itemView.FindViewById<TextView>(Resource.Id.tv_title);
                tv_content = itemView.FindViewById<TextView>(Resource.Id.tv_description);
                tv_date = itemView.FindViewById<TextView>(Resource.Id.tv_date);
                img_user = itemView.FindViewById<ImageView>(Resource.Id.img_user);
            }

        }
        
    }
}

