using System.Collections.Generic;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace App8
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.Loaded += MainPage_Loaded;
        }

        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            List<Thing> Items = new List<Thing> {
                new Thing(1), new Thing(2), new Thing(4),
                new Thing(5), new Thing(3), new Thing(4),
                new Thing(6), new Thing(4), new Thing(6),
                new Thing(3)
            };

            List<IGrouping<int, Thing>> FinalItems = Items
                .OrderBy(a => a.Num)
                .GroupBy(a => a.Num)
                .ToList();

            MainList.ItemsSource = FinalItems;
        }
    }

    public class Thing
    {
        public Thing(int num) { Num = num; }
        public int Num { get; set; }
    }
}
