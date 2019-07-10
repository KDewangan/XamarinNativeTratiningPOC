using System;
namespace XamarinNativeTrainingPOC.Droid
{
    public class NewsItem
    {


        //String title, content, date;
        //int userPhoto;
        public string Title { get; set; }
        public string Content { get; set; }
        public string Date { get; set; }
        public int UserPhoto { get; set; }

        public NewsItem()
        {
        }

        

        public NewsItem(String title, String content, String date, int userPhoto)
        {
            this.Title = title;
            this.Content = content;
            this.Date = date;
            this.UserPhoto = userPhoto;
        }

    }
}
