using System;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Constraints;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using XamarinNativeTrainingPOC.Droid.Adapters;
using XamarinNativeTrainingPOC.ViewModels;

namespace XamarinNativeTrainingPOC.Droid
{
    [Activity(Label = "XamarinNativeTrainingPOC", MainLauncher = true, Icon = "@mipmap/icon", Theme = "@style/AppTheme")]
    public class MainActivity : AppCompatActivity
    {
        public ConadaDataViewModel ConadaDataViewModel { get; set; }
        RecyclerView NewsRecyclerview;
        ConstraintLayout rootLayout;
        FloatingActionButton fabSwitcher;

        CountryDataAdaper countryDataAdaper;

        bool isDark = true;

        EditText searchInput;

        List<Row> RowDataList;

        protected override void OnStart()
        {
            base.OnStart();

        }


        protected async override void OnCreate(Bundle savedInstanceState)
        {
            this.RequestWindowFeature(WindowFeatures.NoTitle);
            base.OnCreate(savedInstanceState);
            try
            {
                ConadaDataViewModel = new ConadaDataViewModel();
                await ConadaDataViewModel.ExecuteLoadItemsCommand();
                RowDataList = new List<Row>(ConadaDataViewModel.Items.CountryData);

                SetContentView(Resource.Layout.Layout1);

                rootLayout = FindViewById<ConstraintLayout>(Resource.Id.root_layout);
                searchInput = FindViewById<EditText>(Resource.Id.search_input);
                NewsRecyclerview = FindViewById<RecyclerView>(Resource.Id.news_rv);
                fabSwitcher = FindViewById<FloatingActionButton>(Resource.Id.fab_switcher);
                fabSwitcher.Clickable = true;
                fabSwitcher.SetOnClickListener(new FabClickLitner(this));

                #region tepmData
                //mData = new List<NewsItem>();
                //mData.Add(new NewsItem("OnePlus 6T Camera Review:", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", "6 july 1994", Resource.Drawable.user));
                //mData.Add(new NewsItem("I love Programming And Design", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam,", "6 july 1994", Resource.Drawable.circul6));
                //mData.Add(new NewsItem("My first trip to Thailand story ", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", "6 july 1994", Resource.Drawable.uservoyager));
                //mData.Add(new NewsItem("After Facebook Messenger, Viber now gets...", "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,", "6 july 1994", Resource.Drawable.usertwo));
                //mData.Add(new NewsItem("Isometric Design Grid Concept", "lorem ipsum dolor sit lorem ipsum dolor sit lorem ipsum dolor sit lorem ipsum dolor sit", "6 july 1994", Resource.Drawable.xamarin_logo));
                //mData.Add(new NewsItem("Android R Design Concept 4K", "lorem ipsum dolor sit lorem ipsum dolor sit lorem ipsum dolor sit lorem ipsum dolor sit lorem ipsum dolor sit lorem ipsum dolor sit lorem ipsum dolor sit lorem ipsum dolor sit lorem ipsum dolor sit lorem ipsum dolor sit lorem ipsum dolor sit lorem ipsum dolor sit lorem ipsum dolor sit lorem ipsum dolor sit lorem ipsum dolor sit ", "6 july 1994", Resource.Drawable.xamarin_logo));
                //mData.Add(new NewsItem("OnePlus 6T Camera Review:", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", "6 july 1994", Resource.Drawable.circul6));
                //mData.Add(new NewsItem("I love Programming And Design", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam,", "6 july 1994", Resource.Drawable.xamarin_logo));
                //mData.Add(new NewsItem("My first trip to Thailand story ", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", "6 july 1994", Resource.Drawable.xamarin_logo));
                //mData.Add(new NewsItem("After Facebook Messenger, Viber now gets...", "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,", "6 july 1994", Resource.Drawable.xamarin_logo));
                //mData.Add(new NewsItem("Isometric Design Grid Concept", "lorem ipsum dolor sit lorem ipsum dolor sit lorem ipsum dolor sit lorem ipsum dolor sit", "6 july 1994", Resource.Drawable.xamarin_logo));
                //mData.Add(new NewsItem("Android R Design Concept 4K", "lorem ipsum dolor sit lorem ipsum dolor sit lorem ipsum dolor sit lorem ipsum dolor sit lorem ipsum dolor sit lorem ipsum dolor sit lorem ipsum dolor sit lorem ipsum dolor sit lorem ipsum dolor sit lorem ipsum dolor sit lorem ipsum dolor sit lorem ipsum dolor sit lorem ipsum dolor sit lorem ipsum dolor sit lorem ipsum dolor sit ", "6 july 1994", Resource.Drawable.xamarin_logo));
                //mData.Add(new NewsItem("OnePlus 6T Camera Review:", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", "6 july 1994", Resource.Drawable.xamarin_logo));
                //mData.Add(new NewsItem("I love Programming And Design", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam,", "6 july 1994", Resource.Drawable.xamarin_logo));
                //mData.Add(new NewsItem("My first trip to Thailand story ", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", "6 july 1994", Resource.Drawable.xamarin_logo));
                //mData.Add(new NewsItem("After Facebook Messenger, Viber now gets...", "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,", "6 july 1994", Resource.Drawable.xamarin_logo));
                //mData.Add(new NewsItem("Isometric Design Grid Concept", "lorem ipsum dolor sit lorem ipsum dolor sit lorem ipsum dolor sit lorem ipsum dolor sit", "6 july 1994", Resource.Drawable.xamarin_logo));
                //mData.Add(new NewsItem("Android R Design Concept 4K", "lorem ipsum dolor sit lorem ipsum dolor sit lorem ipsum dolor sit lorem ipsum dolor sit lorem ipsum dolor sit lorem ipsum dolor sit lorem ipsum dolor sit lorem ipsum dolor sit lorem ipsum dolor sit lorem ipsum dolor sit lorem ipsum dolor sit lorem ipsum dolor sit lorem ipsum dolor sit lorem ipsum dolor sit lorem ipsum dolor sit ", "6 july 1994", Resource.Drawable.xamarin_logo));
                #endregion

                isDark = GetThemeStatePref();
                if (isDark)
                {
                    searchInput.SetBackgroundResource(Resource.Drawable.search_input_dark_style);
                    rootLayout.SetBackgroundColor(this.Resources.GetColor(Resource.Color.black));
                }
                else
                {
                    searchInput.SetBackgroundResource(Resource.Drawable.search_input_style);
                    rootLayout.SetBackgroundColor(this.Resources.GetColor(Resource.Color.white));
                }

                countryDataAdaper = new CountryDataAdaper(this, RowDataList, isDark);
                NewsRecyclerview.SetAdapter(countryDataAdaper);
                NewsRecyclerview.SetLayoutManager(new LinearLayoutManager(this));
            }
            catch (System.Exception ex)
            {

            }
        }

