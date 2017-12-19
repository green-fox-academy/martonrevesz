using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    public class Skeleton : Monster
    {
        public static int SkeletonCount = 0;

        public int SkeletonId { get; set; }
        public bool HasTheKey { get; set; } = false;

        public Skeleton(int gameLevel, int TileNumber, int d6) : base(gameLevel, TileNumber, d6)
        {
            ImageSource = "./Assets/skeleton.png";
            SkeletonId = SkeletonCount;
            if (SkeletonId == 0)
            {
                HasTheKey = true;
            }
            SkeletonCount++;
        }
    }
}
