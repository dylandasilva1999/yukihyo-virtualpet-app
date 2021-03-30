using System;
using System.Collections.Generic;
using System.Text;

namespace yukihyo.Objects
{
    public class Yukihyo
    {
        const string yukihyoNameKey = "yukihyoName";
        const string yukihyoStateKey = "yukihyoState";
        const string yukihyoXpKey = "yukihyoXp";

        const string yukihyoHungerXpKey = "yukihyoHungerXp";
        const string hungerStateKey = "hungerState";

        const string yukihyoHabitatXpKey = "yukihyoHabitatXp";
        const string habitatStateKey = "habitatState";

        const string yukihyoSafetyXpKey = "yukihyoSafetyXp";
        const string safetyStateKey = "safetyState";

        public Yukihyo()
        {

        }

        /*Yukihyo Name Function*/
        public string YukihyoName
        {
            get
            {
                if(App.Current.Properties.ContainsKey(yukihyoNameKey))
                {
                    return (string)App.Current.Properties[yukihyoNameKey];                
                } 
                else
                {
                    return "There is no name";
                }
            }
            set
            {
                App.Current.Properties[yukihyoNameKey] = value;
            }
        }

        /*Set Yukihyo State*/
        public YukihyoState CurrentYukihyoState
        {
            get
            {
                if (App.Current.Properties.ContainsKey(yukihyoStateKey))
                {
                    return YukihyoStates.GetYukihyoState((string)App.Current.Properties[yukihyoStateKey]);
                }
                else
                {
                    return YukihyoState.happy;
                }
            }

            set
            {
                App.Current.Properties[yukihyoStateKey] = YukihyoStates.GetYukihyoString(value);
            }
        }

        /*Set Overall Xp*/
        public int Xp
        {
            get
            {
                if (App.Current.Properties.ContainsKey(yukihyoXpKey))
                {
                    Console.WriteLine((int)App.Current.Properties[yukihyoXpKey]);
                    return (int)App.Current.Properties[yukihyoXpKey];
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                App.Current.Properties[yukihyoXpKey] = value;
            }
        }

        /*Set HungerXp*/
        public int HungerXp
        {
            get
            {
                if (App.Current.Properties.ContainsKey(yukihyoHungerXpKey))
                {
                    Console.WriteLine((int)App.Current.Properties[yukihyoHungerXpKey]);
                    return (int)App.Current.Properties[yukihyoHungerXpKey];
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                App.Current.Properties[yukihyoHungerXpKey] = value;
            }
        }

        /*Set Hunger State*/
        public HungerState CurrentHungerState
        {
            get
            {
                if (App.Current.Properties.ContainsKey(hungerStateKey))
                {
                    return HungerStates.GetHungerState((string)App.Current.Properties[hungerStateKey]);
                }
                else
                {
                    return HungerState.happy;
                }
            }

            set
            {
                App.Current.Properties[hungerStateKey] = HungerStates.GetHungerState(value);
            }
        }

        /*Set HabitatXp*/
        public int HabitatXp
        {
            get
            {
                if (App.Current.Properties.ContainsKey(yukihyoHabitatXpKey))
                {
                    Console.WriteLine((int)App.Current.Properties[yukihyoHabitatXpKey]);
                    return (int)App.Current.Properties[yukihyoHabitatXpKey];
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                App.Current.Properties[yukihyoHabitatXpKey] = value;
            }
        }

        /*Set Habitat State*/
        public HabitatState CurrentHabitatState
        {
            get
            {
                if (App.Current.Properties.ContainsKey(habitatStateKey))
                {
                    return HabitatStates.GetHabitatState((string)App.Current.Properties[habitatStateKey]);
                }
                else
                {
                    return HabitatState.happy;
                }
            }

            set
            {
                App.Current.Properties[habitatStateKey] = HabitatStates.GetHabitatState(value);
            }
        }

        /*Set SafetyXp*/
        public int SafetyXp
        {
            get
            {
                if (App.Current.Properties.ContainsKey(yukihyoSafetyXpKey))
                {
                    Console.WriteLine((int)App.Current.Properties[yukihyoSafetyXpKey]);
                    return (int)App.Current.Properties[yukihyoSafetyXpKey];
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                App.Current.Properties[yukihyoSafetyXpKey] = value;
            }
        }

        /*Set Safety State*/
        public SafetyState CurrentSafetyState
        {
            get
            {
                if (App.Current.Properties.ContainsKey(safetyStateKey))
                {
                    return SafetyStates.GetSafetyState((string)App.Current.Properties[safetyStateKey]);
                }
                else
                {
                    return SafetyState.happy;
                }
            }

            set
            {
                App.Current.Properties[safetyStateKey] = SafetyStates.GetSafetyState(value);
            }
        }

        /*Feed Yukihyo*/
        public void giveFood()
        {
            HungerXp = HungerXp + 100;
            Xp = Xp + 300 + HungerXp;
        }

        /*Habitat Yukihyo*/
        public void changeTemp()
        {
            HabitatXp = HabitatXp + 100;
            Xp = Xp + 300 + HabitatXp;
        }

        /*Safety Yukihyo*/
        public void catchPoacher()
        {
            SafetyXp = SafetyXp + 100;
            Xp = Xp + 300 + SafetyXp;
        }

        /*Attention Yukihyo*/
        public void giveAttention()
        {
            Xp = Xp + 200;
        }

        /*Start Xp*/
        public void startXp()
        {
            Xp = Xp + 150;
        }

        /*Reduce Hunger*/
        public void Cease()
        {
            if (HungerXp > 0)
            {
                HungerXp = HungerXp - 5;
            }
            else
            {
                HungerXp = 0;
            }
        }

        /*Reduce Habitat*/
        public void Heat()
        {
            if (HabitatXp > 0)
            {
                HabitatXp = HabitatXp - 5;
            }
            else
            {
                HabitatXp = 0;
            }
        }

        /*Reduce Safety*/
        public void Unsafe()
        {
            if (SafetyXp > 0)
            {
                SafetyXp = SafetyXp - 5;
            }
            else
            {
                SafetyXp = 0;
            }
        }
    }
}
