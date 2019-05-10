using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Богатов Максим 

//1.	Добавить космический корабль, как описано в уроке.
//2.	Доработать игру «Астероиды»:
//a.Добавить ведение журнала в консоль с помощью делегатов;
//b.  * добавить это и в файл.
//3.	Разработать аптечки, которые добавляют энергию.
//4.	Добавить подсчет очков за сбитые астероиды.


namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {

                Form form = new Form
                {
                    Width = Screen.PrimaryScreen.Bounds.Width,
                    Height = Screen.PrimaryScreen.Bounds.Height
                };
                Game.Init(form);
                form.Show();
                Game.Load();
                Game.Draw();
                Application.Run(form);


        }
    }
}
