using System;
using System.Collections.Generic;
using System.Text;

namespace yukihyo.Objects
{
    public enum YukihyoState
    {
        happy,
        neutral,
        sad
    }
    public class YukihyoStates
    {
        public static string GetYukihyoString(YukihyoState yukihyoState)
        {
            switch (yukihyoState)
            {
                case YukihyoState.happy:
                    return "happy";
                case YukihyoState.neutral:
                    return "neutral";
                case YukihyoState.sad:
                    return "sad";
                default:
                    return "happy";
            }
        }

        public static YukihyoState GetYukihyoState(string yukihyoString)
        {
            switch (yukihyoString)
            {
                case "happy":
                    return YukihyoState.happy;
                case "neutral":
                    return YukihyoState.neutral;
                case "sad":
                    return YukihyoState.sad;
                default:
                    return YukihyoState.happy;
            }
        }
    }
}
