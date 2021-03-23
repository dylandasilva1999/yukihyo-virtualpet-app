using System;
using System.Collections.Generic;
using System.Text;

namespace yukihyo.Objects
{
    public class Level
    {
        public static int GetLevelFromXp(int xp)
        {
            if (xp == 0)
            {
                return 0;
            }
            else if (xp < 3000)
            {
                return 1;
            }
            else if (xp >= 3000)
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }

        public static int GetHungerLevelFromXp(int hungerXp)
        {
            if (hungerXp == 0)
            {
                return 0;
            }
            else if (hungerXp < 1500)
            {
                return 1;
            }
            else if (hungerXp >= 1500)
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }

        public static int GetHabitatLevelFromXp(int habitatXp)
        {
            if (habitatXp == 0)
            {
                return 0;
            }
            else if (habitatXp < 1500)
            {
                return 1;
            }
            else if (habitatXp >= 1500)
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }

        public static int GetSafetyLevelFromXp(int safetyXp)
        {
            if (safetyXp == 0)
            {
                return 0;
            }
            else if (safetyXp < 1500)
            {
                return 1;
            }
            else if (safetyXp >= 1500)
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
