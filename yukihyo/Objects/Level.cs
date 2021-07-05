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
            else if (xp >= 500 && xp < 500)
            {
                return 2;
            }
            else if (xp >= 500 && xp < 1000)
            {
                return 3;
            }
            else if (xp >= 1000 && xp < 1500)
            {
                return 4;
            }
            else if (xp >= 1500 && xp < 2000)
            {
                return 5;
            }
            else if (xp >= 2000 && xp < 2500)
            {
                return 6;
            }
            else if (xp >= 2500 && xp < 3000)
            {
                return 7;
            }
            else if (xp >= 3000 && xp < 3500)
            {
                return 8;
            }
            else if (xp >= 3500 && xp < 4000)
            {
                return 9;
            }
            else if (xp >= 4000 && xp < 4500)
            {
                return 10;
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
            else if (hungerXp < 100)
            {
                return 1;
            }
            else if (hungerXp >= 100 && hungerXp < 200)
            {
                return 2;
            }
            else if (hungerXp >= 200 && hungerXp < 300)
            {
                return 3;
            }
            else if (hungerXp >= 300 && hungerXp < 400)
            {
                return 4;
            }
            else if (hungerXp >= 400 && hungerXp < 500)
            {
                return 5;
            }
            else if (hungerXp >= 500 && hungerXp < 600)
            {
                return 6;
            }
            else if (hungerXp >= 600 && hungerXp < 700)
            {
                return 7;
            }
            else if (hungerXp >= 700 && hungerXp < 800)
            {
                return 8;
            }
            else if (hungerXp >= 800 && hungerXp < 900)
            {
                return 9;
            }
            else if (hungerXp >= 900 && hungerXp < 1000)
            {
                return 10;
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
            else if (habitatXp >= 100 && habitatXp < 200)
            {
                return 2;
            }
            else if (habitatXp >= 200 && habitatXp < 300)
            {
                return 3;
            }
            else if (habitatXp >= 300 && habitatXp < 400)
            {
                return 4;
            }
            else if (habitatXp >= 400 && habitatXp < 500)
            {
                return 5;
            }
            else if (habitatXp >= 500 && habitatXp < 600)
            {
                return 6;
            }
            else if (habitatXp >= 600 && habitatXp < 700)
            {
                return 7;
            }
            else if (habitatXp >= 700 && habitatXp < 800)
            {
                return 8;
            }
            else if (habitatXp >= 800 && habitatXp < 900)
            {
                return 9;
            }
            else if (habitatXp >= 900 && habitatXp < 1000)
            {
                return 10;
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
            else if (safetyXp >= 100 && safetyXp < 200)
            {
                return 2;
            }
            else if (safetyXp >= 200 && safetyXp < 300)
            {
                return 3;
            }
            else if (safetyXp >= 300 && safetyXp < 400)
            {
                return 4;
            }
            else if (safetyXp >= 400 && safetyXp < 500)
            {
                return 5;
            }
            else if (safetyXp >= 500 && safetyXp < 600)
            {
                return 6;
            }
            else if (safetyXp >= 600 && safetyXp < 700)
            {
                return 7;
            }
            else if (safetyXp >= 700 && safetyXp < 800)
            {
                return 8;
            }
            else if (safetyXp >= 800 && safetyXp < 900)
            {
                return 9;
            }
            else if (safetyXp >= 900 && safetyXp < 1000)
            {
                return 10;
            }
            else
            {
                return 0;
            }
        }
    }
}
