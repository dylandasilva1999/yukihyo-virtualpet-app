using System;
using System.Collections.Generic;
using System.Text;

namespace yukihyo.Objects
{
    public enum HungerState
    {
        happy,
        neutral,
        sad
    }
    public class HungerStates
    {
        public static string GetHungerString(HungerState hungerState)
        {
            switch (hungerState)
            {
                case HungerState.happy:
                    return "happy";
                case HungerState.neutral:
                    return "neutral";
                case HungerState.sad:
                    return "sad";
                default:
                    return "happy";
            }
        }

        public static HungerState GetHungerState(string hungerString)
        {
            switch (hungerString)
            {
                case "happy":
                    return HungerState.happy;
                case "neutral":
                    return HungerState.neutral;
                case "sad":
                    return HungerState.sad;
                default:
                    return HungerState.happy;
            }
        }
    }
}
