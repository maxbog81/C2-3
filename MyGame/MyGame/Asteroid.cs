using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MyGame
{
    class Asteroid : BaseObject, ICloneable, IComparable<Asteroid>
    {
        public int Power { get; set; } = 3; // Начиная с версии C# 6.0 была добавлена инициализация автосвойств

        public Asteroid(Point pos, Point dir, Size size) : base(pos, dir, size)
        {
            Power = 1;
        }

        public object Clone()
        {
            // Создаем копию нашего робота
            Asteroid asteroid = new Asteroid(new Point(Pos.X, Pos.Y), new Point(Dir.X, Dir.Y),
                new Size(Size.Width, Size.Height))
            { Power = Power };
            // Не забываем скопировать новому астероиду Power нашего астероида
            return asteroid;
        }
        public override void Draw()
        {
            Game.Buffer.Graphics.FillEllipse(Brushes.White, Pos.X, Pos.Y, Size.Width, Size.Height);
        }

        public override void Update()
        {
            Pos.X = Pos.X + Dir.X;
            if (Pos.X < 0) Pos.X = Game.Width + Size.Width;

        }

        int IComparable<Asteroid>.CompareTo(Asteroid obj)
        {
            if (Power > obj.Power)
                return 1;
            if (Power < obj.Power)
                return -1;
            return 0;
        }

        //int IComparable.CompareTo(object obj)
        //{
        //    if (obj is Asteroid temp)
        //    {
        //        if (Power > temp.Power)
        //            return 1;
        //        if (Power < temp.Power)
        //            return -1;
        //        else
        //            return 0;
        //    }
        //    throw new ArgumentException("Parameter is not а Asteroid!");
        //}
    }

}
