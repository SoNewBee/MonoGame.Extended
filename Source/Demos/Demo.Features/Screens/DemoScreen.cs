using System;
using System.Linq;
using Microsoft.Xna.Framework;
using MonoGame.Extended;
using MonoGame.Extended.Gui;
using MonoGame.Extended.Gui.Controls;

namespace Demo.Features.Screens
{
    public class DemoScreen : GuiScreen
    {
        public DemoScreen(GuiSkin skin, Action onNextDemo)
            : base(skin)
        {
            var button = Skin.Create<GuiButton>("white-button", c =>
            {
                c.Position = new Vector2(670, 430);
                c.Size = new Size2(120, 42);
                c.Text = "Next Demo";
            });
            var canvas = new GuiCanvas
            {
                Controls = { button }
            };

            Controls.Add(canvas);
            button.Clicked += (sender, args) => onNextDemo();


        }

        public override void Initialize()
        {
            //var dialog = Skin.Create<GuiDialog>("dialog");

            //var stackPanel = new GuiStackPanel
            //{
            //    Controls =
            //    {
            //        Skin.Create<GuiLabel>("label", c =>
            //        {
            //            c.Text = "Are you sure you want to do that?";
            //            c.Margin = new Thickness(0, 20, 0, 0);
            //        }),
            //        Skin.Create<GuiLabel>("label", c =>
            //        {
            //            c.Text = "If you do you'll be in some serious trouble.";
            //        }),
            //        new GuiStackPanel
            //        {
            //            Orientation = GuiOrientation.Horizontal,
            //            VerticalAlignment = VerticalAlignment.Bottom,
            //            HorizontalAlignment = HorizontalAlignment.Centre,
            //            Controls =
            //            {
            //                Skin.Create<GuiButton>("white-button", c =>
            //                {
            //                    c.Text = "Yes";
            //                    c.Width = 100;
            //                    c.Margin = new Thickness(2);
            //                    c.Offset = new Vector2(0, 20);
            //                }),
            //                Skin.Create<GuiButton>("white-button", c =>
            //                {
            //                    c.Text = "No";
            //                    c.Width = 100;
            //                    c.Margin = new Thickness(2);
            //                    c.Offset = new Vector2(0, 20);
            //                })
            //            }
            //        }
            //    }
            //};

            //dialog.Controls.Add(stackPanel);
            //dialog.Controls.Add(Skin.Create<GuiLabel>("label", c =>
            //{
            //    c.Text = "Please confirm";
            //    c.VerticalAlignment = VerticalAlignment.Top;
            //    c.HorizontalAlignment = HorizontalAlignment.Centre;
            //    c.Offset = new Vector2(0, -30);
            //    c.BackgroundRegion = Skin.NinePatches.FirstOrDefault(i => i.Name == "progress-bar-blue");
            //}));
            //dialog.Controls.Add(Skin.Create<GuiButton>("close-button", c =>
            //{
            //    c.HorizontalAlignment = HorizontalAlignment.Right;
            //    c.VerticalAlignment = VerticalAlignment.Top;
            //    c.Offset = new Vector2(20, -20);
            //}));

            //dialog.Show(this);
        }
    }
}