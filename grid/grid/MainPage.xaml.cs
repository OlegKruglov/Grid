using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace grid
{
    public partial class MainPage : ContentPage
    {
        BoxView box;
        public MainPage()
        {
            Grid grid = new Grid
            {
                /*RowDefinitions =
                {

                    new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                    new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                    new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                    new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                    new RowDefinition{Height=new GridLength(1,GridUnitType.Star)}
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)},
                    new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)},
                    new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)},
                    new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)},
                    new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)}
                }*/
            };
            for (int i = 0; i < 3; i++)
            {
                grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    //box = new BoxView { Color = Color.Beige };
                    Image img = new Image { Source = ImageSource.FromFile("cross.png")};
                    grid.Children.Add(box, i, j);
                    var tap = new TapGestureRecognizer();
                    //tap.Tapped += Tap_Tapped;
                    img.GestureRecognizers.Add(tap);
                    tap.Tapped += async (object sender, EventArgs e) =>
                    {
                        //BoxView box = sender as BoxView;
                        //if (box.Color == new Color(0, 0, 0))
                        //{
                        //  box.Color = Color.Red;
                        //}
                        //else
                        //{
                        //  box.Color = new Color(0, 0, 0);
                        //}
                        Image img1 = sender as Image;
                        if (img1.Source == "cross") 
                        {
                            img1.Source = "cross";
                        }
                        else
                        {
                            img1.Source = "O";
                        }
                    };
                }
            }
            Content = grid;
        }
        //int tapValue = 0;


        /*private void Tap_Tapped(object sender, EventArgs e)
        {
            tapValue++;
            BoxView box = sender as BoxView;
            if (tapValue % 2 == 0)
            {
                box.Color = Color.Black;
            }
            else
            {
                box.Color = Color.Beige;
            }
        }*/
    }
}
