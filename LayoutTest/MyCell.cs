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

namespace LayoutTest
{
    public class MyCell:ViewCell
    {
        private const int PADDING = 10;

        public MyCell ()
        {
            var box = new BoxView
            {
                Color = Color.Blue,
                WidthRequest = 60,
                HeightRequest = 60,
            };

            var lbl = new Label ();
            lbl.SetBinding(Label.TextProperty, "Name");

            var box2 = new BoxView
            {
                Color = Color.Red,
                WidthRequest = 30,
                HeightRequest = 30,
            };

            var viewLayout = new RelativeLayout ();

            viewLayout.Children.Add(
                box,
                Constraint.Constant(PADDING),
                Constraint.RelativeToParent((parent) => { return (parent.Height - box.Height)/2; })
            );

            viewLayout.Children.Add(
                lbl,
                Constraint.RelativeToView(box, (parent, sibling) => { return sibling.X + sibling.Width + PADDING; }),
                Constraint.Constant(PADDING/2),
                Constraint.RelativeToParent(
                    (parent) => { return parent.Width - box.Width - box2.Width - PADDING*4; })
            );

            viewLayout.Children.Add(
                box2,
                Constraint.RelativeToParent((parent) => { return parent.Width - box2.Width - PADDING; }),
                Constraint.Constant(PADDING)
            );
            View = viewLayout;
        }
    }
}

