using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpieSetNS
{
    public class SharpieSet
    {
        public List<Sharpie> SharpieList { get; set; }

        public SharpieSet(List<Sharpie> sharpieList)
        {
            SharpieList = sharpieList;
        }

        public int CountUsable()
        {
            int usableCount = 0;
            foreach (Sharpie sharpie in SharpieList)
            {
                if (sharpie.InkAmount > 0)
                {
                    usableCount++;
                }
            }
            return usableCount;
        }

        public void RemoveTrash()
        {
            for (int i = 0; i < SharpieList.Count; i++)
            {
                if (SharpieList[i].InkAmount == 0)
                {
                    SharpieList.Remove(SharpieList[i]);
                }
            }
        }
    }
}