        private void SaveThemeStatePref(bool isDark)
        {

            ISharedPreferences pref = ApplicationContext.GetSharedPreferences("myPref", FileCreationMode.Private);
            ISharedPreferencesEditor editor = pref.Edit();
            editor.PutBoolean("isDark", isDark);
            editor.Commit();
        }

        private bool GetThemeStatePref()
        {

            ISharedPreferences pref = ApplicationContext.GetSharedPreferences("myPref", FileCreationMode.Private);
            bool isDark = pref.GetBoolean("isDark", false);
            return isDark;
        }


        public class FabClickLitner : Java.Lang.Object, View.IOnClickListener
        {
            private MainActivity mainActivity;

            public FabClickLitner(MainActivity parant)
            {
                this.mainActivity = parant;
            }

            public void Dispose()
            {
                // throw new NotImplementedException();
            }

            public void OnClick(View v)
            {


                mainActivity.isDark = !mainActivity.isDark;
                if (mainActivity.isDark)
                {

                    mainActivity.searchInput.SetBackgroundResource(Resource.Drawable.search_input_dark_style);
                    mainActivity.rootLayout.SetBackgroundColor(mainActivity.Resources.GetColor(Resource.Color.black));

                }
                else
                {
                    mainActivity.searchInput.SetBackgroundResource(Resource.Drawable.search_input_style);
                    mainActivity.rootLayout.SetBackgroundColor(mainActivity.Resources.GetColor(Resource.Color.white));
                }

                mainActivity.countryDataAdaper = new CountryDataAdaper(mainActivity, mainActivity.RowDataList, mainActivity.isDark);
                if (!string.IsNullOrEmpty(mainActivity.searchInput.ToString()))
                {

                    // countryDataAdaper.getFilter().filter(search);

                }
                // NewsRecyclerview.setAdapter(newsAdapter);
                mainActivity.SaveThemeStatePref(mainActivity.isDark);


            }
        }
    }
}

