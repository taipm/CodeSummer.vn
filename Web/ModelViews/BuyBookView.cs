using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using CafeT.Text;

namespace Web.ModelViews
{
    public class BuyBookView : BaseView
    {
        public string BookTilte { set; get; }
        public string BookImageUrl { set; get; }
        public string BuyBookUrl { set; get; }

        public BuyBookView(string title, string url, string imageUrl)
        {
            BookTilte = title;
            BookImageUrl = imageUrl;
            BuyBookUrl = url;
        }
    }
}