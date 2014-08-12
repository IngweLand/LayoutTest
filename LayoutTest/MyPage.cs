// ///////////////////////////////////////////////////////////////////////////////
//
//    Author ILYA GOLOVACH (aka IngweLand)
//    http://ingweland.com
//    ingweland@gmail.com
//    2014
//
// ///////////////////////////////////////////////////////////////////////////////
using System;
using Xamarin.Forms;
using System.Collections.Generic;

namespace LayoutTest
{
    public class MyPage:ContentPage
    {
        public MyPage ()
        {
            Padding = 20;

            var list = new ListView ()
            {
                RowHeight = 100
            };

            list.ItemsSource = new TodoItem [] {
                new TodoItem {Name = "Lorem Ipsum is simply dummy text of "},
                new TodoItem {Name = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen bo"},
                new TodoItem {Name = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the ind"},
                new TodoItem {Name = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was "},
                new TodoItem {Name = "Lorem Ipsum is simply dummy text of the printing and typesettin"}
            };
            list.ItemTemplate = new DataTemplate(typeof(MyCell));

            Content = list;
        }
    }

    class TodoItem {
        public string Name { get; set; }
        public bool Done { get; set; }
    }
}

