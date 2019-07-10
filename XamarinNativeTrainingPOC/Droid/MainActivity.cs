using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.Widget;
using System.Collections.Generic;
using Android.Support.Constraints;
using Android.Runtime;
using XamarinNativeTrainingPOC.Droid.Adapters;
using Android.Content;
using XamarinNativeTrainingPOC.Services.Interfaces;
using XamarinNativeTrainingPOC.Models;
using XamarinNativeTrainingPOC.ViewModels;
using System.Threading.Tasks;

namespace XamarinNativeTrainingPOC.Droid
{
    [Activity(Label = "XamarinNativeTrainingPOC", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        public ConadaDataViewModel ConadaDataViewModel { get; set; }
        RecyclerView NewsRecyclerview;
        ConstraintLayout rootLayout;
        // FloatingActionButton fabSwitcher;

        //NewsAdapter newsAdapter;
        //List<NewsItem> mData;

        CountryDataAdaper countryDataAdaper;




        bool isDark = false;

        EditText searchInput;

        protected override void OnStart()
        {
            base.OnStart();
            
        }

        private async Task LoadViewModel()
        {
            if (ConadaDataViewModel == null) ;
               
        }

        protected async override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            try
            {
                ConadaDataViewModel = new ConadaDataViewModel();
                await ConadaDataViewModel.ExecuteLoadItemsCommand();
                RequestWindowFeature(Android.Views.WindowFeatures.NoTitle);
                SetContentView(Resource.Layout.Layout1);

                rootLayout = FindViewById<ConstraintLayout>(Resource.Id.root_layout);
                searchInput = FindViewById<EditText>(Resource.Id.search_input);
                NewsRecyclerview = FindViewById<RecyclerView>(Resource.Id.news_rv);


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

                isDark = getThemeStatePref();
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

                countryDataAdaper = new CountryDataAdaper(this, ConadaDataViewModel.Items.CountryData, isDark);
                NewsRecyclerview.SetAdapter(countryDataAdaper);
                NewsRecyclerview.SetLayoutManager(new LinearLayoutManager(this));

            }
            catch (System.Exception ex)
            {

            }
        }

        private void saveThemeStatePref(bool isDark)
        {

            ISharedPreferences pref = ApplicationContext.GetSharedPreferences("myPref", FileCreationMode.Private);
            ISharedPreferencesEditor editor = pref.Edit();
            editor.PutBoolean("isDark", isDark);
            editor.Commit();
        }

        private bool getThemeStatePref()
        {

            ISharedPreferences pref = ApplicationContext.GetSharedPreferences("myPref", FileCreationMode.Private);
            bool isDark = pref.GetBoolean("isDark", false);
            return isDark;

        }


    }
}

