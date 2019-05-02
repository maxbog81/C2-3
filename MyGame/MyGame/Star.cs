using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MyGame
{
    class Star : BaseObject
    {
        Image image;
        public Star(Point pos, Point dir, Size size) : base(pos, dir, size)
        {
            image = new Bitmap(@"..\..\Star.jpg");
        }

        public override void Draw()
        {
            //Game.Buffer.Graphics.DrawLine(Pens.White, Pos.X, Pos.Y, Pos.X + Size.Width, Pos.Y + Size.Height);
            //Game.Buffer.Graphics.DrawLine(Pens.White, Pos.X + Size.Width, Pos.Y, Pos.X, Pos.Y + Size.Height);

            // Draw the image unaltered with its upper-left corner at (0, 0).
            Game.Buffer.Graphics.DrawImage(image, Pos.X, Pos.Y);
        }

        public override void Update()
        {
            Pos.X = Pos.X + Dir.X;
            if (Pos.X < 0) Pos.X = Game.Width + Size.Width;
        }


    }

}
