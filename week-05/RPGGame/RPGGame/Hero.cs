using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace RPGGame
{
    public class Hero : Character
    {
        public Hero(int tileNumber, int d6) : base(  tileNumber)
        {
            ImageSource = "./Assets/hero-down.png";
            CurrentHP = 20 + 3 * d6;
            DefendPoint = 2 * d6;
            StrikePoint = 5 + d6;
            Level = 1;
            MaxHP = 15;
        }

        internal override void MoveDown(Area map, FoxDraw foxDraw)
        {
            foxDraw.Tiles[CharacterId].Source = new BitmapImage(new Uri("./Assets/hero-down.png", UriKind.Relative));
            base.MoveDown(map, foxDraw);
        }

        internal override void MoveLeft(Area map, FoxDraw foxDraw)
        {
            foxDraw.Tiles[CharacterId].Source = new BitmapImage(new Uri("./Assets/hero-left.png", UriKind.Relative));
            base.MoveLeft(map, foxDraw);
        }

        internal override void MoveRight(Area map, FoxDraw foxDraw)
        {
            foxDraw.Tiles[CharacterId].Source = new BitmapImage(new Uri("./Assets/hero-right.png", UriKind.Relative));
            base.MoveRight(map, foxDraw);
        }

        internal override void MoveUp(Area map, FoxDraw foxDraw)
        {
            foxDraw.Tiles[CharacterId].Source = new BitmapImage(new Uri("./Assets/hero-up.png", UriKind.Relative));
            base.MoveUp(map, foxDraw);
        }
    }
}
