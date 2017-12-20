using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace RPGGame
{
    public class GameLogic
    {
        public FoxDraw MyFoxDraw { get; set; }
        Random random = new Random();

        public GameLogic(FoxDraw myFoxDraw)
        {
            MyFoxDraw = myFoxDraw;
        }



        public int CheckSameField(Character hero, List<Monster> monsterList)
        {
            for (int i = 0; i < monsterList.Count; i++)
            {
                if (monsterList[i].TileNumber == hero.TileNumber)
                {
                    return i;
                }
            }
            return -1;
        }

        internal bool Battle(Character hero, Monster monster, List<Monster> monsterList)
        {
            while (true)
            {
                Strike(hero, monster);
                if (monster.CurrentHP <= 0)
                {
                    MyFoxDraw.SetPosition(MyFoxDraw.Tiles[monster.CharacterId], 5000, 5000);
                    monsterList.Remove(monster);
                    hero.Level++;
                    return true;
                }
                Strike(monster, hero);
                if (hero.CurrentHP <= 0)
                { 
                    return false;
                }
            }
        }
        public void Strike(Character char1, Character char2)
        {
            int d6 = random.Next(1,7);
            int SV = char1.StrikePoint + 2 * d6;
            if (SV > char2.DefendPoint)
            {
                char2.CurrentHP -= (SV - char2.DefendPoint);
            }
        }
    }
}
