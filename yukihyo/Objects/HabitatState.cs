using System;
using System.Collections.Generic;
using System.Text;

namespace yukihyo.Objects
{
    public enum HabitatState
    {
        happy,
        neutral,
        sad
    }
    public class HabitatStates
    {
        public static string GetHabitatString(HabitatState habitatState)
        {
            switch (habitatState)
            {
                case HabitatState.happy:
                    return "happy";
                case HabitatState.neutral:
                    return "neutral";
                case HabitatState.sad:
                    return "sad";
                default:
                    return "happy";
            }
        }

        public static HabitatState GetHabitatState(string habitatString)
        {
            switch (habitatString)
            {
                case "happy":
                    return HabitatState.happy;
                case "neutral":
                    return HabitatState.neutral;
                case "sad":
                    return HabitatState.sad;
                default:
                    return HabitatState.happy;
            }
        }
    }
}
