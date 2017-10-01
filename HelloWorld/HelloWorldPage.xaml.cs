using System.Collections.Generic;
using Xamarin.Forms;

namespace HelloWorld
{
    public partial class HelloWorldPage : ContentPage
    {
        private List<string> list;
        private int current = -1;

        public HelloWorldPage()
        {
            InitializeComponent();
            this.list = new List<string>();
            this.list.Add("People wo live in glass house... no throw hard crap.");
            this.list.Add("The real trouble with reality is that there's no background music.");
            this.list.Add("Going to church doesn't make you a Christian any more than standing in a garage makes you a car.");
            this.list.Add("War doesn't determine who's right. War determines who's left.");
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            if (++this.current == list.Count)
                this.current = 0;
            quote.Text = list[this.current];
        }
    }
}
