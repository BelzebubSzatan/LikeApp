using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Like
{
    public partial class MainPage : ContentPage
    {
        private uint likeCounter = 0;
        public MainPage()
        {
            InitializeComponent();
        }
        public void LikeButtonClick(object sender,EventArgs args)
        {
            likeCounter++;
            Likes.Text = likeCounter.ToString() + " Likes";
        }
        public void DisLikeButtonClick(object sender, EventArgs args)
        {
            if (likeCounter == 0) return;
            likeCounter--;
            Likes.Text = likeCounter.ToString()+" Likes";
        }
    }
}
