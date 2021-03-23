using System;
using System.Collections.Generic;
using System.Text;

namespace yukihyo.Objects
{
    public enum SafetyState
    {
        happy,
        neutral,
        sad
    }
    public class SafetyStates
    {
        public static string GetSafetyString(SafetyState safetyState)
        {
            switch (safetyState)
            {
                case SafetyState.happy:
                    return "happy";
                case SafetyState.neutral:
                    return "neutral";
                case SafetyState.sad:
                    return "sad";
                default:
                    return "happy";
            }
        }

        public static SafetyState GetSafetyState(string safetyString)
        {
            switch (safetyString)
            {
                case "happy":
                    return SafetyState.happy;
                case "neutral":
                    return SafetyState.neutral;
                case "sad":
                    return SafetyState.sad;
                default:
                    return SafetyState.happy;
            }
        }
    }
}
