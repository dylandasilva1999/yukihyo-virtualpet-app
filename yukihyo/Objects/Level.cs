using System;
using System.Collections.Generic;
using System.Text;

namespace yukihyo.Objects
{
    class Level
    {
        public static int GetLevelFromXp(int xp)
        {
            if (xp == 0)
            {
                return 0;
            }
            else if (xp < 1000)
            {
                return 1;
            }
            else if (xp >= 1000)
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }
    }
}
