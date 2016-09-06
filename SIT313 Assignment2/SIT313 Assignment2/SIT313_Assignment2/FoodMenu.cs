using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace SIT313_Assignment2
{
    public class FoodMenu : ContentPage
    {
        public FoodMenu()
        {
            List<ImageCell> imgCells = new List<ImageCell>();

            Label header = new Label
            {
                Text = "ImageCell",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center
            };

            TableView tableView = new TableView
            {
                Intent = TableIntent.Form,
                Root = new TableRoot
                {
                    new TableSection
                    {
                       new List<ImageCell>(


                                                   new ImageCell
                        {
                            // Some differences with loading images in initial release.
                            ImageSource =
                                Device.OnPlatform(ImageSource.FromUri(new Uri("http://xamarin.com/images/index/ide-xamarin-studio.png")),
                                                  ImageSource.FromFile("friedrice"),
                                                  ImageSource.FromFile("Images/fried")),
                            Text = "Fried Rice",
                            Detail = "This is some detail text",



                        },

                        new ImageCell
                        {
                            // Some differences with loading images in initial release.
                            ImageSource =
                                Device.OnPlatform(ImageSource.FromUri(new Uri("http://xamarin.com/images/index/ide-xamarin-studio.png")),
                                                  ImageSource.FromFile("rnc"),
                                                  ImageSource.FromFile("Images/rnc")),
                            Text = "Rice and curry",
                            Detail = "This is some detail text",
                        }


                           )

                    }
                }
            };

            // Accomodate iPhone status bar.
            this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

            // Build the page.
            this.Content = new StackLayout
            {
                Children =
                {
                    header,
                    tableView
                }
            };
        }
    }
}
