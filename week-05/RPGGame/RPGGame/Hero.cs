using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace RPGGame
{
    class Hero : Character
    {
        public Hero(string name, int tileNumber) : base(name,  tileNumber)
        {
            ImageSource = "./Assets/hero-down.png";
        }

        internal override void MoveDown(Map map, FoxDraw foxDraw)
        {
            foxDraw.Tiles[CharacterId].Source = new BitmapImage(new Uri("./Assets/hero-down.png", UriKind.Relative));
            base.MoveDown(map, foxDraw);
        }

        internal override void MoveLeft(Map map, FoxDraw foxDraw)
        {
            foxDraw.Tiles[CharacterId].Source = new BitmapImage(new Uri("./Assets/hero-left.png", UriKind.Relative));
            base.MoveLeft(map, foxDraw);
        }

        internal override void MoveRight(Map map, FoxDraw foxDraw)
        {
            foxDraw.Tiles[CharacterId].Source = new BitmapImage(new Uri("./Assets/hero-right.png", UriKind.Relative));
            base.MoveRight(map, foxDraw);
        }

        internal override void MoveUp(Map map, FoxDraw foxDraw)
        {
            foxDraw.Tiles[CharacterId].Source = new BitmapImage(new Uri("./Assets/hero-up.png", UriKind.Relative));
            base.MoveUp(map, foxDraw);
        }
    }
}
