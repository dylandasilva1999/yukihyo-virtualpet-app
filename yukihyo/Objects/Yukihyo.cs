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
        const string yukihyoHungerXpKey = "yukihyoXp";
        const string yukihyoHabitatXpKey = "yukihyoXp";
        const string yukihyoSafetyXpKey = "yukihyoXp";
        const string hungerStateKey = "hungerState";
        const string habitatStateKey = "hungerState";
        const string safetyStateKey = "hungerState";

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
                    return YukihyoStates.GetTurtleState((string)App.Current.Properties[yukihyoStateKey]);
                }
                else
                {
                    return YukihyoState.happy;
                }
            }

            set
            {
                App.Current.Properties[yukihyoStateKey] = YukihyoStates.GetTurtleString(value);
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
                App.Current.Properties[hungerStateKey] = HungerStates.GetHungerString(value);
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
                App.Current.Properties[habitatStateKey] = HabitatStates.GetHabitatString(value);
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
                App.Current.Properties[safetyStateKey] = SafetyStates.GetSafetyString(value);
            }
        }

        /*Feed Yukihyo*/
        public void giveFood()
        {
            Xp = Xp + 300;
        }

        /*Habitat Yukihyo*/
        public void changeTemp()
        {
            Xp = Xp + 300;
        }

        /*Habitat Yukihyo*/
        public void catchPoacher()
        {
            Xp = Xp + 300;
        }
    }
}
